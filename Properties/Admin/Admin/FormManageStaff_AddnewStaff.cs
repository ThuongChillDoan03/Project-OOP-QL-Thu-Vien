using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class FormManageStaff_AddnewStaff : Form
    {
        public FormManageStaff_AddnewStaff()
        {
            InitializeComponent();
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
            if (radioButtonMale.Checked == true) genderPrefix = "2"; else genderPrefix = "";
            string randomCode = GenerateRandomCode(genderPrefix);

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
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(" Chúc mừng bạn đã đăng ký thông tin cho nhân viên mới thành công !.\n Mã ID của nhân viên " +textBox1.Text + " là:" + "\n Tài khoản được cấp cho nhân viên" +textBox1.Text +"là: " +email + "\n Vui Lòng liên hệ với nhân viên mới qua số điện thoại đã đăng ký để họ được biết về các thông tin quan trọng này");
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
