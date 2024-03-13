using MySql.Data.MySqlClient;
using PROJECT_CK_20231;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{

    
    public partial class Admin_HomePage : Form
    {

        /// <summary>
        private string ID_User1;
        /// </summary>
        /// <param name="ID_ND1"></param>
        public Admin_HomePage(string ID_ND1)
        {
            InitializeComponent();
            this.ID_User1 = ID_ND1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Địa chỉ trang web của bạn
            string websiteUrl = "https://www.facebook.com/profile.php?id=100046213479695";

            // Mở trình duyệt web với địa chỉ trang web
            Process.Start(websiteUrl);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            uid.Text = ID_User1;
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string query = "SELECT * FROM `customers` WHERE  `Reader_ID` = @ID_User1"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID_User1", ID_User1);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            //dataGridView.DataSource = dataTable; // Hiển thị kết quả trong Datagridview 
            DataRow row1 = dataTable.Rows[0];
            ten_admin.Text = row1["Reader_Name"].ToString();

        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string websiteUrl = "https://hust.edu.vn/";

           
            Process.Start(websiteUrl);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            frm_tt_quan_tri_vien formshowAdminInfo = new frm_tt_quan_tri_vien();
            formshowAdminInfo.ShowDialog();
            this.Hide();
        }
        

        private void hướngDẫnSựDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátKhỏiHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi hệ thống không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void theoDõiNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_quan_ly_nhan_vien formManageStaff = new frm_quan_ly_nhan_vien();
            formManageStaff.ShowDialog();
        }

        private void cậpNhậtTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog1 = MessageBox.Show("Bằng cách bấm vào đây, bạn sẽ quản lý các vấn đề liên quan đến bạn đọc như một nhân viên. \nChúc bạn một ngày tốt lành !", "Lưu ý !", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (dialog1 == DialogResult.OK)
            {
                //mở form quản lý nhân viên của staff lên, nhưng mà tên ở góc thì sẽ là tên admin
                Frm_qlsach qlnhanvien = new Frm_qlsach();
                qlnhanvien.ShowDialog();
            }
        }

        private void trởVềGiaoDiệnĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Bạn chắc chắn đăng xuất về trang đăng nhập chứ ?", "Đăng xuất", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(ask == DialogResult.OK)
            {
                //mở form đăng nhập
                Form_Dangnhap quaylaidangnhap = new Form_Dangnhap();
                quaylaidangnhap.ShowDialog();
            }
        }

        private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // mở form thông tin cá nhân bạn đã làm sẵn nhé
            frm_tt_quan_tri_vien thongtin = new frm_tt_quan_tri_vien();
            thongtin.ShowDialog();

        }

        private void sửDụngNhưĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Ngay sau đây, bạn sẽ được chuyển sang giao diện độc giả tương ứng", "Đổi giao diện", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (ask == DialogResult.OK)
            {
                //mở form đăng nhập
                Form_gduser dangnhapfrm = new Form_gduser(uid.Text);
                dangnhapfrm.ShowDialog();
            }
        }

        private void quảnLýToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void cáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void uid_Click(object sender, EventArgs e)
        {

        }
    }
}
