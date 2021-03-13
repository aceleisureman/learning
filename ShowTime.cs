using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace learning
{
    public partial class ShowTime : Form
    {
        public ShowTime()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string timestr = DateTime.Now.ToString("yyyy-MM-dd HH:MM:ss");
            this.textBox1.Text = timestr;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
