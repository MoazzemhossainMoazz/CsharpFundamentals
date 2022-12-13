using CsharpFundamentals.Math;
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
                var male = new Person();

                male.firstName = "John";
                male.lastName = "Doe";

                male.Introduce();

                var result = Calculator.Add(13, 27);
                Console.WriteLine(result);
            }
        }
    }
}