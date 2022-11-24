using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("input number 1");

            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input number 2");

            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input number 3");

            int m3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input number 4");

            int m4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input number 5");

            int m5 = Convert.ToInt32(Console.ReadLine());

            if (m1 > m2 && m1 > m3 && m1 > m4 && m1 > m5)
            {
                Console.WriteLine("the max number is : " + m1);

            }
            else if (m1 < m2 && m2 > m3 && m2 > m4 && m2 > m5)
            {
                Console.WriteLine("the max number is : " + m2);

            }
            else if (m3 > m1 && m2 < m3 && m3 > m4 && m3 > m5)
            {
                Console.WriteLine("the max number is : " + m3);

            }
            else if (m4 > m2 && m4 > m3 && m1 < m4 && m4 > m5)
            {
                Console.WriteLine("the max number is : " + m4);

            }
            else if (m5 > m2 && m5 > m3 && m5 > m4 && m1 < m5)
            {
                Console.WriteLine("the max number is : " + m5);

            }

        }
    }
}
