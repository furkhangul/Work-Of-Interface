using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactive
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemUse system = new SystemUse();
            Member member = new Member()
            {
                UserID = 12348526,
                UserFirstName = "Furkan",
                UserLastName = "Gül",
                UserAdress = "Turkey",
                UserNumber = 5418640498,
            };
            Adminstrator administrator = new Adminstrator();

            system.Add(member);
            

            Console.ReadLine();
        }

        interface IUser
        {
            int UserID { get; set; }
            string UserFirstName { get; set; }
            string UserLastName { get; set; }
            string UserAdress { get; set; }
            long UserNumber { get; set;  }

        }

        class Adminstrator : IUser
        {
            public int UserID { get; set; }
            public string UserFirstName { get; set; }
            public string UserLastName { get; set; }
            public string UserAdress { get; set; }
            public long UserNumber { get; set; }
        }

        class Member : IUser
        {
            public int UserID { get; set; }
            public string UserFirstName { get; set; }
            public string UserLastName { get; set; }
            public string UserAdress { get; set; }
            public long UserNumber { get; set; }
        }


        class SystemUse
        {
            public void Add(IUser user)
            {
                Console.WriteLine("User ID: {0}", user.UserID);
                Console.WriteLine("First Name: {0}", user.UserFirstName);
                Console.WriteLine("Last Name: {0}", user.UserLastName);
                Console.WriteLine("Adress: {0}", user.UserAdress);
                Console.WriteLine("Phone Number: {0}", user.UserNumber);

            }

        }


    }
}
