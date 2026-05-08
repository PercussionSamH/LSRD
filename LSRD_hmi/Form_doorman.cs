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


namespace LSRD_hmi
{
    public partial class Form_doorman : Form
    {
        //Global vars
        public string[] Room_names = {"Discovery Lab", "Partner Suites", "Seminar Room", "Work Cafe"};
        public Dictionary<string, string> Room_Desc = new Dictionary<string, string>();
        public string room_selection = null;
        public bool popup_open = false;
        public Form_doorman()
        {
            //Initializations
            this.FormBorderStyle = FormBorderStyle.None; // Removes borders and title bar
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            Hide_Popup(); //make sure popup with directions is hidden

            //Using a dictionary mostly to keep the code legible for long blocks of text
            Room_Desc.Add(Room_names[0], "• Classroom \r\n• Conference Room\r\n");
            Room_Desc.Add(Room_names[1], "• Faculty Offices\r\n• USCG Great Lakes Oil Spill \r\n   Center of Expertise\r\n• Michigan Sea Grant\r\n• HeadWaters North \r\n");
            Room_Desc.Add(Room_names[2], "• Classroom\r\n• Conference Room\r\n");
            Room_Desc.Add(Room_names[3], "• Reception\r\n •Faculty and Administative\r\n  Offices\r\n• Conference Room 110\r\n• All deliveries \r\n");

            //default to work cafe
            PB_door_work_cafe_Click(this, new EventArgs());


            //Propagate events
            for (int i = 0; i < Form1.Event_strings.Count; i++)
            {
                
                
                RichTextBox b = new RichTextBox();
                b.AutoSize = false;
                
                b.Height = b.PreferredHeight;
                
                b.Font = new Font("Verdana", 12, b.Font.Style); //font and text size

                
                b.MinimumSize = new Size(326, 10);



                //b.Size = new Size(326,b.PreferredHeight);
                b.BorderStyle = BorderStyle.FixedSingle;
                b.Margin = new Padding(5, 8, 5, 5);
                
                
                //Select the first line
                b.SelectionStart = 0;

                b.ScrollBars = 0;
                b.Text = Form1.Event_strings[i]; //sets text

                b.ContentsResized += (sender, e) => {
                    RichTextBox rtb = (RichTextBox)sender;
                    // Add a little padding to prevent scrollbars (e.g., + 10)
                    rtb.Height = e.NewRectangle.Height + 10;
                };


                Scrollable_Events_Box.Controls.Add(b); //add each item to list
            }

            //set room desc position
            lbl_room_info_back.Location = new Point(Scrollable_Events_Box.Location.X, Scrollable_Events_Box.Location.Y);
            lbl_room_info.Location = new Point(Scrollable_Events_Box.Location.X+((Scrollable_Events_Box.Width-lbl_room_info.Width)/2), 170);
            button_events_Click(this , new EventArgs());


        }

    
        private void Form_doorman_Load(object sender, EventArgs e)
        {
            if (Form1.ENABLE_SCALING)
            {
                float widthRatio = Screen.PrimaryScreen.Bounds.Width / 1024f;
                float heightRatio = Screen.PrimaryScreen.Bounds.Height / 600f;
                SizeF scale = new SizeF(widthRatio, heightRatio);
                this.Scale(scale);
                foreach (Control control in this.Controls)
                {
                    control.Font = new Font("Verdana", control.Font.SizeInPoints * heightRatio * widthRatio / 1);
                }
            }

        }

        private void PB_Back_To_Home_Click(object sender, EventArgs e)
        {
            if (popup_open == false)
            {
                Close();
            }
        }

        // Buttons
    
