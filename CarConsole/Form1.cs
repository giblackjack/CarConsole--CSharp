#define TRACE

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
using System.Management;
using System.Diagnostics;
using WMPLib;

namespace CarConsole
{
    /*
    Code	    Arduino pin	Action
    999	    --	Close all output pins
    Servo		
    10-90	5	Control servo angle 0-90 deg.
    Vents		
    190	    6	Face vent
    191	    7	Face and feet vents
    192	    8	Feet vent
    193	    9	Feet and windows vents
    194	    10	Windows vents
    195	    --	All vents offs
    Airflow		
    196	    11	Circulate air inside
    197	    12	Circulate air from outside
    AC		
    198	    13	AC on
    199	    --	AC off
    Fan		
    300		    Fan Off. AC Off
    325	    A1	Fan speed 1 (min)
    350	    A2	Fan speed 2
    375	    A3	Fan speed 3
    400	    A4	Fan speed 4 (max)
    */
    public partial class Form1 : Form
    {
        public String port { get; set; }

        private int Compressor = 199;
        private int vent = 190;
        private int airflow = 196;
        private int fanSpeed = 300;
        private int temp = 10;
        private bool SystemSwitch = true;
        //private static int VID = 2341;
        //private static int PID = 0043;

        

        public Form1()
        {
            Trace.Listeners.Add(new TextWriterTraceListener("C:/CarConsole.log"));
            Trace.AutoFlush = true;
            InitializeComponent();
            this.port = "COM3";
            this.textBoxCOMPort.Text = this.port;
            if (connectToArduino())
            {
                this.toolStripStatusConnected.Text = "Connected";
                this.toolStripStatusConnected.LinkColor = Color.Green;
            }

        }

        private Boolean connectToArduino()
        {
            /*
            VID = 0x2341
            PID = 0x0043
            */
            
            serialPortArduino = new System.IO.Ports.SerialPort(this.port);
            //TODO Uncomment code below for distro to Matt to see if it works.
            //serialPortArduino.Handshake = System.IO.Ports.Handshake.RequestToSendXOnXOff;
            Trace.TraceInformation(System.DateTime.Now.ToString());
            Trace.TraceInformation("connecting to Arduino");
            Trace.TraceInformation("serial port information");
            Trace.TraceInformation("Com port: " + serialPortArduino.PortName);
            Trace.TraceInformation("baud rate: " + serialPortArduino.BaudRate);
            try {
                if (!serialPortArduino.IsOpen)
                {
                    serialPortArduino.Open();
                }
            } catch (System.IO.IOException e)
            {
                Trace.TraceError("Connect to Arduino Failed");
                Trace.TraceError(e.ToString());
            }
            return serialPortArduino.IsOpen;
        }

