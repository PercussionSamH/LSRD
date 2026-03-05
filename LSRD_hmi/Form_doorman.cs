using LSRD_hmi.Room_popups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace LSRD_hmi
{
    public partial class Form_doorman : Form
    {
        //Global vars
        //public Form1 _opener; //pointer back to form 1

      
        public Form_doorman()
        {
            //Initializations
            this.FormBorderStyle = FormBorderStyle.None; // Removes borders and title bar
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();

            //Upcoming events container

            //fetch events ((fix))
            String[] Event_text = { "Event #1, Room 111, fish people thing thing thing thing", "Event #2, Room 110, fish people", "Event #3000","Event 4000","1000100100","Event #22, Room 131, fish people thing thing thing thing"};

            //Propage events
            for (int i = 0; i < Event_text.Length; i++)
            {
                Label b = new Label();
                b.Text = Event_text[i]; //sets text
                b.Font = new Font(b.Font.FontFamily, 12, b.Font.Style); //font and text size
                b.AutoSize = true;
                b.BorderStyle = BorderStyle.FixedSingle;
                b.Margin = new Padding(5, 5, 5, 5);
                
                
                
                Scrollable_Events_Box.Controls.Add(b); //add each item to list
            }

            ////Rich text boxes
            ////-------  #1 Upstairs room -------
            //richtext_room1.SelectionIndent = 5;
            ////text_area1.SelectionRightIndent = 5;

            //richtext_room1.SelectionColor = Color.Black;

            //richtext_room1.SelectionIndent = 10;
            //richtext_room1.SelectionFont = new Font(richtext_room1.Font.FontFamily, 10f);
            //richtext_room1.AppendText("Test test test" + "\r\n");

            ////-------  #2 Upstairs room -------
            //richtext_room2.SelectionIndent = 10;
            //richtext_room2.SelectionRightIndent = 10;


        }

    
        private void Form_doorman_Load(object sender, EventArgs e)
        {

        }

        private void PB_Back_To_Home_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PB_area_upstairs_class_Click(object sender, EventArgs e)
        {
            Form_area_up_class form_Area_Up_Class = new Form_area_up_class();
            form_Area_Up_Class.ShowDialog();
        }
    }
}
