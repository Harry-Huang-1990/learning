using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using MR.Data;

namespace MR.View
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model_1 = new Model();
            model_1.GetData();
        }
    }
}

namespace MR.Data
    {
    class Model
    {
        public void GetData()
        {
            Console.WriteLine("我爱你");
            Console.ReadLine();
            
        }
    }
}
