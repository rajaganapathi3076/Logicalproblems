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
        static int FibonaciSeries(int n)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;
             
            if (n == 0)
            
                return 0;
            
            if (n == 1)
            
                return  1;
            return FibonaciSeries ( n-1) +FibonaciSeries(n-2);
        }   
        static void Main(string[] args)
        {
            Console.WriteLine("Pleas enter the Length of the fibonocciseries");
            int length=Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < length; i++)
            {
                Console.Write("  {0} ",FibonaciSeries (i));
            } 
            Console.ReadKey();
                       

        }
    }
    
}
