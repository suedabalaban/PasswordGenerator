using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class PasswordGenerator
    {
        StringBuilder builder = new StringBuilder();
        Random random = new Random();
        char ch;

        public string Password(int length, int upperCase, int lowerCase, int specialChar, int number)
        {
            if (length == upperCase + lowerCase + specialChar + number)
            {
                StringBuilder bd = new StringBuilder();
                bd.Append(LowerString(lowerCase));
                bd.Append(SpecialChar(specialChar));
                bd.Append(UpperString(upperCase));
                bd.Append(RandomNumber(number));
            }
            else
            {
                Console.WriteLine("Length must be equal to the sum of the characters.");
            }
            return builder.ToString();
        }
        public string UpperString(int size)
        {
            for (int i = 0; i < size; i++)
            {
                //returns a random uppercase letter in accordance with ASCII reference.
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString();
        }
        public string LowerString(int size)
        {
            for (int i = 0; i < size; i++)
            {
                //returns a random lowercase letter in accordance with ASCII reference.
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 97)));
                builder.Append(ch);
            }
            return builder.ToString();
        }
        public string SpecialChar(int size)
        {
            for (int i = 0; i < size; i++)
            {
                //returns a random special character in accordance with ASCII reference.
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(14 * random.NextDouble() + 33)));
                builder.Append(ch);
            }
            return builder.ToString();
        }
        public string RandomNumber(int size)
        {
            int num;
            for (int i = 0; i < size; i++)
            {
                //returns a random integer between 0 and 10.
                num = random.Next(0, 10);
                builder.Append(num);
            }
            return builder.ToString();
        }
    }
}

