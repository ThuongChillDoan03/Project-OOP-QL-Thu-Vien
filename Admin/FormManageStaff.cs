using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Org.BouncyCastle.Asn1.Crmf;

namespace Admin
{
    public partial class FormManageStaff : Form
    {
        string constr;
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter adapter;

        public FormManageStaff()
        {
            InitializeComponent();

            // Thêm đoạn mã kết nối vào hàm khởi tạo
            InitializeDatabaseConnection();
            LoadDataIntoDataGridView();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void InitializeDatabaseConnection()
        {
            try
            {
                // Thiết lập chuỗi kết nối
                constr = "Server=localhost;Database=oop_admin;User ID=root;Password=11001203;";
                connection = new MySqlConnection(constr);
                command = new MySqlCommand();
                adapter = new MySqlDataAdapter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database connection: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {    // Lấy giá trị từ các controls
            string staffID = textBox1.Text.Trim();
            string staffName = textBox2.Text.Trim();
            string staffEmail = textBox5.Text.Trim();
            List<string> selectedAddresses = new List<string>();
            string staffSex = "null";
            if (radioButton1.Checked == true)
            {
                staffSex = radioButton1.Text.Trim();
            }
            else if (radioButton2.Checked == true)
            {
                staffSex = radioButton2.Text.Trim();
            }
 

            try
            {
                // Mở kết nối
                connection.Open();

                // Xây dựng câu truy vấn động
                StringBuilder queryBuilder = new StringBuilder("SELECT * FROM staff WHERE ");

                bool conditionAdded = false;

                if (!string.IsNullOrEmpty(staffID))
                {
                    queryBuilder.Append($" Staff_ID = '{staffID}'");
                    conditionAdded = true;
                }
                else
                {
                    if (!string.IsNullOrEmpty(staffName))
                    {
                        if (conditionAdded)
                            queryBuilder.Append(" OR");
                        queryBuilder.Append($" Staff_Name LIKE '%{staffName}%'");
                        conditionAdded = true;
                    }

                    if (!string.IsNullOrEmpty(staffEmail))
                    {
                        if (conditionAdded)
                            queryBuilder.Append(" OR");
                        queryBuilder.Append($" Staff_Email LIKE '%{staffEmail}%'");
                        conditionAdded = true;
                    }

                    if (!string.IsNullOrEmpty(staffSex))
                    {
                        if (conditionAdded)
                            queryBuilder.Append(" OR");
                        queryBuilder.Append($" Staff_Sex LIKE '%{staffSex}%'");
                        conditionAdded = true;
                    }
                }

                // Thực hiện truy vấn
                MySqlCommand command = new MySqlCommand(queryBuilder.ToString(), connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Đóng kết nối
                connection.Close();

                // Đổ dữ liệu vào DataGridView
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã bấm vào nút xóa ở cột nào không
            if (e.ColumnIndex == dataGridView1.Columns["XoaColumn"].Index && e.RowIndex >= 0)
            {
                // Lấy giá trị cột ID của dòng được chọn
                int staffID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["StaffID"].Value);


                // Sau khi xóa, cập nhật lại DataGridView
                LoadDataIntoDataGridView();
            }
        }
        private void LoadDataIntoDataGridView()
        {
            try
            {
                // Mở kết nối
                connection.Open();

                // Thực hiện truy vấn
                string query = "SELECT * FROM staff";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Tạo đối tượng DataTable để lưu trữ dữ liệu từ MySQL
                DataTable dataTable = new DataTable();
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataTable);

                // Đóng kết nối
                connection.Close();

                // Đổ dữ liệu vào DataGridView
                dataGridView1.DataSource = dataTable;
                command = new MySqlCommand(query, connection);
                adapter = new MySqlDataAdapter(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormManageStaff_AddnewStaff formManageStaff_AddnewStaff = new FormManageStaff_AddnewStaff ();
            formManageStaff_AddnewStaff.ShowDialog();
            FormManageStaff_AddnewStaff formManageStaff_AddnewStaff1 = new FormManageStaff_AddnewStaff();
            formManageStaff_AddnewStaff1.Owner = this; 
            formManageStaff_AddnewStaff.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        { 
                string StaffID = textBox1.Text.Trim();

                // Kiểm tra xem TextBox có trống không
                if (string.IsNullOrEmpty(StaffID))
                {
                    MessageBox.Show("Vui lòng nhập ID Staff cần xóa");
                    return;
                }

                // Kiểm tra xem ID Staff có tồn tại hay không
                if (!IsStaffIDExists(StaffID))
                {
                    MessageBox.Show("ID Staff bạn yêu cầu không tồn tại");
                    return;
                }

                // Tiến hành xóa dữ liệu
                try
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM staff WHERE Staff_ID = @Staff_ID";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection);
                    deleteCmd.Parameters.AddWithValue("@Staff_ID", StaffID);
                    deleteCmd.ExecuteNonQuery();

                    // Hiển thị toàn bộ dữ liệu trong DataGridView sau khi xóa
                    string selectAllQuery = "SELECT * FROM staff";
                    MySqlCommand selectAllCmd = new MySqlCommand(selectAllQuery, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(selectAllCmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

        private bool IsStaffIDExists(string staffID)
        {
            try
            {
                connection.Open();
                string checkQuery = "SELECT COUNT(*) FROM staff WHERE Staff_ID = @Staff_ID";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection);
                checkCmd.Parameters.AddWithValue("@Staff_ID", staffID);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                return count > 0;
            }
            finally
            {
                connection.Close();
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormManageStaff_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string StaffID = textBox1.Text.Trim();

            // Kiểm tra xem TextBox có trống không
            if (string.IsNullOrEmpty(StaffID))
            {
                MessageBox.Show("Vui lòng nhập ID Staff cần sửa");
                return;
            }

            // Kiểm tra xem ID Staff có tồn tại hay không
            if (!IsStaffIDExists(StaffID))
            {
                MessageBox.Show("ID Staff bạn yêu cầu sửa thông tin không tồn tại");
                return;
            }
            else
            {
                ManageStaff_RepairInfo formManageAdmin_Repair = new ManageStaff_RepairInfo();
                formManageAdmin_Repair.ShowDialog();
            }    
            // Tiến hành cập nhật dữ liệu
            try
            { 
                string selectAllQuery = "SELECT * FROM staff";
                MySqlCommand selectAllCmd = new MySqlCommand(selectAllQuery, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectAllCmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }

            finally
            {
                connection.Close();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Nút khôi phục sẽ khôi phục về thông tin các nhân viên ban đầu, bạn chỉ thật sự nên dùng sau khi thực hiện tìm kiếm", "Nhắc nhở", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                LoadDataIntoDataGridView();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
