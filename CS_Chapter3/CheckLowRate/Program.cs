using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowRate
{
    class Program
    {
        static void Main(string[] args)
        {
            int pay = Convert.ToInt32(Console.ReadLine());

            if (pay < 5.56)
            {
                Console.WriteLine("ERROR!");
            }
            
            else
            {
                Console.WriteLine("well done.");
            }        
        }
    }
}
