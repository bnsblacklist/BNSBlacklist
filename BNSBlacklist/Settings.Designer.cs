namespace BNSBan
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.recd = new System.Windows.Forms.TabPage();
            this.enableNCS = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.localRecdDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.enableLocalRecd = new System.Windows.Forms.CheckBox();
            this.autodetect = new System.Windows.Forms.TabPage();
            this.ADgap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.screenshotDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enableAD = new System.Windows.Forms.CheckBox();
            this.update = new System.Windows.Forms.TabPage();
            this.checkupd_btn = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.autoinstall = new System.Windows.Forms.CheckBox();
            this.checkupd = new System.Windows.Forms.CheckBox();
            this.about = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.toubns = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.recd.SuspendLayout();
            this.autodetect.SuspendLayout();
            this.update.SuspendLayout();
            this.about.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(185, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "BNS Blacklist Record Checker Settings";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.recd);
            this.tabControl1.Controls.Add(this.autodetect);
            this.tabControl1.Controls.Add(this.update);
            this.tabControl1.Controls.Add(this.about);
            this.tabControl1.Location = new System.Drawing.Point(30, 282);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 355);
            this.tabControl1.TabIndex = 3;
            // 
            // recd
            // 
            this.recd.BackColor = System.Drawing.Color.Black;
            this.recd.Controls.Add(this.enableNCS);
            this.recd.Controls.Add(this.button1);
            this.recd.Controls.Add(this.localRecdDir);
            this.recd.Controls.Add(this.label3);
            this.recd.Controls.Add(this.enableLocalRecd);
            this.recd.ForeColor = System.Drawing.Color.White;
            this.recd.Location = new System.Drawing.Point(4, 22);
            this.recd.Name = "recd";
            this.recd.Padding = new System.Windows.Forms.Padding(3);
            this.recd.Size = new System.Drawing.Size(825, 329);
            this.recd.TabIndex = 0;
            this.recd.Text = "Record Checking";
            // 
            // enableNCS
            // 
            this.enableNCS.AutoSize = true;
            this.enableNCS.Location = new System.Drawing.Point(15, 117);
            this.enableNCS.Name = "enableNCS";
            this.enableNCS.Size = new System.Drawing.Size(745, 17);
            this.enableNCS.TabIndex = 4;
            this.enableNCS.Text = "Enable change of name submission (when a player in online blacklist database chan" +
    "ges his name, automatically report this name change to the manager)";
            this.enableNCS.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(741, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // localRecdDir
            // 
            this.localRecdDir.Location = new System.Drawing.Point(130, 47);
            this.localRecdDir.Name = "localRecdDir";
            this.localRecdDir.Size = new System.Drawing.Size(600, 20);
            this.localRecdDir.TabIndex = 2;
            this.localRecdDir.Text = "./records/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Local record directory:";
            // 
            // enableLocalRecd
            // 
            this.enableLocalRecd.AutoSize = true;
            this.enableLocalRecd.Location = new System.Drawing.Point(15, 18);
            this.enableLocalRecd.Name = "enableLocalRecd";
            this.enableLocalRecd.Size = new System.Drawing.Size(174, 17);
            this.enableLocalRecd.TabIndex = 0;
            this.enableLocalRecd.Text = "Enable Local Record Checking";
            this.enableLocalRecd.UseVisualStyleBackColor = true;
            // 
            // autodetect
            // 
            this.autodetect.BackColor = System.Drawing.Color.Black;
            this.autodetect.Controls.Add(this.ADgap);
            this.autodetect.Controls.Add(this.label6);
            this.autodetect.Controls.Add(this.label5);
            this.autodetect.Controls.Add(this.label4);
            this.autodetect.Controls.Add(this.button2);
            this.autodetect.Controls.Add(this.screenshotDir);
            this.autodetect.Controls.Add(this.label2);
            this.autodetect.Controls.Add(this.enableAD);
            this.autodetect.ForeColor = System.Drawing.Color.White;
            this.autodetect.Location = new System.Drawing.Point(4, 22);
            this.autodetect.Name = "autodetect";
            this.autodetect.Padding = new System.Windows.Forms.Padding(3);
            this.autodetect.Size = new System.Drawing.Size(825, 329);
            this.autodetect.TabIndex = 1;
            this.autodetect.Text = "Auto Detection";
            // 
            // ADgap
            // 
            this.ADgap.Location = new System.Drawing.Point(196, 75);
            this.ADgap.Name = "ADgap";
            this.ADgap.Size = new System.Drawing.Size(100, 20);
            this.ADgap.TabIndex = 10;
            this.ADgap.Text = "15";
            this.ADgap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ADgap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ADgap_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(373, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "This feature is not implemented at this moment. Please wait for future updates.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "seconds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Auto detect frequency: check every";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(732, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // screenshotDir
            // 
            this.screenshotDir.Location = new System.Drawing.Point(149, 43);
            this.screenshotDir.Name = "screenshotDir";
            this.screenshotDir.Size = new System.Drawing.Size(562, 20);
            this.screenshotDir.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BNS screenshot directory:";
            // 
            // enableAD
            // 
            this.enableAD.AutoSize = true;
            this.enableAD.Location = new System.Drawing.Point(16, 17);
            this.enableAD.Name = "enableAD";
            this.enableAD.Size = new System.Drawing.Size(604, 17);
            this.enableAD.TabIndex = 0;
            this.enableAD.Text = "Enable character name auto detect (After screenshoot automatically popup a window" +
    " and check each person in the party.)";
            this.enableAD.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Black;
            this.update.Controls.Add(this.checkupd_btn);
            this.update.Controls.Add(this.version);
            this.update.Controls.Add(this.label8);
            this.update.Controls.Add(this.label7);
            this.update.Controls.Add(this.autoinstall);
            this.update.Controls.Add(this.checkupd);
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Location = new System.Drawing.Point(4, 22);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(825, 329);
            this.update.TabIndex = 2;
            this.update.Text = "Update";
            // 
            // checkupd_btn
            // 
            this.checkupd_btn.ForeColor = System.Drawing.Color.Black;
            this.checkupd_btn.Location = new System.Drawing.Point(654, 73);
            this.checkupd_btn.Name = "checkupd_btn";
            this.checkupd_btn.Size = new System.Drawing.Size(103, 23);
            this.checkupd_btn.TabIndex = 13;
            this.checkupd_btn.Text = "check for updates";
            this.checkupd_btn.UseVisualStyleBackColor = true;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.Location = new System.Drawing.Point(628, 42);
            this.version.MinimumSize = new System.Drawing.Size(150, 16);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(150, 16);
            this.version.TabIndex = 12;
            this.version.Text = "version";
            this.version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(627, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Current Version";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(373, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "This feature is not implemented at this moment. Please wait for future updates.";
            // 
            // autoinstall
            // 
            this.autoinstall.AutoSize = true;
            this.autoinstall.Location = new System.Drawing.Point(15, 40);
            this.autoinstall.Name = "autoinstall";
            this.autoinstall.Size = new System.Drawing.Size(262, 17);
            this.autoinstall.TabIndex = 1;
            this.autoinstall.Text = "Auto download and install updates when available";
            this.autoinstall.UseVisualStyleBackColor = true;
            // 
            // checkupd
            // 
            this.checkupd.AutoSize = true;
            this.checkupd.Location = new System.Drawing.Point(15, 15);
            this.checkupd.Name = "checkupd";
            this.checkupd.Size = new System.Drawing.Size(222, 17);
            this.checkupd.TabIndex = 0;
            this.checkupd.Text = "Check updates at the start of the program";
            this.checkupd.UseVisualStyleBackColor = true;
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.Black;
            this.about.Controls.Add(this.label13);
            this.about.Controls.Add(this.toubns);
            this.about.Controls.Add(this.linkLabel1);
            this.about.Controls.Add(this.label12);
            this.about.Controls.Add(this.label11);
            this.about.Controls.Add(this.label10);
            this.about.ForeColor = System.Drawing.Color.White;
            this.about.Location = new System.Drawing.Point(4, 22);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(825, 329);
            this.about.TabIndex = 3;
            this.about.Text = "About";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 294);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "For more information, see:";
            // 
            // toubns
            // 
            this.toubns.AutoSize = true;
            this.toubns.LinkColor = System.Drawing.Color.Red;
            this.toubns.Location = new System.Drawing.Point(5, 312);
            this.toubns.Name = "toubns";
            this.toubns.Size = new System.Drawing.Size(179, 13);
            this.toubns.TabIndex = 4;
            this.toubns.TabStop = true;
            this.toubns.Text = "CONTENT TERMS OF USE of BNS";
            this.toubns.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.toubns_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(756, 305);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 20);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Privacy";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 39);
            this.label12.TabIndex = 2;
            this.label12.Text = "Markdig\r\nTesseract\r\nSilveress BNS API";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Third Party Libraries && APIs:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 9);
            this.label10.MinimumSize = new System.Drawing.Size(800, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(800, 48);
            this.label10.TabIndex = 0;
            this.label10.Text = "BNS Blacklist By Kroulis\r\nGame content and assets are copyrights and/or trademark" +
    "s of NCSOFT Corporation.\r\nBnSBlacklist is not affiliated with NCSOFT Corporation" +
    " or Team Bloodlust.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(689, 275);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 4;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(775, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BNSBan.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(230, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 203);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(888, 649);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.save);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabControl1.ResumeLayout(false);
            this.recd.ResumeLayout(false);
            this.recd.PerformLayout();
            this.autodetect.ResumeLayout(false);
            this.autodetect.PerformLayout();
            this.update.ResumeLayout(false);
            this.update.PerformLayout();
            this.about.ResumeLayout(false);
            this.about.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage recd;
        private System.Windows.Forms.TabPage autodetect;
        private System.Windows.Forms.CheckBox enableLocalRecd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox localRecdDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox enableNCS;
        private System.Windows.Forms.TabPage update;
        private System.Windows.Forms.TabPage about;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox enableAD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox screenshotDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkupd;
        private System.Windows.Forms.CheckBox autoinstall;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Button checkupd_btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel toubns;
        private System.Windows.Forms.TextBox ADgap;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button button3;
    }
}