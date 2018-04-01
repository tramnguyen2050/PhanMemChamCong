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
        SqlCommand cmd = null;
        DataTable table;
        SqlDataAdapter da;
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            cnStr = "Server = .; Database = dbChamCong; Integrated security = true;";
            cn = new SqlConnection();
            cn.ConnectionString = cnStr;

            string query = "SELECT * FROM  tbChamCong_NhanVien_Fulltime ";
            cmd = new SqlCommand(query, cn);

            try
            {
                cn.Open();
                MessageBox.Show("DB Connected");
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        this.txtUser.Text = (reader["MaNVFT"].ToString());
                        this.txtHoten.Text = (reader["HoTen"].ToString());
                        this.dtpNgaySinh.Text = (reader["NgaySinh"].ToString());
                        this.cbxGioiTinh.Text = (reader["GioiTinh"].ToString());
                        this.txtSdt.Text = (reader["DienThoai"].ToString());
                        this.txtDiaChi.Text = (reader["DiaChi"].ToString());
                    }
                    reader.Close();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }      
        
            pnlProfile.Enabled= false; // ẩn profile
            
        }

        private void tabProfile_Click(object sender, EventArgs e)
        {
          
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            pnlProfile.Enabled = true;
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
                cmd.Parameters.Add(new SqlParameter("@user", txtUser.Text));
                cmd.Parameters.Add(new SqlParameter("@hoten", txtHoten.Text));
                cmd.Parameters.Add(new SqlParameter("@gioitinh", cbxGioiTinh.Text));
                cmd.Parameters.Add(new SqlParameter("@ngaysinh", Convert.ToDateTime(dtpNgaySinh.Text)));
                cmd.Parameters.Add(new SqlParameter("@dienthoai", txtSdt.Text));
                cmd.Parameters.Add(new SqlParameter("@diachi", txtDiaChi.Text));            
                cmd.ExecuteNonQuery();
	        }
            catch (Exception ex)
	        {
                MessageBox.Show(ex.Message);
	        }
            finally  {
                cn.Close();
                    }
            MessageBox.Show("Đã lưu");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem1_Click(object sender, EventArgs e)
        {
           // cn.Open();
            cmd.CommandText = "uspSearchNhanVien";
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);
            table = new DataTable();
            da.Fill(table);
            dgvNhanVien.DataSource = table;
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
    }   
}
