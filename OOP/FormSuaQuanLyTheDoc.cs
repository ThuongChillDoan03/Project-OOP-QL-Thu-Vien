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

namespace OOP
{
    public partial class FormSuaQuanLyTheDoc : Form
    {
        public FormSuaQuanLyTheDoc()
        {
            InitializeComponent();
            this.AcceptButton = btnSuaCapNhat;
            this.AcceptButton = btnSuaHuy;
        }
        public MySqlConnection tao_connetion()
        {
            string server = "localhost";
            string database = "oop";
            string uid = "root";
            string password = "123456";

            string constring = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + password;
            MySqlConnection connection = new MySqlConnection(constring);
            return connection;
        }
        private void btnSuaCapNhat_Click(object sender, EventArgs e)
        {
            string MaThe = txtSuaCardID.Text.Trim();
            string MaDocGia = txtSuaReaderID.Text.Trim();
            string TenDocGia = txtSuaReaderName.Text.Trim();
            DateTime NgaySinh1 = dtpSuaReaderDob.Value;
            string NgaySinh = NgaySinh1.ToString("yyyy-MM-dd");

            MySqlConnection connection = tao_connetion();
            connection.Open();

            string UpdateQuery = "update CardReader set Reader_Name = @TenDocGia, Reader_Dob = @NgaySinh where CardReader_ID = @MaThe and Reader_ID = @MaDocGia";
            MySqlCommand UpdateCmd = new MySqlCommand(UpdateQuery, connection);
            UpdateCmd.Parameters.AddWithValue("@MaThe", MaThe);
            UpdateCmd.Parameters.AddWithValue("@MaDocGia", MaDocGia);
            UpdateCmd.Parameters.AddWithValue("@TenDocGia", TenDocGia);
            UpdateCmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
            UpdateCmd.ExecuteNonQuery();
            connection.Close();

            this.Close();
        }

        private void btnSuaHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpSuaReaderDob_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
