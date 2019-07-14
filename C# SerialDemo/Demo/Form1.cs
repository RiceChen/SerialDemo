using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace Demo
{
    public partial class Form1 : Form
    {
        public SerialPort MySerialPort = new SerialPort();
        Thread serialPort_Thread;

        bool comExistence = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void scan_Click(object sender, EventArgs e)
        {
            port.Clear();
            for (int i = 1; i <= 30; i++)
            {
                try
                {
                    SerialPort sp = new SerialPort("COM" + i.ToString());
                    sp.Open();
                    sp.Close();
                    port.Text = "COM" + i.ToString();
                    comExistence = true;
                }
                catch (Exception)
                {
                    continue;
                }
            }
            if (comExistence == false)
            {
                port.Text = "COM";
                MessageBox.Show("Unused serial!");
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            try
            {
                if (open.Text == "open")
                {
                    if (comExistence == true)
                    {
                        MySerialPort.Close();
                        /* port */
                        MySerialPort.PortName = port.Text;
                        /* baud rate */
                        MySerialPort.BaudRate = Convert.ToInt32(baud.Text.Trim());
                        /* data bit */
                        if (data_bit.Text == "5")
                            MySerialPort.DataBits = (byte)5;
                        else if (data_bit.Text == "6")
                            MySerialPort.DataBits = (byte)6;
                        else if (data_bit.Text == "7")
                            MySerialPort.DataBits = (byte)7;
                        else
                            MySerialPort.DataBits = (byte)8;
                        /* stop bit */
                        if (stop_bit.Text == "2")
                            MySerialPort.StopBits = StopBits.Two;
                        else if (stop_bit.Text == "1.5")
                            MySerialPort.StopBits = StopBits.OnePointFive;
                        else
                            MySerialPort.StopBits = StopBits.One;
                        /* parity */
                        if (parity.Text == "Even")
                            MySerialPort.Parity = Parity.Even;
                        else if (parity.Text == "Odd")
                            MySerialPort.Parity = Parity.Odd;
                        else
                            MySerialPort.Parity = Parity.None;
                        MySerialPort.Open();

                        if (MySerialPort.IsOpen)
                        {
                            open.Text = "Close";
                            port.Enabled = false;
                            baud.Enabled = false;
                            data_bit.Enabled = false;
                            stop_bit.Enabled = false;
                            parity.Enabled = false;
                            scan.Enabled = false;
                            serialPort_Thread = new Thread(new ThreadStart(this.readPort));
                            serialPort_Thread.Start();
                        }
                    }
                }
                else
                {
                    open.Text = "open";
                    port.Enabled = true;
                    baud.Enabled = true;
                    data_bit.Enabled = true;
                    stop_bit.Enabled = true;
                    parity.Enabled = true;
                    scan.Enabled = true;
                    comExistence = false;
                    port.Text = "COM";
                    MySerialPort.Close();
                    serialPort_Thread.Abort();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                open.Text = "Open";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            receive_box.Clear();
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (MySerialPort.IsOpen)
            {
                MySerialPort.WriteLine(send_box.Text);
            }
        }

        private void readPort()
        {
            string rxBuffer = "";

            while (MySerialPort.IsOpen)
            {
                try
                {
                    rxBuffer = MySerialPort.ReadExisting();
                    this.Invoke((EventHandler)(delegate
                    {
                        receive_box.Text += rxBuffer;
                    }));
                }
                catch
                {
                    rxBuffer = "";
                }
            }
        }



    }
}
