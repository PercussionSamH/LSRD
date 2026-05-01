using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;






//------------- UNUSED BECUASE POPUP FORMS MAKE THE APPLICATION CRASH ON THE PI -------------------





namespace LSRD_hmi
{
    public partial class Form_Pass_popup : Form
    {
        public bool login;


        //Rounded form corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        //end rounded corners

        public Form_Pass_popup()
        {
            //Initializations
            this.FormBorderStyle = FormBorderStyle.None; // Removes borders and title bar
            //this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            login = false;

            InitializeComponent();

            //rounded form corners call
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            text_wrong_pass.Visible = false;
            
        }

        private void PB_Back_To_Home_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        public void PB_confirm_pass_Click(object sender, EventArgs e)
        {
            login_check();
        }

        private void Form_Pass_popup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                login_check();
            }
        }

        public void login_check()
        {
            if (text_entry_pass.Text == "lsrd")
            {
                login = true;
                Close();
            }
            else
            {
                text_wrong_pass.Visible = true;
            }
        }

        
    }
}
