namespace SGM_Student_Mgt_System_04
{
    partial class frm_Add_Student_Details
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
            this.lbl_Add_New_Student = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.cmd_Course = new System.Windows.Forms.ComboBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Add_New_Student
            // 
            this.lbl_Add_New_Student.AutoSize = true;
            this.lbl_Add_New_Student.BackColor = System.Drawing.Color.Thistle;
            this.lbl_Add_New_Student.Font = new System.Drawing.Font("Book Antiqua", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Add_New_Student.Location = new System.Drawing.Point(194, 25);
            this.lbl_Add_New_Student.Name = "lbl_Add_New_Student";
            this.lbl_Add_New_Student.Size = new System.Drawing.Size(329, 44);
            this.lbl_Add_New_Student.TabIndex = 17;
            this.lbl_Add_New_Student.Text = "Add New Student";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.Red;
            this.lbl_Course.Location = new System.Drawing.Point(100, 344);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(95, 33);
            this.lbl_Course.TabIndex = 22;
            this.lbl_Course.Text = "Course";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Red;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(100, 282);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(140, 33);
            this.lbl_Mobile_No.TabIndex = 21;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.Red;
            this.lbl_DOB.Location = new System.Drawing.Point(100, 223);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(75, 33);
            this.lbl_DOB.TabIndex = 20;
            this.lbl_DOB.Text = "DOB";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Red;
            this.lbl_Name.Location = new System.Drawing.Point(100, 158);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(83, 33);
            this.lbl_Name.TabIndex = 19;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.Red;
            this.lbl_Roll_No.Location = new System.Drawing.Point(100, 94);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(106, 33);
            this.lbl_Roll_No.TabIndex = 18;
            this.lbl_Roll_No.Text = "Roll No";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(436, 158);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(232, 26);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // cmd_Course
            // 
            this.cmd_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmd_Course.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Course.FormattingEnabled = true;
            this.cmd_Course.Items.AddRange(new object[] {
            "BCS",
            "BCA",
            "BSC CS",
            "MCS",
            "MCA",
            "MSC CS"});
            this.cmd_Course.Location = new System.Drawing.Point(436, 344);
            this.cmd_Course.Name = "cmd_Course";
            this.cmd_Course.Size = new System.Drawing.Size(232, 27);
            this.cmd_Course.TabIndex = 5;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(436, 219);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(232, 26);
            this.dtp_DOB.TabIndex = 3;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(436, 278);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(232, 26);
            this.tb_Mobile_No.TabIndex = 4;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(436, 90);
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(232, 26);
            this.tb_Roll_No.TabIndex = 1;
            this.tb_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(347, 384);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(88, 54);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Add_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.cmd_Course);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Mobile_No);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.lbl_Add_New_Student);
            this.Name = "frm_Add_Student_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student Details";
            this.Load += new System.EventHandler(this.frm_Add_Student_Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_New_Student;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.ComboBox cmd_Course;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.Button btn_Save;
    }
}