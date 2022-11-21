using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            string name = "moath";
            Console.WriteLine(name);
            int number1 = 0;
            double number2 = 1.2;
            char myLetter = 'A';
            string myName = "Moath Bdour";
            bool myBool = false;
            const double pi = 3.14;
            Console.WriteLine(number1+" "+ number2 +" " + myLetter + " " + myName +" "+ myBool + " "+ pi );
            string[] car = { "opel", "mercedes", "Kia", "hyundai" };
            Console.WriteLine(car[0]);
            Console.WriteLine(car[1]);
            Console.WriteLine(car[2]);
            Console.WriteLine(car[3]);
            string firstName = Console.ReadLine();
            string secNAme = Console.ReadLine();
            int birth = 1999;
            Console.WriteLine(firstName + "  " + secNAme + "  " + birth);
            int[] Test = {1,1,2,3,4,5,6,7,8,9};
            Console.WriteLine(Test[0]+ " " + Test[1] + " " + Test[2] + " " + Test[3] + " " + Test[4] + " " + Test[5] + "  " + Test[6] + " " + Test[7] + " " + Test[8] + " " + Test[9] );
            int[] sum = { 2,5,8 };
            int sum2 = sum[0] + sum[1] + sum[2];
            Console.WriteLine(sum2);
        }
    }
}
