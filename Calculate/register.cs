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

        }

        /// <summary>
        /// 退出，返回登录界面
        /// 作者：杨斌
        /// 最后修改时间：2016-10-11
        /// </summary>
        private void button_cancle_Click(object sender, EventArgs e)
        {

        }
    }
}
