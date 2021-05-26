namespace Student_study
{
    partial class Main
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
            this.IMStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_Student = new System.Windows.Forms.ToolStripMenuItem();
            this.Student_List = new System.Windows.Forms.ToolStripMenuItem();
            this.IMClass = new System.Windows.Forms.ToolStripMenuItem();
            this.AddClass = new System.Windows.Forms.ToolStripMenuItem();
            this.Class_List = new System.Windows.Forms.ToolStripMenuItem();
            this.IMGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.Grade_List = new System.Windows.Forms.ToolStripMenuItem();
            this.IMexit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IMStudent,
            this.IMClass,
            this.IMGrade,
            this.IMexit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1193, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // IMStudent
            // 
            this.IMStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_Student,
            this.Student_List});
            this.IMStudent.Name = "IMStudent";
            this.IMStudent.Size = new System.Drawing.Size(83, 24);
            this.IMStudent.Text = "学生管理";
            // 
            // Add_Student
            // 
            this.Add_Student.Name = "Add_Student";
            this.Add_Student.Size = new System.Drawing.Size(224, 26);
            this.Add_Student.Text = "新增学生";
            this.Add_Student.Click += new System.EventHandler(this.Add_Student_Click);
            // 
            // Student_List
            // 
            this.Student_List.Name = "Student_List";
            this.Student_List.Size = new System.Drawing.Size(224, 26);
            this.Student_List.Text = "学生列表";
            this.Student_List.Click += new System.EventHandler(this.Student_List_Click);
            // 
            // IMClass
            // 
            this.IMClass.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddClass,
            this.Class_List});
            this.IMClass.Name = "IMClass";
            this.IMClass.Size = new System.Drawing.Size(83, 24);
            this.IMClass.Text = "班级管理";
            // 
            // AddClass
            // 
            this.AddClass.Name = "AddClass";
            this.AddClass.Size = new System.Drawing.Size(224, 26);
            this.AddClass.Text = "新增班级";
            this.AddClass.Click += new System.EventHandler(this.AddClass_Click);
            // 
            // Class_List
            // 
            this.Class_List.Name = "Class_List";
            this.Class_List.Size = new System.Drawing.Size(224, 26);
            this.Class_List.Text = "班级列表";
            this.Class_List.Click += new System.EventHandler(this.Class_List_Click);
            // 
            // IMGrade
            // 
            this.IMGrade.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Grade_List});
            this.IMGrade.Name = "IMGrade";
            this.IMGrade.Size = new System.Drawing.Size(83, 24);
            this.IMGrade.Text = "年级管理";
            // 
            // Grade_List
            // 
            this.Grade_List.Name = "Grade_List";
            this.Grade_List.Size = new System.Drawing.Size(224, 26);
            this.Grade_List.Text = "年级列表";
            this.Grade_List.Click += new System.EventHandler(this.Grade_List_Click);
            // 
            // IMexit
            // 
            this.IMexit.Name = "IMexit";
            this.IMexit.Size = new System.Drawing.Size(83, 24);
            this.IMexit.Text = "退出系统";
            this.IMexit.Click += new System.EventHandler(this.IMexit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 712);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "学生管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem IMStudent;
        private System.Windows.Forms.ToolStripMenuItem IMClass;
        private System.Windows.Forms.ToolStripMenuItem IMGrade;
        private System.Windows.Forms.ToolStripMenuItem IMexit;
        private System.Windows.Forms.ToolStripMenuItem Add_Student;
        private System.Windows.Forms.ToolStripMenuItem Student_List;
        private System.Windows.Forms.ToolStripMenuItem AddClass;
        private System.Windows.Forms.ToolStripMenuItem Class_List;
        private System.Windows.Forms.ToolStripMenuItem Grade_List;
    }
}