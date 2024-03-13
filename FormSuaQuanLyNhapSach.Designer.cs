namespace OOP
{
    partial class FormSuaQuanLyNhapSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaBillNhap = new System.Windows.Forms.TextBox();
            this.txtMaSachQLNS = new System.Windows.Forms.TextBox();
            this.txtMaNhanVienQLNS = new System.Windows.Forms.TextBox();
            this.btnCapNhatQLNS = new System.Windows.Forms.Button();
            this.btnHuyQLNS = new System.Windows.Forms.Button();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(259, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SỬA THÔNG TIN NHẬP SÁCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Import_Bill_ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Staff_ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Import_Bill_Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(190, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Book_ID:";
            // 
            // txtMaBillNhap
            // 
            this.txtMaBillNhap.Location = new System.Drawing.Point(287, 85);
            this.txtMaBillNhap.Name = "txtMaBillNhap";
            this.txtMaBillNhap.Size = new System.Drawing.Size(184, 22);
            this.txtMaBillNhap.TabIndex = 5;
            // 
            // txtMaSachQLNS
            // 
            this.txtMaSachQLNS.Location = new System.Drawing.Point(287, 328);
            this.txtMaSachQLNS.Name = "txtMaSachQLNS";
            this.txtMaSachQLNS.Size = new System.Drawing.Size(184, 22);
            this.txtMaSachQLNS.TabIndex = 6;
            // 
            // txtMaNhanVienQLNS
            // 
            this.txtMaNhanVienQLNS.Location = new System.Drawing.Point(287, 247);
            this.txtMaNhanVienQLNS.Name = "txtMaNhanVienQLNS";
            this.txtMaNhanVienQLNS.Size = new System.Drawing.Size(184, 22);
            this.txtMaNhanVienQLNS.TabIndex = 7;
            // 
            // btnCapNhatQLNS
            // 
            this.btnCapNhatQLNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatQLNS.ForeColor = System.Drawing.Color.Blue;
            this.btnCapNhatQLNS.Location = new System.Drawing.Point(610, 126);
            this.btnCapNhatQLNS.Name = "btnCapNhatQLNS";
            this.btnCapNhatQLNS.Size = new System.Drawing.Size(96, 59);
            this.btnCapNhatQLNS.TabIndex = 9;
            this.btnCapNhatQLNS.Text = "Cập Nhật";
            this.btnCapNhatQLNS.UseVisualStyleBackColor = true;
            this.btnCapNhatQLNS.Click += new System.EventHandler(this.btnCapNhatQLNS_Click);
            // 
            // btnHuyQLNS
            // 
            this.btnHuyQLNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyQLNS.ForeColor = System.Drawing.Color.Blue;
            this.btnHuyQLNS.Location = new System.Drawing.Point(610, 248);
            this.btnHuyQLNS.Name = "btnHuyQLNS";
            this.btnHuyQLNS.Size = new System.Drawing.Size(96, 59);
            this.btnHuyQLNS.TabIndex = 10;
            this.btnHuyQLNS.Text = "Hủy";
            this.btnHuyQLNS.UseVisualStyleBackColor = true;
            this.btnHuyQLNS.Click += new System.EventHandler(this.btnHuyQLNS_Click);
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(289, 166);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(184, 22);
            this.dtpNgayNhap.TabIndex = 11;
            // 
            // FormSuaQuanLyNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.btnHuyQLNS);
            this.Controls.Add(this.btnCapNhatQLNS);
            this.Controls.Add(this.txtMaNhanVienQLNS);
            this.Controls.Add(this.txtMaSachQLNS);
            this.Controls.Add(this.txtMaBillNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSuaQuanLyNhapSach";
            this.Text = "FormSuaQuanLyNhapSach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaBillNhap;
        private System.Windows.Forms.TextBox txtMaSachQLNS;
        private System.Windows.Forms.TextBox txtMaNhanVienQLNS;
        private System.Windows.Forms.Button btnCapNhatQLNS;
        private System.Windows.Forms.Button btnHuyQLNS;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
    }
}