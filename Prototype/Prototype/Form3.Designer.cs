namespace Prototype
{
    partial class userPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userPage));
            this.Logout = new System.Windows.Forms.LinkLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Scan = new System.Windows.Forms.TabPage();
            this.Reports = new System.Windows.Forms.TabPage();
            this.Managesoftware = new System.Windows.Forms.TabPage();
            this.Manageuser = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.exUserBtn = new System.Windows.Forms.Button();
            this.newUserBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.activeChk = new System.Windows.Forms.CheckBox();
            this.adminChk = new System.Windows.Forms.CheckBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.userList = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Realname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsAdmin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsActive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Details = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newBtn = new System.Windows.Forms.Button();
            this.exBtn = new System.Windows.Forms.Button();
            this.mngBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.activeCheck = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.Managesoftware.SuspendLayout();
            this.Manageuser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.LinkColor = System.Drawing.SystemColors.ControlText;
            this.Logout.Location = new System.Drawing.Point(700, 17);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(68, 24);
            this.Logout.TabIndex = 0;
            this.Logout.TabStop = true;
            this.Logout.Text = "Logout";
            this.Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout_LinkClicked);
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.Controls.Add(this.Scan);
            this.tabControl.Controls.Add(this.Reports);
            this.tabControl.Controls.Add(this.Managesoftware);
            this.tabControl.Controls.Add(this.Manageuser);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(100, 28);
            this.tabControl.Location = new System.Drawing.Point(28, 47);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(740, 391);
            this.tabControl.TabIndex = 1;
            // 
            // Scan
            // 
            this.Scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scan.Location = new System.Drawing.Point(4, 32);
            this.Scan.Name = "Scan";
            this.Scan.Padding = new System.Windows.Forms.Padding(3);
            this.Scan.Size = new System.Drawing.Size(732, 355);
            this.Scan.TabIndex = 0;
            this.Scan.Text = "Scan";
            this.Scan.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            this.Reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reports.Location = new System.Drawing.Point(4, 32);
            this.Reports.Name = "Reports";
            this.Reports.Padding = new System.Windows.Forms.Padding(3);
            this.Reports.Size = new System.Drawing.Size(732, 355);
            this.Reports.TabIndex = 1;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = true;
            // 
            // Managesoftware
            // 
            this.Managesoftware.Controls.Add(this.panel1);
            this.Managesoftware.Controls.Add(this.mngBtn);
            this.Managesoftware.Controls.Add(this.exBtn);
            this.Managesoftware.Controls.Add(this.newBtn);
            this.Managesoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Managesoftware.Location = new System.Drawing.Point(4, 32);
            this.Managesoftware.Name = "Managesoftware";
            this.Managesoftware.Size = new System.Drawing.Size(732, 355);
            this.Managesoftware.TabIndex = 2;
            this.Managesoftware.Text = "Manage Software";
            this.Managesoftware.UseVisualStyleBackColor = true;
            // 
            // Manageuser
            // 
            this.Manageuser.Controls.Add(this.splitContainer1);
            this.Manageuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manageuser.Location = new System.Drawing.Point(4, 32);
            this.Manageuser.Name = "Manageuser";
            this.Manageuser.Size = new System.Drawing.Size(732, 355);
            this.Manageuser.TabIndex = 3;
            this.Manageuser.Text = "Manage User";
            this.Manageuser.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.exUserBtn);
            this.splitContainer1.Panel1.Controls.Add(this.newUserBtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cancelBtn);
            this.splitContainer1.Panel2.Controls.Add(this.saveBtn);
            this.splitContainer1.Panel2.Controls.Add(this.activeChk);
            this.splitContainer1.Panel2.Controls.Add(this.adminChk);
            this.splitContainer1.Panel2.Controls.Add(this.passwordLabel);
            this.splitContainer1.Panel2.Controls.Add(this.usernameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.passwordText);
            this.splitContainer1.Panel2.Controls.Add(this.usernameText);
            this.splitContainer1.Panel2.Controls.Add(this.nameText);
            this.splitContainer1.Panel2.Controls.Add(this.nameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.userList);
            this.splitContainer1.Size = new System.Drawing.Size(732, 355);
            this.splitContainer1.SplitterDistance = 244;
            this.splitContainer1.TabIndex = 0;
            // 
            // exUserBtn
            // 
            this.exUserBtn.Location = new System.Drawing.Point(32, 91);
            this.exUserBtn.Name = "exUserBtn";
            this.exUserBtn.Size = new System.Drawing.Size(180, 40);
            this.exUserBtn.TabIndex = 1;
            this.exUserBtn.Text = "Existing Users";
            this.exUserBtn.UseVisualStyleBackColor = true;
            this.exUserBtn.Click += new System.EventHandler(this.exUserBtn_Click);
            // 
            // newUserBtn
            // 
            this.newUserBtn.Location = new System.Drawing.Point(32, 38);
            this.newUserBtn.Name = "newUserBtn";
            this.newUserBtn.Size = new System.Drawing.Size(180, 40);
            this.newUserBtn.TabIndex = 0;
            this.newUserBtn.Text = "New user";
            this.newUserBtn.UseVisualStyleBackColor = true;
            this.newUserBtn.Click += new System.EventHandler(this.newUserBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(262, 260);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(121, 40);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(91, 260);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(121, 40);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // activeChk
            // 
            this.activeChk.AutoSize = true;
            this.activeChk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.activeChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeChk.Location = new System.Drawing.Point(66, 200);
            this.activeChk.Name = "activeChk";
            this.activeChk.Size = new System.Drawing.Size(98, 28);
            this.activeChk.TabIndex = 4;
            this.activeChk.Text = "Is Active";
            this.activeChk.UseVisualStyleBackColor = true;
            // 
            // adminChk
            // 
            this.adminChk.AutoSize = true;
            this.adminChk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.adminChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminChk.Location = new System.Drawing.Point(62, 162);
            this.adminChk.Name = "adminChk";
            this.adminChk.Size = new System.Drawing.Size(102, 28);
            this.adminChk.TabIndex = 3;
            this.adminChk.Text = "Is Admin";
            this.adminChk.UseVisualStyleBackColor = true;
            this.adminChk.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(47, 119);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(92, 24);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(39, 79);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(100, 24);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "UserName";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(148, 117);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(199, 26);
            this.passwordText.TabIndex = 2;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(148, 77);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(199, 26);
            this.usernameText.TabIndex = 1;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(148, 36);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(199, 26);
            this.nameText.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(78, 38);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 24);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // userList
            // 
            this.userList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Realname,
            this.Username,
            this.IsAdmin,
            this.IsActive,
            this.Details});
            this.userList.FullRowSelect = true;
            this.userList.GridLines = true;
            this.userList.HideSelection = false;
            this.userList.Location = new System.Drawing.Point(4, 4);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(477, 348);
            this.userList.TabIndex = 0;
            this.userList.UseCompatibleStateImageBehavior = false;
            this.userList.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Realname
            // 
            this.Realname.Text = "Name";
            this.Realname.Width = 80;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 100;
            // 
            // IsAdmin
            // 
            this.IsAdmin.Text = "IsAdmin";
            this.IsAdmin.Width = 80;
            // 
            // IsActive
            // 
            this.IsActive.Text = "IsActive";
            this.IsActive.Width = 80;
            // 
            // Details
            // 
            this.Details.Text = "Details";
            this.Details.Width = 80;
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(30, 46);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(186, 34);
            this.newBtn.TabIndex = 0;
            this.newBtn.Text = "New Software";
            this.newBtn.UseVisualStyleBackColor = true;
            // 
            // exBtn
            // 
            this.exBtn.Location = new System.Drawing.Point(30, 86);
            this.exBtn.Name = "exBtn";
            this.exBtn.Size = new System.Drawing.Size(186, 34);
            this.exBtn.TabIndex = 0;
            this.exBtn.Text = "Existing Softwares";
            this.exBtn.UseVisualStyleBackColor = true;
            // 
            // mngBtn
            // 
            this.mngBtn.Location = new System.Drawing.Point(30, 126);
            this.mngBtn.Name = "mngBtn";
            this.mngBtn.Size = new System.Drawing.Size(186, 34);
            this.mngBtn.TabIndex = 0;
            this.mngBtn.Text = "Manage Categories";
            this.mngBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.activeCheck);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(239, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 332);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 26);
            this.textBox1.TabIndex = 1;
            // 
            // activeCheck
            // 
            this.activeCheck.AutoSize = true;
            this.activeCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.activeCheck.Location = new System.Drawing.Point(74, 62);
            this.activeCheck.Name = "activeCheck";
            this.activeCheck.Size = new System.Drawing.Size(88, 24);
            this.activeCheck.TabIndex = 2;
            this.activeCheck.Text = "Is Active";
            this.activeCheck.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(101, 95);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(106, 33);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(264, 95);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 33);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // userPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.Logout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "userPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersPage";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.userPage_FormClosed);
            this.tabControl.ResumeLayout(false);
            this.Managesoftware.ResumeLayout(false);
            this.Manageuser.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Logout;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Scan;
        private System.Windows.Forms.TabPage Reports;
        private System.Windows.Forms.TabPage Managesoftware;
        private System.Windows.Forms.TabPage Manageuser;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button exUserBtn;
        private System.Windows.Forms.Button newUserBtn;
        private System.Windows.Forms.ListView userList;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Realname;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader IsAdmin;
        private System.Windows.Forms.ColumnHeader IsActive;
        private System.Windows.Forms.ColumnHeader Details;
        private System.Windows.Forms.CheckBox activeChk;
        private System.Windows.Forms.CheckBox adminChk;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mngBtn;
        private System.Windows.Forms.Button exBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox activeCheck;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}