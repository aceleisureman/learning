using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learning
{
    public partial class Main : Form
    {
        private const string V = "TestButton";

        public Main()
        {

            this.StartPosition = FormStartPosition.CenterParent;

            InitializeComponent();

            //
            int spacing_x = 10;
            int spacing_y = 10;

            int button_w = 100;
            int button_h = 40;

            //手动创建按钮

            Button TestButton = new Button()
            {
                Text = "显示时间",
                Location = new Point(spacing_x, spacing_y),
                Size = new Size(button_w, button_h),

            };

            this.Controls.Add(TestButton);

            //注册按钮事件
            TestButton.Click += new EventHandler( this.TestButtonOnClick);



            //图片控件
            Button ImageButton = new Button
            {
                Text = "载入图片",
                Location = new Point(TestButton.Location.X+TestButton.Size.Width+spacing_x,spacing_y),
                Size = new Size(button_w, button_h),
            };

            this.Controls.Add(ImageButton);
            ImageButton.Click += new EventHandler( this.ImageButtonOnClick);



            //布局
            Button PanelButton = new Button
            {
                Text = "Panel",
                Location = new Point(ImageButton.Location.X+ImageButton.Size.Width+ spacing_x, spacing_y),
                Size = new Size(button_w, button_h),
            };

            this.Controls.Add(PanelButton);

            //注册按钮事件
            PanelButton.Click += new EventHandler(this.PanelButtonOnClick);



            //布局
            Button CustomLayout = new Button
            {
                Text = "自定义布局",
                Location = new Point(PanelButton.Location.X + PanelButton.Size.Width + spacing_x, spacing_y),
                Size = new Size(button_w, button_h),
            };

            this.Controls.Add(CustomLayout);


            //注册按钮事件
            CustomLayout.Click += new EventHandler(this.CustomLayoutOnClick);


            CustomLayout form = new CustomLayout();
            form.Show();
            form.TopMost = true;

            form.Top = this.Top + this.ClientSize.Height + 10;

        }




        public void CustomLayoutOnClick(object sender, EventArgs e)
        {
            CustomLayout form = new CustomLayout();
            form.Show();
        }


        public void PanelButtonOnClick(object sender, EventArgs e)
        {
            panlen form = new panlen();
            form.Show();
        }


        public void TestButtonOnClick(object sender,EventArgs e)
        {

            ShowTime form = new ShowTime();
            form.Show();
        }



        public void ImageButtonOnClick(object sender,EventArgs e)
        {
            adaptive form = new adaptive();
            form.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
