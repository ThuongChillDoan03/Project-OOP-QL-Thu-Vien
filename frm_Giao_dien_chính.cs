using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Admin;

namespace PROJECT_CK_20231
{
 
    //public delegate void ButtonClickHandler(object sender, EventArgs e);
    //public event ButtonClickHandler ButtonClicked;
    public partial class Form_Dangnhap : Form
    {

        public Form_Dangnhap()
        {
            InitializeComponent();
        }

        /*private void buttonInFormA_Click(object sender, EventArgs e)
        {
            // Khi button được click, gửi event đến các subscriber
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }*/

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


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();
            if (rad_Docgia.Checked)
            {
                
                if (connection.State == ConnectionState.Open)
                {
                    //_________________Tai_khoan_______________________________

                    string inputText_Taikhoan = tex_Taikhoan.Text; // Lấy dữ liệu từ TextBox
                    string query1 = "SELECT COUNT(*) FROM user WHERE Account = @InputText_Taikhoan"; // Thay thế tên bảng, cột và tham số query

                    MySqlCommand command1 = new MySqlCommand(query1, connection);
                    command1.Parameters.AddWithValue("@InputText_Taikhoan", inputText_Taikhoan);

                    int count1 = Convert.ToInt32(command1.ExecuteScalar());


                    //_________________Mat_khau________________________________

                    string inputText_Matkhau = tex_Matkhau.Text; // Lấy dữ liệu từ TextBox
                    string query2 = "SELECT COUNT(*) FROM user WHERE Password = @InputText_Matkhau AND Account = @InputText_Taikhoan"; // Thay thế tên bảng, cột và tham số query

                    MySqlCommand command2 = new MySqlCommand(query2, connection);
                    command2.Parameters.AddWithValue("@InputText_Matkhau", inputText_Matkhau);
                    command2.Parameters.AddWithValue("@InputText_Taikhoan", inputText_Taikhoan);

                    int count2 = Convert.ToInt32(command2.ExecuteScalar());


                    if (count2 > 0)     //__________Tìm tài khoản trong Database_____//
                    {
                        Form_gduser users = new Form_gduser(tex_Taikhoan.Text);
                        users.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Thông tin đăng nhập chưa chính xác");
                    }
                }
            }
            if (rad_Nhanvien.Checked)
            {
                if (connection.State == ConnectionState.Open)
                {
                    //_________________Tai_khoan_______________________________

                    string inputText_Taikhoan = tex_Taikhoan.Text; // Lấy dữ liệu từ TextBox
                    string inputText_Matkhau = tex_Matkhau.Text;
                    

                    string query2 = "SELECT COUNT(*) FROM `staff_account` WHERE Password = @InputText_Matkhau AND Account = @InputText_Taikhoan"; // Thay thế tên bảng, cột và tham số query

                    MySqlCommand command2 = new MySqlCommand(query2, connection);
                    command2.Parameters.AddWithValue("@InputText_Matkhau", inputText_Matkhau);
                    command2.Parameters.AddWithValue("@InputText_Taikhoan", inputText_Taikhoan);
                    int count2 = Convert.ToInt32(command2.ExecuteScalar());


                    if (count2 > 0)     //__________Tìm tài khoản trong Database_____//
                    {
                        Frm_qlsach users = new Frm_qlsach();
                        users.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Thông tin đăng nhập chưa chính xác");
                    }
                }
            }

            if (rad_Nguoiquanly.Checked)
            {
                if (connection.State == ConnectionState.Open)
                {
                    //_________________Tai_khoan_______________________________

                    string inputText_Taikhoan = tex_Taikhoan.Text; // Lấy dữ liệu từ TextBox
                    string inputText_Matkhau = tex_Matkhau.Text;


                    string query2 = "SELECT COUNT(*) FROM `admin` WHERE Password = @InputText_Matkhau AND Account = @InputText_Taikhoan"; // Thay thế tên bảng, cột và tham số query

                    MySqlCommand command2 = new MySqlCommand(query2, connection);
                    command2.Parameters.AddWithValue("@InputText_Matkhau", inputText_Matkhau);
                    command2.Parameters.AddWithValue("@InputText_Taikhoan", inputText_Taikhoan);
                    int count2 = Convert.ToInt32(command2.ExecuteScalar());


                    if (count2 > 0)     //__________Tìm tài khoản trong Database_____//
                    {
                        Admin_HomePage frm_homepage = new Admin_HomePage(tex_Taikhoan.Text);
                        frm_homepage.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Thông tin đăng nhập chưa chính xác");
                    }
                }
            }


            

        }

        private void tex_Taikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void but_dki_Click(object sender, EventArgs e)
        {
            Form5 users5 = new Form5();
            users5.ShowDialog();
        }

        private void rad_Nhanvien_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
