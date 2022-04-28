using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh2
{
    public class LichSu
    {
        public listDonHang listDonHang { get; set; }
        public List<String> diachi { get; set; }
        public List<DateTime> date { get; set; }   

        //public String idDonHang { get; set; }
        //public String name { get; set; }
        //public int soluong { get; set; }
        //public int gia { get; set; }
        //public String diachi { get; set; }
        //public DateTime date { get; set; }

        public LichSu()
        {
            this.listDonHang = new listDonHang();
            this.diachi = new List<String>();
            this.date = new List<DateTime>();
        }

        public LichSu(listDonHang listDonHang, List<String> diachi, List<DateTime> date)
        {
            this.listDonHang = listDonHang;
            this.diachi = diachi;
            this.date = date;
        }
    }
}
