namespace IOOP_Assignment__Worker_
{
    partial class AdminPage
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
            this.button1 = new System.Windows.Forms.Button();
            this.UpdateUserProfile_btn = new System.Windows.Forms.Button();
            this.ViewAllReports_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdminLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(54, 402);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 152);
            this.button1.TabIndex = 0;
            this.button1.Text = "Register New User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateUserProfile_btn
            // 
            this.UpdateUserProfile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateUserProfile_btn.Location = new System.Drawing.Point(432, 402);
            this.UpdateUserProfile_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateUserProfile_btn.Name = "UpdateUserProfile_btn";
            this.UpdateUserProfile_btn.Size = new System.Drawing.Size(312, 152);
            this.UpdateUserProfile_btn.TabIndex = 1;
            this.UpdateUserProfile_btn.Text = "Update User Profile";
            this.UpdateUserProfile_btn.UseVisualStyleBackColor = true;
            this.UpdateUserProfile_btn.Click += new System.EventHandler(this.UpdateUserProfile_btn_Click);
            // 
            // ViewAllReports_btn
            // 
            this.ViewAllReports_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllReports_btn.Location = new System.Drawing.Point(812, 402);
            this.ViewAllReports_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewAllReports_btn.Name = "ViewAllReports_btn";
            this.ViewAllReports_btn.Size = new System.Drawing.Size(312, 152);
            this.ViewAllReports_btn.TabIndex = 2;
            this.ViewAllReports_btn.Text = "View All Reports";
            this.ViewAllReports_btn.UseVisualStyleBackColor = true;
            this.ViewAllReports_btn.Click += new System.EventHandler(this.ViewAllReports_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(940, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome Admin! Please Select A Button Below";
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogout.Location = new System.Drawing.Point(488, 606);
            this.btnAdminLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(192, 68);
            this.btnAdminLogout.TabIndex = 11;
            this.btnAdminLogout.Text = "Log out";
            this.btnAdminLogout.UseVisualStyleBackColor = true;
            this.btnAdminLogout.Click += new System.EventHandler(this.btnAdminLogout_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnAdminLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewAllReports_btn);
            this.Controls.Add(this.UpdateUserProfile_btn);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button UpdateUserProfile_btn;
        private System.Windows.Forms.Button ViewAllReports_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdminLogout;
    }
}

