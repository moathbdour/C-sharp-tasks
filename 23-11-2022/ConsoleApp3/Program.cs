using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {

        static double addnumbers(double x, double y)
        {
            return x + y;
        }


        static double sub(double x, double y)
        {
            return x - y;
        }

        static double mul(double x, double y)
        {
            return x * y;
        }

        static double div(double x, double y)
        {
            return x / y;
        }

        static string wel(string s)
        {
            return "welcome" + s;
        }
        static string bye(string s)
        {
            return "good bye" + s;
        }



        static void Main(string[] args)
        {

            Console.WriteLine("please inter the first number ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("please inter the secound number ");
            double secoundNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("the summation is" + addnumbers(firstNumber, secoundNumber));




            Console.WriteLine("the subtraact is = " + sub(firstNumber, secoundNumber));

            Console.WriteLine("the multiblication is = " + mul(firstNumber, secoundNumber));

            Console.WriteLine("the div is = " + div(firstNumber, secoundNumber));




            Console.WriteLine("inter your name");
            string name1 = Console.ReadLine();
            Console.WriteLine(wel(name1));
            Console.WriteLine(bye(name1));



        }
    }
}
