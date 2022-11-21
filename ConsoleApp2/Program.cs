using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Task1

            Console.WriteLine("input first number");

            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input sec number");

            int secnumber = Convert.ToInt32(Console.ReadLine());
            if(firstnumber > secnumber)
            {
                Console.WriteLine("the biggest number is "+firstnumber);
            }
            else
            {
                Console.WriteLine("the biggest number is " + secnumber);

            }


            //Task2
            Console.WriteLine("input number");


            int f1 = Convert.ToInt32(Console.ReadLine());

            if (f1 >= 0)
            {
                Console.WriteLine("the sign is : +");
            }
            else
            {
                Console.WriteLine("the sign is : -");

            }


            //Task3
            Console.WriteLine("input first number");



            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input sec number");

            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input third number");

            int n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2 && n2 > n3)
            {
                Console.WriteLine(n1 + " " + n2 + " " + n3);

            }
            else if (n1 > n3 && n2 < n3)
            {
                Console.WriteLine(n1 + " " + n3 + " " + n2);

            }
            else if (n2 > n1 && n1 > n3)
            {
                Console.WriteLine(n2 + " " + n1 + " " + n3);
            }
            else if (n2 > n3 && n1 < n3)
            {
                Console.WriteLine(n2 + " " + n3 + " " + n1);
            }
            else if (n3 > n1 && n1 > n2)
            {
                Console.WriteLine(n3 + " " + n1 + " " + n2);
            }
            else if (n3 > n2 && n1 < n2)
            {
                Console.WriteLine(n3 + " " + n2 + " " + n1);
            }
            else
            {
                Console.WriteLine("please dont input equel numbers and embarrass me ");

            };


            //Task4
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

            if(m1>m2&&m1>m3&& m1 > m4 && m1 > m5)
            {
                Console.WriteLine("the max number is : "+ m1);

            }
            else if ( m1 < m2 && m2 > m3 && m2 > m4 && m2 > m5)
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



            //Task5
            Console.WriteLine("Input kilometers per hour");



            double ki = Convert.ToInt32(Console.ReadLine());
            double mi = 0.621371 * ki;
            Console.WriteLine(mi);



            //task 6 

            Console.WriteLine("Input hours");

            int h1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input minutes");

            int i1 = Convert.ToInt32(Console.ReadLine());

            int sum = h1 * 60 + i1;
            Console.WriteLine(sum);


            //task 7
            Console.WriteLine("Input hours");


            int o1 = Convert.ToInt32(Console.ReadLine());
            int c1 = o1 / 60;
            int c2 = o1 % 60;
            Console.WriteLine(c1+"hours ,"+c2 +" minutes");




            string[] moath = { "moathbdour", "khaledobeidat","yazeedfrehat", "malek_obiedat","malneesh_obedat" };

            Console.WriteLine(moath[0].Substring(0,3)+" "+ moath[1].Substring(0, 3) + " " + moath[2].Substring(0, 3) + " " + moath[3].Substring(0, 3) + " " + moath[4].Substring(0, 3) + " " );











        }
    }
}
