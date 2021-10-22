
namespace QLHOCSINH
{
    partial class FormMenuChinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mntThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mntDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mntHocSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mntLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mntMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mntBangDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mntThongKeHocSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mntThongKeLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mntThongKeBangDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.mntHocSinh,
            this.mntLopHoc,
            this.mntMonHoc,
            this.mntBangDiem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 31);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntThoat,
            this.mntDangXuat});
            this.trangChủToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // mntThoat
            // 
            this.mntThoat.Name = "mntThoat";
            this.mntThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mntThoat.Size = new System.Drawing.Size(198, 28);
            this.mntThoat.Text = "Thoát";
            this.mntThoat.Click += new System.EventHandler(this.mntThoat_Click);
            // 
            // mntDangXuat
            // 
            this.mntDangXuat.Name = "mntDangXuat";
            this.mntDangXuat.Size = new System.Drawing.Size(198, 28);
            this.mntDangXuat.Text = "Đăng xuất";
            this.mntDangXuat.Click += new System.EventHandler(this.mntDangXuat_Click);
            // 
            // mntHocSinh
            // 
            this.mntHocSinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mntHocSinh.Name = "mntHocSinh";
            this.mntHocSinh.Size = new System.Drawing.Size(174, 27);
            this.mntHocSinh.Text = "Thông Tin Học Sinh";
            this.mntHocSinh.Click += new System.EventHandler(this.mntHocSinh_Click);
            // 
            // mntLopHoc
            // 
            this.mntLopHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mntLopHoc.Name = "mntLopHoc";
            this.mntLopHoc.Size = new System.Drawing.Size(87, 27);
            this.mntLopHoc.Text = "Lớp Học";
            this.mntLopHoc.Click += new System.EventHandler(this.mntLopHoc_Click);
            // 
            // mntMonHoc
            // 
            this.mntMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mntMonHoc.Name = "mntMonHoc";
            this.mntMonHoc.Size = new System.Drawing.Size(94, 27);
            this.mntMonHoc.Text = "Môn Học";
            this.mntMonHoc.Click += new System.EventHandler(this.mntMonHoc_Click);
            // 
            // mntBangDiem
            // 
            this.mntBangDiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mntBangDiem.Name = "mntBangDiem";
            this.mntBangDiem.Size = new System.Drawing.Size(108, 27);
            this.mntBangDiem.Text = "Bảng Điểm";
            this.mntBangDiem.Click += new System.EventHandler(this.mntBangDiem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntThongKeHocSinh,
            this.mntThongKeLopHoc,
            this.mntThongKeBangDiem});
            this.thốngKêToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(97, 27);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // mntThongKeHocSinh
            // 
            this.mntThongKeHocSinh.Name = "mntThongKeHocSinh";
            this.mntThongKeHocSinh.Size = new System.Drawing.Size(224, 28);
            this.mntThongKeHocSinh.Text = "Học Sinh";
            this.mntThongKeHocSinh.Click += new System.EventHandler(this.mntThongKeHocSinh_Click);
            // 
            // mntThongKeLopHoc
            // 
            this.mntThongKeLopHoc.Name = "mntThongKeLopHoc";
            this.mntThongKeLopHoc.Size = new System.Drawing.Size(224, 28);
            this.mntThongKeLopHoc.Text = "Lớp học";
            this.mntThongKeLopHoc.Click += new System.EventHandler(this.mntThongKeLopHoc_Click);
            // 
            // mntThongKeBangDiem
            // 
            this.mntThongKeBangDiem.Name = "mntThongKeBangDiem";
            this.mntThongKeBangDiem.Size = new System.Drawing.Size(251, 28);
            this.mntThongKeBangDiem.Text = "Bảng Điểm Học Sinh";
            this.mntThongKeBangDiem.Click += new System.EventHandler(this.mntThongKeBangDiem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::QLHOCSINH.Properties.Resources.Trang_chủ;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(967, 492);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenuChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 523);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenuChinh";
            this.Text = "Phần Mềm Quản Lý Học Sinh Trung Học";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mntThoat;
        private System.Windows.Forms.ToolStripMenuItem mntDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mntHocSinh;
        private System.Windows.Forms.ToolStripMenuItem mntLopHoc;
        private System.Windows.Forms.ToolStripMenuItem mntMonHoc;
        private System.Windows.Forms.ToolStripMenuItem mntBangDiem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mntThongKeHocSinh;
        private System.Windows.Forms.ToolStripMenuItem mntThongKeLopHoc;
        private System.Windows.Forms.ToolStripMenuItem mntThongKeBangDiem;
    }
}