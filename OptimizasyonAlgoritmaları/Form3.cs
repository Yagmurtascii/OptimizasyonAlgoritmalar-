using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptimizasyonAlgoritmaları
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deneme deneme = new Deneme();
            deneme.Calculate("x^2 + 2*y^2+ 2*z^2 +2*x*y+2*y*z+a^3+b");
            var form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.Show();
        }
    }
}
