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
    
        public LogIn()
        {
            InitializeComponent();
        }
       
        private void btnStart_Click(object sender, EventArgs e)
        {
            Util.Animate(lblTitle, Util.Effect.Slide, 150, 180);
            Util.Animate(btnStart, Util.Effect.Slide, 150, 180);
            Util.Animate(label2, Util.Effect.Slide, 150, 180);
            Util.Animate(panelSignIn, Util.Effect.Slide, 150, 180);
            txtUsername.Focus();
            txtUsername.Select(0, 0);
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtpassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtpassword.Select(0, 0);
            txtpassword.Focus();
            
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Select(0, 0);
            txtUsername.Focus();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                //set default message in normal chars
                txtUsername.Text = "Account Name";
                txtUsername.PasswordChar = Char.MinValue;
            }
            //if the new text is different from the default message
            //but the passwordchar is not yet on
            if (txtUsername.PasswordChar.Equals(Char.MinValue) && txtUsername.Text.Equals("Account Name").Equals(false))
            {
                //take the newly added letter
                txtUsername.Text = txtpassword.Text[0].ToString();
                //set caret at the end of the textbox
                txtUsername.SelectionStart = 1;
                //set the passwordchar
                txtUsername.PasswordChar = '*';


            }
        }

        private void txtpassword_TextChanged_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtpassword.Text))
            {
                //set default message in normal chars
                txtpassword.Text = "Password";
                txtpassword.PasswordChar = Char.MinValue;
            }
            //if the new text is different from the default message
            //but the passwordchar is not yet on
            if (txtpassword.PasswordChar.Equals(Char.MinValue) && txtpassword.Text.Equals("Password").Equals(false))
            {
                //take the newly added letter
                txtpassword.Text = txtpassword.Text[0].ToString();
                //set caret at the end of the textbox
                txtpassword.SelectionStart = 1;
                //set the passwordchar
                txtpassword.PasswordChar = '*';

                  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtpassword.Text + " "+txtUsername.Text);
        }
    }
}
