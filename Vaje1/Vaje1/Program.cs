﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int št1 = 15;
            int št2 = 30;
            Console.WriteLine("Moje število 1 je {0}, drugo število je {1}", št1, št2);
            Console.WriteLine("Decimalno {0,5:d}", št1);
            Console.WriteLine("Šestnajstiško {0,5:x}", št1);
            double r = 1234.56789;
            Console.WriteLine("Realno število decimal z 10:f3= {0,10:f3}", r);
            Console.WriteLine("Realno število z 10:e3= {0,10:e3}", r);
            Console.WriteLine("Realno število z 10:p2= {0,10:p2}", r);
            Console.WriteLine("Realno število z 10:n2= {0,10:n2}", r);
            Console.WriteLine("Realno število z 10:g2= {0,10:g2}", r);
            Console.WriteLine("Realno število decimalno z 10:c2= {0,10:c2}", r);
            Console.ReadLine();
        }
    }
}
