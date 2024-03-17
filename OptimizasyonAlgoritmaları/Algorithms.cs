using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptimizasyonAlgoritmaları
{
    public class Algorithms
    {
        Derivate d = Derivate.GetInstance();
        public void enDikInis(string function, double x1, double x2, double x3, double adim, double epsilon)
        {
            int t = 0; //iterasyon aldım
            d.Calculate(function); //kismi türev aldım
            bool isTrue = true;
            while (isTrue)
            {
                d.SubstituteValues(x1, x2, x3); // kismi türeve göre x1 ve x2 değerleri alındı
                double genlik = d.CalculateGenlik(d.substitutedX, d.substitutedY,d.substitutedz);
                t++;
                if (genlik <= epsilon)
                {
                    isTrue = false;
                    MessageBox.Show($"t değeri {t}");
                    break;
                }

                d.dValuesCalculate(d.substitutedX, d.substitutedY, d.substitutedz);
                d.newXValuesCalculate(x1, x2, x3, adim, d.dx, d.dy,d. dz);
                x1 =d. x1NewSol;
                x2 =d. x2NewSol;
                x3 =d. x3NewSol;

            }

        }

        public void eneslenikGradyent(string function, double x1, double x2, double x3, double adim, double epsilon)
        {
            int t = 0;
            d.Calculate(function); //kismi türev aldım
            d.SubstituteValues(x1, x2, x3); // kismi türeve göre x1 ve x2 değerleri alındı
            double genlik = d.CalculateGenlik(d.substitutedX, d.substitutedY, d.substitutedz);
            if (genlik <= epsilon)
            {
                MessageBox.Show($"t değeri {t}");
            }
            else
            {

                d.dValuesCalculate(d.substitutedX, d.substitutedY, d.substitutedz);
                d.newXValuesCalculate(x1, x2, x3, adim, d.dx, d.dy, d.dz);
                x1 = d.x1NewSol;
                x2 = d.x2NewSol;
                x3 = d.x3NewSol;
                while (genlik > epsilon)
                {
                    t++;
                    d.SubstituteValues(x1, x2, x3); // kismi türeve göre x1 ve x2 değerleri alındı
                    double genlik1 = d.CalculateGenlik(d.substitutedX, d.substitutedY, d.substitutedz);
                    if (genlik1 <= epsilon)
                    {
                        MessageBox.Show($"t değeri {t}");
                        Console.WriteLine("t değerim {0}", t);
                        break;
                    }
                    double beta = Math.Pow((genlik1 / genlik), 2);
                    genlik = genlik1;
                    double newDx = -d.substitutedX + beta * d.dx;
                    double newDy = -d.substitutedY + beta * d.dy;
                    double newDz = -d.substitutedz + beta * d.dz;
                    d.dx = newDx;
                    d.dy = newDy;
                    d.dz = newDz;
                    d.newXValuesCalculate(x1, x2, x3, adim, d.dx, d.dy, d.dz);

                    x1 = d.x1NewSol;
                    x2 = d.x2NewSol;
                    x3 = d.x3NewSol;
                }
            }
        }

    }

}
