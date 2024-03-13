using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJECT_CK_20231
{
    public partial class Form_Thongtinnguoidung : Form
    {
        private string ID_User;
        public Form_Thongtinnguoidung(string ID_ND)
        {
            InitializeComponent();
            this.ID_User = ID_ND;
        }

        private string GetRandomImageUrl()
        {
            // Thay đổi kích thước và các thông số khác nếu cần
            int width = 800;
            int height = 600;

            // Tạo URL cho hình ảnh ngẫu nhiên từ Lorem Picsum
            return $"https://picsum.photos/{width}/{height}/?random";
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string query = "SELECT * FROM `customers` WHERE  `Reader_ID` = @ID_User"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID_User", ID_User);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DataRow row = dataTable.Rows[0];

            tex_Nhaphovaten.Text = row["Reader_Name"].ToString();
            tex_Nhapngaysinh.Text = row["Birthday"].ToString();
            tex_Nhapgioitinh.Text = row["Reader_Sex"].ToString();
            tex_Nhapdiachi.Text = row["Reader_Address"].ToString();
            tex_NhapEmail.Text = row["Reader_Email"].ToString();
            tex_Nhapdienthoai.Text = row["Reader_Phone"].ToString();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            tab_Thongtin.SelectedIndex = 0;
        }

        private void tab_TTCN_Click(object sender, EventArgs e)
        {

        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            tab_Thongtin.SelectedIndex = 1;
        }

        private void vbButton3_Click(object sender, EventArgs e)
        {
            tab_Thongtin.SelectedIndex = 2;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void vbB_Xacnhan_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string query = "SELECT * FROM `user` WHERE  `Account` = @ID_User"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID_User", ID_User);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DataRow row = dataTable.Rows[0];

            string nameuser = tex_NhapTK.Text;
            string oldPassword = tex_NhapMKcu.Text;
            string newPassword = tex_NhapMKmoi.Text;
            string confirmPassword = tex_NLai.Text;

            if (nameuser == row["Account"].ToString()  && oldPassword == row["Password"].ToString())
            {   
                string updatePasswordQuery = "UPDATE user SET Password = @newPassword WHERE Account = @nameuser;";
                MySqlCommand updatePasswordCmd = new MySqlCommand(updatePasswordQuery, connection);
                updatePasswordCmd.Parameters.AddWithValue("@newPassword", newPassword);
                updatePasswordCmd.Parameters.AddWithValue("@nameuser", nameuser); // Thay 'ten_nguoidung' bằng tên người dùng

                updatePasswordCmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật mật khẩu thành công!!!");
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng. Vui lòng thử lại.");
            }
        }

        private void vbB_doithongtin_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string query = "SELECT * FROM `customers` WHERE  `Reader_ID` = @ID_User"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID_User", ID_User);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DataRow row = dataTable.Rows[0];

            string tenmoi = tex_doiten.Text;
            string ngaysinhmoi = tex_doingaysinh.Text;

            string gioitinhmoi = rad_Male.Text;
            string gioitinhmoi1 = rad_Female.Text;

            string diachimoi = tex_Doidiachi.Text;
            string emailmoi = tex_Doiemail.Text;
            string dienthoaimoi = tex_DoiSDT.Text;
            
            
            string updateten = "UPDATE `customers` SET `Reader_Name` = @tenmoi WHERE `Reader_ID` = @ID_User;";
            MySqlCommand updatetenCmd = new MySqlCommand(updateten, connection);
            updatetenCmd.Parameters.AddWithValue("@tenmoi", tenmoi);
            updatetenCmd.Parameters.AddWithValue("@ID_User", ID_User); // Thay 'ten_nguoidung' bằng tên người dùng
            updatetenCmd.ExecuteNonQuery();

            string updatengaysinh = "UPDATE `customers` SET `Birthday` = @ngaysinhmoi WHERE `Reader_ID` = @ID_User;";
            MySqlCommand updatengaysinhCmd = new MySqlCommand(updatengaysinh, connection);
            updatengaysinhCmd.Parameters.AddWithValue("@ngaysinhmoi", ngaysinhmoi);
            updatengaysinhCmd.Parameters.AddWithValue("@ID_User", ID_User); // Thay 'ten_nguoidung' bằng tên người dùng
            updatengaysinhCmd.ExecuteNonQuery();

            if (rad_Male.Checked)
            {
                string updategioitinhmoi = "UPDATE `customers` SET `Reader_Sex` = @gioitinhmoi WHERE `Reader_ID` = @ID_User;";
                MySqlCommand updategioitinhCmd = new MySqlCommand(updategioitinhmoi, connection);
                updategioitinhCmd.Parameters.AddWithValue("@gioitinhmoi", gioitinhmoi);
                updategioitinhCmd.Parameters.AddWithValue("@ID_User", ID_User); // Thay 'ten_nguoidung' bằng tên người dùng
                updategioitinhCmd.ExecuteNonQuery();
            }

            if (rad_Female.Checked)
            {
                string updategioitinhmoi = "UPDATE `customers` SET `Reader_Sex` = @gioitinhmoi1 WHERE `Reader_ID` = @ID_User;";
                MySqlCommand updategioitinhCmd = new MySqlCommand(updategioitinhmoi, connection);
                updategioitinhCmd.Parameters.AddWithValue("@gioitinhmoi1", gioitinhmoi1);
                updategioitinhCmd.Parameters.AddWithValue("@ID_User", ID_User); // Thay 'ten_nguoidung' bằng tên người dùng
                updategioitinhCmd.ExecuteNonQuery();
            }

            string updatediachimoi = "UPDATE `customers` SET `Reader_Address` = @diachimoi WHERE `Reader_ID` = @ID_User;";
            MySqlCommand updatediachimoiCmd = new MySqlCommand(updatediachimoi, connection);
            updatediachimoiCmd.Parameters.AddWithValue("@diachimoi", diachimoi);
            updatediachimoiCmd.Parameters.AddWithValue("@ID_User", ID_User); // Thay 'ten_nguoidung' bằng tên người dùng
            updatediachimoiCmd.ExecuteNonQuery();

            string updateemailmoi = "UPDATE `customers` SET `Reader_Email` = @emailmoi WHERE `Reader_ID` = @ID_User;";
            MySqlCommand updatedemailmoiCmd = new MySqlCommand(updateemailmoi, connection);
            updatedemailmoiCmd.Parameters.AddWithValue("@emailmoi", emailmoi);
            updatedemailmoiCmd.Parameters.AddWithValue("@ID_User", ID_User); // Thay 'ten_nguoidung' bằng tên người dùng
            updatedemailmoiCmd.ExecuteNonQuery();

            string updatdienthoaimoi = "UPDATE `customers` SET `Reader_Phone` = @dienthoaimoi WHERE `Reader_ID` = @ID_User;";
            MySqlCommand updatedienthoaimoiCmd = new MySqlCommand(updatdienthoaimoi, connection);
            updatedienthoaimoiCmd.Parameters.AddWithValue("@dienthoaimoi", dienthoaimoi);
            updatedienthoaimoiCmd.Parameters.AddWithValue("@ID_User", ID_User); // Thay 'ten_nguoidung' bằng tên người dùng
            updatedienthoaimoiCmd.ExecuteNonQuery();


            MessageBox.Show("Cập nhật thông tin thành công!!!");

            tex_Nhaphovaten.Text = tex_doiten.Text;
            tex_Nhapngaysinh.Text = tex_doingaysinh.Text;
            if (rad_Male.Checked)
            {
                tex_Nhapgioitinh.Text = rad_Male.Text;
            }
            if (rad_Female.Checked)
            {
                tex_Nhapgioitinh.Text = rad_Female.Text;
            }

            tex_Nhapdiachi.Text = tex_Doidiachi.Text;
            tex_NhapEmail.Text = tex_Doiemail.Text;
            tex_Nhapdienthoai.Text = tex_DoiSDT.Text;

        }

        private void rad_Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad_Female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void vbB_DoiTT_Click(object sender, EventArgs e)
        {
            tab_Thongtin.SelectedIndex = 2;
        }
    }
}

