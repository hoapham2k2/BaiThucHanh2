using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using BarcodeLib;
using ZXing;

namespace test
{
    public partial class Form1 : Form
    {
        BarcodeLib.Barcode code128 = new BarcodeLib.Barcode();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image barcode = code128.Encode(BarcodeLib.TYPE.CODE128, textBox1.Text);
            pictureBox1.Image = barcode;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCode qrCode = new QRCode(qrGenerator.CreateQrCode(textBox2.Text, QRCodeGenerator.ECCLevel.Q));
            pictureBox2.Image = qrCode.GetGraphic(2, Color.Black, Color.White, false);
            qrGenerator.Dispose();
            qrCode.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
