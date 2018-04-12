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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           SqlConnection sqlcn = new SqlConnection(@"Data Source =.; Initial Catalog = dbChamCong;  Integrated Security = True;");
            string query = "select * from tbChamCong_DangNhap where UserName = '" + txtUser.Text.Trim() +"' and Password = '" + txtPassword.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                FrmDashboard dashboard = new FrmDashboard();
                this.Hide();
                dashboard.ShowDialog();
                this.Close();
            }
            else 
            {
                MessageBox.Show("user hoặc mặt khẩu không đúng!");
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

        private void FrmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain main = new FrmMain();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }
    }
}
