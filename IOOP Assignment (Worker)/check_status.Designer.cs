namespace IOOP_Assignment__Worker_
{
    partial class check_status
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
            this.aPU_Printing_ServiceDataSet = new IOOP_Assignment__Worker_.APU_Printing_ServiceDataSet();
            this.jobTableAdapter = new IOOP_Assignment__Worker_.APU_Printing_ServiceDataSetTableAdapters.JobTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.aPUPrintingServiceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvAllJob = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.aPU_Printing_ServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPUPrintingServiceDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllJob)).BeginInit();
            this.SuspendLayout();
            // 
            // aPU_Printing_ServiceDataSet
            // 
            this.aPU_Printing_ServiceDataSet.DataSetName = "APU_Printing_ServiceDataSet";
            this.aPU_Printing_ServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Job Table";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(580, 464);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 50);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // aPUPrintingServiceDataSetBindingSource
            // 
            this.aPUPrintingServiceDataSetBindingSource.DataSource = this.aPU_Printing_ServiceDataSet;
            this.aPUPrintingServiceDataSetBindingSource.Position = 0;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.aPUPrintingServiceDataSetBindingSource;
            // 
            // dgvAllJob
            // 
            this.dgvAllJob.AllowUserToDeleteRows = false;
            this.dgvAllJob.AllowUserToOrderColumns = true;
            this.dgvAllJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllJob.Location = new System.Drawing.Point(34, 84);
            this.dgvAllJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAllJob.Name = "dgvAllJob";
            this.dgvAllJob.RowHeadersWidth = 51;
            this.dgvAllJob.RowTemplate.Height = 24;
            this.dgvAllJob.Size = new System.Drawing.Size(1228, 349);
            this.dgvAllJob.TabIndex = 0;
            // 
            // check_status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 555);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAllJob);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "check_status";
            this.Text = "check_status";
            ((System.ComponentModel.ISupportInitialize)(this.aPU_Printing_ServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPUPrintingServiceDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllJob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private APU_Printing_ServiceDataSet aPU_Printing_ServiceDataSet;
        private APU_Printing_ServiceDataSetTableAdapters.JobTableAdapter jobTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.BindingSource aPUPrintingServiceDataSetBindingSource;
        private System.Windows.Forms.DataGridView dgvAllJob;
    }
}