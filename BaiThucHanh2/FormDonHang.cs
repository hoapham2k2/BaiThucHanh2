using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ganss.Excel;

namespace BaiThucHanh2
{
    public partial class FormDonHang : Form
    {
        //public List<LichSu> lichsus = new ExcelMapper("data02.xlsx").Fetch<LichSu>().ToList();
        public FormDonHang()
        {
            InitializeComponent();


            for (int i = 0; i < listProduct.products.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = listProduct.products[i].ten;
                row.Cells[1].Value = listProduct.soluong[i].ToString();
                row.Cells[2].Value = (listProduct.products[i].gia * listProduct.soluong[i]).ToString();
                dataGridView1.Rows.Add(row);
            }
            
        }

        public int tinhTongTien()
        {
            int tong = 0;
            for(int i=0;i<listProduct.products.Count;i++)
            {
                tong += listProduct.products[i].gia * listProduct.soluong[i];
            }
            return tong;
        }

        private void FormDonHang_Load(object sender, EventArgs e)
        {
            labelTongTienGT.Text = tinhTongTien().ToString();
            
        }
        

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            
            //List<LichSu> lichsus = new List<LichSu>();
            //foreach (DonHang dh in listDonHang.donHangs)
            //{
            //    LichSu ls = new LichSu();
            //    //ls.id = dh.id;
            //    ls.name = dh.tenDonHang;
            //    ls.soluong = dh.soLuong;
            //    ls.gia = dh.giaTien;
            //    ls.diachi = tbDCGH.Text;
            //    ls.date = DateTime.Now;
            //    lichsus.Add(ls);
            //}

            //new ExcelMapper().Save("data02.xlsx", lichsus, "lichsus");
            //MessageBox.Show("Bạn đã đặt hàng");
            //dataGridView1.DataSource = null;
            //tbDCGH.Text = "";
            //labelTongTienGT.Text = "0";
            //dataGridView1.Refresh();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
