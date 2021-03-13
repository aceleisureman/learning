using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace learning
{
    public partial class adaptive : Form
    {
        public adaptive()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }


        protected override void OnLayout(LayoutEventArgs levent)
        {

            int top = 5;

            int left = 5;


            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;

            textBox1.Location = new Point(top,left);
            textBox1.Size = new Size(w - 100-10,20);

            button1.Location = new Point(textBox1.Size.Width+10,textBox1.Location.X);
            button1.Size = new Size(100, textBox1.Size.Height);


            pictureBox1.Location = new Point(left, textBox1.Location.X + textBox1.Size.Height + 5);
            pictureBox1.Size = new Size(w - 10,h- textBox1.Size.Height-top-10);




        }

    }
}
