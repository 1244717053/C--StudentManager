namespace Student_study
{
    partial class FrmClassList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cob_gradeList = new System.Windows.Forms.ComboBox();
            this.Btn_select = new System.Windows.Forms.Button();
            this.Tx_ClassName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ClassInfo = new System.Windows.Forms.DataGridView();
            this.ColCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ClassId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUpdate = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colDel = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClassInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cob_gradeList);
            this.groupBox1.Controls.Add(this.Btn_select);
            this.groupBox1.Controls.Add(this.Tx_ClassName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // Cob_gradeList
            // 
            this.Cob_gradeList.FormattingEnabled = true;
            this.Cob_gradeList.Location = new System.Drawing.Point(87, 42);
            this.Cob_gradeList.Name = "Cob_gradeList";
            this.Cob_gradeList.Size = new System.Drawing.Size(180, 23);
            this.Cob_gradeList.TabIndex = 5;
            // 
            // Btn_select
            // 
            this.Btn_select.Location = new System.Drawing.Point(618, 35);
            this.Btn_select.Name = "Btn_select";
            this.Btn_select.Size = new System.Drawing.Size(125, 34);
            this.Btn_select.TabIndex = 4;
            this.Btn_select.Text = "查询";
            this.Btn_select.UseVisualStyleBackColor = true;
            this.Btn_select.Click += new System.EventHandler(this.Btn_select_Click);
            // 
            // Tx_ClassName
            // 
            this.Tx_ClassName.Location = new System.Drawing.Point(357, 42);
            this.Tx_ClassName.Name = "Tx_ClassName";
            this.Tx_ClassName.Size = new System.Drawing.Size(194, 25);
            this.Tx_ClassName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "班名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "年级";
            // 
            // dgv_ClassInfo
            // 
            this.dgv_ClassInfo.AllowUserToAddRows = false;
            this.dgv_ClassInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ClassInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ClassInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCheck,
            this.ClassId,
            this.ClassName,
            this.GradeName,
            this.Remark,
            this.ColUpdate,
            this.colDel});
            this.dgv_ClassInfo.Location = new System.Drawing.Point(12, 122);
            this.dgv_ClassInfo.Name = "dgv_ClassInfo";
            this.dgv_ClassInfo.RowHeadersWidth = 51;
            this.dgv_ClassInfo.RowTemplate.Height = 27;
            this.dgv_ClassInfo.Size = new System.Drawing.Size(776, 316);
            this.dgv_ClassInfo.TabIndex = 1;
            this.dgv_ClassInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ClassInfo_CellContentClick);
            // 
            // ColCheck
            // 
            this.ColCheck.HeaderText = "选择";
            this.ColCheck.MinimumWidth = 6;
            this.ColCheck.Name = "ColCheck";
            // 
            // ClassId
            // 
            this.ClassId.DataPropertyName = "ClassId";
            this.ClassId.HeaderText = "班级名称";
            this.ClassId.MinimumWidth = 6;
            this.ClassId.Name = "ClassId";
            this.ClassId.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "班级名称";
            this.ClassName.MinimumWidth = 6;
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // GradeName
            // 
            this.GradeName.DataPropertyName = "GradeName";
            this.GradeName.HeaderText = "年级名称";
            this.GradeName.MinimumWidth = 6;
            this.GradeName.Name = "GradeName";
            this.GradeName.ReadOnly = true;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "说明";
            this.Remark.MinimumWidth = 6;
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            // 
            // ColUpdate
            // 
            dataGridViewCellStyle3.NullValue = "修改";
            this.ColUpdate.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColUpdate.HeaderText = "修改";
            this.ColUpdate.MinimumWidth = 6;
            this.ColUpdate.Name = "ColUpdate";
            // 
            // colDel
            // 
            dataGridViewCellStyle4.NullValue = "删除";
            this.colDel.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDel.HeaderText = "删除";
            this.colDel.MinimumWidth = 6;
            this.colDel.Name = "colDel";
            // 
            // FrmClassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_ClassInfo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmClassList";
            this.Text = "班级列表";
            this.Load += new System.EventHandler(this.FrmClassList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClassInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tx_ClassName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_select;
        private System.Windows.Forms.ComboBox Cob_gradeList;
        private System.Windows.Forms.DataGridView dgv_ClassInfo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewLinkColumn ColUpdate;
        private System.Windows.Forms.DataGridViewLinkColumn colDel;
    }
}