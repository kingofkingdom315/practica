﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pract
{
    abstract class Figure
    {
        public double FigureP(double[] topsx, double[] topsy)
        {
            double res = 0;
            for (int i = 0; i < topsx.Length - 1; i++)
            {
                res += Math.Sqrt((topsx[i + 1] -topsx[i]) * (topsx[i + 1] - topsx[i]) + (topsy[i + 1] - topsy[i]) * (topsy[i + 1] - topsy[i]));
            }
            res += Math.Sqrt((topsx[0] - topsx[topsx.Length - 1]) * (topsx[0] - topsx[topsx.Length - 1]) + (topsy[0] - topsy[topsx.Length - 1]) * (topsy[0] - topsy[topsx.Length - 1]));
            return res;
        }
        public void outFigure(double[] topsx, double[] topsy, double S, double P)
        {
            for (int i = 0; i < topsx.Length; i++)
            {
                Console.WriteLine("Вершина " + (i + 1) + " x = " + topsx[i] + " y = " + topsy[i]);
            }
            Console.WriteLine("S = " + S);
            Console.WriteLine("P = " + P);
        }
    }
    class Rectangle : Figure
    { 
        public double[] x = new double[4];
        public double[] y = new double[4];
        public Rectangle()
        {
            x[0] = 0;
            y[0] = 0;
            x[1] = 5;
            y[1] = 0;
            x[2] = 5;
            y[2] = 5;
            x[3] = 0;
            y[3] = 5;
        }
        public Rectangle(double[] A,double[] B)
        {
            for (int i = 0; i < 4; i++)
            {
                x[i] = A[i];
                y[i] = B[i];
            }
        }
        public void tops(double[] TopsX, double[] TopsY)
        {
            for (int i = 0; i < 4; i++)
            {
                this.x[i] = TopsX[i];
                this.y[i] = TopsY[i];
            }
        }
        public double S()
        {
            return Math.Sqrt((x[1] - x[0]) * (x[1] - x[0]) + (y[1] - y[0]) * (y[1] - y[0])) * Math.Sqrt((x[2] - x[1]) * (x[2] - x[1]) + (y[2] - y[1]) * (y[2] - y[1]));
        }
        public double P()
        {
            return (Math.Sqrt((x[1] - x[0]) * (x[1] - x[0]) + (y[1] - y[0]) * (y[1] - y[0])) + Math.Sqrt((x[2] - x[1]) * (x[2] - x[1]) + (y[2] - y[1]) * (y[2] - y[1]))) * 2;
        }
        public void outRectangle()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Вершина " + (i + 1) + " x = " + x[i] + " y = " + y[i]);
            }
            Console.WriteLine("S = " + this.S());
            Console.WriteLine("P = " + this.P());
        }
    }
    class Triangle : Figure
    {
        public double[] x = new double[3];
        public double[] y = new double[3];
        public Triangle()
        {
            x[0] = 0;
            y[0] = 0;
            x[1] = 5;
            y[1] = 0;
            x[2] = 2.5;
            y[2] = 5;
        }
        public Triangle(double[] A, double[] B)
        {
            for (int i = 0; i < 3; i++)
            {
                x[i] = A[i];
                y[i] = B[i];
            }
        }
        public void tops(double[] TopsX, double[] TopsY)
        {
            for (int i = 0; i < 4; i++)
            {
                this.x[i] = TopsX[i];
                this.y[i] = TopsY[i];
            }
        }
        public double S()
        {
            return (x[0] * (y[1] - y[2]) + x[1] * (y[2] - y[0]) + x[2] * (y[0] - y[1]))/2;
        }
        public double P()
        {
            return Math.Sqrt((x[1] - x[0]) * (x[1] - x[0]) + (y[1] - y[0]) * (y[1] - y[0])) + Math.Sqrt((x[2] - x[1]) * (x[2] - x[1]) + (y[2] - y[1]) * (y[2] - y[1])) + Math.Sqrt((x[0] - x[2]) * (x[0] - x[2]) + (y[0] - y[2]) * (y[0] - y[2]));
        }
        public void outTriangle()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Вершина " + (i + 1) + " x = " + x[i] + " y = " + y[i]);
            }
            Console.WriteLine("S = " + this.S());
            Console.WriteLine("P = " + this.P());
        }
    }
    class Circle
    {
        double[] center = new double[2];
        double R;
        public Circle()
        {
            center[0] = 0;
            center[1] = 0;
            R = 5;
        }
        public Circle(double A, double B, double Z)
        {
            center[0] = A;
            center[1] = B;
            R = Z;
        }
        public void topsCircle(double[] c, double r)
        {
            center[0] = c[0];
            center[1] = c[1];
            R = r;
        }
        public double S()
        {
            return Math.PI * R * R;
        }
        public double L()
        {
            return 2 * Math.PI * R;
        }
        public void outCircle()
        {
            Console.WriteLine("Центр = " + center[0] + ":" + center[1]);
            Console.WriteLine("R = " + R);
            Console.WriteLine("S = " + this.S());
            Console.WriteLine("L = " + this.L());
        }
    }
}
