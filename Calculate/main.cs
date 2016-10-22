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
            start.test tx = new start.test();
            tx.TopLevel = false;
            tx.FormBorderStyle = FormBorderStyle.None;
            //this.panel1.Controls.Clear();
            //this.panel1.Controls.Add(tx);
            tx.Show();
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

    }
}
