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
    public partial class Form2 : Form
    {
        //Global vars
        int fish_selection = 0;
        //int backgnd_selection = 0;
        int margin = 20;

        string[] fish_names = {"Lake Sturgeon","Atlantic Salmon","Sea Lamprey","Zoo Plankton","Mayfly Nymph"};
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

            //Using a dictionary mostly to keep the code legible for long blocks of text
            D_fish_tag.Add("Lake Sturgeon", "A living fossil of the Great Lakes");
            D_fish_tag.Add("Atlantic Salmon", "Raised right here");
            D_fish_tag.Add("Sea Lamprey", "An ancient invader");
            D_fish_tag.Add("Zoo Plankton", "Tiny drifters with a big role");
            D_fish_tag.Add("Mayfly Nymph", "A sign of clean water");
  
            D_fish_desc.Add("Lake Sturgeon", "Lake sturgeon can live for more than 100 years.");
            D_fish_desc.Add("Atlantic Salmon", "Originally from the Atlantic coast, the Atlantic salmon are now a popular Great Lakes sport fish.");
            D_fish_desc.Add("Sea Lamprey", "This jawless fish attaches to other fish with a suction-cup mouth and feeds on them.");
            D_fish_desc.Add("Zoo Plankton", "Zooplankton—small animals like this daphnia—float through freshwater feeding on algae.");
            D_fish_desc.Add("Mayfly Nymph", "Mayflies spend most of their lives underwater as nymphs.");

            D_fish_desc2.Add("Lake Sturgeon", "Lake sturgeon also have whisker-like barbels to search the river bottom for food.");
            D_fish_desc2.Add("Atlantic Salmon", "Each year, CFRE raises thousands for release into the St. Marys River.");
            D_fish_desc2.Add("Sea Lamprey", "In the Great Lakes, scientists work to control sea lamprey.");
            D_fish_desc2.Add("Zoo Plankton", "They are an important food source for many young fish.");
            D_fish_desc2.Add("Mayfly Nymph", "Finding them in a stream or river usually means the water is healthy.");


            //Load initial fish image, text and descs
            Fish_preview_picture.Image = fish_pictures[fish_selection];
            Label_Fish_Type_Text.Text = fish_names[fish_selection];
            Fish_tagline.Text = D_fish_tag[fish_names[fish_selection]];
            Fish_desc.Text = D_fish_desc[fish_names[fish_selection]];
            Fish_desc2.Text = D_fish_desc2[fish_names[fish_selection]];

        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
            Close();
        }
    }
}
