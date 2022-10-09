namespace Student_Management_System
{
    partial class frm_Add_New_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_Student));
            this.lbl_Add_Student_Details = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_View_Student_Details = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Add_Student_Details
            // 
            this.lbl_Add_Student_Details.AutoSize = true;
            this.lbl_Add_Student_Details.BackColor = System.Drawing.Color.White;
            this.lbl_Add_Student_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Student_Details.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Add_Student_Details.Location = new System.Drawing.Point(173, 22);
            this.lbl_Add_Student_Details.Name = "lbl_Add_Student_Details";
            this.lbl_Add_Student_Details.Size = new System.Drawing.Size(348, 42);
            this.lbl_Add_Student_Details.TabIndex = 0;
            this.lbl_Add_Student_Details.Text = "Add Student Details";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.BackColor = System.Drawing.Color.White;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_Roll_No.Location = new System.Drawing.Point(108, 118);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(103, 31);
            this.lbl_Roll_No.TabIndex = 1;
            this.lbl_Roll_No.Text = "Roll No";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.White;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_Name.Location = new System.Drawing.Point(108, 184);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(86, 31);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.Color.White;
            this.lbl_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_DOB.Location = new System.Drawing.Point(108, 256);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(73, 31);
            this.lbl_DOB.TabIndex = 3;
            this.lbl_DOB.Text = "DOB";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.BackColor = System.Drawing.Color.White;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(108, 315);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(135, 31);
            this.lbl_Mobile_No.TabIndex = 4;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.BackColor = System.Drawing.Color.White;
            this.lbl_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_Course.Location = new System.Drawing.Point(108, 375);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(102, 31);
            this.lbl_Course.TabIndex = 5;
            this.lbl_Course.Text = "Course";
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(450, 116);
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(213, 31);
            this.tb_Roll_No.TabIndex = 1;
            this.tb_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(450, 182);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(213, 31);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(449, 313);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(214, 31);
            this.tb_Mobile_No.TabIndex = 4;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(450, 257);
            this.dtp_DOB.MaxDate = new System.DateTime(2002, 6, 15, 0, 0, 0, 0);
            this.dtp_DOB.MinDate = new System.DateTime(1996, 7, 15, 0, 0, 0, 0);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(214, 31);
            this.dtp_DOB.TabIndex = 3;
            this.dtp_DOB.Value = new System.DateTime(2002, 6, 15, 0, 0, 0, 0);
            // 
            // cmb_Course
            // 
            this.cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "BCS",
            "BCA",
            "BSC.CS",
            "B.COM IT",
            "MCS",
            "MCA"});
            this.cmb_Course.Location = new System.Drawing.Point(450, 373);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(214, 33);
            this.cmb_Course.TabIndex = 5;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Lime;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(180, 443);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(90, 45);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_View_Student_Details
            // 
            this.btn_View_Student_Details.BackColor = System.Drawing.Color.Lime;
            this.btn_View_Student_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Student_Details.Location = new System.Drawing.Point(404, 443);
            this.btn_View_Student_Details.Name = "btn_View_Student_Details";
            this.btn_View_Student_Details.Size = new System.Drawing.Size(255, 45);
            this.btn_View_Student_Details.TabIndex = 7;
            this.btn_View_Student_Details.Text = "View Student Details";
            this.btn_View_Student_Details.UseVisualStyleBackColor = false;
            this.btn_View_Student_Details.Click += new System.EventHandler(this.btn_View_Student_Details_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.Location = new System.Drawing.Point(654, 0);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(75, 41);
            this.btn_Log_Out.TabIndex = 8;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // frm_Add_New_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(729, 500);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_View_Student_Details);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Mobile_No);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.lbl_Add_Student_Details);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_New_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Add_New_Student";
            this.Load += new System.EventHandler(this.frm_Add_New_Student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_Student_Details;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_View_Student_Details;
        private System.Windows.Forms.Button btn_Log_Out;
    }
}