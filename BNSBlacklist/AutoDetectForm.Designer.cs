namespace BNSBan
{
    partial class AutoDetectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoDetectForm));
            this.label1 = new System.Windows.Forms.Label();
            this.autoDetectTimer = new System.Windows.Forms.Timer(this.components);
            this.F2SurviceStatus = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PartyProfileStatus = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.characterName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.recent = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.tprogress = new System.Windows.Forms.ProgressBar();
            this.resetTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.F2SurviceStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartyProfileStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Auto Detection System";
            // 
            // autoDetectTimer
            // 
            this.autoDetectTimer.Interval = 15000;
            this.autoDetectTimer.Tick += new System.EventHandler(this.autoDetectTimer_Tick);
            // 
            // F2SurviceStatus
            // 
            this.F2SurviceStatus.Image = ((System.Drawing.Image)(resources.GetObject("F2SurviceStatus.Image")));
            this.F2SurviceStatus.Location = new System.Drawing.Point(282, 39);
            this.F2SurviceStatus.Name = "F2SurviceStatus";
            this.F2SurviceStatus.Size = new System.Drawing.Size(32, 32);
            this.F2SurviceStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.F2SurviceStatus.TabIndex = 2;
            this.F2SurviceStatus.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BNSBan.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "F2 Profile Auto Detect";
            // 
            // PartyProfileStatus
            // 
            this.PartyProfileStatus.Image = ((System.Drawing.Image)(resources.GetObject("PartyProfileStatus.Image")));
            this.PartyProfileStatus.Location = new System.Drawing.Point(282, 77);
            this.PartyProfileStatus.Name = "PartyProfileStatus";
            this.PartyProfileStatus.Size = new System.Drawing.Size(32, 32);
            this.PartyProfileStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PartyProfileStatus.TabIndex = 4;
            this.PartyProfileStatus.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Party Member Auto Detect";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "System is checking every ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 128);
            this.label5.MinimumSize = new System.Drawing.Size(40, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "15";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(479, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "seconds";
            // 
            // characterName
            // 
            this.characterName.Location = new System.Drawing.Point(32, 232);
            this.characterName.Name = "characterName";
            this.characterName.Size = new System.Drawing.Size(487, 20);
            this.characterName.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Most Recent Detected Character Name:";
            // 
            // recent
            // 
            this.recent.AutoSize = true;
            this.recent.LinkColor = System.Drawing.Color.Yellow;
            this.recent.Location = new System.Drawing.Point(233, 202);
            this.recent.Name = "recent";
            this.recent.Size = new System.Drawing.Size(103, 13);
            this.recent.TabIndex = 11;
            this.recent.TabStop = true;
            this.recent.Text = "No Detection Result";
            this.recent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.recent_LinkClicked);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(529, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tprogress
            // 
            this.tprogress.Location = new System.Drawing.Point(272, 147);
            this.tprogress.Name = "tprogress";
            this.tprogress.Size = new System.Drawing.Size(332, 10);
            this.tprogress.TabIndex = 13;
            // 
            // resetTimer
            // 
            this.resetTimer.Interval = 1000;
            this.resetTimer.Tick += new System.EventHandler(this.resetTimer_Tick);
            // 
            // AutoDetectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(622, 471);
            this.Controls.Add(this.tprogress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.recent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.characterName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PartyProfileStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.F2SurviceStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.MaximizeBox = false;
            this.Name = "AutoDetectForm";
            this.Text = "BNSBlacklist - AutoDetect";
            this.Load += new System.EventHandler(this.AutoDetectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.F2SurviceStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartyProfileStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer autoDetectTimer;
        private System.Windows.Forms.PictureBox F2SurviceStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PartyProfileStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox characterName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel recent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar tprogress;
        private System.Windows.Forms.Timer resetTimer;
    }
}