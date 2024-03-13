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
    public partial class FormSuaQuanLyMuonSach : Form
    {
        public FormSuaQuanLyMuonSach()
        {
            InitializeComponent();
            this.AcceptButton = btnCapNhatQLMS;
            this.AcceptButton = btnHuyQLMS;
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
        private void btnCapNhatQLMS_Click(object sender, EventArgs e)
        {
            string MaBillMuon = txtMaBillMuon.Text.Trim(); // Lấy dữ liệu từ TextBox
            DateTime NgayMuon1 = dateNgayMuon.Value;
            string NgayMuon = NgayMuon1.ToString("yyyy-MM-dd");
            string MaDocGia = txtMaDocGiaQLMS.Text.Trim();
            string MaSach = txtMaSachQLMS.Text.Trim();
            string MaThe = txtMaTheQLMS.Text.Trim();
            string TenDocGia = txtTenDocGia.Text.Trim();


            MySqlConnection connection = tao_connetion();
            connection.Open();
            string UpdateQuery = "update Borrow_Bill set Borrow_Bill_Date = @NgayMuon, Reader_Name = @TenDocGia where Borrow_Bill_ID = @MaBillMuon and Book_ID = @MaSach and Reader_ID = @MaDocGia and CardReader_ID = @MaThe";
            MySqlCommand UpdateCmd = new MySqlCommand(UpdateQuery, connection);
            UpdateCmd.Parameters.AddWithValue("@MaBillMuon", MaBillMuon);
            UpdateCmd.Parameters.AddWithValue("@NgayMuon", NgayMuon);
            UpdateCmd.Parameters.AddWithValue("@MaDocGia", MaDocGia);
            UpdateCmd.Parameters.AddWithValue("@MaSach", MaSach);
            UpdateCmd.Parameters.AddWithValue("@MaThe", MaThe);
            UpdateCmd.Parameters.AddWithValue("@TenDocGia", TenDocGia);
            UpdateCmd.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }

        private void btnHuyQLMS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormSuaQuanLyMuonSach_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtMaSachQLMS_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
