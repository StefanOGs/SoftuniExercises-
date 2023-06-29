using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Decryptive
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            var nums = new StringBuilder();
            var letters = new StringBuilder();
            var other = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                var curr = text[i];
                if (char.IsDigit(curr))
                {
                    nums.Append(curr);
                }
                else if (char.IsLetter(curr))
                {
                    letters.Append(curr);
                }
                else
                {
                    other.Append(curr);
                }
            }
            Console.WriteLine($"{nums}\n{letters}\n{other}");

        }
    }
}





