using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Recievertest1
{
    public partial class Form1 : Form
    {
        string dataIN;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxcom.Items.AddRange(ports);
            btnOpen.Enabled = true;
            btnClosed.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxcom.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxbaud.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxdata.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxstop.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxparry.Text);
                serialPort1.Open();
                btnOpen.Enabled = false;
                btnClosed.Enabled = true;
                progressBar1.Value = 100;
                lbComstat.Text = "ON";
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnOpen.Enabled = true;
                btnClosed.Enabled = false;
                lbComstat.Text = "OFF";
            }
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;   
                btnClosed.Enabled = false;
                btnOpen.Enabled = true;
                lbComstat.Text = "OFF";
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
    
        }

        private void ShowData(object sender, EventArgs e)
        {
            //tbDataIn.Text = dataIN;
            tbDataIn.AppendText(dataIN.ToString());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (tbDataIn.Text != "")
            {
                tbDataIn.Text = "";
            }
        }

        private void tbDataIn_TextChanged(object sender, EventArgs e)
        {
            int dataInLength=tbDataIn.Text.Length;
            lbDataInlen.Text=string.Format("{0:00}",dataInLength);
        }
    }
}
