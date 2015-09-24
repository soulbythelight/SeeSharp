namespace LiveFaceDetection
{
    partial class FaceRecogger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaceRecogger));
            this.cbCamIndex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxScIncRte = new System.Windows.Forms.ComboBox();
            this.comboBoxMinNeigh = new System.Windows.Forms.ComboBox();
            this.textBoxWinSiz = new System.Windows.Forms.TextBox();
            this.CamImageBox = new Emgu.CV.UI.ImageBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.pbRecog = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTrainRecog = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOpnTSeditor = new System.Windows.Forms.Button();
            this.ImBoxEigen = new Emgu.CV.UI.ImageBox();
            this.gbEigen = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAvgFace = new System.Windows.Forms.Button();
            this.btnViewEigen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImBoxEigen)).BeginInit();
            this.gbEigen.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCamIndex
            // 
            this.cbCamIndex.FormattingEnabled = true;
            this.cbCamIndex.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbCamIndex.Location = new System.Drawing.Point(210, 356);
            this.cbCamIndex.Name = "cbCamIndex";
            this.cbCamIndex.Size = new System.Drawing.Size(57, 21);
            this.cbCamIndex.TabIndex = 4;
            this.cbCamIndex.Text = "NONE";
            this.cbCamIndex.SelectedIndexChanged += new System.EventHandler(this.cbCamIndex_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Camera:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(273, 355);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start Live Video!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Scale Increase Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Min Neighbors:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Min.detection Scale\r\n(Window Size)";
            // 
            // comboBoxScIncRte
            // 
            this.comboBoxScIncRte.FormattingEnabled = true;
            this.comboBoxScIncRte.Items.AddRange(new object[] {
            "1.1",
            "1.2",
            "1.3",
            "1.4"});
            this.comboBoxScIncRte.Location = new System.Drawing.Point(130, 28);
            this.comboBoxScIncRte.Name = "comboBoxScIncRte";
            this.comboBoxScIncRte.Size = new System.Drawing.Size(64, 21);
            this.comboBoxScIncRte.TabIndex = 13;
            this.comboBoxScIncRte.Text = "1.1";
            // 
            // comboBoxMinNeigh
            // 
            this.comboBoxMinNeigh.FormattingEnabled = true;
            this.comboBoxMinNeigh.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxMinNeigh.Location = new System.Drawing.Point(130, 54);
            this.comboBoxMinNeigh.Name = "comboBoxMinNeigh";
            this.comboBoxMinNeigh.Size = new System.Drawing.Size(64, 21);
            this.comboBoxMinNeigh.TabIndex = 14;
            this.comboBoxMinNeigh.Text = "2";
            // 
            // textBoxWinSiz
            // 
            this.textBoxWinSiz.Location = new System.Drawing.Point(130, 81);
            this.textBoxWinSiz.Name = "textBoxWinSiz";
            this.textBoxWinSiz.Size = new System.Drawing.Size(64, 20);
            this.textBoxWinSiz.TabIndex = 15;
            this.textBoxWinSiz.Text = "25";
            // 
            // CamImageBox
            // 
            this.CamImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CamImageBox.Location = new System.Drawing.Point(10, 64);
            this.CamImageBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CamImageBox.Name = "CamImageBox";
            this.CamImageBox.Size = new System.Drawing.Size(366, 282);
            this.CamImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CamImageBox.TabIndex = 2;
            this.CamImageBox.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(10, 354);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(89, 26);
            this.btnBrowse.TabIndex = 17;
            this.btnBrowse.Text = "Browse Image";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxWinSiz);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxMinNeigh);
            this.groupBox1.Controls.Add(this.comboBoxScIncRte);
            this.groupBox1.Location = new System.Drawing.Point(397, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(206, 119);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tune Detection Parameters:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(357, 52);
            this.label6.TabIndex = 27;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // pbRecog
            // 
            this.pbRecog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRecog.Location = new System.Drawing.Point(398, 155);
            this.pbRecog.Name = "pbRecog";
            this.pbRecog.Size = new System.Drawing.Size(102, 108);
            this.pbRecog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRecog.TabIndex = 28;
            this.pbRecog.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Face Name";
            // 
            // btnTrainRecog
            // 
            this.btnTrainRecog.BackColor = System.Drawing.Color.LightGreen;
            this.btnTrainRecog.Location = new System.Drawing.Point(397, 292);
            this.btnTrainRecog.Name = "btnTrainRecog";
            this.btnTrainRecog.Size = new System.Drawing.Size(103, 45);
            this.btnTrainRecog.TabIndex = 30;
            this.btnTrainRecog.Text = "Train the Recognizer";
            this.btnTrainRecog.UseVisualStyleBackColor = false;
            this.btnTrainRecog.Click += new System.EventHandler(this.btnTrainRecog_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Loaded Face:";
            // 
            // btnOpnTSeditor
            // 
            this.btnOpnTSeditor.BackColor = System.Drawing.Color.Plum;
            this.btnOpnTSeditor.Location = new System.Drawing.Point(397, 343);
            this.btnOpnTSeditor.Name = "btnOpnTSeditor";
            this.btnOpnTSeditor.Size = new System.Drawing.Size(103, 37);
            this.btnOpnTSeditor.TabIndex = 32;
            this.btnOpnTSeditor.Text = "Edit Training Set";
            this.btnOpnTSeditor.UseVisualStyleBackColor = false;
            this.btnOpnTSeditor.Click += new System.EventHandler(this.btnOpnTSeditor_Click);
            // 
            // ImBoxEigen
            // 
            this.ImBoxEigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImBoxEigen.Location = new System.Drawing.Point(28, 18);
            this.ImBoxEigen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImBoxEigen.Name = "ImBoxEigen";
            this.ImBoxEigen.Size = new System.Drawing.Size(95, 107);
            this.ImBoxEigen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImBoxEigen.TabIndex = 33;
            this.ImBoxEigen.TabStop = false;
            // 
            // gbEigen
            // 
            this.gbEigen.Controls.Add(this.label8);
            this.gbEigen.Controls.Add(this.btnAvgFace);
            this.gbEigen.Controls.Add(this.btnViewEigen);
            this.gbEigen.Controls.Add(this.ImBoxEigen);
            this.gbEigen.Location = new System.Drawing.Point(510, 139);
            this.gbEigen.Name = "gbEigen";
            this.gbEigen.Size = new System.Drawing.Size(144, 241);
            this.gbEigen.TabIndex = 34;
            this.gbEigen.TabStop = false;
            this.gbEigen.Text = "EigenFace Viewer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Shown Above is...";
            // 
            // btnAvgFace
            // 
            this.btnAvgFace.Enabled = false;
            this.btnAvgFace.Location = new System.Drawing.Point(17, 199);
            this.btnAvgFace.Name = "btnAvgFace";
            this.btnAvgFace.Size = new System.Drawing.Size(108, 32);
            this.btnAvgFace.TabIndex = 36;
            this.btnAvgFace.Text = "View Average Face";
            this.btnAvgFace.UseVisualStyleBackColor = true;
            this.btnAvgFace.Click += new System.EventHandler(this.btnAvgFace_Click);
            // 
            // btnViewEigen
            // 
            this.btnViewEigen.Enabled = false;
            this.btnViewEigen.Location = new System.Drawing.Point(17, 153);
            this.btnViewEigen.Name = "btnViewEigen";
            this.btnViewEigen.Size = new System.Drawing.Size(108, 40);
            this.btnViewEigen.TabIndex = 35;
            this.btnViewEigen.Text = "View Calculated Eigen Faces";
            this.btnViewEigen.UseVisualStyleBackColor = true;
            this.btnViewEigen.Click += new System.EventHandler(this.btnViewEigen_Click);
            // 
            // FaceRecogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 389);
            this.Controls.Add(this.gbEigen);
            this.Controls.Add(this.btnOpnTSeditor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTrainRecog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbRecog);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCamIndex);
            this.Controls.Add(this.CamImageBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FaceRecogger";
            this.Text = "Face Recognizer";
            this.Load += new System.EventHandler(this.FaceRecognizer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImBoxEigen)).EndInit();
            this.gbEigen.ResumeLayout(false);
            this.gbEigen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCamIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxScIncRte;
        private System.Windows.Forms.ComboBox comboBoxMinNeigh;
        private System.Windows.Forms.TextBox textBoxWinSiz;
        private Emgu.CV.UI.ImageBox CamImageBox;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbRecog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTrainRecog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOpnTSeditor;
        private Emgu.CV.UI.ImageBox ImBoxEigen;
        private System.Windows.Forms.GroupBox gbEigen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAvgFace;
        private System.Windows.Forms.Button btnViewEigen;
    }
}

