namespace OOP
{
    partial class FormSuaQuanLyTheDoc
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
            this.txtSuaCardID = new System.Windows.Forms.TextBox();
            this.txtSuaReaderName = new System.Windows.Forms.TextBox();
            this.txtSuaReaderID = new System.Windows.Forms.TextBox();
            this.btnSuaHuy = new System.Windows.Forms.Button();
            this.btnSuaCapNhat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpSuaReaderDob = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(263, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SỬA THÔNG TIN THẺ ĐỌC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "CardReader_ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reader_Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reader_ID:";
            // 
            // txtSuaCardID
            // 
            this.txtSuaCardID.Location = new System.Drawing.Point(418, 107);
            this.txtSuaCardID.Name = "txtSuaCardID";
            this.txtSuaCardID.Size = new System.Drawing.Size(196, 22);
            this.txtSuaCardID.TabIndex = 4;
            // 
            // txtSuaReaderName
            // 
            this.txtSuaReaderName.Location = new System.Drawing.Point(418, 213);
            this.txtSuaReaderName.Name = "txtSuaReaderName";
            this.txtSuaReaderName.Size = new System.Drawing.Size(196, 22);
            this.txtSuaReaderName.TabIndex = 5;
            // 
            // txtSuaReaderID
            // 
            this.txtSuaReaderID.Location = new System.Drawing.Point(418, 160);
            this.txtSuaReaderID.Name = "txtSuaReaderID";
            this.txtSuaReaderID.Size = new System.Drawing.Size(196, 22);
            this.txtSuaReaderID.TabIndex = 6;
            // 
            // btnSuaHuy
            // 
            this.btnSuaHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaHuy.ForeColor = System.Drawing.Color.Blue;
            this.btnSuaHuy.Location = new System.Drawing.Point(209, 316);
            this.btnSuaHuy.Name = "btnSuaHuy";
            this.btnSuaHuy.Size = new System.Drawing.Size(157, 52);
            this.btnSuaHuy.TabIndex = 18;
            this.btnSuaHuy.Text = "Hủy";
            this.btnSuaHuy.UseVisualStyleBackColor = true;
            this.btnSuaHuy.Click += new System.EventHandler(this.btnSuaHuy_Click);
            // 
            // btnSuaCapNhat
            // 
            this.btnSuaCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCapNhat.ForeColor = System.Drawing.Color.Blue;
            this.btnSuaCapNhat.Location = new System.Drawing.Point(457, 316);
            this.btnSuaCapNhat.Name = "btnSuaCapNhat";
            this.btnSuaCapNhat.Size = new System.Drawing.Size(157, 52);
            this.btnSuaCapNhat.TabIndex = 19;
            this.btnSuaCapNhat.Text = "Cập nhật";
            this.btnSuaCapNhat.UseVisualStyleBackColor = true;
            this.btnSuaCapNhat.Click += new System.EventHandler(this.btnSuaCapNhat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(294, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Reader_Dob:";
            // 
            // dtpSuaReaderDob
            // 
            this.dtpSuaReaderDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSuaReaderDob.Location = new System.Drawing.Point(417, 266);
            this.dtpSuaReaderDob.Name = "dtpSuaReaderDob";
            this.dtpSuaReaderDob.Size = new System.Drawing.Size(196, 22);
            this.dtpSuaReaderDob.TabIndex = 21;
            this.dtpSuaReaderDob.ValueChanged += new System.EventHandler(this.dtpSuaReaderDob_ValueChanged);
            // 
            // FormSuaQuanLyTheDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpSuaReaderDob);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSuaCapNhat);
            this.Controls.Add(this.btnSuaHuy);
            this.Controls.Add(this.txtSuaReaderID);
            this.Controls.Add(this.txtSuaReaderName);
            this.Controls.Add(this.txtSuaCardID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSuaQuanLyTheDoc";
            this.Text = "FormSuaQuanLyTheDoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSuaCardID;
        private System.Windows.Forms.TextBox txtSuaReaderName;
        private System.Windows.Forms.TextBox txtSuaReaderID;
        private System.Windows.Forms.Button btnSuaHuy;
        private System.Windows.Forms.Button btnSuaCapNhat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpSuaReaderDob;
    }
}