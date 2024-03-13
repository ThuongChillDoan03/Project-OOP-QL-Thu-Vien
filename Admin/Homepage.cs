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
        public Admin_HomePage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Địa chỉ trang web của bạn
            string websiteUrl = "https://www.facebook.com/profile.php?id=100046213479695";

            // Mở trình duyệt web với địa chỉ trang web
            Process.Start(websiteUrl);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
   
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
            
            FormAdminInfo formshowAdminInfo = new FormAdminInfo();
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
            FormManageStaff formManageStaff = new FormManageStaff();
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
            }
        }

        private void trởVềGiaoDiệnĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Bạn chắc chắn đăng xuất về trang đăng nhập chứ ?", "Đăng xuất", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(ask == DialogResult.OK)
            {
                //mở form đăng nhập
            }
        }

        private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // mở form thông tin cá nhân bạn đã làm sẵn nhé
        }

        private void sửDụngNhưĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Ngay sau đây, bạn sẽ được chuyển sang giao diện độc giả tương ứng", "Đổi giao diện", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (ask == DialogResult.OK)
            {
                //mở form đăng nhập
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
    }
}
