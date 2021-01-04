using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        // Palindrome means A word, phrase, or sequence that reads the same backward as forward, e.g., madam 
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string to check if it is a palindrome or not: ");
            string input = Console.ReadLine();
            string reverse = string.Empty;
            int length = input.Length - 1;

            while(length >=0)
            {
                reverse = reverse + input[length];
                length--;
            }

            if(input == reverse)
            {
                Console.WriteLine("The entered string is a palindrome");
            }
            else
            {
                Console.WriteLine("The entered string is not a palindrome");
            }
            Console.ReadLine();
        }
    }
}
