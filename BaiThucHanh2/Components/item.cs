using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh2.Components
{
    public partial class item : UserControl
    {
        public item()
        {
            InitializeComponent();
        }

        public item(string a,string b,Image img)
        {
            InitializeComponent();
            labelGia.Text = a;
            labelTen.Text = b;
            ptbAnh.Image = img;
        }
    }
}
