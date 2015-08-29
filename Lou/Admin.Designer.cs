namespace Lou
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackMenu = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnPic = new RoundButton();
            this.panel5.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel5.Controls.Add(this.btnMenu);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1366, 87);
            this.panel5.TabIndex = 7;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(53, 346);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(287, 45);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Butial, Ralph";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1212, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sign out";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.btnBackMenu);
            this.panelMenu.Controls.Add(this.btnPic);
            this.panelMenu.Controls.Add(this.btnStart);
            this.panelMenu.Location = new System.Drawing.Point(116, 127);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(388, 768);
            this.panelMenu.TabIndex = 9;
            this.panelMenu.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(0, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 371);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 86);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hi,";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBackMenu.BackgroundImage = global::Lou.Properties.Resources.left_arrow1;
            this.btnBackMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackMenu.FlatAppearance.BorderSize = 0;
            this.btnBackMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackMenu.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackMenu.ForeColor = System.Drawing.Color.White;
            this.btnBackMenu.Location = new System.Drawing.Point(289, 11);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(89, 63);
            this.btnBackMenu.TabIndex = 9;
            this.btnBackMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackMenu.UseVisualStyleBackColor = false;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMenu.BackgroundImage = global::Lou.Properties.Resources.menu;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(36, 16);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(62, 56);
            this.btnMenu.TabIndex = 10;
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnPic
            // 
            this.btnPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPic.BackgroundImage")));
            this.btnPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPic.Location = new System.Drawing.Point(73, 98);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(243, 232);
            this.btnPic.TabIndex = 0;
            this.btnPic.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel5.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private RoundButton btnPic;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnBackMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
    }
}