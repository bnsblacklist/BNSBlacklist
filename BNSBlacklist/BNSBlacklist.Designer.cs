namespace BNSBan
{
    partial class BNSBlacklist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BNSBlacklist));
            this.charname = new System.Windows.Forms.TextBox();
            this.spkb = new System.Windows.Forms.Button();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.detailsbtn = new System.Windows.Forms.Button();
            this.statusImg = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.settings = new System.Windows.Forms.PictureBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.autoDetectShowHideTimer = new System.Windows.Forms.Timer(this.components);
            this.resultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // charname
            // 
            this.charname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charname.Location = new System.Drawing.Point(375, 82);
            this.charname.Name = "charname";
            this.charname.Size = new System.Drawing.Size(462, 26);
            this.charname.TabIndex = 2;
            this.charname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.charname_KeyDown);
            // 
            // spkb
            // 
            this.spkb.Location = new System.Drawing.Point(851, 82);
            this.spkb.Name = "spkb";
            this.spkb.Size = new System.Drawing.Size(112, 26);
            this.spkb.TabIndex = 3;
            this.spkb.Text = "SP Char Keyboard";
            this.spkb.UseVisualStyleBackColor = true;
            this.spkb.Click += new System.EventHandler(this.spkb_Click);
            // 
            // resultPanel
            // 
            this.resultPanel.BackColor = System.Drawing.Color.Black;
            this.resultPanel.Controls.Add(this.detailsbtn);
            this.resultPanel.Controls.Add(this.statusImg);
            this.resultPanel.Controls.Add(this.pictureBox3);
            this.resultPanel.Location = new System.Drawing.Point(12, 207);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(951, 100);
            this.resultPanel.TabIndex = 7;
            this.resultPanel.Visible = false;
            // 
            // detailsbtn
            // 
            this.detailsbtn.BackColor = System.Drawing.Color.Black;
            this.detailsbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("detailsbtn.BackgroundImage")));
            this.detailsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.detailsbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.detailsbtn.FlatAppearance.BorderSize = 0;
            this.detailsbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.detailsbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.detailsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detailsbtn.ImageIndex = 0;
            this.detailsbtn.Location = new System.Drawing.Point(689, 22);
            this.detailsbtn.Name = "detailsbtn";
            this.detailsbtn.Size = new System.Drawing.Size(200, 60);
            this.detailsbtn.TabIndex = 9;
            this.detailsbtn.UseVisualStyleBackColor = false;
            this.detailsbtn.Click += new System.EventHandler(this.detailsbtn_Click);
            this.detailsbtn.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.detailsbtn.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // statusImg
            // 
            this.statusImg.Location = new System.Drawing.Point(210, 22);
            this.statusImg.Name = "statusImg";
            this.statusImg.Size = new System.Drawing.Size(400, 60);
            this.statusImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusImg.TabIndex = 8;
            this.statusImg.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.BackgroundImage = global::BNSBan.Properties.Resources.result;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(14, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(178, 53);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.Black;
            this.settings.Image = global::BNSBan.Properties.Resources.setting;
            this.settings.Location = new System.Drawing.Point(12, 12);
            this.settings.MaximumSize = new System.Drawing.Size(32, 32);
            this.settings.MinimumSize = new System.Drawing.Size(32, 32);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(32, 32);
            this.settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settings.TabIndex = 8;
            this.settings.TabStop = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.Black;
            this.searchbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchbtn.BackgroundImage")));
            this.searchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.searchbtn.FlatAppearance.BorderSize = 0;
            this.searchbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.searchbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.ImageIndex = 0;
            this.searchbtn.Location = new System.Drawing.Point(384, 127);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(200, 60);
            this.searchbtn.TabIndex = 5;
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.button2_Click);
            this.searchbtn.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.searchbtn.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.BackgroundImage = global::BNSBan.Properties.Resources.playername;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(359, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 53);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::BNSBan.Properties.Resources.logo;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(981, 322);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // autoDetectShowHideTimer
            // 
            this.autoDetectShowHideTimer.Enabled = true;
            this.autoDetectShowHideTimer.Interval = 1000;
            this.autoDetectShowHideTimer.Tick += new System.EventHandler(this.autoDetectShowHideTimer_Tick);
            // 
            // BNSBlacklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 319);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.resultPanel);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.spkb);
            this.Controls.Add(this.charname);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BNSBlacklist";
            this.Text = "BnsBlacklist";
            this.Load += new System.EventHandler(this.BNSBan_Load);
            this.resultPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox charname;
        private System.Windows.Forms.Button spkb;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox statusImg;
        private System.Windows.Forms.Button detailsbtn;
        private System.Windows.Forms.PictureBox settings;
        private System.Windows.Forms.Timer autoDetectShowHideTimer;
    }
}

