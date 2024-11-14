﻿using doandbms.Dbs;
using doandbms.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doandbms.Design
{
    public partial class QuanLiSinhVien : UserControl
    {
        private QlyRepository qlyRepository = new QlyRepository();
        QuanLy quanLy = new QuanLy();
        SinhVien sinhVien = new SinhVien();

        public QuanLiSinhVien(QuanLy quanLy)
        {
            this.quanLy = quanLy;
            InitializeComponent();
        }


        private void dt_Student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void LoadDataToGried(string Toa)
        {
            MessageBox.Show(quanLy.MaToaQl.ToString());
            DataTable dt = new DataTable();
            dt = qlyRepository.ShowSinhVienInToa(Toa);
            dtg_student.DataSource = dt;
        }

        private void QuanLiSinhVien_Load(object sender, EventArgs e)
        {
            LoadDataToGried(quanLy.MaToaQl);
        }

        private void txt_search_sv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt = qlyRepository.SearchSvKeyDown(txt_search_sv.Text, quanLy.MaToaQl);
                dtg_student.DataSource = dt;
            }
        }


        private void dtg_student_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GetDataStudent(e);
                txt_masv.Text = sinhVien.MaSv;
                txt_cccd.Text = sinhVien.Cccd;
                txt_name.Text = sinhVien.HoTen;
                txt_sdt.Text = sinhVien.Sdt;
                txt_maphong.Text = sinhVien.MaPhong;
                txt_matoa.Text = sinhVien.MaToa;
                txt_diachi.Text = sinhVien.DiaChi;
                txt_sex.Text = sinhVien.Sex;
                mdf_date.Text = sinhVien.NgaySinh.ToString("dd/MM/yyyy");
            }
        }

        private void GetDataStudent(DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtg_student.Rows[e.RowIndex];
            sinhVien.MaSv = row.Cells["MaSV"].Value.ToString();
            sinhVien.Cccd = row.Cells["CCCD"].Value.ToString();
            sinhVien.HoTen = row.Cells["HoTen"].Value.ToString();
            sinhVien.Sdt = row.Cells["SDT"].Value.ToString();
            sinhVien.MaPhong = row.Cells["MaPhong"].Value.ToString();
            sinhVien.MaToa = row.Cells["MaToa"].Value.ToString();
            sinhVien.DiaChi = row.Cells["DiaChi"].Value.ToString();
            sinhVien.Sex = row.Cells["GioiTinh"].Value.ToString();
            string date = row.Cells["NgaySinh"].Value.ToString();
            sinhVien.NgaySinh = DateTime.Parse(date);
            sinhVien.MaSv = row.Cells["MaSV"].Value.ToString();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Muốn xóa sinh viên này ? ", "Xóa sinh viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txt_masv.Text.Length > 0)
                {
                    qlyRepository.DeleteSv(txt_masv.Text);
                }
                else
                {
                    MessageBox.Show("Không có sinh viên được chọn");
                }
            } 
        }
    }
}
