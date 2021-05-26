namespace Student_study
{
    partial class FrmAddStudent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tx_StuName = new System.Windows.Forms.TextBox();
            this.Cob_ClassName = new System.Windows.Forms.ComboBox();
            this.Rd_man = new System.Windows.Forms.RadioButton();
            this.Rd_woman = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Tx_Phone = new System.Windows.Forms.TextBox();
            this.Btu_AddStudent = new System.Windows.Forms.Button();
            this.Btu_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btu_exit);
            this.panel1.Controls.Add(this.Btu_AddStudent);
            this.panel1.Controls.Add(this.Tx_Phone);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Cob_ClassName);
            this.panel1.Controls.Add(this.Tx_StuName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 378);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "班级";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "电话";
            // 
            // Tx_StuName
            // 
            this.Tx_StuName.Location = new System.Drawing.Point(107, 45);
            this.Tx_StuName.Name = "Tx_StuName";
            this.Tx_StuName.Size = new System.Drawing.Size(262, 25);
            this.Tx_StuName.TabIndex = 4;
            // 
            // Cob_ClassName
            // 
            this.Cob_ClassName.FormattingEnabled = true;
            this.Cob_ClassName.Location = new System.Drawing.Point(107, 103);
            this.Cob_ClassName.Name = "Cob_ClassName";
            this.Cob_ClassName.Size = new System.Drawing.Size(262, 23);
            this.Cob_ClassName.TabIndex = 5;
            // 
            // Rd_man
            // 
            this.Rd_man.AutoSize = true;
            this.Rd_man.Checked = true;
            this.Rd_man.Location = new System.Drawing.Point(21, 13);
            this.Rd_man.Name = "Rd_man";
            this.Rd_man.Size = new System.Drawing.Size(43, 19);
            this.Rd_man.TabIndex = 6;
            this.Rd_man.TabStop = true;
            this.Rd_man.Text = "男";
            this.Rd_man.UseVisualStyleBackColor = true;
            // 
            // Rd_woman
            // 
            this.Rd_woman.AutoSize = true;
            this.Rd_woman.Location = new System.Drawing.Point(93, 13);
            this.Rd_woman.Name = "Rd_woman";
            this.Rd_woman.Size = new System.Drawing.Size(43, 19);
            this.Rd_woman.TabIndex = 7;
            this.Rd_woman.TabStop = true;
            this.Rd_woman.Text = "女";
            this.Rd_woman.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Rd_man);
            this.panel2.Controls.Add(this.Rd_woman);
            this.panel2.Location = new System.Drawing.Point(107, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 37);
            this.panel2.TabIndex = 8;
            // 
            // Tx_Phone
            // 
            this.Tx_Phone.Location = new System.Drawing.Point(107, 233);
            this.Tx_Phone.Name = "Tx_Phone";
            this.Tx_Phone.Size = new System.Drawing.Size(262, 25);
            this.Tx_Phone.TabIndex = 9;
            // 
            // Btu_AddStudent
            // 
            this.Btu_AddStudent.Location = new System.Drawing.Point(50, 299);
            this.Btu_AddStudent.Name = "Btu_AddStudent";
            this.Btu_AddStudent.Size = new System.Drawing.Size(102, 33);
            this.Btu_AddStudent.TabIndex = 10;
            this.Btu_AddStudent.Text = "添加";
            this.Btu_AddStudent.UseVisualStyleBackColor = true;
            this.Btu_AddStudent.Click += new System.EventHandler(this.Btu_AddStudent_Click);
            // 
            // Btu_exit
            // 
            this.Btu_exit.Location = new System.Drawing.Point(267, 299);
            this.Btu_exit.Name = "Btu_exit";
            this.Btu_exit.Size = new System.Drawing.Size(102, 33);
            this.Btu_exit.TabIndex = 11;
            this.Btu_exit.Text = "退出";
            this.Btu_exit.UseVisualStyleBackColor = true;
            // 
            // FrmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 397);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddStudent";
            this.Text = "新增学生页面";
            this.Load += new System.EventHandler(this.FrmAddStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tx_StuName;
        private System.Windows.Forms.ComboBox Cob_ClassName;
        private System.Windows.Forms.RadioButton Rd_woman;
        private System.Windows.Forms.RadioButton Rd_man;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Tx_Phone;
        private System.Windows.Forms.Button Btu_exit;
        private System.Windows.Forms.Button Btu_AddStudent;
    }
}