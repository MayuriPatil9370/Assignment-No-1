namespace SGM_Student_Mgt_System_04
{
    partial class frm_Search_Student_Details
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
            this.lbl_Search_Student_Details = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Search_Student_Details
            // 
            this.lbl_Search_Student_Details.AutoSize = true;
            this.lbl_Search_Student_Details.BackColor = System.Drawing.Color.Thistle;
            this.lbl_Search_Student_Details.Font = new System.Drawing.Font("Book Antiqua", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Student_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Search_Student_Details.Location = new System.Drawing.Point(182, 32);
            this.lbl_Search_Student_Details.Name = "lbl_Search_Student_Details";
            this.lbl_Search_Student_Details.Size = new System.Drawing.Size(408, 44);
            this.lbl_Search_Student_Details.TabIndex = 22;
            this.lbl_Search_Student_Details.Text = "Search Student Details";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.Red;
            this.lbl_Course.Location = new System.Drawing.Point(137, 363);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(95, 33);
            this.lbl_Course.TabIndex = 27;
            this.lbl_Course.Text = "Course";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Red;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(137, 295);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(140, 33);
            this.lbl_Mobile_No.TabIndex = 26;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.Red;
            this.lbl_DOB.Location = new System.Drawing.Point(137, 236);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(75, 33);
            this.lbl_DOB.TabIndex = 25;
            this.lbl_DOB.Text = "DOB";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Red;
            this.lbl_Name.Location = new System.Drawing.Point(137, 171);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(83, 33);
            this.lbl_Name.TabIndex = 24;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.BackColor = System.Drawing.Color.Thistle;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.Red;
            this.lbl_Roll_No.Location = new System.Drawing.Point(137, 107);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(106, 33);
            this.lbl_Roll_No.TabIndex = 23;
            this.lbl_Roll_No.Text = "Roll No";
            // 
            // cmb_Course
            // 
            this.cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Course.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "BCS",
            "BCA",
            "BSC CS",
            "MCS",
            "MAC",
            "MSC CS"});
            this.cmb_Course.Location = new System.Drawing.Point(399, 363);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(216, 27);
            this.cmb_Course.TabIndex = 32;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(399, 242);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(216, 26);
            this.dtp_DOB.TabIndex = 30;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(399, 301);
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(216, 26);
            this.tb_Mobile_No.TabIndex = 31;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(399, 183);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(216, 26);
            this.tb_Name.TabIndex = 29;
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(399, 113);
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(216, 26);
            this.tb_Roll_No.TabIndex = 28;
            this.tb_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.White;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn_Refresh.Location = new System.Drawing.Point(309, 405);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(115, 44);
            this.btn_Refresh.TabIndex = 33;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Search.Location = new System.Drawing.Point(621, 111);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(80, 29);
            this.btn_Search.TabIndex = 34;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_Search_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Refresh);
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
            this.Controls.Add(this.lbl_Search_Student_Details);
            this.Name = "frm_Search_Student_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Student Details";
            this.Load += new System.EventHandler(this.frm_Search_Student_Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Search_Student_Details;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search;
    }
}