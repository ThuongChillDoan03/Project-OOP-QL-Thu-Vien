using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace OOP
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            LoadDataIntoDgvQuanLySach();
            LoadDataIntoDgvThongKeDocGia();
            LoadDataIntoDgvQuanLyTheDoc();
            LoadDataIntoDgvQuanLyNhapSach();
            LoadDataIntoDgvQuanLyMuonSach();
            this.AcceptButton = btnTimKiemSach;
            this.AcceptButton = btnThem;
            this.AcceptButton = btnSua;
            this.AcceptButton = btnXoa;
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
            dgvQuanLySach.DataSource = dataTable;
            connection.Close();
        }

        private void LoadDataIntoDgvThongKeDocGia()
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();
            string query = "SELECT * FROM `customers`";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvThongKeDocGia.DataSource = dataTable;
            connection.Close();
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
            dgvQuanLyTheDoc.DataSource = dataTable;
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
            dgvQuanLyNhapSach.DataSource = dataTable;
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
            dgvQuanLyMuonSach.DataSource = dataTable;
            connection.Close();
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            string IDSach = txtIDSach.Text.Trim(); // Lấy dữ liệu từ TextBox
            string TheLoai = txtTheLoai.Text.Trim();
            string TacGia = txtTacGia.Text.Trim();
            string TenSach = txtTenSach.Text.Trim();
            string NgonNgu = txtNgonNgu.Text.Trim();

            MySqlConnection connection = tao_connetion();
            connection.Open();
            string insertQuery = "INSERT INTO `table books` (Book_ID, Book_Genre, Book_Author, Book_Title) VALUES (@IDSach, @TheLoai, @TacGia, @TenSach)";
            MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
            insertCmd.Parameters.AddWithValue("@IDSach", IDSach);
            insertCmd.Parameters.AddWithValue("@TheLoai", TheLoai);
            insertCmd.Parameters.AddWithValue("@TacGia", TacGia);
            insertCmd.Parameters.AddWithValue("@TenSach", TenSach);
            insertCmd.ExecuteNonQuery();

            // Hiển thị toàn bộ dữ liệu trong DataGridView sau khi thêm mới
            string selectAllQuery = "SELECT * FROM `table books`";
            MySqlCommand selectAllCmd = new MySqlCommand(selectAllQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectAllCmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvQuanLySach.DataSource = dataTable;
            connection.Close();
        }
        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            string IDSach = txtIDSach.Text.Trim(); // Lấy dữ liệu từ TextBox
            string TheLoai = txtTheLoai.Text.Trim();
            string TacGia = txtTacGia.Text.Trim();
            string TenSach = txtTenSach.Text.Trim();
            string NgonNgu = txtNgonNgu.Text.Trim();

            MySqlConnection connection = tao_connetion();
            connection.Open();

            string queryexist = "select count(*) from `table books` where Book_ID = @BookID";
            MySqlCommand existcmd = new MySqlCommand(queryexist, connection);
            existcmd.Parameters.AddWithValue("@BookID", IDSach);
            int count = Convert.ToInt32(existcmd.ExecuteScalar());

            if (count > 0)
            {
                string query = "select * from `table books` WHERE Book_ID = @IDSach";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@IDSach", IDSach);
                cmd.Parameters.AddWithValue("@TheLoai", TheLoai);
                cmd.Parameters.AddWithValue("@TacGia", TacGia);
                cmd.Parameters.AddWithValue("@TenSach", TenSach);
                cmd.Parameters.AddWithValue("@NgonNgu", NgonNgu);

                //____________________Lấy data___________________//
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvQuanLySach.DataSource = dataTable;
                //dataGridView.DataSource = dataTable; // Hiển thị kết quả trong Datagridview 
            }
            else
            {
                MessageBox.Show("ID bạn nhập không hợp lệ!");
            }

            connection.Close();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string IDSach = txtIDSach.Text.Trim(); // Lấy dữ liệu từ TextBox
            string TheLoai = txtTheLoai.Text.Trim();
            string TacGia = txtTacGia.Text.Trim();
            string TenSach = txtTenSach.Text.Trim();
            string NgonNgu = txtNgonNgu.Text.Trim();

            MySqlConnection connection = tao_connetion();
            connection.Open();

            string queryexist = "select count(*) from `table books` where Book_ID = @BookID";
            MySqlCommand existcmd = new MySqlCommand(queryexist, connection);
            existcmd.Parameters.AddWithValue("@BookID", IDSach);
            int count = Convert.ToInt32(existcmd.ExecuteScalar());

            if (count > 0)
            {
                string deleteQuery = "delete from `table books` where Book_ID = @IDSach";
                MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection);
                deleteCmd.Parameters.AddWithValue("@IDSach", IDSach);
                deleteCmd.Parameters.AddWithValue("@TheLoai", TheLoai);
                deleteCmd.Parameters.AddWithValue("@TacGia", TacGia);
                deleteCmd.Parameters.AddWithValue("@TenSach", TenSach);
                deleteCmd.Parameters.AddWithValue("@NgonNgu", NgonNgu);
                deleteCmd.ExecuteNonQuery();

                // Hiển thị toàn bộ dữ liệu trong DataGridView sau khi thêm mới
                string selectAllQuery = "SELECT * FROM `table books`";
                MySqlCommand selectAllCmd = new MySqlCommand(selectAllQuery, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectAllCmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvQuanLySach.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("ID bạn nhập không hợp lệ!");
            }
            
            connection.Close();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            FormSuaQuanLySach SuaQuanLySach_Form = new FormSuaQuanLySach();
            SuaQuanLySach_Form.ShowDialog();
            MySqlConnection connection = tao_connetion();
            connection.Open();
            string selectAllQuery = "SELECT * FROM `table books`";
            MySqlCommand selectAllCmd = new MySqlCommand(selectAllQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectAllCmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvQuanLySach.DataSource = dataTable;
            connection.Close();
        }

        // Quản lý thẻ đọc, gồm các chức năng: tìm kiếm, thêm, xóa, sửa
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string MaDocGia = txtMaDocGiaQLTD.Text.Trim(); // Lấy dữ liệu từ TextBox
            string MaThe = txtMaTheQLTD.Text.Trim();
            string TenDocGia = txtTenDocGiaQLTD.Text.Trim();
            DateTime NgaySinh1 = dtpNgaySinhQLTD.Value;
            string NgaySinh = NgaySinh1.ToString("yyyy-MM-dd");

            MySqlConnection connection = tao_connetion();
            connection.Open();

            string query = "select * from CardReader WHERE Reader_ID = @MaDocGia and CardReader_ID = @MaThe and Reader_Name = @TenDocGia and Birthday = @NgaySinh";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@MaDocGia", MaDocGia);
            cmd.Parameters.AddWithValue("@MaThe", MaThe);
            cmd.Parameters.AddWithValue("@TenDocGia", TenDocGia);
            cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvQuanLyTheDoc.DataSource = dataTable;
            //dataGridView.DataSource = dataTable; // Hiển thị kết quả trong Datagridview 
            connection.Close();
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {

            string MaDocGia = txtMaDocGiaQLTD.Text.Trim(); // Lấy dữ liệu từ TextBox
            string MaThe = txtMaTheQLTD.Text.Trim();
            string TenDocGia = txtTenDocGiaQLTD.Text.Trim();
            DateTime NgaySinh1 = dtpNgaySinhQLTD.Value;
            string NgaySinh = NgaySinh1.ToString("yyyy-MM-dd");

            MySqlConnection connection = tao_connetion();
            connection.Open();
            

            string insertQuery = "INSERT INTO CardReader (CardReader_ID, Reader_ID, Reader_Name, Birthday) VALUES (@MaThe, @MaDocGia, @TenDocGia, @NgaySinh)";
            MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
            insertCmd.Parameters.AddWithValue("@MaDocGia", MaDocGia);
            insertCmd.Parameters.AddWithValue("@MaThe", MaThe);
            insertCmd.Parameters.AddWithValue("@TenDocGia", TenDocGia);
            insertCmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            insertCmd.ExecuteNonQuery();

            // Hiển thị toàn bộ dữ liệu trong DataGridView sau khi thêm mới
            string selectAllQuery = "SELECT * FROM CardReader";
            MySqlCommand selectAllCmd = new MySqlCommand(selectAllQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectAllCmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvQuanLyTheDoc.DataSource = dataTable;

            connection.Close();
        }
        private void btnSuaQLTD_Click(object sender, EventArgs e)
        {
            FormSuaQuanLyTheDoc SuaQuanLyTheDoc_Form = new FormSuaQuanLyTheDoc();
            SuaQuanLyTheDoc_Form.ShowDialog();
            MySqlConnection connection = tao_connetion();
            connection.Open();
            string selectAllQuery = "SELECT * FROM CardReader";
            MySqlCommand selectAllCmd = new MySqlCommand(selectAllQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectAllCmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvQuanLyTheDoc.DataSource = dataTable;
            connection.Close();
        }
        private void btnXoaQLTD_Click(object sender, EventArgs e)
        {
            string MaDocGia = txtMaDocGiaQLTD.Text.Trim(); // Lấy dữ liệu từ TextBox
            string MaThe = txtMaTheQLTD.Text.Trim();
            string TenDocGia = txtTenDocGiaQLTD.Text.Trim();
            DateTime NgaySinh1 = dtpNgaySinhQLTD.Value;
            string NgaySinh = NgaySinh1.ToString("yyyy-MM-dd");

            MySqlConnection connection = tao_connetion();
            connection.Open();

            string queryexist = "select count(*) from CardReader where CardReader_ID = @MaThe";
            MySqlCommand existcmd = new MySqlCommand(queryexist, connection);
            existcmd.Parameters.AddWithValue("@MaThe", MaThe);
            int count = Convert.ToInt32(existcmd.ExecuteScalar());

            if (count > 0)
            {
                string deleteQuery = "delete from CardReader where CardReader_ID = @MaThe and Reader_ID = @MaDocGia and Reader_Name = @TenDocGia and Birthday = @NgaySinh";
                MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection);
                deleteCmd.Parameters.AddWithValue("@MaDocGia", MaDocGia);
                deleteCmd.Parameters.AddWithValue("@MaThe", MaThe);
                deleteCmd.Parameters.AddWithValue("@TenDocGia", TenDocGia);
                deleteCmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                deleteCmd.ExecuteNonQuery();

                // Hiển thị toàn bộ dữ liệu trong DataGridView sau khi thêm mới
                string selectAllQuery = "SELECT * FROM CardReader";
                MySqlCommand selectAllCmd = new MySqlCommand(selectAllQuery, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectAllCmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvQuanLyTheDoc.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("ID bạn nhập không hợp lệ!");
            }

            connection.Close();
        }

        // Quản lý nhập sách, gồm các chức năng: thêm, sửa, xóa, tìm kiếm
        private void btnThemQLNS_Click(object sender, EventArgs e)
        {
            string MaBillNhap = txtMaBillNhap.Text.Trim(); // Lấy dữ liệu từ TextBox
            string MaNhanVien = txtMaNhanVien.Text.Trim();
            string MaSach = txtMaSach.Text.Trim();
            DateTime NgayNhap1 = dateNgayNhap.Value;
            string NgayNhap = NgayNhap1.ToString("yyyy-MM-dd");

            MySqlConnection connection = tao_connetion();
            connection.Open();

            string queryexist = "select count(*) from `staffremake` where Staff_ID = @StaffID";
            MySqlCommand existcmd = new MySqlCommand(queryexist, connection);
            existcmd.Parameters.AddWithValue("@StaffID", MaNhanVien);
            int count = Convert.ToInt32(existcmd.ExecuteScalar());

            if (count > 0)
            {
                FormThongTinSach QuanLyNhapSach_Form = new FormThongTinSach();
                QuanLyNhapSach_Form.ShowDialog();
                string selectAllQuery1 = "SELECT * FROM `table books`";
                MySqlCommand selectAllCmd1 = new MySqlCommand(selectAllQuery1, connection);
                MySqlDataAdapter adapter1 = new MySqlDataAdapter(selectAllCmd1);
                DataTable dataTable1 = new DataTable();
                adapter1.Fill(dataTable1);
                dgvQuanLySach.DataSource = dataTable1;

                string insertQuery = "INSERT INTO `bill nhập` (ImportBill_ID, ImportBill_Date, Staff_ID, Book_ID) VALUES (@MaBillNhap, @NgayNhap, @MaNhanVien, @MaSach)";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                insertCmd.Parameters.AddWithValue("@MaBillNhap", MaBillNhap);
                insertCmd.Parameters.AddWithValue("@NgayNhap", NgayNhap);
                insertCmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
                insertCmd.Parameters.AddWithValue("@MaSach", MaSach);
                insertCmd.ExecuteNonQuery();

                // Hiển thị toàn bộ dữ liệu trong DataGridView sau khi thêm mới
                string selectAllQuery = "SELECT * FROM `bill nhập`";
                MySqlCommand selectAllCmd = new MySqlCommand(selectAllQuery, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectAllCmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvQuanLyNhapSach.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Mã nhân viên không hợp lệ!");
            }
            connection.Close();
        }

        private void btnXoaQLNS_Click(object sender, EventArgs e)
        {
            string MaBillNhap = txtMaBillNhap.Text.Trim(); // Lấy dữ liệu từ TextBox
            string MaNhanVien = txtMaNhanVien.Text.Trim();
            string MaSach = txtMaSach.Text.Trim();
            DateTime NgayNhap1 = dateNgayNhap.Value;
            string NgayNhap = NgayNhap1.ToString("yyyy-MM-dd");

            MySqlConnection connection = tao_connetion();
            connection.Open();

            string queryexist = "select count(*) from `staffremake` where Staff_ID = @StaffID";
            MySqlCommand existcmd = new MySqlCommand(queryexist, connection);
            existcmd.Parameters.AddWithValue("@StaffID", MaNhanVien);
            int count = Convert.ToInt32(existcmd.ExecuteScalar());

            if (count > 0)
            {
                string deleteQuery = "delete from `bill nhập` where ImportBill_ID = @MaBillNhap and Book_ID = @MaSach";
                MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection);
                deleteCmd.Parameters.AddWithValue("@MaBillNhap", MaBillNhap);
                deleteCmd.Parameters.AddWithValue("@NgayNhap", NgayNhap);
                deleteCmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
                deleteCmd.Parameters.AddWithValue("@MaSach", MaSach);
                deleteCmd.ExecuteNonQuery();

                // Hiển thị toàn bộ dữ liệu trong DataGridView sau khi thêm mới
                string selectAllQuery = "SELECT * FROM `bill nhập`";
                MySqlCommand selectAllCmd = new MySqlCommand(selectAllQuery, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectAllCmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvQuanLyNhapSach.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Mã nhân viên không hợp lệ!");
            }

            connection.Close();
        }

        private void btnSuaQLNS_Click(object sender, EventArgs e)
        {
            FormSuaQuanLyNhapSach SuaQuanLyNhapSach_Form = new FormSuaQuanLyNhapSach();
            SuaQuanLyNhapSach_Form.ShowDialog();
            MySqlConnection connection = tao_connetion();
            connection.Open();
            string selectAllQuery = "SELECT * FROM `bill nhập`";
            MySqlCommand selectAllCmd = new MySqlCommand(selectAllQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectAllCmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvQuanLyNhapSach.DataSource = dataTable;
            connection.Close();
        }

        private void btnTimKiemQLNS_Click(object sender, EventArgs e)
        {
            string MaBillNhap = txtMaBillNhap.Text.Trim(); // Lấy dữ liệu từ TextBox
            DateTime NgayNhap1 = dateNgayNhap.Value;
            string NgayNhap = NgayNhap1.ToString("yyyy-MM-dd");
            string MaNhanVien = txtMaNhanVien.Text.Trim();
            string MaSach = txtMaSach.Text.Trim();

            MySqlConnection connection = tao_connetion();
            connection.Open();

            string queryexist = "select count(*) from `staffremake` where Staff_ID = @StaffID";
            MySqlCommand existcmd = new MySqlCommand(queryexist, connection);
            existcmd.Parameters.AddWithValue("@StaffID", MaNhanVien);
            int count = Convert.ToInt32(existcmd.ExecuteScalar());

            if (count > 0)
            {
                string query = "select * from `bill nhập` WHERE ImportBill_ID = @MaBillNhap or Staff_ID = @MaNhanVien or Book_ID = @MaSach";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaBillNhap", MaBillNhap);
                cmd.Parameters.AddWithValue("@NgayNhap", NgayNhap);
                cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
                cmd.Parameters.AddWithValue("@MaSach", MaSach);

                //____________________Lấy data___________________//
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvQuanLyNhapSach.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Mã nhân viên không hợp lệ!");
            }
            
            connection.Close();
        }
        // Quản lý mượn sách, gồm các chức năng: thêm, sửa, xóa, tìm kiếm
        private void btnThemQLMS_Click(object sender, EventArgs e)
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

            string queryexist = "select count(*) from `table books` where Book_ID = @BookID";
            MySqlCommand existcmd = new MySqlCommand(queryexist, connection);
            existcmd.Parameters.AddWithValue("@BookID", MaSach);
            int count = Convert.ToInt32(existcmd.ExecuteScalar());

            if (count > 0)
            {
                string insertQuery = "INSERT INTO `bill mượn` (BorrowBill_ID, BorrowBill_Date, Reader_ID, Book_ID) VALUES (@MaBillMuon, @NgayMuon, @MaDocGia, @MaSach)";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                insertCmd.Parameters.AddWithValue("@MaBillMuon", MaBillMuon);
                insertCmd.Parameters.AddWithValue("@NgayMuon", NgayMuon);
                insertCmd.Parameters.AddWithValue("@MaDocGia", MaDocGia);
                insertCmd.Parameters.AddWithValue("@MaSach", MaSach);
    
                insertCmd.ExecuteNonQuery();

                // Hiển thị toàn bộ dữ liệu trong DataGridView sau khi thêm mới
                string selectAllQuery = "SELECT * FROM `bill mượn`";
                MySqlCommand selectAllCmd = new MySqlCommand(selectAllQuery, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectAllCmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvQuanLyMuonSach.DataSource = dataTable;

            }
            else
            {
                MessageBox.Show("Mã sách không hợp lệ!");
            }


            connection.Close();
        }

        private void btnXoaQLMS_Click(object sender, EventArgs e)
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

            string queryexist = "select count(*) from `table books` where Book_ID = @BookID";
            MySqlCommand existcmd = new MySqlCommand(queryexist, connection);
            existcmd.Parameters.AddWithValue("@BookID", MaSach);
            int count = Convert.ToInt32(existcmd.ExecuteScalar());

            if (count > 0)
            {
                string deleteQuery = "delete from `` where Borrow_Bill_ID = @MaBillMuon or Reader_ID = @MaDocGia or Book_ID = @MaSach and CardReader_ID = @MaThe";
                MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection);
                deleteCmd.Parameters.AddWithValue("@MaBillMuon", MaBillMuon);
                deleteCmd.Parameters.AddWithValue("@NgayMuon", NgayMuon);
                deleteCmd.Parameters.AddWithValue("@MaDocGia", MaDocGia);
                deleteCmd.Parameters.AddWithValue("@MaSach", MaSach);
                deleteCmd.Parameters.AddWithValue("@MaThe", MaThe);
                deleteCmd.Parameters.AddWithValue("@TenDocGia", TenDocGia);
                deleteCmd.ExecuteNonQuery();

                // Hiển thị toàn bộ dữ liệu trong DataGridView sau khi thêm mới
                string selectAllQuery = "SELECT * FROM Borrow_Bill";
                MySqlCommand selectAllCmd = new MySqlCommand(selectAllQuery, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectAllCmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvQuanLyMuonSach.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Mã sách không hợp lệ!");
            }

            connection.Close();
        }
        private void btnSuaQLMS_Click(object sender, EventArgs e)
        {
            FormSuaQuanLyMuonSach SuaQuanLyMuonSach_Form = new FormSuaQuanLyMuonSach();
            SuaQuanLyMuonSach_Form.ShowDialog();
            MySqlConnection connection = tao_connetion();
            connection.Open();
            string selectAllQuery = "SELECT * FROM Borrow_Bill";
            MySqlCommand selectAllCmd = new MySqlCommand(selectAllQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectAllCmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvQuanLyMuonSach.DataSource = dataTable;
            connection.Close();
        }

        private void btnTimKiemQLMS_Click(object sender, EventArgs e)
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

            string queryexist = "select count(*) from book where book_id = @BookID";
            MySqlCommand existcmd = new MySqlCommand(queryexist, connection);
            existcmd.Parameters.AddWithValue("@BookID", MaSach);
            int count = Convert.ToInt32(existcmd.ExecuteScalar());

            if (count > 0)
            {
                string query = "select * from Borrow_Bill WHERE Borrow_Bill_ID = @MaBillMuon or Reader_ID = @MaDocGia or Book_ID = @MaSach or CardReader_ID = @MaThe";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaBillMuon", MaBillMuon);
                cmd.Parameters.AddWithValue("@NgayMuon", NgayMuon);
                cmd.Parameters.AddWithValue("@MaDocGia", MaDocGia);
                cmd.Parameters.AddWithValue("@MaSach", MaSach);
                cmd.Parameters.AddWithValue("@MaThe", MaThe);
                cmd.Parameters.AddWithValue("@TenDocGia", TenDocGia);

                //____________________Lấy data___________________//
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvQuanLyMuonSach.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Mã sách không hợp lệ!");
            }

            connection.Close();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dgvQuanLySach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvThongKeDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvQuanLyNhapSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvQuanLyMuonSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvQuanLyTheDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
