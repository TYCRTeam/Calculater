using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Calculate
{
    public partial class main : Form
    {
        public start.exercise frmex;
        public start.test frmtext;
        public start.errors frmerror;
        public Scores frmscores;
        public main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 关闭界面时
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 关闭界面时，判断是否在测试中
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.Intest)
            {
                MessageBox.Show("测试过程中，不能退出程序！");
                e.Cancel = true;
            }
        }

        /// <summary>
        /// 保存一个错误题目
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void main_Load(object sender, EventArgs e)
        {
            //加载错误题目的Dataset
            if (!File.Exists(Program.ErrorXML))
            {
                //文件不存在，则生成
                Program.ErrorSet = new DataSet();
                DataTable dt = new DataTable("Error");
                dt.Columns.Add("UserID");
                dt.Columns.Add("Title");
                dt.Columns.Add("Result");
                dt.Columns.Add("ErrorResult");
                dt.Columns.Add("HardID");
                dt.Columns.Add("Time");
                Program.ErrorSet.Tables.Add(dt);
                Program.ErrorSet.WriteXml(Program.ErrorXML);
            }
            else
            {
                //如果文件存在，则直接加载
                Program.ErrorSet.ReadXml(Program.ErrorXML);
                if (Program.ErrorSet.Tables.Count == 0)
                {
                    DataTable dt = new DataTable("Error");
                    dt.Columns.Add("UserID");
                    dt.Columns.Add("Title");
                    dt.Columns.Add("Result");
                    dt.Columns.Add("ErrorResult");
                    dt.Columns.Add("HardID");
                    dt.Columns.Add("Time");
                    Program.ErrorSet.Tables.Add(dt);
                    Program.ErrorSet.WriteXml(Program.ErrorXML);
                }
            }
            //加载成绩Dataset
            if (!File.Exists(Program.ScoreXML))
            {
                //文件不存在，则生成
                Program.ScoreSet = new DataSet();
                DataTable dt = new DataTable("Scores");
                dt.Columns.Add("UserID");
                dt.Columns.Add("Score");
                dt.Columns.Add("Time");
                Program.ScoreSet.Tables.Add(dt);
                Program.ScoreSet.WriteXml(Program.ScoreXML);
            }
            else
            {
                //如果文件存在，则直接加载
                Program.ScoreSet.ReadXml(Program.ScoreXML);
                if (Program.ScoreSet.Tables.Count == 0)
                {
                    DataTable dt = new DataTable("Scores");
                    dt.Columns.Add("UserID");
                    dt.Columns.Add("Score");
                    dt.Columns.Add("Time");
                    Program.ScoreSet.Tables.Add(dt);
                    Program.ScoreSet.WriteXml(Program.ScoreXML);
                }
            }

            this.label_username.Text = Program.UserName;
            if (Program.ORBStyle.Equals("Office_2013"))
            {
                rbbMain.OrbStyle = RibbonOrbStyle.Office_2013; 
                ribbonButton21.Checked = true;
            }
            else if (Program.ORBStyle.Equals("Office_2010"))
            {
                rbbMain.OrbStyle = RibbonOrbStyle.Office_2010;
                ribbonButton20.Checked = true;
            }
            else
            {
                rbbMain.OrbStyle = RibbonOrbStyle.Office_2007;
                ribbonButton19.Checked = true;
            }
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


        /// <summary>
        /// 开始启动考试
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void ribbonButton5_Click(object sender, EventArgs e)
        {
            frmtext = new start.test();
            frmtext.MdiParent = this;
            frmtext.Dock = DockStyle.Fill;
            frmtext.TopMost = true;
            frmtext.FormBorderStyle = FormBorderStyle.None;
            frmtext.Show();
            Program.Intest = true;
            //其他按钮不可用
            ribbonButton5.Enabled = false;
            ribbonButton7.Enabled = false;
            ribbonButton9.Enabled = false;
        }

        /// <summary>
        /// 解除可用性
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        public void ResumeButton()
        {
            ribbonButton5.Enabled = true;
            ribbonButton7.Enabled = true;
            ribbonButton9.Enabled = true;
        }

        /// <summary>
        /// 设置为随机类型题目
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void ribbonButton3_Click(object sender, EventArgs e)
        {
            ribbonButton3.Checked = true;
            ribbonButton4.Checked = false;
            ribbonButton14.Checked = false;
            ribbonButton15.Checked = false;
            if (frmex != null)
            {
                frmex.setRedam();
            }
        }

        /// <summary>
        /// 设置为选择题型
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            ribbonButton3.Checked = false;
            ribbonButton4.Checked = true;
            ribbonButton14.Checked = false;
            ribbonButton15.Checked = false;
            if (frmex != null)
            {
                frmex.set_choose();
            }
           
        }

        /// <summary>
        /// 设置为填空体型
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void ribbonButton14_Click(object sender, EventArgs e)
        {
            ribbonButton3.Checked = false;
            ribbonButton4.Checked = false;
            ribbonButton14.Checked = true;
            ribbonButton15.Checked = false;
            if (frmex != null)
            {
                frmex.set_black();
            }
            
        }

        /// <summary>
        /// 设置为判断题型
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void ribbonButton15_Click(object sender, EventArgs e)
        {
            ribbonButton3.Checked = false;
            ribbonButton4.Checked = false;
            ribbonButton14.Checked = false;
            ribbonButton15.Checked = true;
            if (frmex != null)
            {
                frmex.set_judge();
            }
            
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

        /// <summary>
        /// 设置为界面为稳重风格
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void ribbonButton19_Click(object sender, EventArgs e)
        {
            ribbonButton19.Checked = true;
            ribbonButton20.Checked = false;
            ribbonButton21.Checked = false;
            rbbMain.OrbStyle = RibbonOrbStyle.Office_2007;
        }

        /// <summary>
        /// 设置为界面为清新风格
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void ribbonButton20_Click(object sender, EventArgs e)
        {
            ribbonButton19.Checked = false;
            ribbonButton20.Checked = true;
            ribbonButton21.Checked = false;
            rbbMain.OrbStyle = RibbonOrbStyle.Office_2010;
        }

        /// <summary>
        /// 设置为界面为现代风格
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void ribbonButton21_Click(object sender, EventArgs e)
        {
            ribbonButton19.Checked = false;
            ribbonButton20.Checked = false;
            ribbonButton21.Checked = true;
            rbbMain.OrbStyle = RibbonOrbStyle.Office_2013;
        }

        /// <summary>
        /// 暂停计时
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void ribbonButton6_Click(object sender, EventArgs e)
        {
            if (ribbonButton6.Text.Equals("暂停计时"))
            {
                frmtext.PoseTest();
                ribbonButton6.Text = "恢复计时";
            }
            else
            {
                frmtext.RestartTest();
                ribbonButton6.Text = "暂停计时";
            }
        }

        /// <summary>
        /// 打开测试设置窗体
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void ribbonButton22_Click(object sender, EventArgs e)
        {
            start.test_setting frmset = new start.test_setting();
            frmset.ShowDialog();
        }

        /// <summary>
        /// 进入错题界面
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            frmerror = new start.errors();
            frmerror.MdiParent = this;
            frmerror.Dock = DockStyle.Fill;
            frmerror.TopMost = true;
            frmerror.FormBorderStyle = FormBorderStyle.None;
            frmerror.Show();
        }

        /// <summary>
        /// 保存当前成绩
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void ribbonButton7_Click(object sender, EventArgs e)
        {
            if (frmtext != null && !Program.Intest)
            {
                DataTable dt = Program.ScoreSet.Tables[0];
                DataRow dr = dt.NewRow();
                dr["UserID"] = Program.UserID;
                dr["Score"] = frmtext.label_grade.Text.Split(new char[]{'：'})[1];
                dr["Time"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                dt.Rows.Add(dr);
                Program.ScoreSet.WriteXml(Program.ScoreXML);
            }
        }

        /// <summary>
        /// 选择选项卡变化时
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void rbbMain_ActiveTabChanged(object sender, EventArgs e)
        {
            if (Program.Intest)
            {
                if (rbbMain.ActiveTab.Text.Equals("日常练习"))
                {
                    rbbMain.ActivateNextTab();
                }
                else if (rbbMain.ActiveTab.Text.Equals("系统设置"))
                {
                    rbbMain.ActivatePreviousTab();
                }
                //rbbMain.ActiveTab = ribbonTab2;
            }
        }

        /// <summary>
        /// 打开学习曲线界面
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void ribbonButton9_Click(object sender, EventArgs e)
        {
            frmscores = new Scores();
            frmscores.MdiParent = this;
            frmscores.Dock = DockStyle.Fill;
            frmscores.TopMost = true;
            frmscores.FormBorderStyle = FormBorderStyle.None;
            frmscores.Show();
        }

    }
}
