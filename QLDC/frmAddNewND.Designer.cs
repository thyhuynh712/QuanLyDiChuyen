namespace QLDC
{
    partial class frmAdd
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkMale = new System.Windows.Forms.CheckBox();
            this.checkFemale = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDuong = new System.Windows.Forms.TextBox();
            this.btnKBLT = new System.Windows.Forms.Button();
            this.btnKBTTYT = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXemDS = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboTinh = new System.Windows.Forms.ComboBox();
            this.cboHuyen = new System.Windows.Forms.ComboBox();
            this.cboXa = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDC.Properties.Resources.Screenshot_2024_03_13_235134;
            this.pictureBox1.Location = new System.Drawing.Point(12, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(274, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÊM MỚI NGƯỜI DÂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(299, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vui lòng nhập thông tin người dân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập Thông Tin Người Dân";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số CCCD/CMND:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Họ Và Tên:";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(166, 112);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(219, 26);
            this.txtCCCD.TabIndex = 6;
            this.txtCCCD.TextChanged += new System.EventHandler(this.txtCCCD_TextChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(166, 156);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(219, 26);
            this.txtHoTen.TabIndex = 7;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giới Tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(498, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ngày Sinh:";
            // 
            // checkMale
            // 
            this.checkMale.AutoSize = true;
            this.checkMale.Location = new System.Drawing.Point(597, 108);
            this.checkMale.Name = "checkMale";
            this.checkMale.Size = new System.Drawing.Size(68, 24);
            this.checkMale.TabIndex = 10;
            this.checkMale.Text = "Nam";
            this.checkMale.UseVisualStyleBackColor = true;
            // 
            // checkFemale
            // 
            this.checkFemale.AutoSize = true;
            this.checkFemale.Location = new System.Drawing.Point(696, 108);
            this.checkFemale.Name = "checkFemale";
            this.checkFemale.Size = new System.Drawing.Size(55, 24);
            this.checkFemale.TabIndex = 11;
            this.checkFemale.Text = "Nữ";
            this.checkFemale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Địa Chỉ Lưu Trú";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tỉnh, Thành:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Quận, Huyện:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(395, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Phường, Xã, Thị Trấn:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(395, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Số Nhà, Đường:";
            // 
            // txtDuong
            // 
            this.txtDuong.Location = new System.Drawing.Point(562, 283);
            this.txtDuong.Name = "txtDuong";
            this.txtDuong.Size = new System.Drawing.Size(219, 26);
            this.txtDuong.TabIndex = 21;
            this.txtDuong.TextChanged += new System.EventHandler(this.txtDuong_TextChanged);
            // 
            // btnKBLT
            // 
            this.btnKBLT.BackColor = System.Drawing.Color.LightBlue;
            this.btnKBLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKBLT.Location = new System.Drawing.Point(307, 334);
            this.btnKBLT.Name = "btnKBLT";
            this.btnKBLT.Size = new System.Drawing.Size(180, 42);
            this.btnKBLT.TabIndex = 22;
            this.btnKBLT.Text = "Khai Báo Lộ Trình";
            this.btnKBLT.UseVisualStyleBackColor = false;
            this.btnKBLT.Click += new System.EventHandler(this.btnKBLT_Click);
            // 
            // btnKBTTYT
            // 
            this.btnKBTTYT.BackColor = System.Drawing.Color.LightBlue;
            this.btnKBTTYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKBTTYT.Location = new System.Drawing.Point(559, 334);
            this.btnKBTTYT.Name = "btnKBTTYT";
            this.btnKBTTYT.Size = new System.Drawing.Size(180, 42);
            this.btnKBTTYT.TabIndex = 23;
            this.btnKBTTYT.Text = "Khai Báo TTYT";
            this.btnKBTTYT.UseVisualStyleBackColor = false;
            this.btnKBTTYT.Click += new System.EventHandler(this.btnKBTTYT_Click);

            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightBlue;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(307, 396);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(180, 42);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(58, 334);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(178, 42);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightBlue;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(559, 396);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(180, 42);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXemDS
            // 
            this.btnXemDS.BackColor = System.Drawing.Color.LightBlue;
            this.btnXemDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDS.Location = new System.Drawing.Point(58, 396);
            this.btnXemDS.Name = "btnXemDS";
            this.btnXemDS.Size = new System.Drawing.Size(178, 42);
            this.btnXemDS.TabIndex = 27;
            this.btnXemDS.Text = "Xem Danh Sách";
            this.btnXemDS.UseVisualStyleBackColor = false;
            this.btnXemDS.Click += new System.EventHandler(this.btnXemDS_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cboTinh
            // 
            this.cboTinh.FormattingEnabled = true;
            this.cboTinh.Location = new System.Drawing.Point(137, 236);
            this.cboTinh.Name = "cboTinh";
            this.cboTinh.Size = new System.Drawing.Size(234, 28);
            this.cboTinh.TabIndex = 28;
           
            // 
            // cboHuyen
            // 
            this.cboHuyen.FormattingEnabled = true;
            this.cboHuyen.Location = new System.Drawing.Point(137, 283);
            this.cboHuyen.Name = "cboHuyen";
            this.cboHuyen.Size = new System.Drawing.Size(234, 28);
            this.cboHuyen.TabIndex = 29;
            // 
            // cboXa
            // 
            this.cboXa.FormattingEnabled = true;
            this.cboXa.Location = new System.Drawing.Point(562, 236);
            this.cboXa.Name = "cboXa";
            this.cboXa.Size = new System.Drawing.Size(219, 28);
            this.cboXa.TabIndex = 30;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(597, 159);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(154, 26);
            this.dtpNgaySinh.TabIndex = 31;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.cboXa);
            this.Controls.Add(this.cboHuyen);
            this.Controls.Add(this.cboTinh);
            this.Controls.Add(this.btnXemDS);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnKBTTYT);
            this.Controls.Add(this.btnKBLT);
            this.Controls.Add(this.txtDuong);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkFemale);
            this.Controls.Add(this.checkMale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewND";
            this.Load += new System.EventHandler(this.frmAddNewND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkMale;
        private System.Windows.Forms.CheckBox checkFemale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDuong;
        private System.Windows.Forms.Button btnKBLT;
        private System.Windows.Forms.Button btnKBTTYT;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXemDS;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cboXa;
        private System.Windows.Forms.ComboBox cboHuyen;
        private System.Windows.Forms.ComboBox cboTinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    }
}