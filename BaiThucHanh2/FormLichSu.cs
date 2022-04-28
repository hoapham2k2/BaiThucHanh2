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
    public partial class FormLichSu : Form
    {
        public List<LichSu> lichsus = new ExcelMapper("data02.xlsx").Fetch<LichSu>().ToList();

        public FormLichSu()
        {
            InitializeComponent();
            dataGridView1.DataSource = lichsus;
        }
    }
}
