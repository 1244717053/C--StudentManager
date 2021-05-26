namespace Student_study
{
    partial class FrmAddClass
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tx_ClassName = new System.Windows.Forms.TextBox();
            this.cobGrade_list = new System.Windows.Forms.ComboBox();
            this.Rt_Remark = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Rt_Remark);
            this.panel1.Controls.Add(this.cobGrade_list);
            this.panel1.Controls.Add(this.Tx_ClassName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(36, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 563);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "班级描述";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "班级名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "年级";
            // 
            // Tx_ClassName
            // 
            this.Tx_ClassName.Location = new System.Drawing.Point(112, 33);
            this.Tx_ClassName.Name = "Tx_ClassName";
            this.Tx_ClassName.Size = new System.Drawing.Size(395, 25);
            this.Tx_ClassName.TabIndex = 4;
            // 
            // cobGrade_list
            // 
            this.cobGrade_list.FormattingEnabled = true;
            this.cobGrade_list.Location = new System.Drawing.Point(112, 112);
            this.cobGrade_list.Name = "cobGrade_list";
            this.cobGrade_list.Size = new System.Drawing.Size(395, 23);
            this.cobGrade_list.TabIndex = 5;
            // 
            // Rt_Remark
            // 
            this.Rt_Remark.Location = new System.Drawing.Point(112, 195);
            this.Rt_Remark.Name = "Rt_Remark";
            this.Rt_Remark.Size = new System.Drawing.Size(395, 146);
            this.Rt_Remark.TabIndex = 6;
            this.Rt_Remark.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmAddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 602);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAddClass";
            this.Text = "添加班级";
            this.Load += new System.EventHandler(this.FrmAddClass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tx_ClassName;
        private System.Windows.Forms.ComboBox cobGrade_list;
        private System.Windows.Forms.RichTextBox Rt_Remark;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}