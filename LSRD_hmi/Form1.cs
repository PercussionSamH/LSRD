//Library includes
using EasyModbus;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;


namespace LSRD_hmi
{

    public partial class Form1 : Form
    {
        // -----Debug----- 
        public static bool DEBUG_MODE = false; //turn on to enable debug mode

        //IP address
        static string PLC_IP = "10.104.5.184"; static int port = 502;
        public ModbusClient modbusClient = new ModbusClient(PLC_IP, port);

        //Bit ranges
        bool[] QX_Coils; //QX0.0 - QX...
        int QX_length = 100; //total # of vars

        //Settings
        public static bool enabled_doorman = true;
        public static bool enabled_drawing = true;
        public static bool enabled_scavenger = true;

        //Login
        public static bool login_menu_open = false;
        public bool login = false;

        public static bool wave_scheduled = false;
        public static int wave_t_start = 0;
        public static int wave_t_end = 0;
        public static string wave_t_string = null;
        public static int wave_duration = 0;

        //Google cal events
        public static List<string> Event_strings = new List<string>();
        public static List<string> Event_times = new List<string>();
        public static DateTime t_event_start;
        public static DateTime t_event_end;

        //io bits
        public static bool demo_idle = true;
        public static bool demo_active_drawing = false;
        public static bool demo_active_doorman = false;
        public static bool demo_active_scavenger = false;
        public static bool demo_active_wave = false;
        
        //Process bits

        //Cancel
        public static bool cancel_active_demo = false; //[TODO:] hold this to true until robot at home, then set idle
       
        //User confirm
        public static bool drawing_paper_in_place = false;
        public static bool door_next_step = false;
        //Selections
        public static byte B_fish_selection;
        public static byte B_room_selection;
        public static byte B_flag_selection;
        public static byte B_first_initial;
        public static byte B_last_initial;

        

