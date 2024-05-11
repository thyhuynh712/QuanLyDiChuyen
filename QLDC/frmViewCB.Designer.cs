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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SearchCell = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddCB = new System.Windows.Forms.Button();
            this.btnUpdateCB = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
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
            this.btnSearch.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(609, 76);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 59;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // SearchCell
            // 
            this.SearchCell.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCell.Location = new System.Drawing.Point(403, 80);
            this.SearchCell.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchCell.Name = "SearchCell";
            this.SearchCell.Size = new System.Drawing.Size(200, 28);
            this.SearchCell.TabIndex = 58;
            this.SearchCell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchCell.TextChanged += new System.EventHandler(this.SearchCell_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 21);
            this.label2.TabIndex = 57;
            this.label2.Text = "Nhập số CCCD/CMND cần tra cứu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 26);
            this.label3.TabIndex = 60;
            this.label3.Text = "Danh Sách Cán Bộ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(364, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 37);
            this.label1.TabIndex = 56;
            this.label1.Text = "XEM DANH SÁCH CÁN BỘ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLDC.Properties.Resources.Screenshot_2024_03_13_235134;
            this.pictureBox1.Location = new System.Drawing.Point(11, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAddCB
            // 
            this.btnAddCB.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddCB.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCB.Location = new System.Drawing.Point(89, 514);
            this.btnAddCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddCB.Name = "btnAddCB";
            this.btnAddCB.Size = new System.Drawing.Size(226, 50);
            this.btnAddCB.TabIndex = 66;
            this.btnAddCB.Text = "Thêm Cán Bộ";
            this.btnAddCB.UseVisualStyleBackColor = false;
            this.btnAddCB.Click += new System.EventHandler(this.btnAddCB_Click);
            // 
            // btnUpdateCB
            // 
            this.btnUpdateCB.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdateCB.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCB.Location = new System.Drawing.Point(423, 514);
            this.btnUpdateCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateCB.Name = "btnUpdateCB";
            this.btnUpdateCB.Size = new System.Drawing.Size(226, 50);
            this.btnUpdateCB.TabIndex = 65;
            this.btnUpdateCB.Text = "Cập Nhật Cán Bộ";
            this.btnUpdateCB.UseVisualStyleBackColor = false;
            this.btnUpdateCB.Click += new System.EventHandler(this.btnUpdateCB_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightBlue;
            this.btnThoat.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(745, 514);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(226, 50);
            this.btnThoat.TabIndex = 64;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataGridViewCB
            // 
            this.dataGridViewCB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCB.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCB.Location = new System.Drawing.Point(17, 166);
            this.dataGridViewCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCB.Name = "dataGridViewCB";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCB.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCB.RowHeadersWidth = 62;
            this.dataGridViewCB.RowTemplate.Height = 28;
            this.dataGridViewCB.Size = new System.Drawing.Size(1023, 325);
            this.dataGridViewCB.TabIndex = 67;
            this.dataGridViewCB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCB_CellContentClick);
            // 
            // txtContent
            // 
            this.txtContent.AutoSize = true;
            this.txtContent.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(504, 120);
            this.txtContent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(159, 21);
            this.txtContent.TabIndex = 73;
            this.txtContent.Text = "để tra cứu tất cả cán bộ";
            this.txtContent.Click += new System.EventHandler(this.txtContent_Click);
            // 
            // txtSign
            // 
            this.txtSign.AutoSize = true;
            this.txtSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSign.ForeColor = System.Drawing.Color.Red;
            this.txtSign.Location = new System.Drawing.Point(488, 124);
            this.txtSign.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtSign.Name = "txtSign";
            this.txtSign.Size = new System.Drawing.Size(22, 26);
            this.txtSign.TabIndex = 72;
            this.txtSign.Text = "*";
            this.txtSign.Click += new System.EventHandler(this.txtSign_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.AutoSize = true;
            this.txtNhap.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap.Location = new System.Drawing.Point(448, 119);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(45, 21);
            this.txtNhap.TabIndex = 71;
            this.txtNhap.Text = "Nhập";
            this.txtNhap.Click += new System.EventHandler(this.txtNhap_Click);
            // 
            // frmViewCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 581);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtSign);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.dataGridViewCB);
            this.Controls.Add(this.btnAddCB);
            this.Controls.Add(this.btnUpdateCB);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.SearchCell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.DataGridView dataGridViewCB;
        private System.Windows.Forms.Label txtContent;
        private System.Windows.Forms.Label txtSign;
        private System.Windows.Forms.Label txtNhap;
    }
}