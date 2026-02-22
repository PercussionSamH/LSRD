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
    public partial class Form_Settings : Form
    {
        public Form_Settings()
        {
            //Initializations
            this.FormBorderStyle = FormBorderStyle.None; // Removes borders and title bar
            this.WindowState = FormWindowState.Maximized;

            InitializeComponent();
        }

        private void PB_Back_To_Home_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
