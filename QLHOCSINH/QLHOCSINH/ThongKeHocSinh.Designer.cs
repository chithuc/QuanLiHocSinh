
namespace QLHOCSINH
{
    partial class FormThongKeHocSinh
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
            this.HocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsLopHoc = new QLHOCSINH.dsLopHoc();
            this.reportHocSinh = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HocSinhTableAdapter = new QLHOCSINH.dsLopHocTableAdapters.HocSinhTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HocSinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // HocSinhBindingSource
            // 
            this.HocSinhBindingSource.DataMember = "HocSinh";
            this.HocSinhBindingSource.DataSource = this.dsLopHoc;
            // 
            // dsLopHoc
            // 
            this.dsLopHoc.DataSetName = "dsLopHoc";
            this.dsLopHoc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportHocSinh
            // 
            this.reportHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "HocSinhDataSet";
            reportDataSource1.Value = this.HocSinhBindingSource;
            this.reportHocSinh.LocalReport.DataSources.Add(reportDataSource1);
            this.reportHocSinh.LocalReport.ReportEmbeddedResource = "QLHOCSINH.ReportHocSinh.rdlc";
            this.reportHocSinh.Location = new System.Drawing.Point(0, 0);
            this.reportHocSinh.Name = "reportHocSinh";
            this.reportHocSinh.ServerReport.BearerToken = null;
            this.reportHocSinh.Size = new System.Drawing.Size(880, 503);
            this.reportHocSinh.TabIndex = 0;
            // 
            // HocSinhTableAdapter
            // 
            this.HocSinhTableAdapter.ClearBeforeFill = true;
            // 
            // FormThongKeHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 503);
            this.Controls.Add(this.reportHocSinh);
            this.Name = "FormThongKeHocSinh";
            this.Text = "ThongKeHocSinh";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTKHocSinh_FormClosed);
            this.Load += new System.EventHandler(this.ThongKeHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HocSinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLopHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportHocSinh;
        private System.Windows.Forms.BindingSource HocSinhBindingSource;
        private dsLopHoc dsLopHoc;
        private dsLopHocTableAdapters.HocSinhTableAdapter HocSinhTableAdapter;
    }
}