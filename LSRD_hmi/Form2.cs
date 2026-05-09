using EasyModbus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;


namespace LSRD_hmi
{

    public partial class Form2 : Form
    {
        //Global vars
        int fish_selection = 0;
        public static bool DEBUG_MODE = false; //turn on to enable debug mode
        int margin = 20;
        bool isPopup_open = false;
        string[] fish_names = {"Lake Sturgeon","Atlantic Salmon","Sea Lamprey","Zooplankton","Mayfly Nymph"};
        Image[] fish_pictures = {LSRD_hmi.Properties.Resources.Lake_Sturgeon_250_180, LSRD_hmi.Properties.Resources.Atlantic_Salmon_250_180, LSRD_hmi.Properties.Resources.Sea_Lamprey_250_180, LSRD_hmi.Properties.Resources.Zooplankton_250_180, LSRD_hmi.Properties.Resources.Mayfly_nymph_250_180};

        public Dictionary<string, string> D_fish_tag = new Dictionary<string, string>();
        public Dictionary<string, string> D_fish_desc = new Dictionary<string, string>();
        public Dictionary<string, string> D_fish_desc2 = new Dictionary<string, string>();

        public Form2()
        {
            //Initializations
            //this.FormBorderStyle = FormBorderStyle.None; // Removes borders and title bar
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            drawing_in_progress.Visible = false;
            
            //Using a dictionary mostly to keep the code legible for long blocks of text
            D_fish_tag.Add("Lake Sturgeon", "A living fossil of the Great Lakes");
            D_fish_tag.Add("Atlantic Salmon", "Raised right here");
            D_fish_tag.Add("Sea Lamprey", "An ancient invader");
            D_fish_tag.Add("Zooplankton", "Tiny drifters with a big role");
            D_fish_tag.Add("Mayfly Nymph", "A sign of clean water");

            D_fish_desc.Add("Lake Sturgeon", "Lake sturgeon can live for more than 100 years.\n ");
            D_fish_desc.Add("Atlantic Salmon", "Originally from the Atlantic coast, the Atlantic salmon are now a popular Great Lakes sport fish.\n ");
            D_fish_desc.Add("Sea Lamprey", "This jawless fish attaches to other fish with a suction-cup mouth and feeds on them.\n ");
            D_fish_desc.Add("Zooplankton", "Zooplankton—small animals like this daphnia—float through freshwater feeding on algae.\n ");
            D_fish_desc.Add("Mayfly Nymph", "Mayflies spend most of their lives underwater as nymphs.\n ");

            D_fish_desc2.Add("Lake Sturgeon", "Lake sturgeon also have whisker-like barbels to search the river bottom for food.\n \n \n");
            D_fish_desc2.Add("Atlantic Salmon", "Each year, CFRE raises thousands for release into the St. Marys River.\n \n");
            D_fish_desc2.Add("Sea Lamprey", "In the Great Lakes, scientists work to control sea lamprey.\n \n");
            D_fish_desc2.Add("Zooplankton", "They are an important food source for many young fish.\n \n");
            D_fish_desc2.Add("Mayfly Nymph", "Finding them in a stream or river usually means the water is healthy.\n \n");


            //Load initial fish image, text and descs
            Fish_preview_picture.Image = fish_pictures[fish_selection];
            Label_Fish_Type_Text.Text = fish_names[fish_selection];
            
            Fish_tagline.Text = D_fish_tag[fish_names[fish_selection]];
            Fish_desc.Text = D_fish_desc[fish_names[fish_selection]];
            Fish_desc2.Text = D_fish_desc2[fish_names[fish_selection]];
            Fish_desc2.Location = new Point(Fish_desc2.Location.X, Fish_desc.Location.Y + Fish_desc.Size.Height + margin);
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            isPopup_open = false;
            put_yo_paper.Visible = false;
            take_fish.Visible = false;

            drawingactive.Visible = DEBUG_MODE;
            modoutput.Visible = DEBUG_MODE;
            if (Form1.ENABLE_SCALING)
            {
                float widthRatio = Screen.PrimaryScreen.Bounds.Width / 1024f;
                float heightRatio = Screen.PrimaryScreen.Bounds.Height / 600f;
                SizeF scale = new SizeF(widthRatio, heightRatio);
                this.Scale(scale);
                foreach (Control control in this.Controls)
                {
                    control.Font = new Font("Verdana", control.Font.SizeInPoints * heightRatio * widthRatio);
                }
            }
                
            Fish_tagline.Font = new Font(Fish_tagline.Font, FontStyle.Italic);
            drawingactive.Text = $"{GlobalData.demo_active_drawing}";
            modoutput.Text = $"{GlobalData.sturgeon} {GlobalData.sturgeon} " +
                $"{GlobalData.sturgeon} {GlobalData.sturgeon} {GlobalData.sturgeon}";
        }

  
        private void PB_fish_select_right_Click(object sender, EventArgs e)
        {
            fish_selection += 1;
            if (fish_selection >= fish_names.Length)
            {
                fish_selection = 0;
            }

            //change title
            Label_Fish_Type_Text.Text = fish_names[fish_selection];
            
            //change image
            Fish_preview_picture.Image = fish_pictures[fish_selection];

            //change tag
            Fish_tagline.Text = D_fish_tag[fish_names[fish_selection]];
            Fish_desc.Text = D_fish_desc[fish_names[fish_selection]];
            Fish_desc2.Location = new Point(Fish_desc2.Location.X, Fish_desc.Location.Y + Fish_desc.Size.Height + margin);
            Fish_desc2.Text = D_fish_desc2[fish_names[fish_selection]];
        }

