using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ReverseNumber UC4");
            Console.WriteLine("Please enter the Number to make Reverse ");
           int x = Convert.ToInt32(Console.ReadLine());
           ReverseNumber(x);

        }
        public static int ReverseNumber(int number)
        {
            int remainder = 0, reverse = 0;
            while (number != 0)
            {
                remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            Console.WriteLine(reverse);
            return reverse;
        }
    }
    
}
