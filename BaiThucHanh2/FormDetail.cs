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
    public partial class FormDetail : Form
    {
         
        public FormDetail()
        {
            InitializeComponent();
            this.id = "";
            this.name = "";
            this.gia = 0;
            this.url = "";
            this.soluong = 0;
        }
        public String id;
        public String name;
        public int gia;
        public String url;
        public int soluong;
        public FormDetail(String id, String ten, int gia, String url)
        {
            InitializeComponent();
            this.id = id;
            this.name = ten;
            this.gia = gia;
            this.url = url;

        }
        private void FormDetail_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = url;
            labelTen.Text = this.name;
            labelGia.Text = this.gia.ToString();
            numericUpDown1.Value = 1;
        }

        private void FormDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.soluong = Int32.Parse(numericUpDown1.Value.ToString());
            Product product = new Product(this.id, this.name,"", this.gia);
            listProduct.insertProduct(product, this.soluong);
           



            //DonHang donHang = new DonHang(this.id,this.name, this.soluong,this.gia);
            Boolean flag = false;
            //foreach (DonHang dh in listDonHang.donHangs)
            //{
            //    if (dh.idSanPham == this.id)
            //    {
            //        dh.soLuong += this.soluong;
            //        flag = true;
            //    }
            //}
            //if (!flag)
            //    listDonHang.donHangs.Add(donHang);
            MessageBox.Show("Ok");

        }


    }
}
