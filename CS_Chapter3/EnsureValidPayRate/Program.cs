using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter pay: ");

            int pay = Convert.ToInt32(Console.ReadLine());

            if (pay < 5.65 || pay > 49.99)
            {

                // Have user input pay again
                Console.Write("Enter pay: ");
                Console.ReadLine();
            }
            if (pay < 5.65 || pay > 49.99)
            {
                // Display error
                Console.Write("ERROR!");
            }

            else
            {

                // Display success message
                Console.Write("SUCCESS");
            }
        }
    }
}
