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
    public partial class FormSanPham : Form
    {
        public List<Product> products = new ExcelMapper("data01.xlsx").Fetch<Product>().ToList();

        UserControl1[] listItems = new UserControl1[30];

        public FormSanPham()
        {
            InitializeComponent();
        }
        private void FormSanPham_Load(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();
            int i = 0;
            PictureBox pic = new PictureBox();
            foreach (var product in products)
            {

                listItems[i] = new UserControl1();
                listItems[i].id = product.idSanPham;
                listItems[i].ten = product.ten;
                listItems[i].gia = product.gia;
                var url = Application.StartupPath + "\\ao\\ao0" + product.idSanPham + ".png";
                //pic.ImageLocation = url;
                listItems[i].url = url;
                flowLayoutPanel1.Controls.Add(listItems[i]);
            }
        }

        private void FormSanPham_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UserControl_click(object sender, EventArgs e)
        {
             
        }

        private void tShirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var product in products)
            {
                if (product.theloai.Contains("T-shirt"))
                {
                    UserControl1 test = new UserControl1();
                    test.ten = product.ten;
                    test.gia = product.gia;
                    var url = Application.StartupPath + "\\ao\\ao0" + (product.idSanPham).ToString() + ".png";
                    test.url = url;
                    flowLayoutPanel1.Controls.Add(test);
                }
            }
        }

        private void hoodieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var product in products)
            {
                if (product.theloai.Contains("Hoodie"))
                {
                    UserControl1 test = new UserControl1();
                    test.ten = product.ten;
                    test.gia = product.gia;
                    var url = Application.StartupPath + "\\ao\\ao0" + (product.idSanPham).ToString() + ".png";
                    test.url = url;
                    flowLayoutPanel1.Controls.Add(test);
                }
            }
        }

        private void phụKiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var product in products)
            {
                if (product.theloai.Contains("Phụ kiện"))
                {
                    UserControl1 test = new UserControl1();
                    test.ten = product.ten;
                    test.gia = product.gia;
                    var url = Application.StartupPath + "\\ao\\ao0" + (product.idSanPham).ToString() + ".png";
                    test.url = url;
                    flowLayoutPanel1.Controls.Add(test);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var product in products)
            {
                if (product.ten.Contains(textBox1.Text))
                {
                    UserControl1 test = new UserControl1();
                    test.ten = product.ten;
                    test.gia = product.gia;
                    var url = Application.StartupPath + "\\ao\\ao0" + (product.idSanPham).ToString() + ".png";
                    test.url = url;
                    flowLayoutPanel1.Controls.Add(test);
                }
            }
        }

        
    }
}
