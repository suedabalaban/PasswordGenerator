using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            PasswordGenerator generator = new PasswordGenerator();

            Console.WriteLine("-----Password Generator-----");

            //User input to determine the features of password.

            Console.Write("Determine the length of the password: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Determine how many uppercase letter to be created: ");
            int upperCase = Convert.ToInt32(Console.ReadLine());

            Console.Write("Determine how many lowercase letter to be created: ");
            int lowerCase = Convert.ToInt32(Console.ReadLine());

            Console.Write("Determine how many special character to be created: ");
            int specialChar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Determine how many number to be created: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Random Password is : {0} ", generator.Password(length, upperCase, lowerCase, specialChar, number));

            Console.ReadLine();
        }
    }

}


