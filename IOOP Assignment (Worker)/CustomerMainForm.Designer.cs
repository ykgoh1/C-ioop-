namespace IOOP_Assignment__Worker_
{
    partial class CustomerMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCustomerEdit = new System.Windows.Forms.Button();
            this.btnCustomerLogout = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckPreviousRequests = new System.Windows.Forms.Button();
            this.btnSubmitNewRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(713, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCustomerEdit
            // 
            this.btnCustomerEdit.Location = new System.Drawing.Point(588, 41);
            this.btnCustomerEdit.Name = "btnCustomerEdit";
            this.btnCustomerEdit.Size = new System.Drawing.Size(77, 57);
            this.btnCustomerEdit.TabIndex = 6;
            this.btnCustomerEdit.Text = "Edit Profile";
            this.btnCustomerEdit.UseVisualStyleBackColor = true;
            this.btnCustomerEdit.Click += new System.EventHandler(this.btnCustomerEdit_Click);
            // 
            // btnCustomerLogout
            // 
            this.btnCustomerLogout.Location = new System.Drawing.Point(693, 41);
            this.btnCustomerLogout.Name = "btnCustomerLogout";
            this.btnCustomerLogout.Size = new System.Drawing.Size(77, 57);
            this.btnCustomerLogout.TabIndex = 5;
            this.btnCustomerLogout.Text = "Logout";
            this.btnCustomerLogout.UseVisualStyleBackColor = true;
            this.btnCustomerLogout.Click += new System.EventHandler(this.btnCustomerLogout_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Location = new System.Drawing.Point(575, 9);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(213, 25);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "Welcome, *name*";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Available Services:";
            // 
            // btnCheckPreviousRequests
            // 
            this.btnCheckPreviousRequests.Location = new System.Drawing.Point(214, 340);
            this.btnCheckPreviousRequests.Name = "btnCheckPreviousRequests";
            this.btnCheckPreviousRequests.Size = new System.Drawing.Size(130, 58);
            this.btnCheckPreviousRequests.TabIndex = 8;
            this.btnCheckPreviousRequests.Text = "Check Previous Requests";
            this.btnCheckPreviousRequests.UseVisualStyleBackColor = true;
            this.btnCheckPreviousRequests.Click += new System.EventHandler(this.btnCheckPreviousRequests_Click);
            // 
            // btnSubmitNewRequest
            // 
            this.btnSubmitNewRequest.Location = new System.Drawing.Point(455, 340);
            this.btnSubmitNewRequest.Name = "btnSubmitNewRequest";
            this.btnSubmitNewRequest.Size = new System.Drawing.Size(130, 58);
            this.btnSubmitNewRequest.TabIndex = 9;
            this.btnSubmitNewRequest.Text = "Submit New Request";
            this.btnSubmitNewRequest.UseVisualStyleBackColor = true;
            this.btnSubmitNewRequest.Click += new System.EventHandler(this.btnSubmitNewRequest_Click);
            // 
            // CustomerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmitNewRequest);
            this.Controls.Add(this.btnCheckPreviousRequests);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCustomerEdit);
            this.Controls.Add(this.btnCustomerLogout);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CustomerMainForm";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCustomerEdit;
        private System.Windows.Forms.Button btnCustomerLogout;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckPreviousRequests;
        private System.Windows.Forms.Button btnSubmitNewRequest;
    }
}