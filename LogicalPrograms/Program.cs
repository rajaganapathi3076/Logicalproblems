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
            Console.WriteLine("Welcome to CouponNumbers UC5");
            string couponNumber= GenerateCouponNumber();
            Console.WriteLine("Coupon number :  "+couponNumber);

        }
        static string GenerateCouponNumber()
        {
            string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int length = 12;
            Random random = new Random();
            string couponNumber = " ";

            for(int i=0; i< length; i++)
            {
                int randomIndex=random.Next(0,allowedChars.Length);
                couponNumber += allowedChars[randomIndex];
            }
            return couponNumber;
        }
    }
    
}
