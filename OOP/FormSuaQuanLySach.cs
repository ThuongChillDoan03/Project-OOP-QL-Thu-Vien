using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
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
    public partial class FormSuaQuanLySach : Form
    {
        public FormSuaQuanLySach()
        {
            InitializeComponent();
            this.AcceptButton = btnCapNhat;
            this.AcceptButton = btnHuyCapNhat;
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
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string MaSach = txtCapNhatBookID.Text.Trim();
            string TheLoai = txtCapNhatBookCategory.Text.Trim();
            string TacGia = txtCapNhatBookAu.Text.Trim();
            string TenSach = txtCapNhatBookName.Text.Trim();
            string NgonNgu = txtCapNhatBookLanguage.Text.Trim();
            string TinhTrang = txtCapNhatBookStatus.Text.Trim();
            string LinkURL = txtCapNhatBookURL.Text.Trim();

            MySqlConnection connection = tao_connetion();
            connection.Open();
            string UpdateQuery = "update book set Book_Category = @TheLoai, Book_Au = @TacGia, Book_Name = @TenSach, Book_Language = @NgonNgu, Book_UrlImageLink = @LinkURL, Book_Status = @TinhTrang where Book_ID = @MaSach";
            MySqlCommand UpdateCmd = new MySqlCommand(UpdateQuery, connection);
            UpdateCmd.Parameters.AddWithValue("@MaSach", MaSach);
            UpdateCmd.Parameters.AddWithValue("@TheLoai", TheLoai);
            UpdateCmd.Parameters.AddWithValue("@TacGia", TacGia);
            UpdateCmd.Parameters.AddWithValue("@TenSach", TenSach);
            UpdateCmd.Parameters.AddWithValue("@NgonNgu", NgonNgu);
            UpdateCmd.Parameters.AddWithValue("@LinkURL", LinkURL);
            UpdateCmd.Parameters.AddWithValue("@TinhTrang", TinhTrang);
            UpdateCmd.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }
        private void btnHuyCapNhat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        
    }
}
