﻿
namespace QLKS
{
    partial class Frm_DANGKIPHONG
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.numPhong = new System.Windows.Forms.NumericUpDown();
            this.DataGrid_Dangkyphong = new System.Windows.Forms.DataGridView();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblIDDatphong = new System.Windows.Forms.Label();
            this.btnDangky = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.numDatphong = new System.Windows.Forms.NumericUpDown();
            this.lblSophong = new System.Windows.Forms.Label();
            this.numSophong = new System.Windows.Forms.NumericUpDown();
            this.numID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Dangkyphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDatphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSophong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ PHÒNG";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(104, 132);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(39, 25);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID ";
            // 
            // numPhong
            // 
            this.numPhong.Enabled = false;
            this.numPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPhong.Location = new System.Drawing.Point(259, 269);
            this.numPhong.Name = "numPhong";
            this.numPhong.Size = new System.Drawing.Size(273, 26);
            this.numPhong.TabIndex = 4;
            // 
            // DataGrid_Dangkyphong
            // 
            this.DataGrid_Dangkyphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Dangkyphong.Location = new System.Drawing.Point(86, 499);
            this.DataGrid_Dangkyphong.Name = "DataGrid_Dangkyphong";
            this.DataGrid_Dangkyphong.RowHeadersWidth = 51;
            this.DataGrid_Dangkyphong.RowTemplate.Height = 24;
            this.DataGrid_Dangkyphong.Size = new System.Drawing.Size(702, 217);
            this.DataGrid_Dangkyphong.TabIndex = 5;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(81, 270);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(101, 25);
            this.lblPhong.TabIndex = 6;
            this.lblPhong.Text = "ID Phòng";
            // 
            // lblIDDatphong
            // 
            this.lblIDDatphong.AutoSize = true;
            this.lblIDDatphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDDatphong.Location = new System.Drawing.Point(71, 204);
            this.lblIDDatphong.Name = "lblIDDatphong";
            this.lblIDDatphong.Size = new System.Drawing.Size(138, 25);
            this.lblIDDatphong.TabIndex = 7;
            this.lblIDDatphong.Text = "ID Đặt phòng";
            this.lblIDDatphong.Click += new System.EventHandler(this.lblIDDatphong_Click);
            // 
            // btnDangky
            // 
            this.btnDangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangky.Location = new System.Drawing.Point(618, 131);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(170, 62);
            this.btnDangky.TabIndex = 8;
            this.btnDangky.Text = "Đăng ký phòng";
            this.btnDangky.UseVisualStyleBackColor = true;
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(618, 309);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(170, 62);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(618, 219);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(170, 62);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // numDatphong
            // 
            this.numDatphong.Enabled = false;
            this.numDatphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDatphong.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numDatphong.Location = new System.Drawing.Point(259, 206);
            this.numDatphong.Name = "numDatphong";
            this.numDatphong.Size = new System.Drawing.Size(273, 26);
            this.numDatphong.TabIndex = 11;
            this.numDatphong.ValueChanged += new System.EventHandler(this.numDatphong_ValueChanged);
            // 
            // lblSophong
            // 
            this.lblSophong.AutoSize = true;
            this.lblSophong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSophong.Location = new System.Drawing.Point(81, 328);
            this.lblSophong.Name = "lblSophong";
            this.lblSophong.Size = new System.Drawing.Size(111, 25);
            this.lblSophong.TabIndex = 12;
            this.lblSophong.Text = "Số phòng ";
            this.lblSophong.Click += new System.EventHandler(this.label2_Click);
            // 
            // numSophong
            // 
            this.numSophong.Enabled = false;
            this.numSophong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSophong.Location = new System.Drawing.Point(259, 327);
            this.numSophong.Name = "numSophong";
            this.numSophong.Size = new System.Drawing.Size(273, 26);
            this.numSophong.TabIndex = 13;
            this.numSophong.ValueChanged += new System.EventHandler(this.numSophong_ValueChanged);
            // 
            // numID
            // 
            this.numID.Enabled = false;
            this.numID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numID.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numID.Location = new System.Drawing.Point(259, 131);
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(273, 26);
            this.numID.TabIndex = 15;
            this.numID.ValueChanged += new System.EventHandler(this.numID_ValueChanged);
            // 
            // Frm_DANGKIPHONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 755);
            this.Controls.Add(this.numID);
            this.Controls.Add(this.numSophong);
            this.Controls.Add(this.lblSophong);
            this.Controls.Add(this.numDatphong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangky);
            this.Controls.Add(this.lblIDDatphong);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.DataGrid_Dangkyphong);
            this.Controls.Add(this.numPhong);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Name = "Frm_DANGKIPHONG";
            this.Text = "Frm_DANGKIPHONG";
            this.Load += new System.EventHandler(this.Frm_DANGKIPHONG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Dangkyphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDatphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSophong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.NumericUpDown numPhong;
        private System.Windows.Forms.DataGridView DataGrid_Dangkyphong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblIDDatphong;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.NumericUpDown numDatphong;
        private System.Windows.Forms.Label lblSophong;
        private System.Windows.Forms.NumericUpDown numSophong;
        private System.Windows.Forms.NumericUpDown numID;
    }
}