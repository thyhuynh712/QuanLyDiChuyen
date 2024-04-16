namespace QLDC
{
    partial class frmViewTTYT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddTTYT = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SearchCell = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnKBND = new System.Windows.Forms.Button();
            this.btnUpdateTTYT = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewTTYTNguoiDan = new System.Windows.Forms.DataGridView();
            this.txtContent = new System.Windows.Forms.Label();
            this.txtSign = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTTYTNguoiDan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTTYT
            // 
            this.btnAddTTYT.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddTTYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTTYT.Location = new System.Drawing.Point(40, 533);
            this.btnAddTTYT.Name = "btnAddTTYT";
            this.btnAddTTYT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddTTYT.Size = new System.Drawing.Size(179, 48);
            this.btnAddTTYT.TabIndex = 73;
            this.btnAddTTYT.Text = "Thêm TTYT";
            this.btnAddTTYT.UseVisualStyleBackColor = false;
            this.btnAddTTYT.Click += new System.EventHandler(this.btnAddTTYT_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(627, 125);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 38);
            this.btnSearch.TabIndex = 69;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchCell
            // 
            this.SearchCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCell.Location = new System.Drawing.Point(359, 130);
            this.SearchCell.Name = "SearchCell";
            this.SearchCell.Size = new System.Drawing.Size(248, 30);
            this.SearchCell.TabIndex = 68;
            this.SearchCell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Danh Sách Thông Tin Y Tế Người Dân";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(314, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 29);
            this.label1.TabIndex = 66;
            this.label1.Text = "XEM DANH SÁCH THÔNG TIN Y TẾ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(418, 86);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(203, 20);
            this.label20.TabIndex = 134;
            this.label20.Text = "Tra cứu số CCCD/CMND";
            // 
            // btnKBND
            // 
            this.btnKBND.BackColor = System.Drawing.Color.LightBlue;
            this.btnKBND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKBND.Location = new System.Drawing.Point(514, 533);
            this.btnKBND.Name = "btnKBND";
            this.btnKBND.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnKBND.Size = new System.Drawing.Size(222, 48);
            this.btnKBND.TabIndex = 192;
            this.btnKBND.Text = "Khai Báo Người Dân";
            this.btnKBND.UseVisualStyleBackColor = false;
            this.btnKBND.Click += new System.EventHandler(this.btnKBND_Click);
            // 
            // btnUpdateTTYT
            // 
            this.btnUpdateTTYT.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdateTTYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTTYT.Location = new System.Drawing.Point(277, 533);
            this.btnUpdateTTYT.Name = "btnUpdateTTYT";
            this.btnUpdateTTYT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdateTTYT.Size = new System.Drawing.Size(179, 48);
            this.btnUpdateTTYT.TabIndex = 193;
            this.btnUpdateTTYT.Text = "Cập Nhật TTYT";
            this.btnUpdateTTYT.UseVisualStyleBackColor = false;
            this.btnUpdateTTYT.Click += new System.EventHandler(this.btnUpdateTTYT_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightBlue;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(805, 533);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThoat.Size = new System.Drawing.Size(179, 48);
            this.btnThoat.TabIndex = 194;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDC.Properties.Resources.Screenshot_2024_03_13_235134;
            this.pictureBox1.Location = new System.Drawing.Point(30, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewTTYTNguoiDan
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTTYTNguoiDan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTTYTNguoiDan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTTYTNguoiDan.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTTYTNguoiDan.Location = new System.Drawing.Point(61, 266);
            this.dataGridViewTTYTNguoiDan.Name = "dataGridViewTTYTNguoiDan";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTTYTNguoiDan.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTTYTNguoiDan.RowHeadersWidth = 62;
            this.dataGridViewTTYTNguoiDan.RowTemplate.Height = 28;
            this.dataGridViewTTYTNguoiDan.Size = new System.Drawing.Size(923, 239);
            this.dataGridViewTTYTNguoiDan.TabIndex = 195;
            // 
            // txtContent
            // 
            this.txtContent.AutoSize = true;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(435, 179);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(198, 20);
            this.txtContent.TabIndex = 205;
            this.txtContent.Text = "để tra cứu tất cả người dân";
            // 
            // txtSign
            // 
            this.txtSign.AutoSize = true;
            this.txtSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSign.ForeColor = System.Drawing.Color.Red;
            this.txtSign.Location = new System.Drawing.Point(406, 177);
            this.txtSign.Name = "txtSign";
            this.txtSign.Size = new System.Drawing.Size(30, 37);
            this.txtSign.TabIndex = 204;
            this.txtSign.Text = "*";
            // 
            // txtNhap
            // 
            this.txtNhap.AutoSize = true;
            this.txtNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap.Location = new System.Drawing.Point(355, 177);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(47, 20);
            this.txtNhap.TabIndex = 203;
            this.txtNhap.Text = "Nhập";
            // 
            // frmViewTTYT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 610);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtSign);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.dataGridViewTTYTNguoiDan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnUpdateTTYT);
            this.Controls.Add(this.btnKBND);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnAddTTYT);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.SearchCell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmViewTTYT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem Thông Tin Y Tế Người Dân";
            this.Load += new System.EventHandler(this.frmViewTTYT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTTYTNguoiDan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddTTYT;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox SearchCell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnKBND;
        private System.Windows.Forms.Button btnUpdateTTYT;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dataGridViewTTYTNguoiDan;
        private System.Windows.Forms.Label txtContent;
        private System.Windows.Forms.Label txtSign;
        private System.Windows.Forms.Label txtNhap;
    }
}