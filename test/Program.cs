using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Student
    {

        public string Name    // the Name property
        {
            set => Name = value;
        }
      


        class Program
        {

            static void Main(string[] args)
            {

                Student ahmad = new Student
                {
                    Name = "moath"
                };
               
            }
        }
    }
}

