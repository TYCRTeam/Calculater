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
            Form f_main = new main();
            this.Hide();
            f_main.ShowDialog();
        }

        /// <summary>
        /// 用户注册
        /// 用户点击注册按钮后，进入注册界面
        /// 作者：杨斌
        /// 最后修改时间：2016-10-11
        /// </summary>
        private void button_register_Click(object sender, EventArgs e)
        {

        }
    }
}
