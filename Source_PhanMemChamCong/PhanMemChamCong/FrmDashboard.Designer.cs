namespace PhanMemChamCong
{
    partial class FrmDashboard
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
            this.tabChamCong = new System.Windows.Forms.TabPage();
            this.tabQuanLy = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtUser1 = new System.Windows.Forms.TextBox();
            this.txtHoten1 = new System.Windows.Forms.TextBox();
            this.txtChucVu1 = new System.Windows.Forms.TextBox();
            this.txtPhongBan1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimKiem1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTimKiem2 = new System.Windows.Forms.Button();
            this.txtDienThoai2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHoten2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUser2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThayDoi = new System.Windows.Forms.Button();
            this.tabDashboard = new System.Windows.Forms.TabControl();
            this.cbxUser = new System.Windows.Forms.ComboBox();
            this.tabQuanLy.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.tabProfile.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabChamCong
            // 
            this.tabChamCong.Location = new System.Drawing.Point(4, 23);
            this.tabChamCong.Name = "tabChamCong";
            this.tabChamCong.Size = new System.Drawing.Size(618, 453);
            this.tabChamCong.TabIndex = 2;
            this.tabChamCong.Text = "Chấm công";
            this.tabChamCong.UseVisualStyleBackColor = true;
            // 
            // tabQuanLy
            // 
            this.tabQuanLy.Controls.Add(this.tabControl2);
            this.tabQuanLy.Controls.Add(this.dgvNhanVien);
            this.tabQuanLy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQuanLy.Location = new System.Drawing.Point(4, 23);
            this.tabQuanLy.Name = "tabQuanLy";
            this.tabQuanLy.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuanLy.Size = new System.Drawing.Size(618, 453);
            this.tabQuanLy.TabIndex = 0;
            this.tabQuanLy.Text = "Quản lý";
            this.tabQuanLy.UseVisualStyleBackColor = true;
            this.tabQuanLy.Click += new System.EventHandler(this.tabQuanLy_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Location = new System.Drawing.Point(6, 10);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(606, 178);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtUser1);
            this.tabPage5.Controls.Add(this.txtHoten1);
            this.tabPage5.Controls.Add(this.txtChucVu1);
            this.tabPage5.Controls.Add(this.txtPhongBan1);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.btnTimKiem1);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(598, 149);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Nhân viên fulltime";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtUser1
            // 
            this.txtUser1.Location = new System.Drawing.Point(109, 14);
            this.txtUser1.Multiline = true;
            this.txtUser1.Name = "txtUser1";
            this.txtUser1.Size = new System.Drawing.Size(123, 23);
            this.txtUser1.TabIndex = 16;
            // 
            // txtHoten1
            // 
            this.txtHoten1.Location = new System.Drawing.Point(109, 53);
            this.txtHoten1.Multiline = true;
            this.txtHoten1.Name = "txtHoten1";
            this.txtHoten1.Size = new System.Drawing.Size(123, 23);
            this.txtHoten1.TabIndex = 14;
            // 
            // txtChucVu1
            // 
            this.txtChucVu1.Location = new System.Drawing.Point(349, 56);
            this.txtChucVu1.Multiline = true;
            this.txtChucVu1.Name = "txtChucVu1";
            this.txtChucVu1.Size = new System.Drawing.Size(130, 23);
            this.txtChucVu1.TabIndex = 8;
            // 
            // txtPhongBan1
            // 
            this.txtPhongBan1.Location = new System.Drawing.Point(349, 20);
            this.txtPhongBan1.Multiline = true;
            this.txtPhongBan1.Name = "txtPhongBan1";
            this.txtPhongBan1.Size = new System.Drawing.Size(130, 23);
            this.txtPhongBan1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(11, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "MSNV";
            // 
            // btnTimKiem1
            // 
            this.btnTimKiem1.Location = new System.Drawing.Point(349, 86);
            this.btnTimKiem1.Name = "btnTimKiem1";
            this.btnTimKiem1.Size = new System.Drawing.Size(107, 39);
            this.btnTimKiem1.TabIndex = 13;
            this.btnTimKiem1.Text = "Tìm kiếm";
            this.btnTimKiem1.UseVisualStyleBackColor = true;
            this.btnTimKiem1.Click += new System.EventHandler(this.btnTimKiem1_Click);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(251, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Chức vụ";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(251, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "Phòng ban";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(11, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Họ tên";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTimKiem2);
            this.tabPage1.Controls.Add(this.txtDienThoai2);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtHoten2);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtUser2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(598, 149);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Nhân viên partime";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnTimKiem2
            // 
            this.btnTimKiem2.Location = new System.Drawing.Point(375, 51);
            this.btnTimKiem2.Name = "btnTimKiem2";
            this.btnTimKiem2.Size = new System.Drawing.Size(107, 39);
            this.btnTimKiem2.TabIndex = 23;
            this.btnTimKiem2.Text = "Tìm kiếm";
            this.btnTimKiem2.UseVisualStyleBackColor = true;
            this.btnTimKiem2.Click += new System.EventHandler(this.btnTimKiem2_Click);
            // 
            // txtDienThoai2
            // 
            this.txtDienThoai2.Location = new System.Drawing.Point(359, 15);
            this.txtDienThoai2.Multiline = true;
            this.txtDienThoai2.Name = "txtDienThoai2";
            this.txtDienThoai2.Size = new System.Drawing.Size(123, 23);
            this.txtDienThoai2.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(261, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 24);
            this.label12.TabIndex = 21;
            this.label12.Text = "Điện Thoại";
            // 
            // txtHoten2
            // 
            this.txtHoten2.Location = new System.Drawing.Point(116, 51);
            this.txtHoten2.Multiline = true;
            this.txtHoten2.Name = "txtHoten2";
            this.txtHoten2.Size = new System.Drawing.Size(123, 23);
            this.txtHoten2.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(18, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 24);
            this.label11.TabIndex = 19;
            this.label11.Text = "Họ tên";
            // 
            // txtUser2
            // 
            this.txtUser2.Location = new System.Drawing.Point(116, 15);
            this.txtUser2.Multiline = true;
            this.txtUser2.Name = "txtUser2";
            this.txtUser2.Size = new System.Drawing.Size(123, 23);
            this.txtUser2.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(18, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "MSNV";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 194);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(612, 256);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick);
            this.dgvNhanVien.SelectionChanged += new System.EventHandler(this.dgvNhanVien_SelectionChanged);
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.btnLuu);
            this.tabProfile.Controls.Add(this.pnlProfile);
            this.tabProfile.Controls.Add(this.btnThem);
            this.tabProfile.Controls.Add(this.btnDong);
            this.tabProfile.Controls.Add(this.btnThayDoi);
            this.tabProfile.Location = new System.Drawing.Point(4, 23);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Size = new System.Drawing.Size(618, 453);
            this.tabProfile.TabIndex = 3;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            this.tabProfile.Click += new System.EventHandler(this.tabProfile_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(170, 407);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(81, 41);
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // pnlProfile
            // 
            this.pnlProfile.Controls.Add(this.cbxUser);
            this.pnlProfile.Controls.Add(this.label13);
            this.pnlProfile.Controls.Add(this.cbxGioiTinh);
            this.pnlProfile.Controls.Add(this.dtpNgaySinh);
            this.pnlProfile.Controls.Add(this.txtDiaChi);
            this.pnlProfile.Controls.Add(this.label5);
            this.pnlProfile.Controls.Add(this.txtSdt);
            this.pnlProfile.Controls.Add(this.label4);
            this.pnlProfile.Controls.Add(this.txtHoten);
            this.pnlProfile.Controls.Add(this.label3);
            this.pnlProfile.Controls.Add(this.label2);
            this.pnlProfile.Controls.Add(this.label1);
            this.pnlProfile.Controls.Add(this.lblUser);
            this.pnlProfile.Location = new System.Drawing.Point(23, 3);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(579, 398);
            this.pnlProfile.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(158, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 37);
            this.label13.TabIndex = 31;
            this.label13.Text = "Thêm nhân viên";
            // 
            // cbxGioiTinh
            // 
            this.cbxGioiTinh.FormattingEnabled = true;
            this.cbxGioiTinh.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.cbxGioiTinh.Location = new System.Drawing.Point(147, 179);
            this.cbxGioiTinh.Name = "cbxGioiTinh";
            this.cbxGioiTinh.Size = new System.Drawing.Size(223, 22);
            this.cbxGioiTinh.TabIndex = 30;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(147, 146);
            this.dtpNgaySinh.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpNgaySinh.Size = new System.Drawing.Size(223, 20);
            this.dtpNgaySinh.TabIndex = 29;
            this.dtpNgaySinh.Value = new System.DateTime(2018, 4, 6, 0, 0, 0, 0);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(147, 266);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(339, 86);
            this.txtDiaChi.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 35);
            this.label5.TabIndex = 24;
            this.label5.Text = "Địa chỉ";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(147, 220);
            this.txtSdt.Multiline = true;
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(223, 32);
            this.txtSdt.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 30);
            this.label4.TabIndex = 22;
            this.label4.Text = "Số điện thoại";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(147, 106);
            this.txtHoten.Multiline = true;
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(223, 32);
            this.txtHoten.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 30);
            this.label3.TabIndex = 20;
            this.label3.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ngày sinh";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(3, 69);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(138, 30);
            this.lblUser.TabIndex = 14;
            this.lblUser.Text = "Mã số nhân viên";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(347, 406);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 41);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(434, 406);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(81, 41);
            this.btnDong.TabIndex = 28;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThayDoi.Location = new System.Drawing.Point(260, 407);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(81, 41);
            this.btnThayDoi.TabIndex = 27;
            this.btnThayDoi.Text = "Thay đổi";
            this.btnThayDoi.UseVisualStyleBackColor = true;
            this.btnThayDoi.Click += new System.EventHandler(this.btnThayDoi_Click);
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.tabProfile);
            this.tabDashboard.Controls.Add(this.tabQuanLy);
            this.tabDashboard.Controls.Add(this.tabChamCong);
            this.tabDashboard.Location = new System.Drawing.Point(5, 12);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.SelectedIndex = 0;
            this.tabDashboard.Size = new System.Drawing.Size(626, 480);
            this.tabDashboard.TabIndex = 0;
            // 
            // cbxUser
            // 
            this.cbxUser.FormattingEnabled = true;
            this.cbxUser.Location = new System.Drawing.Point(147, 69);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(223, 22);
            this.cbxUser.TabIndex = 32;
            this.cbxUser.SelectedIndexChanged += new System.EventHandler(this.cbxUser_SelectedIndexChanged);
            this.cbxUser.Click += new System.EventHandler(this.cbxUser_Click);
            this.cbxUser.Leave += new System.EventHandler(this.cbxUser_Leave);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 494);
            this.Controls.Add(this.tabDashboard);
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.tabQuanLy.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.tabProfile.ResumeLayout(false);
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            this.tabDashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabChamCong;
        private System.Windows.Forms.TabPage tabQuanLy;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThayDoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TabControl tabDashboard;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtUser1;
        private System.Windows.Forms.TextBox txtHoten1;
        private System.Windows.Forms.TextBox txtChucVu1;
        private System.Windows.Forms.TextBox txtPhongBan1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTimKiem1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxGioiTinh;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnTimKiem2;
        private System.Windows.Forms.TextBox txtDienThoai2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtHoten2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUser2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cbxUser;

    }
}