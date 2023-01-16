namespace SGM_Student_Mgt_System_04
{
    partial class frm_Add_New_Course
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
            this.lbl_Add_New_Course = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Course_Name = new System.Windows.Forms.TextBox();
            this.tb_Course_ID = new System.Windows.Forms.TextBox();
            this.lbl_Course_Name = new System.Windows.Forms.Label();
            this.lbl_Course_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Add_New_Course
            // 
            this.lbl_Add_New_Course.AutoSize = true;
            this.lbl_Add_New_Course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_Add_New_Course.Font = new System.Drawing.Font("Book Antiqua", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Add_New_Course.Location = new System.Drawing.Point(179, 22);
            this.lbl_Add_New_Course.Name = "lbl_Add_New_Course";
            this.lbl_Add_New_Course.Size = new System.Drawing.Size(403, 57);
            this.lbl_Add_New_Course.TabIndex = 25;
            this.lbl_Add_New_Course.Text = "Add New Course";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Lime;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Red;
            this.btn_Save.Location = new System.Drawing.Point(302, 365);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(101, 54);
            this.btn_Save.TabIndex = 29;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Course_Name
            // 
            this.tb_Course_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_Name.Location = new System.Drawing.Point(416, 238);
            this.tb_Course_Name.Name = "tb_Course_Name";
            this.tb_Course_Name.Size = new System.Drawing.Size(242, 31);
            this.tb_Course_Name.TabIndex = 36;
            // 
            // tb_Course_ID
            // 
            this.tb_Course_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_ID.Location = new System.Drawing.Point(416, 113);
            this.tb_Course_ID.Name = "tb_Course_ID";
            this.tb_Course_ID.Size = new System.Drawing.Size(242, 31);
            this.tb_Course_ID.TabIndex = 35;
            // 
            // lbl_Course_Name
            // 
            this.lbl_Course_Name.AutoSize = true;
            this.lbl_Course_Name.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_Name.ForeColor = System.Drawing.Color.Red;
            this.lbl_Course_Name.Location = new System.Drawing.Point(83, 238);
            this.lbl_Course_Name.Name = "lbl_Course_Name";
            this.lbl_Course_Name.Size = new System.Drawing.Size(208, 40);
            this.lbl_Course_Name.TabIndex = 38;
            this.lbl_Course_Name.Text = "Course Name";
            // 
            // lbl_Course_ID
            // 
            this.lbl_Course_ID.AutoSize = true;
            this.lbl_Course_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_Course_ID.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_ID.ForeColor = System.Drawing.Color.Red;
            this.lbl_Course_ID.Location = new System.Drawing.Point(83, 113);
            this.lbl_Course_ID.Name = "lbl_Course_ID";
            this.lbl_Course_ID.Size = new System.Drawing.Size(161, 40);
            this.lbl_Course_ID.TabIndex = 37;
            this.lbl_Course_ID.Text = "Course ID";
            // 
            // frm_Add_New_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Course_Name);
            this.Controls.Add(this.lbl_Course_ID);
            this.Controls.Add(this.tb_Course_Name);
            this.Controls.Add(this.tb_Course_ID);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_Add_New_Course);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_New_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Course";
            this.Load += new System.EventHandler(this.frm_Add_New_Course_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_New_Course;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Course_Name;
        private System.Windows.Forms.TextBox tb_Course_ID;
        private System.Windows.Forms.Label lbl_Course_Name;
        private System.Windows.Forms.Label lbl_Course_ID;
    }
}