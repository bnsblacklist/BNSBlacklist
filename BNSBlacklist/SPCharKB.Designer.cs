namespace BNSBan
{
    partial class SPCharKB
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
            System.Windows.Forms.ListViewItem listViewItem31 = new System.Windows.Forms.ListViewItem("A");
            System.Windows.Forms.ListViewItem listViewItem32 = new System.Windows.Forms.ListViewItem("E");
            System.Windows.Forms.ListViewItem listViewItem33 = new System.Windows.Forms.ListViewItem("I");
            System.Windows.Forms.ListViewItem listViewItem34 = new System.Windows.Forms.ListViewItem("O");
            System.Windows.Forms.ListViewItem listViewItem35 = new System.Windows.Forms.ListViewItem("U");
            System.Windows.Forms.ListViewItem listViewItem36 = new System.Windows.Forms.ListViewItem("a");
            System.Windows.Forms.ListViewItem listViewItem37 = new System.Windows.Forms.ListViewItem("e");
            System.Windows.Forms.ListViewItem listViewItem38 = new System.Windows.Forms.ListViewItem("i");
            System.Windows.Forms.ListViewItem listViewItem39 = new System.Windows.Forms.ListViewItem("o");
            System.Windows.Forms.ListViewItem listViewItem40 = new System.Windows.Forms.ListViewItem("u");
            this.keyShow = new System.Windows.Forms.TextBox();
            this.altlist = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // keyShow
            // 
            this.keyShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyShow.Location = new System.Drawing.Point(12, 12);
            this.keyShow.MaxLength = 1;
            this.keyShow.Name = "keyShow";
            this.keyShow.ReadOnly = true;
            this.keyShow.Size = new System.Drawing.Size(58, 62);
            this.keyShow.TabIndex = 0;
            this.keyShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.keyShow.TextChanged += new System.EventHandler(this.keyShow_TextChanged);
            this.keyShow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyShow_KeyDown);
            // 
            // altlist
            // 
            this.altlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altlist.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem31,
            listViewItem32,
            listViewItem33,
            listViewItem34,
            listViewItem35,
            listViewItem36,
            listViewItem37,
            listViewItem38,
            listViewItem39,
            listViewItem40});
            this.altlist.Location = new System.Drawing.Point(12, 92);
            this.altlist.Name = "altlist";
            this.altlist.Size = new System.Drawing.Size(722, 284);
            this.altlist.TabIndex = 1;
            this.altlist.UseCompatibleStateImageBehavior = false;
            this.altlist.DoubleClick += new System.EventHandler(this.altlist_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "First input simmilar raw character / symbols\r\nThen double click the alt character" +
    " to copy to cliperboard";
            // 
            // SPCharKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.altlist);
            this.Controls.Add(this.keyShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SPCharKB";
            this.Text = "Special Character KeyBoard";
            this.Load += new System.EventHandler(this.SPCharKB_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SPCharKB_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keyShow;
        private System.Windows.Forms.ListView altlist;
        private System.Windows.Forms.Label label1;
    }
}