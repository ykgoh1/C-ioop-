namespace IOOP_Assignment__Worker_
{
    partial class Assigned_New_
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
            this.NewJob = new System.Windows.Forms.ListBox();
            this.Worker_ID = new System.Windows.Forms.ListBox();
            this.NewJobDescription = new System.Windows.Forms.Label();
            this.Worker_IDDescription = new System.Windows.Forms.Label();
            this.btnShowAllRequest = new System.Windows.Forms.Button();
            this.btnAssigned = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnManagerEdit = new System.Windows.Forms.Button();
            this.btnManagerLogout = new System.Windows.Forms.Button();
            this.lblManagerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewJob
            // 
            this.NewJob.FormattingEnabled = true;
            this.NewJob.ItemHeight = 20;
            this.NewJob.Location = new System.Drawing.Point(117, 110);
            this.NewJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewJob.Name = "NewJob";
            this.NewJob.Size = new System.Drawing.Size(166, 184);
            this.NewJob.TabIndex = 0;
            // 
            // Worker_ID
            // 
            this.Worker_ID.FormattingEnabled = true;
            this.Worker_ID.ItemHeight = 20;
            this.Worker_ID.Location = new System.Drawing.Point(367, 110);
            this.Worker_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Worker_ID.Name = "Worker_ID";
            this.Worker_ID.Size = new System.Drawing.Size(173, 184);
            this.Worker_ID.TabIndex = 1;
            // 
            // NewJobDescription
            // 
            this.NewJobDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewJobDescription.ForeColor = System.Drawing.SystemColors.MenuText;
            this.NewJobDescription.Location = new System.Drawing.Point(93, 345);
            this.NewJobDescription.Name = "NewJobDescription";
            this.NewJobDescription.Size = new System.Drawing.Size(202, 188);
            this.NewJobDescription.TabIndex = 2;
            this.NewJobDescription.Text = "New Job Description";
            // 
            // Worker_IDDescription
            // 
            this.Worker_IDDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Worker_IDDescription.Location = new System.Drawing.Point(363, 345);
            this.Worker_IDDescription.Name = "Worker_IDDescription";
            this.Worker_IDDescription.Size = new System.Drawing.Size(202, 188);
            this.Worker_IDDescription.TabIndex = 3;
            this.Worker_IDDescription.Text = "Worker_ID Description";
            // 
            // btnShowAllRequest
            // 
            this.btnShowAllRequest.Location = new System.Drawing.Point(695, 365);
            this.btnShowAllRequest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowAllRequest.Name = "btnShowAllRequest";
            this.btnShowAllRequest.Size = new System.Drawing.Size(140, 64);
            this.btnShowAllRequest.TabIndex = 5;
            this.btnShowAllRequest.Text = "Show All Request";
            this.btnShowAllRequest.UseVisualStyleBackColor = true;
            this.btnShowAllRequest.Click += new System.EventHandler(this.btnShowAllRequest_Click);
            // 
            // btnAssigned
            // 
            this.btnAssigned.Location = new System.Drawing.Point(695, 252);
            this.btnAssigned.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAssigned.Name = "btnAssigned";
            this.btnAssigned.Size = new System.Drawing.Size(140, 64);
            this.btnAssigned.TabIndex = 7;
            this.btnAssigned.Text = "Assigned ";
            this.btnAssigned.UseVisualStyleBackColor = true;
            this.btnAssigned.Click += new System.EventHandler(this.btnAssigned_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Assigned a Job";
            // 
            // btnManagerEdit
            // 
            this.btnManagerEdit.Location = new System.Drawing.Point(675, 66);
            this.btnManagerEdit.Name = "btnManagerEdit";
            this.btnManagerEdit.Size = new System.Drawing.Size(77, 57);
            this.btnManagerEdit.TabIndex = 11;
            this.btnManagerEdit.Text = "Edit Profile";
            this.btnManagerEdit.UseVisualStyleBackColor = true;
            this.btnManagerEdit.Click += new System.EventHandler(this.btnManagerEdit_Click);
            // 
            // btnManagerLogout
            // 
            this.btnManagerLogout.Location = new System.Drawing.Point(758, 66);
            this.btnManagerLogout.Name = "btnManagerLogout";
            this.btnManagerLogout.Size = new System.Drawing.Size(77, 57);
            this.btnManagerLogout.TabIndex = 10;
            this.btnManagerLogout.Text = "Logout";
            this.btnManagerLogout.UseVisualStyleBackColor = true;
            this.btnManagerLogout.Click += new System.EventHandler(this.btnManagerLogout_Click);
            // 
            // lblManagerName
            // 
            this.lblManagerName.Location = new System.Drawing.Point(653, 29);
            this.lblManagerName.Name = "lblManagerName";
            this.lblManagerName.Size = new System.Drawing.Size(213, 25);
            this.lblManagerName.TabIndex = 9;
            this.lblManagerName.Text = "Welcome, *name*";
            this.lblManagerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Assigned_New_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnManagerEdit);
            this.Controls.Add(this.btnManagerLogout);
            this.Controls.Add(this.lblManagerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAssigned);
            this.Controls.Add(this.btnShowAllRequest);
            this.Controls.Add(this.Worker_IDDescription);
            this.Controls.Add(this.NewJobDescription);
            this.Controls.Add(this.Worker_ID);
            this.Controls.Add(this.NewJob);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Assigned_New_";
            this.Text = "Assigned_New_";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox NewJob;
        private System.Windows.Forms.ListBox Worker_ID;
        private System.Windows.Forms.Label NewJobDescription;
        private System.Windows.Forms.Label Worker_IDDescription;
        private System.Windows.Forms.Button btnShowAllRequest;
        private System.Windows.Forms.Button btnAssigned;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManagerEdit;
        private System.Windows.Forms.Button btnManagerLogout;
        private System.Windows.Forms.Label lblManagerName;
    }
}