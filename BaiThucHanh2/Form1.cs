using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadFormSanPham();
        }

        private void LoadFormSanPham()
        {
            panelData.Controls.Clear();
            FormSanPham frm = new FormSanPham() { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            panelData.Controls.Add(frm);
            frm.Show();
           
        }

        private void LoadFormDonHang()
        {
            panelData.Controls.Clear();
            FormDonHang frm = new FormDonHang() { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            panelData.Controls.Add(frm);
            frm.Show();

        }

        private void LoadFormLichSu()
        {
            panelData.Controls.Clear();
            FormLichSu frm = new FormLichSu() { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            panelData.Controls.Add(frm);
            frm.Show();

        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            LoadFormSanPham();

        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            
            LoadFormDonHang();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadFormLichSu();

        }
    }
}
