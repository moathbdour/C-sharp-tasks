using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_27_11
{
    internal class PersonalInfo
    {
        private  int age ;
        private int id;
        private string name ;
        private string gender ;
        private string Email ;
        private string phone ;

        public PersonalInfo(int age1, int id1, string name1, string gender1, string Email1, string phone1)
        {

            age = age1;
            id = id1;
            name = name1;
            gender = gender1;
            Email = Email1;
            phone = phone1;

            checker();
        }

        public String[] checker()
        {
            if(age >60 || age < 18)
            {
                Console.WriteLine("Please inter age between 18 and 60");
                 age = Convert.ToInt32(Console.ReadLine());
                return checker() ;
            }
            else if (phone.Length<3 ||  (phone.Substring(0, 3)!= "077" && phone.Substring(0, 3) != "079" && phone.Substring(0, 3) != "078"))
            {
                Console.WriteLine("Please inter valid number");
                phone = Console.ReadLine();
                return checker();

            }

            else
            {
                return printer();
            }
        }
        public string[] printer()
        {
            string[] result = new string[6];
            result[0] = Convert.ToString(age);
            result[1]= Convert.ToString(id);
            result[2]= name;
            result[3]= gender;
            result[4]=Email; result[5]=phone;
            return result;

        }


     
       
    }
}
