using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Calculate.start
{
    public partial class test : Form
    {
        public static int titleCount = Program.chooseNum + Program.judgeNum + Program.blackNum;
        public string[][] arry=new string[titleCount][];
        private static int current_num=0;
        private string[,] answer = new string[titleCount,3];
        private string[,] opinion = new string[Program.chooseNum, 4];
        private DateTime starttime;
        private double usedtime;
        ArrayList btnList = new ArrayList(titleCount);
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            this.label1.Text = "第" + (current_num+1).ToString() + "题：";
            for (int i = 0; i < titleCount; i++) 
            {
                Application.DoEvents();
                Button bt = new Button();
                btnList.Add(bt);
                bt.Size = new Size(35,25);
                bt.Text = (i + 1).ToString();
                bt.Name = "btn_" + i.ToString();
                bt.Click += new EventHandler(bt_Click);
                bt.Tag = i;
                bt.Top = 32 * (i / 20);
                bt.Left = 37 * (i % 20);
                this.panel1.Controls.Add(bt);
            }
            give_title(titleCount);
            set_type(current_num);
            StartTest();
        }

        private void StartTest()
        {
            starttime = DateTime.Now;
            timer1.Start();
        }

        public void PoseTest()
        {
            timer1.Stop();
        }

        public void RestartTest()
        {
            timer1.Start();
        }

        private void bt_Click(object sender, EventArgs e) 
        {
            if (this.textBox_answer.Text.ToString().Trim() != "" && current_num >= Program.chooseNum + Program.judgeNum)
            {
                answer[current_num, 2] = "1";
            }
            if (this.textBox_answer.Text != null)
            {               
                this.answer[current_num, 1] = this.textBox_answer.Text.ToString().Trim();
            }
            Button bt = sender as Button;
            int tag = Convert.ToInt16(bt.Tag);
            if (this.answer[current_num, 2] == "1")
            {
                Button bt1 = new Button();
                bt1 = (Button)btnList[current_num];
                setBTN_doneColor(bt1);
            }
            else
            {
                Button bt1 = new Button();
                bt1 = (Button)btnList[current_num];
                bt1.BackColor = SystemColors.Control;
            }
            current_num=tag;
            this.label1.Text = "第" + (current_num+1).ToString() + "题：";
            set_type(tag);
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            this.answer[current_num, 2] = "1";
            RadioButton rb = sender as RadioButton;
            switch (rb.Tag.ToString())
            {
                case "t": answer[current_num,0] = this.radioButton_right.Tag.ToString(); break;
                case "f": answer[current_num,0] = this.radioButton_wrong.Tag.ToString(); break;
                case "a": answer[current_num,0] = this.radioButton_a.Tag.ToString(); this.textBox_answer.Text = this.radioButton_a.Text; break;
                case "b": answer[current_num,0] = this.radioButton_b.Tag.ToString(); this.textBox_answer.Text = this.radioButton_b.Text; break;
                case "c": answer[current_num,0] = this.radioButton_c.ToString(); this.textBox_answer.Text = this.radioButton_c.Text; break;
                case "d": answer[current_num,0] = this.radioButton_d.ToString(); this.textBox_answer.Text = this.radioButton_d.Text; break;

            }
        }

        private void set_type(int titleNum)////设置题目界面
        {
            Button bt1 = new Button();
            bt1 = (Button)btnList[titleNum];
            setBTN_currentColor(bt1);
            if (titleNum < Program.chooseNum)
            {
                set_choose(titleNum);
            }
            else
            {
                if (titleNum >= Program.chooseNum && titleNum < Program.chooseNum + Program.judgeNum)
                {
                    set_judge(titleNum);
                }
                else
                {
                    set_black(titleNum);
                }
            }
        }

        private void give_title(int HardId)////出题
        {
            for (int i = 0; i < titleCount; i++)
            {                
                string title = Calculator.FormulaFactory.CreateFormula(Program.HardID);
                arry[i] = title.Split('=');
                arry[i][0] += "=";
            }
        }

        private void set_black(int titleNum)///设置填空题
        {
            this.textBox_answer.Text = "";
            if (this.answer[titleNum,1] != null) 
            {
                this.textBox_answer.Text = answer[titleNum, 1];
            }
            this.textBox_answer.Enabled = true;
            
            //give_title(Program.HardID);
            this.label_title.Text = arry[titleNum][0];
            this.panel2.Visible = false;
            this.label_type.Text = "填空题：";
        }

        private void set_choose(int titleNum)////设置选择题
        {
            this.textBox_answer.Text = "";
            if (this.answer[titleNum, 1] != null)
            {
                this.textBox_answer.Text = answer[titleNum, 1];
            }
            switch (answer[titleNum, 0])
            {
                //case "t": this.radioButton_right.Checked = true; break;
                //case "f": this.radioButton_wrong.Checked = true; break;
                case "a": this.radioButton_a.Checked = true; break;
                case "b": this.radioButton_b.Checked = true; break;
                case "c": this.radioButton_c.Checked = true; break;
                case "d": this.radioButton_d.Checked = true; break;
                default: this.radioButton_a.Checked = false;
                         this.radioButton_b.Checked = false;
                         this.radioButton_c.Checked = false;
                         this.radioButton_d.Checked = false;
                         //this.radioButton_right.Checked = false;
                         //this.radioButton_wrong.Checked = false;
                         break;

            }
            this.radioButton_right.Visible = false;
            this.radioButton_wrong.Visible = false;
            this.radioButton_a.Visible = true;
            this.radioButton_b.Visible = true;
            this.radioButton_c.Visible = true;
            this.radioButton_d.Visible = true;
            this.label_type.Text = "选择题：";
            //give_title(Program.HardID);
            this.label_title.Text = arry[titleNum][0];
            
            this.textBox_answer.Enabled = false;
            this.panel2.Visible = true;
            if (opinion[titleNum, 0] == null)
            {
                long tick = DateTime.Now.Ticks;
                Random re = new Random((int)(tick & 0xffffffffL));
                switch (re.Next(1, 4))
                {
                    case 1: this.radioButton_a.Text = this.arry[titleNum][1]; opinion[titleNum, 0] = this.radioButton_a.Text;
                        this.radioButton_b.Text = re.Next(1000).ToString(); opinion[titleNum, 1] = this.radioButton_b.Text;
                        this.radioButton_c.Text = re.Next(500).ToString(); opinion[titleNum, 2] = this.radioButton_c.Text;
                        this.radioButton_d.Text = re.Next(100).ToString(); opinion[titleNum, 3] = this.radioButton_d.Text;
                        break;
                    case 2: this.radioButton_b.Text = this.arry[titleNum][1]; opinion[titleNum, 1] = this.radioButton_b.Text;
                        this.radioButton_a.Text = re.Next(1000).ToString(); opinion[titleNum, 0] = this.radioButton_a.Text;
                        this.radioButton_c.Text = re.Next(50).ToString(); opinion[titleNum, 2] = this.radioButton_c.Text;
                        this.radioButton_d.Text = re.Next(600).ToString(); opinion[titleNum, 3] = this.radioButton_d.Text;
                        break;
                    case 3: this.radioButton_c.Text = this.arry[titleNum][1]; opinion[titleNum, 2] = this.radioButton_c.Text;
                        this.radioButton_b.Text = re.Next(800).ToString(); opinion[titleNum, 1] = this.radioButton_b.Text;
                        this.radioButton_a.Text = re.Next(1000).ToString(); opinion[titleNum, 0] = this.radioButton_a.Text;
                        this.radioButton_d.Text = re.Next(200).ToString(); opinion[titleNum, 3] = this.radioButton_d.Text;
                        break;
                    case 4: this.radioButton_d.Text = this.arry[titleNum][1]; opinion[titleNum, 3] = this.radioButton_d.Text;
                        this.radioButton_b.Text = re.Next(700).ToString(); opinion[titleNum, 1] = this.radioButton_b.Text;
                        this.radioButton_c.Text = re.Next(30).ToString(); opinion[titleNum, 2] = this.radioButton_c.Text;
                        this.radioButton_a.Text = re.Next(200).ToString(); opinion[titleNum, 0] = this.radioButton_a.Text;
                        break;
                }
            }
            else
            {
                this.radioButton_a.Text = opinion[current_num, 0];
                this.radioButton_b.Text = opinion[current_num, 1];
                this.radioButton_c.Text = opinion[current_num, 2];
                this.radioButton_d.Text = opinion[current_num, 3];
            }
        }

        private void set_judge(int titleNum)///设置判断题
        {
            this.textBox_answer.Text = "";
            if (this.answer[titleNum, 1] != null)
            {
                this.textBox_answer.Text = answer[titleNum, 1];
            }
            switch (answer[titleNum, 0])
            {
                case "t": this.radioButton_right.Checked = true; break;
                case "f": this.radioButton_wrong.Checked = true; break;
                //case "a": this.radioButton_a.Checked = true; break;
                //case "b": this.radioButton_b.Checked = true; break;
                //case "c": this.radioButton_c.Checked = true; break;
                //case "d": this.radioButton_d.Checked = true; break;
                default: this.radioButton_a.Checked = false;
                //    this.radioButton_b.Checked = false;
                //    this.radioButton_c.Checked = false;
                //    this.radioButton_d.Checked = false;
                    this.radioButton_right.Checked = false;
                    this.radioButton_wrong.Checked = false;
                    break;

            }
            this.radioButton_right.Visible = true;
            this.radioButton_wrong.Visible = true;
            this.radioButton_a.Visible = false;
            this.radioButton_b.Visible = false;
            this.radioButton_c.Visible = false;
            this.radioButton_d.Visible = false;
            this.label_type.Text = "判断题：";
            //give_title(Program.HardID);
            this.label_title.Text = arry[titleNum][0];
            
            this.textBox_answer.Enabled = false;
            this.panel2.Visible = true;
            this.radioButton_right.Text = "正确";
            this.radioButton_wrong.Text = "错误";
            if (this.textBox_answer.Text == "")
            {
                long tick = DateTime.Now.Ticks;
                Random re = new Random((int)(tick & 0xffffffffL));
                this.textBox_answer.Text = (Convert.ToInt32(this.arry[titleNum][1]) + re.Next(-3, 3)).ToString();
            }
        }

        private void button_forword_Click(object sender, EventArgs e)
        {
            if (this.textBox_answer.Text.ToString().Trim() != "" && current_num >= Program.chooseNum + Program.judgeNum)
            {
                answer[current_num, 2] = "1";
            }
            if (this.textBox_answer.Text != null)
            {
                this.answer[current_num, 1] = this.textBox_answer.Text.ToString().Trim();
            }
            if (current_num == 0) { return; }
            if (this.answer[current_num, 2] == "1")
            { 
                Button bt1 = new Button();
                bt1 = (Button)btnList[current_num];
                setBTN_doneColor(bt1);
            }
            else
            {
                Button bt1 = new Button();
                bt1 = (Button)btnList[current_num];
                bt1.BackColor = SystemColors.Control;
            }

            current_num--;
            this.label1.Text = "第" + (current_num + 1).ToString() + "题：";
            set_type(current_num);
            label_title.Left = label1.Left + label1.Width;
            textBox_answer.Left = label_title.Left + label_title.Width;
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (this.textBox_answer.Text.ToString().Trim() != "" && current_num >= Program.chooseNum + Program.judgeNum)
            {
                answer[current_num, 2] = "1";
            }
            if (this.textBox_answer.Text != null)
            {
               this.answer[current_num, 1] = this.textBox_answer.Text.ToString().Trim();
            }
            if (current_num == (titleCount - 1)) { return; }
            if (this.answer[current_num, 2] == "1")
            {
                Button bt1 = new Button();
                bt1 = (Button)btnList[current_num];
                setBTN_doneColor(bt1);
            }
            else
            {
                Button bt1 = new Button();
                bt1 = (Button)btnList[current_num];
                bt1.BackColor = SystemColors.Control; 
            }
            current_num++;
            this.label1.Text = "第" + (current_num + 1).ToString() + "题：";
            set_type(current_num);
            label_title.Left = label1.Left + label1.Width;
            textBox_answer.Left = label_title.Left + label_title.Width;

        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            int wrong = 0;
            for (int i = 0; i < titleCount; i++)
            {
                if (answer[i, 1] != arry[i][1]) 
                {
                    if (answer[i, 0] == "f")
                    {
                        Button bt = new Button();
                        bt = (Button)btnList[i];
                        setBTN_rightColor(bt);
                        continue;
                    }
                    else
                    {
                        Button bt = new Button();
                        bt = (Button)btnList[i];
                        setBTN_wrongColor(bt);
                        wrong++;
                        continue;
                    }
                    
                }
                Button bt1 = new Button();
                bt1 = (Button)btnList[i];
                setBTN_rightColor(bt1);
                continue;
            }

            this.label_grade.Text = "分数：" + (100 - wrong * 100 / titleCount).ToString() + "";
            this.label_grade.Visible = true;
            Program.Intest = false;
            this.button_submit.Enabled = false;
            PoseTest();
            ((main)this.MdiParent).ResumeButton();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            usedtime += 1;
            lblUsedtime.Text = "倒计时：" + DateTime.Parse("1990-1-1 00:"+Program.time.ToString()+":00").AddSeconds(-usedtime).ToString("mm:ss");
        }



        /// 修改已经做了的题目的btn样式，不返回任何结果
        /// 作者：杨斌
        /// 最后修改时间：2016-10-22
        /// </summary>
        public void setBTN_doneColor(Button bt)
        {
            bt.BackColor = Color.SlateGray;
        }

        /// 修改答对了的题目的btn样式，不返回任何结果
        /// 作者：杨斌
        /// 最后修改时间：2016-10-22
        /// </summary>
        public void setBTN_rightColor(Button bt)
        {
            bt.BackColor = Color.Green;
        }

        /// 修改答错了的题目的btn样式，不返回任何结果
        /// 作者：杨斌
        /// 最后修改时间：2016-10-22
        /// </summary>
        public void setBTN_wrongColor(Button bt)
        {
            bt.BackColor = Color.Red;
        }


        /// 修改当前的题目的btn样式，不返回任何结果
        /// 作者：杨斌
        /// 最后修改时间：2016-10-22
        /// </summary>
        public void setBTN_currentColor(Button bt)
        {
            bt.BackColor = Color.Yellow;
        }
    }
}
