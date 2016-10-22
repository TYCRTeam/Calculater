namespace Calculate.start
{
    partial class exercise
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
            this.label_title = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.textBox_answer = new System.Windows.Forms.TextBox();
            this.radioButton_a = new System.Windows.Forms.RadioButton();
            this.radioButton_b = new System.Windows.Forms.RadioButton();
            this.radioButton_c = new System.Windows.Forms.RadioButton();
            this.radioButton_d = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_wrong = new System.Windows.Forms.RadioButton();
            this.radioButton_right = new System.Windows.Forms.RadioButton();
            this.label_RightResult = new System.Windows.Forms.Label();
            this.ribbonButtonList1 = new System.Windows.Forms.RibbonButtonList();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.button_explain = new System.Windows.Forms.Button();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.button_jump = new System.Windows.Forms.Button();
            this.button_submit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_title.Location = new System.Drawing.Point(224, 100);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(129, 35);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "label1";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_type.Location = new System.Drawing.Point(111, 42);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(129, 35);
            this.label_type.TabIndex = 1;
            this.label_type.Text = "label2";
            // 
            // textBox_answer
            // 
            this.textBox_answer.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_answer.Location = new System.Drawing.Point(466, 88);
            this.textBox_answer.Name = "textBox_answer";
            this.textBox_answer.Size = new System.Drawing.Size(100, 47);
            this.textBox_answer.TabIndex = 2;
            // 
            // radioButton_a
            // 
            this.radioButton_a.AutoSize = true;
            this.radioButton_a.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_a.Location = new System.Drawing.Point(17, 55);
            this.radioButton_a.Name = "radioButton_a";
            this.radioButton_a.Size = new System.Drawing.Size(172, 25);
            this.radioButton_a.TabIndex = 3;
            this.radioButton_a.TabStop = true;
            this.radioButton_a.Text = "radioButton1";
            this.radioButton_a.UseVisualStyleBackColor = true;
            this.radioButton_a.CheckedChanged += new System.EventHandler(this.radioButton_a_CheckedChanged);
            // 
            // radioButton_b
            // 
            this.radioButton_b.AutoSize = true;
            this.radioButton_b.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_b.Location = new System.Drawing.Point(208, 55);
            this.radioButton_b.Name = "radioButton_b";
            this.radioButton_b.Size = new System.Drawing.Size(172, 25);
            this.radioButton_b.TabIndex = 4;
            this.radioButton_b.TabStop = true;
            this.radioButton_b.Text = "radioButton2";
            this.radioButton_b.UseVisualStyleBackColor = true;
            this.radioButton_b.CheckedChanged += new System.EventHandler(this.radioButton_b_CheckedChanged);
            // 
            // radioButton_c
            // 
            this.radioButton_c.AutoSize = true;
            this.radioButton_c.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_c.Location = new System.Drawing.Point(17, 106);
            this.radioButton_c.Name = "radioButton_c";
            this.radioButton_c.Size = new System.Drawing.Size(172, 25);
            this.radioButton_c.TabIndex = 5;
            this.radioButton_c.TabStop = true;
            this.radioButton_c.Text = "radioButton3";
            this.radioButton_c.UseVisualStyleBackColor = true;
            this.radioButton_c.CheckedChanged += new System.EventHandler(this.radioButton_c_CheckedChanged);
            // 
            // radioButton_d
            // 
            this.radioButton_d.AutoSize = true;
            this.radioButton_d.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_d.Location = new System.Drawing.Point(208, 106);
            this.radioButton_d.Name = "radioButton_d";
            this.radioButton_d.Size = new System.Drawing.Size(172, 25);
            this.radioButton_d.TabIndex = 6;
            this.radioButton_d.TabStop = true;
            this.radioButton_d.Text = "radioButton4";
            this.radioButton_d.UseVisualStyleBackColor = true;
            this.radioButton_d.CheckedChanged += new System.EventHandler(this.radioButton_d_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_wrong);
            this.panel1.Controls.Add(this.radioButton_right);
            this.panel1.Controls.Add(this.radioButton_d);
            this.panel1.Controls.Add(this.radioButton_a);
            this.panel1.Controls.Add(this.radioButton_c);
            this.panel1.Controls.Add(this.radioButton_b);
            this.panel1.Location = new System.Drawing.Point(230, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 148);
            this.panel1.TabIndex = 7;
            // 
            // radioButton_wrong
            // 
            this.radioButton_wrong.AutoSize = true;
            this.radioButton_wrong.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_wrong.Location = new System.Drawing.Point(155, 18);
            this.radioButton_wrong.Name = "radioButton_wrong";
            this.radioButton_wrong.Size = new System.Drawing.Size(72, 25);
            this.radioButton_wrong.TabIndex = 4;
            this.radioButton_wrong.TabStop = true;
            this.radioButton_wrong.Text = "错误";
            this.radioButton_wrong.UseVisualStyleBackColor = true;
            // 
            // radioButton_right
            // 
            this.radioButton_right.AutoSize = true;
            this.radioButton_right.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_right.Location = new System.Drawing.Point(17, 18);
            this.radioButton_right.Name = "radioButton_right";
            this.radioButton_right.Size = new System.Drawing.Size(72, 25);
            this.radioButton_right.TabIndex = 3;
            this.radioButton_right.TabStop = true;
            this.radioButton_right.Text = "正确";
            this.radioButton_right.UseVisualStyleBackColor = true;
            // 
            // label_RightResult
            // 
            this.label_RightResult.AutoSize = true;
            this.label_RightResult.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_RightResult.Location = new System.Drawing.Point(589, 100);
            this.label_RightResult.Name = "label_RightResult";
            this.label_RightResult.Size = new System.Drawing.Size(129, 35);
            this.label_RightResult.TabIndex = 10;
            this.label_RightResult.Text = "label1";
            this.label_RightResult.Visible = false;
            // 
            // ribbonButtonList1
            // 
            this.ribbonButtonList1.ButtonsSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.ribbonButtonList1.FlowToBottom = false;
            this.ribbonButtonList1.ItemsSizeInDropwDownMode = new System.Drawing.Size(7, 5);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Text = null;
            // 
            // button_explain
            // 
            this.button_explain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_explain.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_explain.Image = global::Calculate.Properties.Resources.notebook;
            this.button_explain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_explain.Location = new System.Drawing.Point(538, 336);
            this.button_explain.Name = "button_explain";
            this.button_explain.Size = new System.Drawing.Size(180, 49);
            this.button_explain.TabIndex = 11;
            this.button_explain.Text = "题目讲解";
            this.button_explain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_explain.UseVisualStyleBackColor = true;
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(0, 402);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_log.Size = new System.Drawing.Size(1036, 101);
            this.textBox_log.TabIndex = 13;
            // 
            // button_jump
            // 
            this.button_jump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_jump.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_jump.Image = global::Calculate.Properties.Resources.next;
            this.button_jump.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_jump.Location = new System.Drawing.Point(385, 336);
            this.button_jump.Name = "button_jump";
            this.button_jump.Size = new System.Drawing.Size(123, 49);
            this.button_jump.TabIndex = 9;
            this.button_jump.Text = "跳过";
            this.button_jump.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_jump.UseVisualStyleBackColor = true;
            this.button_jump.Click += new System.EventHandler(this.button_jump_Click);
            // 
            // button_submit
            // 
            this.button_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_submit.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_submit.Image = global::Calculate.Properties.Resources.yes;
            this.button_submit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_submit.Location = new System.Drawing.Point(230, 336);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(123, 49);
            this.button_submit.TabIndex = 8;
            this.button_submit.Text = "提交";
            this.button_submit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // exercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 498);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.button_explain);
            this.Controls.Add(this.label_RightResult);
            this.Controls.Add(this.button_jump);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_answer);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.label_title);
            this.Name = "exercise";
            this.Text = "exercise";
            this.Load += new System.EventHandler(this.exercise_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.TextBox textBox_answer;
        private System.Windows.Forms.RadioButton radioButton_a;
        private System.Windows.Forms.RadioButton radioButton_b;
        private System.Windows.Forms.RadioButton radioButton_c;
        private System.Windows.Forms.RadioButton radioButton_d;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Button button_jump;
        private System.Windows.Forms.Label label_RightResult;
        private System.Windows.Forms.RibbonButtonList ribbonButtonList1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.Button button_explain;
        private System.Windows.Forms.RadioButton radioButton_right;
        private System.Windows.Forms.RadioButton radioButton_wrong;
        private System.Windows.Forms.TextBox textBox_log;

    }
}