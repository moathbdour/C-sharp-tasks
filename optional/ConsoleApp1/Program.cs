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
            for (int h = 0; h < x1.Length; h++)
            {
                summation += x1[h];
                if (x1[h] == 0)
                {
                    zeros++;
                }

            }
            double jj = summation / (x1.Length - zeros);

            Console.WriteLine(jj);

        }
    }
}
