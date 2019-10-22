namespace WindowsFormsApplication1
{
    partial class factureimprimer
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.contient_c_clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sfeDataSet = new WindowsFormsApplication1.sfeDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.contient_c_clientTableAdapter = new WindowsFormsApplication1.sfeDataSetTableAdapters.contient_c_clientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.contient_c_clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // contient_c_clientBindingSource
            // 
            this.contient_c_clientBindingSource.DataMember = "contient_c_client";
            this.contient_c_clientBindingSource.DataSource = this.sfeDataSet;
            // 
            // sfeDataSet
            // 
            this.sfeDataSet.DataSetName = "sfeDataSet";
            this.sfeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.contient_c_clientBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(725, 792);
            this.reportViewer1.TabIndex = 0;
            // 
            // contient_c_clientTableAdapter
            // 
            this.contient_c_clientTableAdapter.ClearBeforeFill = true;
            // 
            // factureimprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 792);
            this.Controls.Add(this.reportViewer1);
            this.Name = "factureimprimer";
            this.Text = "factureimprimer";
            this.Load += new System.EventHandler(this.factureimprimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contient_c_clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public sfeDataSet sfeDataSet;
        public System.Windows.Forms.BindingSource contient_c_clientBindingSource;
        public sfeDataSetTableAdapters.contient_c_clientTableAdapter contient_c_clientTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}