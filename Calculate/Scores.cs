using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Calculate
{
    public partial class Scores : Form
    {
        public Scores()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载界面显示成绩
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void Scores_Load(object sender, EventArgs e)
        {
            lsvScores.Items.Clear();
            DataTable dt = Program.ScoreSet.Tables[0];
            Debug.Write(Program.ScoreSet.GetXml());
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow item = dt.Rows[i];
                ListViewItem li = lsvScores.Items.Add((i+1).ToString());
                li.SubItems.Add(item["Score"].ToString());
                li.SubItems.Add(item["Time"].ToString());
            }
        }
    }
}
