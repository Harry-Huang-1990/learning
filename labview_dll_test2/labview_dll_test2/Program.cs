using System;
using InteropAssembly;

namespace labview_dll_test2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1;
            double b = 2;
            double c ;
            LabVIEWExports.add_lab(a, b, out c);
            Console.WriteLine( $"The result of adding {a}, {b}, is: {c}");
        }
    }
}