        public Form1()
        {

            InitializeComponent();
            
            this.FormBorderStyle = FormBorderStyle.None; // Removes borders and title bar
            this.WindowState = FormWindowState.Maximized;

            // -------- DEBUG VISIBILITY --------
            debug_wave_active.Visible = DEBUG_MODE;
            debug_wave_scheduled.Visible = DEBUG_MODE;
            PB_Quit_Program.Visible = DEBUG_MODE;
            test_textbox.Visible = DEBUG_MODE;
            label_resolution.Visible = DEBUG_MODE;
            label_scaling.Visible = DEBUG_MODE;
            label_formsize.Visible = DEBUG_MODE;
            label_formsize2.Visible = DEBUG_MODE;
            label_formsize3.Visible = DEBUG_MODE;
            //-------------------------------------

            //Login "popup" screen
            login_panel.Visible = false; //Show popup
            login_panel.Location = new Point(282, 150);

            try
            {
                System.Diagnostics.Debug.WriteLine("\nConnecting to " + PLC_IP + " on port " + port);
                modbusClient.Connect();

                System.Diagnostics.Debug.WriteLine("Connected!!\n");

                //start timer for push/pull sync
                timer_Modbus_Com.Enabled = true;

                //read initial QX vars
                QX_Coils = modbusClient.ReadCoils(0, QX_length); //read all variables off of PLC

                Get_Calendar_Events();

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("\nConnection to " + PLC_IP + " on port " + port + " failed...");
                System.Diagnostics.Debug.WriteLine("ERROR: ", ex.Message);
                //throw;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            float widthRatio = Screen.PrimaryScreen.Bounds.Width / 1024f;
            float heightRatio = Screen.PrimaryScreen.Bounds.Height / 600f;
            SizeF scale = new SizeF(widthRatio, heightRatio);
            this.Scale(scale);
            foreach (Control control in this.Controls)
            {
                control.Font = new Font("Verdana", control.Font.SizeInPoints * heightRatio * widthRatio);
            }
            foreach (Control ctrl in login_panel.Controls)
            {
                // Access existing size
                float currentSize = ctrl.Font.Size;
                // Set new size (e.g., 12pt)
                ctrl.Font = new Font("Verdana", ctrl.Font.SizeInPoints * heightRatio * widthRatio);
            }

            //Debug screen resolutions
            if (DEBUG_MODE)
            {
                try { label_resolution.Text = "Screen bounds detected: " + Screen.PrimaryScreen.Bounds.Width + "," + Screen.PrimaryScreen.Bounds.Height; }
                catch { }

                try { label_formsize2.Text = "Form preferredSize:" + Form.ActiveForm.PreferredSize; }
                catch { }

                try { label_formsize3.Text = "Form size: " + Form.ActiveForm.Width + "," + Form.ActiveForm.Height; }
                catch { }

                try { label_formsize.Text = "Form ClientSize is currently:" + Form.ActiveForm.ClientSize.Width + "," + Form.ActiveForm.ClientSize.Height + "\n"; }
                catch { }

                try { label_scaling.Text = "Scaling = " + scale; }
                catch { }
            }    
            // I HAVE FINALLY TRACKED DOWN THE SCALING ISSUE FOR FORMS
            // the forms must be set to AutoScaleMode = None
            // for some reason it by default will set this to Font as the scaling method
            // it will literally scale the whole diplay, form width and height, picture size, and anything else by whatever the current font size is for Form.Font
            
        }


        //Update all bits onto PLC
        //Modbus clock update rate = 10ms
        private void timer_Modbus_Com_Tick(object sender, EventArgs e)
        {
            timer_Modbus_Com.Enabled = false; //prevents multiple timer signals per read
            modbusClient.ConnectionTimeout = 5000;
            //Fetch all inputs
            QX_Coils = modbusClient.ReadCoils(0, QX_length);

            if (DEBUG_MODE)
            {
                test_textbox.Text = string.Join(" ", QX_Coils.Select(b => b.ToString()));
            }

            //Set all individual outputs, see google sheet for full list
            modbusClient.WriteSingleCoil(10, demo_idle);
            modbusClient.WriteSingleCoil(11, demo_active_drawing);
            modbusClient.WriteSingleCoil(12, demo_active_doorman);
            modbusClient.WriteSingleCoil(13, demo_active_scavenger);
            modbusClient.WriteSingleCoil(14, demo_active_wave); //Wave should be active

            modbusClient.WriteSingleCoil(20, cancel_active_demo);
            modbusClient.WriteSingleCoil(22, drawing_paper_in_place);
            modbusClient.WriteSingleCoil(23, door_next_step);


            //Reenable timer
            timer_Modbus_Com.Enabled = true;
        }
        
        //Check for Wave triggered
        //This function runs every tick (10/sec)
        private void tmr_update_vars_Tick(object sender, EventArgs e)
        {
            tmr_update_vars.Enabled = false;
            //Check for wave demo
            int c_t_min = DateTime.Now.Minute + (60 * DateTime.Now.Hour); //curent time in minutes

            if (DEBUG_MODE)
            {   
                debug_wave_active.Text = "wave active: " + demo_active_wave.ToString();
                debug_wave_scheduled.Text = "wave scheduled: " + wave_scheduled.ToString();
            }
            DateTime t_now = DateTime.Now;
            DateTime t_10_min = t_now.AddMinutes(10);
            DateTime t_event_pre = t_event_start.AddMinutes(5);
            DateTime t_event_post = t_event_end.AddMinutes(10);
            //check if a wave is manually scheuled
            if (((c_t_min >= wave_t_start && c_t_min < wave_t_end && wave_t_end >= wave_t_start) //normal case
                 ^ (c_t_min <= wave_t_start && c_t_min > wave_t_end && wave_t_end < wave_t_start) //past midnight (the ^ is an XOR)
               ) && wave_scheduled)
            {
                start_wave_demo();
            }
            else //if an event is scheduled
            {
                //This could be a single if statement but the mess of having a 4 line if condidition makes it hardly readable
                if (((t_event_start <= t_10_min) && (t_event_pre > t_now)) //10 minutes before an event til 5 minutes after start
                   || ((t_event_end < t_10_min) && (t_event_post > t_now))) //10 minutes after event ends til 10 minutes after)
                {
                    start_wave_demo();
                }
                else //no event active
                {
                    if (demo_active_wave) wave_scheduled = false;
                    demo_active_wave = false;
                    demo_idle = true;
                }
            }
            tmr_update_vars.Enabled = true; //reenable timer

        }

        private void start_wave_demo()
        {
            if (demo_idle)
            {
                wave_scheduled = false;
                demo_idle = false;
                demo_active_wave = true;
            }
        }

        //Old tests
        private void PB_Draw_Fish1_Click(object sender, EventArgs e)
        {
            //QX_Coils[16] = true; //set 2.0
            modbusClient.WriteSingleCoil(16, true);
        
        }
        private void PB_Draw_Square_Click(object sender, EventArgs e)
        {
            //QX_Coils[17] = true; //set 2.1
            modbusClient.WriteSingleCoil(17, true);
        } 


        private void PB_doorman_mode_Click(object sender, EventArgs e)
        {
            if (enabled_doorman == true)
            {
                //Open new window
                Get_Calendar_Events(); //fetch events
                Form_doorman form_doorman = new Form_doorman();
                form_doorman.ShowDialog();
                form_doorman = null;
            }
        }


        private async void Get_Calendar_Events()
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("Trying to read events");
                string[] Scopes = { CalendarService.Scope.CalendarReadonly };
                string ApplicationName = "Calendar Export";

                UserCredential credential;

                string credPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "credentials.json");
                System.Diagnostics.Debug.WriteLine("Trying to fetch credentials...");
                using (var stream = new FileStream(credPath, FileMode.Open, FileAccess.Read))
                {
                    credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.FromStream(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore("token.json", true));
                }
                System.Diagnostics.Debug.WriteLine("Credentials found\n");
                var service = new CalendarService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                // Request events
                var request = service.Events.List("primary");
                request.TimeMin = DateTime.Now;
                request.ShowDeleted = false;
                request.SingleEvents = true;
                request.MaxResults = 50;
                request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

