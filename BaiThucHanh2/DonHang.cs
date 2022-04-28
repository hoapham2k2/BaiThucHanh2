using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh2
{
    public class DonHang
    {

        public string idDonHang { get; set; }
        public  List<Product> listproduct { get; set; }
        public List<int> soluong { get; set; }

        //public String idSanPham { get; set; }
        //public String tenDonHang { get; set; }
        //public int soLuong { get; set; }
        //public int giaTien { get; set; }
        //public int thanhTien { get; set; }

        public DonHang() { }
        public DonHang(String idDonHang, List<Product> products, List<int> soluong)
        {
            this.idDonHang = idDonHang;
            this.listproduct = products;
            this.soluong = soluong;
        }
    }
}
