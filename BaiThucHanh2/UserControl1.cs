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
    public partial class UserControl1 : UserControl
    {
        class UserControl1ControlCollection : ControlCollection
        {
            UserControl1 owner;
            public UserControl1ControlCollection(UserControl1 owner): base(owner)
            {
                this.owner = owner;
            }

            public override void Add(Control value)
            {
                base.Add(value);
                value.Click += Value_Click;
            }

            private void Value_Click(object sender, EventArgs e)
            {
                owner.OnClick(EventArgs.Empty);
            }
        }

        protected override ControlCollection CreateControlsInstance()
        {
            return new UserControl1ControlCollection(this);
        }
        public String _id;
        public String _ten;
        public int _gia;
        public String _url;

        public String id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String ten
        {
            get { return _ten; }
            set { _ten = value; labelTen.Text = value; }
        }

        public int gia
        {
            get { return _gia; }
            set { _gia = value; labelGia.Text = value+"vnd"; }
        }

        public String url
        {
            get { return _url; }
            set
            {
                _url = value; ptbAnh.LoadAsync(value);
            }
        }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            FormDetail formdetail = new FormDetail(_id,_ten,_gia, _url);
            formdetail.Show();
        }
    }
}
