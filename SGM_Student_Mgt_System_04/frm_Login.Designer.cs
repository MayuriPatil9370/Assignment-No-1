namespace SGM_Student_Mgt_System_04
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
            this.lbl_Login_Form = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Login_Form
            // 
            this.lbl_Login_Form.AutoSize = true;
            this.lbl_Login_Form.Font = new System.Drawing.Font("Book Antiqua", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_Form.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Login_Form.Location = new System.Drawing.Point(225, 33);
            this.lbl_Login_Form.Name = "lbl_Login_Form";
            this.lbl_Login_Form.Size = new System.Drawing.Size(281, 57);
            this.lbl_Login_Form.TabIndex = 1;
            this.lbl_Login_Form.Text = "Login Form";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Red;
            this.lbl_Password.Location = new System.Drawing.Point(98, 262);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(158, 42);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Red;
            this.lbl_Username.Location = new System.Drawing.Point(98, 147);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(167, 42);
            this.lbl_Username.TabIndex = 2;
            this.lbl_Username.Text = "Username";
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(407, 271);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(253, 35);
            this.tb_Password.TabIndex = 5;
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(407, 158);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(253, 35);
            this.tb_Username.TabIndex = 4;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Submit.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Red;
            this.btn_Submit.Location = new System.Drawing.Point(287, 429);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(131, 51);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Error.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.Location = new System.Drawing.Point(208, 371);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(298, 23);
            this.lbl_Error.TabIndex = 7;
            this.lbl_Error.Text = "Enter Valid Username && Password";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 503);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Login_Form);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGM LOGIN APP";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login_Form;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Error;
    }
}

