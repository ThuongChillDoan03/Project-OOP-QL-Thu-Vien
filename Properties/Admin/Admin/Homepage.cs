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
            FormUsingGuide formUsingGuide = new FormUsingGuide();
            formUsingGuide.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátKhỏiHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
    }
}
