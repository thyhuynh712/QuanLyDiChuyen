using System.Windows.Forms;

namespace QLDC
{
    partial class frmQLDiaDiem
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXa = new System.Windows.Forms.Button();
            this.btnHuyen = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightBlue;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(100, 376);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(661, 50);
            this.btnThoat.TabIndex = 37;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXa
            // 
            this.btnXa.BackColor = System.Drawing.Color.LightBlue;
            this.btnXa.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXa.Location = new System.Drawing.Point(577, 268);
            this.btnXa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXa.Name = "btnXa";
            this.btnXa.Size = new System.Drawing.Size(255, 50);
            this.btnXa.TabIndex = 36;
            this.btnXa.Text = "Phường/Xã/Thị Trấn";
            this.btnXa.UseVisualStyleBackColor = false;
            this.btnXa.Click += new System.EventHandler(this.btnXa_Click);
            // 
            // btnHuyen
            // 
            this.btnHuyen.BackColor = System.Drawing.Color.LightBlue;
            this.btnHuyen.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyen.Location = new System.Drawing.Point(304, 268);
            this.btnHuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuyen.Name = "btnHuyen";
            this.btnHuyen.Size = new System.Drawing.Size(255, 50);
            this.btnHuyen.TabIndex = 35;
            this.btnHuyen.Text = "Quận/Huyện";
            this.btnHuyen.UseVisualStyleBackColor = false;
            this.btnHuyen.Click += new System.EventHandler(this.btnHuyen_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.Color.LightBlue;
            this.btnTinh.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(30, 268);
            this.btnTinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(255, 50);
            this.btnTinh.TabIndex = 34;
            this.btnTinh.Text = "Tỉnh/Thành phố";
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::QLDC.Properties.Resources._372f677cf09a8cf376a10a13a236d7a5;
            this.pictureBox3.Location = new System.Drawing.Point(634, 100);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(143, 135);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::QLDC.Properties.Resources._9a70ba746399f90915cc095701913fc2;
            this.pictureBox2.Location = new System.Drawing.Point(364, 100);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::QLDC.Properties.Resources._1263913;
            this.pictureBox1.Location = new System.Drawing.Point(89, 100);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
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
            this.label1.Size = new System.Drawing.Size(856, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Địa Điểm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmQLDiaDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXa);
            this.Controls.Add(this.btnHuyen);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQLDiaDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Địa Điểm";
            this.Load += new System.EventHandler(this.frmQLDiaDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXa;
        private System.Windows.Forms.Button btnHuyen;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}