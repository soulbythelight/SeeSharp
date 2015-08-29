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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            for(int i = -200; i < 0; i = i + 10)
            {
                panelMenu.Location = new Point(i, 0);
                panelMenu.Show();
                panelMenu.Refresh();
            }
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i > -399; i = i - 10)
            {
                panelMenu.Location = new Point(i, 0);
                panelMenu.Show();
                panelMenu.Refresh();
            }
        }
    }
}
