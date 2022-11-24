using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks_23_11_2022
{
    internal class Program
    {
        static double[] summations(double[] i)
        {
            double sum = 0;
            double avg = 0;
            for (int x = 0; x < i.Length; x++)
            {
                sum += i[x];

            }
            avg = sum / i.Length;
            return new[] { sum, avg };
        }

        static int cubic(int c)
        {
            int cub = c * c * c;
            return cub;
        }

        static int[] GetYears (int[] b)
        {
            int sum = 0;

            for (int x = 0; x < b.Length; x++)
            {
                if (b[x] > 1950)
                {
                    sum++;

                }
            }
            int[] PassYears = new int[sum];
            int h = 0;

            for (int r=0; r < b.Length ; r++)
            {
                if (b[r] > 1950)
                {

                   
                    PassYears[h] = b[r];
                    h++;
                }
            }
            return PassYears;
        }

        static int calculateAge (int t) {

            //int myAge = 2022-t;
            int myAge =  t;
            return myAge*365+myAge/4;
        
        
        
        }

        static int animals (int ch , int co , int pi) {

            return ch*2+co*4+pi*4;
        }


        static string check (string[] userInput)

        {
            
            string[][] data = new string[3][];
            data[0] = new string[2] { "moathbdur@gmail.com", "passward" };
            data[1] = new string[2] { "moath bdour", "passward2" };
            data[2] = new string[2] { "anyuser", "passward3" };
            int count = 0;
            
            for (int x=0 ; x < data.Length; x++)
            {
                for (int y=0; y< data[x].Length; y++)
                {
                    while (userInput[y] == data[x][y])
                    {
                        count++;
                        if (count == 2)
                        {
                            return "pass";
                        }
                        
                    }
                }
            }   
               return "failed";
        }

        static int powernumber1 (int b , int p) { 
        
            int sum = 1;
        for(int x=0 ; x < p ; x++) {
            sum*=b ;
            
            }
        return sum;
        }


        static string leap (int p)
        {
            if (p<1900|| p > 2024)
            {
                Console.WriteLine("please input year between 1900-2024");
                p=Convert.ToInt32(Console.ReadLine());
               
            }
            else { 

                if (p%4==0 && (p%100!=0 || p % 400 == 0)){
                    return "its a leap year";
                }
                else
                {
                    return "its a leap year";
                }
            }

            return leap(p);


        }


        static string primenumber (int TestedNumber)
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
            
           
            if(lastnumber %2 ==0 || sum %3 ==0 ||  (lastnumber == 5 && savedNumber>10)   || lastnumber==0) {

                return "its not a prime number";

            }
            else
            {
                return "its a prime number";

            }


        }


        static int wordsCounter(string[] sentence)
        {
            int counter = 0;
            for (int x=0; x<sentence.Length; x++)
            {
                if (sentence[x].Length>=2) { 
                    counter++;


                }
            }
            return counter;




        }






        static void Main(string[] args)
        {


            //Task1
            Console.WriteLine("Please Input 10 numbers dividers between commas : ");
            string[] inputs = Console.ReadLine().Split(',');
            double[] numbers = new double[inputs.Length];
            for (int x = 0; x < inputs.Length; x++)
            {
                numbers[x] = Convert.ToDouble(inputs[x]);
            }

            double[] results = summations(numbers);
            Console.WriteLine("the summation of the numbers : " + results[0]);
            Console.WriteLine("the Average of the numbers : " + results[1]);

            ////End||| -_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||


            ////Task2

            Console.WriteLine("Please inter a number to cube it");
            int cube = Convert.ToInt16(Console.ReadLine());
            int cubedNumber = cubic(cube);
            Console.WriteLine(cubedNumber);

            //End||| -_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||


            //Task3
            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };


            int[] PassYears2 = GetYears(years);
            for (int x = 0; x < PassYears2.Length; x++)
            {
                Console.WriteLine(PassYears2[x]);
            }
            //End||| -_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||



            //task4

            Console.WriteLine("Please inter your age in years to calculate it in days");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("your Age in Days including leap years :" + calculateAge(age));
            //End||| -_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||



            //Task5
            Console.WriteLine("How many Chickens you have ?");
            int chickens = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many cows you have ?");
            int cows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many pigs you have ?");
            int pigs = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("congeratulations your farm has "+animals(chickens, cows, pigs) + " legs.");

            //End||| -_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||



            //Task6

            string[] userinput = new string[2];
            Console.WriteLine("please inter the user name or e-mail :");
            userinput[0] = Console.ReadLine();
            Console.WriteLine("please inter the Passward :");
            userinput[1] = Console.ReadLine();

            Console.WriteLine(check(userinput));


            //End||| -_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||

            //Task7

            Console.WriteLine("please inter the base number :");
            int baseNumber = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("please inter the Power number :");
            int powerNumber = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(powernumber1(baseNumber, powerNumber));

            //End||| -_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||


            //Task8

            Console.WriteLine("please inter a year to check :");
            int checkyear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(leap(checkyear));

            //End||| -_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||

            //Task9

            Console.WriteLine("Please inter a number to check if its a prime number :");
            int inputtedNumber = Convert.ToInt32(Console.ReadLine());
            string answerPrime = primenumber(inputtedNumber);
            Console.WriteLine(answerPrime);

            //End||| -_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||

            //Task10 
            Console.WriteLine("please input a sentence to count the number of words in it :");
            String[] inputtedSentence= Console.ReadLine().Split(' ');
            Console.WriteLine("the number of words are :" + wordsCounter(inputtedSentence));

            //End||| -_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||-_-|||-_-|||||-_-||||




        }
    }
}
