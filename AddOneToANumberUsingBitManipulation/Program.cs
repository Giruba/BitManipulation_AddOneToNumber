using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOneToANumberUsingBitManipulation
{
    class Program
    {

        public static int getNumberPlusOne(int number) {
            /* It is known that 'Negation of a negative number is positive'
             * Two's complement of a number is formed by flipping all bits{1's complement)
             * and adding 1. 
             * Therefore applying minus to a 2's complement number yields the number+1
             */ 
            return (-(~number));
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the number whose next number(+1) is to be found using Bit Manipulation:");
            bool canParse = int.TryParse(Console.ReadLine(), out number);
            Console.WriteLine("The output after adding one to "+number+" using Bit manipulation is " +
                getNumberPlusOne(number));
            Console.ReadKey();
        }
    }
}
