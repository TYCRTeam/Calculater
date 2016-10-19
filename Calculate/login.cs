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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 系统登录
        /// 用户点击登录按钮后，通过远程连接数据库，核对用户名密码后进入主界面
        /// 错误提示：
        /// 1.用户名和密码输入错误
        /// 2.用户不存在
        /// 作者：杨斌
        /// 最后修改时间：2016-10-11
        /// </summary>
        private void button_login_Click(object sender, EventArgs e)
        {
            //DataBase.ConnectServerDataBase();
            //DataTable dt = DataBase.TableResult("select * from Users");
            //MessageBox.Show(""+dt.Rows.Count+"");
            //DataBase.ConnectServerDataBase();
            if (this.textBox_userId.Text != null && this.textBox_userPSW.Text != null)
            {
                if (this.textBox_userId.Text.ToString().Trim() == "" || this.textBox_userPSW.Text.ToString().Trim() == "") 
                {
                    MessageBox.Show("用户名或密码不能为空！");
                    return;
                }
                
                DataTable dt = new DataTable();
                if (filterSql(this.textBox_userId.Text.ToString().Trim()) == 0 && filterSql(this.textBox_userPSW.Text.ToString().Trim()) ==0 )
                {
                    string sql = "SELECT * FROM Users WHERE UserID = " + this.textBox_userId.Text.ToString().Trim() + "";
                    dt = DataBase.TableResult(sql);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("用户名不存在！");
                    }
                    else
                    {
                        sql = "SELECT * FROM Users WHERE UserID = " + this.textBox_userId.Text.ToString().Trim() + " AND Password = " + this.textBox_userPSW.Text.ToString().Trim() + "";
                        dt.Rows.Clear();
                        dt = DataBase.TableResult(sql);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("用户名和密码错误！");
                        }
                        else
                        {
                            DataTable dt1=DataBase.TableResult("SELECT RealName FROM Users WHERE UserID="+this.textBox_userId.Text.ToString().Trim()+"");
                            Program.UserID = this.textBox_userId.Text;
                            Program.UserName = dt1.Rows[0][0].ToString();
                            Form f_main = new main();
                            this.Hide();
                            f_main.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("输入了非法字符！");
                }
            }
        }

        /// <summary>
        /// 检测sql注入
        /// </summary>
        /// <param name="sSql"></param>
        /// <returns></returns>
        public  static int filterSql(string sSql)
        {
            int srcLen, decLen = 0;
            sSql = sSql.ToLower().Trim();
            srcLen = sSql.Length;
            sSql = sSql.Replace(" ","");
            sSql = sSql.Replace("'","");
            sSql = sSql.Replace("exec", "");
            sSql = sSql.Replace("delete", "");
            sSql = sSql.Replace("master", "");
            sSql = sSql.Replace("truncate", "");
            sSql = sSql.Replace("declare", "");
            sSql = sSql.Replace("create", "");
            sSql = sSql.Replace("xp_", "no");
            decLen = sSql.Length;
            if (srcLen == decLen) return 0; else return 1;
        }

        /// <summary>
        /// 用户注册
        /// 用户点击注册按钮后，进入注册界面
        /// 作者：杨斌
        /// 最后修改时间：2016-10-11
        /// </summary>
        private void button_register_Click(object sender, EventArgs e)
        {
            Form re = new register();
            re.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_userPSW_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
