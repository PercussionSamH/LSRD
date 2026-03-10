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
        //public Form1 _opener; //pointer back to form 1
        //public String[] Event_strings;
        public List<string> Event_strings = new List<string>();

        public Form_doorman()
        {
            //Initializations
            this.FormBorderStyle = FormBorderStyle.None; // Removes borders and title bar
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();

            //Upcoming events container

            //fetch events
            
            //Event_text = new String[] {"","","",""};
            Get_Calendar_Events();
            //Propage events
            for (int i = 0; i < Event_strings.Count; i++)
            {
                Label b = new Label();
                b.Text = Event_strings[i]; //sets text
                b.Font = new Font(b.Font.FontFamily, 12, b.Font.Style); //font and text size
                b.AutoSize = true;
                b.BorderStyle = BorderStyle.FixedSingle;
                b.Margin = new Padding(5, 5, 5, 5);
                
                Scrollable_Events_Box.Controls.Add(b); //add each item to list
            }

        }

    
        private void Form_doorman_Load(object sender, EventArgs e)
        {

        }

        private void PB_Back_To_Home_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PB_door_work_cafe_Click(object sender, EventArgs e)
        {
            Form_door_work_cafe form_Door_Work_Cafe= new Form_door_work_cafe();
            form_Door_Work_Cafe.ShowDialog();
        }

        private void PB_door_seminar_room_Click(object sender, EventArgs e)
        {
            Form_door_seminar_room form_Door_Seminar_Room = new Form_door_seminar_room();
            form_Door_Seminar_Room.ShowDialog();
        }

        private void PB_door_discovery_lab_Click(object sender, EventArgs e)
        {
            Form_door_discovery_lab form_Door_Discovery_Lab = new Form_door_discovery_lab();
            form_Door_Discovery_Lab.ShowDialog();
        }
        private void PB_door_partner_suites_Click(object sender, EventArgs e)
        {
            Form_door_partner_suites form_Door_Partner_Suites = new Form_door_partner_suites();
            form_Door_Partner_Suites.ShowDialog();
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
    }
}
