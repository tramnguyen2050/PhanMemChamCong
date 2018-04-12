using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhanMemChamCong
{
    public partial class FrmDashboard : Form
    {
        string cnStr = "";
        SqlConnection cn;
        SqlCommand cmd ;
        DataTable table;
        SqlDataAdapter da;
        SqlDataReader reader;
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            cnStr = "Server = .; Database = dbChamCong; Integrated security = true;";
            cn = new SqlConnection();
            cn.ConnectionString = cnStr;
            cbxUser.Enabled = false; //an
            btnLuu.Enabled = false;  //an
        }

        private void tabProfile_Click(object sender, EventArgs e)
        {
          
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true; // hien button
            cbxUser.Enabled = true;// hien textbox
            txtHoten.Text = string.Empty;
            cbxGioiTinh.Text = string.Empty;
            dtpNgaySinh.Text = string.Empty;
            txtSdt.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            string query = "select * from tbChamCong_NhanVien_Fulltime";// where MaNVFT = " + cbxUser.SelectedItem + "";
            cmd = new SqlCommand(query, cn);
            try
            {
                cn.Open();
                da = new SqlDataAdapter(query, cn);
                table = new DataTable();
                da.Fill(table);              
                cbxUser.DataSource = table;
                cbxUser.DisplayMember = "MaNVFT";
                cbxUser.ValueMember = "MaNVFT";                          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            finally
            {
                cn.Close();
            }          
        }

      

        private string cbxUser_SelectedIndexChanged()
        {
           throw new NotImplementedException();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {         //  update Profile      
            cn.Open();
            try 
	        {               
                cmd = new SqlCommand();
                cmd.CommandText = "uspInsertProfile";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;               
                //cmd.Parameters.Add(new SqlParameter("@user", txtUser.Text));       
                cmd.Parameters.Add(new SqlParameter("@hoten", txtHoten.Text));
                cmd.Parameters.Add(new SqlParameter("@gioitinh",KieuGioiTinh()));              
                cmd.Parameters.Add(new SqlParameter("@ngaysinh", Convert.ToString(dtpNgaySinh.Text)));
                cmd.Parameters.Add(new SqlParameter("@dienthoai", Convert.ToString(txtSdt.Text)));
                cmd.Parameters.Add(new SqlParameter("@diachi", txtDiaChi.Text));            
                cmd.ExecuteNonQuery();
	        }
            catch (Exception ex)
	        {
                MessageBox.Show(ex.Message);
	        }
            finally 
            {
                cn.Close();
            }
            MessageBox.Show("Đã lưu");
        }
       
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Boolean KieuGioiTinh()
        {
            if (cbxGioiTinh.Text == "Nữ")
                return true;
            else
                return false;
        }
        private void btnTimKiem1_Click(object sender, EventArgs e)
        { // tim kiem bang cach noi chuoi
            cn.Open();
            dgvNhanVien.Refresh();
            cmd.Parameters.Clear(); 
            var sql = new StringBuilder("select nv.MaNVFT,nv.HoTen,nv.GioiTinh,nv.NgaySinh,nv.DienThoai,nv.DiaChi,cv.TenChucVu,pb.TenPhongBan from tbChamCong_NhanVien_Fulltime_ChiTiet ct inner join tbChamCong_NhanVien_Fulltime nv on nv.MaNVFT = ct.MaNVFT inner join tbChamCong_PhongBan pb on pb.MaPB = ct.MaPB inner join tbChamCong_ChucVu cv on cv.MaCV = ct.MaCV ");
            if (!string.IsNullOrEmpty(txtUser1.Text)) 
                sql.Append("where nv.MaNVFT = " + txtUser1.Text + "");          
            if (!string.IsNullOrEmpty(txtHoten1.Text))           
                sql.Append("or HoTen like '%" + txtHoten1.Text + "%'");            
            if (!string.IsNullOrEmpty(txtChucVu1.Text))         
                sql.Append("or TenChucVu like '%" + txtChucVu1.Text + "%'");            
            if (!string.IsNullOrEmpty(txtPhongBan1.Text))          
                sql.Append("or TenPhongBan like '%" + txtPhongBan1.Text + "%'");
            try
            {                
                    da = new SqlDataAdapter(sql.ToString(), cn);
                    table = new DataTable();
                    da.Fill(table);                 
                    dgvNhanVien.DataSource = table;               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               
                cn.Close();
            }
        }

        private void tabQuanLy_Click(object sender, EventArgs e)
        {
          
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnTimKiem2_Click(object sender, EventArgs e)
        {
            cn.Open();
            dgvNhanVien.Refresh();
           /// cmd.Parameters.Clear();
            var sql1 = new StringBuilder("select * from tbChamCong_NhanVien_Parttime where");
            if (!string.IsNullOrEmpty(txtUser2.Text))
                sql1.Append("(MaNVPT =" + txtUser2.Text +"or '" + txtUser2 + "'is null)");
            if (!string.IsNullOrEmpty(txtHoten2.Text))
                sql1.Append("or ((HoTen like '%' + is null('" +txtHoten2.Text +"',HoTen)+ '%') or '" + txtHoten2.Text +"' is null)");                           
            if (!string.IsNullOrEmpty(txtDienThoai2.Text))
                sql1.Append("or ((DienThoai like'%'+is null('" + txtDienThoai2.Text + "',DienThoai)+ '%')or '" +txtDienThoai2 +"' is null)");
            try
            {
                    da = new SqlDataAdapter(sql1.ToString(), cn);
                    table = new DataTable();
                    da.Fill(table);
                    dgvNhanVien.DataSource = table;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                cn.Close();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void cbxUser_Click(object sender, EventArgs e)
        {
            cbxUser.DroppedDown = true;
        }

        private void cbxUser_Leave(object sender, EventArgs e)
        {
            cbxUser.DroppedDown = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "uspUpdateProfile";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@user", cbxUser.Text));       
                cmd.Parameters.Add(new SqlParameter("@hoten", txtHoten.Text));
                cmd.Parameters.Add(new SqlParameter("@gioitinh", KieuGioiTinh()));
                cmd.Parameters.Add(new SqlParameter("@ngaysinh", Convert.ToString(dtpNgaySinh.Text)));
                cmd.Parameters.Add(new SqlParameter("@dienthoai", Convert.ToString(txtSdt.Text)));
                cmd.Parameters.Add(new SqlParameter("@diachi", txtDiaChi.Text));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            MessageBox.Show("Đã lưu");
        }

        private void cbxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnStr = "Server = .; Database = dbChamCong; Integrated security = true;";
            cn = new SqlConnection();
            cn.ConnectionString = cnStr;
            try
            {
                string query1 = "select * from tbChamCong_NhanVien_Fulltime where MaNVFT = '" + cbxUser.Text + "'";
                cmd = new SqlCommand(query1, cn);
                cmd.Connection = cn;
                cn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtHoten.Text = (string)reader["HoTen"].ToString();
                    dtpNgaySinh.Text = (string)reader["NgaySinh"].ToString();
                    string name = (string)reader["GioiTinh"].ToString();
                    name = Convert.ToString(KieuGioiTinh());
                    txtSdt.Text = (string)reader["DienThoai"].ToString();
                    txtDiaChi.Text = (string)reader["DiaChi"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            finally
            {
                cn.Close();
            }
        }       
    }   
}
