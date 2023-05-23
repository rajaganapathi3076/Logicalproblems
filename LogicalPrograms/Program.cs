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
           
            Console.WriteLine("Welcome to the perfect numbers");
            Console.WriteLine("Please enter the numbers");
            int num = Convert.ToInt32(Console.ReadLine());
            int perfect = 0;

            for (int i = 1; i <= num / 2; i = i + 1) 
            {
                if(num%i == 0)
                {
                    perfect=perfect + i;

                }
                if (num == perfect)
                {
                    Console.WriteLine("This is {0} perfect",num);
                }
                else
                {
                    Console.WriteLine("This not perfect");
                }
            }


            
                
            
            



        }
    }
    
}
