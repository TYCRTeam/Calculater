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
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载界面显示个人基本信息
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void UserInfo_Load(object sender, EventArgs e)
        {
            DataTable dt = DataBase.TableResult("select * from Users where UserID = " + Program.UserID);
            if(dt.Rows.Count > 0)
            {
                this.textBox_birth.Text = dt.Rows[0]["Birthday"].ToString();
                this.textBox_city.Text = dt.Rows[0]["City"].ToString();
                this.textBox_classname.Text = dt.Rows[0]["ClassName"].ToString();
                this.textBox_email.Text = dt.Rows[0]["Email"].ToString();
                this.textBox_name.Text = dt.Rows[0]["RealName"].ToString();
                this.textBox_nation.Text = dt.Rows[0]["Nation"].ToString();
                this.textBox_province.Text = dt.Rows[0]["Province"].ToString();
                this.textBox_school.Text = dt.Rows[0]["School"].ToString();
                this.textBox_sex.Text = dt.Rows[0]["Sex"].ToString();
            }
            
        }


        /// <summary>
        /// 保存后退出
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_userPSW.Text != textBox_userPSWRe.Text)
            {
                MessageBox.Show("两次输入的密码不同！");
            }
            else if (textBox_userPSW.Text.Length < 5)
            {
                MessageBox.Show("两次输入的密码不同！");
            }
            else
            {
                if (textBox_userPSW.Text == "TJNUoffice2012")
                {
                    string sql = "update Users set Birthday='" + textBox_birth.Value.ToString("yyyy-MM-dd") + "',City='" + textBox_city.Text + "',ClassName='" + textBox_classname.Text + "',RealName='" + textBox_name.Text + "',Nation='" + textBox_nation.Text + "',Province='" + textBox_province.Text + "',School='" + textBox_school.Text + "',Sex='" + textBox_sex.Text + "' where UserID = " + Program.UserID;
                }
                else
                {
                    string sql = "update Users set Password='" + textBox_userPSW.Text + "', Birthday='" + textBox_birth.Value.ToString("yyyy-MM-dd") + "',City='" + textBox_city.Text + "',ClassName='" + textBox_classname.Text + "',RealName='" + textBox_name.Text + "',Nation='" + textBox_nation.Text + "',Province='" + textBox_province.Text + "',School='" + textBox_school.Text + "',Sex='" + textBox_sex.Text + "' where UserID = " + Program.UserID;
                }
                MessageBox.Show("修改成功！");
            }
            this.Dispose();
        }

        /// <summary>
        /// 不保存退出
        /// 作者：田强
        /// 最后修改时间：2016-10-21
        /// </summary>
        private void button_cancle_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
