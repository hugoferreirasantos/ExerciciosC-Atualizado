﻿using System;
using System.Globalization;

namespace uri1060
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double e = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double f = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double[] vet = { a, b, c, d, e, f };

            int cont = 0;


            foreach(double i in vet)
            {
                if(i > 0.0)
                {
                    cont++;
                }

                
            }

            Console.WriteLine($"{cont} valores positivos");


            /*
             if (a > 0.0)
            {
                cont = cont + 1;
            }
            if (b > 0.0)
            {
                cont = cont + 1;
            }
            if (c > 0.0)
            {
                cont = cont + 1;
            }
            if (d > 0.0)
            {
                cont = cont + 1;
            }
            if (e > 0.0)
            {
                cont = cont + 1;
            }
            if (f > 0.0)
            {
                cont = cont + 1;
            }
            Console.WriteLine(cont + " valores positivos");
             */


        }
    }
}