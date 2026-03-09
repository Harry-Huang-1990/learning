
using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using InteropAssembly;


namespace labview_dll_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 5.0;
            double b = 10.0;
            double c = 0.0;               
            InteropAssembly.LabVIEWExports.add_lab(a, b, out c);
            Console.WriteLine($"The result of adding {a} and {b} is: {c}");




        }
    }
}