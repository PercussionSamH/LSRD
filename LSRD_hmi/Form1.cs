using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EasyModbus;


namespace LSRD_hmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //intialize modbus
            ModbusClient modbusClient = new ModbusClient("10.104.5.184", 502);
            modbusClient.Connect();
        }

        private void PB_wave_Click(object sender, EventArgs e)
        {
            
            modbusClient.WriteSingleCoil(0, true);
        }
    }
}
