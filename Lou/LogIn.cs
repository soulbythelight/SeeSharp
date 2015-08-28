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
    public partial class LogIn : Form
    {
        protected bool isStarted = false;
        public LogIn()
        {
            InitializeComponent();
        }
       
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isStarted) {
                this.ClickAnimate();
                isStarted = true;
                btnStart.Text = "Sign in";
                panel1.Show();
            } else {
                
            }

        }

        private void LogIn_Load(object sender, EventArgs e)
        {
          
        }

        private void LogIn_Shown(object sender, EventArgs e)
        {
            this.StartAnimate();
        }
        public void StartAnimate()
        {
            for (int i = 330; i > 290; i--)
            {
                lblTitle.Location = new Point(317, i);
                lblTitle.Show();
                lblTitle.Refresh();
            }
            for (int i = 400; i < 500; i++)
            {
                btnStart.Location = new Point(544, i);
                btnStart.Show();
                btnStart.Refresh();
                lblTitle.Refresh();
            }
        }
        public void ClickAnimate()
        {
            for (int i = 500; i < 570; i++)
            {
                btnStart.Location = new Point(544, i);
                btnStart.Refresh();
                btnStart.Show();
            }
            for (int i = 290; i > 100; i--)
            {
                lblTitle.Location = new Point(317, i);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
