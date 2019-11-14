using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Creating_Product_Dll;

namespace Creating_Product_Dll_Part_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            int ppu = int.Parse(textBox1.Text);
            int nou = int.Parse(textBox2.Text);
            double ba = p.GetBillAmount(ppu, nou);

           label1.Text = ba.ToString();



        }
    }
}
