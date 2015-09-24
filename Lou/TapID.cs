using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Lou
{
    public partial class TapID : Form
    {
        protected string DispString;
        public TapID()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("h:mm:ss tt");
            lblDate.Text = DateTime.Today.ToString("dddd, MMMMMMMMM dd, yyyy");
        }

        private void TapID_Load(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = "COM16";
                serialPort1.BaudRate = 9600;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Handshake = Handshake.None;

                serialPort1.Open();
                serialPort1.ReadTimeout = 200;
                if (serialPort1.IsOpen)
                {
                    //DispString = "";
                    //textBox1.Text = "";
                }
            }
            catch (Exception me) { }
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            DispString = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(DisplayText));
        }
        private void DisplayText(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.AppendText(DispString);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }
    }
}
