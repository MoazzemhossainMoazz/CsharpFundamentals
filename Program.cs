using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFundamentals
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("My Name is " + firstName + " " + lastName);
            Console.ReadLine();
        }
        class Program
        {
            static void Main(string[] args)
            {
                Person male = new Person();

                male.firstName = "John";
                male.lastName = "Doe";

                male.Introduce();
            }
        }
    }
}