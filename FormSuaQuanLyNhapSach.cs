using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class FormSuaQuanLyNhapSach : Form
    {
        public FormSuaQuanLyNhapSach()
        {
            InitializeComponent();
            this.AcceptButton = btnCapNhatQLNS;
            this.AcceptButton = btnHuyQLNS;
        }
        public MySqlConnection tao_connetion()
        {
            string server = "localhost";
            string database = "oop";
            string uid = "root";
            string password = "123456";

            string constring = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + password;
            MySqlConnection connection = new MySqlConnection(constring);
            return connection;
        }

        private void btnCapNhatQLNS_Click(object sender, EventArgs e)
        {
            string MaBillNhap = txtMaBillNhap.Text.Trim();
            DateTime NgayNhap1 = dtpNgayNhap.Value;
            string NgayNhap = NgayNhap1.ToString("yyyy-MM-dd");
            string MaNhanVien = txtMaNhanVienQLNS.Text.Trim();
            string MaSach = txtMaSachQLNS.Text.Trim();


            MySqlConnection connection = tao_connetion();
            connection.Open();
            string UpdateQuery = "update Import_Bill set Import_Bill_Date = @NgayNhap where Import_Bill_ID = @MaBillNhap and Staff_ID = @MaNhanVien and Book_ID = @MaSach";
            MySqlCommand UpdateCmd = new MySqlCommand(UpdateQuery, connection);
            UpdateCmd.Parameters.AddWithValue("@MaBillNhap", MaBillNhap);
            UpdateCmd.Parameters.AddWithValue("@NgayNhap", NgayNhap);
            UpdateCmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            UpdateCmd.Parameters.AddWithValue("@MaSach", MaSach);
            UpdateCmd.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }

        private void btnHuyQLNS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
