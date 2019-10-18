using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationWeek3
{
    class Program
    {
        static void Main(string[] args)
        {   
            

            Console.WriteLine("Press 1 for registration or 2 for login");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    RegistrerUser();

                case "2":
                    LoginUser();
                    break;


            }

            Console.WriteLine("Email");
            string email = Console.ReadLine();
            Console.WriteLine("Password");
            string password = Console.ReadLine();
            break;

            if (password.Length < 3)
            {
                Console.WriteLine("Password is too short ");
            }

            List<string> names = new List<string>()
             {
                "Hristiana Nedyalkova",
               "Ivan Ivanov",
               "Marina Stoilova",
               "Krasimir Petkov"
             };

             foreach (var name in names)
             {
              Console.WriteLine(name);
             }
             
        }
    }
}
