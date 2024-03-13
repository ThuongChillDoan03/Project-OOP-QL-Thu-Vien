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

namespace PROJECT_CK_20231
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private MySqlConnection tao_connetion()
        {
            string server = "localhost";
            string database = "data_oop";
            string uid = "root";
            string password = "24112003";

            string constring = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + password;
            MySqlConnection connection = new MySqlConnection(constring);
            return connection;
        }

        private void vbB_Xacnhan_Click(object sender, EventArgs e)
        {
            string taikhoan = tex_NhapTK.Text;
            string matkhau = tex_NhapMK.Text;
            string nhaplai = tex_XacnhanMK.Text;

            MySqlConnection connection = tao_connetion();
            connection.Open();
            string queryk = "SELECT * FROM `user` WHERE  `Account` = @taikhoan"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
            MySqlCommand cmdk = new MySqlCommand(queryk, connection);
            cmdk.Parameters.AddWithValue("@taikhoan", taikhoan);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapterk = new MySqlDataAdapter(cmdk);
            DataTable dataTablek = new DataTable();
            adapterk.Fill(dataTablek);
            int rowCount = dataTablek.Rows.Count;

            if (rowCount != 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại!!!");
            }

            if (matkhau == nhaplai && matkhau != "" && nhaplai != "" && rowCount == 0)
            {

                string insertQuery = "INSERT INTO `user` (Account, Password) VALUES (@taikhoan, @matkhau)";
                MySqlCommand insertQuerycmd = new MySqlCommand(insertQuery, connection);
                insertQuerycmd.Parameters.AddWithValue("@taikhoan", taikhoan);
                insertQuerycmd.Parameters.AddWithValue("@matkhau", matkhau);
                insertQuerycmd.ExecuteNonQuery();
                MessageBox.Show("Đăng kí thành công!!!");
            }
            
            if (matkhau != nhaplai && matkhau != "" && nhaplai != "" )
            {
                MessageBox.Show("Mật khẩu xác nhận không chính xác!!!");
            }
        }
    }
}


