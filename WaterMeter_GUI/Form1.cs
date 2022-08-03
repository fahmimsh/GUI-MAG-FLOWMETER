using System;
using System.Globalization;
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

namespace WaterMeter_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect_Serial_com();
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("1,0.0");
                toolStripStatusLabel1.Text = "Serial PORT: " + Convert.ToString(Properties.Settings.Default.COM_PORT) + " , Baudrate:" + Convert.ToString(Properties.Settings.Default.BAUD_RATE) + "  is connected.";
            }
            else
            {
                connect_Serial_com();
            }
        }
        
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            // f3.MdiParent = this;
            f3.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void serialComToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            // f2.MdiParent = this;
            f2.Show();
            toolStripStatusLabel1.Text = "Pastikan koneksi Komunikasi Serial Pada alat Sebelum Disetting Pada device manager";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

        public void connect_Serial_com()
        {
            try
            {
                serialPort1.PortName = Properties.Settings.Default.COM_PORT;
                serialPort1.BaudRate = Convert.ToInt32(Properties.Settings.Default.BAUD_RATE);
                serialPort1.Open();
                toolStripStatusLabel1.Text = "Serial PORT: " + Convert.ToString(Properties.Settings.Default.COM_PORT) + " , Baudrate:" + Convert.ToString(Properties.Settings.Default.BAUD_RATE) + "  is connected.";
            }

            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = ("ERROR: ") + ex.Message.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        public String receiveMsg;
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                receiveMsg = serialPort1.ReadLine();
                Tampilkan(receiveMsg);
            }
            catch { }
        }
        private delegate void TampilkanDelegate(object item);
        private void Tampilkan(object item)
        {
            if (InvokeRequired)
                listBox1.Invoke(new TampilkanDelegate(Tampilkan), item);
            else
            {
                listBox1.Items.Add(item);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
            splitData(item);
        }
        public bool kirimdata_ = false;
        private void splitData(object item)
        {
            String[] data = item.ToString().Split(',');
            if (data[0] == ("*A"))
            {
                if(kirimdata_ == true)
                {
                    button1.Enabled = false;
                }
                standardControl3.BlinkMode = SymbolFactoryNetEngine.BlinkModeOptions.Shaded;
                standardControl4.BlinkMode = SymbolFactoryNetEngine.BlinkModeOptions.Shaded;
                standardControl6.BlinkMode = SymbolFactoryNetEngine.BlinkModeOptions.Shaded;
                standardControl5.BlinkMode = SymbolFactoryNetEngine.BlinkModeOptions.Shaded;
                standardControl7.BlinkMode = SymbolFactoryNetEngine.BlinkModeOptions.Shaded;
                standardControl8.BlinkMode = SymbolFactoryNetEngine.BlinkModeOptions.Shaded;
                label7.Text = data[1];
                label6.Text = data[2];
            }
            else if (data[0] == ("*B"))
            {
                kirimdata_ = false;
                standardControl3.BlinkMode = SymbolFactoryNetEngine.BlinkModeOptions.NoBlink;
                standardControl4.BlinkMode = SymbolFactoryNetEngine.BlinkModeOptions.NoBlink;
                standardControl6.BlinkMode = SymbolFactoryNetEngine.BlinkModeOptions.NoBlink;
                standardControl5.BlinkMode = SymbolFactoryNetEngine.BlinkModeOptions.NoBlink;
                standardControl7.BlinkMode = SymbolFactoryNetEngine.BlinkModeOptions.NoBlink;
                standardControl8.BlinkMode = SymbolFactoryNetEngine.BlinkModeOptions.NoBlink;
                label7.Text = data[1];
                label6.Text = data[2];
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = true;
                toolStripStatusLabel1.Text = ("ERROR: Tidak terhubung dengan alat");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kirimdata_ = true;
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("1," + numericUpDown1.Value);
                toolStripStatusLabel1.Text = "Serial PORT: " + Convert.ToString(Properties.Settings.Default.COM_PORT) + " , Baudrate:" + Convert.ToString(Properties.Settings.Default.BAUD_RATE) + "  is connected.";
            }
            else 
            {
                connect_Serial_com();
            }
        }

        private void dataLogsheetAirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox2.Visible = true;
        }

        private void dataInputSerialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox2.Visible = false;
        }
    }
}
