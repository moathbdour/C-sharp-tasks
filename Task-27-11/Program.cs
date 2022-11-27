using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_27_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please inter your age ");
            int myage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please inter your id ");
            int myid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please inter your name ");
            string myname = Console.ReadLine();
            Console.WriteLine("please inter your gender ");
            string mygender = Console.ReadLine();
            Console.WriteLine("please inter your e-mail ");
            string myEmail = Console.ReadLine();
            Console.WriteLine("please inter your phone ");

            string myphone = Console.ReadLine();
            PersonalInfo Moath = new PersonalInfo(myage, myid, myname, mygender, myEmail, myphone);

            string[] myarray = new string[] { };
            myarray = Moath.printer();
            for (int i=0; i<myarray.Length; i++)
            {
                Console.WriteLine(myarray[i]);
            }


        }
    }
}
