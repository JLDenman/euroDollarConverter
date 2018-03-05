using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace euroDollarConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dollar<->euro converter !!!");
            Console.WriteLine("=========================================");

            while (true)
            {
                Console.WriteLine("What would you like to convert? Type 'd' for dollar or 'e' for euro. ");
                char conversion = Convert.ToChar(Console.ReadLine());

                if (conversion == 'd')
                {
                    Console.WriteLine("How many dollars would you like to convert to euros?");
                    decimal dollars = Convert.ToDecimal(Console.ReadLine());
                    decimal result;
                    result = dollars * (decimal)0.81;
          
                    Console.WriteLine("According to my exchange rate, you will be getting {0} euros!", result);

                }
                else if (conversion == 'e')
                {
                    Console.WriteLine("How many euros would you like to convert to dollars?");
                    decimal euros = Convert.ToDecimal(Console.ReadLine());
                    decimal result;
                    result = euros * (decimal)1.23;

                    Console.WriteLine("According to my exchange rate, you will be getting {0:C}!", result);

                }
                else
                {
                    Console.WriteLine("Please type in one of the above mentioned characters. ");
                }



            }
            
            
        }

    }
}
