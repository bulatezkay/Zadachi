using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kv_k
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            a = float.Parse(Console.ReadLine()); 
            b = float.Parse(Console.ReadLine());
            Console.WriteLine(a / b); 
            Console.ReadKey();
        }
    }
}
