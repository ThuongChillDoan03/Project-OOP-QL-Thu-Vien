using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class FormThongTinSach : Form
    {
        public FormThongTinSach()
        {
            InitializeComponent();
            this.AcceptButton = btnCapNhatTTS;
            this.AcceptButton = btnHuyNTTS;
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

        private void FormQuanLyNhapSach_Load(object sender, EventArgs e)
        {

        }

        private void btnCapNhatTTS_Click(object sender, EventArgs e)
        {
            string BookID = txtBookID.Text.Trim(); // Lấy dữ liệu từ TextBox
            string BookName = txtBookName.Text.Trim();
            string BookAu = txtBookAu.Text.Trim();
            string BookCate = txtBookCate.Text.Trim();
            string BookLanguage = txtBookLanguage.Text.Trim();
            string BookURL = txtBookURL.Text.Trim();
            string BookStatus = txtBookStatus.Text.Trim();
            MySqlConnection connection = tao_connetion();
            connection.Open();
            string insertQuery = "INSERT INTO book (Book_ID, Book_Category, Book_Au, Book_Name, Book_Language, Book_UrlImageLink, Book_Status) VALUES (@BookID, @BookCate, @BookAu, @BookName, @BookLanguage, @BookURL, @BookStatus)";
            MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
            insertCmd.Parameters.AddWithValue("@BookID", BookID);
            insertCmd.Parameters.AddWithValue("@BookName", BookName);
            insertCmd.Parameters.AddWithValue("@BookAu", BookAu);
            insertCmd.Parameters.AddWithValue("@BookCate", BookCate);
            insertCmd.Parameters.AddWithValue("@BookLanguage", BookLanguage);
            insertCmd.Parameters.AddWithValue("@BookURL", BookURL);
            insertCmd.Parameters.AddWithValue("@BookStatus", BookStatus);
            insertCmd.ExecuteNonQuery();
            connection.Close();
            this.Close();
        }

        private void btnHuyNTTS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
