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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtContent = new System.Windows.Forms.Label();
            this.txtSign = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.Label();
            this.dataGridViewND = new System.Windows.Forms.DataGridView();
            this.btnAddND = new System.Windows.Forms.Button();
            this.btnUpdateND = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SearchCell = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKBLT = new System.Windows.Forms.Button();
            this.btnKBTTYT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.AutoSize = true;
            this.txtContent.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(511, 130);
            this.txtContent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(182, 21);
            this.txtContent.TabIndex = 86;
            this.txtContent.Text = "để tra cứu tất cả người dân";
            // 
            // txtSign
            // 
            this.txtSign.AutoSize = true;
            this.txtSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSign.ForeColor = System.Drawing.Color.Red;
            this.txtSign.Location = new System.Drawing.Point(495, 134);
            this.txtSign.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtSign.Name = "txtSign";
            this.txtSign.Size = new System.Drawing.Size(22, 26);
            this.txtSign.TabIndex = 85;
            this.txtSign.Text = "*";
            // 
            // txtNhap
            // 
            this.txtNhap.AutoSize = true;
            this.txtNhap.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap.Location = new System.Drawing.Point(455, 129);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(45, 21);
            this.txtNhap.TabIndex = 84;
            this.txtNhap.Text = "Nhập";
            // 
            // dataGridViewND
            // 
            this.dataGridViewND.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewND.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewND.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewND.Location = new System.Drawing.Point(24, 176);
            this.dataGridViewND.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewND.Name = "dataGridViewND";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewND.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewND.RowHeadersWidth = 62;
            this.dataGridViewND.RowTemplate.Height = 28;
            this.dataGridViewND.Size = new System.Drawing.Size(1023, 325);
            this.dataGridViewND.TabIndex = 83;
            // 
            // btnAddND
            // 
            this.btnAddND.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddND.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddND.Location = new System.Drawing.Point(24, 520);
            this.btnAddND.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddND.Name = "btnAddND";
            this.btnAddND.Size = new System.Drawing.Size(190, 50);
            this.btnAddND.TabIndex = 82;
            this.btnAddND.Text = "Thêm Người Dân";
            this.btnAddND.UseVisualStyleBackColor = false;
            this.btnAddND.Click += new System.EventHandler(this.btnAddND_Click);
            // 
            // btnUpdateND
            // 
            this.btnUpdateND.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdateND.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateND.Location = new System.Drawing.Point(234, 520);
            this.btnUpdateND.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateND.Name = "btnUpdateND";
            this.btnUpdateND.Size = new System.Drawing.Size(190, 50);
            this.btnUpdateND.TabIndex = 81;
            this.btnUpdateND.Text = "Cập Nhật Người Dân";
            this.btnUpdateND.UseVisualStyleBackColor = false;
            this.btnUpdateND.Click += new System.EventHandler(this.btnUpdateND_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightBlue;
            this.btnThoat.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(863, 520);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(190, 50);
            this.btnThoat.TabIndex = 80;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightBlue;
            this.btnSearch.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(616, 86);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 78;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchCell
            // 
            this.SearchCell.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCell.Location = new System.Drawing.Point(410, 90);
            this.SearchCell.Margin = new System.Windows.Forms.Padding(2);
            this.SearchCell.Name = "SearchCell";
            this.SearchCell.Size = new System.Drawing.Size(200, 28);
            this.SearchCell.TabIndex = 77;
            this.SearchCell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 21);
            this.label2.TabIndex = 76;
            this.label2.Text = "Nhập số CCCD/CMND cần tra cứu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 26);
            this.label3.TabIndex = 79;
            this.label3.Text = "Danh Sách Người Dân";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(348, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 37);
            this.label1.TabIndex = 75;
            this.label1.Text = "XEM DANH SÁCH NGƯỜI DÂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDC.Properties.Resources.Screenshot_2024_03_13_235134;
            this.pictureBox1.Location = new System.Drawing.Point(18, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // btnKBLT
            // 
            this.btnKBLT.BackColor = System.Drawing.Color.LightBlue;
            this.btnKBLT.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKBLT.Location = new System.Drawing.Point(445, 520);
            this.btnKBLT.Margin = new System.Windows.Forms.Padding(2);
            this.btnKBLT.Name = "btnKBLT";
            this.btnKBLT.Size = new System.Drawing.Size(190, 50);
            this.btnKBLT.TabIndex = 87;
            this.btnKBLT.Text = "Khai Báo Lộ Trình\r\n";
            this.btnKBLT.UseVisualStyleBackColor = false;
            this.btnKBLT.Click += new System.EventHandler(this.btnKBLT_Click);
            // 
            // btnKBTTYT
            // 
            this.btnKBTTYT.BackColor = System.Drawing.Color.LightBlue;
            this.btnKBTTYT.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKBTTYT.Location = new System.Drawing.Point(656, 520);
            this.btnKBTTYT.Margin = new System.Windows.Forms.Padding(2);
            this.btnKBTTYT.Name = "btnKBTTYT";
            this.btnKBTTYT.Size = new System.Drawing.Size(190, 50);
            this.btnKBTTYT.TabIndex = 88;
            this.btnKBTTYT.Text = "Khai Báo TTYT";
            this.btnKBTTYT.UseVisualStyleBackColor = false;
            this.btnKBTTYT.Click += new System.EventHandler(this.btnKBTTYT_Click);
            // 
            // frmViewND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 581);
            this.Controls.Add(this.btnKBTTYT);
            this.Controls.Add(this.btnKBLT);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtSign);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.dataGridViewND);
            this.Controls.Add(this.btnAddND);
            this.Controls.Add(this.btnUpdateND);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.SearchCell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmViewND";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem Danh Sách Người Dân";
            this.Load += new System.EventHandler(this.frmViewND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtContent;
        private System.Windows.Forms.Label txtSign;
        private System.Windows.Forms.Label txtNhap;
        private System.Windows.Forms.DataGridView dataGridViewND;
        private System.Windows.Forms.Button btnAddND;
        private System.Windows.Forms.Button btnUpdateND;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox SearchCell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKBLT;
        private System.Windows.Forms.Button btnKBTTYT;
    }
}