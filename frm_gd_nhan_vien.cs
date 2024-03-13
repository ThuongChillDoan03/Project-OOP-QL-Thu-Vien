using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;


namespace PROJECT_CK_20231
{
    public partial class Frm_qlsach : Form
    {
        public Frm_qlsach()
        {
            InitializeComponent();
            LoadDataIntoDgvQuanLySach();
            LoadDataIntoDgvQuanLyTheDoc();
            LoadDataIntoDgvQuanLyNhapSach();
            LoadDataIntoDgvQuanLyMuonSach();
            LoadDataIntoDgvDanhGia();

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


        private void LoadDataIntoDgvQuanLySach()
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();
            string query = "SELECT * FROM `table books`";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dGV_qlsach.DataSource = dataTable;       
        }

        private void LoadDataIntoDgvDanhGia()
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();
            string query = "SELECT * FROM `rating`";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dGV_Danhgia.DataSource = dataTable;
        }

        private void LoadDataIntoDgvQuanLyTheDoc()
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();
            string query = "SELECT * FROM cardreader";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dGV_qlthedoc.DataSource = dataTable;
            connection.Close();
        }

        private void LoadDataIntoDgvQuanLyNhapSach()
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();
            string query = "SELECT * FROM `bill nhập`";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dGV_qlnhapsach.DataSource = dataTable;
            connection.Close();
        }


        private void LoadDataIntoDgvQuanLyMuonSach()
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();
            string query = "SELECT * FROM `bill mượn`";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dGV_qlmuonsach.DataSource = dataTable;
            connection.Close();
        }


















        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void dGV_qlsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void vbButton6_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string mathedoc = tex_thedoc.Text;
            string tendocgia = tex_tendocgia.Text;

            //________________________________//
            string queryp = "SELECT * FROM `cardreader` WHERE  `Mã thẻ đọc` = @mathedoc";
            MySqlCommand cmdp = new MySqlCommand(queryp, connection);
            cmdp.Parameters.AddWithValue("@mathedoc", mathedoc);
            MySqlDataAdapter adapterp = new MySqlDataAdapter(cmdp);
            DataTable dataTablep = new DataTable();
            adapterp.Fill(dataTablep);


            dGV_qlthedoc.DataSource = dataTablep;

        }

        private void vbButton4_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string masach = tex_masach1.Text;
            string queryp = "SELECT * FROM `table books` WHERE  `Mã sách` = @masach";
            MySqlCommand cmdp = new MySqlCommand(queryp, connection);
            cmdp.Parameters.AddWithValue("@masach", masach);
            MySqlDataAdapter adapterp = new MySqlDataAdapter(cmdp);
            DataTable dataTablep = new DataTable();
            adapterp.Fill(dataTablep);
            int rowCount = dataTablep.Rows.Count;
            if (rowCount > 0)
            {
                Quanlysach.SelectedIndex = 6;
            }
            if (rowCount == 0)
            {
                MessageBox.Show("Không tồn tại mã nhập sách");
            }
        }

        private void Quanlysach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void vbButton8_Click(object sender, EventArgs e)
        {
            //______________________________________________UPDATE________________________________//

            MySqlConnection connection = tao_connetion();
            connection.Open();

            DateTime selectedDateTime = date_ngaysinh.Value;
            string ngaysinh = selectedDateTime.ToString("dd/MM/yyyy");
            string mathedoc = tex_thedoc.Text;
            string tendocgia = tex_tendocgia.Text;
            string madocgia = tex_madocgia1.Text;
           

            string queryp = "SELECT * FROM `cardreader` WHERE  `Mã độc giả` = @madocgia"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
            MySqlCommand cmdp = new MySqlCommand(queryp, connection);
            cmdp.Parameters.AddWithValue("@madocgia", madocgia);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapterp = new MySqlDataAdapter(cmdp);
            DataTable dataTablep = new DataTable();
            adapterp.Fill(dataTablep);
            int rowCount = dataTablep.Rows.Count;

            if (rowCount == 0)
            {
                string insertQuery = "INSERT INTO `cardreader` (`Mã độc giả`, `Tên độc giả`, `Mã thẻ đọc`, `Ngày sinh`) VALUES (@madocgia, @tendocgia, @mathedoc, @ngaysinh)";
                MySqlCommand insertQuerycmd = new MySqlCommand(insertQuery, connection);
                insertQuerycmd.Parameters.AddWithValue("@madocgia", madocgia);
                insertQuerycmd.Parameters.AddWithValue("@tendocgia", tendocgia);
                insertQuerycmd.Parameters.AddWithValue("@mathedoc", mathedoc);
                insertQuerycmd.Parameters.AddWithValue("@ngaysinh", ngaysinh); // Thay 'ten_nguoidung' bằng tên người dùng 
                insertQuerycmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thẻ đọc thành công");
            }
            else
            {
                MessageBox.Show("Người dùng đã có thẻ bạn đọc! Vui lòng kiểm tra lại!");
            }

            //_________________________________________Cập nhật lại DTG_____________________________________//
            LoadDataIntoDgvQuanLyTheDoc();
        }

        private void vbButton7_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string thedoc = tex_thedoc.Text;
            string queryp = "SELECT * FROM `cardreader` WHERE  `Mã thẻ đọc` = @thedoc";
            MySqlCommand cmdp = new MySqlCommand(queryp, connection);
            cmdp.Parameters.AddWithValue("@thedoc", thedoc);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapterp = new MySqlDataAdapter(cmdp);
            DataTable dataTablep = new DataTable();
            adapterp.Fill(dataTablep);
            int rowCount = dataTablep.Rows.Count;

            if (rowCount > 0)
            {
                string deletequery = "DELETE FROM `cardreader` WHERE `Mã thẻ đọc` = @thedoc";
                MySqlCommand cmdd = new MySqlCommand(deletequery, connection);
                cmdd.Parameters.AddWithValue("@thedoc", thedoc);
                cmdd.ExecuteNonQuery();
                MessageBox.Show("Đã xóa hóa đơn nhập sách");
            }
            else
            {
                MessageBox.Show("Mã sách không tồn tại trong kho nhập! Không thể xóa");

            }
            //_________________________________________Cập nhật lại DTG_____________________________________//
            LoadDataIntoDgvQuanLyTheDoc();
        }

        private void vbButton5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dGV_qlthedoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void qlsach_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            //______________________________________________UPDATE________________________________//

            MySqlConnection connection = tao_connetion();
            connection.Open();

            string masach = tex_masach1.Text;
            string theloai = tex_theloai1.Text;
            string tacgia = tex_tacgia1.Text;
            string tensach = tex_tensach1.Text;

            string queryp = "SELECT * FROM `table books` WHERE  `Mã sách` = @masach"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
            MySqlCommand cmdp = new MySqlCommand(queryp, connection);
            cmdp.Parameters.AddWithValue("@masach", masach);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapterp = new MySqlDataAdapter(cmdp);
            DataTable dataTablep = new DataTable();
            adapterp.Fill(dataTablep);
            int rowCount = dataTablep.Rows.Count;

            if (rowCount == 0)
            {
                string insertQuery = "INSERT INTO `table books` (`Mã sách`, `Thể loại`, `Tên tác giả`, `Tên sách`) VALUES (@masach, @theloai, @tacgia, @tensach)";
                MySqlCommand insertQuerycmd = new MySqlCommand(insertQuery, connection);
                insertQuerycmd.Parameters.AddWithValue("@masach", masach);
                insertQuerycmd.Parameters.AddWithValue("@theloai", theloai);
                insertQuerycmd.Parameters.AddWithValue("@tacgia", tacgia);
                insertQuerycmd.Parameters.AddWithValue("@tensach", tensach); // Thay 'ten_nguoidung' bằng tên người dùng
                insertQuerycmd.ExecuteNonQuery();
                MessageBox.Show("Thêm đơn mượn thành công");
            }
            else
            {
                MessageBox.Show("Mã mượn đã tồn tại! Vui lòng kiểm tra lại!");
            }

            //_________________________________________Cập nhật lại DTG_____________________________________//
            LoadDataIntoDgvQuanLySach();
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string masach = tex_masach1.Text;
            string queryp = "SELECT * FROM `table books` WHERE  `Mã sách` = @masach";
            MySqlCommand cmdp = new MySqlCommand(queryp, connection);
            cmdp.Parameters.AddWithValue("@masach", masach);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapterp = new MySqlDataAdapter(cmdp);
            DataTable dataTablep = new DataTable();
            adapterp.Fill(dataTablep);
            int rowCount = dataTablep.Rows.Count;

            if (rowCount > 0)
            {
                string deletequery = "DELETE FROM `table books` WHERE `Mã sách` = @masach";
                MySqlCommand cmdd = new MySqlCommand(deletequery, connection);
                cmdd.Parameters.AddWithValue("@masach", masach);
                cmdd.ExecuteNonQuery();
                MessageBox.Show("Đã xóa hóa đơn nhập sách");
            }
            else
            {
                MessageBox.Show("Mã sách không tồn tại trong kho nhập! Không thể xóa");

            }
            //_________________________________________Cập nhật lại DTG_____________________________________//
            LoadDataIntoDgvQuanLyNhapSach();

        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string tensach = tex_tensach1.Text;
            string theloai = tex_theloai1.Text;
            string tacgia = tex_tacgia1.Text;

            //________________________________//
            string queryp = "SELECT * FROM `table books` WHERE  `Tên sách` = @tensach";
            MySqlCommand cmdp = new MySqlCommand(queryp, connection);
            cmdp.Parameters.AddWithValue("@tensach", tensach);
            MySqlDataAdapter adapterp = new MySqlDataAdapter(cmdp);
            DataTable dataTablep = new DataTable();
            adapterp.Fill(dataTablep);


            string query1 = "SELECT * FROM `table books` WHERE  `Thể loại` = @theloai";
            MySqlCommand cmd1 = new MySqlCommand(query1, connection);
            cmd1.Parameters.AddWithValue("@theloai", theloai);
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);
            DataTable dataTable1 = new DataTable();
            adapter1.Fill(dataTable1);
            
            string query2 = "SELECT * FROM `table books` WHERE  `Tên tác giả` = @tacgia";
            MySqlCommand cmd2 = new MySqlCommand(query2, connection);
            cmd2.Parameters.AddWithValue("@tacgia", tacgia);
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2);
            DataTable dataTable2 = new DataTable();
            adapter2.Fill(dataTable2);

            if (tensach != "")
            {
                dGV_qlsach.DataSource = dataTablep;
            }
            if (theloai != "")
            {
                dGV_qlsach.DataSource = dataTable1;
            }
            if (tacgia != "")
            {
                dGV_qlsach.DataSource = dataTable2;
            }

        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void vbButton12_Click(object sender, EventArgs e)
        {
            //______________________________________________UPDATE________________________________//

            MySqlConnection connection = tao_connetion();
            connection.Open();

            DateTime currentTime = DateTime.Now;
            string ngaynhap = currentTime.ToString("dd/MM/yyyy HH:mm:ss");
            string manhap = tex_manhap.Text;
            //string ngaynhap = tex_ngaynhap.Text;
            string manhanvien = tex_manhanvien.Text;
            string masach = tex_masach.Text;

            string queryp = "SELECT * FROM `bill nhập` WHERE  `Mã nhập` = @manhap"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
            MySqlCommand cmdp = new MySqlCommand(queryp, connection);
            cmdp.Parameters.AddWithValue("@manhap", manhap);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapterp = new MySqlDataAdapter(cmdp);
            DataTable dataTablep = new DataTable();
            adapterp.Fill(dataTablep);
            int rowCount = dataTablep.Rows.Count;

            if (rowCount == 0)
            {
                string insertQuery = "INSERT INTO `bill nhập` (`Mã nhập`, `Mã sách`, `Mã nhân viên`, `Ngày nhập sách`) VALUES (@manhap, @masach, @manhanvien, @ngaynhap)";
                MySqlCommand insertQuerycmd = new MySqlCommand(insertQuery, connection);
                insertQuerycmd.Parameters.AddWithValue("@manhap", manhap);
                insertQuerycmd.Parameters.AddWithValue("@ngaynhap", ngaynhap);
                insertQuerycmd.Parameters.AddWithValue("@manhanvien", manhanvien);
                insertQuerycmd.Parameters.AddWithValue("@masach", masach); // Thay 'ten_nguoidung' bằng tên người dùng
                insertQuerycmd.ExecuteNonQuery();
                MessageBox.Show("Thêm sách thành công");
            }
            else
            {
                MessageBox.Show("Mã nhập đã tồn tại! Vui lòng kiểm tra lại!");
            }

            //_________________________________________Cập nhật lại DTG_____________________________________//
            LoadDataIntoDgvQuanLyNhapSach();


        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void vbButton11_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string manhapsach = tex_manhap.Text;
            string queryp = "SELECT * FROM `bill nhập` WHERE  `Mã nhập` = @manhapsach";
            MySqlCommand cmdp = new MySqlCommand(queryp, connection);
            cmdp.Parameters.AddWithValue("@manhapsach", manhapsach);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapterp = new MySqlDataAdapter(cmdp);
            DataTable dataTablep = new DataTable();
            adapterp.Fill(dataTablep);
            int rowCount = dataTablep.Rows.Count;

            if (rowCount > 0)
            {
                string deletequery = "DELETE FROM `bill nhập` WHERE `Mã nhập` = @manhapsach";
                MySqlCommand cmdd = new MySqlCommand(deletequery, connection);
                cmdd.Parameters.AddWithValue("@manhapsach", manhapsach);
                cmdd.ExecuteNonQuery();
                MessageBox.Show("Đã xóa hóa đơn nhập sách");
            }
            else
            {
                MessageBox.Show("Mã sách không tồn tại trong kho nhập! Không thể xóa");

            }
            //_________________________________________Cập nhật lại DTG_____________________________________//
            LoadDataIntoDgvQuanLyNhapSach();

        }

        private void vbButton10_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string manhapsach = tex_manhap.Text;
            string masach = tex_masach.Text;
            string manhanvien = tex_manhanvien.Text;

            //________________________________//
            string queryp = "SELECT * FROM `bill nhập` WHERE  `Mã nhập` = @manhapsach";
            MySqlCommand cmdp = new MySqlCommand(queryp, connection);
            cmdp.Parameters.AddWithValue("@manhapsach", manhapsach);
            MySqlDataAdapter adapterp = new MySqlDataAdapter(cmdp);
            DataTable dataTablep = new DataTable();
            adapterp.Fill(dataTablep);

            //________________________________//

            string query1 = "SELECT * FROM `bill nhập` WHERE  `Mã sách` = @masach";
            MySqlCommand cmd1 = new MySqlCommand(query1, connection);
            cmdp.Parameters.AddWithValue("@masach", masach);
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);
            DataTable dataTable1 = new DataTable();
            adapter1.Fill(dataTable1);

            //______________________________________//

            string query2 = "SELECT * FROM `bill nhập` WHERE  `Mã nhân viên` = @manhanvien";
            MySqlCommand cmd2 = new MySqlCommand(query2, connection);
            cmdp.Parameters.AddWithValue("@manhanvien", manhanvien);
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2);
            DataTable dataTable2 = new DataTable();
            adapter2.Fill(dataTable2);

            //_____________________________________//

            string query3 = "SELECT * FROM `bill nhập` WHERE  `Mã nhân viên` = @manhanvien AND `Mã sách` = @masach";
            MySqlCommand cmd3 = new MySqlCommand(query3, connection);
            cmd3.Parameters.AddWithValue("@manhanvien", manhanvien);
            cmd3.Parameters.AddWithValue("@masach", masach);
            MySqlDataAdapter adapter3 = new MySqlDataAdapter(cmd3);
            DataTable dataTable3 = new DataTable();
            adapter3.Fill(dataTable3);

            //_____________________________________//

            string query4 = "SELECT * FROM `bill nhập` WHERE  `Mã nhân viên` = @manhanvien AND `Mã nhập` = @manhapsach";
            MySqlCommand cmd4 = new MySqlCommand(query4, connection);
            cmd4.Parameters.AddWithValue("@manhanvien", manhanvien);
            cmd4.Parameters.AddWithValue("@manhapsach", manhapsach);
            MySqlDataAdapter adapter4 = new MySqlDataAdapter(cmd4);
            DataTable dataTable4 = new DataTable();
            adapter4.Fill(dataTable4);

            //_____________________________________//

            string query5 = "SELECT * FROM `bill nhập` WHERE  `Mã sách` = @masach AND `Mã nhập` = @manhapsach";
            MySqlCommand cmd5 = new MySqlCommand(query5, connection);
            cmd5.Parameters.AddWithValue("@masach", masach);
            cmd5.Parameters.AddWithValue("@manhapsach", manhapsach);
            MySqlDataAdapter adapter5 = new MySqlDataAdapter(cmd5);
            DataTable dataTable5 = new DataTable();
            adapter5.Fill(dataTable5);

            //_____________________________________//

            string query6 = "SELECT * FROM `bill nhập` WHERE `Mã nhân viên` = @manhanvien AND `Mã sách` = @masach AND `Mã nhập` = @manhapsach";
            MySqlCommand cmd6 = new MySqlCommand(query6, connection);
            cmd6.Parameters.AddWithValue("@manhanvien", manhanvien);
            cmd6.Parameters.AddWithValue("@masach", masach);
            cmd6.Parameters.AddWithValue("@manhapsach", manhapsach);
            MySqlDataAdapter adapter6 = new MySqlDataAdapter(cmd6);
            DataTable dataTable6 = new DataTable();
            adapter6.Fill(dataTable6);


            if (manhapsach != "" && masach == "" && manhanvien == "")
            {
                dGV_qlnhapsach.DataSource = dataTablep;
            }
            if (manhapsach == "" && masach != "" && manhanvien == "")
            {
                dGV_qlnhapsach.DataSource = dataTable1;
            }
            if (manhapsach == "" && masach == "" && manhanvien != "")
            {
                dGV_qlnhapsach.DataSource = dataTable2;
            }
            if (manhapsach == "" && masach != "" && manhanvien != "")
            {
                dGV_qlnhapsach.DataSource = dataTable3;
            }
            if (manhapsach != "" && masach == "" && manhanvien != "")
            {
                dGV_qlnhapsach.DataSource = dataTable4;
            }
            if (manhapsach != "" && masach != "" && manhanvien == "")
            {
                dGV_qlnhapsach.DataSource = dataTable5;
            }
            if (manhapsach != "" && masach != "" && manhanvien != "")
            {
                dGV_qlnhapsach.DataSource = dataTable6;
            }

        }

        private void vbButton9_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string manhapsach = tex_manhap.Text;
            string queryp = "SELECT * FROM `bill nhập` WHERE  `Mã nhập` = @manhapsach";
            MySqlCommand cmdp = new MySqlCommand(queryp, connection);
            cmdp.Parameters.AddWithValue("@manhapsach", manhapsach);
            MySqlDataAdapter adapterp = new MySqlDataAdapter(cmdp);
            DataTable dataTablep = new DataTable();
            adapterp.Fill(dataTablep);
            int rowCount = dataTablep.Rows.Count;
            if (rowCount > 0)
            {
                Quanlysach.SelectedIndex = 4;
            }
            if (rowCount == 0)
            {
                MessageBox.Show("Không tồn tại mã nhập sách");
            }


        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void vbButton11_Click_1(object sender, EventArgs e)
        {

            MySqlConnection connection = tao_connetion();
            connection.Open();
            string manhapsach = tex_manhap.Text;
            string masachmoi = tex_doisachnhap.Text;
            string doimanhanvien = tex_doimanv.Text;

            string updatenhapsach = "UPDATE `bill nhập` SET `Mã sách` = @masachmoi WHERE `Mã nhập` = @manhapsach;";
            MySqlCommand updategioCmd = new MySqlCommand(updatenhapsach, connection);
            updategioCmd.Parameters.AddWithValue("@masachmoi", masachmoi);
            updategioCmd.Parameters.AddWithValue("@manhapsach", manhapsach); // Thay 'ten_nguoidung' bằng tên người dùng
            updategioCmd.ExecuteNonQuery();

            string updatenhapsach1 = "UPDATE `bill nhập` SET `Mã nhân viên` = @doimanhanvien WHERE `Mã nhập` = @manhapsach;";
            MySqlCommand updategioCmd1 = new MySqlCommand(updatenhapsach1, connection);
            updategioCmd1.Parameters.AddWithValue("@doimanhanvien", doimanhanvien);
            updategioCmd1.Parameters.AddWithValue("@manhapsach", manhapsach); // Thay 'ten_nguoidung' bằng tên người dùng
            updategioCmd1.ExecuteNonQuery();
            LoadDataIntoDgvQuanLyNhapSach();
            MessageBox.Show("Cập nhật thành công!");
        }

        private void vbButton16_Click(object sender, EventArgs e)
        {
            //______________________________________________UPDATE________________________________//

            MySqlConnection connection = tao_connetion();
            connection.Open();

            DateTime currentTime = DateTime.Now;
            string ngaymuon = currentTime.ToString("dd/MM/yyyy HH:mm:ss");
            string mamuon = text_mamuon.Text;
            //string ngaynhap = tex_ngaynhap.Text;
            string madocgia = tex_madocgia.Text;
            string masach = tex_idsach.Text;

            string queryp = "SELECT * FROM `bill mượn` WHERE  `Mã mượn` = @mamuon"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
            MySqlCommand cmdp = new MySqlCommand(queryp, connection);
            cmdp.Parameters.AddWithValue("@mamuon", mamuon);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapterp = new MySqlDataAdapter(cmdp);
            DataTable dataTablep = new DataTable();
            adapterp.Fill(dataTablep);
            int rowCount = dataTablep.Rows.Count;

            if (rowCount == 0)
            {
                string insertQuery = "INSERT INTO `bill mượn` (`Mã mượn`, `Mã độc giả`, `Mã sách`, `Thời gian mượn`) VALUES (@mamuon, @madocgia, @masach, @ngaymuon)";
                MySqlCommand insertQuerycmd = new MySqlCommand(insertQuery, connection);
                insertQuerycmd.Parameters.AddWithValue("@mamuon", mamuon);
                insertQuerycmd.Parameters.AddWithValue("@madocgia", madocgia);
                insertQuerycmd.Parameters.AddWithValue("@masach", masach);
                insertQuerycmd.Parameters.AddWithValue("@ngaymuon", ngaymuon); // Thay 'ten_nguoidung' bằng tên người dùng
                insertQuerycmd.ExecuteNonQuery();
                MessageBox.Show("Thêm đơn mượn thành công");
            }
            else
            {
                MessageBox.Show("Mã mượn đã tồn tại! Vui lòng kiểm tra lại!");
            }

            //_________________________________________Cập nhật lại DTG_____________________________________//
            LoadDataIntoDgvQuanLyMuonSach();

        }

        private void vbButton15_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string mamuon = text_mamuon.Text;
            string queryp = "SELECT * FROM `bill mượn` WHERE  `Mã mượn` = @mamuon";
            MySqlCommand cmdp = new MySqlCommand(queryp, connection);
            cmdp.Parameters.AddWithValue("@mamuon", mamuon);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapterp = new MySqlDataAdapter(cmdp);
            DataTable dataTablep = new DataTable();
            adapterp.Fill(dataTablep);
            int rowCount = dataTablep.Rows.Count;

            if (rowCount > 0)
            {
                string deletequery = "DELETE FROM `bill mượn` WHERE `Mã mượn` = @mamuon";
                MySqlCommand cmdd = new MySqlCommand(deletequery, connection);
                cmdd.Parameters.AddWithValue("@mamuon", mamuon);
                cmdd.ExecuteNonQuery();
                MessageBox.Show("Đã xóa hóa đơn mượn sách");
            }
            else
            {
                MessageBox.Show("Mã sách không tồn tại trong kho mượn! Không thể xóa");

            }
            //_________________________________________Cập nhật lại DTG_____________________________________//
            LoadDataIntoDgvQuanLyMuonSach();
        }

        private void vbButton14_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string mamuonsach = text_mamuon.Text;
            string masach = tex_idsach.Text;
            string madocgia = tex_madocgia.Text;

            //________________________________//
            string queryp = "SELECT * FROM `bill mượn` WHERE  `Mã mượn` = @mamuonsach";
            MySqlCommand cmdp = new MySqlCommand(queryp, connection);
            cmdp.Parameters.AddWithValue("@mamuonsach", mamuonsach);
            MySqlDataAdapter adapterp = new MySqlDataAdapter(cmdp);
            DataTable dataTablep = new DataTable();
            adapterp.Fill(dataTablep);

            //________________________________//

            string query1 = "SELECT * FROM `bill mượn` WHERE  `Mã sách` = @masach";
            MySqlCommand cmd1 = new MySqlCommand(query1, connection);
            cmdp.Parameters.AddWithValue("@masach", masach);
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);
            DataTable dataTable1 = new DataTable();
            adapter1.Fill(dataTable1);

            //______________________________________//

            string query2 = "SELECT * FROM `bill mượn` WHERE  `Mã độc giả` = @madocgia";
            MySqlCommand cmd2 = new MySqlCommand(query2, connection);
            cmdp.Parameters.AddWithValue("@madocgia", madocgia);
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2);
            DataTable dataTable2 = new DataTable();
            adapter2.Fill(dataTable2);

            //_____________________________________//

            string query3 = "SELECT * FROM `bill nhập` WHERE  `Mã mượn` = @mamuonsach AND `Mã sách` = @masach";
            MySqlCommand cmd3 = new MySqlCommand(query3, connection);
            cmd3.Parameters.AddWithValue("@mamuonsach", mamuonsach);
            cmd3.Parameters.AddWithValue("@masach", masach);
            MySqlDataAdapter adapter3 = new MySqlDataAdapter(cmd3);
            DataTable dataTable3 = new DataTable();
            adapter3.Fill(dataTable3);

            //_____________________________________//

            string query4 = "SELECT * FROM `bill nhập` WHERE  `Mã mượn` = @mamuonsach AND `Mã độc giả` = @madocgia";
            MySqlCommand cmd4 = new MySqlCommand(query4, connection);
            cmd4.Parameters.AddWithValue("@mamuonsach", mamuonsach);
            cmd4.Parameters.AddWithValue("@madocgia", madocgia);
            MySqlDataAdapter adapter4 = new MySqlDataAdapter(cmd4);
            DataTable dataTable4 = new DataTable();
            adapter4.Fill(dataTable4);

            //_____________________________________//

            string query5 = "SELECT * FROM `bill nhập` WHERE  `Mã sách` = @masach AND `Mã độc giả` = @madocgia";
            MySqlCommand cmd5 = new MySqlCommand(query5, connection);
            cmd5.Parameters.AddWithValue("@masach", masach);
            cmd5.Parameters.AddWithValue("@madocgia", madocgia);
            MySqlDataAdapter adapter5 = new MySqlDataAdapter(cmd5);
            DataTable dataTable5 = new DataTable();
            adapter5.Fill(dataTable5);

            //_____________________________________//

            string query6 = "SELECT * FROM `bill nhập` WHERE `Mã mượn` = @mamuonsach AND `Mã sách` = @masach AND `Mã độc giả` = @madocgia";
            MySqlCommand cmd6 = new MySqlCommand(query6, connection);
            cmd6.Parameters.AddWithValue("@mamuonsach", mamuonsach);
            cmd6.Parameters.AddWithValue("@masach", masach);
            cmd6.Parameters.AddWithValue("@madocgia", madocgia);
            MySqlDataAdapter adapter6 = new MySqlDataAdapter(cmd6);
            DataTable dataTable6 = new DataTable();
            adapter6.Fill(dataTable6);


            if (mamuonsach != "" && masach == "" && madocgia == "")
            {
                dGV_qlmuonsach.DataSource = dataTablep;
            }
            if (mamuonsach == "" && masach != "" && madocgia == "")
            {
                dGV_qlmuonsach.DataSource = dataTable1;
            }
            if (mamuonsach == "" && masach == "" && madocgia != "")
            {
                dGV_qlmuonsach.DataSource = dataTable2;
            }
            if (mamuonsach != "" && masach != "" && madocgia == "")
            {
                dGV_qlmuonsach.DataSource = dataTable3;
            }
            if (mamuonsach != "" && masach == "" && madocgia != "")
            {
                dGV_qlmuonsach.DataSource = dataTable4;
            }
            if (mamuonsach == "" && masach != "" && madocgia != "")
            {
                dGV_qlmuonsach.DataSource = dataTable5;
            }
            if (mamuonsach != "" && masach != "" && madocgia != "")
            {
                dGV_qlmuonsach.DataSource = dataTable6;
            }
        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void vbButton13_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string mamuon = text_mamuon.Text;
            string queryp = "SELECT * FROM `bill mượn` WHERE  `Mã mượn` = @mamuon";
            MySqlCommand cmdp = new MySqlCommand(queryp, connection);
            cmdp.Parameters.AddWithValue("@mamuon", mamuon);
            MySqlDataAdapter adapterp = new MySqlDataAdapter(cmdp);
            DataTable dataTablep = new DataTable();
            adapterp.Fill(dataTablep);
            int rowCount = dataTablep.Rows.Count;
            if (rowCount > 0)
            {
                Quanlysach.SelectedIndex = 5;
            }
            if (rowCount == 0)
            {
                MessageBox.Show("Không tồn tại mã nhập sách");
            }
        }

        private void vbB_caphatmuon_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();
            string mamuon = text_mamuon.Text;
            string masachmoi = tex_masachmuon.Text;
            string madocgiamoi = tex_iddocgia.Text;

            string updatenhapsach = "UPDATE `bill mượn` SET `Mã sách` = @masachmoi WHERE `Mã mượn` = @mamuon;";
            MySqlCommand updategioCmd = new MySqlCommand(updatenhapsach, connection);
            updategioCmd.Parameters.AddWithValue("@masachmoi", masachmoi);
            updategioCmd.Parameters.AddWithValue("@mamuon", mamuon); // Thay 'ten_nguoidung' bằng tên người dùng
            updategioCmd.ExecuteNonQuery();

            string updatenhapsach1 = "UPDATE `bill mượn` SET `Mã độc giả` = @madocgiamoi WHERE `Mã mượn` = @mamuon;";
            MySqlCommand updategioCmd1 = new MySqlCommand(updatenhapsach1, connection);
            updategioCmd1.Parameters.AddWithValue("@madocgiamoi", madocgiamoi);
            updategioCmd1.Parameters.AddWithValue("@mamuon", mamuon); // Thay 'ten_nguoidung' bằng tên người dùng
            updategioCmd1.ExecuteNonQuery();
            LoadDataIntoDgvQuanLyMuonSach();
            MessageBox.Show("Cập nhật thành công!");
        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void vbButton12_Click_1(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();
            string masach = tex_masach1.Text;
            string tensachmoi = tex_suatensach.Text;
            string tacgiamoi = tex_suatacgia.Text;
            string theloaimoi = tex_suatheloai.Text;

            string updatenhapsach = "UPDATE `table books` SET `Tên sách` = @tensachmoi WHERE `Mã sách` = @masach;";
            MySqlCommand updategioCmd = new MySqlCommand(updatenhapsach, connection);
            updategioCmd.Parameters.AddWithValue("@tensachmoi", tensachmoi);
            updategioCmd.Parameters.AddWithValue("@masach", masach); // Thay 'ten_nguoidung' bằng tên người dùng
            updategioCmd.ExecuteNonQuery();

            string updatenhapsach1 = "UPDATE `table books` SET `Tên tác giả` = @tacgiamoi WHERE `Mã sách` = @masach;";
            MySqlCommand updategioCmd1 = new MySqlCommand(updatenhapsach1, connection);
            updategioCmd1.Parameters.AddWithValue("@masach", masach);
            updategioCmd1.Parameters.AddWithValue("@tacgiamoi", tacgiamoi); // Thay 'ten_nguoidung' bằng tên người dùng
            updategioCmd1.ExecuteNonQuery();

            string updatenhapsach2 = "UPDATE `table books` SET `Thể loại` = @theloaimoi WHERE `Mã sách` = @masach;";
            MySqlCommand updategioCmd2 = new MySqlCommand(updatenhapsach2, connection);
            updategioCmd2.Parameters.AddWithValue("@masach", masach);
            updategioCmd2.Parameters.AddWithValue("@theloaimoi", theloaimoi); // Thay 'ten_nguoidung' bằng tên người dùng
            updategioCmd2.ExecuteNonQuery();

            LoadDataIntoDgvQuanLySach();
            MessageBox.Show("Cập nhật thành công!");
        }

        private void vbButton5_Click_1(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string queryp = "SELECT * FROM `cardreader`"; 

            MySqlCommand cmdp = new MySqlCommand(queryp, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdp);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                PdfWriter writer = new PdfWriter("C:\\File_pdf_oop\\output1.pdf");
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                //__________________________________________________________________//
                Table table = new Table(dataTable.Columns.Count); // Tạo bảng với số cột tương ứng với số cột trong DataTable

                // Thêm header cho bảng 
                foreach (DataColumn column in dataTable.Columns)
                {
                    table.AddHeaderCell(new Cell().Add(new Paragraph(column.ColumnName)));
                }
                //______________________________________________________________//
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (object value in row.ItemArray)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(value.ToString())));
                    }
                }

                document.Add(table);

                //_________________________________________________________________//
                /*foreach (DataRow row in dataTable.Rows)
                {                  
                    foreach (DataColumn col in dataTable.Columns)
                    {
                        document.Add(new Paragraph(row[col].ToString()));
                    }
                }*/

                document.Close();
                writer.Close();
            }

            //PdfWriter writer = new PdfWriter("C:\\File_pdf_oop\\Thong_ke_the_ban_doc.pdf");
            //PdfDocument pdf = new PdfDocument(writer);
            //Document document = new Document(pdf);

            /*while (reader.Read())
            {
                // Đọc dữ liệu từ SQL và thêm vào file PDF
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    document.Add(new Paragraph(reader[i].ToString()));
                }
            }

            reader.Close();*/

            MessageBox.Show("Đã xuất file báo cáo!");
        }


        private void vbButton16_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Danh sách lọc sách.pdf";
            sfd.Title = "Danh sách các sách theo" + tex_theloai1.Text + " " + tex_tacgia1.Text + " " + tex_tensach1.Text;
            sfd.InitialDirectory = @"C:\File_pdf_oop";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                PdfWriter writer = new PdfWriter(sfd.FileName);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                //dGV_qlsach.AutoResizeColumns();
                // Tạo bảng iTextSharp
                Table table = new Table(dGV_qlsach.Columns.Count);

                // Thêm header cho bảng từ DataGridView
                foreach (DataGridViewColumn column in dGV_qlsach.Columns)
                {
                    table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText)));
                }

                // Thêm dữ liệu từ DataGridView vào bảng
                foreach (DataGridViewRow row in dGV_qlsach.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null || cell.Value == DBNull.Value)
                        {
                            cell.Value = "Unknown";
                        }
                        else
                        {
                            table.AddCell(new Cell().Add(new Paragraph(cell.Value.ToString())));
                        }
                    }
                }


                document.Add(table); // Thêm bảng vào tài liệu PDF

                document.Close();
                writer.Close();

                MessageBox.Show("File PDF đã được xuất thành công!");
            }
        }

        private void vbButton17_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string queryp = "SELECT * FROM `cardreader` WHERE `Ngày sinh` > '2003-11-24';";

            MySqlCommand cmdp = new MySqlCommand(queryp, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdp);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                PdfWriter writer = new PdfWriter("C:\\File_pdf_oop\\the_ban_doc_duoi_18_tuoi.pdf");
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                //__________________________________________________________________//
                Table table = new Table(dataTable.Columns.Count); // Tạo bảng với số cột tương ứng với số cột trong DataTable

                // Thêm header cho bảng 
                foreach (DataColumn column in dataTable.Columns)
                {
                    table.AddHeaderCell(new Cell().Add(new Paragraph(column.ColumnName)));
                }
                //______________________________________________________________//
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (object value in row.ItemArray)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(value.ToString())));
                    }
                }

                document.Add(table);

               

                document.Close();
                writer.Close();
            }           

            MessageBox.Show("Đã xuất file báo cáo!");
        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void vbButton18_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string nam = tex_nam.Text;
            string queryp = "SELECT * FROM `bill mượn` WHERE SUBSTRING_INDEX(`Thời gian mượn`, '/', -1) > @nam;";

            MySqlCommand cmdp = new MySqlCommand(queryp, connection);

            cmdp.Parameters.AddWithValue("@nam", nam);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdp);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                PdfWriter writer = new PdfWriter("C:\\File_pdf_oop\\don_muon_sach.pdf");
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                //__________________________________________________________________//
                Table table = new Table(dataTable.Columns.Count); // Tạo bảng với số cột tương ứng với số cột trong DataTable

                // Thêm header cho bảng 
                foreach (DataColumn column in dataTable.Columns)
                {
                    table.AddHeaderCell(new Cell().Add(new Paragraph(column.ColumnName)));
                }
                //______________________________________________________________//
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (object value in row.ItemArray)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(value.ToString())));
                    }
                }

                document.Add(table);

                document.Close();
                writer.Close();
            }

            MessageBox.Show("Đã xuất file báo cáo!");
        }

        private void text_mamuon_TextChanged(object sender, EventArgs e)
        {

        }

        private void vbButton19_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string nam = tex_nam1.Text;
            string queryp = "SELECT * FROM `bill nhập` WHERE SUBSTRING_INDEX(`Ngày nhập sách`, '/', -1) > @nam;";

            MySqlCommand cmdp = new MySqlCommand(queryp, connection);

            cmdp.Parameters.AddWithValue("@nam", nam);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdp);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                PdfWriter writer = new PdfWriter("C:\\File_pdf_oop\\thong_ke_nhap_sach.pdf");
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                //__________________________________________________________________//
                Table table = new Table(dataTable.Columns.Count); // Tạo bảng với số cột tương ứng với số cột trong DataTable

                // Thêm header cho bảng 
                foreach (DataColumn column in dataTable.Columns)
                {
                    table.AddHeaderCell(new Cell().Add(new Paragraph(column.ColumnName)));
                }
                //______________________________________________________________//
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (object value in row.ItemArray)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(value.ToString())));
                    }
                }

                document.Add(table);

                document.Close();
                writer.Close();
            }

            MessageBox.Show("Đã xuất file báo cáo!");
        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void vbButton20_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string diemlon = tex_diemlon.Text;
            string queryp = "SELECT * FROM `rating` WHERE `Điểm đánh giá` > @diemlon;";

            MySqlCommand cmdp = new MySqlCommand(queryp, connection);

            cmdp.Parameters.AddWithValue("@diemlon", diemlon);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdp);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                PdfWriter writer = new PdfWriter("C:\\File_pdf_oop\\thong_ke_danh_gia_hon.pdf");
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                //__________________________________________________________________//
                Table table = new Table(dataTable.Columns.Count); // Tạo bảng với số cột tương ứng với số cột trong DataTable

                // Thêm header cho bảng 
                foreach (DataColumn column in dataTable.Columns)
                {
                    table.AddHeaderCell(new Cell().Add(new Paragraph(column.ColumnName)));
                }
                //______________________________________________________________//
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (object value in row.ItemArray)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(value.ToString())));
                    }
                }

                document.Add(table);

                document.Close();
                writer.Close();
            }

            MessageBox.Show("Đã xuất file báo cáo!");
        }

        private void vbButton21_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string diembang = tex_diembang.Text;
            string queryp = "SELECT * FROM `rating` WHERE `Điểm đánh giá` > @diembang;";

            MySqlCommand cmdp = new MySqlCommand(queryp, connection);

            cmdp.Parameters.AddWithValue("@diembang", diembang);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdp);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                PdfWriter writer = new PdfWriter("C:\\File_pdf_oop\\thong_ke_danh_gia_diem_bang.pdf");
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                //__________________________________________________________________//
                Table table = new Table(dataTable.Columns.Count); // Tạo bảng với số cột tương ứng với số cột trong DataTable

                // Thêm header cho bảng 
                foreach (DataColumn column in dataTable.Columns)
                {
                    table.AddHeaderCell(new Cell().Add(new Paragraph(column.ColumnName)));
                }
                //______________________________________________________________//
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (object value in row.ItemArray)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(value.ToString())));
                    }
                }

                document.Add(table);

                document.Close();
                writer.Close();
            }

            MessageBox.Show("Đã xuất file báo cáo!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quanlysach.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quanlysach.SelectedIndex = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Quanlysach.SelectedIndex = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Quanlysach.SelectedIndex = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Quanlysach.SelectedIndex = 7;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tex_diembang_TextChanged(object sender, EventArgs e)
        {

        }

        private void vbB_loaddiembang_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string diembang = tex_diembang.Text;
            string queryp = "SELECT * FROM `rating` WHERE `Điểm đánh giá` = @diembang;";

            MySqlCommand cmdp = new MySqlCommand(queryp, connection);

            cmdp.Parameters.AddWithValue("@diembang", diembang);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdp);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dGV_Danhgia.DataSource = dataTable;
        }

        private void vbB_loaddiemlon_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string diemlon = tex_diemlon.Text;
            string queryp = "SELECT * FROM `rating` WHERE `Điểm đánh giá` > @diemlon;";

            MySqlCommand cmdp = new MySqlCommand(queryp, connection);

            cmdp.Parameters.AddWithValue("@diemlon", diemlon);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmdp);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dGV_Danhgia.DataSource = dataTable;
        }

        private void vbButton22_Click(object sender, EventArgs e)
        {
            LoadDataIntoDgvQuanLySach();
        }
    }
}
