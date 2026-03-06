//Library includes
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



namespace LSRD_hmi
{

    public partial class Form1 : Form
    {
        //IP address
        static string PLC_IP = "10.104.5.184"; static int port = 502;
        public ModbusClient modbusClient = new ModbusClient(PLC_IP, port);

        //Bit ranges
        bool[] QX_Coils; //QX0.0 - QX...
        int QX_length = 100; //total # of vars

        //settings
        public static bool enabled_doorman = true;
        public static bool enabled_drawing = true;
        public static bool enabled_scavenger = true;

        public static bool wave_scheduled = false;
        public static bool wave_active = false;
        public static int wave_t_start = 0;
        public static int wave_t_end = 0;
        public static string wave_t_string = null;
        public static int wave_duration = 0;

        public Form1()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Removes borders and title bar
            this.WindowState = FormWindowState.Maximized;

            try
            {
                System.Diagnostics.Debug.WriteLine("Connecting to " + PLC_IP + " on port " + port);
                modbusClient.Connect();

                System.Diagnostics.Debug.WriteLine("Connected!");

                //start timer for push/pull sync
                timer_Modbus_Com.Enabled = true;

                //read initial QX vars
                QX_Coils = modbusClient.ReadCoils(0, QX_length); //read all variables off of PLC
        
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Connection to " + PLC_IP + " on port " + port + " failed...");
                System.Diagnostics.Debug.WriteLine("ERROR: ", ex.Message);
                //throw;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer_Modbus_Com_Tick(object sender, EventArgs e)
        {
            timer_Modbus_Com.Enabled = false; //prevents multiple timer signals per read

            //Read inputs
            QX_Coils = modbusClient.ReadCoils(0, QX_length);
            //test_textbox.Text = string.Join(" ", QX_Coils.Select(b => b.ToString())); ;
            modbusClient.WriteSingleCoil(99, wave_active); //Wave mode enabled

            //Reenable timer
            timer_Modbus_Com.Enabled = true;
        }

        private void tmr_update_vars_Tick(object sender, EventArgs e)
        {
            tmr_update_vars.Enabled = false;
            //Check for wave demo
            int current_time_min = DateTime.Now.Minute + (60 * DateTime.Now.Hour);
            label1.Text = wave_active.ToString();
            label2.Text = wave_scheduled.ToString();
            if (current_time_min >= wave_t_start && current_time_min < wave_t_end)
            {
                if (wave_scheduled)
                {
                    wave_scheduled = false;
                    wave_active = true;
                }
            }
            else
            {
                if (wave_active) wave_scheduled = false;
                wave_active = false;
            }
            tmr_update_vars.Enabled = true;
        }

        private void PB_Draw_Fish1_Click(object sender, EventArgs e)
        {
            //QX_Coils[16] = true; //set 2.0
            modbusClient.WriteSingleCoil(16, true);
        
        }

        private void PB_Draw_Square_Click(object sender, EventArgs e)
        {
            //QX_Coils[17] = true; //set 2.1
            modbusClient.WriteSingleCoil(17, true);
        }

        private void PB_doorman_mode_Click(object sender, EventArgs e)
        {
            if (enabled_doorman == true)
            {
                Form_doorman form_doorman = new Form_doorman();
                form_doorman.ShowDialog();
                form_doorman = null;
            }
        }



        private void PB_drawing_mode_Click(object sender, EventArgs e)
        {
            if (enabled_drawing == true)
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
                form2 = null;
            }

        }

        private void PB_Quit_Program_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PB_staff_controls_Click(object sender, EventArgs e)
        {

            Form_Pass_popup form_Settings_Popup = new Form_Pass_popup();
            form_Settings_Popup.ShowDialog();
            
            //grab login bool from popup form
            if (form_Settings_Popup.login == true)
            {
                Form_Settings form_Settings = new Form_Settings();
                form_Settings.ShowDialog();

                //get vars from menu
                enabled_doorman = form_Settings.enabled_doorman;
                enabled_drawing = form_Settings.enabled_drawing;
                enabled_scavenger  = form_Settings.enabled_scavenger;

                wave_t_start = form_Settings.wave_time_start;
                wave_t_end = form_Settings.wave_time_end;
                wave_scheduled = form_Settings.wave_scheduled;
                wave_t_string = form_Settings.wave_time_string;
                wave_duration = form_Settings.wave_duration;

                //sets button graphics to enable/disabled
                PB_doorman_mode.Image = (enabled_doorman) ? LSRD_hmi.Properties.Resources.PB_gray_doorman_demo : LSRD_hmi.Properties.Resources.PB_disabled_doorman;
                PB_drawing_mode.Image = (enabled_drawing) ? LSRD_hmi.Properties.Resources.PB_gray_Drawing_demo : LSRD_hmi.Properties.Resources.PB_disabled_drawing;
                PB_scavenger_mode.Image = (enabled_scavenger) ? LSRD_hmi.Properties.Resources.PB_gray_Scavenger_hunt : LSRD_hmi.Properties.Resources.PB_disabled_scavenger;
                form_Settings = null;
                
            }

            form_Settings_Popup = null;
        }

        private void PB_scavenger_mode_Click(object sender, EventArgs e)
        {
            if (enabled_scavenger == true)
            {
                //Form2 form2 = new Form2();
                //form2.ShowDialog();
                //form2 = null;
            }
        }

    }
}
