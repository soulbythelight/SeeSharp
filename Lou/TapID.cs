using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lou
{
    public partial class TapID : Form
    {
        public TapID()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("h:mm:ss tt");
            lblDate.Text = DateTime.Today.ToString("dddd, MMMMMMMMM dd, yyyy");
        }
    }
}