        private void PB_door_work_cafe_Click(object sender, EventArgs e)
        {
            if (popup_open == false)
            {
                room_selection = "Work Cafe";
                lbl_room_info.Text = "\t" + room_selection + "\n\r" + Room_Desc[room_selection];
                button_room_info_Click(this, new EventArgs());
            }
            
        }
        private void PB_door_seminar_room_Click(object sender, EventArgs e)
        {
            if (popup_open == false)
            {
                room_selection = "Seminar Room";
                lbl_room_info.Text = "\t" + room_selection + "\n\r" + Room_Desc[room_selection];
                button_room_info_Click(this, new EventArgs());
            }
        }
        private void PB_door_discovery_lab_Click(object sender, EventArgs e)
        {
            if (popup_open == false)
            {
                room_selection = "Discovery Lab";
                lbl_room_info.Text = "\t" + room_selection + "\n\r" + Room_Desc[room_selection];
                button_room_info_Click(this, new EventArgs());
            }
        }
        private void PB_door_partner_suites_Click(object sender, EventArgs e)
        {
            if (popup_open == false)
            {
                room_selection = "Partner Suites";
                lbl_room_info.Text = "\t" + room_selection + "\n\r" + Room_Desc[room_selection];
                button_room_info_Click(this, new EventArgs());
            }

            
        }




        private void button_events_Click(object sender, EventArgs e)
        {
            if (popup_open == false)
            {
                button_room_info.SendToBack();
                button_events.BackColor = Color.White;
                button_room_info.BackColor = Color.LightGray;
                Scrollable_Events_Box.Visible = true;
                lbl_room_info.Visible = false;
                lbl_room_info_back.Visible = false;
            }
        }

        private void button_room_info_Click(object sender, EventArgs e)
        {

            button_events.SendToBack();
            button_room_info.BackColor = Color.White;
            button_events.BackColor = Color.LightGray;
            Scrollable_Events_Box.Visible = false;
            lbl_room_info.Visible = true;
            lbl_room_info_back.Visible = true;
        }

        private void PB_get_directions_Click(object sender, EventArgs e)
        {
            Show_Popup();         
        }

        private void Show_Popup()
        {
            popup_open = true;
            popup_back.Visible = true;
            popup_border.Visible = true;
            popup_pb_close.Visible = true;
            popup_pb_enter.Visible = true;
            popup_text.Visible = true;
            popup_title.Visible = true;
            popup_title.BringToFront();
            popup_text.BringToFront();
            popup_pb_close.BringToFront();
            popup_pb_enter.BringToFront();
            //public string[] Room_names = { "Discovery Lab", "Partner Suites", "Seminar Room", "Work Cafe" };
            //launch popups

            popup_title.Text = room_selection;
            if (room_selection == Room_names[0])//Discovery_Lab
            {
                popup_text.Text = "--sample--\n" +
                    "Facing towards the discovery center, take the door forward and to your left\n" +
                    "go up the stairs and to the left\n";

            }
            else if (room_selection == Room_names[1])//Partner_Suites
            {
                popup_text.Text = "--sample--\n" +
                    "Partner_Suites Facing towards the discovery center, take the door forward and to your left\n" +
                    "go up the stairs and to the left\n";
            }
            else if (room_selection == Room_names[2])//Seminar_Room
            {
                popup_text.Text = "--sample--\n" +
                   "Seminar_Room Facing towards the discovery center, take the door forward and to your left\n" +
                   "go up the stairs and to the left\n";

            }
            else if (room_selection == Room_names[3]) //Work_Cafe
            {
                popup_text.Text = "--sample--\n" +
                     "Work_Cafe Facing towards the discovery center, take the door forward and to your left\n" +
                     "go up the stairs and to the left\n";
            }
        }
        private void Hide_Popup()
        {
            popup_open = false;

            popup_title.Visible = false;
            popup_text.Visible = false;
            popup_pb_close.Visible = false;
            popup_pb_enter.Visible = false;
            popup_border.Visible = false;
            popup_back.Visible = false;


        }

        private void popup_pb_close_Click(object sender, EventArgs e)
        {
            Hide_Popup();
        }
    }
}
