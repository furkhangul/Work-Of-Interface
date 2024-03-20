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
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                ID = 148651231,
                FirstName = "Furkan",
                LastName = "Gül",
                Adress = "Türkiye"
            };
            manager.Add(customer);
            Student student = new Student
            {
                ID = 148651231,
                FirstName = "Furkan",
                LastName = "Gül",
                Departmant = "Software Engeenering"

            };
            manager.Add(student);
            Console.ReadLine();
        }
        interface Iperson
        {
            int ID { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }

            

        }

        private class Customer : Iperson
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Adress { get; set; }
        }
        class Student : Iperson
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }
        }

        class PersonManager
        {
            public void Add(Iperson person)
            {
                Console.WriteLine("ID : {0}", person.ID);
                Console.WriteLine("First Name : {0}", person.FirstName);
                Console.WriteLine("Last Name : {0}", person.LastName);

            }
        }
    }
}
