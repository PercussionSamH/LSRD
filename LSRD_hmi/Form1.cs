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
   
        //Vars
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




        private void timer_Modbus_Com_Tick(object sender, EventArgs e)
        {

            //prevents multiple timer signals per read
            timer_Modbus_Com.Enabled = false;

            //Read inputs
            QX_Coils = modbusClient.ReadCoils(0, QX_length);
            test_textbox.Text = string.Join(" ", QX_Coils.Select(b => b.ToString())); ;
            //Reenable timer
            timer_Modbus_Com.Enabled = true;
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
            Form_doorman form_doorman = new Form_doorman();

            form_doorman.ShowDialog();
            //Free form2 from memory
            form_doorman = null;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PB_drawing_mode_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.ShowDialog();
            //Free form2 from memory
            form2 = null;
        }

        private void PB_Quit_Program_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
