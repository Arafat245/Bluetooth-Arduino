using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bluetooth
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            serialPort1.PortName = "COM16";
            serialPort1.BaudRate = 9600;
            try
            {
                if (!serialPort1.IsOpen)
                    serialPort1.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(DataReceived);
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //throw new NotImplementedException();
            try
            {
                SerialPort spl = (SerialPort)sender;
                Console.Write("Data" + count + " " + spl.ReadLine()+"\n");
                count++;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
