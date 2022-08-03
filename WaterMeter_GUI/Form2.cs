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

namespace WaterMeter_GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboCOMPORT.Text = Properties.Settings.Default.COM_PORT; 
            comboBAUDRATE.Text = Convert.ToString(Properties.Settings.Default.BAUD_RATE);
            string[] ports = SerialPort.GetPortNames();
            comboCOMPORT.Items.AddRange(ports);
        }

        private void comboCOMPORT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Savesettings();
            this.Close();
        }

        public void Savesettings()
        {
            Properties.Settings.Default.COM_PORT = comboCOMPORT.Text;
            Properties.Settings.Default.BAUD_RATE = Convert.ToInt32(comboBAUDRATE.Text);
        }
    }
}
