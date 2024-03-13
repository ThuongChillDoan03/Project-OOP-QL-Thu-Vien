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

namespace Admin
{
    public partial class ManageStaff_RepairInfo : Form
    {
        string constr;
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        public ManageStaff_RepairInfo()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }
        private void InitializeDatabaseConnection()
        {
            
                // Thiết lập chuỗi kết nối
                constr = "Server=localhost;Database=data_oop;User ID=root;Password=24112003;";
                connection = new MySqlConnection(constr);
                command = new MySqlCommand();
                adapter = new MySqlDataAdapter();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                string StaffID = textBox1.Text.Trim();
                string StaffName = textBox2.Text.Trim();
                string StaffSex = null;
                string phone = textBox3.Text.Trim();
                if (radioButton1.Checked.ToString() == "true")
                {   
                    StaffSex = radioButton1.Text.Trim();
                }
                else
                {
                    StaffSex = radioButton2.Text.Trim(); 
                }
                DateTime StaffDOB = dateTimePicker1.Value;
                string NgaySinh = StaffDOB.ToString("yyyy-MM-dd");
                string StaffEmail = textBox5.Text.Trim();
            
                //MySqlConnection connection = new MySqlConnection();
                connection.Open();
                
                string UpdateQuery = "update `staffremake` set `Tên nhân viên` = @StaffName, `Giới tính` = @StaffSex, `Ngày sinh` = @NgaySinh,`Số điện thoại` = @phone, `Email nhân viên` = @StaffEmail where `Mã nhân viên` = @StaffID";
                MySqlCommand UpdateCmd = new MySqlCommand(UpdateQuery, connection);
                UpdateCmd.Parameters.AddWithValue("@StaffID", StaffID);
                UpdateCmd.Parameters.AddWithValue("@StaffName", StaffName);
                UpdateCmd.Parameters.AddWithValue("@StaffSex", StaffSex);
                UpdateCmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                UpdateCmd.Parameters.AddWithValue("@phone", phone);
                UpdateCmd.Parameters.AddWithValue("@StaffEmail", StaffEmail);
                UpdateCmd.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }
            private void btnHuyCapNhat_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormManageStaff_RepairInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
