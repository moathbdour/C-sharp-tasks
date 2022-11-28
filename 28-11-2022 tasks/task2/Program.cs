using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static double calc (double x)
        {
            double summation = x * 20;
            return summation;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("please inter how much leters you have");
            double leters = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("your car can meve " + calc(leters) + "killometers");

        }
    }
}
