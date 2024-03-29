﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class Frm_DICHVU : Form
    {
        public Frm_DICHVU()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();

        public void BANG_DICHVU()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from DICH_VU");
            dataGridView1.DataSource = dta;
            HIENTHI_DULIEU();
        }

        private void HIENTHI_DULIEU()
        {
            txt_ID.DataBindings.Clear();
            txt_ID.DataBindings.Add("Value", dataGridView1.DataSource, "ID");

            txt_Ten.DataBindings.Clear();
            txt_Ten.DataBindings.Add("Text", dataGridView1.DataSource, "TEN");

            txt_Gia.DataBindings.Clear();
            txt_Gia.DataBindings.Add("Text", dataGridView1.DataSource, "GIA");
        }
        private void Frm_DICHVU_Load(object sender, EventArgs e)
        {
            BANG_DICHVU();


        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HIENTHI_DULIEU();
        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            DataTable dta = kn.Lay_DulieuBang("select (Max(id)+1) as id from dich_vu");
            txt_ID.DataBindings.Clear();
            txt_ID.DataBindings.Add("value", dta, "id");
            txt_Ten.Text = "";
            txt_Gia.Text = "";
            txt_ID.Focus();
            btn_Luu.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm dịch vụ này vào danh sách dịch vụ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                String sql_Luu = "insert into DICH_VU values (" + txt_ID.Value + ",'" + txt_Ten.Text + "', " + txt_Gia.Text + ");";
                kn.ThucThi(sql_Luu);
               
            }
            BANG_DICHVU();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa thông tin dịch vụ này trong danh sách dịch vụ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string sql_sua = "update  DICH_VU set TEN = '" + txt_Ten.Text + "' , GIA=" + txt_Gia.Text + " where id=" + txt_ID.Text;
                kn.ThucThi(sql_sua);
                
            }
            BANG_DICHVU();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa thông tin dịch vụ này trong danh sách dịch vụ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                String sql_Xoa = "DELETE  FROM [DICH_VU] WHERE ID=" + txt_ID.Value + ";";
                kn.ThucThi(sql_Xoa);
                
            }
            BANG_DICHVU();
        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
