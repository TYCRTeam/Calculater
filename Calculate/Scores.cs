using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using ZedGraph;

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
            //Debug.Write(Program.ScoreSet.GetXml());
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow item = dt.Rows[i];
                ListViewItem li = lsvScores.Items.Add((i+1).ToString());
                li.SubItems.Add(item["Score"].ToString());
                li.SubItems.Add(item["Time"].ToString());
            }

            GraphPane mypt = zedGraphControl1.GraphPane;
            mypt.CurveList.Clear();
            mypt.Title.Text = "学习曲线";
            mypt.XAxis.Title.Text = "时间";
            mypt.YAxis.Title.Text = "分数";

            string[] labels3;
            double[] y;

            labels3 = new string[dt.Rows.Count];
            y = new double[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                y[i] = double.Parse(dt.Rows[i]["Score"].ToString());
                labels3[i] = dt.Rows[i]["Time"].ToString().Split(new char[] { ' ' })[0];
            }

                //if (dt.Rows.Count > 5)
                //{
                //    labels3 = new string[5];
                //    y = new double[5];
                //    int ii = 0;
                //    //多于5条记录，则取后五条
                //    for (int i = dt.Rows.Count - 1; i > dt.Rows.Count - 6; i--)
                //    {
                //        y[ii] = double.Parse(dt.Rows[i]["Score"].ToString());
                //        labels3[ii++] = dt.Rows[i]["Time"].ToString().Split(new char[] { ' ' })[0];

                //    }
                //}
                //else
                //{
                //    int ii = 0;
                //    y = new double[dt.Rows.Count];
                //    labels3 = new string[dt.Rows.Count];
                //    for (int i = dt.Rows.Count - 1; i >= 0; i--)
                //    {
                //        y[ii] = double.Parse(dt.Rows[i]["Score"].ToString());
                //        labels3[ii++] = dt.Rows[i]["Time"].ToString().Split(new char[] { ' ' })[0];
                //    }
                //}

            LineItem myCurve = mypt.AddCurve("成绩曲线", null, y, Color.Red, SymbolType.Circle);
            myCurve.Symbol.Size = 8.0F;
            myCurve.Symbol.Fill = new Fill(Color.Red);
            myCurve.Line.Width = 2.0F;


            mypt.XAxis.MajorTic.IsBetweenLabels = true;
            mypt.XAxis.Scale.TextLabels = labels3;
            mypt.XAxis.Type = AxisType.Text;

            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();
        }
    }
}
