using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculate.start
{
    public partial class test_setting : Form
    {
        public test_setting()
        {
            InitializeComponent();
        }

        private void button_cancle_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            Program.HardID = comboBox1.SelectedIndex;
            Program.chooseNum = int.Parse(textBox_chooseNum.Text);
            Program.time = int.Parse(textBox_time.Text );
            Program.judgeNum = int.Parse(textBox_judgeNum.Text);
            Program.blackNum = int.Parse(textBox_blackNum.Text);
            this.Dispose();
        }

        private void test_setting_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = Program.HardID;
            textBox_chooseNum.Text = Program.chooseNum.ToString();
            textBox_time.Text = Program.time.ToString();
            textBox_judgeNum.Text = Program.judgeNum.ToString();
            textBox_blackNum.Text = Program.blackNum.ToString();
        }
    }
}
