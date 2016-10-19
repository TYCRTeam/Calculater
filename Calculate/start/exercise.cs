using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Calculate.start
{
    public partial class exercise : Form
    {
        private string realAnswer;
        public exercise()
        {
            InitializeComponent();
        }

        private void exercise_Load(object sender, EventArgs e)
        {
            set_type();
        }
        private void radioButton_a_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox_answer.Text = this.radioButton_a.Text;
        }

        private void radioButton_b_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox_answer.Text = this.radioButton_b.Text;
        }

        private void radioButton_c_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox_answer.Text = this.radioButton_c.Text;
        }

        private void radioButton_d_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox_answer.Text = this.radioButton_d.Text;
        }
        
        private void ToolStripMenuItem_choose_Click(object sender, EventArgs e)
        {
            this.ToolStripMenuItem_all.Checked = false;
            this.ToolStripMenuItem_black.Checked = false;
            this.ToolStripMenuItem_choose.Checked = true;
            this.ToolStripMenuItem_judge.Checked = false;
            set_type();
        }

        private void ToolStripMenuItem_all_Click(object sender, EventArgs e)
        {
            this.ToolStripMenuItem_all.Checked = true;
            this.ToolStripMenuItem_black.Checked = false;
            this.ToolStripMenuItem_choose.Checked = false;
            this.ToolStripMenuItem_judge.Checked = false;
        }

        private void ToolStripMenuItem_black_Click(object sender, EventArgs e)
        {
            this.ToolStripMenuItem_all.Checked = false;
            this.ToolStripMenuItem_black.Checked = true;
            this.ToolStripMenuItem_choose.Checked = false;
            this.ToolStripMenuItem_judge.Checked = false;
            set_type();
        }

        private void ToolStripMenuItem_judge_Click(object sender, EventArgs e)
        {
            this.ToolStripMenuItem_all.Checked = false;
            this.ToolStripMenuItem_black.Checked = false;
            this.ToolStripMenuItem_choose.Checked = false;
            this.ToolStripMenuItem_judge.Checked = true;
            set_type();
        } 
        
        private void button_jump_Click(object sender, EventArgs e)
        {
            this.textBox_log.AppendText("" + this.label_title.Text + this.textBox_answer.Text + "               跳过            " + DateTime.Now.ToString() + "\r\n");
            set_type();
        }


        
        
        private void set_type()//设置题型界面 
        {
            int type=1;
            if (this.ToolStripMenuItem_all.Checked == true) 
            {
                long tick = DateTime.Now.Ticks;
                Random re = new Random((int)(tick & 0xffffffffL));
                type = re.Next(1, 4);
            }
            if (this.ToolStripMenuItem_black.Checked == true) { type = 1; }
            if (this.ToolStripMenuItem_choose.Checked == true) { type = 2; }
            if (this.ToolStripMenuItem_judge.Checked == true) { type = 3; }
            switch (type) 
            {
                case 1: set_black(); break;
                case 2: set_choose(); break;
                case 3: set_judge(); break;
            }
        }
       
        private void give_title(int HardId)////出题
        {
            string title = Calculator.FormulaFactory.CreateFormula(Program.HardID);
            string[] arry = title.Split('=');
            this.label_title.Text = arry[0] + " = ";
            this.realAnswer = arry[1];
        }

        private void set_black()///设置填空题
        {
            this.textBox_answer.Enabled = true;
            this.textBox_answer.Text = "";
            give_title(Program.HardID);
            this.panel1.Visible = false;
            this.label_type.Text = "填空题：";
        }

        private void set_choose()////设置选择题
        {
            this.radioButton_right.Visible = false;
            this.radioButton_wrong.Visible = false;
            this.radioButton_a.Visible = true;
            this.radioButton_b.Visible = true;
            this.radioButton_c.Visible = true;
            this.radioButton_d.Visible = true;
            this.label_type.Text = "选择题：";
            give_title(Program.HardID);
            this.textBox_answer.Text = "";
            this.textBox_answer.Enabled = false;
            this.panel1.Visible = true;
            long tick = DateTime.Now.Ticks;
            Random re = new Random((int)(tick & 0xffffffffL));
            switch (re.Next(1, 4))
            {
                case 1: this.radioButton_a.Text = this.realAnswer; 
                        this.radioButton_b.Text = re.Next(1000).ToString();
                        this.radioButton_c.Text = re.Next(500).ToString();
                        this.radioButton_d.Text = re.Next(100).ToString();
                        break;
                case 2: this.radioButton_b.Text = this.realAnswer;
                        this.radioButton_a.Text = re.Next(1000).ToString();
                        this.radioButton_c.Text = re.Next(50).ToString();
                        this.radioButton_d.Text = re.Next(600).ToString();
                        break;
                case 3: this.radioButton_c.Text = this.realAnswer;
                        this.radioButton_b.Text = re.Next(800).ToString();
                        this.radioButton_a.Text = re.Next(1000).ToString();
                        this.radioButton_d.Text = re.Next(200).ToString();
                        break;
                case 4: this.radioButton_d.Text = this.realAnswer; 
                        this.radioButton_b.Text = re.Next(700).ToString();
                        this.radioButton_c.Text = re.Next(30).ToString();
                        this.radioButton_a.Text = re.Next(200).ToString();
                        break;
            }
        }

        private void set_judge()///设置判断题
        {
            this.radioButton_right.Visible = true;
            this.radioButton_wrong.Visible = true;
            this.radioButton_a.Visible = false;
            this.radioButton_b.Visible = false;
            this.radioButton_c.Visible = false;
            this.radioButton_d.Visible = false;
            this.panel1.Visible = true;
            this.label_type.Text = "判断题：";
            give_title(Program.HardID);
            this.textBox_answer.Text = "";
            this.textBox_answer.Enabled = false;
            this.panel1.Visible = true ;
            this.radioButton_right.Text = "正确";
            this.radioButton_wrong.Text = "错误";
            long tick = DateTime.Now.Ticks;
            Random re = new Random((int)(tick & 0xffffffffL));
            this.textBox_answer.Text = (Convert.ToInt32(this.realAnswer) + re.Next(-3, 3)).ToString();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            switch (this.label_type.Text) 
            {
                case "选择题：":
                case "填空题：":
                    if (this.textBox_answer.Text.ToString().Trim() == this.realAnswer) 
                    {
                        this.textBox_log.AppendText(""+this.label_title.Text + this.textBox_answer.Text + "               正确            " + DateTime.Now.ToString()+"\r\n");
                        set_type();
                    }
                    else
                    {
                        this.textBox_log.AppendText("" + this.label_title.Text + this.textBox_answer.Text + "               错误            " + DateTime.Now.ToString() + "\r\n");
                    }
                    break;
                case "判断题：":
                    {
                        if (this.radioButton_right.Checked == false && this.radioButton_wrong.Checked == false) { MessageBox.Show("请选择！"); return; }
                        bool answer = false;
                        if (this.radioButton_right.Checked == true) { answer = true; }
                        if (this.radioButton_wrong.Checked == true) { answer = false; }
                        if (!((this.textBox_answer.Text.ToString().Trim() == this.realAnswer)^answer))
                        {
                            this.textBox_log.AppendText("" + this.label_title.Text + this.textBox_answer.Text + "               正确            " + DateTime.Now.ToString() + "\r\n");
                            set_type();
                        }
                        else
                        {
                            this.textBox_log.AppendText("" + this.label_title.Text + this.realAnswer + "               错误            " + DateTime.Now.ToString() + "\r\n");
                        }
                        break;
                    }
            }
        }

        
       

       

    }
}
