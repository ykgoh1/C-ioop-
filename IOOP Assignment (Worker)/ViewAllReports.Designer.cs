namespace IOOP_Assignment__Worker_
{
    partial class ViewAllReports
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
            this.ServiceReport_btn = new System.Windows.Forms.Button();
            this.YearlyReport_btn = new System.Windows.Forms.Button();
            this.VARBack_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(291, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "View All Reports";
            // 
            // ServiceReport_btn
            // 
            this.ServiceReport_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceReport_btn.Location = new System.Drawing.Point(452, 192);
            this.ServiceReport_btn.Name = "ServiceReport_btn";
            this.ServiceReport_btn.Size = new System.Drawing.Size(208, 99);
            this.ServiceReport_btn.TabIndex = 11;
            this.ServiceReport_btn.Text = "Service and Customer Report";
            this.ServiceReport_btn.UseVisualStyleBackColor = true;
            this.ServiceReport_btn.Click += new System.EventHandler(this.ServiceReport_btn_Click);
            // 
            // YearlyReport_btn
            // 
            this.YearlyReport_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearlyReport_btn.Location = new System.Drawing.Point(143, 192);
            this.YearlyReport_btn.Name = "YearlyReport_btn";
            this.YearlyReport_btn.Size = new System.Drawing.Size(208, 99);
            this.YearlyReport_btn.TabIndex = 10;
            this.YearlyReport_btn.Text = "Yearly Report";
            this.YearlyReport_btn.UseVisualStyleBackColor = true;
            this.YearlyReport_btn.Click += new System.EventHandler(this.YearlyReport_btn_Click);
            // 
            // VARBack_btn
            // 
            this.VARBack_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VARBack_btn.Location = new System.Drawing.Point(336, 379);
            this.VARBack_btn.Name = "VARBack_btn";
            this.VARBack_btn.Size = new System.Drawing.Size(128, 44);
            this.VARBack_btn.TabIndex = 13;
            this.VARBack_btn.Text = "Back";
            this.VARBack_btn.UseVisualStyleBackColor = true;
            this.VARBack_btn.Click += new System.EventHandler(this.VARBack_btn_Click);
            // 
            // ViewAllReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VARBack_btn);
            this.Controls.Add(this.ServiceReport_btn);
            this.Controls.Add(this.YearlyReport_btn);
            this.Controls.Add(this.label5);
            this.Name = "ViewAllReports";
            this.Text = "ViewAllReports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ServiceReport_btn;
        private System.Windows.Forms.Button YearlyReport_btn;
        private System.Windows.Forms.Button VARBack_btn;
    }
}