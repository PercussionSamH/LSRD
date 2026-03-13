using LSRD_hmi.Room_popups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;


namespace LSRD_hmi
{
    public partial class Form_doorman : Form
    {
        //Global vars
        public List<string> Event_strings = new List<string>();
        public string[] Room_names = {"Discovery Lab", "Partner Suites", "Seminar Room", "Work Cafe"};
        public Dictionary<string, string> Room_Desc = new Dictionary<string, string>();
        public string room_selection = null;
        public Form_doorman()
        {
            //Initializations
            this.FormBorderStyle = FormBorderStyle.None; // Removes borders and title bar
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();

            //Upcoming events container

            //fetch events
            Get_Calendar_Events();

            //Using a dictionary mostly to keep the code legible for long blocks of text
            Room_Desc.Add(Room_names[0], "• Classroom (course number?)\r\n• Conference Room\r\n");
            Room_Desc.Add(Room_names[1], "• Faculty Offices\r\n• USCG Great Lakes Oil Spill \r\n   Center of Expertise\r\n• Michigan Sea Grant\r\n• HeadWaters North \r\n");
            Room_Desc.Add(Room_names[2], "• Classroom\r\n• Conference Room\r\n");
            Room_Desc.Add(Room_names[3], "• Reception\r\n •Faculty and Administative\r\n  Offices\r\n• Conference Room 110\r\n• All deliveries \r\n");

            //default to work cafe
            PB_door_work_cafe_Click(this, new EventArgs());


            //Propagate events
            for (int i = 0; i < Event_strings.Count; i++)
            {
                Label b = new Label();
                b.Text = Event_strings[i]; //sets text
                b.Font = new Font(b.Font.FontFamily, 12, b.Font.Style); //font and text size
                b.MinimumSize = new Size(230,0);
                b.BorderStyle = BorderStyle.FixedSingle;
                b.Margin = new Padding(5, 8, 5, 5);
                b.AutoSize = true;

                Scrollable_Events_Box.Controls.Add(b); //add each item to list
            }

            //set room desc position
            lbl_room_info_back.Location = new Point(Scrollable_Events_Box.Location.X, Scrollable_Events_Box.Location.Y);
            lbl_room_info.Location = new Point(Scrollable_Events_Box.Location.X+((Scrollable_Events_Box.Width-lbl_room_info.Width)/2), 155);
            button_events_Click(this , new EventArgs());


        }

    
        private void Form_doorman_Load(object sender, EventArgs e)
        {

        }

        private void PB_Back_To_Home_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Buttons
    
        private void PB_door_work_cafe_Click(object sender, EventArgs e)
        {
            room_selection = "Work Cafe";
            lbl_room_info.Text = "\t" + room_selection + "\n\r" + Room_Desc[room_selection];
            button_room_info_Click(this, new EventArgs());
        }
        private void PB_door_seminar_room_Click(object sender, EventArgs e)
        {
            room_selection = "Seminar Room";
            lbl_room_info.Text = "\t" + room_selection + "\n\r" + Room_Desc[room_selection];
            button_room_info_Click(this, new EventArgs());
        }
        private void PB_door_discovery_lab_Click(object sender, EventArgs e)
        {
            room_selection = "Discovery Lab";
            lbl_room_info.Text = "\t" + room_selection + "\n\r" + Room_Desc[room_selection];
            button_room_info_Click(this, new EventArgs());
        }
        private void PB_door_partner_suites_Click(object sender, EventArgs e)
        {
            room_selection = "Partner Suites";
            lbl_room_info.Text = "\t" + room_selection + "\n\r" + Room_Desc[room_selection];
            button_room_info_Click(this, new EventArgs());
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
                System.Diagnostics.Debug.WriteLine("Credentials found");
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

                {
                    if (events != null && events.Count > 0)
                    {
                        int i = 0; //event number
                        foreach (var ev in events)
                        {                    
                            string title = ev.Summary ?? "No Title";
                            string description = ev.Description ?? "No Description";
                            //string time_s = ev.

                            System.Diagnostics.Debug.WriteLine("event found with name: " + title);
                            Event_strings.Add(title +"\n\r"+ description);
                            //writer.WriteLine($"Title: {title}");
                            //writer.WriteLine($"Description: {description}");
                            //writer.WriteLine(new string('-', 40));
                            
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
                System.Diagnostics.Debug.WriteLine("An error occured with exception:"+ex);
            }
        }

        private void button_events_Click(object sender, EventArgs e)
        {
            button_events.BringToFront();
            button_events.BackColor = Color.White;
            button_room_info.BackColor = Color.LightGray;
            Scrollable_Events_Box.Visible = true;
            lbl_room_info.Visible = false;
            lbl_room_info_back.Visible = false;

        }

        private void button_room_info_Click(object sender, EventArgs e)
        {
            button_room_info.BringToFront();
            button_room_info.BackColor = Color.White;
            button_events.BackColor = Color.LightGray;
            Scrollable_Events_Box.Visible = false;
            lbl_room_info.Visible = true;
            lbl_room_info_back.Visible = true;
        }

        private void PB_get_directions_Click(object sender, EventArgs e)
        {
            //public string[] Room_names = { "Discovery Lab", "Partner Suites", "Seminar Room", "Work Cafe" };
            //launch popups
            if (room_selection== Room_names[0])
            {
                Form_door_discovery_lab form_Door_Discovery_Lab = new Form_door_discovery_lab();
                form_Door_Discovery_Lab.ShowDialog();
            }
            else if (room_selection == Room_names[1])
            {
                Form_door_partner_suites form_Door_Partner_Suites = new Form_door_partner_suites();
                form_Door_Partner_Suites.ShowDialog();
            }
            else if (room_selection == Room_names[2])
            {
                Form_door_seminar_room form_Door_Seminar_Room = new Form_door_seminar_room();
                form_Door_Seminar_Room.ShowDialog();
            }
            else if (room_selection == Room_names[3])
            {
                Form_door_work_cafe form_Door_Work_Cafe = new Form_door_work_cafe();
                form_Door_Work_Cafe.ShowDialog();
            }          
        }
    }
}
