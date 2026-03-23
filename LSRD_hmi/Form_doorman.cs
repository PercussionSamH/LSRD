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




namespace LSRD_hmi
{
    public partial class Form_doorman : Form
    {
        //Global vars
        
        public string[] Room_names = {"Discovery Lab", "Partner Suites", "Seminar Room", "Work Cafe"};
        public Dictionary<string, string> Room_Desc = new Dictionary<string, string>();
        public string room_selection = null;
        public Form_doorman()
        {
            //Initializations
            this.FormBorderStyle = FormBorderStyle.None; // Removes borders and title bar
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();


            //Using a dictionary mostly to keep the code legible for long blocks of text
            Room_Desc.Add(Room_names[0], "• Classroom (course number?)\r\n• Conference Room\r\n");
            Room_Desc.Add(Room_names[1], "• Faculty Offices\r\n• USCG Great Lakes Oil Spill \r\n   Center of Expertise\r\n• Michigan Sea Grant\r\n• HeadWaters North \r\n");
            Room_Desc.Add(Room_names[2], "• Classroom\r\n• Conference Room\r\n");
            Room_Desc.Add(Room_names[3], "• Reception\r\n •Faculty and Administative\r\n  Offices\r\n• Conference Room 110\r\n• All deliveries \r\n");

            //default to work cafe
            PB_door_work_cafe_Click(this, new EventArgs());


            //Propagate events
            for (int i = 0; i < Form1.Event_strings.Count; i++)
            {
                Label b = new Label();
                b.Text = Form1.Event_strings[i]; //sets text
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
