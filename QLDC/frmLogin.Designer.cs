namespace QLDC
{
    partial class frmLogin
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkShowPassword = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLoaiTK = new System.Windows.Forms.ComboBox();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(514, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 26);
            this.textBox1.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.SteelBlue;
            this.title.Location = new System.Drawing.Point(454, 49);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(272, 26);
            this.title.TabIndex = 1;
            this.title.Text = "MOVESAFE XIN CHÀO!";
            this.title.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(455, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vui lòng nhập thông tin đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số CCCD/CMND:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mật khẩu:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(514, 234);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(250, 26);
            this.textBox2.TabIndex = 5;
            // 
            // checkShowPassword
            // 
            this.checkShowPassword.AutoSize = true;
            this.checkShowPassword.Location = new System.Drawing.Point(514, 277);
            this.checkShowPassword.Name = "checkShowPassword";
            this.checkShowPassword.Size = new System.Drawing.Size(159, 24);
            this.checkShowPassword.TabIndex = 8;
            this.checkShowPassword.Text = "Hiển thị mật khẩu";
            this.checkShowPassword.UseVisualStyleBackColor = true;
            this.checkShowPassword.CheckedChanged += checkShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightBlue;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(370, 355);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(154, 46);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightBlue;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(611, 355);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(153, 46);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Loại Tài Khoản:";
            // 
            // cboLoaiTK
            // 
            this.cboLoaiTK.FormattingEnabled = true;
            this.cboLoaiTK.Location = new System.Drawing.Point(514, 186);
            this.cboLoaiTK.Name = "cboLoaiTK";
            this.cboLoaiTK.Size = new System.Drawing.Size(250, 28);
            this.cboLoaiTK.TabIndex = 14;
            // 
            // logo
            // 
            this.logo.ErrorImage = null;
            this.logo.Image = global::QLDC.Properties.Resources.M1;
            this.logo.InitialImage = global::QLDC.Properties.Resources._1;
            this.logo.Location = new System.Drawing.Point(44, 87);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(237, 240);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 12;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.cboLoaiTK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.checkShowPassword);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkShowPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLoaiTK;
    }
}

