using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter GPA: ");
            double gpa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter admission test score: ");
            int score = Convert.ToInt32(Console.ReadLine());

            if ((gpa >= 3.0 && score >= 60) || (gpa < 3.0 && score >= 80))
            {
                Console.WriteLine("Accept");
            }
            else
            {
                Console.WriteLine("Decline");
            }
        }
    }
}
