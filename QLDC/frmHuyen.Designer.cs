namespace QLDC
{
    partial class frmHuyen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXa = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSLNB = new System.Windows.Forms.TextBox();
            this.txtTenHuyen = new System.Windows.Forms.TextBox();
            this.txtMaHuyen = new System.Windows.Forms.TextBox();
            this.dataGridViewHuyen = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboTinh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightBlue;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(194, 358);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(179, 50);
            this.btnThoat.TabIndex = 46;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXa
            // 
            this.btnXa.BackColor = System.Drawing.Color.LightBlue;
            this.btnXa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXa.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXa.Location = new System.Drawing.Point(194, 273);
            this.btnXa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXa.Name = "btnXa";
            this.btnXa.Size = new System.Drawing.Size(179, 50);
            this.btnXa.TabIndex = 45;
            this.btnXa.Text = "Phường/Xã/Thị Trấn";
            this.btnXa.UseVisualStyleBackColor = false;
            this.btnXa.Click += new System.EventHandler(this.btnXa_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightBlue;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(11, 358);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(179, 50);
            this.btnReset.TabIndex = 44;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(11, 273);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(179, 50);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSLNB
            // 
            this.txtSLNB.BackColor = System.Drawing.Color.Silver;
            this.txtSLNB.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLNB.Location = new System.Drawing.Point(233, 217);
            this.txtSLNB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSLNB.Name = "txtSLNB";
            this.txtSLNB.Size = new System.Drawing.Size(103, 33);
            this.txtSLNB.TabIndex = 41;
            this.txtSLNB.TextChanged += new System.EventHandler(this.txtSLNB_TextChanged);
            // 
            // txtTenHuyen
            // 
            this.txtTenHuyen.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHuyen.Location = new System.Drawing.Point(187, 168);
            this.txtTenHuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenHuyen.Name = "txtTenHuyen";
            this.txtTenHuyen.Size = new System.Drawing.Size(186, 33);
            this.txtTenHuyen.TabIndex = 40;
            this.txtTenHuyen.TextChanged += new System.EventHandler(this.txtTenHuyen_TextChanged);
            // 
            // txtMaHuyen
            // 
            this.txtMaHuyen.BackColor = System.Drawing.Color.Silver;
            this.txtMaHuyen.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHuyen.Location = new System.Drawing.Point(187, 72);
            this.txtMaHuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaHuyen.Name = "txtMaHuyen";
            this.txtMaHuyen.Size = new System.Drawing.Size(109, 33);
            this.txtMaHuyen.TabIndex = 39;
            // 
            // dataGridViewHuyen
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dataGridViewHuyen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHuyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewHuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHuyen.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewHuyen.Location = new System.Drawing.Point(387, 116);
            this.dataGridViewHuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewHuyen.Name = "dataGridViewHuyen";
            this.dataGridViewHuyen.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHuyen.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewHuyen.RowHeadersWidth = 62;
            this.dataGridViewHuyen.RowTemplate.Height = 28;
            this.dataGridViewHuyen.Size = new System.Drawing.Size(586, 334);
            this.dataGridViewHuyen.TabIndex = 14;
            this.dataGridViewHuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHuyen_CellClick);
            this.dataGridViewHuyen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHuyen_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 26);
            this.label5.TabIndex = 37;
            this.label5.Text = "Danh Sách Các Quận/Huyện";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 26);
            this.label4.TabIndex = 36;
            this.label4.Text = "Số Lượng Nhiễm Bệnh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 26);
            this.label3.TabIndex = 35;
            this.label3.Text = "Quận/Huyện:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 26);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mã Quận/Huyện:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.label1.Size = new System.Drawing.Size(984, 55);
            this.label1.TabIndex = 33;
            this.label1.Text = "QUẬN/HUYỆN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 26);
            this.label6.TabIndex = 47;
            this.label6.Text = "Tỉnh/Thành phố:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cboTinh
            // 
            this.cboTinh.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTinh.FormattingEnabled = true;
            this.cboTinh.Location = new System.Drawing.Point(187, 121);
            this.cboTinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTinh.Name = "cboTinh";
            this.cboTinh.Size = new System.Drawing.Size(186, 34);
            this.cboTinh.TabIndex = 48;
            // 
            // frmHuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.cboTinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXa);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtSLNB);
            this.Controls.Add(this.txtTenHuyen);
            this.Controls.Add(this.txtMaHuyen);
            this.Controls.Add(this.dataGridViewHuyen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmHuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHuyen";
            this.Load += new System.EventHandler(this.frmHuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXa;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSLNB;
        private System.Windows.Forms.TextBox txtTenHuyen;
        private System.Windows.Forms.TextBox txtMaHuyen;
        private System.Windows.Forms.DataGridView dataGridViewHuyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cboTinh;
    }
}