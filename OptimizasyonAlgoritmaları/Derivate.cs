using System;
using System.Collections.Generic;
using MathNet.Symbolics;


namespace OptimizasyonAlgoritmaları
{
    public class Derivate
    {
        private static Derivate instance;

        private Derivate() { }

        public static Derivate GetInstance()
        {
            if(instance == null)
                instance = new Derivate();
            return instance;
        }
        public SymbolicExpression PartialDerivativeX { get; private set; }
        public SymbolicExpression PartialDerivativeY { get; private set; }
        public SymbolicExpression PartialDerivativeZ { get; private set; }

        public double x1NewSol { get; set; }
        public double x2NewSol { get; set; }
        public double x3NewSol { get; set; }

        public double dx { get; set; }
        public double dy { get; set; }
        public double dz { get; set; }

        public double substitutedX { get; set; }
        public double substitutedY { get; set; }
        public double substitutedz { get; set; }

        public void Calculate(string function)
        {
            SymbolicExpression func = SymbolicExpression.Parse(function);
            PartialDerivativeX = func.Differentiate("x");
            PartialDerivativeY = func.Differentiate("y");
            PartialDerivativeZ = func.Differentiate("z");
        }

        public void SubstituteValues(double xValue, double yValue, double zValue) 
        {
            substitutedX = PartialDerivativeX.Evaluate(new Dictionary<string, FloatingPoint> { ["x"] = xValue, ["y"] = yValue, ["z"] = zValue }).RealValue;
            substitutedY = PartialDerivativeY.Evaluate(new Dictionary<string, FloatingPoint> { ["x"] = xValue, ["y"] = yValue, ["z"] = zValue }).RealValue;
            substitutedz = PartialDerivativeZ.Evaluate(new Dictionary<string, FloatingPoint> { ["x"] = xValue, ["y"] = yValue, ["z"] = zValue }).RealValue;
        }

        public double CalculateGenlik(double x, double y, double z)
        {
            return Math.Sqrt((Math.Pow(x, 2)) + (Math.Pow(y, 2)) + (Math.Pow(z, 2))); 
        }


        public void newXValuesCalculate(double x1, double x2, double x3, double adim, double dx, double dy, double dz)
        {
            x1NewSol = x1 + (adim * dx);
            x2NewSol = x2 + (adim * dy);
            x3NewSol = x3 + (adim * dz);
        }

        public void dValuesCalculate(double x1, double x2, double x3)
        {
             dx = (-1) * x1;
             dy = (-1) * x2;
             dz = (-1) * x3;
        }

    }
}