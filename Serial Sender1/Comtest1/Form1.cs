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
namespace Comtest1
{
    public partial class Form1 : Form
    {
        string dataOut;
        string sendWith;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports=SerialPort.GetPortNames();
            cboxCom.Items.AddRange(ports);
            //cboxCom.SelectedIndex = 0;
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            sendWith = "WriteLine";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cboxCom.Text;
                serialPort1.BaudRate = Convert.ToInt32(cboxBaud.Text);
                serialPort1.DataBits = Convert.ToInt32(cboxData.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cboxStop.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cboxParity.Text);
                serialPort1.Open();
                progressBar1.Value = 100;
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                lbStatuscom.Text = "ON";
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                btnOpen.Enabled=true;
                btnClose.Enabled=false;
                lbStatuscom.Text = "OFF";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                btnClose.Enabled = false;
                btnOpen.Enabled=true;
                lbStatuscom.Text = "OFF";
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            //if (serialPort1.IsOpen)
            //{
            //    dataOut = tBoxDataout.Text+"\r\n";
            //    if (sendWith == "WriteLine")
            //    {
            //        serialPort1.WriteLine(dataOut);
            //    }
            //    else if(sendWith =="Write")
            //    {
            //        serialPort1.Write(dataOut);
            //    }
                
            //}

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                
                dataOut = tBoxDataout.Text + "\r\n";
                if (sendWith == "WriteLine")
                {
                    serialPort1.WriteLine(dataOut);
                }
                else if (sendWith == "Write")
                {
                    serialPort1.Write(dataOut);
                }

            }
        }

        private void tnClearData_Click(object sender, EventArgs e)
        {
            if(tBoxDataout.Text!="")
            {
                tBoxDataout.Text = "";
            }
        }

        

        private void tBoxDataout_TextChanged(object sender, EventArgs e)
        {
            int dataOutLength=tBoxDataout.Text.Length;
            lbDataOutLen.Text = string.Format("{0:00}", dataOutLength);
        }
    }

}
