using MySql.Data.MySqlClient;
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

namespace Admin
{
    public partial class frm_them_nhan_vien : Form
    {
        public frm_them_nhan_vien()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp; *.jpg; *.png)|*.bmp; *.jpg; *.png|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn tới file hình ảnh được chọn
                string imagePath = openFileDialog.FileName;

                // Hiển thị hình ảnh trong PictureBox
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }

        private void ButtonConfirmNewStaff_Click(object sender, EventArgs e)
        {   
            // Sinh mã số ngẫu nhiên
            string genderPrefix = (radioButtonMale.Checked) ? "0" : "1";
            if (radioButtonMale.Checked == true) genderPrefix = "2"; else genderPrefix = "1";
            string randomCode = GenerateRandomCode(genderPrefix);


            string genre1 = radioButtonMale.Text;
            string genre2 = radioButtonFemale.Text;


            // Tạo email theo yêu cầu
            string email = textBox1.Text.ToLower().Replace(" ", "") + randomCode.Substring(3) + "@gmail.com.com";

            // Hàm sinh mã số ngẫu nhiên
             string GenerateRandomCode(string a)
            {
                Random random = new Random();
                int randomNumber = random.Next(1000000, 9999999); // Sinh số ngẫu nhiên từ 1000000 đến 9999999
                return genderPrefix + randomNumber.ToString();
            }

            DialogResult result = MessageBox.Show("Bạn có đã chắc chắn về thông tin đăng ký rồi chứ", "Chắc chắn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ((result == DialogResult.Yes) && (pictureBox1.Image != null))
            {
                MessageBox.Show(" Chúc mừng bạn đã đăng ký thông tin cho nhân viên mới thành công !.\n Mã ID của nhân viên " +textBox1.Text + " là: " +  randomCode + "\n Tài khoản được cấp cho nhân viên" +textBox1.Text +"là: " +email + "\n Vui Lòng liên hệ với nhân viên mới qua số điện thoại đã đăng ký để họ được biết về các thông tin quan trọng này.","Đăng ký thành công", MessageBoxButtons.OK,MessageBoxIcon.Information );
                // Chuyển thông tin nhân viên mới sang FormManageStaff
                string staffName = textBox1.Text;
                string staffPhoneNumber = textBox4.Text;
                DateTime ngaysinh = dTP_ngaysinh.Value;
                string dateString = ngaysinh.ToString("yyyy-MM-dd");

                // Gửi thông tin sang FormManageStaff thông qua sự kiện hoặc phương thức
                // (Bạn cần tạo một phương thức hoặc sự kiện để nhận thông tin ở FormManageStaff)
                // Đóng form AddNewStaff sau khi xác nhận
                // Thêm thông tin nhân viên mới vào DataGridView trong FormManageStaff
                //((FormManageStaff)this.Owner).UpdateDataGridView(randomCode, email, staffName, staffPhoneNumber, staffAddress);
                MySqlConnection connection = tao_connetion();
                connection.Open();

                if (radioButtonMale.Checked)
                {
                    string insertQuery = "INSERT INTO `staffremake` (`Mã nhân viên`, `Tên nhân viên`, `Giới tính`, `Ngày sinh`, `Số điện thoại`, `Email nhân viên`) VALUES (@randomCode, @staffName, @genre1, @dateString, @staffPhoneNumber, @email)";
                    MySqlCommand insertQuerycmd = new MySqlCommand(insertQuery, connection);
                    insertQuerycmd.Parameters.AddWithValue("@randomCode", randomCode);
                    insertQuerycmd.Parameters.AddWithValue("@staffName", staffName);
                    insertQuerycmd.Parameters.AddWithValue("@genre1", genre1);
                    insertQuerycmd.Parameters.AddWithValue("@dateString", dateString); // Thay 'ten_nguoidung' bằng tên người dùng
                    insertQuerycmd.Parameters.AddWithValue("@staffPhoneNumber", staffPhoneNumber);
                    insertQuerycmd.Parameters.AddWithValue("@email", email);
                    insertQuerycmd.ExecuteNonQuery();
                }

                if (radioButtonFemale.Checked)
                {
                    string insertQuery = "INSERT INTO `staffremake` (`Mã nhân viên`, `Tên nhân viên`, `Giới tính`, `Ngày sinh`, `Số điện thoại`, `Email nhân viên`) VALUES (@randomCode, @staffName, @genre2, @dateString, @staffPhoneNumber, @email)";
                    MySqlCommand insertQuerycmd = new MySqlCommand(insertQuery, connection);
                    insertQuerycmd.Parameters.AddWithValue("@randomCode", randomCode);
                    insertQuerycmd.Parameters.AddWithValue("@staffName", staffName);
                    insertQuerycmd.Parameters.AddWithValue("@genre2", genre2);
                    insertQuerycmd.Parameters.AddWithValue("@dateString", dateString); // Thay 'ten_nguoidung' bằng tên người dùng
                    insertQuerycmd.Parameters.AddWithValue("@staffPhoneNumber", staffPhoneNumber);
                    insertQuerycmd.Parameters.AddWithValue("@email", email);
                    insertQuerycmd.ExecuteNonQuery();
                }



                this.Close();
            }
            else if ((result == DialogResult.Yes) && (pictureBox1.Image == null))
            {
                MessageBox.Show("Vui lòng tải ảnh đại diện của nhân viên lên", "Cảnh báo !", MessageBoxButtons.OK);
            }    

            else if ((result == DialogResult.Yes) && ((textBox1.Text != null) || (textBox4.Text != null) ))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin của nhân viên", "Cảnh báo !", MessageBoxButtons.OK);
            } 



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
