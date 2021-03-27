namespace Prototype
{
    partial class dashboardPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardPage));
            this.logoutLink = new System.Windows.Forms.LinkLabel();
            this.Scan = new System.Windows.Forms.Button();
            this.Reports = new System.Windows.Forms.Button();
            this.Manageuser = new System.Windows.Forms.Button();
            this.Managesoftware = new System.Windows.Forms.Button();
            this.welcomeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logoutLink
            // 
            this.logoutLink.AutoSize = true;
            this.logoutLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLink.LinkColor = System.Drawing.SystemColors.ControlText;
            this.logoutLink.Location = new System.Drawing.Point(494, 47);
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.Size = new System.Drawing.Size(68, 24);
            this.logoutLink.TabIndex = 0;
            this.logoutLink.TabStop = true;
            this.logoutLink.Text = "Logout";
            this.logoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout_LinkClicked);
            // 
            // Scan
            // 
            this.Scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scan.Location = new System.Drawing.Point(76, 120);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(164, 67);
            this.Scan.TabIndex = 1;
            this.Scan.Text = "Scan";
            this.Scan.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            this.Reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reports.Location = new System.Drawing.Point(329, 120);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(164, 67);
            this.Reports.TabIndex = 1;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = true;
            // 
            // Manageuser
            // 
            this.Manageuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manageuser.Location = new System.Drawing.Point(329, 269);
            this.Manageuser.Name = "Manageuser";
            this.Manageuser.Size = new System.Drawing.Size(164, 67);
            this.Manageuser.TabIndex = 1;
            this.Manageuser.Text = "Manage User";
            this.Manageuser.UseVisualStyleBackColor = true;
            this.Manageuser.Click += new System.EventHandler(this.Manageuser_Click);
            // 
            // Managesoftware
            // 
            this.Managesoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Managesoftware.Location = new System.Drawing.Point(76, 269);
            this.Managesoftware.Name = "Managesoftware";
            this.Managesoftware.Size = new System.Drawing.Size(164, 67);
            this.Managesoftware.TabIndex = 1;
            this.Managesoftware.Text = "Manage Software";
            this.Managesoftware.UseVisualStyleBackColor = true;
            this.Managesoftware.Click += new System.EventHandler(this.Managesoftware_Click);
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText.Location = new System.Drawing.Point(48, 24);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(115, 29);
            this.welcomeText.TabIndex = 2;
            this.welcomeText.Text = "Welcome";
            // 
            // dashboardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 414);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.Managesoftware);
            this.Controls.Add(this.Manageuser);
            this.Controls.Add(this.Reports);
            this.Controls.Add(this.Scan);
            this.Controls.Add(this.logoutLink);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "dashboardPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.dashboardPage_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel logoutLink;
        private System.Windows.Forms.Button Scan;
        private System.Windows.Forms.Button Reports;
        private System.Windows.Forms.Button Manageuser;
        private System.Windows.Forms.Button Managesoftware;
        private System.Windows.Forms.Label welcomeText;
    }
}