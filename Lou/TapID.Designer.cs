namespace Lou
{
    partial class TapID
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lbltapYourID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.roundButton1 = new RoundButton();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Light", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(800, -13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(410, 128);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "12:41 AM";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(828, 91);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(350, 45);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Tuesday, August 25, 2015";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CadetBlue;
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.lblDate);
            this.panel5.Controls.Add(this.lblTime);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.lblLogo);
            this.panel5.Location = new System.Drawing.Point(0, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1367, 139);
            this.panel5.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lou.Properties.Resources.ic_cast_white_48dp_2x;
            this.pictureBox1.Location = new System.Drawing.Point(31, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("CLiCHE 21", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(115, 57);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(198, 43);
            this.lblLogo.TabIndex = 13;
            this.lblLogo.Text = "LILOUMIAN";
            // 
            // lbltapYourID
            // 
            this.lbltapYourID.AutoSize = true;
            this.lbltapYourID.BackColor = System.Drawing.Color.Transparent;
            this.lbltapYourID.Font = new System.Drawing.Font("Segoe UI Light", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltapYourID.ForeColor = System.Drawing.Color.SlateGray;
            this.lbltapYourID.Location = new System.Drawing.Point(200, 379);
            this.lbltapYourID.Name = "lbltapYourID";
            this.lbltapYourID.Size = new System.Drawing.Size(981, 128);
            this.lbltapYourID.TabIndex = 12;
            this.lbltapYourID.Text = "Tap your card to Log in";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(84, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 768);
            this.panel2.TabIndex = 13;
            this.panel2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.roundButton1);
            this.panel1.Location = new System.Drawing.Point(536, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 412);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(457, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.LightGray;
            this.roundButton1.Location = new System.Drawing.Point(60, 82);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(256, 254);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // TapID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbltapYourID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TapID";
            this.Text = "TapID";
            this.Load += new System.EventHandler(this.TapID_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbltapYourID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private RoundButton roundButton1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBox1;
    }
}