        private void sendInstruction(String message)
        {
            if(message != null && message != "" && serialPortArduino.IsOpen)
            {
                serialPortArduino.Write(message);
                //TODO: uncomment line below if handshake doesn't work to fix non-comm issue.
               Thread.Sleep(500);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            serialPortArduino.Close();
            serialPortArduino.Dispose();
            this.toolStripStatusConnected.Text = "Not Connected";
            this.toolStripStatusConnected.LinkColor = Color.Red;
            this.port = this.textBoxCOMPort.Text;
            if (connectToArduino())
            {
                this.toolStripStatusConnected.Text = "Connected";
                this.toolStripStatusConnected.LinkColor = Color.Green;
            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            if(Compressor == 199)
            {
                Compressor--;
                sendInstruction(Compressor.ToString());
            }
            else if (Compressor == 198)
            {
                Compressor++;
                sendInstruction(Compressor.ToString());
            }
            else
            {
                Compressor = 199;
                sendInstruction(Compressor.ToString());
            }
        }

        private void btnRecirc_Click(object sender, EventArgs e)
        {
            airflow = 196;
            sendInstruction(airflow.ToString());
        }

        private void btnFreshAir_Click(object sender, EventArgs e)
        {
            airflow = 197;
            sendInstruction(airflow.ToString());
        }

        private void btnFace_Click(object sender, EventArgs e)
        {
            vent = 190;
            sendInstruction(vent.ToString());
        }

        private void btnFaceFeet_Click(object sender, EventArgs e)
        {
            vent = 191;
            sendInstruction(vent.ToString());
        }

        private void btnFeet_Click(object sender, EventArgs e)
        {
            vent = 192;
            sendInstruction(vent.ToString());
        }

        private void btnFeetWindows_Click(object sender, EventArgs e)
        {
            vent = 193;
            sendInstruction(vent.ToString());
        }

        private void btnWindow_Click(object sender, EventArgs e)
        {
            vent = 194;
            sendInstruction(vent.ToString());
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            if (this.SystemSwitch)
            {
                this.SystemSwitch = false;
                sendInstruction("999");
            }
            else
            {
                this.SystemSwitch = true;
                sendInstruction(vent.ToString());
                sendInstruction(fanSpeed.ToString());
                sendInstruction(Compressor.ToString());
                sendInstruction(airflow.ToString());
            }

        }

        private void trackBarFanSpeed_ValueChanged(object sender, EventArgs e)
        {
            System.Console.WriteLine(trackBarFanSpeed.Value.ToString());
            switch (trackBarFanSpeed.Value)
            {
                case 0: fanSpeed = 300;
                    sendInstruction(fanSpeed.ToString());
                    break;
                case 1: fanSpeed = 325;
                    sendInstruction(fanSpeed.ToString());
                    break;
                case 2: fanSpeed = 350;
                    sendInstruction(fanSpeed.ToString());
                    break;
                case 3: fanSpeed = 375;
                    sendInstruction(fanSpeed.ToString());
                    break;
                case 4: fanSpeed = 400;
                    sendInstruction(fanSpeed.ToString());
                    break;
                default: fanSpeed = 300;
                    sendInstruction(fanSpeed.ToString());
                    break;
            }
        }

        private void trackBarTemp_ValueChanged(object sender, EventArgs e)
        {
            System.Console.WriteLine(trackBarTemp.Value.ToString());
            switch (trackBarTemp.Value)
            {
                case 1:
                    temp = 10;
                    sendInstruction(temp.ToString());
                    break;
                case 2:
                    temp = 20;
                    sendInstruction(temp.ToString());
                    break;
                case 3:
                    temp = 30;
                    sendInstruction(temp.ToString());
                    break;
                case 4:
                    temp = 40;
                    sendInstruction(temp.ToString());
                    break;
                case 5:
                    temp = 50;
                    sendInstruction(temp.ToString());
                    break;
                case 6:
                    temp = 60;
                    sendInstruction(temp.ToString());
                    break;
                case 7:
                    temp = 70;
                    sendInstruction(temp.ToString());
                    break;
                case 8:
                    temp = 80;
                    sendInstruction(temp.ToString());
                    break;
                case 9:
                    temp = 90;
                    sendInstruction(temp.ToString());
                    break;
                default:
                    temp = 10;
                    sendInstruction(temp.ToString());
                    break;
            }
        }

        private void btnFanFaster_Click(object sender, EventArgs e)
        {
            if (trackBarFanSpeed.Value != 4)
            {
                trackBarFanSpeed.Value++;
            }
        }

        private void btnFanSlower_Click(object sender, EventArgs e)
        {
            if (trackBarFanSpeed.Value != 0)
            {
                trackBarFanSpeed.Value--;
            }
        }

        private void btnHotter_Click(object sender, EventArgs e)
        {
            if (trackBarTemp.Value != 9)
            {
                trackBarTemp.Value++;
            }
        }

        private void btnColder_Click(object sender, EventArgs e)
        {
            if (trackBarTemp.Value != 1)
            {
                trackBarTemp.Value--;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBarFanSpeed_Scroll(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}

