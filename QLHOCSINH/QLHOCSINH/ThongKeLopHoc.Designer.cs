
namespace QLHOCSINH
{
    partial class FormThongKeLopHoc
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
            this.LopHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLopHoc = new QLHOCSINH.dsLopHoc();
            this.LopHocTableAdapter = new QLHOCSINH.dsLopHocTableAdapters.LopHocTableAdapter();
            this.reportLopHoc = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.LopHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // LopHocBindingSource
            // 
            this.LopHocBindingSource.DataMember = "LopHoc";
            this.LopHocBindingSource.DataSource = this.dsLopHoc;
            // 
            // dsLopHoc
            // 
            this.dsLopHoc.DataSetName = "dsLopHoc";
            this.dsLopHoc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LopHocTableAdapter
            // 
            this.LopHocTableAdapter.ClearBeforeFill = true;
            // 
            // reportLopHoc
            // 
            this.reportLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LopHocBindingSource;
            this.reportLopHoc.LocalReport.DataSources.Add(reportDataSource1);
            this.reportLopHoc.LocalReport.ReportEmbeddedResource = "QLHOCSINH.ReportLopHoc.rdlc";
            this.reportLopHoc.Location = new System.Drawing.Point(0, 0);
            this.reportLopHoc.Name = "reportLopHoc";
            this.reportLopHoc.ServerReport.BearerToken = null;
            this.reportLopHoc.Size = new System.Drawing.Size(842, 512);
            this.reportLopHoc.TabIndex = 0;
            // 
            // FormThongKeLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 512);
            this.Controls.Add(this.reportLopHoc);
            this.Name = "FormThongKeLopHoc";
            this.Text = "ThongKeLopHoc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTKLH_Formclosed);
            this.Load += new System.EventHandler(this.FormThongKeLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LopHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLopHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource LopHocBindingSource;
        private dsLopHoc dsLopHoc;
        private dsLopHocTableAdapters.LopHocTableAdapter LopHocTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportLopHoc;
    }
}