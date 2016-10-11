namespace Calculate
{
    partial class login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_userId = new System.Windows.Forms.TextBox();
            this.textBox_userPSW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(228, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "四则运算";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(168, 396);
            this.button_login.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(150, 46);
            this.button_login.TabIndex = 1;
            this.button_login.Text = "登录";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(388, 394);
            this.button_register.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(150, 46);
            this.button_register.TabIndex = 2;
            this.button_register.Text = "注册";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "密码：";
            // 
            // textBox_userId
            // 
            this.textBox_userId.Location = new System.Drawing.Point(214, 162);
            this.textBox_userId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_userId.Name = "textBox_userId";
            this.textBox_userId.Size = new System.Drawing.Size(320, 35);
            this.textBox_userId.TabIndex = 5;
            // 
            // textBox_userPSW
            // 
            this.textBox_userPSW.Location = new System.Drawing.Point(214, 226);
            this.textBox_userPSW.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_userPSW.Name = "textBox_userPSW";
            this.textBox_userPSW.Size = new System.Drawing.Size(320, 35);
            this.textBox_userPSW.TabIndex = 6;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 522);
            this.Controls.Add(this.textBox_userPSW);
            this.Controls.Add(this.textBox_userId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "login";
            this.Text = "登陆";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_userId;
        private System.Windows.Forms.TextBox textBox_userPSW;
    }
}

