using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    internal class Person
    {
        public string FirstName;
        public string LastNamel;

        private DateTime dateOfBirth;
        private string contactNumber;

        public static int Count = 0;

        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                if (value.Length != 9)
                {
                    Console.WriteLine("Invalid contact");
                }
                else
                {
                    contactNumber = value;
                }         
            }
        }
        /*
        public string ContactNumber { get; set; }       jeżeli nie ma żadnej logiki
        */
        public Person(string firstName, string lastName) 
        {
            Console.WriteLine("Constructor1");
            FirstName = firstName;
            LastNamel = lastName;
            Count++;
        }

        public Person(DateTime dateOgBirth, string firstName, string lastName) : this(firstName, lastName)
        {
            Console.WriteLine("Construdctor2");
            SetDateOfBirth(dateOgBirth);
        }

        public void SetDateOfBirth(DateTime date)
        {
            if (date > DateTime.Now)
            {
                Console.WriteLine("Invalid date of birth");
            }
            else
            {
                 dateOfBirth = date;
            }
        }
        public DateTime GetDateOfBirth() => dateOfBirth;
        /*
        {
            return dateOfBirth;
        }
        */

        public void SayHi()
        {
            Console.WriteLine($"Hi, i'm {this.FirstName}, {GetDateOfBirth()}");
        }
    }
}
