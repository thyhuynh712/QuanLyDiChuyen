namespace QLDC
{
    partial class frmTinh   {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewTinh = new System.Windows.Forms.DataGridView();
            this.txtMaTinh = new System.Windows.Forms.TextBox();
            this.txtTenTinh = new System.Windows.Forms.TextBox();
            this.txtSLNB = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnHuyen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label1.Size = new System.Drawing.Size(884, 55);
            this.label1.TabIndex = 19;
            this.label1.Text = "TỈNH/THÀNH PHỐ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã Tỉnh/Thành phố:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tên Tỉnh/Thành phố:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Số Lượng Nhiễm Bệnh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 26);
            this.label5.TabIndex = 23;
            this.label5.Text = "Danh Sách Các Tỉnh/Thành phố";
            // 
            // dataGridViewTinh
            // 
            this.dataGridViewTinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTinh.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTinh.Location = new System.Drawing.Point(397, 114);
            this.dataGridViewTinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewTinh.Name = "dataGridViewTinh";
            this.dataGridViewTinh.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTinh.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTinh.RowHeadersWidth = 62;
            this.dataGridViewTinh.RowTemplate.Height = 28;
            this.dataGridViewTinh.Size = new System.Drawing.Size(476, 333);
            this.dataGridViewTinh.TabIndex = 24;
            this.dataGridViewTinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTinh_CellClick);
            this.dataGridViewTinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTinh_CellContentClick);
            // 
            // txtMaTinh
            // 
            this.txtMaTinh.BackColor = System.Drawing.Color.Silver;
            this.txtMaTinh.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTinh.Location = new System.Drawing.Point(223, 73);
            this.txtMaTinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaTinh.Name = "txtMaTinh";
            this.txtMaTinh.Size = new System.Drawing.Size(146, 33);
            this.txtMaTinh.TabIndex = 25;
            // 
            // txtTenTinh
            // 
            this.txtTenTinh.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTinh.Location = new System.Drawing.Point(223, 134);
            this.txtTenTinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenTinh.Name = "txtTenTinh";
            this.txtTenTinh.Size = new System.Drawing.Size(163, 33);
            this.txtTenTinh.TabIndex = 26;
            this.txtTenTinh.TextChanged += new System.EventHandler(this.txtTenTinh_TextChanged);
            // 
            // txtSLNB
            // 
            this.txtSLNB.BackColor = System.Drawing.Color.Silver;
            this.txtSLNB.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLNB.Location = new System.Drawing.Point(223, 194);
            this.txtSLNB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSLNB.Name = "txtSLNB";
            this.txtSLNB.Size = new System.Drawing.Size(146, 33);
            this.txtSLNB.TabIndex = 27;
            this.txtSLNB.TextChanged += new System.EventHandler(this.txtSLNB_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(26, 268);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 50);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightBlue;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(26, 372);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 50);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightBlue;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(223, 372);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(140, 50);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnHuyen
            // 
            this.btnHuyen.BackColor = System.Drawing.Color.LightBlue;
            this.btnHuyen.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyen.Location = new System.Drawing.Point(223, 268);
            this.btnHuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuyen.Name = "btnHuyen";
            this.btnHuyen.Size = new System.Drawing.Size(140, 50);
            this.btnHuyen.TabIndex = 33;
            this.btnHuyen.Text = " Quận, Huyện";
            this.btnHuyen.UseVisualStyleBackColor = false;
            this.btnHuyen.Click += new System.EventHandler(this.btnHuyen_Click);
            // 
            // frmTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 456);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuyen);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtSLNB);
            this.Controls.Add(this.txtTenTinh);
            this.Controls.Add(this.txtMaTinh);
            this.Controls.Add(this.dataGridViewTinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmTinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTinh";
            this.Load += new System.EventHandler(this.frmTinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewTinh;
        private System.Windows.Forms.TextBox txtMaTinh;
        private System.Windows.Forms.TextBox txtTenTinh;
        private System.Windows.Forms.TextBox txtSLNB;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnHuyen;
    }
}