namespace Calculate
{
    partial class main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_start = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_start_exercise = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_start_exam = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_check = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_check_wrongAnswer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_check_examGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_option = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_option_difficult = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_option_difficult_low = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_option_difficult_middle = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_option_difficult_high = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_option_questionType = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_option_questionType_choice = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_option_questionType_fBlank = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_option_questionType_judge = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_help = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_help_help = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_about = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_about_about = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_start,
            this.ToolStripMenuItem_check,
            this.ToolStripMenuItem_option,
            this.ToolStripMenuItem_help,
            this.ToolStripMenuItem_about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_start
            // 
            this.ToolStripMenuItem_start.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_start_exercise,
            this.ToolStripMenuItem_start_exam});
            this.ToolStripMenuItem_start.Name = "ToolStripMenuItem_start";
            this.ToolStripMenuItem_start.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem_start.Text = "开始";
            // 
            // ToolStripMenuItem_start_exercise
            // 
            this.ToolStripMenuItem_start_exercise.Name = "ToolStripMenuItem_start_exercise";
            this.ToolStripMenuItem_start_exercise.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_start_exercise.Text = "练习";
            this.ToolStripMenuItem_start_exercise.Click += new System.EventHandler(this.ToolStripMenuItem_start_exercise_Click);
            // 
            // ToolStripMenuItem_start_exam
            // 
            this.ToolStripMenuItem_start_exam.Name = "ToolStripMenuItem_start_exam";
            this.ToolStripMenuItem_start_exam.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_start_exam.Text = "考试";
            this.ToolStripMenuItem_start_exam.Click += new System.EventHandler(this.ToolStripMenuItem_start_exam_Click);
            // 
            // ToolStripMenuItem_check
            // 
            this.ToolStripMenuItem_check.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_check_wrongAnswer,
            this.ToolStripMenuItem_check_examGrade});
            this.ToolStripMenuItem_check.Name = "ToolStripMenuItem_check";
            this.ToolStripMenuItem_check.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem_check.Text = "查看";
            // 
            // ToolStripMenuItem_check_wrongAnswer
            // 
            this.ToolStripMenuItem_check_wrongAnswer.Name = "ToolStripMenuItem_check_wrongAnswer";
            this.ToolStripMenuItem_check_wrongAnswer.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_check_wrongAnswer.Text = "错题";
            this.ToolStripMenuItem_check_wrongAnswer.Click += new System.EventHandler(this.ToolStripMenuItem_check_wrongAnswer_Click);
            // 
            // ToolStripMenuItem_check_examGrade
            // 
            this.ToolStripMenuItem_check_examGrade.Name = "ToolStripMenuItem_check_examGrade";
            this.ToolStripMenuItem_check_examGrade.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_check_examGrade.Text = "考试成绩";
            this.ToolStripMenuItem_check_examGrade.Click += new System.EventHandler(this.ToolStripMenuItem_check_examGrade_Click);
            // 
            // ToolStripMenuItem_option
            // 
            this.ToolStripMenuItem_option.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_option_difficult,
            this.ToolStripMenuItem_option_questionType});
            this.ToolStripMenuItem_option.Name = "ToolStripMenuItem_option";
            this.ToolStripMenuItem_option.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem_option.Text = "选项";
            // 
            // ToolStripMenuItem_option_difficult
            // 
            this.ToolStripMenuItem_option_difficult.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_option_difficult_low,
            this.ToolStripMenuItem_option_difficult_middle,
            this.ToolStripMenuItem_option_difficult_high});
            this.ToolStripMenuItem_option_difficult.Name = "ToolStripMenuItem_option_difficult";
            this.ToolStripMenuItem_option_difficult.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_option_difficult.Text = "难度";
            // 
            // ToolStripMenuItem_option_difficult_low
            // 
            this.ToolStripMenuItem_option_difficult_low.Name = "ToolStripMenuItem_option_difficult_low";
            this.ToolStripMenuItem_option_difficult_low.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_option_difficult_low.Text = "初级";
            // 
            // ToolStripMenuItem_option_difficult_middle
            // 
            this.ToolStripMenuItem_option_difficult_middle.Name = "ToolStripMenuItem_option_difficult_middle";
            this.ToolStripMenuItem_option_difficult_middle.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_option_difficult_middle.Text = "中级";
            // 
            // ToolStripMenuItem_option_difficult_high
            // 
            this.ToolStripMenuItem_option_difficult_high.Name = "ToolStripMenuItem_option_difficult_high";
            this.ToolStripMenuItem_option_difficult_high.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_option_difficult_high.Text = "高级";
            // 
            // ToolStripMenuItem_option_questionType
            // 
            this.ToolStripMenuItem_option_questionType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_option_questionType_choice,
            this.ToolStripMenuItem_option_questionType_fBlank,
            this.ToolStripMenuItem_option_questionType_judge});
            this.ToolStripMenuItem_option_questionType.Name = "ToolStripMenuItem_option_questionType";
            this.ToolStripMenuItem_option_questionType.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_option_questionType.Text = "题型";
            // 
            // ToolStripMenuItem_option_questionType_choice
            // 
            this.ToolStripMenuItem_option_questionType_choice.Name = "ToolStripMenuItem_option_questionType_choice";
            this.ToolStripMenuItem_option_questionType_choice.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_option_questionType_choice.Text = "选择";
            // 
            // ToolStripMenuItem_option_questionType_fBlank
            // 
            this.ToolStripMenuItem_option_questionType_fBlank.Name = "ToolStripMenuItem_option_questionType_fBlank";
            this.ToolStripMenuItem_option_questionType_fBlank.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_option_questionType_fBlank.Text = "填空";
            // 
            // ToolStripMenuItem_option_questionType_judge
            // 
            this.ToolStripMenuItem_option_questionType_judge.Name = "ToolStripMenuItem_option_questionType_judge";
            this.ToolStripMenuItem_option_questionType_judge.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_option_questionType_judge.Text = "判断";
            // 
            // ToolStripMenuItem_help
            // 
            this.ToolStripMenuItem_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_help_help});
            this.ToolStripMenuItem_help.Name = "ToolStripMenuItem_help";
            this.ToolStripMenuItem_help.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem_help.Text = "帮助";
            // 
            // ToolStripMenuItem_help_help
            // 
            this.ToolStripMenuItem_help_help.Name = "ToolStripMenuItem_help_help";
            this.ToolStripMenuItem_help_help.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuItem_help_help.Text = "帮助";
            // 
            // ToolStripMenuItem_about
            // 
            this.ToolStripMenuItem_about.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_about_about});
            this.ToolStripMenuItem_about.Name = "ToolStripMenuItem_about";
            this.ToolStripMenuItem_about.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem_about.Text = "关于";
            // 
            // ToolStripMenuItem_about_about
            // 
            this.ToolStripMenuItem_about_about.Name = "ToolStripMenuItem_about_about";
            this.ToolStripMenuItem_about_about.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_about_about.Text = "四则运算";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 562);
            this.panel1.TabIndex = 1;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "四则运算";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_start;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_start_exercise;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_start_exam;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_check;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_check_wrongAnswer;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_check_examGrade;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_option;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_option_difficult;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_option_difficult_low;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_option_difficult_middle;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_option_difficult_high;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_option_questionType;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_option_questionType_choice;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_option_questionType_fBlank;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_option_questionType_judge;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_help;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_help_help;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_about;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_about_about;
        private System.Windows.Forms.Panel panel1;
    }
}