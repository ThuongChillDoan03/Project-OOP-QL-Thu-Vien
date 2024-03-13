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
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
        }
    }
}
