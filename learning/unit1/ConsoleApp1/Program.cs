using System.ComponentModel.Design;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write($"{j}*{i}=" + i * j + "    ");
            //    }
            //    Console.WriteLine();
            //}

            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7 };

            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }
        }


    }
}


class Person
{
    public int Age;
}

