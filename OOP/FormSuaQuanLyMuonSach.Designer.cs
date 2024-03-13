namespace OOP
{
    partial class FormSuaQuanLyMuonSach
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
            this.dateNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.txtMaSachQLMS = new System.Windows.Forms.TextBox();
            this.txtMaDocGiaQLMS = new System.Windows.Forms.TextBox();
            this.txtMaTheQLMS = new System.Windows.Forms.TextBox();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.txtMaBillMuon = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHuyQLMS = new System.Windows.Forms.Button();
            this.btnCapNhatQLMS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateNgayMuon
            // 
            this.dateNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNgayMuon.Location = new System.Drawing.Point(189, 214);
            this.dateNgayMuon.Name = "dateNgayMuon";
            this.dateNgayMuon.Size = new System.Drawing.Size(178, 22);
            this.dateNgayMuon.TabIndex = 25;
            // 
            // txtMaSachQLMS
            // 
            this.txtMaSachQLMS.Location = new System.Drawing.Point(562, 169);
            this.txtMaSachQLMS.Name = "txtMaSachQLMS";
            this.txtMaSachQLMS.Size = new System.Drawing.Size(178, 22);
            this.txtMaSachQLMS.TabIndex = 24;
            this.txtMaSachQLMS.TextChanged += new System.EventHandler(this.txtMaSachQLMS_TextChanged);
            // 
            // txtMaDocGiaQLMS
            // 
            this.txtMaDocGiaQLMS.Location = new System.Drawing.Point(189, 262);
            this.txtMaDocGiaQLMS.Name = "txtMaDocGiaQLMS";
            this.txtMaDocGiaQLMS.Size = new System.Drawing.Size(178, 22);
            this.txtMaDocGiaQLMS.TabIndex = 23;
            // 
            // txtMaTheQLMS
            // 
            this.txtMaTheQLMS.Location = new System.Drawing.Point(562, 216);
            this.txtMaTheQLMS.Name = "txtMaTheQLMS";
            this.txtMaTheQLMS.Size = new System.Drawing.Size(178, 22);
            this.txtMaTheQLMS.TabIndex = 22;
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Location = new System.Drawing.Point(562, 263);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.Size = new System.Drawing.Size(178, 22);
            this.txtTenDocGia.TabIndex = 21;
            // 
            // txtMaBillMuon
            // 
            this.txtMaBillMuon.Location = new System.Drawing.Point(189, 166);
            this.txtMaBillMuon.Name = "txtMaBillMuon";
            this.txtMaBillMuon.Size = new System.Drawing.Size(178, 22);
            this.txtMaBillMuon.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(54, 169);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(125, 18);
            this.label18.TabIndex = 14;
            this.label18.Text = "Borrow_Bill_ID:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(257, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(319, 25);
            this.label17.TabIndex = 26;
            this.label17.Text = "SỬA THÔNG TIN MƯỢN SÁCH";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Reader_Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "CardReader_ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Book_ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Reader_ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Borrow_Bill_Date:";
            // 
            // btnHuyQLMS
            // 
            this.btnHuyQLMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyQLMS.ForeColor = System.Drawing.Color.Blue;
            this.btnHuyQLMS.Location = new System.Drawing.Point(271, 324);
            this.btnHuyQLMS.Name = "btnHuyQLMS";
            this.btnHuyQLMS.Size = new System.Drawing.Size(96, 59);
            this.btnHuyQLMS.TabIndex = 32;
            this.btnHuyQLMS.Text = "Hủy";
            this.btnHuyQLMS.UseVisualStyleBackColor = true;
            this.btnHuyQLMS.Click += new System.EventHandler(this.btnHuyQLMS_Click);
            // 
            // btnCapNhatQLMS
            // 
            this.btnCapNhatQLMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatQLMS.ForeColor = System.Drawing.Color.Blue;
            this.btnCapNhatQLMS.Location = new System.Drawing.Point(450, 324);
            this.btnCapNhatQLMS.Name = "btnCapNhatQLMS";
            this.btnCapNhatQLMS.Size = new System.Drawing.Size(96, 59);
            this.btnCapNhatQLMS.TabIndex = 33;
            this.btnCapNhatQLMS.Text = "Cập Nhật";
            this.btnCapNhatQLMS.UseVisualStyleBackColor = true;
            this.btnCapNhatQLMS.Click += new System.EventHandler(this.btnCapNhatQLMS_Click);
            // 
            // FormSuaQuanLyMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCapNhatQLMS);
            this.Controls.Add(this.btnHuyQLMS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dateNgayMuon);
            this.Controls.Add(this.txtMaSachQLMS);
            this.Controls.Add(this.txtMaDocGiaQLMS);
            this.Controls.Add(this.txtMaTheQLMS);
            this.Controls.Add(this.txtTenDocGia);
            this.Controls.Add(this.txtMaBillMuon);
            this.Controls.Add(this.label18);
            this.Name = "FormSuaQuanLyMuonSach";
            this.Text = "FormSuaQuanLyMuonSach";
            this.Load += new System.EventHandler(this.FormSuaQuanLyMuonSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateNgayMuon;
        private System.Windows.Forms.TextBox txtMaSachQLMS;
        private System.Windows.Forms.TextBox txtMaDocGiaQLMS;
        private System.Windows.Forms.TextBox txtMaTheQLMS;
        private System.Windows.Forms.TextBox txtTenDocGia;
        private System.Windows.Forms.TextBox txtMaBillMuon;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHuyQLMS;
        private System.Windows.Forms.Button btnCapNhatQLMS;
    }
}