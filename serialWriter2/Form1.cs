using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace serialWriter2
{
    public partial class Form1 : Form
    {
        SerialPort serialHandler = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            this.serialHandler.PortName = "COM3";
            this.serialHandler.BaudRate = 9600;
        }


        private void HighButton_click(object sender, EventArgs e)
        {
            this.label1.Text = "HIGH";
            this.serialHandler.Open();
            this.serialHandler.WriteLine("H");
            this.serialHandler.Close();
            
        }

        private void LowButton_Click(object sender, EventArgs e)
        {
            this.label1.Text = "LOW";
            this.serialHandler.Open();
            this.serialHandler.WriteLine("L");
            this.serialHandler.Close();
        }

        private void FrequencyButton_Click(object sender, EventArgs e)
        {
            this.label1.Text = "FREQUENCY";
            this.serialHandler.Open();
            this.serialHandler.WriteLine("F");
            this.serialHandler.Close();
        }
    }
}