                var events = request.Execute().Items;

                ////For writing to a .txt file
                //System.Diagnostics.Debug.WriteLine("Getting File path");
                //string downloadsPath = Path.Combine(
                //Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                //"Downloads");
                //System.Diagnostics.Debug.WriteLine("filepath at: " + downloadsPath);
                //string outputPath = Path.Combine(downloadsPath, "calendar_events.txt");
                //System.Diagnostics.Debug.WriteLine("outputPath at: " + outputPath);
                //using (StreamWriter writer = new StreamWriter(outputPath))
                Event_strings.Clear();
                {
                    if (events != null && events.Count > 0)
                    {
                        int i = 0; //event number
                        foreach (var ev in events)
                        {
                            string title = ev.Summary ?? "No Title";
                            string description = ev.Description ?? "No Description";
                            if (i==0)
                            {
                                DateTime t10 = t_event_end.AddMinutes(10);
                                if (t10 < DateTime.Now)
                                {
                                    t_event_start = DateTime.Parse(ev.Start.DateTimeDateTimeOffset.ToString());
                                    t_event_end = DateTime.Parse(ev.End.DateTimeDateTimeOffset.ToString());
                                }
                                
                            }         
                            //if (DEBUG_MODE) System.Diagnostics.Debug.WriteLine("event found with name: " + title);

                            Event_strings.Add(title + "\n\r" + description);
                            i++;
                        }
                    }
                    else
                    {
                        //writer.WriteLine("No upcoming events found.");
                        System.Diagnostics.Debug.WriteLine("No events found :(");
                        Event_strings.Add("No upcoming events");

                    }
                }

                //Optional message box for confirmation
                //MessageBox.Show("Export complete!", "Success",
                //MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                //Optional message box for confirmation
                //MessageBox.Show(ex.Message, "Error",
                //MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine("An error occured with exception:" + ex);
            }
        }


        private void PB_drawing_mode_Click(object sender, EventArgs e)
        {
            if (enabled_drawing == true)
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
                form2 = null;
            }

        }

        private void PB_Quit_Program_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PB_staff_controls_Click(object sender, EventArgs e)
        {
            //old popup system
            //Form_Pass_popup form_Settings_Popup = new Form_Pass_popup();
            //form_Settings_Popup.ShowDialog();
            
            login_panel.Visible = true; //Show popup
            login_menu_open = true; //disable other buttons underneath
            text_entry_pass.Focus();
            //Initializations
            login = false;
            text_wrong_pass.Visible = false;
            text_entry_pass.Text = string.Empty;

        }


        private void PB_Back_To_Home_Click(object sender, EventArgs e)
        {
            login_panel.Visible=false;
            text_wrong_pass.Visible = false;
            login_menu_open = false;
        }

        public void PB_confirm_pass_Click(object sender, EventArgs e)
        {
            login_check();
        }

        public void login_check()
        {
            if (text_entry_pass.Text == "lsrd")
            {
                login_panel.Visible = false;
                text_entry_pass.Text = string.Empty;
                Form_Settings form_Settings = new Form_Settings();
                form_Settings.ShowDialog();

                //get vars from menu
                enabled_doorman = form_Settings.enabled_doorman;
                enabled_drawing = form_Settings.enabled_drawing;
                enabled_scavenger = form_Settings.enabled_scavenger;

                wave_t_start = form_Settings.wave_time_start;
                wave_t_end = form_Settings.wave_time_end;
                wave_scheduled = form_Settings.wave_scheduled;
                wave_t_string = form_Settings.wave_time_string;
                wave_duration = form_Settings.wave_duration;

                //sets button graphics to enable/disabled
                PB_doorman_mode.Image = (enabled_doorman) ? LSRD_hmi.Properties.Resources.PB_gray_doorman_demo : LSRD_hmi.Properties.Resources.PB_disabled_doorman;
                PB_drawing_mode.Image = (enabled_drawing) ? LSRD_hmi.Properties.Resources.PB_gray_Drawing_demo : LSRD_hmi.Properties.Resources.PB_disabled_drawing;
                PB_scavenger_mode.Image = (enabled_scavenger) ? LSRD_hmi.Properties.Resources.PB_gray_Scavenger_hunt : LSRD_hmi.Properties.Resources.PB_disabled_scavenger;
                form_Settings = null;

                
            }
            else
            {
                text_wrong_pass.Visible = true;
            }
        }

        private void Pass_popup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                login_check();
            }
        }

        private void PB_scavenger_mode_Click(object sender, EventArgs e)
        {
            if (enabled_scavenger == true)
            {
                //Form2 form2 = new Form2();
                //form2.ShowDialog();
                //form2 = null;
            }
        }





    }
}
