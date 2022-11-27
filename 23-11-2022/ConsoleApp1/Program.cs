using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static string primenumber(int TestedNumber)
        {
            int savedNumber = TestedNumber;
            int sum = 0, m;
            while (TestedNumber > 0)
            {
                m = TestedNumber % 10;
                sum = sum + m;
                TestedNumber = TestedNumber / 10;
            }
            //Console.WriteLine(savedNumber);

            //Console.WriteLine(sum);
            int lastnumber = savedNumber % 10;
            //Console.WriteLine(lastnumber);


            if ((savedNumber != 2 && savedNumber != 3 && savedNumber != 5 && savedNumber != 1) && (lastnumber % 2 == 0 || sum % 3 == 0 || (lastnumber == 5 && savedNumber > 10) || lastnumber == 0)) {

                return "its not a prime number";

            }
            else
            {
                return "its a prime number";

            }


        }
        static void Main(string[] args)
        {


            Console.WriteLine("Please inter a number to check if its a prime number :");
            int inputtedNumber = Convert.ToInt32(Console.ReadLine());
            string answerPrime = primenumber(inputtedNumber);
            Console.WriteLine(answerPrime);
        }
    }
}
