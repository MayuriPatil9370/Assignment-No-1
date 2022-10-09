namespace Student_Management_System
{
    partial class frm_View_Student_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_View_Student_List));
            this.lbl_View_Student_List = new System.Windows.Forms.Label();
            this.lbl_Add_New_Student = new System.Windows.Forms.Label();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.student_Management_DBDataSet = new Student_Management_System.Student_Management_DBDataSet();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_DetailsTableAdapter = new Student_Management_System.Student_Management_DBDataSetTableAdapters.Student_DetailsTableAdapter();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_LogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Student_List
            // 
            this.lbl_View_Student_List.AutoSize = true;
            this.lbl_View_Student_List.BackColor = System.Drawing.Color.White;
            this.lbl_View_Student_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Student_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_View_Student_List.Location = new System.Drawing.Point(216, 41);
            this.lbl_View_Student_List.Name = "lbl_View_Student_List";
            this.lbl_View_Student_List.Size = new System.Drawing.Size(306, 42);
            this.lbl_View_Student_List.TabIndex = 0;
            this.lbl_View_Student_List.Text = "View Student List";
            // 
            // lbl_Add_New_Student
            // 
            this.lbl_Add_New_Student.AutoSize = true;
            this.lbl_Add_New_Student.BackColor = System.Drawing.Color.Lime;
            this.lbl_Add_New_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Student.Location = new System.Drawing.Point(244, 390);
            this.lbl_Add_New_Student.Name = "lbl_Add_New_Student";
            this.lbl_Add_New_Student.Size = new System.Drawing.Size(239, 33);
            this.lbl_Add_New_Student.TabIndex = 1;
            this.lbl_Add_New_Student.Text = "Add New Student";
            this.lbl_Add_New_Student.Click += new System.EventHandler(this.lbl_Add_New_Student_Click);
            // 
            // dgv_table
            // 
            this.dgv_table.AutoGenerateColumns = false;
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_table.DataSource = this.studentDetailsBindingSource;
            this.dgv_table.Location = new System.Drawing.Point(106, 109);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.Size = new System.Drawing.Size(543, 253);
            this.dgv_table.TabIndex = 2;
            // 
            // student_Management_DBDataSet
            // 
            this.student_Management_DBDataSet.DataSetName = "Student_Management_DBDataSet";
            this.student_Management_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this.student_Management_DBDataSet;
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.Red;
            this.btn_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.Location = new System.Drawing.Point(669, 3);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(82, 40);
            this.btn_LogOut.TabIndex = 3;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // frm_View_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.dgv_table);
            this.Controls.Add(this.lbl_Add_New_Student);
            this.Controls.Add(this.lbl_View_Student_List);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_View_Student_List";
            this.Load += new System.EventHandler(this.frm_View_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Management_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Student_List;
        private System.Windows.Forms.Label lbl_Add_New_Student;
        private System.Windows.Forms.DataGridView dgv_table;
        private Student_Management_DBDataSet student_Management_DBDataSet;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private Student_Management_DBDataSetTableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_LogOut;
    }
}