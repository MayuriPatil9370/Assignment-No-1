namespace SGM_Student_Mgt_System_04
{
    partial class MDI_SGM_Mgt_System_04
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.admissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchSingleStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllStudentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calCulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_Username = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admissionToolStripMenuItem,
            this.courseToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(864, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // admissionToolStripMenuItem
            // 
            this.admissionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.updateStudentToolStripMenuItem,
            this.searchSingleStudentToolStripMenuItem,
            this.viewAllStudentListToolStripMenuItem});
            this.admissionToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admissionToolStripMenuItem.Name = "admissionToolStripMenuItem";
            this.admissionToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.admissionToolStripMenuItem.Text = "Admission";
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addNewStudentToolStripMenuItem.Text = "Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.addNewStudentToolStripMenuItem_Click);
            // 
            // updateStudentToolStripMenuItem
            // 
            this.updateStudentToolStripMenuItem.Name = "updateStudentToolStripMenuItem";
            this.updateStudentToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.updateStudentToolStripMenuItem.Text = "Update Student";
            this.updateStudentToolStripMenuItem.Click += new System.EventHandler(this.updateStudentToolStripMenuItem_Click);
            // 
            // searchSingleStudentToolStripMenuItem
            // 
            this.searchSingleStudentToolStripMenuItem.Name = "searchSingleStudentToolStripMenuItem";
            this.searchSingleStudentToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.searchSingleStudentToolStripMenuItem.Text = "Search Single Student";
            this.searchSingleStudentToolStripMenuItem.Click += new System.EventHandler(this.searchSingleStudentToolStripMenuItem_Click);
            // 
            // viewAllStudentListToolStripMenuItem
            // 
            this.viewAllStudentListToolStripMenuItem.Name = "viewAllStudentListToolStripMenuItem";
            this.viewAllStudentListToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.viewAllStudentListToolStripMenuItem.Text = "View All Student List";
            this.viewAllStudentListToolStripMenuItem.Click += new System.EventHandler(this.viewAllStudentListToolStripMenuItem_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem});
            this.courseToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.courseToolStripMenuItem.Text = "Course";
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notepadToolStripMenuItem,
            this.calCulaToolStripMenuItem,
            this.addToolStripMenuItem,
            this.titanToolStripMenuItem});
            this.toolsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(54, 23);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.notepadToolStripMenuItem.Text = "Notepad";
            this.notepadToolStripMenuItem.Click += new System.EventHandler(this.notepadToolStripMenuItem_Click);
            // 
            // calCulaToolStripMenuItem
            // 
            this.calCulaToolStripMenuItem.Name = "calCulaToolStripMenuItem";
            this.calCulaToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.calCulaToolStripMenuItem.Text = "Calculator";
            this.calCulaToolStripMenuItem.Click += new System.EventHandler(this.calCulaToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // titanToolStripMenuItem
            // 
            this.titanToolStripMenuItem.Name = "titanToolStripMenuItem";
            this.titanToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.titanToolStripMenuItem.Text = "Titan";
            this.titanToolStripMenuItem.Click += new System.EventHandler(this.titanToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.updateUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.userManagementToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(132, 23);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.updateUserToolStripMenuItem.Text = "Update User";
            this.updateUserToolStripMenuItem.Click += new System.EventHandler(this.updateUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_Username.Location = new System.Drawing.Point(505, 0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(115, 26);
            this.lbl_Username.TabIndex = 3;
            this.lbl_Username.Text = "Username";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Red;
            this.btn_Logout.Location = new System.Drawing.Point(774, 2);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 27);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.Text = "Log Out";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // MDI_SGM_Mgt_System_04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 561);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MDI_SGM_Mgt_System_04";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI SGM Mgt System";
            this.Load += new System.EventHandler(this.MDI_SGM_Mgt_System_04_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem admissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calCulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchSingleStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllStudentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.Button btn_Logout;
    }
}



