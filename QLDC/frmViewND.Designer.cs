namespace QLDC
{
    partial class frmViewND
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchCell = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKBLT = new System.Windows.Forms.Button();
            this.btnKBTTYT = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdateND = new System.Windows.Forms.Button();
            this.btnAddND = new System.Windows.Forms.Button();
            this.dataGridViewND = new System.Windows.Forms.DataGridView();
            this.txtNhap = new System.Windows.Forms.Label();
            this.txtSign = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewND)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(395, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "XEM DANH SÁCH NGƯỜI DÂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập số CCCD/CMND cần tra cứu";
            // 
            // SearchCell
            // 
            this.SearchCell.Location = new System.Drawing.Point(400, 121);
            this.SearchCell.Name = "SearchCell";
            this.SearchCell.Size = new System.Drawing.Size(248, 26);
            this.SearchCell.TabIndex = 4;
            this.SearchCell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(668, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 38);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Danh Sách Người Dân";
            // 
            // btnKBLT
            // 
            this.btnKBLT.BackColor = System.Drawing.Color.LightBlue;
            this.btnKBLT.Location = new System.Drawing.Point(478, 431);
            this.btnKBLT.Name = "btnKBLT";
            this.btnKBLT.Size = new System.Drawing.Size(182, 48);
            this.btnKBLT.TabIndex = 52;
            this.btnKBLT.Text = "Khai Báo Lộ Trình";
            this.btnKBLT.UseVisualStyleBackColor = false;
            this.btnKBLT.Click += new System.EventHandler(this.btnKBLT_Click);
            // 
            // btnKBTTYT
            // 
            this.btnKBTTYT.BackColor = System.Drawing.Color.LightBlue;
            this.btnKBTTYT.Location = new System.Drawing.Point(706, 431);
            this.btnKBTTYT.Name = "btnKBTTYT";
            this.btnKBTTYT.Size = new System.Drawing.Size(187, 48);
            this.btnKBTTYT.TabIndex = 53;
            this.btnKBTTYT.Text = "Khai Báo TTYT";
            this.btnKBTTYT.UseVisualStyleBackColor = false;
            this.btnKBTTYT.Click += new System.EventHandler(this.btnKBTTYT_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightBlue;
            this.btnThoat.Location = new System.Drawing.Point(927, 431);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(188, 48);
            this.btnThoat.TabIndex = 54;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDC.Properties.Resources.Screenshot_2024_03_13_235134;
            this.pictureBox1.Location = new System.Drawing.Point(13, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpdateND
            // 
            this.btnUpdateND.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdateND.Location = new System.Drawing.Point(254, 431);
            this.btnUpdateND.Name = "btnUpdateND";
            this.btnUpdateND.Size = new System.Drawing.Size(182, 48);
            this.btnUpdateND.TabIndex = 55;
            this.btnUpdateND.Text = "Cập Nhật Người Dân";
            this.btnUpdateND.UseVisualStyleBackColor = false;
            this.btnUpdateND.Click += new System.EventHandler(this.btnUpdateND_Click);
            // 
            // btnAddND
            // 
            this.btnAddND.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddND.Location = new System.Drawing.Point(31, 431);
            this.btnAddND.Name = "btnAddND";
            this.btnAddND.Size = new System.Drawing.Size(182, 48);
            this.btnAddND.TabIndex = 56;
            this.btnAddND.Text = "Thêm Người Dân";
            this.btnAddND.UseVisualStyleBackColor = false;
            this.btnAddND.Click += new System.EventHandler(this.btnAddND_Click);
            // 
            // dataGridViewND
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewND.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewND.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewND.Location = new System.Drawing.Point(51, 222);
            this.dataGridViewND.Name = "dataGridViewND";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewND.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewND.RowHeadersWidth = 62;
            this.dataGridViewND.RowTemplate.Height = 28;
            this.dataGridViewND.Size = new System.Drawing.Size(1042, 178);
            this.dataGridViewND.TabIndex = 67;
            // 
            // txtNhap
            // 
            this.txtNhap.AutoSize = true;
            this.txtNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap.Location = new System.Drawing.Point(396, 156);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(47, 20);
            this.txtNhap.TabIndex = 68;
            this.txtNhap.Text = "Nhập";
            // 
            // txtSign
            // 
            this.txtSign.AutoSize = true;
            this.txtSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSign.ForeColor = System.Drawing.Color.Red;
            this.txtSign.Location = new System.Drawing.Point(447, 156);
            this.txtSign.Name = "txtSign";
            this.txtSign.Size = new System.Drawing.Size(30, 37);
            this.txtSign.TabIndex = 69;
            this.txtSign.Text = "*";
            // 
            // txtContent
            // 
            this.txtContent.AutoSize = true;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(476, 158);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(198, 20);
            this.txtContent.TabIndex = 70;
            this.txtContent.Text = "để tra cứu tất cả người dân";
            // 
            // frmViewND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 517);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtSign);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.dataGridViewND);
            this.Controls.Add(this.btnAddND);
            this.Controls.Add(this.btnUpdateND);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKBTTYT);
            this.Controls.Add(this.btnKBLT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.SearchCell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmViewND";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem Danh Sách Người Dân";
            this.Load += new System.EventHandler(this.frmViewND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewND)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchCell;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKBLT;
        private System.Windows.Forms.Button btnKBTTYT;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnUpdateND;
        private System.Windows.Forms.Button btnAddND;
        private System.Windows.Forms.DataGridView dataGridViewND;
        private System.Windows.Forms.Label txtNhap;
        private System.Windows.Forms.Label txtSign;
        private System.Windows.Forms.Label txtContent;
    }
}