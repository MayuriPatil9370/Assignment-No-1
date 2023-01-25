namespace My_Controls
{
    partial class frm_My_Controls
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
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Selection_Controls_Use = new System.Windows.Forms.Label();
            this.gb_Student_Basics = new System.Windows.Forms.GroupBox();
            this.gb_Batch_Time = new System.Windows.Forms.GroupBox();
            this.rb_Evening = new System.Windows.Forms.RadioButton();
            this.rb_Afternoon = new System.Windows.Forms.RadioButton();
            this.rb_Morning = new System.Windows.Forms.RadioButton();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.tb_Student_Name = new System.Windows.Forms.TextBox();
            this.lbl_Error3 = new System.Windows.Forms.Label();
            this.lbl_Batch_Time = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Error2 = new System.Windows.Forms.Label();
            this.lbl_Error1 = new System.Windows.Forms.Label();
            this.lbl_Student_Name = new System.Windows.Forms.Label();
            this.gb_Technical = new System.Windows.Forms.GroupBox();
            this.gb_Education = new System.Windows.Forms.GroupBox();
            this.cb_Java = new System.Windows.Forms.CheckBox();
            this.cb_CPP = new System.Windows.Forms.CheckBox();
            this.cb_CSharp = new System.Windows.Forms.CheckBox();
            this.cb_C = new System.Windows.Forms.CheckBox();
            this.lbl_Choice = new System.Windows.Forms.Label();
            this.lbl_Programming = new System.Windows.Forms.Label();
            this.tb_Output1 = new System.Windows.Forms.TextBox();
            this.tb_Output2 = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.clb_Choices = new System.Windows.Forms.CheckedListBox();
            this.pnl_Top.SuspendLayout();
            this.gb_Student_Basics.SuspendLayout();
            this.gb_Batch_Time.SuspendLayout();
            this.gb_Gender.SuspendLayout();
            this.gb_Technical.SuspendLayout();
            this.gb_Education.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.Crimson;
            this.pnl_Top.Controls.Add(this.btn_Logout);
            this.pnl_Top.Controls.Add(this.lbl_Username);
            this.pnl_Top.Controls.Add(this.lbl_Selection_Controls_Use);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(1184, 73);
            this.pnl_Top.TabIndex = 0;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Logout.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Red;
            this.btn_Logout.Location = new System.Drawing.Point(1022, 14);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(141, 47);
            this.btn_Logout.TabIndex = 6;
            this.btn_Logout.Text = "Log Out";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_Username.Location = new System.Drawing.Point(32, 19);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(176, 42);
            this.lbl_Username.TabIndex = 4;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Selection_Controls_Use
            // 
            this.lbl_Selection_Controls_Use.AutoSize = true;
            this.lbl_Selection_Controls_Use.Font = new System.Drawing.Font("Book Antiqua", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Selection_Controls_Use.ForeColor = System.Drawing.Color.White;
            this.lbl_Selection_Controls_Use.Location = new System.Drawing.Point(366, 19);
            this.lbl_Selection_Controls_Use.Name = "lbl_Selection_Controls_Use";
            this.lbl_Selection_Controls_Use.Size = new System.Drawing.Size(405, 44);
            this.lbl_Selection_Controls_Use.TabIndex = 1;
            this.lbl_Selection_Controls_Use.Text = "Selection Controls Use";
            // 
            // gb_Student_Basics
            // 
            this.gb_Student_Basics.BackColor = System.Drawing.Color.White;
            this.gb_Student_Basics.Controls.Add(this.gb_Batch_Time);
            this.gb_Student_Basics.Controls.Add(this.gb_Gender);
            this.gb_Student_Basics.Controls.Add(this.tb_Student_Name);
            this.gb_Student_Basics.Controls.Add(this.lbl_Error3);
            this.gb_Student_Basics.Controls.Add(this.lbl_Batch_Time);
            this.gb_Student_Basics.Controls.Add(this.lbl_Gender);
            this.gb_Student_Basics.Controls.Add(this.lbl_Error2);
            this.gb_Student_Basics.Controls.Add(this.lbl_Error1);
            this.gb_Student_Basics.Controls.Add(this.lbl_Student_Name);
            this.gb_Student_Basics.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Student_Basics.Location = new System.Drawing.Point(8, 131);
            this.gb_Student_Basics.Name = "gb_Student_Basics";
            this.gb_Student_Basics.Size = new System.Drawing.Size(568, 355);
            this.gb_Student_Basics.TabIndex = 1;
            this.gb_Student_Basics.TabStop = false;
            this.gb_Student_Basics.Text = "Student Basics";
            // 
            // gb_Batch_Time
            // 
            this.gb_Batch_Time.BackColor = System.Drawing.Color.Moccasin;
            this.gb_Batch_Time.Controls.Add(this.rb_Evening);
            this.gb_Batch_Time.Controls.Add(this.rb_Afternoon);
            this.gb_Batch_Time.Controls.Add(this.rb_Morning);
            this.gb_Batch_Time.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Batch_Time.ForeColor = System.Drawing.Color.Maroon;
            this.gb_Batch_Time.Location = new System.Drawing.Point(176, 234);
            this.gb_Batch_Time.Name = "gb_Batch_Time";
            this.gb_Batch_Time.Size = new System.Drawing.Size(354, 84);
            this.gb_Batch_Time.TabIndex = 10;
            this.gb_Batch_Time.TabStop = false;
            this.gb_Batch_Time.Text = "Batch Time";
            // 
            // rb_Evening
            // 
            this.rb_Evening.AutoSize = true;
            this.rb_Evening.ForeColor = System.Drawing.Color.Red;
            this.rb_Evening.Location = new System.Drawing.Point(235, 43);
            this.rb_Evening.Name = "rb_Evening";
            this.rb_Evening.Size = new System.Drawing.Size(87, 25);
            this.rb_Evening.TabIndex = 6;
            this.rb_Evening.TabStop = true;
            this.rb_Evening.Text = "Evening";
            this.rb_Evening.UseVisualStyleBackColor = true;
            // 
            // rb_Afternoon
            // 
            this.rb_Afternoon.AutoSize = true;
            this.rb_Afternoon.ForeColor = System.Drawing.Color.Red;
            this.rb_Afternoon.Location = new System.Drawing.Point(115, 43);
            this.rb_Afternoon.Name = "rb_Afternoon";
            this.rb_Afternoon.Size = new System.Drawing.Size(104, 25);
            this.rb_Afternoon.TabIndex = 5;
            this.rb_Afternoon.TabStop = true;
            this.rb_Afternoon.Text = "Afternoon";
            this.rb_Afternoon.UseVisualStyleBackColor = true;
            // 
            // rb_Morning
            // 
            this.rb_Morning.AutoSize = true;
            this.rb_Morning.ForeColor = System.Drawing.Color.Red;
            this.rb_Morning.Location = new System.Drawing.Point(20, 43);
            this.rb_Morning.Name = "rb_Morning";
            this.rb_Morning.Size = new System.Drawing.Size(91, 25);
            this.rb_Morning.TabIndex = 4;
            this.rb_Morning.TabStop = true;
            this.rb_Morning.Text = "Morning";
            this.rb_Morning.UseVisualStyleBackColor = true;
            // 
            // gb_Gender
            // 
            this.gb_Gender.BackColor = System.Drawing.Color.Moccasin;
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Gender.ForeColor = System.Drawing.Color.Maroon;
            this.gb_Gender.Location = new System.Drawing.Point(176, 123);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(354, 66);
            this.gb_Gender.TabIndex = 9;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.ForeColor = System.Drawing.Color.Red;
            this.rb_Male.Location = new System.Drawing.Point(235, 28);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(64, 25);
            this.rb_Male.TabIndex = 3;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.ForeColor = System.Drawing.Color.Red;
            this.rb_Female.Location = new System.Drawing.Point(79, 28);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(81, 25);
            this.rb_Female.TabIndex = 2;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // tb_Student_Name
            // 
            this.tb_Student_Name.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Student_Name.Location = new System.Drawing.Point(176, 43);
            this.tb_Student_Name.Name = "tb_Student_Name";
            this.tb_Student_Name.Size = new System.Drawing.Size(354, 32);
            this.tb_Student_Name.TabIndex = 1;
            // 
            // lbl_Error3
            // 
            this.lbl_Error3.AutoSize = true;
            this.lbl_Error3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error3.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error3.Location = new System.Drawing.Point(390, 321);
            this.lbl_Error3.Name = "lbl_Error3";
            this.lbl_Error3.Size = new System.Drawing.Size(49, 21);
            this.lbl_Error3.TabIndex = 5;
            this.lbl_Error3.Text = "Error";
            // 
            // lbl_Batch_Time
            // 
            this.lbl_Batch_Time.AutoSize = true;
            this.lbl_Batch_Time.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Batch_Time.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Batch_Time.Location = new System.Drawing.Point(6, 234);
            this.lbl_Batch_Time.Name = "lbl_Batch_Time";
            this.lbl_Batch_Time.Size = new System.Drawing.Size(139, 31);
            this.lbl_Batch_Time.TabIndex = 6;
            this.lbl_Batch_Time.Text = "Batch Time";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Gender.Location = new System.Drawing.Point(6, 123);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(94, 31);
            this.lbl_Gender.TabIndex = 5;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Error2
            // 
            this.lbl_Error2.AutoSize = true;
            this.lbl_Error2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error2.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error2.Location = new System.Drawing.Point(390, 192);
            this.lbl_Error2.Name = "lbl_Error2";
            this.lbl_Error2.Size = new System.Drawing.Size(49, 21);
            this.lbl_Error2.TabIndex = 5;
            this.lbl_Error2.Text = "Error";
            // 
            // lbl_Error1
            // 
            this.lbl_Error1.AutoSize = true;
            this.lbl_Error1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error1.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error1.Location = new System.Drawing.Point(390, 78);
            this.lbl_Error1.Name = "lbl_Error1";
            this.lbl_Error1.Size = new System.Drawing.Size(49, 21);
            this.lbl_Error1.TabIndex = 5;
            this.lbl_Error1.Text = "Error";
            // 
            // lbl_Student_Name
            // 
            this.lbl_Student_Name.AutoSize = true;
            this.lbl_Student_Name.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Student_Name.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Student_Name.Location = new System.Drawing.Point(6, 46);
            this.lbl_Student_Name.Name = "lbl_Student_Name";
            this.lbl_Student_Name.Size = new System.Drawing.Size(169, 31);
            this.lbl_Student_Name.TabIndex = 4;
            this.lbl_Student_Name.Text = "Student Name";
            // 
            // gb_Technical
            // 
            this.gb_Technical.BackColor = System.Drawing.Color.White;
            this.gb_Technical.Controls.Add(this.clb_Choices);
            this.gb_Technical.Controls.Add(this.gb_Education);
            this.gb_Technical.Controls.Add(this.lbl_Choice);
            this.gb_Technical.Controls.Add(this.lbl_Programming);
            this.gb_Technical.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Technical.Location = new System.Drawing.Point(590, 131);
            this.gb_Technical.Name = "gb_Technical";
            this.gb_Technical.Size = new System.Drawing.Size(582, 355);
            this.gb_Technical.TabIndex = 2;
            this.gb_Technical.TabStop = false;
            this.gb_Technical.Text = "Technical";
            // 
            // gb_Education
            // 
            this.gb_Education.BackColor = System.Drawing.Color.Moccasin;
            this.gb_Education.Controls.Add(this.cb_Java);
            this.gb_Education.Controls.Add(this.cb_CPP);
            this.gb_Education.Controls.Add(this.cb_CSharp);
            this.gb_Education.Controls.Add(this.cb_C);
            this.gb_Education.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Education.ForeColor = System.Drawing.Color.Maroon;
            this.gb_Education.Location = new System.Drawing.Point(204, 46);
            this.gb_Education.Name = "gb_Education";
            this.gb_Education.Size = new System.Drawing.Size(353, 92);
            this.gb_Education.TabIndex = 8;
            this.gb_Education.TabStop = false;
            this.gb_Education.Text = "Education";
            // 
            // cb_Java
            // 
            this.cb_Java.AutoSize = true;
            this.cb_Java.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Java.ForeColor = System.Drawing.Color.Black;
            this.cb_Java.Location = new System.Drawing.Point(228, 62);
            this.cb_Java.Name = "cb_Java";
            this.cb_Java.Size = new System.Drawing.Size(61, 25);
            this.cb_Java.TabIndex = 0;
            this.cb_Java.Text = "Java";
            this.cb_Java.UseVisualStyleBackColor = true;
            // 
            // cb_CPP
            // 
            this.cb_CPP.AutoSize = true;
            this.cb_CPP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_CPP.ForeColor = System.Drawing.Color.Black;
            this.cb_CPP.Location = new System.Drawing.Point(228, 22);
            this.cb_CPP.Name = "cb_CPP";
            this.cb_CPP.Size = new System.Drawing.Size(64, 25);
            this.cb_CPP.TabIndex = 0;
            this.cb_CPP.Text = "C++";
            this.cb_CPP.UseVisualStyleBackColor = true;
            // 
            // cb_CSharp
            // 
            this.cb_CSharp.AutoSize = true;
            this.cb_CSharp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_CSharp.ForeColor = System.Drawing.Color.Black;
            this.cb_CSharp.Location = new System.Drawing.Point(64, 62);
            this.cb_CSharp.Name = "cb_CSharp";
            this.cb_CSharp.Size = new System.Drawing.Size(52, 25);
            this.cb_CSharp.TabIndex = 0;
            this.cb_CSharp.Text = "C#";
            this.cb_CSharp.UseVisualStyleBackColor = true;
            // 
            // cb_C
            // 
            this.cb_C.AutoSize = true;
            this.cb_C.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_C.ForeColor = System.Drawing.Color.Black;
            this.cb_C.Location = new System.Drawing.Point(64, 22);
            this.cb_C.Name = "cb_C";
            this.cb_C.Size = new System.Drawing.Size(42, 25);
            this.cb_C.TabIndex = 0;
            this.cb_C.Text = "C";
            this.cb_C.UseVisualStyleBackColor = true;
            // 
            // lbl_Choice
            // 
            this.lbl_Choice.AutoSize = true;
            this.lbl_Choice.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Choice.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Choice.Location = new System.Drawing.Point(23, 199);
            this.lbl_Choice.Name = "lbl_Choice";
            this.lbl_Choice.Size = new System.Drawing.Size(91, 31);
            this.lbl_Choice.TabIndex = 7;
            this.lbl_Choice.Text = "Choice";
            // 
            // lbl_Programming
            // 
            this.lbl_Programming.AutoSize = true;
            this.lbl_Programming.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Programming.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Programming.Location = new System.Drawing.Point(23, 61);
            this.lbl_Programming.Name = "lbl_Programming";
            this.lbl_Programming.Size = new System.Drawing.Size(158, 31);
            this.lbl_Programming.TabIndex = 6;
            this.lbl_Programming.Text = "Programming";
            // 
            // tb_Output1
            // 
            this.tb_Output1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Output1.Location = new System.Drawing.Point(8, 592);
            this.tb_Output1.Name = "tb_Output1";
            this.tb_Output1.Size = new System.Drawing.Size(568, 35);
            this.tb_Output1.TabIndex = 7;
            // 
            // tb_Output2
            // 
            this.tb_Output2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Output2.Location = new System.Drawing.Point(604, 592);
            this.tb_Output2.Name = "tb_Output2";
            this.tb_Output2.Size = new System.Drawing.Size(568, 35);
            this.tb_Output2.TabIndex = 7;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Submit.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Black;
            this.btn_Submit.Location = new System.Drawing.Point(184, 522);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(229, 51);
            this.btn_Submit.TabIndex = 7;
            this.btn_Submit.Text = "Show Output";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Show.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show.ForeColor = System.Drawing.Color.Black;
            this.btn_Show.Location = new System.Drawing.Point(745, 522);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(338, 51);
            this.btn_Show.TabIndex = 8;
            this.btn_Show.Text = "Show Technical Skills";
            this.btn_Show.UseVisualStyleBackColor = false;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // clb_Choices
            // 
            this.clb_Choices.FormattingEnabled = true;
            this.clb_Choices.Items.AddRange(new object[] {
            "Developer",
            "Designer",
            "Manager",
            "CEO",
            "DBA"});
            this.clb_Choices.Location = new System.Drawing.Point(204, 195);
            this.clb_Choices.Name = "clb_Choices";
            this.clb_Choices.Size = new System.Drawing.Size(292, 139);
            this.clb_Choices.TabIndex = 9;
            // 
            // frm_My_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tb_Output2);
            this.Controls.Add(this.tb_Output1);
            this.Controls.Add(this.gb_Technical);
            this.Controls.Add(this.gb_Student_Basics);
            this.Controls.Add(this.pnl_Top);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_My_Controls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Controls";
            this.Load += new System.EventHandler(this.frm_My_Controls_Load);
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.gb_Student_Basics.ResumeLayout(false);
            this.gb_Student_Basics.PerformLayout();
            this.gb_Batch_Time.ResumeLayout(false);
            this.gb_Batch_Time.PerformLayout();
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.gb_Technical.ResumeLayout(false);
            this.gb_Technical.PerformLayout();
            this.gb_Education.ResumeLayout(false);
            this.gb_Education.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Label lbl_Selection_Controls_Use;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.GroupBox gb_Student_Basics;
        private System.Windows.Forms.GroupBox gb_Technical;
        private System.Windows.Forms.Label lbl_Batch_Time;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Student_Name;
        private System.Windows.Forms.TextBox tb_Output1;
        private System.Windows.Forms.TextBox tb_Output2;
        private System.Windows.Forms.GroupBox gb_Batch_Time;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.TextBox tb_Student_Name;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Evening;
        private System.Windows.Forms.RadioButton rb_Afternoon;
        private System.Windows.Forms.RadioButton rb_Morning;
        private System.Windows.Forms.GroupBox gb_Education;
        private System.Windows.Forms.CheckBox cb_Java;
        private System.Windows.Forms.CheckBox cb_CPP;
        private System.Windows.Forms.CheckBox cb_CSharp;
        private System.Windows.Forms.CheckBox cb_C;
        private System.Windows.Forms.Label lbl_Choice;
        private System.Windows.Forms.Label lbl_Programming;
        private System.Windows.Forms.Label lbl_Error3;
        private System.Windows.Forms.Label lbl_Error2;
        private System.Windows.Forms.Label lbl_Error1;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.CheckedListBox clb_Choices;
    }
}