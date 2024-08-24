using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_5_SwitchDays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Radius:");
            double radius = double.Parse(Console.ReadLine()); 

            Console.Write("A - Compute Area\nP - Compute Perimeter\nX - Exit\nEnter choice:");
            string choice = Console.ReadLine().ToUpper();

            switch (choice)
            {
                case "A":
                    Console.WriteLine($"The area of the circle is {Math.PI*(radius*radius) :F2}"); //F2 para di na mag double 
                    break;
                case "P":
                    Console.WriteLine($"The perimeter of the circle is {2*Math.PI*radius:F2}");
                    break;
                case "X":
                    Console.WriteLine("Exiting the program");
                    break;
            }
        }
    }
}
