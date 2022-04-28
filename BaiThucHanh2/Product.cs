using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh2
{
    public class Product
    {
        public String idSanPham { get; set; }
        public String ten { get; set; }
        public String theloai { get; set; }
        public int gia { get; set; }

        public Product() { }

        public Product(String idSanPham,string ten,String theloai,int gia)
        {
            this.idSanPham = idSanPham;
            this.ten = ten;
            this.theloai = theloai;
            this.gia = gia;
        }

        //public Product(String idSanPham, String ten, int gia)
        //{
        //    this.idSanPham= idSanPham;
        //    this.ten = ten;
        //    this.gia = gia;
        //}
    }
}
