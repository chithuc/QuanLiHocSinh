
namespace QLHOCSINH
{
    partial class ThongKeBangDiem
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportBangDiem = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsLopHoc = new QLHOCSINH.dsLopHoc();
            this.BangDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BangDiemTableAdapter = new QLHOCSINH.dsLopHocTableAdapters.BangDiemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsLopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangDiemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportBangDiem
            // 
            this.reportBangDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetBangDiem";
            reportDataSource2.Value = this.BangDiemBindingSource;
            this.reportBangDiem.LocalReport.DataSources.Add(reportDataSource2);
            this.reportBangDiem.LocalReport.ReportEmbeddedResource = "QLHOCSINH.ReportBangDiem.rdlc";
            this.reportBangDiem.Location = new System.Drawing.Point(0, 0);
            this.reportBangDiem.Name = "reportBangDiem";
            this.reportBangDiem.ServerReport.BearerToken = null;
            this.reportBangDiem.Size = new System.Drawing.Size(865, 487);
            this.reportBangDiem.TabIndex = 0;
            // 
            // dsLopHoc
            // 
            this.dsLopHoc.DataSetName = "dsLopHoc";
            this.dsLopHoc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BangDiemBindingSource
            // 
            this.BangDiemBindingSource.DataMember = "BangDiem";
            this.BangDiemBindingSource.DataSource = this.dsLopHoc;
            // 
            // BangDiemTableAdapter
            // 
            this.BangDiemTableAdapter.ClearBeforeFill = true;
            // 
            // ThongKeBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 487);
            this.Controls.Add(this.reportBangDiem);
            this.Name = "ThongKeBangDiem";
            this.Text = "ThongKeBangDiem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTKBD_FormClosed);
            this.Load += new System.EventHandler(this.ThongKeBangDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsLopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BangDiemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportBangDiem;
        private System.Windows.Forms.BindingSource BangDiemBindingSource;
        private dsLopHoc dsLopHoc;
        private dsLopHocTableAdapters.BangDiemTableAdapter BangDiemTableAdapter;
    }
}