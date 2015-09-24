using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace Lou
{
    public partial class Admin : Form
    {
        static Administer.Query SELF = new Administer.Query();
        protected string[] panelAddUserString = { "First Name", "MI", "Last Name", "Account name", "Password", "Confirm password", "Value" };
        protected string gender = "";
        protected bool btnAddUserIsClick = false;
        protected bool btnViewDTRIsClick = false;
        protected bool rfidIstap = false;
        protected bool panelAddUserisValidated = false;
        protected string DispString;
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
                refreshAllPanel();
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
      
            panelMain.Location = new Point(62, 111);
            panelAddUser.Location = new Point(54, 195);
            SELF.PREPARE("localhost", "bulsu_db", "root", "");
            try {
                serialPort1.PortName = "COM15";
                serialPort1.BaudRate = 9600;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Handshake = Handshake.None;

                serialPort1.Open();
                serialPort1.ReadTimeout = 200;
                if (serialPort1.IsOpen)
                {
                    DispString = "";
                    textBox1.Text = "";
                }
            } catch (Exception me) { }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if(!btnAddUserIsClick) {
                for(int i = 62; i < 600; i = i + 10) {
                    panelMain.Location = new Point(i, 111);
                    panelMain.Refresh();
                }
                Util.Animate(panelAddUser, Util.Effect.Slide, 150, 180);
                btnAddUserIsClick = true;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (btnAddUserIsClick)
            {
                Util.Animate(panelAddUser, Util.Effect.Slide, 150, 180);
                for (int i = 600; i > 62; i = i - 10)
                {
                    panelMain.Location = new Point(i, 111);
                    panelMain.Refresh();
                }
                btnAddUserIsClick = false;
            }
        }
        private void btnViewDTR_Click(object sender, EventArgs e)
        {   
            if (!btnViewDTRIsClick)
            {
                btnViewDTR.Hide();
                Util.Animate(panelSubDTR, Util.Effect.Slide, 150, 180);
                btnViewDTRIsClick = true;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        { 
            if (btnViewDTRIsClick)
            {
                Util.Animate(panelSubDTR, Util.Effect.Slide, 150, 180);
                btnViewDTRIsClick = false;
                btnViewDTR.Show();
            }
        }
        private void refreshAllPanel()
        {
            panelMenu.Refresh();
            panelMain.Refresh();
            panelHead.Refresh();
            panelAddUser.Refresh();
            panelViewDTRMonth.Refresh();
            panelIndividualDTR.Refresh();
        }
        private void btnDTRMonth_Click(object sender, EventArgs e)
        {
            if(btnAddUserIsClick) {
                button7.PerformClick();
                for (int i = 111; i < 768; i = i + 10)  {
                    panelMain.Location = new Point(62, i);
                    panelMain.Refresh();
                }
                panelViewDTRMonth.Location = new Point(62, 111);
                Util.Animate(panelViewDTRMonth, Util.Effect.Slide, 150, 180);
            } else {
                for (int i = 111; i < 768; i = i + 10) {
                    panelMain.Location = new Point(62, i);
                    panelMain.Refresh();
                }
                panelViewDTRMonth.Location = new Point(62, 111);
                Util.Animate(panelViewDTRMonth, Util.Effect.Slide, 150, 180);
            }

        }
        private void btnbackDTRMonth_Click(object sender, EventArgs e)
        {
            Util.Animate(panelViewDTRMonth, Util.Effect.Slide, 150, 180); for (int i = 768; i > 111; i = i - 10)
            {
                panelMain.Location = new Point(62, i);
                panelMain.Refresh();
            }
        }
        private void btnBackIndividual_Click(object sender, EventArgs e)
        {
            Util.Animate(panelIndividualDTR, Util.Effect.Slide, 150, 180); for (int i = 768; i > 111; i = i - 10)
            {
                panelMain.Location = new Point(62, i);
                panelMain.Refresh();
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (btnAddUserIsClick)
            {
                button7.PerformClick();
                for (int i = 111; i < 768; i = i + 10)
                {
                    panelMain.Location = new Point(62, i);
                    panelMain.Refresh();
                }
                panelIndividualDTR.Location = new Point(62, 111);
                Util.Animate(panelIndividualDTR, Util.Effect.Slide, 150, 180);
            }
            else
            {
                for (int i = 111; i < 768; i = i + 10)
                {
                    panelMain.Location = new Point(62, i);
                    panelMain.Refresh();
                }
                panelIndividualDTR.Location = new Point(62, 111);
                Util.Animate(panelIndividualDTR, Util.Effect.Slide, 150, 180);
            }
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {

                openFileDialog.Title = "Choose Image File";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                openFileDialog.Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    pictureBoxProfile.BackgroundImage = new Bitmap(openFileDialog.FileName);
                }
        }
 
        private void btnTakePhoto_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //if (txtRFID.Text.Length >= 9) {
            //    serialPort1.Close();
            //} else {
            //    DispString = serialPort1.ReadExisting();
            //    this.Invoke(new EventHandler(DisplayText));
            //}
            Console.WriteLine(serialPort1.ReadExisting());
        }
        private void DisplayText(object sender, EventArgs e)
        {
            txtRFID.Clear();
            txtRFID.PasswordChar = '*';
            txtRFID.AppendText(DispString);
            MessageBox.Show(DispString);
            rfidIstap = true;
        }
        private void btnNeedToTap_Click(object sender, EventArgs e)
        {
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }
        private void AddTextChangedHandler(Control parent)
        {
            foreach (Control c in parent.Controls) {
                if (c.GetType() == typeof(TextBox)) {
                    errorProvider1.SetError(c, "");
                    foreach (string s in panelAddUserString)
                    {
                        if (c.Text.Equals(s, StringComparison.InvariantCulture)) {
                            errorProvider1.SetError(c, "Please enter your " + c.Text);
                            panelAddUserisValidated = true;
                        }  
                    }
                } else {
                    AddTextChangedHandler(c);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelAddUserisValidated = false;
            this.AddTextChangedHandler(panelAddUser);
            if (!panelAddUserisValidated) {
                String getUsername = SELF.GET_ONE("users", "account_name ='" + txtAccountName.Text + "'" , "user_rfid");
                if(!(getUsername == "")) {
                    SELF.PUT("users", new Dictionary<string, string>
                            {
                                { "user_rfid", txtRFID.Text},
                                { "account_name", txtAccountName.Text},
                                { "password", txtPassword.Text}
                            }
                         ); 
                    SELF._query = @"INSERT INTO user_details(user_rfid, first_name, middle_initlal, last_name, gender, account_picture) VALUES (@a,@b,@c,@d,@e,@f)";
                    SELF._command = new MySql.Data.MySqlClient.MySqlCommand(SELF._query, SELF._connect);
                    SELF._command.Parameters.AddWithValue("@a", txtRFID.Text);
                    SELF._command.Parameters.AddWithValue("@b", txtFirstName.Text);
                    SELF._command.Parameters.AddWithValue("@c", txtMiddleInitial.Text);
                    SELF._command.Parameters.AddWithValue("@d", txtLastName.Text);
                    SELF._command.Parameters.AddWithValue("@e", gender);
                    SELF._command.Parameters.AddWithValue("@f", File.ReadAllBytes(openFileDialog.FileName));
                    SELF._command.ExecuteNonQuery();
                    lblMessageBox.Text = "Account created :)";
                    popUpMesssageBox();
                    clearAllInPanelAdduser();
                    SELF._command.Parameters.Clear();
                }
            } else {
                lblMessageBox.Text = "Complete all required fields";
                popUpMesssageBox();

            }
        }
        public void popUpMesssageBox()
        {
            Util.Animate(panelMessageBox, Util.Effect.Slide, 150, 180);
            var t = new Timer();
            t.Interval = 2500;
            t.Tick += (s, a) => {
                Util.Animate(panelMessageBox, Util.Effect.Slide, 150, 180);
                t.Stop();
            };
            t.Start();
        }
        public void clearAllInPanelAdduser()
        {
            pictureBoxProfile.BackgroundImage = Lou.Properties.Resources.account;
            txtRFID.Text = "Value";
            txtRFID.PasswordChar = '\0';
            txtConfirmPass.Text = "Confirm password";
            txtConfirmPass.PasswordChar = '\0';
            txtPassword.Text = "Password";
            txtFirstName.Text = "First Name";
            txtMiddleInitial.Text = "MI";
            txtLastName.Text = "Last Name";
            openFileDialog.FileName = null;
        }
        private void txtFirstName_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text.Equals("First Name", StringComparison.InvariantCulture)) {
                txtFirstName.Clear();
            }
        }
        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtFirstName.Text)) {
                txtFirstName.Text = "First Name";
            }
        }

        private void txtMiddleInitial_Click(object sender, EventArgs e)
        {
            if (txtMiddleInitial.Text.Equals("MI", StringComparison.InvariantCulture)) {
                txtMiddleInitial.Clear();
            }
        }

        private void txtMiddleInitial_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtMiddleInitial.Text)) {
                txtMiddleInitial.Text = "MI";
            }
        }

        private void txtLastName_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text.Equals("Last Name", StringComparison.InvariantCulture)) {
                txtLastName.Clear();
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtLastName.Text)) {
                txtLastName.Text = "Last Name";
            }
        }

        private void txtAccountName_Click(object sender, EventArgs e)
        {
            if (txtAccountName.Text.Equals("Account name", StringComparison.InvariantCulture)) {
                txtAccountName.Clear();
            }
        }

        private void txtAccountName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAccountName.Text)) {
                txtAccountName.Text = "Account name";
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Password", StringComparison.InvariantCulture)){
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPassword.Text)){
                txtPassword.Text = "Password";
                txtPassword.PasswordChar = '\0';
            }
        }

        private void txtConfirmPass_Click(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text.Equals("Confirm password", StringComparison.InvariantCulture)) {
                txtConfirmPass.Clear();
                txtConfirmPass.PasswordChar = '*';
            }
        }

        private void txtConfirmPass_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtConfirmPass.Text)){
                txtConfirmPass.Text = "Confirm password";
                txtConfirmPass.PasswordChar = '\0';
            }
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMale.Checked) {
                gender = "Male";
            }
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
            {
                gender = "Female";
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == ' ')                
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtMiddleInitial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == ' ')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == ' ')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void txtRFID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
