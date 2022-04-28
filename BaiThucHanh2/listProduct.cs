using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh2
{
    public class listProduct
    {
        public static List<Product> products = new List<Product>(); 
        
        public static  List<int> soluong = new List<int>();

        public static void insertProduct(Product p, int sl)
        {
            Boolean flag = false;
            for(int i = 0; i <listProduct.products.Count; i++)
            {
                if (p.idSanPham == listProduct.products[i].idSanPham)
                {
                    listProduct.soluong[i] += sl;
                    flag=true;
                }        
            }
            if (!flag)
            {
                listProduct.products.Add(p);
                listProduct.soluong.Add(sl);
            }
        }
    }
}
