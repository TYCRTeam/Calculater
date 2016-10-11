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
        public main()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem_start_exercise_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form f1 = new start.exercise();//初始化
            f1.TopLevel = false;
            this.panel1.Controls.Add(f1);
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Show();
        }

        private void ToolStripMenuItem_start_exam_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form f1 = new start.test();
            f1.TopLevel = false;
            this.panel1.Controls.Add(f1);
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Show();
        }

        private void ToolStripMenuItem_check_wrongAnswer_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form f1 = new check.wrongAnswer();//初始化
            f1.TopLevel = false;
            this.panel1.Controls.Add(f1);
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Show();
        }

        private void ToolStripMenuItem_check_examGrade_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form f1 = new check.testGrade();//初始化
            f1.TopLevel = false;
            this.panel1.Controls.Add(f1);
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Show();
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
