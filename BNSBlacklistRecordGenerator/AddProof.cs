using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BNSBlacklistRecordGenerator
{
    public partial class AddProof : Form
    {
        private ResultWrapper<string> wrapper;
        public AddProof(ResultWrapper<string> wrapper)
        {
            InitializeComponent();
            this.wrapper = wrapper;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (wrapper != null)
            {
                wrapper.setResult(textBox1.Text);
            }
            Dispose();
        }
    }
}
