using MathNet.Numerics.LinearAlgebra.Solvers;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //low ve uppr %5 i hesaplanır ona göre random bulunur ve mevcut x1 değerine eklenir.
        private void button1_Click(object sender, EventArgs e)
        {
            HeatTreatment islem = new HeatTreatment();
            double x1l, x1u, x2l, x2u, t, alfa;
            int iterasyon;

            x1l = double.Parse(textBox1.Text);
            x1u = double.Parse(textBox2.Text);
            x2l = double.Parse(textBox3.Text);
            x2u = double.Parse(textBox4.Text);
            t = double.Parse(textBox6.Text);
            alfa = double.Parse(textBox7.Text);
            iterasyon=int.Parse(textBox5.Text);

            islem.Calculate("x^2+y^2", x1l, x1u, x2l, x2u, t, alfa, iterasyon);
        }

    
    }
}
