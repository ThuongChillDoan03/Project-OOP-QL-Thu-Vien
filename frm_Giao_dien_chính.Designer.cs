namespace PROJECT_CK_20231
{
    partial class Form_Dangnhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rad_Docgia = new System.Windows.Forms.RadioButton();
            this.rad_Nhanvien = new System.Windows.Forms.RadioButton();
            this.rad_Nguoiquanly = new System.Windows.Forms.RadioButton();
            this.tex_Taikhoan = new System.Windows.Forms.TextBox();
            this.tex_Matkhau = new System.Windows.Forms.TextBox();
            this.but_Nutdangnhap = new System.Windows.Forms.Button();
            this.but_dki = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(300, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 340);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackgroundImage = global::PROJECT_CK_20231.Properties.Resources.Logo_hust;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(322, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 48);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(318, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vui lòng chọn vai trò đăng nhập:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rad_Docgia
            // 
            this.rad_Docgia.AutoSize = true;
            this.rad_Docgia.BackColor = System.Drawing.Color.White;
            this.rad_Docgia.Location = new System.Drawing.Point(339, 365);
            this.rad_Docgia.Name = "rad_Docgia";
            this.rad_Docgia.Size = new System.Drawing.Size(74, 20);
            this.rad_Docgia.TabIndex = 4;
            this.rad_Docgia.Text = "Độc giả";
            this.rad_Docgia.UseVisualStyleBackColor = false;
            // 
            // rad_Nhanvien
            // 
            this.rad_Nhanvien.AutoSize = true;
            this.rad_Nhanvien.BackColor = System.Drawing.Color.White;
            this.rad_Nhanvien.Location = new System.Drawing.Point(339, 392);
            this.rad_Nhanvien.Name = "rad_Nhanvien";
            this.rad_Nhanvien.Size = new System.Drawing.Size(88, 20);
            this.rad_Nhanvien.TabIndex = 5;
            this.rad_Nhanvien.TabStop = true;
            this.rad_Nhanvien.Text = "Nhân viên";
            this.rad_Nhanvien.UseVisualStyleBackColor = false;
            this.rad_Nhanvien.CheckedChanged += new System.EventHandler(this.rad_Nhanvien_CheckedChanged);
            // 
            // rad_Nguoiquanly
            // 
            this.rad_Nguoiquanly.AutoSize = true;
            this.rad_Nguoiquanly.BackColor = System.Drawing.Color.White;
            this.rad_Nguoiquanly.Location = new System.Drawing.Point(339, 419);
            this.rad_Nguoiquanly.Name = "rad_Nguoiquanly";
            this.rad_Nguoiquanly.Size = new System.Drawing.Size(110, 20);
            this.rad_Nguoiquanly.TabIndex = 6;
            this.rad_Nguoiquanly.TabStop = true;
            this.rad_Nguoiquanly.Text = "Người quản lý";
            this.rad_Nguoiquanly.UseVisualStyleBackColor = false;
            // 
            // tex_Taikhoan
            // 
            this.tex_Taikhoan.Location = new System.Drawing.Point(325, 455);
            this.tex_Taikhoan.Multiline = true;
            this.tex_Taikhoan.Name = "tex_Taikhoan";
            this.tex_Taikhoan.Size = new System.Drawing.Size(325, 25);
            this.tex_Taikhoan.TabIndex = 7;
            this.tex_Taikhoan.Text = "Tài khoản";
            this.tex_Taikhoan.TextChanged += new System.EventHandler(this.tex_Taikhoan_TextChanged);
            // 
            // tex_Matkhau
            // 
            this.tex_Matkhau.Location = new System.Drawing.Point(325, 496);
            this.tex_Matkhau.Multiline = true;
            this.tex_Matkhau.Name = "tex_Matkhau";
            this.tex_Matkhau.Size = new System.Drawing.Size(325, 25);
            this.tex_Matkhau.TabIndex = 8;
            this.tex_Matkhau.Text = "Mật khẩu";
            // 
            // but_Nutdangnhap
            // 
            this.but_Nutdangnhap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.but_Nutdangnhap.Location = new System.Drawing.Point(339, 536);
            this.but_Nutdangnhap.Name = "but_Nutdangnhap";
            this.but_Nutdangnhap.Size = new System.Drawing.Size(100, 25);
            this.but_Nutdangnhap.TabIndex = 9;
            this.but_Nutdangnhap.Text = "Đăng nhập";
            this.but_Nutdangnhap.UseVisualStyleBackColor = false;
            this.but_Nutdangnhap.Click += new System.EventHandler(this.button2_Click);
            // 
            // but_dki
            // 
            this.but_dki.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.but_dki.Location = new System.Drawing.Point(530, 536);
            this.but_dki.Name = "but_dki";
            this.but_dki.Size = new System.Drawing.Size(100, 25);
            this.but_dki.TabIndex = 10;
            this.but_dki.Text = "Đăng kí";
            this.but_dki.UseVisualStyleBackColor = false;
            this.but_dki.Click += new System.EventHandler(this.but_dki_Click);
            // 
            // Form_Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::PROJECT_CK_20231.Properties.Resources.BG3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.but_dki);
            this.Controls.Add(this.but_Nutdangnhap);
            this.Controls.Add(this.tex_Matkhau);
            this.Controls.Add(this.tex_Taikhoan);
            this.Controls.Add(this.rad_Nguoiquanly);
            this.Controls.Add(this.rad_Nhanvien);
            this.Controls.Add(this.rad_Docgia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Form_Dangnhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form_Dangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rad_Docgia;
        private System.Windows.Forms.RadioButton rad_Nhanvien;
        private System.Windows.Forms.RadioButton rad_Nguoiquanly;
        private System.Windows.Forms.TextBox tex_Taikhoan;
        private System.Windows.Forms.TextBox tex_Matkhau;
        private System.Windows.Forms.Button but_Nutdangnhap;
        private System.Windows.Forms.Button but_dki;
    }
}

