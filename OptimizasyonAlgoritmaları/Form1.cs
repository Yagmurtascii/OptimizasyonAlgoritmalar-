using System;
using System.Drawing;
using System.Windows.Forms;

namespace OptimizasyonAlgoritmaları
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Algorithms alg = new Algorithms();
            if(x1.Text!="" || x2.Text != "" || x3.Text != "" || adim.Text != "" || epsilon.Text != "")
            {
                double xValue = (double.Parse(x1.Text));
                double yValue = (double.Parse(x2.Text));
                double zValue = (double.Parse(x3.Text));
                double a = (double.Parse(adim.Text));
                double ep = (double.Parse(epsilon.Text));
                if (comboBox1.SelectedItem.ToString() == "En Dik İniş Algoritması")
                {
                    alg.enDikInis(function.Text, xValue, yValue, zValue, a, ep);
                }
                else
                    alg.eneslenikGradyent(function.Text, xValue, yValue, zValue, a, ep);
            }
  
         
               
            

        }


        private void function_Enter(object sender, EventArgs e)
        {
            function.Text = "";
            function.ForeColor = Color.Black;
        }


        private void adim_Enter(object sender, EventArgs e)
        {
            adim.Text = "";
            adim.ForeColor = Color.Black;
        }


        // x^2 + 2*y^2+ 2*z^2 +2*x*y+2*y*z
    }
}
