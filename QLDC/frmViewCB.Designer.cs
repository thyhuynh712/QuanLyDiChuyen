namespace QLDC
{
    partial class frmViewCB
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.SearchCell = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddCB = new System.Windows.Forms.Button();
            this.btnUpdateCB = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnKBTTYT = new System.Windows.Forms.Button();
            this.btnKBLT = new System.Windows.Forms.Button();
            this.dataGridViewCB = new System.Windows.Forms.DataGridView();
            this.txtContent = new System.Windows.Forms.Label();
            this.txtSign = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(671, 111);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 38);
            this.btnSearch.TabIndex = 59;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // SearchCell
            // 
            this.SearchCell.Location = new System.Drawing.Point(403, 117);
            this.SearchCell.Name = "SearchCell";
            this.SearchCell.Size = new System.Drawing.Size(248, 26);
            this.SearchCell.TabIndex = 58;
            this.SearchCell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Nhập số CCCD/CMND cần tra cứu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "Danh Sách Cán Bộ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(398, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 29);
            this.label1.TabIndex = 56;
            this.label1.Text = "XEM DANH SÁCH CÁN BỘ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDC.Properties.Resources.Screenshot_2024_03_13_235134;
            this.pictureBox1.Location = new System.Drawing.Point(16, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddCB
            // 
            this.btnAddCB.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCB.Location = new System.Drawing.Point(29, 510);
            this.btnAddCB.Name = "btnAddCB";
            this.btnAddCB.Size = new System.Drawing.Size(182, 48);
            this.btnAddCB.TabIndex = 66;
            this.btnAddCB.Text = "Thêm Cán Bộ";
            this.btnAddCB.UseVisualStyleBackColor = false;
            this.btnAddCB.Click += new System.EventHandler(this.btnAddCB_Click);
            // 
            // btnUpdateCB
            // 
            this.btnUpdateCB.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdateCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCB.Location = new System.Drawing.Point(252, 510);
            this.btnUpdateCB.Name = "btnUpdateCB";
            this.btnUpdateCB.Size = new System.Drawing.Size(182, 48);
            this.btnUpdateCB.TabIndex = 65;
            this.btnUpdateCB.Text = "Cập Nhật Cán Bộ";
            this.btnUpdateCB.UseVisualStyleBackColor = false;
            this.btnUpdateCB.Click += new System.EventHandler(this.btnUpdateCB_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightBlue;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(925, 510);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(188, 48);
            this.btnThoat.TabIndex = 64;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnKBTTYT
            // 
            this.btnKBTTYT.BackColor = System.Drawing.Color.LightBlue;
            this.btnKBTTYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKBTTYT.Location = new System.Drawing.Point(704, 510);
            this.btnKBTTYT.Name = "btnKBTTYT";
            this.btnKBTTYT.Size = new System.Drawing.Size(187, 48);
            this.btnKBTTYT.TabIndex = 63;
            this.btnKBTTYT.Text = "Khai Báo TTYT";
            this.btnKBTTYT.UseVisualStyleBackColor = false;
            this.btnKBTTYT.Click += new System.EventHandler(this.btnKBTTYT_Click);
            // 
            // btnKBLT
            // 
            this.btnKBLT.BackColor = System.Drawing.Color.LightBlue;
            this.btnKBLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKBLT.Location = new System.Drawing.Point(476, 510);
            this.btnKBLT.Name = "btnKBLT";
            this.btnKBLT.Size = new System.Drawing.Size(182, 48);
            this.btnKBLT.TabIndex = 62;
            this.btnKBLT.Text = "Khai Báo Lộ Trình";
            this.btnKBLT.UseVisualStyleBackColor = false;
            this.btnKBLT.Click += new System.EventHandler(this.btnKBLT_Click);
            // 
            // dataGridViewCB
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCB.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCB.Location = new System.Drawing.Point(26, 239);
            this.dataGridViewCB.Name = "dataGridViewCB";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCB.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewCB.RowHeadersWidth = 62;
            this.dataGridViewCB.RowTemplate.Height = 28;
            this.dataGridViewCB.Size = new System.Drawing.Size(1077, 234);
            this.dataGridViewCB.TabIndex = 67;
            // 
            // txtContent
            // 
            this.txtContent.AutoSize = true;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(485, 168);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(198, 20);
            this.txtContent.TabIndex = 73;
            this.txtContent.Text = "để tra cứu tất cả người dân";
            // 
            // txtSign
            // 
            this.txtSign.AutoSize = true;
            this.txtSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSign.ForeColor = System.Drawing.Color.Red;
            this.txtSign.Location = new System.Drawing.Point(456, 166);
            this.txtSign.Name = "txtSign";
            this.txtSign.Size = new System.Drawing.Size(30, 37);
            this.txtSign.TabIndex = 72;
            this.txtSign.Text = "*";
            // 
            // txtNhap
            // 
            this.txtNhap.AutoSize = true;
            this.txtNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap.Location = new System.Drawing.Point(405, 166);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(47, 20);
            this.txtNhap.TabIndex = 71;
            this.txtNhap.Text = "Nhập";
            // 
            // frmViewCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 598);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtSign);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.dataGridViewCB);
            this.Controls.Add(this.btnAddCB);
            this.Controls.Add(this.btnUpdateCB);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnKBTTYT);
            this.Controls.Add(this.btnKBLT);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.SearchCell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmViewCB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem danh sách cán bộ";
            this.Load += new System.EventHandler(this.frmViewCB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox SearchCell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddCB;
        private System.Windows.Forms.Button btnUpdateCB;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnKBTTYT;
        private System.Windows.Forms.Button btnKBLT;
        private System.Windows.Forms.DataGridView dataGridViewCB;
        private System.Windows.Forms.Label txtContent;
        private System.Windows.Forms.Label txtSign;
        private System.Windows.Forms.Label txtNhap;
    }
}