namespace IOOP_Assignment__Worker_
{
    partial class UpdateUserProfile
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
            this.label5 = new System.Windows.Forms.Label();
            this.UUPBack_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Role_cmb = new System.Windows.Forms.ComboBox();
            this.role_lbl = new System.Windows.Forms.Label();
            this.Password_txtb = new System.Windows.Forms.TextBox();
            this.LoginName_txtb = new System.Windows.Forms.TextBox();
            this.PhoneNumber_txtb = new System.Windows.Forms.TextBox();
            this.FullName_txtb = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.loginname_lbl = new System.Windows.Forms.Label();
            this.phonenumber_lbl = new System.Windows.Forms.Label();
            this.fullname_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UUPFindUsername_cmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Update User Profile";
            // 
            // UUPBack_btn
            // 
            this.UUPBack_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UUPBack_btn.Location = new System.Drawing.Point(223, 384);
            this.UUPBack_btn.Name = "UUPBack_btn";
            this.UUPBack_btn.Size = new System.Drawing.Size(128, 44);
            this.UUPBack_btn.TabIndex = 24;
            this.UUPBack_btn.Text = "Back";
            this.UUPBack_btn.UseVisualStyleBackColor = true;
            this.UUPBack_btn.Click += new System.EventHandler(this.UUPBack_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(405, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 44);
            this.button1.TabIndex = 25;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Role_cmb
            // 
            this.Role_cmb.FormattingEnabled = true;
            this.Role_cmb.Items.AddRange(new object[] {
            "Admin",
            "Customer",
            "Manager",
            "Worker"});
            this.Role_cmb.Location = new System.Drawing.Point(302, 326);
            this.Role_cmb.Name = "Role_cmb";
            this.Role_cmb.Size = new System.Drawing.Size(353, 21);
            this.Role_cmb.TabIndex = 35;
            // 
            // role_lbl
            // 
            this.role_lbl.AutoSize = true;
            this.role_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_lbl.Location = new System.Drawing.Point(102, 326);
            this.role_lbl.Name = "role_lbl";
            this.role_lbl.Size = new System.Drawing.Size(54, 24);
            this.role_lbl.TabIndex = 34;
            this.role_lbl.Text = "Role:";
            // 
            // Password_txtb
            // 
            this.Password_txtb.Location = new System.Drawing.Point(302, 285);
            this.Password_txtb.Name = "Password_txtb";
            this.Password_txtb.Size = new System.Drawing.Size(353, 20);
            this.Password_txtb.TabIndex = 33;
            // 
            // LoginName_txtb
            // 
            this.LoginName_txtb.Location = new System.Drawing.Point(302, 243);
            this.LoginName_txtb.Name = "LoginName_txtb";
            this.LoginName_txtb.Size = new System.Drawing.Size(353, 20);
            this.LoginName_txtb.TabIndex = 32;
            // 
            // PhoneNumber_txtb
            // 
            this.PhoneNumber_txtb.Location = new System.Drawing.Point(302, 200);
            this.PhoneNumber_txtb.Name = "PhoneNumber_txtb";
            this.PhoneNumber_txtb.Size = new System.Drawing.Size(353, 20);
            this.PhoneNumber_txtb.TabIndex = 31;
            // 
            // FullName_txtb
            // 
            this.FullName_txtb.Location = new System.Drawing.Point(302, 154);
            this.FullName_txtb.Name = "FullName_txtb";
            this.FullName_txtb.Size = new System.Drawing.Size(353, 20);
            this.FullName_txtb.TabIndex = 30;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.Location = new System.Drawing.Point(102, 280);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(97, 24);
            this.password_lbl.TabIndex = 29;
            this.password_lbl.Text = "Password:";
            // 
            // loginname_lbl
            // 
            this.loginname_lbl.AutoSize = true;
            this.loginname_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginname_lbl.Location = new System.Drawing.Point(102, 239);
            this.loginname_lbl.Name = "loginname_lbl";
            this.loginname_lbl.Size = new System.Drawing.Size(118, 24);
            this.loginname_lbl.TabIndex = 28;
            this.loginname_lbl.Text = "Login Name:";
            // 
            // phonenumber_lbl
            // 
            this.phonenumber_lbl.AutoSize = true;
            this.phonenumber_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumber_lbl.Location = new System.Drawing.Point(102, 196);
            this.phonenumber_lbl.Name = "phonenumber_lbl";
            this.phonenumber_lbl.Size = new System.Drawing.Size(145, 24);
            this.phonenumber_lbl.TabIndex = 27;
            this.phonenumber_lbl.Text = "Phone Number:";
            // 
            // fullname_lbl
            // 
            this.fullname_lbl.AutoSize = true;
            this.fullname_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname_lbl.Location = new System.Drawing.Point(102, 150);
            this.fullname_lbl.Name = "fullname_lbl";
            this.fullname_lbl.Size = new System.Drawing.Size(102, 24);
            this.fullname_lbl.TabIndex = 26;
            this.fullname_lbl.Text = "Full Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Find Username:";
            // 
            // UUPFindUsername_cmb
            // 
            this.UUPFindUsername_cmb.FormattingEnabled = true;
            this.UUPFindUsername_cmb.Location = new System.Drawing.Point(302, 94);
            this.UUPFindUsername_cmb.Name = "UUPFindUsername_cmb";
            this.UUPFindUsername_cmb.Size = new System.Drawing.Size(353, 21);
            this.UUPFindUsername_cmb.TabIndex = 37;
            this.UUPFindUsername_cmb.SelectedIndexChanged += new System.EventHandler(this.UUPFindUsername_cmb_SelectedIndexChanged);
            // 
            // UpdateUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UUPFindUsername_cmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Role_cmb);
            this.Controls.Add(this.role_lbl);
            this.Controls.Add(this.Password_txtb);
            this.Controls.Add(this.LoginName_txtb);
            this.Controls.Add(this.PhoneNumber_txtb);
            this.Controls.Add(this.FullName_txtb);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.loginname_lbl);
            this.Controls.Add(this.phonenumber_lbl);
            this.Controls.Add(this.fullname_lbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UUPBack_btn);
            this.Controls.Add(this.label5);
            this.Name = "UpdateUserProfile";
            this.Text = "UpdateUserProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button UUPBack_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Role_cmb;
        private System.Windows.Forms.Label role_lbl;
        private System.Windows.Forms.TextBox Password_txtb;
        private System.Windows.Forms.TextBox LoginName_txtb;
        private System.Windows.Forms.TextBox PhoneNumber_txtb;
        private System.Windows.Forms.TextBox FullName_txtb;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label loginname_lbl;
        private System.Windows.Forms.Label phonenumber_lbl;
        private System.Windows.Forms.Label fullname_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox UUPFindUsername_cmb;
    }
}