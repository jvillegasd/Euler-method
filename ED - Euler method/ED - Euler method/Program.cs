using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED___Euler_method
{
    class Program
    {
        static void Main(string[] args)
        {
            double ivpx = -1; //Inital value of X
            double ivpy = 3; //Initial value of Y
            double finalx = 2; //Final value of X
            double n = 3; //Steps
            double increase = findIncrement(ivpx, finalx, n); //Increase value
            /*Formulas:
                Xn+1 = Xn + increase
                Yn+1 = Yn + increase*f(Xn, Yn)
            */
            eulerMethod(increase, ivpx, ivpy, finalx);
        }

        static void eulerMethod(double increase, double ivpx, double ivpy, double finalx)
        {
            double yaprox = ivpy, xaprox = ivpx;
            Console.WriteLine("Euler method for dy/dx = x-y-2:\n");
            for (double i = ivpx; i <= finalx; i = i + increase)
            {
                if (i != finalx)
                {
                    Console.WriteLine("X = {0}, Y = {1}, dy/dx = {2}", i, yaprox, function(i, yaprox));
                }
                else
                {
                    Console.WriteLine("X = {0}, Y = {1}, dy/dx = {2} <--- Final", i, yaprox, function(i, yaprox));
                }
                yaprox = yaprox + increase * function(i, yaprox);
            }

            Console.ReadLine();
        }

        static double function(double x, double y)
        {
            return (x - y - 2);
        }

        static double findIncrement(double ivpx, double finalx, double n)
        {
            return ((finalx - ivpx) / n);
        }
    }
}