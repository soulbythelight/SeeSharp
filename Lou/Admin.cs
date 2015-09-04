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
        static Administer.Query SELF = new Administer.Query();
        protected bool btnAddUserIsClick = false;
        protected bool btnViewDTRIsClick = false;
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
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Choose Image File";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                openFileDialog.Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    btnOpenFile.BackgroundImage = new Bitmap(openFileDialog.FileName);
                }
                // store file path in some field or textbox...
                //textBox1.Text = openFileDialog.FileName;
            }
        }
 
        private void btnTakePhoto_Click(object sender, EventArgs e)
        {
          
        }
    }
}
