using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_22_11_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task1
            int[] ARR = { 1, 7, 9, 45, };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over ", "lazy", "dog", };
            //---------------------------------------------------------------------------




            //Task2
            //What the index of "Banana","Tomato" ?
            String[] fruits = { "Tomato", "Banana", "Watermelon" };


            //Answers are : 1 , 0
            Console.WriteLine(Array.IndexOf(fruits, "Banana"));

            Console.WriteLine(Array.IndexOf(fruits, "Tomato"));
            //---------------------------------------------------------------------



            //Task3
            string[] FavoriteFood = { "Maftool", "maglooba", "Mlookheyah", "Kabsah", "Makmoorah" };
            string[] FavoriteSport = { "soccer", "volleyball", "Swimming" };
            string[] FavoriteMovies = { "Tenet", "inception", "miss peregrine's home for peculiar children", "Harry Potter" };


            for(int a =0; a < FavoriteFood.Length; a++)
            {
                Console.Write(FavoriteFood[a]+ " ");
            }
            Console.WriteLine();
            for (int a = 0; a < FavoriteSport.Length; a++)
            {
                Console.Write(FavoriteSport[a] + " ");
            }
            Console.WriteLine();

            for (int a = 0; a < FavoriteMovies.Length; a++)
            {
                Console.Write(FavoriteMovies[a] + " ");
            }
            Console.WriteLine();

            //--------------------------------------------------------------------------------------------------------------------------------------




            //Task4


            Console.Write("Enter three values: ");
            string[] x = Console.ReadLine().Split(',');
            int[] number = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                number[i] = Convert.ToInt32(x[i]);
            }

            Console.WriteLine(number[0] + number[1] + number[2]);
            //for(int i=0 ; i<number.Length; i++) { 

            //    int t = t+ number[i];

            //}

            //--------------------------------------------------------------------------------------------------------------------------------------



            //Task5
            int w = 0;

            for (int d = 0; d < 100; d++)
            {
                if (d % 2 != 0)
                {
                    Console.Write(d + " ");
                    w += d;

                }



            }
            Console.WriteLine(w);



            //--------------------------------------------------------------------------------------------------------------------------------------


            //Task6

            //for (int y=0 ; y < 5; y++) {
            //    for (int r = 4; r > y; r--)
            //    {
            //        Console.Write(" ");


            //    }

            //    for (int u=0 ; u < y; u++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine(" ");

            //}

            int counter = 5;

            for (int y = 0; y < counter; y++)
            {
                for (int r = counter-1; r > y; r--)
                {
                    Console.Write(" ");


                }


                for (int u = 0; u < y; u++)
                {

                    Console.Write("* ");


                }
                Console.WriteLine("");


            }

            //--------------------------------------------------------------------------------------------------------------------------------------
            //Task7
            int c = 1;

            for (int y = 0; y < counter; y++)
            {
                for (int r = counter-1; r > y; r--)
                {
                    Console.Write(" ");


                }

                for (int u = 0; u < y; u++)
                {

                    Console.Write(c + " ");
                    c++;

                }
                Console.WriteLine(" ");

            }




            //Task
            //--------------------------------------------------------------------------------------------------------------------------------------
            //Console.Write("Enter as much values you want: ");
            //string[] i = Console.ReadLine().Split(',');
            //int[] numbers = new int[x.Length];
            //for (int u = 0; u < x.Length; u++)
            //{
            //    numbers[u] = Convert.ToInt32(x[u]);
            //}
            //double o = 0;

            //for (int k = 0; k < numbers.Length; k++)
            //{


            //}


            string f = Console.ReadLine();
            string[] nums = f.Split(',');
            int[] x1 = new int[nums.Length];
            //int[] x2 = new int[] { };
            //int sum = 0;
            //int co = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                x1[i] = Convert.ToInt32(nums[i]);
            }

            
            for (int a = 1; a < x1.Length; a++)
            {
                for (int d = 0; d < a; d++)
                    while (x1[a] == x1[d])
                    {
                        x1[d] = 0;
                    }
            }
            int summation = 0;
            int zeros = 0;
            for(int h=0; h < x1.Length;h++)
            {
                summation+= x1[h];
                if (x1[h] == 0)
                {
                    zeros++;
                }

            }
            double jj = summation / (x1.Length - zeros);

            Console.WriteLine(jj);



            //string f = Console.ReadLine();
            //string[] nums = f.Split(',');
            //int[] x1 = new int[nums.Length];
            //int[] x2 = new int[] { };
            //int sum = 0;
            //int co = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    x1[i] = Convert.ToInt32(nums[i]);
            //}




            //int[] array = { 1, 3, 4, 5, 4, 2 };
            //int item = 4;

            //for(int i=0; i < x1.Length; i++)
            //{
            //    int index = Array.IndexOf(x1, i);
            //    x1 = x1.Where((e, p) => p != i).ToArray();

            //}



            //for (int x = 0; x < x1.Length; x++)
            //{
            //    Console.WriteLine(x);
            //}
        }
    }
}
