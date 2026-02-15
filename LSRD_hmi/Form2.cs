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
        public Form1 _opener; //pointer back to form 1

        int fish_selection = 0;
        int backgnd_selection = 0;
        string[] fish_names = {"Lake Sturgeon","Atlantic Salmon","Sea Lamprey","Zoo Plankton","Mayfly Nymph"};
        Image[] fish_pictures = {LSRD_hmi.Properties.Resources.Lake_Sturgeon_250_180, LSRD_hmi.Properties.Resources.Atlantic_Salmon_250_180, LSRD_hmi.Properties.Resources.Sea_Lamprey_250_180, LSRD_hmi.Properties.Resources.Zooplankton_250_180, LSRD_hmi.Properties.Resources.Mayfly_nymph_250_180};
        public Form2()
        {
            //Initializations
            this.FormBorderStyle = FormBorderStyle.None; // Removes borders and title bar
            this.WindowState = FormWindowState.Maximized;            
            InitializeComponent();

            Fish_preview_picture.Image = fish_pictures[fish_selection];
            Label_Fish_Type_Text.Text = fish_names[fish_selection];

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void PB_Screen_Main_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PB_fish_select_right_Click(object sender, EventArgs e)
        {
            fish_selection += 1;
            if (fish_selection >= fish_names.Length)
            {
                fish_selection = 0;
            }
            Fish_preview_picture.Image = fish_pictures[fish_selection];
            Label_Fish_Type_Text.Text = fish_names[fish_selection];

        }

        private void PB_fish_select_left_Click(object sender, EventArgs e)
        {
            fish_selection -= 1;
            if (fish_selection < 0)
            {
                fish_selection = fish_names.Length-1;
            }
            Fish_preview_picture.Image = fish_pictures[fish_selection];
            Label_Fish_Type_Text.Text = fish_names[fish_selection];
        }
    }
}
