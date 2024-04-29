namespace QLDC
{
    partial class frmViewLT
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.SearchCell = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnKBND = new System.Windows.Forms.Button();
            this.btnAddLT = new System.Windows.Forms.Button();
            this.dataGridViewLT = new System.Windows.Forms.DataGridView();
            this.txtContent = new System.Windows.Forms.Label();
            this.txtSign = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(807, 114);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 38);
            this.btnSearch.TabIndex = 64;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchCell
            // 
            this.SearchCell.Location = new System.Drawing.Point(539, 120);
            this.SearchCell.Name = "SearchCell";
            this.SearchCell.Size = new System.Drawing.Size(248, 26);
            this.SearchCell.TabIndex = 63;
            this.SearchCell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(603, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 61;
            this.label1.Text = "XEM LỘ TRÌNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(604, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(203, 20);
            this.label20.TabIndex = 133;
            this.label20.Text = "Tra cứu số CCCD/CMND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 20);
            this.label2.TabIndex = 169;
            this.label2.Text = "Danh Sách Lộ Trình Của Người Dân";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDC.Properties.Resources.Screenshot_2024_03_13_235134;
            this.pictureBox1.Location = new System.Drawing.Point(28, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightBlue;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1058, 797);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThoat.Size = new System.Drawing.Size(179, 48);
            this.btnThoat.TabIndex = 198;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnKBND
            // 
            this.btnKBND.BackColor = System.Drawing.Color.LightBlue;
            this.btnKBND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKBND.Location = new System.Drawing.Point(621, 797);
            this.btnKBND.Name = "btnKBND";
            this.btnKBND.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnKBND.Size = new System.Drawing.Size(222, 48);
            this.btnKBND.TabIndex = 196;
            this.btnKBND.Text = "Khai Báo Người Dân";
            this.btnKBND.UseVisualStyleBackColor = false;
            this.btnKBND.Click += new System.EventHandler(this.btnKBND_Click);
            // 
            // btnAddLT
            // 
            this.btnAddLT.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLT.Location = new System.Drawing.Point(217, 797);
            this.btnAddLT.Name = "btnAddLT";
            this.btnAddLT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddLT.Size = new System.Drawing.Size(179, 48);
            this.btnAddLT.TabIndex = 195;
            this.btnAddLT.Text = "Thêm Lộ Trình";
            this.btnAddLT.UseVisualStyleBackColor = false;
            this.btnAddLT.Click += new System.EventHandler(this.btnAddLT_Click);
            // 
            // dataGridViewLT
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLT.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLT.Location = new System.Drawing.Point(58, 237);
            this.dataGridViewLT.Name = "dataGridViewLT";
            this.dataGridViewLT.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLT.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewLT.RowHeadersWidth = 62;
            this.dataGridViewLT.RowTemplate.Height = 28;
            this.dataGridViewLT.Size = new System.Drawing.Size(1294, 510);
            this.dataGridViewLT.TabIndex = 199;
            this.dataGridViewLT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLT_CellContentClick);
            // 
            // txtContent
            // 
            this.txtContent.AutoSize = true;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(609, 174);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(198, 20);
            this.txtContent.TabIndex = 202;
            this.txtContent.Text = "để tra cứu tất cả người dân";
            // 
            // txtSign
            // 
            this.txtSign.AutoSize = true;
            this.txtSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSign.ForeColor = System.Drawing.Color.Red;
            this.txtSign.Location = new System.Drawing.Point(580, 172);
            this.txtSign.Name = "txtSign";
            this.txtSign.Size = new System.Drawing.Size(30, 37);
            this.txtSign.TabIndex = 201;
            this.txtSign.Text = "*";
            // 
            // txtNhap
            // 
            this.txtNhap.AutoSize = true;
            this.txtNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap.Location = new System.Drawing.Point(529, 172);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(47, 20);
            this.txtNhap.TabIndex = 200;
            this.txtNhap.Text = "Nhập";
            // 
            // frmViewLT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1409, 877);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtSign);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.dataGridViewLT);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKBND);
            this.Controls.Add(this.btnAddLT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.SearchCell);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmViewLT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem lộ trình";
            this.Load += new System.EventHandler(this.frmViewLT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox SearchCell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnKBND;
        private System.Windows.Forms.Button btnAddLT;
        private System.Windows.Forms.DataGridView dataGridViewLT;
        private System.Windows.Forms.Label txtContent;
        private System.Windows.Forms.Label txtSign;
        private System.Windows.Forms.Label txtNhap;
    }
}