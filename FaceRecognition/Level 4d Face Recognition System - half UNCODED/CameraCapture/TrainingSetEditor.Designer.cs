namespace LiveFaceDetection
{
    partial class TrainingSetEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingSetEditor));
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxFaceName = new System.Windows.Forms.TextBox();
            this.pbCollectedFaces = new System.Windows.Forms.PictureBox();
            this.btnAddtoTS = new System.Windows.Forms.Button();
            this.gBFaceAdder = new System.Windows.Forms.GroupBox();
            this.btnTSFirst = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gbTSUpdate = new System.Windows.Forms.GroupBox();
            this.lblFaceNo = new System.Windows.Forms.Label();
            this.btnLoadTSLast = new System.Windows.Forms.Button();
            this.btnDelFace = new System.Windows.Forms.Button();
            this.pbTSFace = new System.Windows.Forms.PictureBox();
            this.btnUpdateFace = new System.Windows.Forms.Button();
            this.btnTSNxt = new System.Windows.Forms.Button();
            this.txtBoxNewLabel = new System.Windows.Forms.TextBox();
            this.btnTSPrev = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLoadRecog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCollectedFaces)).BeginInit();
            this.gBFaceAdder.SuspendLayout();
            this.gbTSUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTSFace)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCamIndex
            // 
            this.cbCamIndex.FormattingEnabled = true;
            this.cbCamIndex.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbCamIndex.Location = new System.Drawing.Point(315, 444);
            this.cbCamIndex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCamIndex.Name = "cbCamIndex";
            this.cbCamIndex.Size = new System.Drawing.Size(75, 24);
            this.cbCamIndex.TabIndex = 4;
            this.cbCamIndex.Text = "NONE";
            this.cbCamIndex.SelectedIndexChanged += new System.EventHandler(this.cbCamIndex_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 449);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Camera:";
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(395, 443);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(137, 28);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start Live Video!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Scale Increase Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Min Neighbors:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 34);
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
            this.comboBoxScIncRte.Location = new System.Drawing.Point(173, 34);
            this.comboBoxScIncRte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxScIncRte.Name = "comboBoxScIncRte";
            this.comboBoxScIncRte.Size = new System.Drawing.Size(84, 24);
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
            this.comboBoxMinNeigh.Location = new System.Drawing.Point(173, 66);
            this.comboBoxMinNeigh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxMinNeigh.Name = "comboBoxMinNeigh";
            this.comboBoxMinNeigh.Size = new System.Drawing.Size(84, 24);
            this.comboBoxMinNeigh.TabIndex = 14;
            this.comboBoxMinNeigh.Text = "2";
            // 
            // textBoxWinSiz
            // 
            this.textBoxWinSiz.Location = new System.Drawing.Point(173, 100);
            this.textBoxWinSiz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxWinSiz.Name = "textBoxWinSiz";
            this.textBoxWinSiz.Size = new System.Drawing.Size(84, 22);
            this.textBoxWinSiz.TabIndex = 15;
            this.textBoxWinSiz.Text = "25";
            // 
            // CamImageBox
            // 
            this.CamImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CamImageBox.Location = new System.Drawing.Point(12, 80);
            this.CamImageBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CamImageBox.Name = "CamImageBox";
            this.CamImageBox.Size = new System.Drawing.Size(538, 358);
            this.CamImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CamImageBox.TabIndex = 2;
            this.CamImageBox.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 442);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(120, 30);
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
            this.groupBox1.Location = new System.Drawing.Point(580, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(279, 146);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tune Detection Parameters:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(100, 171);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(61, 28);
            this.btnNext.TabIndex = 24;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.Location = new System.Drawing.Point(23, 171);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 28);
            this.btnPrev.TabIndex = 23;
            this.btnPrev.Text = "Prev.";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Set Face Label/Name:";
            // 
            // txtBoxFaceName
            // 
            this.txtBoxFaceName.Enabled = false;
            this.txtBoxFaceName.Location = new System.Drawing.Point(23, 226);
            this.txtBoxFaceName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxFaceName.Name = "txtBoxFaceName";
            this.txtBoxFaceName.Size = new System.Drawing.Size(132, 22);
            this.txtBoxFaceName.TabIndex = 21;
            // 
            // pbCollectedFaces
            // 
            this.pbCollectedFaces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCollectedFaces.Location = new System.Drawing.Point(23, 23);
            this.pbCollectedFaces.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCollectedFaces.Name = "pbCollectedFaces";
            this.pbCollectedFaces.Size = new System.Drawing.Size(138, 140);
            this.pbCollectedFaces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCollectedFaces.TabIndex = 20;
            this.pbCollectedFaces.TabStop = false;
            // 
            // btnAddtoTS
            // 
            this.btnAddtoTS.BackColor = System.Drawing.Color.Plum;
            this.btnAddtoTS.Enabled = false;
            this.btnAddtoTS.Location = new System.Drawing.Point(23, 258);
            this.btnAddtoTS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddtoTS.Name = "btnAddtoTS";
            this.btnAddtoTS.Size = new System.Drawing.Size(153, 28);
            this.btnAddtoTS.TabIndex = 19;
            this.btnAddtoTS.Text = "Add to Training Set";
            this.btnAddtoTS.UseVisualStyleBackColor = false;
            this.btnAddtoTS.Click += new System.EventHandler(this.btnAddtoTS_Click);
            // 
            // gBFaceAdder
            // 
            this.gBFaceAdder.Controls.Add(this.pbCollectedFaces);
            this.gBFaceAdder.Controls.Add(this.btnAddtoTS);
            this.gBFaceAdder.Controls.Add(this.btnNext);
            this.gBFaceAdder.Controls.Add(this.txtBoxFaceName);
            this.gBFaceAdder.Controls.Add(this.btnPrev);
            this.gBFaceAdder.Controls.Add(this.label5);
            this.gBFaceAdder.Location = new System.Drawing.Point(557, 175);
            this.gBFaceAdder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBFaceAdder.Name = "gBFaceAdder";
            this.gBFaceAdder.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gBFaceAdder.Size = new System.Drawing.Size(193, 297);
            this.gBFaceAdder.TabIndex = 26;
            this.gBFaceAdder.TabStop = false;
            this.gBFaceAdder.Text = "Face Adder";
            // 
            // btnTSFirst
            // 
            this.btnTSFirst.Location = new System.Drawing.Point(7, 170);
            this.btnTSFirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTSFirst.Name = "btnTSFirst";
            this.btnTSFirst.Size = new System.Drawing.Size(41, 28);
            this.btnTSFirst.TabIndex = 27;
            this.btnTSFirst.Text = "|<";
            this.btnTSFirst.UseVisualStyleBackColor = true;
            this.btnTSFirst.Click += new System.EventHandler(this.btnTSFirst_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(408, 68);
            this.label6.TabIndex = 27;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // gbTSUpdate
            // 
            this.gbTSUpdate.Controls.Add(this.lblFaceNo);
            this.gbTSUpdate.Controls.Add(this.btnLoadTSLast);
            this.gbTSUpdate.Controls.Add(this.btnTSFirst);
            this.gbTSUpdate.Controls.Add(this.btnDelFace);
            this.gbTSUpdate.Controls.Add(this.pbTSFace);
            this.gbTSUpdate.Controls.Add(this.btnUpdateFace);
            this.gbTSUpdate.Controls.Add(this.btnTSNxt);
            this.gbTSUpdate.Controls.Add(this.txtBoxNewLabel);
            this.gbTSUpdate.Controls.Add(this.btnTSPrev);
            this.gbTSUpdate.Controls.Add(this.label7);
            this.gbTSUpdate.Location = new System.Drawing.Point(759, 175);
            this.gbTSUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTSUpdate.Name = "gbTSUpdate";
            this.gbTSUpdate.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTSUpdate.Size = new System.Drawing.Size(225, 297);
            this.gbTSUpdate.TabIndex = 28;
            this.gbTSUpdate.TabStop = false;
            this.gbTSUpdate.Text = "Training Set Viewer/Updater";
            // 
            // lblFaceNo
            // 
            this.lblFaceNo.AutoSize = true;
            this.lblFaceNo.Location = new System.Drawing.Point(168, 148);
            this.lblFaceNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFaceNo.Name = "lblFaceNo";
            this.lblFaceNo.Size = new System.Drawing.Size(43, 17);
            this.lblFaceNo.TabIndex = 30;
            this.lblFaceNo.Text = "face#";
            // 
            // btnLoadTSLast
            // 
            this.btnLoadTSLast.Location = new System.Drawing.Point(145, 169);
            this.btnLoadTSLast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadTSLast.Name = "btnLoadTSLast";
            this.btnLoadTSLast.Size = new System.Drawing.Size(41, 30);
            this.btnLoadTSLast.TabIndex = 31;
            this.btnLoadTSLast.Text = ">|";
            this.btnLoadTSLast.UseVisualStyleBackColor = true;
            this.btnLoadTSLast.Click += new System.EventHandler(this.btnLoadTSLast_Click);
            // 
            // btnDelFace
            // 
            this.btnDelFace.Location = new System.Drawing.Point(152, 215);
            this.btnDelFace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelFace.Name = "btnDelFace";
            this.btnDelFace.Size = new System.Drawing.Size(63, 52);
            this.btnDelFace.TabIndex = 30;
            this.btnDelFace.Text = "Delete Face";
            this.btnDelFace.UseVisualStyleBackColor = true;
            this.btnDelFace.Click += new System.EventHandler(this.btnDelFace_Click);
            // 
            // pbTSFace
            // 
            this.pbTSFace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTSFace.Location = new System.Drawing.Point(25, 23);
            this.pbTSFace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbTSFace.Name = "pbTSFace";
            this.pbTSFace.Size = new System.Drawing.Size(138, 140);
            this.pbTSFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTSFace.TabIndex = 20;
            this.pbTSFace.TabStop = false;
            // 
            // btnUpdateFace
            // 
            this.btnUpdateFace.Location = new System.Drawing.Point(9, 262);
            this.btnUpdateFace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateFace.Name = "btnUpdateFace";
            this.btnUpdateFace.Size = new System.Drawing.Size(133, 28);
            this.btnUpdateFace.TabIndex = 19;
            this.btnUpdateFace.Text = "Update Face";
            this.btnUpdateFace.UseVisualStyleBackColor = true;
            this.btnUpdateFace.Click += new System.EventHandler(this.btnUpdateFace_Click);
            // 
            // btnTSNxt
            // 
            this.btnTSNxt.Location = new System.Drawing.Point(99, 170);
            this.btnTSNxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTSNxt.Name = "btnTSNxt";
            this.btnTSNxt.Size = new System.Drawing.Size(39, 28);
            this.btnTSNxt.TabIndex = 24;
            this.btnTSNxt.Text = ">";
            this.btnTSNxt.UseVisualStyleBackColor = true;
            this.btnTSNxt.Click += new System.EventHandler(this.btnTSNxt_Click);
            // 
            // txtBoxNewLabel
            // 
            this.txtBoxNewLabel.Location = new System.Drawing.Point(9, 230);
            this.txtBoxNewLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxNewLabel.Name = "txtBoxNewLabel";
            this.txtBoxNewLabel.Size = new System.Drawing.Size(127, 22);
            this.txtBoxNewLabel.TabIndex = 21;
            // 
            // btnTSPrev
            // 
            this.btnTSPrev.Location = new System.Drawing.Point(56, 170);
            this.btnTSPrev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTSPrev.Name = "btnTSPrev";
            this.btnTSPrev.Size = new System.Drawing.Size(35, 28);
            this.btnTSPrev.TabIndex = 23;
            this.btnTSPrev.Text = "<";
            this.btnTSPrev.UseVisualStyleBackColor = true;
            this.btnTSPrev.Click += new System.EventHandler(this.btnTSPrev_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 207);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Modify Face Name?";
            // 
            // btnLoadRecog
            // 
            this.btnLoadRecog.BackColor = System.Drawing.Color.LightGreen;
            this.btnLoadRecog.Location = new System.Drawing.Point(889, 9);
            this.btnLoadRecog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadRecog.Name = "btnLoadRecog";
            this.btnLoadRecog.Size = new System.Drawing.Size(100, 60);
            this.btnLoadRecog.TabIndex = 29;
            this.btnLoadRecog.Text = "load recognizer";
            this.btnLoadRecog.UseVisualStyleBackColor = false;
            this.btnLoadRecog.Click += new System.EventHandler(this.btnLoadRecog_Click);
            // 
            // TrainingSetEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 478);
            this.Controls.Add(this.btnLoadRecog);
            this.Controls.Add(this.gbTSUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gBFaceAdder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCamIndex);
            this.Controls.Add(this.CamImageBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TrainingSetEditor";
            this.Text = "Training Set Editor";
            this.Load += new System.EventHandler(this.TrainingSetEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCollectedFaces)).EndInit();
            this.gBFaceAdder.ResumeLayout(false);
            this.gBFaceAdder.PerformLayout();
            this.gbTSUpdate.ResumeLayout(false);
            this.gbTSUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTSFace)).EndInit();
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
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxFaceName;
        private System.Windows.Forms.PictureBox pbCollectedFaces;
        private System.Windows.Forms.Button btnAddtoTS;
        private System.Windows.Forms.GroupBox gBFaceAdder;
        private System.Windows.Forms.Button btnTSFirst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbTSUpdate;
        private System.Windows.Forms.PictureBox pbTSFace;
        private System.Windows.Forms.Button btnUpdateFace;
        private System.Windows.Forms.Button btnTSNxt;
        private System.Windows.Forms.TextBox txtBoxNewLabel;
        private System.Windows.Forms.Button btnTSPrev;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelFace;
        private System.Windows.Forms.Button btnLoadTSLast;
        private System.Windows.Forms.Label lblFaceNo;
        private System.Windows.Forms.Button btnLoadRecog;
    }
}

