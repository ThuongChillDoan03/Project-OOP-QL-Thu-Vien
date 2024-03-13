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
    public partial class FormAdminInfo : Form
    {
        public FormAdminInfo()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string websiteUrl = "https://www.facebook.com/profile.php?id=100046213479695";

            Process.Start(websiteUrl);
        }

        private void FormAdminInfo_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string websiteUrl = "https://www.facebook.com/lent.phuoc1201/";

            Process.Start(websiteUrl);
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string websiteUrl = "https://www.facebook.com/hoangkimkhanh.1907";

            Process.Start(websiteUrl);

        }

        private void trởVềHệThốngCũToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}

