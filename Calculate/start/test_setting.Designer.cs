namespace Calculate.start
{
    partial class test_setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_chooseNum = new System.Windows.Forms.TextBox();
            this.textBox_judgeNum = new System.Windows.Forms.TextBox();
            this.textBox_blackNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_time = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "难度：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "选择题数：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "判断题数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "填空题数：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "初级",
            "中级",
            "高级"});
            this.comboBox1.Location = new System.Drawing.Point(103, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox_chooseNum
            // 
            this.textBox_chooseNum.Location = new System.Drawing.Point(103, 69);
            this.textBox_chooseNum.Name = "textBox_chooseNum";
            this.textBox_chooseNum.Size = new System.Drawing.Size(121, 21);
            this.textBox_chooseNum.TabIndex = 5;
            this.textBox_chooseNum.Text = "20";
            // 
            // textBox_judgeNum
            // 
            this.textBox_judgeNum.Location = new System.Drawing.Point(103, 101);
            this.textBox_judgeNum.Name = "textBox_judgeNum";
            this.textBox_judgeNum.Size = new System.Drawing.Size(121, 21);
            this.textBox_judgeNum.TabIndex = 6;
            this.textBox_judgeNum.Text = "20";
            // 
            // textBox_blackNum
            // 
            this.textBox_blackNum.Location = new System.Drawing.Point(104, 132);
            this.textBox_blackNum.Name = "textBox_blackNum";
            this.textBox_blackNum.Size = new System.Drawing.Size(120, 21);
            this.textBox_blackNum.TabIndex = 7;
            this.textBox_blackNum.Text = "40";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "考试时间：";
            // 
            // textBox_time
            // 
            this.textBox_time.Location = new System.Drawing.Point(104, 162);
            this.textBox_time.Name = "textBox_time";
            this.textBox_time.Size = new System.Drawing.Size(120, 21);
            this.textBox_time.TabIndex = 9;
            this.textBox_time.Text = "40";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "分钟";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(48, 219);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 11;
            this.button_ok.Text = "确定";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancle
            // 
            this.button_cancle.Location = new System.Drawing.Point(164, 219);
            this.button_cancle.Name = "button_cancle";
            this.button_cancle.Size = new System.Drawing.Size(75, 23);
            this.button_cancle.TabIndex = 12;
            this.button_cancle.Text = "取消";
            this.button_cancle.UseVisualStyleBackColor = true;
            // 
            // test_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 277);
            this.Controls.Add(this.button_cancle);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_blackNum);
            this.Controls.Add(this.textBox_judgeNum);
            this.Controls.Add(this.textBox_chooseNum);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "test_setting";
            this.Text = "考试设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_chooseNum;
        private System.Windows.Forms.TextBox textBox_judgeNum;
        private System.Windows.Forms.TextBox textBox_blackNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancle;

    }
}