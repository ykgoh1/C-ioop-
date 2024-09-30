namespace IOOP_Assignment__Worker_
{
    partial class WorkerMainForm
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
            this.lblWorkerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnWorkerLogout = new System.Windows.Forms.Button();
            this.btnWorkerEdit = new System.Windows.Forms.Button();
            this.lstAssigned = new System.Windows.Forms.ListBox();
            this.lstWIP = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMoveWIP = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.aPU_Printing_ServiceDataSet = new IOOP_Assignment__Worker_.APU_Printing_ServiceDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new IOOP_Assignment__Worker_.APU_Printing_ServiceDataSetTableAdapters.UserTableAdapter();
            this.lblJobDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aPU_Printing_ServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.Location = new System.Drawing.Point(576, 9);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(213, 25);
            this.lblWorkerName.TabIndex = 0;
            this.lblWorkerName.Text = "Welcome, *name*";
            this.lblWorkerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assigned";
            // 
            // btnWorkerLogout
            // 
            this.btnWorkerLogout.Location = new System.Drawing.Point(681, 46);
            this.btnWorkerLogout.Name = "btnWorkerLogout";
            this.btnWorkerLogout.Size = new System.Drawing.Size(77, 57);
            this.btnWorkerLogout.TabIndex = 2;
            this.btnWorkerLogout.Text = "Logout";
            this.btnWorkerLogout.UseVisualStyleBackColor = true;
            this.btnWorkerLogout.Click += new System.EventHandler(this.btnWorkerLogout_Click);
            // 
            // btnWorkerEdit
            // 
            this.btnWorkerEdit.Location = new System.Drawing.Point(598, 46);
            this.btnWorkerEdit.Name = "btnWorkerEdit";
            this.btnWorkerEdit.Size = new System.Drawing.Size(77, 57);
            this.btnWorkerEdit.TabIndex = 3;
            this.btnWorkerEdit.Text = "Edit Profile";
            this.btnWorkerEdit.UseVisualStyleBackColor = true;
            this.btnWorkerEdit.Click += new System.EventHandler(this.btnWorkerEdit_Click);
            // 
            // lstAssigned
            // 
            this.lstAssigned.FormattingEnabled = true;
            this.lstAssigned.ItemHeight = 20;
            this.lstAssigned.Location = new System.Drawing.Point(77, 55);
            this.lstAssigned.Name = "lstAssigned";
            this.lstAssigned.Size = new System.Drawing.Size(168, 244);
            this.lstAssigned.TabIndex = 4;
            // 
            // lstWIP
            // 
            this.lstWIP.FormattingEnabled = true;
            this.lstWIP.ItemHeight = 20;
            this.lstWIP.Location = new System.Drawing.Point(280, 55);
            this.lstWIP.Name = "lstWIP";
            this.lstWIP.Size = new System.Drawing.Size(168, 244);
            this.lstWIP.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Work in Progress";
            // 
            // btnMoveWIP
            // 
            this.btnMoveWIP.Location = new System.Drawing.Point(110, 315);
            this.btnMoveWIP.Name = "btnMoveWIP";
            this.btnMoveWIP.Size = new System.Drawing.Size(102, 75);
            this.btnMoveWIP.TabIndex = 7;
            this.btnMoveWIP.Text = "Move to WIP";
            this.btnMoveWIP.UseVisualStyleBackColor = true;
            this.btnMoveWIP.Click += new System.EventHandler(this.btnMoveWIP_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.Location = new System.Drawing.Point(313, 315);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(102, 75);
            this.btnCompleted.TabIndex = 8;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.UseVisualStyleBackColor = true;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description";
            // 
            // aPU_Printing_ServiceDataSet
            // 
            this.aPU_Printing_ServiceDataSet.DataSetName = "APU_Printing_ServiceDataSet";
            this.aPU_Printing_ServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.aPU_Printing_ServiceDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // lblJobDescription
            // 
            this.lblJobDescription.BackColor = System.Drawing.SystemColors.Info;
            this.lblJobDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJobDescription.Location = new System.Drawing.Point(500, 162);
            this.lblJobDescription.Name = "lblJobDescription";
            this.lblJobDescription.Size = new System.Drawing.Size(288, 203);
            this.lblJobDescription.TabIndex = 10;
            this.lblJobDescription.Text = "*Job Description*";
            // 
            // WorkerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblJobDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.btnMoveWIP);
            this.Controls.Add(this.lstWIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAssigned);
            this.Controls.Add(this.btnWorkerEdit);
            this.Controls.Add(this.btnWorkerLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWorkerName);
            this.Name = "WorkerMainForm";
            this.Text = "Worker";
            ((System.ComponentModel.ISupportInitialize)(this.aPU_Printing_ServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWorkerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnWorkerLogout;
        private System.Windows.Forms.Button btnWorkerEdit;
        private System.Windows.Forms.ListBox lstAssigned;
        private System.Windows.Forms.ListBox lstWIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMoveWIP;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Label label3;
        private APU_Printing_ServiceDataSet aPU_Printing_ServiceDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private APU_Printing_ServiceDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.Label lblJobDescription;
    }
}

