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
        bool[] QX1; //QX1.0 - QX1.9


        public Form1()
        {
            InitializeComponent();
            try
            {
                System.Diagnostics.Debug.WriteLine("Connecting to " + PLC_IP + " on port " + port);
                modbusClient.Connect();

                System.Diagnostics.Debug.WriteLine("Connected!");

                ////start timer for push/pull sync
                //timer_Modbus_Com.Enabled = true;

                //read initial QX vars
                QX1 = modbusClient.ReadCoils(1, 10); //all QX1.X vars
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Connection to " + PLC_IP + " on port " + port + " failed...");
                System.Diagnostics.Debug.WriteLine("ERROR: ", ex.Message);
                throw;
            }
        }

        private void PB_wave_Click(object sender, EventArgs e)
        {
            //bool PB_mode_wave;
            //PB_mode_wave = true;

            for (int i = 0; i < QX1.Length; i++)
            {
                Console.WriteLine("QX1." + i + " is currently: " + QX1[i]);
            }
            //Set vars to bits
            QX1[0] = true;

            //Write to PLC
            //modbusClient.WriteMultipleCoils(1, QX1);

            modbusClient.WriteMultipleCoils(4, QX1);///I don't know why this is on coil 4, it doesn't make any sense
            for (int i = 0; i < QX1.Length; i++)
            {
                Console.WriteLine("QX1." + i + " is  now: " + QX1[i]);
            }

            //--------------------
            //QX1 = modbusClient.ReadCoils(1, 10);
            //Console.WriteLine("bit 1.3" + " set to: " + QX1[3]);

            //Thread.Sleep(2000);
            //modbusClient.WriteMultipleCoils(1, new bool[] { true, true, true, true, true, true});
            //QX1 = modbusClient.ReadCoils(1, 10);
            //Console.WriteLine("bit 1.3" + " read as: " + QX1[3]);
            //for (int i = 0; i < QX1.Length; i++)
            //{
            //   Console.WriteLine("QX1." + i + " set to: " + QX1[i]);
            //}
            //Console.WriteLine("QX1." + "3" + " set to: " + QX1[3]);


        }


        private void timer_Modbus_Com_Tick(object sender, EventArgs e)
        {
            //Read inputs
            //QX1 = modbusClient.ReadCoils(1, 10);



            //timer_Modbus_Com.Enabled = false;//prevents multiple signals within value
            ////grab values
            //modbusClient.WriteMultipleCoils(4, new bool[] { true, true, true, true, true, true, true, true, true, true });    //Write Coils starting with Address 5
            //bool[] readCoils = modbusClient.ReadCoils(9, 10);                        //Read 10 Coils from Server, starting with address 10
            //int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters(0, 10);    //Read 10 Holding Registers from Server, starting with Address 1

            ////myvar = readHoldingRegisters[0];
            //timer_Modbus_Com.Enabled = true;
        }
    }
}
