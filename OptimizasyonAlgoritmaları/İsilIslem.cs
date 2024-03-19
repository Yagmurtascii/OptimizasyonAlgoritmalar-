using MathNet.Numerics.Random;
using MathNet.Symbolics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptimizasyonAlgoritmaları
{
    public class İsilIslem
    {

        public SymbolicExpression x { get; private set; }
        public SymbolicExpression y { get; private set; }
        public double fBaslangic { get; set; }
        public double fKomsu { get; set; }


        // x başlangıç değeri upper xbu
        public void Calculate(string function, double x1bl, double x1bu, double x2bl, double x2bu, double T, double alfa, int iterasyon)
        {
            Random rnd = new Random();
            SymbolicExpression func = SymbolicExpression.Parse(function);

            //başlangıç değerlerine göre ara değerler çekilmesi gerek
            double x1Constant = rnd.NextDouble() * (x1bu - x1bl) + x1bl;
            double x2Constant = rnd.NextDouble() * (x2bu - x2bl) + x2bl;
            Console.WriteLine("1 x1Value {0}", x1Constant);
            Console.WriteLine("2 x2Value {0}", x2Constant);
            double teta = rnd.NextDouble() * (0 - 1) + 1;
            Console.WriteLine("Sıcaklık {0}", T);
            Console.WriteLine("Alfa {0}", alfa);
            // döngü içinde yeni bir x1Value  üret sürekli
            fBaslangic = func.Evaluate(new Dictionary<string, FloatingPoint> { ["x"] = x1Constant, ["y"] = x2Constant }).RealValue;
            while (iterasyon > 0)
            {
                //low ve uppr % 5 i hesaplanır ona göre random bulunur ve mevcut x1 değerine eklenir.
                double x1Value = rnd.NextDouble() * (x1bu*0.05 - x1bl*0.05) + x1bl * 0.05;
                double x2Value = rnd.NextDouble() * (x2bu * 0.05 - x2bl * 0.05) + x2bl;
                Console.WriteLine("x1Value {0}", x1Value);
                Console.WriteLine("x2Value {0}", x2Value);
                double x1KomsuValue = x1Constant + x1Value;
                double x2KomsuValue = x2Constant + x2Value;
                fKomsu = func.Evaluate(new Dictionary<string, FloatingPoint> { ["x"] = x1KomsuValue, ["y"] = x2KomsuValue }).RealValue;
                double delta = fBaslangic - fKomsu;

                if (delta < 0 || Math.Pow(Math.E, (-delta/T))>teta)
                {
                    x1Constant = x1KomsuValue;
                    x2Constant = x2KomsuValue;
                }
                T = T * alfa;
                iterasyon--;
            }
            Console.WriteLine(x1Constant);
            Console.WriteLine(x2Constant);
            Console.WriteLine(T);
            Console.WriteLine(fBaslangic);
            MessageBox.Show($"x1 değeri : {x1Constant}" +
                $"\nx2 değeri : {x2Constant} " +
                $"\nSon sıcaklık değeri: {T}", "İterasyon sonucu" , MessageBoxButtons.OK, MessageBoxIcon.Information);
      



        }
    }
}
