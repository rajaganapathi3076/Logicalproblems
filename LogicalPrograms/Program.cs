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
            Console.WriteLine("Welcome to the prime numbers");
            Console.WriteLine("PLease enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for(int i=1; i<= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }

            }
            
           
            
            if (a == 2) 
            {
                Console.WriteLine("This is {0} prime number ", n);
            }
            else
            {
                Console.WriteLine("This is not prime");
            }
            Console.ReadLine();



        }
    }
    
}
