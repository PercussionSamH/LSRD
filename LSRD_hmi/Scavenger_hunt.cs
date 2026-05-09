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
    public partial class Scavenger_hunt : Form
    {
        public Scavenger_hunt()
        {
            this.FormBorderStyle = FormBorderStyle.None; // Removes borders and title bar
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void Scavenger_hunt_Load(object sender, EventArgs e)
        {
            Popup_Hide();
            if(Form1.ENABLE_SCALING)
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
            
        }

        private void popup_pb_close_Click(object sender, EventArgs e)
        {
            Popup_Hide();
        }
        private void PB_drawing_mode_Click(object sender, EventArgs e)
        {
            Popup_Show();
        }


        private void Popup_Hide()
        {
            //popup_open = false;
            popup_scav.Visible = false;
            //popup_scav_text.Visible = false;
            //popup_pb_close.Visible = false;
            //popup_pb_confirm.Visible = false;
            //popup_scav_border.Visible = false;
            //popup_scav_back.Visible = false;
        }

        private void Popup_Show()
        {
            //popup_open = false;

            popup_scav.Visible = true;
            //popup_scav_text.Visible = true;
            //popup_pb_close.Visible = true;
            //popup_pb_confirm.Visible = true;
            //popup_scav_border.Visible = true;
            //popup_scav_back.Visible = true;
            //popup_scav_text.BringToFront();
            //popup_pb_close.BringToFront();
            //popup_pb_confirm.BringToFront();
        }

        private void popup_pb_confirm_Click(object sender, EventArgs e)
        {
            //modbus stuff
            Form1.demo_active_scavenger = true;
            wait(1000);
            Form1.demo_active_scavenger = false;
            Popup_Hide();
        }

        private void PB_Back_To_Home_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
