namespace Student_Management_System
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Userame = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.BackColor = System.Drawing.Color.White;
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Login.Location = new System.Drawing.Point(266, 66);
            this.lbl_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(206, 42);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "Login Form";
            // 
            // lbl_Userame
            // 
            this.lbl_Userame.AutoSize = true;
            this.lbl_Userame.BackColor = System.Drawing.Color.White;
            this.lbl_Userame.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Userame.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_Userame.Location = new System.Drawing.Point(108, 171);
            this.lbl_Userame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Userame.Name = "lbl_Userame";
            this.lbl_Userame.Size = new System.Drawing.Size(150, 33);
            this.lbl_Userame.TabIndex = 1;
            this.lbl_Userame.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.White;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Magenta;
            this.lbl_Password.Location = new System.Drawing.Point(108, 276);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(143, 33);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(237, 365);
            this.lbl_Error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(252, 24);
            this.lbl_Error.TabIndex = 3;
            this.lbl_Error.Text = "Enter Username && Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 544);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(438, 172);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(201, 35);
            this.tb_Username.TabIndex = 1;
            this.tb_Username.TextChanged += new System.EventHandler(this.tb_Username_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(780, 263);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(9, 22);
            this.textBox2.TabIndex = 6;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Red;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.Location = new System.Drawing.Point(643, 1);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(86, 38);
            this.btn_Logout.TabIndex = 4;
            this.btn_Logout.Text = "Log out";
            this.btn_Logout.UseVisualStyleBackColor = false;
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(438, 277);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(201, 35);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.TextChanged += new System.EventHandler(this.tb_Password_TextChanged);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Lime;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Black;
            this.btn_Submit.Location = new System.Drawing.Point(306, 429);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(118, 42);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(729, 500);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Userame);
            this.Controls.Add(this.lbl_Login);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_Userame;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Submit;
    }
}

