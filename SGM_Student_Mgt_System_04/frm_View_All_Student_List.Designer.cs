namespace SGM_Student_Mgt_System_04
{
    partial class frm_View_All_Student_List
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
            this.lbl_View_Student_List = new System.Windows.Forms.Label();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_View_Student_Details = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sGM_04_DBDataSet = new SGM_Student_Mgt_System_04.SGM_04_DBDataSet();
            this.student_DetailsTableAdapter = new SGM_Student_Mgt_System_04.SGM_04_DBDataSetTableAdapters.Student_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_04_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Student_List
            // 
            this.lbl_View_Student_List.AutoSize = true;
            this.lbl_View_Student_List.BackColor = System.Drawing.Color.Thistle;
            this.lbl_View_Student_List.Font = new System.Drawing.Font("Book Antiqua", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Student_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_View_Student_List.Location = new System.Drawing.Point(228, 33);
            this.lbl_View_Student_List.Name = "lbl_View_Student_List";
            this.lbl_View_Student_List.Size = new System.Drawing.Size(327, 44);
            this.lbl_View_Student_List.TabIndex = 24;
            this.lbl_View_Student_List.Text = "View Student List";
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            // 
            // dgv_View_Student_Details
            // 
            this.dgv_View_Student_Details.AllowUserToOrderColumns = true;
            this.dgv_View_Student_Details.AutoGenerateColumns = false;
            this.dgv_View_Student_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Student_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Student_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_View_Student_Details.DataSource = this.studentDetailsBindingSource1;
            this.dgv_View_Student_Details.Location = new System.Drawing.Point(77, 95);
            this.dgv_View_Student_Details.Name = "dgv_View_Student_Details";
            this.dgv_View_Student_Details.Size = new System.Drawing.Size(615, 342);
            this.dgv_View_Student_Details.TabIndex = 25;
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
            // studentDetailsBindingSource1
            // 
            this.studentDetailsBindingSource1.DataMember = "Student_Details";
            this.studentDetailsBindingSource1.DataSource = this.sGM_04_DBDataSet;
            // 
            // sGM_04_DBDataSet
            // 
            this.sGM_04_DBDataSet.DataSetName = "SGM_04_DBDataSet";
            this.sGM_04_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_All_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_View_Student_Details);
            this.Controls.Add(this.lbl_View_Student_List);
            this.Name = "frm_View_All_Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Student List";
            this.Load += new System.EventHandler(this.frm_View_All_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGM_04_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Student_List;
        
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private System.Windows.Forms.DataGridView dgv_View_Student_Details;
        private SGM_04_DBDataSet sGM_04_DBDataSet;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource1;
        private SGM_04_DBDataSetTableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        
    }
}