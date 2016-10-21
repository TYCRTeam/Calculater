using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculate
{
    public partial class main : Form
    {
        public start.exercise frmex;
        public main()
        {
            InitializeComponent();
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.label_username.Text = Program.UserName;
        }

        private void rbbStart_Click(object sender, EventArgs e)
        {
            frmex = new start.exercise();
            frmex.MdiParent = this;
            frmex.Dock = DockStyle.Fill;
            frmex.TopMost = true;
            frmex.FormBorderStyle = FormBorderStyle.None;
            frmex.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ribbonButton5_Click(object sender, EventArgs e)
        {
            start.test tx = new start.test();
            tx.TopLevel = false;
            tx.FormBorderStyle = FormBorderStyle.None;
            //this.panel1.Controls.Clear();
            //this.panel1.Controls.Add(tx);
            tx.Show();
        }

        private void ribbonButton3_Click(object sender, EventArgs e)
        {
            frmex.setRedam();
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            frmex.set_choose();
        }

        private void ribbonButton14_Click(object sender, EventArgs e)
        {
            frmex.set_black();
        }

        private void ribbonButton15_Click(object sender, EventArgs e)
        {
            frmex.set_judge();
        }

        /// <summary>
        /// 设置为初级
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void ribbonButton16_Click(object sender, EventArgs e)
        {
            Program.HardID = 0;
        }

        /// <summary>
        /// 设置为中级
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void ribbonButton17_Click(object sender, EventArgs e)
        {
            Program.HardID = 1;
        }

        /// <summary>
        /// 设置为高级
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void ribbonButton18_Click(object sender, EventArgs e)
        {
            Program.HardID = 2;
        }

    }
}
