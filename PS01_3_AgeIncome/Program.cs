using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_3_AgeIncome
{
    class Program
    {
        static void Main(string[] args)
        {
           int age = 47;
           int income = 80000;

            if (age <= 35 && income >= 50000)
            {
                Console.WriteLine("You are a Young Professional");
            }

            else if (age <= 55 && income >= 70000)
            {
                Console.WriteLine("You are a Middle-Aged Professional");
            }

            else if (age >= 56 && income <= 30000)
            {
                Console.WriteLine("You are a Senior Citizen");
            }

            else
            {
                Console.WriteLine("Others");
            }
        }
    }
}
