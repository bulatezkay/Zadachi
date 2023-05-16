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
            try
            {
                float a, b, c = 0;
                Console.WriteLine("Enter parametr a");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter parametr a");
                b = float.Parse(Console.ReadLine()); 
                If (a != 0 and b != 0)
                    c = a / b;
                Console.WriteLine("Answer is " + Convert.ToString(c)); 
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("incorrect data")
            }
        }
    }
}
