using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        class car
        {



            //static double calc(double x)
            //{
            //    double summation = x * 20;
            //    return summation;
            //}
            //static void Main(string[] args)
            //{
            //    Console.WriteLine("please inter how much leters you have");
            //    double leters = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("your car can meve " + calc(leters) + "killometers");

            //}
            public int makeYear;
            public string type;
            public int price;
            public string model;
            public int palletNo;
            public string color;
            string mystato;


            public void engine(bool action)
            {
                if (action)
                {
                    
                    mystato = "the engin is on";
                }
                else
                {
                    
                    mystato = "the engin is off";
                }
            }

            public double calc(double x)
            {
                double summation = x * 20;
                return summation;
            }


            public string[] CarStatus()
            {
                string[] status = new string[7];
                status[0] = Convert.ToString(makeYear);
                status[1] = type;
                status[2] = Convert.ToString(price);
                status[3] = model;
                status[4] = Convert.ToString(palletNo);
                status[5] = color;
                status[6]= mystato;
               
                return status ;
            }

           

        }
        class Opel : car
        {
            public Opel(int makeYear1, string type1, int price1, string model1, int palletNo1, string color1)
            {
                makeYear = makeYear1;
                type = type1;
                price = price1;
                model = model1;
                palletNo = palletNo1;
                color = color1;
                
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("please inter car make year");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please inter cars Type");
            string type = Console.ReadLine();
            Console.WriteLine("please inter cars price");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please inter cars model");
            string model = Console.ReadLine();
            Console.WriteLine("please inter cars Pallet.No");
            int pallet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please inter cars color");
            string color = Console.ReadLine();
            Console.WriteLine("please inter cars Engine states Type 'on' Or 'off'");
            string enStatus = Console.ReadLine();
            bool st;
            if (enStatus == "on")
            {
                st=true;
            }
            else

            {
                st = true;
            }
            Opel mycar = new Opel(year, type, price, model, pallet, color);
            mycar.engine(st);
            string[] stat = new string[7];
            stat = mycar.CarStatus();
            for(int i=0; i<stat.Length; i++)
            {
                Console.WriteLine(stat[i]);
            }

            Console.WriteLine("please inter how much leters you have");
            double leters = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("your car can meve " + mycar.calc(leters) + " killometers");



        }
    }
}
