namespace Calculate.start
{
    partial class test
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_RightResult = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton_wrong = new System.Windows.Forms.RadioButton();
            this.radioButton_right = new System.Windows.Forms.RadioButton();
            this.radioButton_d = new System.Windows.Forms.RadioButton();
            this.radioButton_a = new System.Windows.Forms.RadioButton();
            this.radioButton_c = new System.Windows.Forms.RadioButton();
            this.radioButton_b = new System.Windows.Forms.RadioButton();
            this.textBox_answer = new System.Windows.Forms.TextBox();
            this.label_type = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsedtime = new System.Windows.Forms.Label();
            this.label_grade = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_forword = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(141, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 172);
            this.panel1.TabIndex = 0;
            // 
            // label_RightResult
            // 
            this.label_RightResult.AutoSize = true;
            this.label_RightResult.BackColor = System.Drawing.Color.Transparent;
            this.label_RightResult.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold);
            this.label_RightResult.Location = new System.Drawing.Point(625, 88);
            this.label_RightResult.Name = "label_RightResult";
            this.label_RightResult.Size = new System.Drawing.Size(129, 35);
            this.label_RightResult.TabIndex = 15;
            this.label_RightResult.Text = "label1";
            this.label_RightResult.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.radioButton_wrong);
            this.panel2.Controls.Add(this.radioButton_right);
            this.panel2.Controls.Add(this.radioButton_d);
            this.panel2.Controls.Add(this.radioButton_a);
            this.panel2.Controls.Add(this.radioButton_c);
            this.panel2.Controls.Add(this.radioButton_b);
            this.panel2.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold);
            this.panel2.Location = new System.Drawing.Point(247, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 148);
            this.panel2.TabIndex = 14;
            // 
            // radioButton_wrong
            // 
            this.radioButton_wrong.AutoSize = true;
            this.radioButton_wrong.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold);
            this.radioButton_wrong.Location = new System.Drawing.Point(155, 18);
            this.radioButton_wrong.Name = "radioButton_wrong";
            this.radioButton_wrong.Size = new System.Drawing.Size(105, 39);
            this.radioButton_wrong.TabIndex = 4;
            this.radioButton_wrong.TabStop = true;
            this.radioButton_wrong.Tag = "f";
            this.radioButton_wrong.Text = "错误";
            this.radioButton_wrong.UseVisualStyleBackColor = true;
            this.radioButton_wrong.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton_right
            // 
            this.radioButton_right.AutoSize = true;
            this.radioButton_right.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold);
            this.radioButton_right.Location = new System.Drawing.Point(17, 18);
            this.radioButton_right.Name = "radioButton_right";
            this.radioButton_right.Size = new System.Drawing.Size(105, 39);
            this.radioButton_right.TabIndex = 3;
            this.radioButton_right.TabStop = true;
            this.radioButton_right.Tag = "t";
            this.radioButton_right.Text = "正确";
            this.radioButton_right.UseVisualStyleBackColor = true;
            this.radioButton_right.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton_d
            // 
            this.radioButton_d.AutoSize = true;
            this.radioButton_d.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold);
            this.radioButton_d.Location = new System.Drawing.Point(272, 106);
            this.radioButton_d.Name = "radioButton_d";
            this.radioButton_d.Size = new System.Drawing.Size(261, 39);
            this.radioButton_d.TabIndex = 6;
            this.radioButton_d.TabStop = true;
            this.radioButton_d.Tag = "d";
            this.radioButton_d.Text = "radioButton4";
            this.radioButton_d.UseVisualStyleBackColor = true;
            this.radioButton_d.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton_a
            // 
            this.radioButton_a.AutoSize = true;
            this.radioButton_a.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold);
            this.radioButton_a.Location = new System.Drawing.Point(17, 55);
            this.radioButton_a.Name = "radioButton_a";
            this.radioButton_a.Size = new System.Drawing.Size(261, 39);
            this.radioButton_a.TabIndex = 3;
            this.radioButton_a.TabStop = true;
            this.radioButton_a.Tag = "a";
            this.radioButton_a.Text = "radioButton1";
            this.radioButton_a.UseVisualStyleBackColor = true;
            this.radioButton_a.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton_c
            // 
            this.radioButton_c.AutoSize = true;
            this.radioButton_c.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold);
            this.radioButton_c.Location = new System.Drawing.Point(17, 106);
            this.radioButton_c.Name = "radioButton_c";
            this.radioButton_c.Size = new System.Drawing.Size(261, 39);
            this.radioButton_c.TabIndex = 5;
            this.radioButton_c.TabStop = true;
            this.radioButton_c.Tag = "c";
            this.radioButton_c.Text = "radioButton3";
            this.radioButton_c.UseVisualStyleBackColor = true;
            this.radioButton_c.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton_b
            // 
            this.radioButton_b.AutoSize = true;
            this.radioButton_b.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold);
            this.radioButton_b.Location = new System.Drawing.Point(272, 55);
            this.radioButton_b.Name = "radioButton_b";
            this.radioButton_b.Size = new System.Drawing.Size(261, 39);
            this.radioButton_b.TabIndex = 4;
            this.radioButton_b.TabStop = true;
            this.radioButton_b.Tag = "b";
            this.radioButton_b.Text = "radioButton2";
            this.radioButton_b.UseVisualStyleBackColor = true;
            this.radioButton_b.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // textBox_answer
            // 
            this.textBox_answer.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold);
            this.textBox_answer.Location = new System.Drawing.Point(503, 81);
            this.textBox_answer.Name = "textBox_answer";
            this.textBox_answer.Size = new System.Drawing.Size(118, 47);
            this.textBox_answer.TabIndex = 13;
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.BackColor = System.Drawing.Color.Transparent;
            this.label_type.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold);
            this.label_type.Location = new System.Drawing.Point(-1, 302);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(129, 35);
            this.label_type.TabIndex = 12;
            this.label_type.Text = "label2";
            this.label_type.Visible = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold);
            this.label_title.Location = new System.Drawing.Point(330, 88);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(129, 35);
            this.label_title.TabIndex = 11;
            this.label_title.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(135, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 35);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            // 
            // lblUsedtime
            // 
            this.lblUsedtime.AutoSize = true;
            this.lblUsedtime.BackColor = System.Drawing.Color.Transparent;
            this.lblUsedtime.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold);
            this.lblUsedtime.Location = new System.Drawing.Point(135, 15);
            this.lblUsedtime.Name = "lblUsedtime";
            this.lblUsedtime.Size = new System.Drawing.Size(159, 35);
            this.lblUsedtime.TabIndex = 20;
            this.lblUsedtime.Text = "倒计时：";
            // 
            // label_grade
            // 
            this.label_grade.AutoSize = true;
            this.label_grade.BackColor = System.Drawing.Color.Transparent;
            this.label_grade.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold);
            this.label_grade.Location = new System.Drawing.Point(659, 9);
            this.label_grade.Name = "label_grade";
            this.label_grade.Size = new System.Drawing.Size(123, 35);
            this.label_grade.TabIndex = 21;
            this.label_grade.Text = "分数：";
            this.label_grade.Visible = false;
            // 
            // button_submit
            // 
            this.button_submit.BackColor = System.Drawing.Color.Transparent;
            this.button_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_submit.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold);
            this.button_submit.Image = global::Calculate.Properties.Resources.yes;
            this.button_submit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_submit.Location = new System.Drawing.Point(625, 296);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(157, 49);
            this.button_submit.TabIndex = 18;
            this.button_submit.Text = "交  卷";
            this.button_submit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_submit.UseVisualStyleBackColor = false;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.Transparent;
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold);
            this.button_next.Image = global::Calculate.Properties.Resources.next;
            this.button_next.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_next.Location = new System.Drawing.Point(436, 296);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(157, 49);
            this.button_next.TabIndex = 17;
            this.button_next.Text = "下一题";
            this.button_next.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_forword
            // 
            this.button_forword.BackColor = System.Drawing.Color.Transparent;
            this.button_forword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_forword.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold);
            this.button_forword.Image = global::Calculate.Properties.Resources._return;
            this.button_forword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_forword.Location = new System.Drawing.Point(247, 296);
            this.button_forword.Name = "button_forword";
            this.button_forword.Size = new System.Drawing.Size(157, 49);
            this.button_forword.TabIndex = 16;
            this.button_forword.Text = "前一题";
            this.button_forword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_forword.UseVisualStyleBackColor = false;
            this.button_forword.Click += new System.EventHandler(this.button_forword_Click);
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 534);
            this.Controls.Add(this.label_grade);
            this.Controls.Add(this.lblUsedtime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_forword);
            this.Controls.Add(this.label_RightResult);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox_answer);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.panel1);
            this.Name = "test";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_RightResult;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton_wrong;
        private System.Windows.Forms.RadioButton radioButton_right;
        private System.Windows.Forms.RadioButton radioButton_d;
        private System.Windows.Forms.RadioButton radioButton_a;
        private System.Windows.Forms.RadioButton radioButton_c;
        private System.Windows.Forms.RadioButton radioButton_b;
        private System.Windows.Forms.TextBox textBox_answer;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_forword;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsedtime;
        public System.Windows.Forms.Label label_grade;

    }
}