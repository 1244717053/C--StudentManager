namespace Student_study
{
    partial class FrmStudentList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btu_select = new System.Windows.Forms.Button();
            this.Tx_Name = new System.Windows.Forms.TextBox();
            this.Cob_ClassName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_StudentList = new System.Windows.Forms.DataGridView();
            this.ColCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.StuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUpdate = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColDelate = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Btu_Edite = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btu_Edite);
            this.groupBox1.Controls.Add(this.Btu_select);
            this.groupBox1.Controls.Add(this.Tx_Name);
            this.groupBox1.Controls.Add(this.Cob_ClassName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // Btu_select
            // 
            this.Btu_select.Location = new System.Drawing.Point(601, 48);
            this.Btu_select.Name = "Btu_select";
            this.Btu_select.Size = new System.Drawing.Size(109, 33);
            this.Btu_select.TabIndex = 4;
            this.Btu_select.Text = "查询";
            this.Btu_select.UseVisualStyleBackColor = true;
            this.Btu_select.Click += new System.EventHandler(this.Btu_select_Click);
            // 
            // Tx_Name
            // 
            this.Tx_Name.Location = new System.Drawing.Point(343, 54);
            this.Tx_Name.Name = "Tx_Name";
            this.Tx_Name.Size = new System.Drawing.Size(230, 25);
            this.Tx_Name.TabIndex = 3;
            // 
            // Cob_ClassName
            // 
            this.Cob_ClassName.FormattingEnabled = true;
            this.Cob_ClassName.Location = new System.Drawing.Point(51, 54);
            this.Cob_ClassName.Name = "Cob_ClassName";
            this.Cob_ClassName.Size = new System.Drawing.Size(217, 23);
            this.Cob_ClassName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "班级";
            // 
            // dgv_StudentList
            // 
            this.dgv_StudentList.AllowUserToAddRows = false;
            this.dgv_StudentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_StudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCheck,
            this.StuId,
            this.StuName,
            this.Sex,
            this.ClassName,
            this.Phone,
            this.CreateTime,
            this.ColUpdate,
            this.ColDelate});
            this.dgv_StudentList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_StudentList.Location = new System.Drawing.Point(0, 160);
            this.dgv_StudentList.Name = "dgv_StudentList";
            this.dgv_StudentList.RowHeadersWidth = 51;
            this.dgv_StudentList.RowTemplate.Height = 27;
            this.dgv_StudentList.Size = new System.Drawing.Size(905, 309);
            this.dgv_StudentList.TabIndex = 1;
            // 
            // ColCheck
            // 
            this.ColCheck.HeaderText = "选择";
            this.ColCheck.MinimumWidth = 6;
            this.ColCheck.Name = "ColCheck";
            // 
            // StuId
            // 
            this.StuId.DataPropertyName = "StuId";
            this.StuId.HeaderText = "学号";
            this.StuId.MinimumWidth = 6;
            this.StuId.Name = "StuId";
            this.StuId.ReadOnly = true;
            // 
            // StuName
            // 
            this.StuName.DataPropertyName = "StuName";
            this.StuName.HeaderText = "学生姓名";
            this.StuName.MinimumWidth = 6;
            this.StuName.Name = "StuName";
            this.StuName.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "性别";
            this.Sex.MinimumWidth = 6;
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "班级信息";
            this.ClassName.MinimumWidth = 6;
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "联系方式";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "创建时间";
            this.CreateTime.MinimumWidth = 6;
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            // 
            // ColUpdate
            // 
            dataGridViewCellStyle5.NullValue = "修改";
            this.ColUpdate.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColUpdate.HeaderText = "修改";
            this.ColUpdate.MinimumWidth = 6;
            this.ColUpdate.Name = "ColUpdate";
            // 
            // ColDelate
            // 
            dataGridViewCellStyle6.NullValue = "删除";
            this.ColDelate.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColDelate.HeaderText = "删除";
            this.ColDelate.MinimumWidth = 6;
            this.ColDelate.Name = "ColDelate";
            // 
            // Btu_Edite
            // 
            this.Btu_Edite.Location = new System.Drawing.Point(753, 48);
            this.Btu_Edite.Name = "Btu_Edite";
            this.Btu_Edite.Size = new System.Drawing.Size(109, 33);
            this.Btu_Edite.TabIndex = 5;
            this.Btu_Edite.Text = "修改/删除";
            this.Btu_Edite.UseVisualStyleBackColor = true;
            this.Btu_Edite.Click += new System.EventHandler(this.Btu_Edite_Click);
            // 
            // FrmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 469);
            this.Controls.Add(this.dgv_StudentList);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmStudentList";
            this.Text = "学生列表";
            this.Load += new System.EventHandler(this.FrmStudentList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cob_ClassName;
        private System.Windows.Forms.TextBox Tx_Name;
        private System.Windows.Forms.DataGridView dgv_StudentList;
        private System.Windows.Forms.Button Btu_select;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewLinkColumn ColUpdate;
        private System.Windows.Forms.DataGridViewLinkColumn ColDelate;
        private System.Windows.Forms.Button Btu_Edite;
    }
}