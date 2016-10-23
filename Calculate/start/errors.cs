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
    public partial class errors : Form
    {

        private string realAnswer;

        public errors()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载错题内容
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void errors_Load(object sender, EventArgs e)
        {
            NewErrorItem();
        }

        /// <summary>
        /// 显示一个新的错误题目
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void NewErrorItem()
        {
            Random re = new Random();
            DataTable dt = Program.ErrorSet.Tables[0];
            int index = re.Next(0, dt.Rows.Count-1);
            DataRow item = dt.Rows[index];

            pnlPath.Visible = false;
            piBW.Visible = false;
            lblW.Visible = false;
            pnlPath.Visible = false;
            pibRight.Visible = false;
            lblRight.Visible = false;
            button_jump.Visible = true;
            //加载内容
            this.textBox_answer.Enabled = true;
            this.textBox_answer.Text = "";

            this.label_title.Text = item["Title"].ToString();
            this.realAnswer = item["Result"].ToString();

            this.textBox_answer.Left = this.label_title.Left + label_title.Width + 5;
            this.label_type.Text = "填空题：";
            this.label_type.Tag = index.ToString();
        }

        /// <summary>
        /// 做对了，删除当前题目
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void RemoveErrorItem()
        {
            DataTable dt = Program.ErrorSet.Tables[0];
            dt.Rows.RemoveAt(int.Parse(this.label_type.Tag.ToString()));
            Program.ErrorSet.WriteXml(Program.ErrorXML);
        }

        /// <summary>
        /// 提交答案
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void button_submit_Click(object sender, EventArgs e)
        {
            if (this.textBox_answer.Text.ToString().Trim() == this.realAnswer)
            {
                pnlPath.Visible = false;
                piBW.Visible = false;
                lblW.Visible = false;
                pnlPath.Visible = true;
                pibRight.Visible = true;
                lblRight.Visible = true;
                Application.DoEvents();
                Thread.Sleep(2000);
                pnlPath.Visible = false;
                pibRight.Visible = false;
                lblRight.Visible = false;
                btnNext.Visible = false;
                button_jump.Visible = true;
                RemoveErrorItem();
                NewErrorItem();
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
            }
        }

        /// <summary>
        /// 跳过该题目
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void button_jump_Click(object sender, EventArgs e)
        {
            pnlPath.Visible = false;
            btnNext.Visible = false;
            button_jump.Visible = true;
            NewErrorItem();
        }

        /// <summary>
        /// 下一题
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            pnlPath.Visible = false;
            btnNext.Visible = false;
            button_jump.Visible = true;
            NewErrorItem();
        }
    }
}
