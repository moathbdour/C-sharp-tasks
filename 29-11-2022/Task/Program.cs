using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task
{
    internal class Program
    {
        interface moath
        {
             void StartEngine();
            void StopEngine();
             void OpenDoor();
            void CloseDoor();
            void Honk();
            void IncreaseSpeed();
            void DecreaseSpeed();
            void Breaks();
            void OpenWindow();
            void CloseWindow();
            void AdjustSeat();
            void CleanGlass();
            void ChangeGear();
        }

        public class car : moath
        {
            public void AdjustSeat()
            {
                throw new NotImplementedException();
            }

            public void Breaks()
            {
                throw new NotImplementedException();
            }

            public void ChangeGear()
            {
                throw new NotImplementedException();
            }

            public void CleanGlass()
            {
                throw new NotImplementedException();
            }

            public void CloseDoor()
            {
                throw new NotImplementedException();
            }

            public void CloseWindow()
            {
                throw new NotImplementedException();
            }

            public void DecreaseSpeed()
            {
                throw new NotImplementedException();
            }

            public void Honk()
            {
                throw new NotImplementedException();
            }

            public void IncreaseSpeed()
            {
                throw new NotImplementedException();
            }

            public void OpenDoor()
            {
                throw new NotImplementedException();
            }

            public void OpenWindow()
            {
                throw new NotImplementedException();
            }

            public void StartEngine()
            {
                throw new NotImplementedException();
            }

            public void StopEngine()
            {
                throw new NotImplementedException();
            }
        }

        public  class Employee
        {
          protected  string Name;
            protected string[] DateBirth;
            protected int ID;
            protected int[] births = new int[3];

            
            public Employee(string Name1, string[] DateBirth1 , int ID1)
            {
                Name = Name1;
                DateBirth = DateBirth1;
                ID = ID1;
                births[0] = Convert.ToInt32(DateBirth1[0]);
                births[1] = Convert.ToInt32(DateBirth1[1]);
                births[2] = Convert.ToInt32(DateBirth1[2]);
            }

            public virtual int[] Age()
            {
                int[] myage2= new int[3];
                return myage2;
            }
           

            
        }

        public class manager: Employee
        {
          public  manager (string Name1, string[] DateBirth1, int ID1):base(Name1, DateBirth1, ID1)
            {
                
            }
            int[] realage = new int[3];
           public DateTime dates = DateTime.Today;

            public override int[] Age()
            {
               
                realage[2] = dates.Year - births[2];
                if (births[1] > dates.Month)
                {
                    realage[2] -= 1;
                    realage[1] = (births[1] +12)-dates.Month;
                }
                else
                {
                    realage[1] = -births[1] + dates.Month;
                }

                if (births[0] > dates.Day)
                {
                    realage[1] -= 1;
                    realage[0] = (births[0] + 30 )-dates.Day;
                }
                else
                {
                    realage[0] = -births[0] + dates.Day;
                }
                return realage;
            }


            public void test()
            {
                Console.WriteLine("your name is "+Name);
                Console.WriteLine(DateBirth[0]+"/"+ DateBirth[1]+"/"+ DateBirth[2]);
                Console.WriteLine("your ID is : "+ID);
                Console.WriteLine("you are " + realage[2] + " year " + realage[1] + " month " + realage[0] + " days");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("please inter your name");
            string Mname= Console.ReadLine();

            Console.WriteLine("please inter your date of birth like this '28/3/1999'");
            string[] Mbirth = Console.ReadLine().Split('/');

            Console.WriteLine("please inter you Id");
            int Mid =Convert.ToInt32(Console.ReadLine());

            manager moath = new manager(Mname, Mbirth, Mid);
            moath.Age();
            moath.test();



        }
    }
}
