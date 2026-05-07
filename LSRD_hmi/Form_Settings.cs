using Google.Apis.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace LSRD_hmi
{
    public partial class Form_Settings : Form
    {
        // ------ Public vars ------
        //Enabling toggle switches
        public bool enabled_doorman;
        public bool enabled_drawing;
        public bool enabled_scavenger;
        public bool enabled_wave;
        //Wave demo
        public bool wave_scheduled;
        public int wave_time_start;
        public int wave_duration;
        public int wave_time_end;
        public string wave_time_string;


        public Form_Settings()
        {
            //Initializations
            this.FormBorderStyle = FormBorderStyle.None; // Removes borders and title bar
            this.WindowState = FormWindowState.Maximized;

            InitializeComponent();

            //Start timer to update clock
            tmr_upd_clock.Enabled = true;


            //Set toggles
            enabled_doorman = Form1.enabled_doorman;
            enabled_drawing = Form1.enabled_drawing;
            enabled_scavenger = Form1.enabled_scavenger;
            enabled_wave = Form1.enabled_wave;
            //load mains wave vars (to preserve them after close)
            wave_time_start = Form1.wave_t_start;
            wave_time_end = Form1.wave_t_end;
            wave_scheduled = Form1.wave_scheduled;
            wave_time_string = Form1.wave_t_string;
            wave_duration = Form1.wave_duration;

            Toggle_doorman.Image = (enabled_doorman) ? LSRD_hmi.Properties.Resources.toggle_on : LSRD_hmi.Properties.Resources.toggle_off;
            Toggle_drawing.Image = (enabled_drawing) ? LSRD_hmi.Properties.Resources.toggle_on : LSRD_hmi.Properties.Resources.toggle_off;
            Toggle_scavenger.Image = (enabled_scavenger) ? LSRD_hmi.Properties.Resources.toggle_on : LSRD_hmi.Properties.Resources.toggle_off;
            Toggle_wave.Image = (enabled_wave) ? LSRD_hmi.Properties.Resources.toggle_on : LSRD_hmi.Properties.Resources.toggle_off;

        }

        private void PB_Back_To_Home_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Toggle_doorman_Click(object sender, EventArgs e)
        {
            if (enabled_doorman)
            {
                enabled_doorman = false;
                Toggle_doorman.Image = LSRD_hmi.Properties.Resources.toggle_off;
            }
            else
            {
                enabled_doorman = true;
                Toggle_doorman.Image = LSRD_hmi.Properties.Resources.toggle_on;
            }
        }

        private void Toggle_drawing_Click(object sender, EventArgs e)
        {
            if (enabled_drawing)
            {
                enabled_drawing = false;
                Toggle_drawing.Image = LSRD_hmi.Properties.Resources.toggle_off;
            }
            else
            {
                enabled_drawing = true;
                Toggle_drawing.Image = LSRD_hmi.Properties.Resources.toggle_on;
            }
        }

        private void Toggle_scavenger_Click(object sender, EventArgs e)
        {
            if (enabled_scavenger)
            {
                enabled_scavenger = false;
                Toggle_scavenger.Image = LSRD_hmi.Properties.Resources.toggle_off;
            }
            else
            {
                enabled_scavenger = true;
                Toggle_scavenger.Image = LSRD_hmi.Properties.Resources.toggle_on;
            }

        }
        private void Toggle_wave_Click(object sender, EventArgs e)
        {
            if (enabled_wave)
            {
                enabled_wave = false;
                Toggle_wave.Image = LSRD_hmi.Properties.Resources.toggle_off;
            }
            else
            {
                enabled_wave = true;
                Toggle_wave.Image = LSRD_hmi.Properties.Resources.toggle_on;
            }
        }


        private void tmr_upd_clock_Tick(object sender, EventArgs e)
        {
            text_clock.Text = DateTime.Now.ToString("hh:mm:ss tt");

            if (wave_scheduled)
            {
                if (Form1.wave_scheduled == true)
                {
                    text_time_left.Text = (Form1.timeleft / 60).ToString() + ":" + (Form1.timeleft % 60).ToString();
                }
                else
                {
                    text_time_left.Text = "Pend.";
                }

            }
        }

        private void Form_Settings_Load(object sender, EventArgs e)
        {
            if (Form1.ENABLE_SCALING)
            {
                float widthRatio = Screen.PrimaryScreen.Bounds.Width / 1024f;
                float heightRatio = Screen.PrimaryScreen.Bounds.Height / 600f;
                SizeF scale = new SizeF(widthRatio, heightRatio);
                this.Scale(scale);
                foreach (Control ctrl in panel1.Controls)
                {
                    // Access existing size
                    float currentSize = ctrl.Font.Size;
                    // Set new size (e.g., 12pt)
                    ctrl.Font = new Font("Verdana", ctrl.Font.SizeInPoints * heightRatio * widthRatio / 1);

                }
                foreach (Control ctrl in panel2.Controls)
                {
                    // Access existing size
                    float currentSize = ctrl.Font.Size;
                    // Set new size (e.g., 12pt)
                    ctrl.Font = new Font("Verdana", ctrl.Font.SizeInPoints * heightRatio * widthRatio / 1);
                }
                foreach (Control ctrl in panel3.Controls)
                {
                    // Access existing size
                    float currentSize = ctrl.Font.Size;
                    // Set new size (e.g., 12pt)
                    ctrl.Font = new Font("Verdana", ctrl.Font.SizeInPoints * heightRatio * widthRatio / 1);
                }
            }
                
        }

        private void PB_start_wave_demo_Click(object sender, EventArgs e)
        {
            int duration = (int)t_duration.Value * 60;
            Form1.timeleft = duration;
            text_time_left.Text = "Pend.";// (Form1.timeleft / 60).ToString() + ":" + (Form1.timeleft % 60).ToString();

            DateTime t_now = DateTime.Now;

            //wave_time_start = minutes + (hours * 60);
            wave_time_start = t_now.Hour * 60 + t_now.Minute;
            wave_time_end = wave_time_start + duration;
            wave_scheduled = true;

        }
    }
}