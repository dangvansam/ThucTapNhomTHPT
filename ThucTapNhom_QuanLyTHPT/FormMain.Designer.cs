namespace ThucTapNhom_QuanLyTHPT
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUser = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnGiangDay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChucVu = new System.Windows.Forms.Button();
            this.btnMonHoc = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnBangDiem = new System.Windows.Forms.Button();
            this.btnLopHoc = new System.Windows.Forms.Button();
            this.btnGiaoVien = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnHocSinh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.btnGiangDay);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbUser);
            this.panel1.Controls.Add(this.btnChucVu);
            this.panel1.Controls.Add(this.btnMonHoc);
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.btnBangDiem);
            this.panel1.Controls.Add(this.btnLopHoc);
            this.panel1.Controls.Add(this.btnGiaoVien);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnHocSinh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 688);
            this.panel1.TabIndex = 3;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbUser.ForeColor = System.Drawing.Color.Silver;
            this.lbUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbUser.Location = new System.Drawing.Point(5, 616);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(42, 21);
            this.lbUser.TabIndex = 10;
            this.lbUser.Text = "User";
            this.lbUser.Visible = false;
            this.lbUser.Click += new System.EventHandler(this.lbUser_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(152, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1177, 81);
            this.pnlHeader.TabIndex = 10;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBody.Location = new System.Drawing.Point(152, 81);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1177, 607);
            this.pnlBody.TabIndex = 11;
            this.pnlBody.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBody_Paint);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Tomato;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = null;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(1119, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 32);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 6;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("UTM Avo", 11.25F);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThongKe.Location = new System.Drawing.Point(1, 536);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(152, 47);
            this.btnThongKe.TabIndex = 12;
            this.btnThongKe.Text = "    Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnGiangDay
            // 
            this.btnGiangDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGiangDay.FlatAppearance.BorderSize = 0;
            this.btnGiangDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiangDay.Font = new System.Drawing.Font("UTM Avo", 11.25F);
            this.btnGiangDay.ForeColor = System.Drawing.Color.White;
            this.btnGiangDay.Image = ((System.Drawing.Image)(resources.GetObject("btnGiangDay.Image")));
            this.btnGiangDay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGiangDay.Location = new System.Drawing.Point(3, 430);
            this.btnGiangDay.Name = "btnGiangDay";
            this.btnGiangDay.Size = new System.Drawing.Size(150, 47);
            this.btnGiangDay.TabIndex = 5;
            this.btnGiangDay.Text = "   Giảng dạy";
            this.btnGiangDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGiangDay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGiangDay.UseVisualStyleBackColor = true;
            this.btnGiangDay.Click += new System.EventHandler(this.btnGiangDay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::ThucTapNhom_QuanLyTHPT.Properties.Resources.logogoc1;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(8, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnChucVu
            // 
            this.btnChucVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChucVu.FlatAppearance.BorderSize = 0;
            this.btnChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChucVu.Font = new System.Drawing.Font("UTM Avo", 11.25F);
            this.btnChucVu.ForeColor = System.Drawing.Color.White;
            this.btnChucVu.Image = ((System.Drawing.Image)(resources.GetObject("btnChucVu.Image")));
            this.btnChucVu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnChucVu.Location = new System.Drawing.Point(0, 271);
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.Size = new System.Drawing.Size(152, 47);
            this.btnChucVu.TabIndex = 2;
            this.btnChucVu.Text = "     Chức vụ";
            this.btnChucVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChucVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChucVu.UseVisualStyleBackColor = true;
            this.btnChucVu.Click += new System.EventHandler(this.btnChucVu_Click);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMonHoc.FlatAppearance.BorderSize = 0;
            this.btnMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonHoc.Font = new System.Drawing.Font("UTM Avo", 11.25F);
            this.btnMonHoc.ForeColor = System.Drawing.Color.White;
            this.btnMonHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.Image")));
            this.btnMonHoc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMonHoc.Location = new System.Drawing.Point(-1, 377);
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.Size = new System.Drawing.Size(154, 47);
            this.btnMonHoc.TabIndex = 4;
            this.btnMonHoc.Text = "   Môn học";
            this.btnMonHoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMonHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMonHoc.UseVisualStyleBackColor = true;
            this.btnMonHoc.Click += new System.EventHandler(this.btnMonHoc_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSetting.Location = new System.Drawing.Point(111, 640);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(33, 30);
            this.btnSetting.TabIndex = 9;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHelp.Location = new System.Drawing.Point(59, 640);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(33, 30);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnBangDiem
            // 
            this.btnBangDiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBangDiem.FlatAppearance.BorderSize = 0;
            this.btnBangDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBangDiem.Font = new System.Drawing.Font("UTM Avo", 11.25F);
            this.btnBangDiem.ForeColor = System.Drawing.Color.White;
            this.btnBangDiem.Image = ((System.Drawing.Image)(resources.GetObject("btnBangDiem.Image")));
            this.btnBangDiem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBangDiem.Location = new System.Drawing.Point(3, 483);
            this.btnBangDiem.Name = "btnBangDiem";
            this.btnBangDiem.Size = new System.Drawing.Size(150, 47);
            this.btnBangDiem.TabIndex = 6;
            this.btnBangDiem.Text = "   Bảng điểm";
            this.btnBangDiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBangDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBangDiem.UseVisualStyleBackColor = true;
            this.btnBangDiem.Click += new System.EventHandler(this.btnBangDiem_Click);
            // 
            // btnLopHoc
            // 
            this.btnLopHoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLopHoc.FlatAppearance.BorderSize = 0;
            this.btnLopHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLopHoc.Font = new System.Drawing.Font("UTM Avo", 11.25F);
            this.btnLopHoc.ForeColor = System.Drawing.Color.White;
            this.btnLopHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLopHoc.Image")));
            this.btnLopHoc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLopHoc.Location = new System.Drawing.Point(-4, 324);
            this.btnLopHoc.Name = "btnLopHoc";
            this.btnLopHoc.Size = new System.Drawing.Size(157, 47);
            this.btnLopHoc.TabIndex = 3;
            this.btnLopHoc.Text = "    Lớp học";
            this.btnLopHoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLopHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLopHoc.UseVisualStyleBackColor = true;
            this.btnLopHoc.Click += new System.EventHandler(this.btnLopHoc_Click);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGiaoVien.FlatAppearance.BorderSize = 0;
            this.btnGiaoVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaoVien.Font = new System.Drawing.Font("UTM Avo", 11.25F);
            this.btnGiaoVien.ForeColor = System.Drawing.Color.White;
            this.btnGiaoVien.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaoVien.Image")));
            this.btnGiaoVien.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGiaoVien.Location = new System.Drawing.Point(0, 218);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(152, 47);
            this.btnGiaoVien.TabIndex = 1;
            this.btnGiaoVien.Text = "    Giáo viên";
            this.btnGiaoVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGiaoVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGiaoVien.UseVisualStyleBackColor = true;
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHome.Location = new System.Drawing.Point(9, 640);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(33, 30);
            this.btnHome.TabIndex = 7;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHocSinh.FlatAppearance.BorderSize = 0;
            this.btnHocSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHocSinh.Font = new System.Drawing.Font("UTM Avo", 11.25F);
            this.btnHocSinh.ForeColor = System.Drawing.Color.White;
            this.btnHocSinh.Image = ((System.Drawing.Image)(resources.GetObject("btnHocSinh.Image")));
            this.btnHocSinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHocSinh.Location = new System.Drawing.Point(0, 165);
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.Size = new System.Drawing.Size(152, 47);
            this.btnHocSinh.TabIndex = 0;
            this.btnHocSinh.Text = "    Học sinh";
            this.btnHocSinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHocSinh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHocSinh.UseVisualStyleBackColor = true;
            this.btnHocSinh.Click += new System.EventHandler(this.btnHocSinh_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1329, 688);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý THPT";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBangDiem;
        private System.Windows.Forms.Button btnLopHoc;
        private System.Windows.Forms.Button btnGiaoVien;
        private System.Windows.Forms.Button btnHocSinh;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnHelp;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnMonHoc;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button btnChucVu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btnGiangDay;
        private System.Windows.Forms.Button btnThongKe;
    }
}

