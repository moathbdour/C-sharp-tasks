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
            //String[ ]  fruits =["Tomato", "Banana", "Watermelon"]


            //Answers are : 0 , 1
            //---------------------------------------------------------------------



            //Task3
            string[] FavoriteFood = { "Maftool", "maglooba", "Mlookheyah", "Kabsah", "Makmoorah" };
            string[] FavoriteSport = { "soccer", "volleyball", "Swimming" };
            string[] FavoriteMovies = { "Tenet", "inception", "miss peregrine's home for peculiar children" , "Harry Potter" };

            //--------------------------------------------------------------------------------------------------------------------------------------




            //Task4


            Console.Write("Enter three values: ");
            string[] x = Console.ReadLine().Split(',');
            int[] number = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                number[i] = Convert.ToInt32(x[i]);
            }
            //foreach (int i in number)
            //{
            //    int y=y+ i;
            //}
            Console.WriteLine(number[0] + number[1] + number[2]);
            //for(int i=0 ; i<number.Length; i++) { 

            //    int t = t+ number[i];

            //}

            //--------------------------------------------------------------------------------------------------------------------------------------



            //Task5
            int w=0;

            for (int d=0 ; d < 100; d++) { 
                if(d%2!=0)
                {
                    Console.Write(d+" ");
                    w += d;

                }
            
            
            
            }
            Console.WriteLine(w);



            //--------------------------------------------------------------------------------------------------------------------------------------


            //Task6

            for (int y=0 ; y < 5; y++) { 
            
            for(int u=0 ; u < y; u++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");

            }

            //--------------------------------------------------------------------------------------------------------------------------------------
            //Task7
            int c = 1;

            for (int y = 0; y < 5; y++)
            {
                for (int r = 4; r > y; r--)
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
        }
    }
}
