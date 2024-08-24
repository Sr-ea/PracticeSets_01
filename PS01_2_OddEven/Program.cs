using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_2_OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = -9;

            if (n < 0)
            {
                Console.WriteLine($"{n} is Negative");
            }

            else 
            {
                Console.WriteLine($"{n} is Positive");
            }
        }
    }
}
