using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void Form_doorman_Load(object sender, EventArgs e)
        {

        }

        private void PB_Goto_Screen_Main_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