        private void PB_fish_select_left_Click(object sender, EventArgs e)
        {
            fish_selection -= 1;
            if (fish_selection < 0)
            {
                fish_selection = fish_names.Length-1;
            }
            

            //change title
            Label_Fish_Type_Text.Text = fish_names[fish_selection];

            //change image
            Fish_preview_picture.Image = fish_pictures[fish_selection];

            //change tag and description
            Fish_tagline.Text = D_fish_tag[fish_names[fish_selection]];
            Fish_desc.Text = D_fish_desc[fish_names[fish_selection]];
            Fish_desc2.Location = new Point(Fish_desc2.Location.X, Fish_desc.Location.Y + Fish_desc.Size.Height + margin);
            Fish_desc2.Text = D_fish_desc2[fish_names[fish_selection]];
        }

        private void PB_Back_To_Home_Click(object sender, EventArgs e)
        {
            if (take_fish.Visible == false && isPopup_open == false)
            {
                Close();
                GlobalData.demo_active_drawing = false;
            }
            
        }

        private  void PB_drawing_mode_Click(object sender, EventArgs e)
        {
            if (take_fish.Visible == false)
            {
                isPopup_open = true;
                put_yo_paper.Visible = true;
            }

        }

        private async void popup_pb_confirm_Click(object sender, EventArgs e)
        {
            put_yo_paper.Visible = false;

            //sets the popup while drawing


            drawing_in_progress.Visible = true;
            
            drawing_in_progress.BringToFront();


            drawing_in_progress.Width = this.Width; drawing_in_progress.Height = this.Height;
            drawing_in_progress.Location = new Point(0, 0);
            fish_drawn_border.Size = new Size(pictureBox2.Width+13, pictureBox2.Height+13);
            pictureBox2.Location = new Point((drawing_in_progress.Width - pictureBox2.Width) / 2, (drawing_in_progress.Height - pictureBox2.Height) / 2);
            fish_drawn_border.Location = new Point((drawing_in_progress.Width - fish_drawn_border.Width) / 2, (drawing_in_progress.Height - fish_drawn_border.Height) / 2);
            
            label2.Location = new Point((drawing_in_progress.Width - label2.Width) / 2, pictureBox2.Location.Y + pictureBox2.Height + margin);
            pictureBox2.Image = fish_pictures[fish_selection];

            take_fish.Visible = true;


            //turn on the selected fish for the drawing
            if (fish_selection == 0)
            {
                fishon(0);
                update_debug();
                wait(1000);
                fishoff();
                update_debug();
            }
            if (fish_selection == 1)
            {
                fishon(1);
                update_debug();
                wait(1000);
                fishoff();
                update_debug();
            }
            if (fish_selection == 2)
            {
                fishon(2);
                update_debug();
                wait(1000);
                fishoff();
                update_debug();
            }
            if (fish_selection == 3)
            {
                fishon(3);
                update_debug();
                wait(1000);
                fishoff();
                update_debug();
            }
            if (fish_selection == 4)
            {
                fishon(4);
                update_debug();
                wait(1000);
                fishoff();
                update_debug();
            }

            //set the left initial and waits for robot to finish it
            GlobalData.left = true;
            GlobalData.alphabet[Convert.ToChar(domainUpDown1.SelectedItem)] = true;
            while (!GlobalData.check1)
            {
                await Task.Delay(100);
            }
            GlobalData.left = false;
            GlobalData.alphabet[Convert.ToChar(domainUpDown1.SelectedItem)] = false;
            GlobalData.alphabet[Convert.ToChar(domainUpDown2.SelectedItem)] = true;

            while (!GlobalData.check2)
            {
                await Task.Delay(100);
            }

            drawing_in_progress.Visible = false;

            GlobalData.alphabet[Convert.ToChar(domainUpDown2.SelectedItem)] = false;

        }
        public void fishoff()
        {
            GlobalData.sturgeon = false;
            GlobalData.salmon = false;
            GlobalData.lamprey = false;
            GlobalData.plankton = false;
            GlobalData.nymph = false;
        }
        public void update_debug()
        {
            modoutput.Text = $"{GlobalData.sturgeon} {GlobalData.salmon} " +
                $"{GlobalData.lamprey} {GlobalData.plankton} {GlobalData.nymph}";
        }
        public void fishon(int i)
        {
            GlobalData.sturgeon = (i == 0);
            GlobalData.salmon = (i == 1);
            GlobalData.lamprey = (i == 2);
            GlobalData.plankton = (i == 3);
            GlobalData.nymph = (i == 4);
        }
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void popup_pb_close_Click(object sender, EventArgs e)
        {
            put_yo_paper.Visible = false;
            isPopup_open = false;
        }


        private void pb_confirm_take_Click_1(object sender, EventArgs e)
        {
            take_fish.Visible = false;
            isPopup_open = false;
            isPopup_open = false;
        }
    }
}