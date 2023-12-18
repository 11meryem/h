using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int a=Convert.ToInt32(txtSayi1.Text);
            int b=Convert.ToInt32(txtSayi2.Text);
            double c=Math.Sqrt(a*a+b*b);
            label1.Text = "hipotenüs = " + c.ToString();
        }  
}
