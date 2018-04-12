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
    public partial class FrmDangKy : Form
    {
        string cnStr;
        SqlConnection cn;
        SqlCommand cmd = new SqlCommand();
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {
            cnStr = @"Data Source =.; Initial Catalog = dbChamCong;  Integrated Security = True;";
            cmd.CommandText = "select UserName , Password from tbChamCong_DangNhap";

        }
        private void Connect()
        {
            if (cn != null && cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
        }
        private void Disconnect()
        {
            if (cn == null && cn.State != ConnectionState.Closed)
            {
                cn.Close();
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Connect();
            try
            {
                cn = new SqlConnection(cnStr);
                cn.Open();
                cmd = new SqlCommand("uspDangNhap", cn);
                if (txtXNpass.Text == txtPassword.Text && txtPassword.Text != null && txtXNpass.Text != null)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = cn;
                    cmd.Parameters.AddWithValue("@UserName", txtUser.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ĐĂNG KÝ THÀNH CÔNG", "thong bao");
                    FrmDangNhap dangnhap = new FrmDangNhap();
                    this.Hide();
                    dangnhap.ShowDialog();

                }
                else if (txtXNpass.Text != txtPassword.Text || txtPassword.Text == null || txtXNpass.Text == null)
                {
                    MessageBox.Show("nhập đúng mật khẩu và không bỏ trống");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            finally
            {
                Disconnect();
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            FrmMain log = new FrmMain();
            this.Hide();
            log.ShowDialog();
            this.Close();
        }

        private void lblGhiChu_Click(object sender, EventArgs e)
        {

        }

        private void FrmDangKy_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain main = new FrmMain();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }
    }
}
