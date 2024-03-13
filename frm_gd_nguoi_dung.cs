using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace PROJECT_CK_20231
{
    public partial class Form_gduser : Form
    {
        private string ID_Account;       //lấy ID từ form1

        private float previousWidth;
        private float previousHeight;

        public Form_gduser(string ID_user)
        {
            InitializeComponent();
            this.AcceptButton = but_Timkiemsach;
            previousWidth = this.Width;
            previousHeight = this.Height; 
            this.SizeChanged += Form_gduser_SizeChanged;
            this.ID_Account = ID_user;
        }


        // Tạo một thuộc tính để nhận dữ liệu từ Form1
        /*public string ReceivedDataFromForm1
        {
            get { return receivedDataFromForm1; }
            set { receivedDataFromForm1 = value; }
        }*/

        private void Form_gduser_SizeChanged(object sender, EventArgs e)
        {

            float widthChangeRatio = (float)this.Width / previousWidth;
            float heightChangeRatio = (float)this.Height / previousHeight;

            ScaleControls(widthChangeRatio, heightChangeRatio);

            previousWidth = this.Width;
            previousHeight = this.Height;
        }

        private void ScaleControls(float widthChangeRatio, float heightChangeRatio)
        {
            foreach (Control control in this.Controls)
            {
                control.Left = (int)(control.Left * widthChangeRatio);
                control.Top = (int)(control.Top * heightChangeRatio);
                control.Width = (int)(control.Width * widthChangeRatio);
                control.Height = (int)(control.Height * heightChangeRatio);

                // Các điều chỉnh khác nếu cần thiết cho từng control
            }
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tab_Trangchu.SelectedIndex = 2;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void Themsach(System.Windows.Forms.PictureBox picBox2, System.Windows.Forms.TextBox textbox5, System.Windows.Forms.TextBox textbox6, System.Windows.Forms.TextBox textbox9)
        {
            picBox2.Image = pic_Sachtimkiem.Image;
            textbox5.Text = tex_Tensach.Text;
            textbox6.Text = "Tác giả: " + tex_Tendaydutacgia.Text;
            textbox9.Text = tex_UID.Text;
        }


        private void vbButton1_Click(object sender, EventArgs e)
        {
            if (tex_Tensach.Text != "Tên sách")
            {
                MySqlConnection connection = tao_connetion();
                connection.Open();


                string queryp = "SELECT * FROM `giohang` WHERE  `Reader_ID` = @ID_Account"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
                MySqlCommand cmdp = new MySqlCommand(queryp, connection);
                cmdp.Parameters.AddWithValue("@ID_Account", ID_Account);

                //____________________Lấy data___________________//
                MySqlDataAdapter adapterp = new MySqlDataAdapter(cmdp);
                DataTable dataTablep = new DataTable();
                adapterp.Fill(dataTablep);
                int rowCount1 = dataTablep.Rows.Count;

                if (rowCount1 > 7)
                {
                    MessageBox.Show("Giỏ sách đã đầy!!!");
                }
                if (rowCount1 == 0)
                {
                    Themsach(pic_1, tex_Ten1, tex_T1, UID1);
                    MessageBox.Show("Đã thêm vào giỏ sách!!!");
                }
                if (rowCount1 == 1)
                {
                    Themsach(pic_2, tex_Ten2, tex_T2, UID2);
                    MessageBox.Show("Đã thêm vào giỏ sách!!!");
                }
                if (rowCount1 == 2)
                {
                    Themsach(pic_3, tex_Ten3, tex_T3, UID3);
                    MessageBox.Show("Đã thêm vào giỏ sách!!!");
                }
                if (rowCount1 == 3)
                {
                    Themsach(pic_4, tex_Ten4, tex_T4, UID4);
                    MessageBox.Show("Đã thêm vào giỏ sách!!!");
                }
                if (rowCount1 == 4)
                {
                    Themsach(pic_5, tex_Ten5, tex_T5, UID5);
                    MessageBox.Show("Đã thêm vào giỏ sách!!!");
                }
                if (rowCount1 == 5)
                {
                    Themsach(pic_6, tex_Ten6, tex_T6, UID6);
                    MessageBox.Show("Đã thêm vào giỏ sách!!!");
                }
                if (rowCount1 == 6)
                {
                    Themsach(pic_7, tex_Ten7, tex_T7, UID7);
                    MessageBox.Show("Đã thêm vào giỏ sách!!!");
                }
                if (rowCount1 == 7)
                {
                    Themsach(pic_8, tex_Ten8, tex_T8, UID8);
                    MessageBox.Show("Đã thêm vào giỏ sách!!!");
                }
                

                //___________________________________________UPDATE VÀO DATABASE_____________________________________//
                string UID = tex_UID.Text;

                /*string updategiohang = "UPDATE `giohang` SET `Reader_ID` = @ID_Account WHERE `Mã sách` = @UID;";
                MySqlCommand updategiohangCmd = new MySqlCommand(updategiohang, connection);
                updategiohangCmd.Parameters.AddWithValue("@ID_Account", ID_Account);
                updategiohangCmd.Parameters.AddWithValue("@UID", UID); // Thay 'ten_nguoidung' bằng tên người dùng
                updategiohangCmd.ExecuteNonQuery();*/

                string insertQuery = "INSERT INTO `giohang` (Reader_ID, Book_ID) VALUES (@ID_Account, @UID)";
                MySqlCommand insertQuerycmd = new MySqlCommand(insertQuery, connection);
                insertQuerycmd.Parameters.AddWithValue("@ID_Account", ID_Account);
                insertQuerycmd.Parameters.AddWithValue("@UID", UID); // Thay 'ten_nguoidung' bằng tên người dùng
                insertQuerycmd.ExecuteNonQuery();

            }
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }





        private void but_Trangchu_Click(object sender, EventArgs e)
        {
            tab_Trangchu.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tab_Trangchu.SelectedIndex = 1;
        }

        private void lienhe_Click(object sender, EventArgs e)
        {
            tab_Trangchu.SelectedIndex = 0;
        }

        private void but_Lienhe_Click(object sender, EventArgs e)
        {
            tab_Trangchu.SelectedIndex = 3;
        }

        private void but_Muonsach_Click(object sender, EventArgs e)
        {
            tab_Danhmuc.SelectedIndex = 0;
        }

        private void but_Tusach_Click(object sender, EventArgs e)
        {
            tab_Danhmuc.SelectedIndex = 1;
        }

        private void but_Lichsu_Click(object sender, EventArgs e)
        {
            tab_Danhmuc.SelectedIndex = 2;
        }

        private void but_Thebandoc_Click(object sender, EventArgs e)
        {
            tab_Danhmuc.SelectedIndex = 3;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Name_Click(object sender, EventArgs e)
        {
            
        }


        private void vbButton4_Click(object sender, EventArgs e)
        {
           
            Form_Thongtinnguoidung Thongtin = new Form_Thongtinnguoidung(ID_Account);
            Thongtin.ShowDialog();
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {

            Form_Thongtinnguoidung Thongtin = new Form_Thongtinnguoidung(ID_Account);
            Thongtin.ShowDialog();

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tex_Timkiemsach_TextChanged(object sender, EventArgs e)
        {

        }

        private void tex_Thongtinsach1_TextChanged(object sender, EventArgs e)
        {

        }

        private string GetRandomImageUrl()
        {
            // Thay đổi kích thước và các thông số khác nếu cần
            int width = 800;
            int height = 600;

            // Tạo URL cho hình ảnh ngẫu nhiên từ Lorem Picsum
            return $"https://picsum.photos/{width}/{height}/?random";
        }


        private void but_Timkiemsach_Click(object sender, EventArgs e)
        {
            //MySqlConnection connection = tao_connetion();
            //connection.Open();

            tex_Thongtinsach1.Text = "";
            tex_Thongtinsach2.Text = "";
            tex_Thongtinsach3.Text = "";
            tex_Thongtinsach4.Text = "";

            string searchText = tex_Timkiemsach.Text.Trim(); // Lấy dữ liệu từ TextBox
            if (!string.IsNullOrEmpty(searchText))
            {
                MySqlConnection connection = tao_connetion();
                connection.Open();

                string query = "SELECT * FROM `table books` WHERE  `Tên sách` = @searchText"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@searchText", searchText);

                //____________________Lấy data___________________//
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //dataGridView.DataSource = dataTable; // Hiển thị kết quả trong Datagridview 


                int rowCount = dataTable.Rows.Count;
                if (rowCount > 3)
                {
                    DataRow row1 = dataTable.Rows[0];
                    DataRow row2 = dataTable.Rows[1];
                    DataRow row3 = dataTable.Rows[2];
                    DataRow row4 = dataTable.Rows[3];
                    tex_Thongtinsach1.Text = row1["Tên sách"].ToString();
                    tex_Thongtinsach1.AppendText(Environment.NewLine + row1["Tên tác giả"] + " - " + row1["Năm xuất bản"]);
                    tex_Thongtinsach2.Text = row2["Tên sách"].ToString();
                    tex_Thongtinsach2.AppendText(Environment.NewLine + row2["Tên tác giả"] + " - " + row2["Năm xuất bản"]);
                    tex_Thongtinsach3.Text = row3["Tên sách"].ToString();
                    tex_Thongtinsach3.AppendText(Environment.NewLine + row3["Tên tác giả"] + " - " + row3["Năm xuất bản"]);
                    tex_Thongtinsach4.Text = row4["Tên sách"].ToString();
                    tex_Thongtinsach4.AppendText(Environment.NewLine + row4["Tên tác giả"] + " - " + row4["Năm xuất bản"]);
                }
                if (rowCount == 3)
                {
                    DataRow row1 = dataTable.Rows[0];
                    DataRow row2 = dataTable.Rows[1];
                    DataRow row3 = dataTable.Rows[2];          
                    tex_Thongtinsach1.Text = row1["Tên sách"].ToString();
                    tex_Thongtinsach1.AppendText(Environment.NewLine + row1["Tên tác giả"] + " - " + row1["Năm xuất bản"]);
                    tex_Thongtinsach2.Text = row2["Tên sách"].ToString();
                    tex_Thongtinsach2.AppendText(Environment.NewLine + row2["Tên tác giả"] + " - " + row2["Năm xuất bản"]);
                    tex_Thongtinsach3.Text = row3["Tên sách"].ToString();
                    tex_Thongtinsach3.AppendText(Environment.NewLine + row3["Tên tác giả"] + " - " + row3["Năm xuất bản"]);
                }
                if (rowCount == 2)
                {
                    DataRow row1 = dataTable.Rows[0];
                    DataRow row2 = dataTable.Rows[1];                 
                    tex_Thongtinsach1.Text = row1["Tên sách"].ToString();
                    tex_Thongtinsach1.AppendText(Environment.NewLine + row1["Tên tác giả"] + " - " + row1["Năm xuất bản"]);
                    tex_Thongtinsach2.Text = row2["Tên sách"].ToString();
                    tex_Thongtinsach2.AppendText(Environment.NewLine + row2["Tên tác giả"] + " - " + row2["Năm xuất bản"]);
                }
                if (rowCount == 1)
                {
                    DataRow row1 = dataTable.Rows[0];
                    tex_Thongtinsach1.Text = row1["Tên sách"].ToString();
                    tex_Thongtinsach1.AppendText(Environment.NewLine + row1["Tên tác giả"] + " - " + row1["Năm xuất bản"]);
                }

                tex_KQ_Timkiemsach2.Text = tex_Timkiemsach.Text;
            }
        }

        private void tex_Thongtinsach1_Click(object sender, EventArgs e)
        {
            but_Chitietsach1.Focus();
        }



        private void button1_Click_1(object sender, EventArgs e)        //Hiện thông tin chi tiết cho sách 1 
        {
            string searchText = tex_Timkiemsach.Text.Trim(); // Lấy dữ liệu từ TextBox
            if (!string.IsNullOrEmpty(searchText) && tex_Thongtinsach1.Text != "")
            {

                MySqlConnection connection = tao_connetion();
                connection.Open();

                string query = "SELECT * FROM `table books` WHERE  `Tên sách` = @searchText"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@searchText", searchText);

                //____________________Lấy data___________________//
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DataRow row = dataTable.Rows[0];
                tex_Tensach.Text = row["Tên sách"].ToString();
                tex_Tendaydutacgia.Text = row["Tên tác giả"].ToString();
                tex_Theloai.Text = row["Thể loại"].ToString();
                tex_Phathanh.Text = row["Năm xuất bản"].ToString();
                tex_UID.Text = row["Mã sách"].ToString();

                tex_Noidungchinh.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                    "Cras lacinia scelerisque augue quis mattis. " +
                    "Quisque ipsum massa, convallis et lacus quis, mattis interdum ante. " +
                    "Curabitur porta nunc in dapibus lobortis. Praesent a nibh pharetra, posuere sem vel, molestie nunc. " +
                    "Maecenas varius a enim ultricies rutrum. Donec ultricies scelerisque semper. " +
                    "Pellentesque at purus eu tortor euismod interdum. Nunc sollicitudin ante massa, ac ornare ante pharetra eget. " +
                    "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; " +
                    "Integer egestas tincidunt aliquet.";


                string imageURL = GetRandomImageUrl();
                WebClient webClient = new WebClient();
                byte[] data = webClient.DownloadData(imageURL);

                using (var stream = new System.IO.MemoryStream(data))
                {
                    Image image_book = Image.FromStream(stream);
                    pic_Sachtimkiem.Image = image_book;

                }

            }
        }



        private void AssignValues(System.Windows.Forms.PictureBox picBox, System.Windows.Forms.TextBox textbox1, System.Windows.Forms.TextBox textbox2, System.Windows.Forms.TextBox textbox3, int n)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();
            string imageURL = GetRandomImageUrl();
            WebClient webClient = new WebClient();
            byte[] data = webClient.DownloadData(imageURL);

            using (var stream = new System.IO.MemoryStream(data))
            {
                Image image_book = Image.FromStream(stream);
                picBox.Image = image_book;

            }

            string query1 = "SELECT * FROM `bill mượn` WHERE  `Mã độc giả` = @ID_Account"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
            MySqlCommand cmd1 = new MySqlCommand(query1, connection);
            cmd1.Parameters.AddWithValue("@ID_Account", ID_Account);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);
            DataTable dataTable1 = new DataTable();
            adapter1.Fill(dataTable1);
            DataRow row = dataTable1.Rows[n];

            textbox3.Text = "Mã mượn sách: " + row["Mã mượn"].ToString();
            textbox3.AppendText(Environment.NewLine + "ID: sách: " + row["Mã sách"].ToString());
            textbox3.AppendText(Environment.NewLine + "Thời gian mượn sách: " + row["Mã mượn"].ToString());

            //__________________________________________________________________________//
            string str_bookid = row["Mã sách"].ToString();

            string query2 = "SELECT * FROM `table books` WHERE  `Mã sách` = @str_bookid"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
            MySqlCommand cmd2 = new MySqlCommand(query2, connection);
            cmd2.Parameters.AddWithValue("@str_bookid", str_bookid);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2);
            DataTable dataTable2 = new DataTable();
            adapter2.Fill(dataTable2);
            DataRow row2 = dataTable2.Rows[0];

            textbox1.Text = row2["Tên sách"].ToString();
            textbox2.Text = "Tác  giả: " + row2["Tên tác giả"].ToString();

        }

        private void AssignValuesgiohang(System.Windows.Forms.PictureBox picBox1, System.Windows.Forms.TextBox textbox3, System.Windows.Forms.TextBox textbox4, System.Windows.Forms.TextBox textbox5,int k)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();
            string imageURL = GetRandomImageUrl();
            WebClient webClient = new WebClient();
            byte[] data = webClient.DownloadData(imageURL);

            using (var stream = new System.IO.MemoryStream(data))
            {
                Image image_book = Image.FromStream(stream);
                picBox1.Image = image_book;

            }


            //////_______________________________________________________________________////
            ///


            string queryq = "SELECT * FROM `giohang` WHERE  `Reader_ID` = @ID_Account"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
            MySqlCommand cmdq = new MySqlCommand(queryq, connection);
            cmdq.Parameters.AddWithValue("@ID_Account", ID_Account);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapterq = new MySqlDataAdapter(cmdq);
            DataTable dataTableq = new DataTable();
            adapterq.Fill(dataTableq);
            DataRow row3 = dataTableq.Rows[k];
            string str_bookid1 = row3["Book_ID"].ToString();


            //__________________________________________________________________________//

            string query3 = "SELECT * FROM `table books` WHERE  `Mã sách` = @str_bookid1"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
            MySqlCommand cmd3 = new MySqlCommand(query3, connection);
            cmd3.Parameters.AddWithValue("@str_bookid1", str_bookid1);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapter3 = new MySqlDataAdapter(cmd3);
            DataTable dataTable4 = new DataTable();
            adapter3.Fill(dataTable4);
            DataRow row4 = dataTable4.Rows[0];

            textbox3.Text = row4["Tên sách"].ToString();
            textbox4.Text = "Tác  giả: " + row4["Tên tác giả"].ToString();
            textbox5.Text = row4["Mã sách"].ToString();
        }

        private void pic_Sachtimkiem_Click(object sender, EventArgs e)
        {
             
        }

        private string str1;
        private string str2;
        private void Form_gduser_Load(object sender, EventArgs e)
        {

            MySqlConnection connection = tao_connetion();
            connection.Open();

            string query = "SELECT * FROM `customers` WHERE  `Reader_ID` = @ID_Account"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID_Account", ID_Account);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DataRow row = dataTable.Rows[0];

            vbB_NameUser.Text = row["Reader_Name"].ToString();

            string str1 = row["Cardreader_Status"].ToString();
            int numSTR = int.Parse(str1);

            if (numSTR == 1)
            {
                tex_Tenthe.AppendText(" " + row["Reader_Name"].ToString());
                tex_Ngaysinhthe.AppendText(" " + row["Birthday"].ToString());
                tex_Gioitinhthe.AppendText(" " + row["Reader_Sex"].ToString());
                tex_Diachithe.AppendText(" " + row["Reader_Address"].ToString());
                tex_Mathe.AppendText(" " + row["Reader_ID"].ToString());
            }

            if (numSTR == 0)
            {
                tex_Chuacothe.Text = "Bạn chưa có thẻ bạn đọc. Vui lòng đăng kí!!!";
            }


            //________________________________________________________________________________//



            string queryk = "SELECT * FROM `bill mượn` WHERE  `Mã độc giả` = @ID_Account"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
            MySqlCommand cmdk = new MySqlCommand(queryk, connection);
            cmdk.Parameters.AddWithValue("@ID_Account", ID_Account);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapterk = new MySqlDataAdapter(cmdk);
            DataTable dataTablek = new DataTable();
            adapterk.Fill(dataTablek);
            int rowCount = dataTablek.Rows.Count;

            if (rowCount == 0)
            {
                tex_DL1.Text = "Bạn đọc chưa mượn sách ở thử viện";
            }

            if (rowCount == 1)
            {
                AssignValues(pic_ls1, tex_Tenls1, tex_TG1, tex_DL1, 0);
            }

            if (rowCount == 2)
            {
                AssignValues(pic_ls1, tex_Tenls1, tex_TG1, tex_DL1, 0);
                AssignValues(pic_ls2, tex_Tenls2, tex_TG2, tex_DL2, 1);
            }
            if (rowCount >= 3)
            {
                AssignValues(pic_ls1, tex_Tenls1, tex_TG1, tex_DL1, 0);
                AssignValues(pic_ls2, tex_Tenls2, tex_TG2, tex_DL2, 1);
                AssignValues(pic_ls3, tex_Tenls3, tex_TG3, tex_DL3, 2);
            }


            //________________________________________________________________________________//


            string queryp = "SELECT * FROM `giohang` WHERE  `Reader_ID` = @ID_Account"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
            MySqlCommand cmdp = new MySqlCommand(queryp, connection);
            cmdp.Parameters.AddWithValue("@ID_Account", ID_Account);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapterp = new MySqlDataAdapter(cmdp);
            DataTable dataTablep = new DataTable();
            adapterp.Fill(dataTablep);
            int rowCount1 = dataTablep.Rows.Count;
            

            if (rowCount1 == 0)
            {
                tex_TB.Text = "Không có quyển sách nào trong giỏ hàng!!!";
            }
            if (rowCount1 == 1)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
            }
            if (rowCount1 == 2)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
                AssignValuesgiohang(pic_2, tex_Ten2, tex_T2, UID2, 1);
            }
            if (rowCount1 == 3)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
                AssignValuesgiohang(pic_2, tex_Ten2, tex_T2, UID2, 1);
                AssignValuesgiohang(pic_3, tex_Ten3, tex_T3, UID3, 2);
            }
            if (rowCount1 == 4)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
                AssignValuesgiohang(pic_2, tex_Ten2, tex_T2, UID2, 1);
                AssignValuesgiohang(pic_3, tex_Ten3, tex_T3, UID3, 2);
                AssignValuesgiohang(pic_4, tex_Ten4, tex_T4, UID4, 3);
            }
            if (rowCount1 == 5)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
                AssignValuesgiohang(pic_2, tex_Ten2, tex_T2, UID2, 1);
                AssignValuesgiohang(pic_3, tex_Ten3, tex_T3, UID3, 2);
                AssignValuesgiohang(pic_4, tex_Ten4, tex_T4, UID4, 3);
                AssignValuesgiohang(pic_5, tex_Ten5, tex_T5, UID5, 4);
            }
            if (rowCount1 == 6)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
                AssignValuesgiohang(pic_2, tex_Ten2, tex_T2, UID2, 1);
                AssignValuesgiohang(pic_3, tex_Ten3, tex_T3, UID3, 2);
                AssignValuesgiohang(pic_4, tex_Ten4, tex_T4, UID4, 3);
                AssignValuesgiohang(pic_5, tex_Ten5, tex_T5, UID5, 4);
                AssignValuesgiohang(pic_6, tex_Ten6, tex_T6, UID6, 5);
            }
            if (rowCount1 == 7)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
                AssignValuesgiohang(pic_2, tex_Ten2, tex_T2, UID2, 1);
                AssignValuesgiohang(pic_3, tex_Ten3, tex_T3, UID3, 2);
                AssignValuesgiohang(pic_4, tex_Ten4, tex_T4, UID4, 3);
                AssignValuesgiohang(pic_5, tex_Ten5, tex_T5, UID5, 4);
                AssignValuesgiohang(pic_6, tex_Ten6, tex_T6, UID6, 5);
                AssignValuesgiohang(pic_7, tex_Ten7, tex_T7, UID7, 6);
            }
            if (rowCount1 == 8)
            {
                AssignValuesgiohang(pic_1,tex_Ten1,tex_T1,UID1,0);
                AssignValuesgiohang(pic_2,tex_Ten2,tex_T2,UID2,1);
                AssignValuesgiohang(pic_3,tex_Ten3,tex_T3,UID3,2);
                AssignValuesgiohang(pic_4,tex_Ten4,tex_T4,UID4,3);
                AssignValuesgiohang(pic_5,tex_Ten5,tex_T5,UID5,4);
                AssignValuesgiohang(pic_6,tex_Ten6,tex_T6,UID6,5);
                AssignValuesgiohang(pic_7,tex_Ten7,tex_T7,UID7,6);
                AssignValuesgiohang(pic_8,tex_Ten8,tex_T8,UID8,7);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pan_Chitietsach_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pic_Muonsach_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }



        private void but_Chitietsach3_Click(object sender, EventArgs e)
        {

            string searchText = tex_Timkiemsach.Text.Trim(); // Lấy dữ liệu từ TextBox
            if (!string.IsNullOrEmpty(searchText) && tex_Thongtinsach3.Text != "")
            {

                MySqlConnection connection = tao_connetion();
                connection.Open();

                string query = "SELECT * FROM `table books` WHERE  `Tên sách` = @searchText"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@searchText", searchText);

                //____________________Lấy data___________________//
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DataRow row = dataTable.Rows[2];
                tex_Tensach.Text = row["Tên sách"].ToString();
                tex_Tendaydutacgia.Text = row["Tên tác giả"].ToString();
                tex_Theloai.Text = row["Thể loại"].ToString();
                tex_Phathanh.Text = row["Năm xuất bản"].ToString();
                tex_Noidungchinh.Text = "„Die Verwandlung“ von Franz Kafka ist die Geschichte von Gregor Samsa, einem Arbeiter, der sich eines " +
                    "Morgens plötzlich in einen riesigen Wurm verwandelt. Dieser Übergang führt zu vielen Schwierigkeiten im " +
                    "Familienleben, da sie versuchen, seine Veränderung zu verstehen und zu akzeptieren. Gregor sieht sich mit " +
                    "Einsamkeit und Ungerechtigkeit konfrontiert, als er nach seiner Verwandlung von seinen Verwandten und der " +
                    "Gesellschaft abgelehnt wird. Gregors Leben wird immer schwieriger und schließlich stirbt er allein in Vergessenheit. " +
                    "„Die Verwandlung“ wird oft als ein Werk über Autonomie, Einsamkeit und menschliche Tragödie verstanden.";


                string imageURL = GetRandomImageUrl();
                WebClient webClient = new WebClient();
                byte[] data = webClient.DownloadData(imageURL);

                using (var stream = new System.IO.MemoryStream(data))
                {
                    Image image_book = Image.FromStream(stream);
                    pic_Sachtimkiem.Image = image_book;

                }

            }
        }


        private void but_Chitietsach2_Click(object sender, EventArgs e)
        {
            
            string searchText = tex_Timkiemsach.Text.Trim(); // Lấy dữ liệu từ TextBox
            if (!string.IsNullOrEmpty(searchText) && tex_Thongtinsach2.Text != "")
            {

                MySqlConnection connection = tao_connetion();
                connection.Open();

                string query = "SELECT * FROM `table books` WHERE  `Tên sách` = @searchText"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@searchText", searchText);

                //____________________Lấy data___________________//
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DataRow row = dataTable.Rows[1];
                tex_Tensach.Text = row["Tên sách"].ToString();
                tex_Tendaydutacgia.Text = row["Tên tác giả"].ToString();
                tex_Theloai.Text = row["Thể loại"].ToString();
                tex_Phathanh.Text = row["Năm xuất bản"].ToString();
                tex_Noidungchinh.Text = "The story opens with a celebration party for the wizarding world, " +
                    "which for many years has been dominated by the Dark Lord Voldemort. The night before, " +
                    "Voldemort had found the Potter family home in Godric's Hollow and killed Lily and James " +
                    "Potter because a prophecy predicted that they would influence Voldemort that he would be defeated " +
                    "by \"the child\". born when July was gone\" Voldemort believed that the child was Harry Potter. " +
                    "However, when he attempted to kill Harry, the Avada Kedavra Killing Curse rebounded, and Voldemort " +
                    "was destroyed, remaining only a soul, neither alive nor dead. From then on, a lightning-shaped scar" +
                    " appeared on Harry's forehead, the only outward sign of the curse. He was the only survivor " +
                    "when hit by this curse, and his mysterious defeat of Voldemort earned him the title \"The Boy " +
                    "Who Lived\" and \"The Boy Who Lived\" by the wizarding community.\r\n\r\nThe next night, a " +
                    "wizard who cannot use magic (Rubeus Hagrid) brings Harry to his aunt and uncle's family, " +
                    "which will be his home for the next 10 years. Orphaned Harry was then raised by the Dursley family - " +
                    "who were not wizards and always tried everything to prevent him from gaining magical powers. " +
                    "Harry's aunt and uncle always spurned him, because they hated magic so much that Harry's aunt " +
                    "and uncle hid all the magical assets he inherited and always punished him severely when something " +
                    "unusual happened. happen.";



                string imageURL = GetRandomImageUrl();
                WebClient webClient = new WebClient();
                byte[] data = webClient.DownloadData(imageURL);

                using (var stream = new System.IO.MemoryStream(data))
                {
                    Image image_book = Image.FromStream(stream);
                    pic_Sachtimkiem.Image = image_book;

                }

            }
        }

        private void but_Chitietsach4_Click(object sender, EventArgs e)
        {
            string searchText = tex_Timkiemsach.Text.Trim(); // Lấy dữ liệu từ TextBox
            if (!string.IsNullOrEmpty(searchText) && tex_Thongtinsach4.Text != "")
            {

                MySqlConnection connection = tao_connetion();
                connection.Open();

                string query = "SELECT * FROM `table books` WHERE  `Tên sách` = @searchText"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@searchText", searchText);

                //____________________Lấy data___________________//
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DataRow row = dataTable.Rows[3];
                tex_Tensach.Text = row["Tên sách"].ToString();
                tex_Tendaydutacgia.Text = row["Tên tác giả"].ToString();
                tex_Theloai.Text = row["Thể loại"].ToString();
                tex_Phathanh.Text = row["Năm xuất bản"].ToString();
                tex_Noidungchinh.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                    "Cras lacinia scelerisque augue quis mattis. " +
                    "Quisque ipsum massa, convallis et lacus quis, mattis interdum ante. " +
                    "Curabitur porta nunc in dapibus lobortis. Praesent a nibh pharetra, posuere sem vel, molestie nunc. " +
                    "Maecenas varius a enim ultricies rutrum. Donec ultricies scelerisque semper. " +
                    "Pellentesque at purus eu tortor euismod interdum. Nunc sollicitudin ante massa, ac ornare ante pharetra eget. " +
                    "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; " +
                    "Integer egestas tincidunt aliquet.";


                string imageURL = GetRandomImageUrl();
                WebClient webClient = new WebClient();
                byte[] data = webClient.DownloadData(imageURL);

                using (var stream = new System.IO.MemoryStream(data))
                {
                    Image image_book = Image.FromStream(stream);
                    pic_Sachtimkiem.Image = image_book;

                }

            }
        }

        private void tex_Diachithe_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {

        }

        private void pan_Tieude_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tex_Mathe_TextChanged(object sender, EventArgs e)
        {

        }

        private void tex_DL1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tex_Tenthe_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pic_1_Click(object sender, EventArgs e)
        {

        }

        private void tex_Ten1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tex_Ten5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tex_Ten2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xoagiatri(System.Windows.Forms.PictureBox picBox3, System.Windows.Forms.TextBox textbox7, System.Windows.Forms.TextBox textbox8, System.Windows.Forms.TextBox textbox9)
        {
            MySqlConnection connection = tao_connetion();
            connection.Open();

            string ID = textbox9.Text;
            string deletequery = "DELETE FROM `giohang` WHERE `Book_ID` = @ID";
            MySqlCommand cmdp = new MySqlCommand(deletequery, connection);
            cmdp.Parameters.AddWithValue("@ID", ID);
            cmdp.ExecuteNonQuery();


            picBox3.Image = null;
            textbox7.Text = "";
            textbox8.Text = "";
        }

        private void xoa(System.Windows.Forms.PictureBox picBox0, System.Windows.Forms.TextBox textbox0, System.Windows.Forms.TextBox textbox1, System.Windows.Forms.TextBox textbox2)
        {
            picBox0.Image = null;
            textbox0.Text = "";
            textbox1.Text = "";
            textbox2.Text = "";
        }

        private void vbButton4_Click_1(object sender, EventArgs e)
        {
            if (check_1.Checked)
            {
                xoagiatri(pic_1, tex_Ten1, tex_T1, UID1);
                check_1.Checked = false;
            }
            if (check_2.Checked)
            {
                xoagiatri(pic_2, tex_Ten2, tex_T2, UID2);
                check_2.Checked = false;
            }
            if (check_3.Checked)
            {
                xoagiatri(pic_3, tex_Ten3, tex_T3, UID3);
                check_3.Checked = false;
            }
            if (check_4.Checked)
            {
                xoagiatri(pic_4, tex_Ten4, tex_T4, UID4);
                check_4.Checked = false;
            }
            if (check_5.Checked)
            {
                xoagiatri(pic_5, tex_Ten5, tex_T5, UID5);
                check_5.Checked = false;
            }
            if (check_6.Checked)
            {
                xoagiatri(pic_6, tex_Ten6, tex_T6, UID6);
                check_6.Checked = false;
            }
            if (check_7.Checked)
            {
                xoagiatri(pic_7, tex_Ten7, tex_T7, UID7);
                check_7.Checked = false;
            }
            if (check_8.Checked)
            {
                xoagiatri(pic_8, tex_Ten8, tex_T8, UID8);
                check_8.Checked = false;
            }

            xoa(pic_1, tex_Ten1, tex_T1, UID1);
            xoa(pic_2, tex_Ten2, tex_T2, UID2);
            xoa(pic_3, tex_Ten3, tex_T3, UID3);
            xoa(pic_4, tex_Ten4, tex_T4, UID4);
            xoa(pic_5, tex_Ten5, tex_T5, UID5);
            xoa(pic_6, tex_Ten6, tex_T6, UID6);
            xoa(pic_7, tex_Ten7, tex_T7, UID7);
            xoa(pic_8, tex_Ten8, tex_T8, UID8);

            MySqlConnection connection = tao_connetion();
            connection.Open();

            string queryp = "SELECT * FROM `giohang` WHERE  `Reader_ID` = @ID_Account"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
            MySqlCommand cmdp = new MySqlCommand(queryp, connection);
            cmdp.Parameters.AddWithValue("@ID_Account", ID_Account);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapterp = new MySqlDataAdapter(cmdp);
            DataTable dataTablep = new DataTable();
            adapterp.Fill(dataTablep);
            int rowCount1 = dataTablep.Rows.Count;


            if (rowCount1 == 0)
            {
                tex_TB.Text = "Không có quyển sách nào trong giỏ hàng!!!";
            }
            if (rowCount1 == 1)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
            }
            if (rowCount1 == 2)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
                AssignValuesgiohang(pic_2, tex_Ten2, tex_T2, UID2, 1);
            }
            if (rowCount1 == 3)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
                AssignValuesgiohang(pic_2, tex_Ten2, tex_T2, UID2, 1);
                AssignValuesgiohang(pic_3, tex_Ten3, tex_T3, UID3, 2);
            }
            if (rowCount1 == 4)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
                AssignValuesgiohang(pic_2, tex_Ten2, tex_T2, UID2, 1);
                AssignValuesgiohang(pic_3, tex_Ten3, tex_T3, UID3, 2);
                AssignValuesgiohang(pic_4, tex_Ten4, tex_T4, UID4, 3);
            }
            if (rowCount1 == 5)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
                AssignValuesgiohang(pic_2, tex_Ten2, tex_T2, UID2, 1);
                AssignValuesgiohang(pic_3, tex_Ten3, tex_T3, UID3, 2);
                AssignValuesgiohang(pic_4, tex_Ten4, tex_T4, UID4, 3);
                AssignValuesgiohang(pic_5, tex_Ten5, tex_T5, UID5, 4);
            }
            if (rowCount1 == 6)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
                AssignValuesgiohang(pic_2, tex_Ten2, tex_T2, UID2, 1);
                AssignValuesgiohang(pic_3, tex_Ten3, tex_T3, UID3, 2);
                AssignValuesgiohang(pic_4, tex_Ten4, tex_T4, UID4, 3);
                AssignValuesgiohang(pic_5, tex_Ten5, tex_T5, UID5, 4);
                AssignValuesgiohang(pic_6, tex_Ten6, tex_T6, UID6, 5);
            }
            if (rowCount1 == 7)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
                AssignValuesgiohang(pic_2, tex_Ten2, tex_T2, UID2, 1);
                AssignValuesgiohang(pic_3, tex_Ten3, tex_T3, UID3, 2);
                AssignValuesgiohang(pic_4, tex_Ten4, tex_T4, UID4, 3);
                AssignValuesgiohang(pic_5, tex_Ten5, tex_T5, UID5, 4);
                AssignValuesgiohang(pic_6, tex_Ten6, tex_T6, UID6, 5);
                AssignValuesgiohang(pic_7, tex_Ten7, tex_T7, UID7, 6);
            }
            if (rowCount1 == 8)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
                AssignValuesgiohang(pic_2, tex_Ten2, tex_T2, UID2, 1);
                AssignValuesgiohang(pic_3, tex_Ten3, tex_T3, UID3, 2);
                AssignValuesgiohang(pic_4, tex_Ten4, tex_T4, UID4, 3);
                AssignValuesgiohang(pic_5, tex_Ten5, tex_T5, UID5, 4);
                AssignValuesgiohang(pic_6, tex_Ten6, tex_T6, UID6, 5);
                AssignValuesgiohang(pic_7, tex_Ten7, tex_T7, UID7, 6);
                AssignValuesgiohang(pic_8, tex_Ten8, tex_T8, UID8, 7);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    
        private  void  updateBill(System.Windows.Forms.TextBox textbox_k)
        {
            string UID_book = textbox_k.Text;

            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 6; i++)
            {
                stringBuilder.Append(chars[random.Next(chars.Length)]);
            }

            string randomString = stringBuilder.ToString();

            DateTime currentTime = DateTime.Now;
            string formattedDateTime = currentTime.ToString("dd/MM/yyyy HH:mm:ss");

            //______________________________________________UPDATE________________________________//

            MySqlConnection connection = tao_connetion();
            connection.Open();

            string insertQuery = "INSERT INTO `bill mượn` (`Mã mượn`, `Mã độc giả`, `Mã sách`, `Thời gian mượn`) VALUES (@randomString, @ID_Account, @UID_book, @formattedDateTime)";
            MySqlCommand insertQuerycmd = new MySqlCommand(insertQuery, connection);
            insertQuerycmd.Parameters.AddWithValue("@randomString", randomString);
            insertQuerycmd.Parameters.AddWithValue("@formattedDateTime", formattedDateTime);
            insertQuerycmd.Parameters.AddWithValue("@ID_Account", ID_Account);
            insertQuerycmd.Parameters.AddWithValue("@UID_book", UID_book); // Thay 'ten_nguoidung' bằng tên người dùng
            insertQuerycmd.ExecuteNonQuery();

        }



        private void vbB_Dat_Click(object sender, EventArgs e)
        {
            Form4 users4 = new Form4();
            users4.ShowDialog();

            if (check_1.Checked)
            {
                updateBill(UID1);
                xoagiatri(pic_1, tex_Ten1, tex_T1, UID1);
                check_1.Checked = false;
            }
            if (check_2.Checked)
            {
                updateBill(UID2);
                xoagiatri(pic_2, tex_Ten2, tex_T2, UID2);
                check_2.Checked = false;
            }
            if (check_3.Checked)
            {
                updateBill(UID3);
                xoagiatri(pic_3, tex_Ten3, tex_T3, UID3);
                check_3.Checked = false;
            }
            if (check_4.Checked)
            {
                updateBill(UID4);
                xoagiatri(pic_4, tex_Ten4, tex_T4, UID4);
                check_4.Checked = false;
            }
            if (check_5.Checked)
            {
                updateBill(UID5);
                xoagiatri(pic_5, tex_Ten5, tex_T5, UID5);
                check_5.Checked = false;
            }
            if (check_6.Checked)
            {
                updateBill(UID6);
                xoagiatri(pic_6, tex_Ten6, tex_T6, UID6);
                check_6.Checked = false;
            }
            if (check_7.Checked)
            {
                updateBill(UID7);
                xoagiatri(pic_7, tex_Ten7, tex_T7, UID7);
                check_7.Checked = false;
            }
            if (check_8.Checked)
            {
                updateBill(UID8);
                xoagiatri(pic_8, tex_Ten8, tex_T8, UID8);
                check_8.Checked = false;
            }

            xoa(pic_1, tex_Ten1, tex_T1, UID1);
            xoa(pic_2, tex_Ten2, tex_T2, UID2);
            xoa(pic_3, tex_Ten3, tex_T3, UID3);
            xoa(pic_4, tex_Ten4, tex_T4, UID4);
            xoa(pic_5, tex_Ten5, tex_T5, UID5);
            xoa(pic_6, tex_Ten6, tex_T6, UID6);
            xoa(pic_7, tex_Ten7, tex_T7, UID7);
            xoa(pic_8, tex_Ten8, tex_T8, UID8);

            MySqlConnection connection = tao_connetion();
            connection.Open();

            string queryp = "SELECT * FROM `giohang` WHERE  `Reader_ID` = @ID_Account"; // Thay thế columnName và YourTable với tên cột và bảng của bạn
            MySqlCommand cmdp = new MySqlCommand(queryp, connection);
            cmdp.Parameters.AddWithValue("@ID_Account", ID_Account);

            //____________________Lấy data___________________//
            MySqlDataAdapter adapterp = new MySqlDataAdapter(cmdp);
            DataTable dataTablep = new DataTable();
            adapterp.Fill(dataTablep);
            int rowCount1 = dataTablep.Rows.Count;


            if (rowCount1 == 0)
            {
                tex_TB.Text = "Không có quyển sách nào trong giỏ hàng!!!";
            }
            if (rowCount1 == 1)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
            }
            if (rowCount1 == 2)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
                AssignValuesgiohang(pic_2, tex_Ten2, tex_T2, UID2, 1);
            }
            if (rowCount1 == 3)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
                AssignValuesgiohang(pic_2, tex_Ten2, tex_T2, UID2, 1);
                AssignValuesgiohang(pic_3, tex_Ten3, tex_T3, UID3, 2);
            }
            if (rowCount1 == 4)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
                AssignValuesgiohang(pic_2, tex_Ten2, tex_T2, UID2, 1);
                AssignValuesgiohang(pic_3, tex_Ten3, tex_T3, UID3, 2);
                AssignValuesgiohang(pic_4, tex_Ten4, tex_T4, UID4, 3);
            }
            if (rowCount1 == 5)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
                AssignValuesgiohang(pic_2, tex_Ten2, tex_T2, UID2, 1);
                AssignValuesgiohang(pic_3, tex_Ten3, tex_T3, UID3, 2);
                AssignValuesgiohang(pic_4, tex_Ten4, tex_T4, UID4, 3);
                AssignValuesgiohang(pic_5, tex_Ten5, tex_T5, UID5, 4);
            }
            if (rowCount1 == 6)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
                AssignValuesgiohang(pic_2, tex_Ten2, tex_T2, UID2, 1);
                AssignValuesgiohang(pic_3, tex_Ten3, tex_T3, UID3, 2);
                AssignValuesgiohang(pic_4, tex_Ten4, tex_T4, UID4, 3);
                AssignValuesgiohang(pic_5, tex_Ten5, tex_T5, UID5, 4);
                AssignValuesgiohang(pic_6, tex_Ten6, tex_T6, UID6, 5);
            }
            if (rowCount1 == 7)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
                AssignValuesgiohang(pic_2, tex_Ten2, tex_T2, UID2, 1);
                AssignValuesgiohang(pic_3, tex_Ten3, tex_T3, UID3, 2);
                AssignValuesgiohang(pic_4, tex_Ten4, tex_T4, UID4, 3);
                AssignValuesgiohang(pic_5, tex_Ten5, tex_T5, UID5, 4);
                AssignValuesgiohang(pic_6, tex_Ten6, tex_T6, UID6, 5);
                AssignValuesgiohang(pic_7, tex_Ten7, tex_T7, UID7, 6);
            }
            if (rowCount1 == 8)
            {
                AssignValuesgiohang(pic_1, tex_Ten1, tex_T1, UID1, 0);
                AssignValuesgiohang(pic_2, tex_Ten2, tex_T2, UID2, 1);
                AssignValuesgiohang(pic_3, tex_Ten3, tex_T3, UID3, 2);
                AssignValuesgiohang(pic_4, tex_Ten4, tex_T4, UID4, 3);
                AssignValuesgiohang(pic_5, tex_Ten5, tex_T5, UID5, 4);
                AssignValuesgiohang(pic_6, tex_Ten6, tex_T6, UID6, 5);
                AssignValuesgiohang(pic_7, tex_Ten7, tex_T7, UID7, 6);
                AssignValuesgiohang(pic_8, tex_Ten8, tex_T8, UID8, 7);
            }

            
        }
    }
}
