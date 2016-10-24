using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Calculate.start
{
    public partial class exercise : Form
    {
        private string realAnswer;
        private int type = 0;
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

        
        private void button_jump_Click(object sender, EventArgs e)
        {
            this.textBox_log.AppendText("" + this.label_title.Text + this.textBox_answer.Text + "               跳过            " + DateTime.Now.ToString() + "\r\n");
            panel1.Visible = true;
            pnlPath.Visible = false;
            btnNext.Visible = false;
            button_jump.Visible = true;
            set_type();
        }

        public void setRedam()
        {
            long tick = DateTime.Now.Ticks;
            Random re = new Random((int)(tick & 0xffffffffL));
            type = re.Next(1, 4);
            switch (type)
            {
                case 1: set_black(); break;
                case 2: set_choose(); break;
                case 3: set_judge(); break;
            }
        }


        private void set_type()//设置题型界面 
        {
            switch (type)
            {
                case 0: setRedam(); break;
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

        public void set_black()///设置填空题
        {
            type = 1;
            this.textBox_answer.Enabled = true;
            this.textBox_answer.Text = "";
            give_title(Program.HardID);
            this.textBox_answer.Left = this.label_title.Left + label_title.Width + 5;
            this.panel1.Visible = false;
            this.label_type.Text = "填空题：";
        }

        public void set_choose()////设置选择题
        {
            type = 2;
            this.radioButton_right.Visible = false;
            this.radioButton_wrong.Visible = false;
            this.radioButton_a.Visible = true;
            this.radioButton_b.Visible = true;
            this.radioButton_c.Visible = true;
            this.radioButton_d.Visible = true;
            this.label_type.Text = "选择题：";
            give_title(Program.HardID);
            this.textBox_answer.Left = this.label_title.Left + label_title.Width + 5;
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

        public void set_judge()///设置判断题
        {
            type = 3;
            this.radioButton_right.Visible = true;
            this.radioButton_wrong.Visible = true;
            this.radioButton_a.Visible = false;
            this.radioButton_b.Visible = false;
            this.radioButton_c.Visible = false;
            this.radioButton_d.Visible = false;
            this.panel1.Visible = true;
            this.label_type.Text = "判断题：";
            give_title(Program.HardID);
            this.textBox_answer.Left = this.label_title.Left + label_title.Width + 5;
            this.textBox_answer.Text = "";
            this.textBox_answer.Enabled = false;
            this.panel1.Visible = true ;
            this.radioButton_right.Text = "正确";
            this.radioButton_wrong.Text = "错误";
            long tick = DateTime.Now.Ticks;
            Random re = new Random((int)(tick & 0xffffffffL));
            //Debug.WriteLine(this.realAnswer);
            if (this.realAnswer.IndexOf("/") > -1)
            {
                string[] str = this.realAnswer.Split(new char[] { '/' });
                this.textBox_answer.Text = (int.Parse(str[0]) + re.Next(-3, 3)).ToString() + "/" + (int.Parse(str[1]) + re.Next(-3, 3)).ToString();
            }
            else
            {
                this.textBox_answer.Text = (int.Parse(this.realAnswer) + re.Next(-3, 3)).ToString();
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            switch (this.label_type.Text) 
            {
                case "选择题：":
                case "填空题：":
                    if (this.textBox_answer.Text.ToString().Trim() == this.realAnswer) 
                    {
                        pnlPath.Visible = false;
                        piBW.Visible = false;
                        lblW.Visible = false;
                        pnlPath.Visible = true;
                        pibRight.Visible = true;
                        lblRight.Visible = true;
                        this.textBox_log.AppendText(""+this.label_title.Text + this.textBox_answer.Text + "               正确            " + DateTime.Now.ToString()+"\r\n");
                        Application.DoEvents();
                        Thread.Sleep(2000);
                        pnlPath.Visible = false;
                        pibRight.Visible = false;
                        lblRight.Visible = false;
                        btnNext.Visible = false;
                        button_jump.Visible = true;
                        set_type();
                    }
                    else
                    {
                        pnlPath.Visible = false;
                        pibRight.Visible = false;
                        lblRight.Visible = false;
                        pnlPath.Visible = true;
                        piBW.Visible = true;
                        lblW.Visible = true;
                        btnNext.Visible = true;
                        button_jump.Visible = false;
                        this.textBox_log.AppendText("" + this.label_title.Text + this.textBox_answer.Text + "               错误            " + DateTime.Now.ToString() + "\r\n");
                        SaveNewError();
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
                            pnlPath.Visible = false;
                            piBW.Visible = false;
                            lblW.Visible = false;
                            pnlPath.Visible = true;
                            pibRight.Visible = true;
                            lblRight.Visible = true;
                            this.textBox_log.AppendText("" + this.label_title.Text + this.textBox_answer.Text + "               正确            " + DateTime.Now.ToString() + "\r\n");
                            Application.DoEvents();
                            Thread.Sleep(2000);
                            pnlPath.Visible = false;
                            pibRight.Visible = false;
                            lblRight.Visible = false;
                            btnNext.Visible = false;
                            button_jump.Visible = true;
                            set_type();
                        }
                        else
                        {
                            pnlPath.Visible = false;
                            pibRight.Visible = false;
                            lblRight.Visible = false;
                            pnlPath.Visible = true;
                            piBW.Visible = true;
                            lblW.Visible = true;
                            btnNext.Visible = true;
                            button_jump.Visible = false;
                            this.textBox_log.AppendText("" + this.label_title.Text + this.realAnswer + "               错误            " + DateTime.Now.ToString() + "\r\n");
                            SaveNewError();
                        }
                        break;
                    }
            }
        }

        /// <summary>
        /// 保存一个错误题目
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void SaveNewError()
        {
            DataTable dt = Program.ErrorSet.Tables[0];
            DataRow dr = dt.NewRow();

            dr["UserID"] = Program.UserID;
            dr["Title"] = label_title.Text;
            dr["Result"] = this.realAnswer;
            dr["ErrorResult"] = textBox_answer.Text;
            dr["HardID"] = Program.HardID;
            dr["Time"] = DateTime.Now.ToString("yyyy-MM-dd HH:mmm:ss");
            
            dt.Rows.Add(dr);
            Program.ErrorSet.WriteXml(Program.ErrorXML);
        }
       

    }
}
