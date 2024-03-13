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
                constr = "Server=localhost;Database=oop_admin;User ID=root;Password=11001203;";
                connection = new MySqlConnection(constr);
                command = new MySqlCommand();
                adapter = new MySqlDataAdapter();
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
                MySqlConnection connection = new MySqlConnection();
                connection.Open();
                string UpdateQuery = "update staff set Staff_ID = @StaffID, Staff_Name = @StaffName, Staff_Sex = @StaffSex, Staff_DOB = @StafDOB, Staff_Email = @StaffEmail where Staff_ID = @StaffID";
                MySqlCommand UpdateCmd = new MySqlCommand(UpdateQuery, connection);
                UpdateCmd.Parameters.AddWithValue("@Staff_ID", StaffID);
                UpdateCmd.Parameters.AddWithValue("@Staff_Name", StaffName);
                UpdateCmd.Parameters.AddWithValue("@Staff_Sex", StaffSex);
                UpdateCmd.Parameters.AddWithValue("@Staff_DOB", StaffDOB);
                UpdateCmd.Parameters.AddWithValue("@Staff_Email", StaffEmail);
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
    }
}
