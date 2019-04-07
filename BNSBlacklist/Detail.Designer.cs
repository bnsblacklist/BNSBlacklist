namespace BNSBan
{
    partial class Detail
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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "0", System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(73)))), ((int)(((byte)(104))))), new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "None", System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(73)))), ((int)(((byte)(104))))), new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)))),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "None", System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(73)))), ((int)(((byte)(104))))), new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))))}, -1);
            this.charname = new System.Windows.Forms.Label();
            this.charinfo = new System.Windows.Forms.Label();
            this.aplarge = new System.Windows.Forms.Label();
            this.hplarge = new System.Windows.Forms.Label();
            this.apsmall = new System.Windows.Forms.Label();
            this.hpsmall = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.equipments = new System.Windows.Forms.ListBox();
            this.record = new System.Windows.Forms.ListView();
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Reason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RecordLink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.img = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.altlist = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // charname
            // 
            this.charname.AutoSize = true;
            this.charname.BackColor = System.Drawing.Color.Transparent;
            this.charname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charname.ForeColor = System.Drawing.Color.White;
            this.charname.Location = new System.Drawing.Point(79, 50);
            this.charname.Name = "charname";
            this.charname.Size = new System.Drawing.Size(519, 24);
            this.charname.TabIndex = 0;
            this.charname.Text = "CharacterName [Red Banned Yellow Warning White Normal]";
            // 
            // charinfo
            // 
            this.charinfo.AutoSize = true;
            this.charinfo.BackColor = System.Drawing.Color.Transparent;
            this.charinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charinfo.ForeColor = System.Drawing.Color.White;
            this.charinfo.Location = new System.Drawing.Point(82, 76);
            this.charinfo.Name = "charinfo";
            this.charinfo.Size = new System.Drawing.Size(364, 16);
            this.charinfo.TabIndex = 1;
            this.charinfo.Text = "Class [Build] | Level XX · Hongmong Level XX | Server | Guild";
            // 
            // aplarge
            // 
            this.aplarge.AutoSize = true;
            this.aplarge.BackColor = System.Drawing.Color.Transparent;
            this.aplarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aplarge.ForeColor = System.Drawing.Color.Lime;
            this.aplarge.Location = new System.Drawing.Point(307, 163);
            this.aplarge.MaximumSize = new System.Drawing.Size(180, 40);
            this.aplarge.MinimumSize = new System.Drawing.Size(180, 40);
            this.aplarge.Name = "aplarge";
            this.aplarge.Size = new System.Drawing.Size(180, 40);
            this.aplarge.TabIndex = 2;
            this.aplarge.Text = "AP Number";
            this.aplarge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hplarge
            // 
            this.hplarge.AutoSize = true;
            this.hplarge.BackColor = System.Drawing.Color.Transparent;
            this.hplarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hplarge.ForeColor = System.Drawing.Color.Lime;
            this.hplarge.Location = new System.Drawing.Point(555, 163);
            this.hplarge.MaximumSize = new System.Drawing.Size(180, 40);
            this.hplarge.MinimumSize = new System.Drawing.Size(180, 40);
            this.hplarge.Name = "hplarge";
            this.hplarge.Size = new System.Drawing.Size(180, 40);
            this.hplarge.TabIndex = 3;
            this.hplarge.Text = "HP Number";
            this.hplarge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // apsmall
            // 
            this.apsmall.AutoSize = true;
            this.apsmall.BackColor = System.Drawing.Color.Transparent;
            this.apsmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apsmall.ForeColor = System.Drawing.Color.Lime;
            this.apsmall.Location = new System.Drawing.Point(405, 254);
            this.apsmall.MaximumSize = new System.Drawing.Size(100, 20);
            this.apsmall.MinimumSize = new System.Drawing.Size(10, 20);
            this.apsmall.Name = "apsmall";
            this.apsmall.Size = new System.Drawing.Size(86, 20);
            this.apsmall.TabIndex = 4;
            this.apsmall.Text = "AP Number";
            this.apsmall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hpsmall
            // 
            this.hpsmall.AutoSize = true;
            this.hpsmall.BackColor = System.Drawing.Color.Transparent;
            this.hpsmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpsmall.ForeColor = System.Drawing.Color.Lime;
            this.hpsmall.Location = new System.Drawing.Point(649, 254);
            this.hpsmall.MaximumSize = new System.Drawing.Size(100, 20);
            this.hpsmall.MinimumSize = new System.Drawing.Size(10, 20);
            this.hpsmall.Name = "hpsmall";
            this.hpsmall.Size = new System.Drawing.Size(86, 20);
            this.hpsmall.TabIndex = 5;
            this.hpsmall.Text = "AP Number";
            this.hpsmall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(278, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ban/ Warning Record:";
            // 
            // equipments
            // 
            this.equipments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(73)))), ((int)(((byte)(104)))));
            this.equipments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipments.ForeColor = System.Drawing.Color.White;
            this.equipments.HorizontalScrollbar = true;
            this.equipments.ItemHeight = 20;
            this.equipments.Items.AddRange(new object[] {
            "Weapon: xxx",
            "Ring: xxx"});
            this.equipments.Location = new System.Drawing.Point(780, 108);
            this.equipments.Name = "equipments";
            this.equipments.Size = new System.Drawing.Size(279, 542);
            this.equipments.TabIndex = 7;
            // 
            // record
            // 
            this.record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(73)))), ((int)(((byte)(104)))));
            this.record.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Code,
            this.Reason,
            this.RecordLink});
            this.record.ForeColor = System.Drawing.Color.White;
            this.record.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.record.HideSelection = false;
            listViewItem4.StateImageIndex = 0;
            this.record.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4});
            this.record.Location = new System.Drawing.Point(281, 318);
            this.record.MultiSelect = false;
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(492, 332);
            this.record.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.record.TabIndex = 8;
            this.record.UseCompatibleStateImageBehavior = false;
            this.record.View = System.Windows.Forms.View.Details;
            // 
            // Code
            // 
            this.Code.Text = "RCode";
            // 
            // Reason
            // 
            this.Reason.Text = "Reason";
            this.Reason.Width = 200;
            // 
            // RecordLink
            // 
            this.RecordLink.Text = "RecordLink";
            this.RecordLink.Width = 232;
            // 
            // img
            // 
            this.img.Image = global::BNSBan.Properties.Resources.nocharimg;
            this.img.Location = new System.Drawing.Point(22, 108);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(246, 392);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img.TabIndex = 9;
            this.img.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Alts List:";
            // 
            // altlist
            // 
            this.altlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(73)))), ((int)(((byte)(104)))));
            this.altlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.altlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altlist.ForeColor = System.Drawing.Color.White;
            this.altlist.ItemHeight = 16;
            this.altlist.Items.AddRange(new object[] {
            "Alt 1",
            "Alt 2",
            "Alt 3",
            "Alt 4",
            "Alt 5",
            "Alt 6",
            "Alt 7",
            "Alt 8"});
            this.altlist.Location = new System.Drawing.Point(26, 535);
            this.altlist.MaximumSize = new System.Drawing.Size(240, 120);
            this.altlist.MinimumSize = new System.Drawing.Size(240, 120);
            this.altlist.Name = "altlist";
            this.altlist.Size = new System.Drawing.Size(240, 114);
            this.altlist.TabIndex = 11;
            this.altlist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.altlist_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BNSBan.Properties.Resources.detailbox;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1069, 707);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::BNSBan.Properties.Resources.detailbox;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1070, 708);
            this.Controls.Add(this.altlist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.img);
            this.Controls.Add(this.record);
            this.Controls.Add(this.equipments);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hpsmall);
            this.Controls.Add(this.apsmall);
            this.Controls.Add(this.hplarge);
            this.Controls.Add(this.aplarge);
            this.Controls.Add(this.charinfo);
            this.Controls.Add(this.charname);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Detail";
            this.Text = "Detail";
            this.Load += new System.EventHandler(this.Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label charname;
        private System.Windows.Forms.Label charinfo;
        private System.Windows.Forms.Label aplarge;
        private System.Windows.Forms.Label hplarge;
        private System.Windows.Forms.Label apsmall;
        private System.Windows.Forms.Label hpsmall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox equipments;
        private System.Windows.Forms.ListView record;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader Reason;
        private System.Windows.Forms.ColumnHeader RecordLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox altlist;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}