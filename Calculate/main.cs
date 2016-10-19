﻿using System;
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
            this.panel1.Controls.Clear();
            start.exercise ex = new start.exercise();
            ex.TopLevel = false;
            ex.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(ex);
            ex.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ribbonButton5_Click(object sender, EventArgs e)
        {
            start.test tx = new start.test();
            tx.TopLevel = false;
            tx.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(tx);
            tx.Show();
        }

    }
}
