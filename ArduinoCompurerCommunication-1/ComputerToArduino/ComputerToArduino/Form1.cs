

/*
By Anonymous Shrimp
https://youtube.com/channel/UCs2Sz1gPlWAdET5qcLcZCJw
https://github.com/Anonymous-Shrimp 
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace ComputerToArduino
{
    public partial class Form1 : Form

    {
        int redLed1 = 0;
        int greenLed1 = 0;
        int blueLed1 = 0;

        int redLed2 = 0;
        int greenLed2 = 0;
        int blueLed2 = 0;

        bool isConnected = false;
        String[] ports;
        SerialPort port;

        public Form1()
        {
            InitializeComponent();
            disableControls();
            getAvailableComPorts();

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBox1.SelectedItem = ports[0];
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();
            } else
            {
                disconnectFromArduino();
            }
        }

        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void connectToArduino()
        {
            
            try
            {
                isConnected = true;
                string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
                port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
                port.Open();
                label4.Text = "";
                button1.Text = "Disconnect";
                enableControls();
            }
            catch
            {
                Console.WriteLine("Connection Error");
                label4.Text = "Connection Error";
            }
            
            
        }

      
        private void disconnectFromArduino()
        {
            try
            {
                isConnected = false;
                port.Write("#STOP\n");
                Console.WriteLine("#STOP\n");
                port.Close();
                button1.Text = "Connect";
                disableControls();
            }
            catch
            {
                Console.WriteLine("Connection Error");
            }
        }
        private static String HexConverter(System.Drawing.Color c)
        {
            return c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        String RGBCompiler(int red, int green, int blue)
        { 
            string r, g, b;
            if (red.ToString().Length == 1)
            {
                r = "00" + red.ToString();
            }else if(red.ToString().Length == 2){
                r = "0" + red.ToString();
            }
            else
            {
                r = red.ToString();
            }
            if (green.ToString().Length == 1)
            {
                g = "00" + green.ToString();
            }
            else if (green.ToString().Length == 2)
            {
                g = "0" + green.ToString();
            }
            else
            {
                g = green.ToString();
            }
            if (blue.ToString().Length == 1)
            {
                b = "00" + blue.ToString();
            }
            else if (blue.ToString().Length == 2)
            {
                b = "0" + blue.ToString();
            }
            else
            {
                b = blue.ToString();
            }
            return r + g + b;
        }

        private void enableControls()
        {
            groupbox1.Enabled = true;

        }

        private void disableControls()
        {
            groupbox1.Enabled = false;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=color+picker");
        }

        private void colorBox_Click(object sender, EventArgs e)
        {
            
        }


      

        private void redIn_Scroll(object sender, EventArgs e)
        {
            if (redIn1.Value > 255)
            {
                redIn1.Value = 255;
            }
            if (redIn1.Value < 0)
            {
                redIn1.Value = 0;
            }
            redLed1 = redIn1.Value;
            redLabel1.Text = redIn1.Value.ToString();
            hex1.BackColor = Color.Transparent;
            colorBox1.BackColor = Color.FromArgb(redLed1, greenLed1, blueLed1);
            hex1.Text = '#' + HexConverter(colorBox1.BackColor);

        }

        private void greenIn_Scroll(object sender, EventArgs e)
        {
            if (greenIn1.Value > 255)
            {
                greenIn1.Value = 255;
            }
            if (greenIn1.Value < 0)
            {
                greenIn1.Value = 0;
            }
            greenLed1 = greenIn1.Value;
            greenLabel1.Text = greenIn1.Value.ToString();
            hex1.BackColor = Color.Transparent;
            colorBox1.BackColor = Color.FromArgb(redLed1, greenLed1, blueLed1);
            hex1.Text = '#' + HexConverter(colorBox1.BackColor);

        }

        private void blueIn_Scroll(object sender, EventArgs e)
        {
            if (blueIn1.Value > 255)
            {
                blueIn1.Value = 255;
            }
            if (blueIn1.Value < 0)
            {
                blueIn1.Value = 0;
            }
            blueLed1 = blueIn1.Value;
            blueLabel1.Text = blueIn1.Value.ToString();
            hex1.BackColor = Color.Transparent;
            colorBox1.BackColor = Color.FromArgb(redLed1, greenLed1, blueLed1);
            hex1.Text = '#' + HexConverter(colorBox1.BackColor);
        }

        private void redIn2_Scroll(object sender, EventArgs e)
        {
            if (redIn2.Value > 255)
            {
                redIn2.Value = 255;
            }
            if (redIn2.Value < 0)
            {
                redIn2.Value = 0;
            }
            redLed2 = redIn2.Value;
            redLabel2.Text = redIn2.Value.ToString();
            hex2.BackColor = Color.Transparent;
            colorBox2.BackColor = Color.FromArgb(redLed2, greenLed2, blueLed2);
            hex2.Text = '#' + HexConverter(colorBox2.BackColor);
        }

        private void greenIn2_Scroll(object sender, EventArgs e)
        {
            if (greenIn2.Value > 255)
            {
                greenIn2.Value = 255;
            }
            if (greenIn2.Value < 0)
            {
                greenIn2.Value = 0;
            }
            greenLed2 = greenIn2.Value;
            greenLabel2.Text = greenIn2.Value.ToString();
            hex2.BackColor = Color.Transparent;
            colorBox2.BackColor = Color.FromArgb(redLed2, greenLed2, blueLed2);
            hex2.Text = '#' + HexConverter(colorBox2.BackColor);
        }

        private void blueIn2_Scroll(object sender, EventArgs e)
        {
            if (blueIn2.Value > 255)
            {
                blueIn2.Value = 255;
            }
            if (blueIn2.Value < 0)
            {
                blueIn2.Value = 0;
            }
            blueLed2 = blueIn2.Value;
            blueLabel2.Text = blueIn2.Value.ToString();
            hex2.BackColor = Color.Transparent;
            colorBox2.BackColor = Color.FromArgb(redLed2, greenLed2, blueLed2);
            hex2.Text = '#' + HexConverter(colorBox2.BackColor);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                String delay;
                if (delayTimer.Value.ToString().Length == 1)
                {
                    delay = "0" + delayTimer.Value.ToString();
                }
                else
                {
                    delay = delayTimer.Value.ToString();
                }
                Console.WriteLine('#' + RGBCompiler(redLed1, greenLed1, blueLed1)+ RGBCompiler(redLed2, greenLed2, blueLed2) + delay + "\n");
                port.Write("#" + RGBCompiler(redLed1, greenLed1, blueLed1) + RGBCompiler(redLed2, greenLed2, blueLed2) + delay + "\n");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                port.Write("#PAUSE\n");
                Console.WriteLine("#PAUSE\n");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupbox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void redLabel2_Click(object sender, EventArgs e)
        {

        }

        private void hex1_Click(object sender, EventArgs e)
        {

        }

        private void hex2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
