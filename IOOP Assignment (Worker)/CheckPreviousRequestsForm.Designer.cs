namespace IOOP_Assignment__Worker_
{
    partial class CheckPreviousRequestsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvPreviousRequests = new System.Windows.Forms.DataGridView();
            this.aPU_Printing_ServiceDataSet = new IOOP_Assignment__Worker_.APU_Printing_ServiceDataSet();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobTableAdapter = new IOOP_Assignment__Worker_.APU_Printing_ServiceDataSetTableAdapters.JobTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviousRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPU_Printing_ServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Previous Requests";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(327, 353);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 50);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvPreviousRequests
            // 
            this.dgvPreviousRequests.AllowUserToAddRows = false;
            this.dgvPreviousRequests.AllowUserToDeleteRows = false;
            this.dgvPreviousRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPreviousRequests.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPreviousRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreviousRequests.Location = new System.Drawing.Point(25, 90);
            this.dgvPreviousRequests.Name = "dgvPreviousRequests";
            this.dgvPreviousRequests.RowHeadersWidth = 62;
            this.dgvPreviousRequests.RowTemplate.Height = 28;
            this.dgvPreviousRequests.Size = new System.Drawing.Size(757, 221);
            this.dgvPreviousRequests.TabIndex = 21;
            // 
            // aPU_Printing_ServiceDataSet
            // 
            this.aPU_Printing_ServiceDataSet.DataSetName = "APU_Printing_ServiceDataSet";
            this.aPU_Printing_ServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.aPU_Printing_ServiceDataSet;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // CheckPreviousRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPreviousRequests);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Name = "CheckPreviousRequestsForm";
            this.Text = "Check Previous Requests";
            this.Load += new System.EventHandler(this.CheckPreviousRequestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviousRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPU_Printing_ServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvPreviousRequests;
        private APU_Printing_ServiceDataSet aPU_Printing_ServiceDataSet;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private APU_Printing_ServiceDataSetTableAdapters.JobTableAdapter jobTableAdapter;
    }
}