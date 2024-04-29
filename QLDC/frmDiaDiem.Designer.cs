namespace QLDC
{
    partial class frmDiaDiem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboTinh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTenĐiaiem = new System.Windows.Forms.TextBox();
            this.txtMaDiaDiem = new System.Windows.Forms.TextBox();
            this.dataGridViewDiaDiem = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboHuyen = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboXa = new System.Windows.Forms.ComboBox();
            this.btnKBND = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiaDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cboTinh
            // 
            this.cboTinh.FormattingEnabled = true;
            this.cboTinh.Location = new System.Drawing.Point(205, 208);
            this.cboTinh.Name = "cboTinh";
            this.cboTinh.Size = new System.Drawing.Size(202, 28);
            this.cboTinh.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 63;
            this.label6.Text = "Tỉnh/Thành phố:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightBlue;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(19, 538);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(463, 49);
            this.btnThoat.TabIndex = 62;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightBlue;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(18, 455);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(171, 49);
            this.btnReset.TabIndex = 60;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(282, 377);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 49);
            this.btnUpdate.TabIndex = 59;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightBlue;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(17, 377);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 49);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTenĐiaiem
            // 
            this.txtTenĐiaiem.Location = new System.Drawing.Point(205, 153);
            this.txtTenĐiaiem.Name = "txtTenĐiaiem";
            this.txtTenĐiaiem.Size = new System.Drawing.Size(277, 26);
            this.txtTenĐiaiem.TabIndex = 56;
            // 
            // txtMaDiaDiem
            // 
            this.txtMaDiaDiem.BackColor = System.Drawing.Color.Silver;
            this.txtMaDiaDiem.Location = new System.Drawing.Point(205, 101);
            this.txtMaDiaDiem.Name = "txtMaDiaDiem";
            this.txtMaDiaDiem.Size = new System.Drawing.Size(71, 26);
            this.txtMaDiaDiem.TabIndex = 55;
            // 
            // dataGridViewDiaDiem
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDiaDiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewDiaDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDiaDiem.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewDiaDiem.Location = new System.Drawing.Point(515, 133);
            this.dataGridViewDiaDiem.Name = "dataGridViewDiaDiem";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDiaDiem.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewDiaDiem.RowHeadersWidth = 62;
            this.dataGridViewDiaDiem.RowTemplate.Height = 28;
            this.dataGridViewDiaDiem.Size = new System.Drawing.Size(735, 454);
            this.dataGridViewDiaDiem.TabIndex = 54;
            this.dataGridViewDiaDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDiaDiem_CellClick);
            this.dataGridViewDiaDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDiaDiem_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(511, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Danh Sách Các Địa Điểm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Địa Chỉ:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Mã Địa Điểm:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Size = new System.Drawing.Size(1291, 63);
            this.label1.TabIndex = 49;
            this.label1.Text = "ĐỊA ĐIỂM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "Quận/Huyện:";
            // 
            // cboHuyen
            // 
            this.cboHuyen.FormattingEnabled = true;
            this.cboHuyen.Location = new System.Drawing.Point(205, 262);
            this.cboHuyen.Name = "cboHuyen";
            this.cboHuyen.Size = new System.Drawing.Size(202, 28);
            this.cboHuyen.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 20);
            this.label8.TabIndex = 67;
            this.label8.Text = "Phường/Xã/Thị trấn:";
            // 
            // cboXa
            // 
            this.cboXa.FormattingEnabled = true;
            this.cboXa.Location = new System.Drawing.Point(205, 321);
            this.cboXa.Name = "cboXa";
            this.cboXa.Size = new System.Drawing.Size(277, 28);
            this.cboXa.TabIndex = 68;
            // 
            // btnKBND
            // 
            this.btnKBND.BackColor = System.Drawing.Color.LightBlue;
            this.btnKBND.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKBND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKBND.Location = new System.Drawing.Point(282, 455);
            this.btnKBND.Name = "btnKBND";
            this.btnKBND.Size = new System.Drawing.Size(200, 49);
            this.btnKBND.TabIndex = 69;
            this.btnKBND.Text = "Khai Báo Người Dân";
            this.btnKBND.UseVisualStyleBackColor = false;
            this.btnKBND.Click += new System.EventHandler(this.btnKBND_Click);
            // 
            // frmDiaDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 648);
            this.Controls.Add(this.btnKBND);
            this.Controls.Add(this.cboXa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboHuyen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboTinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTenĐiaiem);
            this.Controls.Add(this.txtMaDiaDiem);
            this.Controls.Add(this.dataGridViewDiaDiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmDiaDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Địa Điểm";
            this.Load += new System.EventHandler(this.frmDiaDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiaDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cboTinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTenĐiaiem;
        private System.Windows.Forms.TextBox txtMaDiaDiem;
        private System.Windows.Forms.DataGridView dataGridViewDiaDiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboXa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboHuyen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKBND;
    }
}