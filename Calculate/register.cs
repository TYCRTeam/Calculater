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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 用户注册
        /// 用户点击确定按钮后，将内容插入到数据库
        /// 错误提示：
        /// 1.用户名已存在
        /// 作者：杨斌
        /// 最后修改时间：2016-10-11
        /// </summary>
        private void button_OK_Click(object sender, EventArgs e)
        {
            string email = this.textBox_email.Text.ToString().Trim();
            string password = this.textBox_userPSW.Text.ToString().Trim();
            string passwordre = textBox_userPSWRe.Text.ToString().Trim();
            string realname = textBox_name.Text.ToString().Trim();
            string nation = textBox_nation.Text.ToString().Trim();
            string province = textBox_province.Text.ToString().Trim();
            string city = textBox_city.Text.ToString().Trim();
            string school = textBox_school.Text.ToString().Trim();
            string classname = this.textBox_classname.Text.ToString().Trim();
            string sex = textBox_sex.Text.ToString().Trim();
            string birthday = textBox_birth.Text.ToString().Trim();
            if (email == "" || realname == "" || sex == "" || password == "" || passwordre == "" || birthday == "")
            {
                MessageBox.Show("带*的选项不能为空！");
            }
            else
            {
                if (password != passwordre)
                {
                    MessageBox.Show("两次密码输入不一致！");
                    return;
                }
               // DataBase.ConnectServerDataBase();
                string sql = "INSERT INTO Users VALUES ('" + email + "','" + password + "','" + realname + "','" + nation + "','" + province + "','" + city + "','" + school + "','" + classname + "','" + sex + "','" + birthday + "','4736776','0')";
                if (login.filterSql(email + password + realname + nation + province + city + school + classname + sex + birthday) == 1)
                {
                    MessageBox.Show("输入了非法字符！");
                    return;
                }
                DataBase.ExecuteNonQuery(sql);
                SendEmail._from = "13931740552@163.com";
                SendEmail.psd = "hebeidaxue521";
                SendEmail._to = email;
                SendEmail._subject = "四则运算软件注册验证码";
                SendEmail._body = "感谢您使用四则运算软件，本次注册的验证码为：4736776";
                SendEmail.send();
                MessageBox.Show("注册成功！请登录您的邮箱获取验证码");
                this.Close();
            }
        }

        /// <summary>
        /// 退出，返回登录界面
        /// 作者：杨斌
        /// 最后修改时间：2016-10-11
        /// </summary>
        private void button_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void register_Load(object sender, EventArgs e)
        {
            //DataTable dt = DataBase.TableResult("SELECT MAX(UserID) FROM Users");
            //this.textBox_userid.Text = (Convert.ToInt16(dt.Rows[0][0].ToString().Trim()) + 1).ToString();
        }

        private void textBox_birth_MouseClick(object sender, MouseEventArgs e)
        {
            this.monthCalendar1.Visible = true;
            this.textBox_birth.Enabled = false;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.textBox_birth.Text = ""+this.monthCalendar1.SelectionStart.Year+"-"+this.monthCalendar1.SelectionStart.Month+"-"+this.monthCalendar1.SelectionStart.Day;
            this.monthCalendar1.Visible = false;
            this.textBox_birth.Enabled = true;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_userid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
