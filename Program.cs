using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            if (isMale)
            {
                Console.WriteLine("You are Male");
            }
            else
            {
                Console.WriteLine("You are Female");

            }
            bool isTall = true;
            if (isTall && isMale)

            {
                Console.WriteLine("You are both Male and Tall");

            }
            else if (!isTall && isMale)
            {
                Console.WriteLine("You are a Short Male");

            }
            else if (!(isMale && isTall))
            {
                Console.WriteLine("You are neither a Male nor Tall");


            }
            else
            {
                Console.WriteLine("You are a women");

            }

            Console.Read();



               


        












        }
    }
}
