using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 A:
    get a seven digit number and make that it will print
    the hundreds, hundred thousand, ten thousand and so on of the number using / & %
    operation.
 B: 

*/
namespace SeptemberPracticeThree
{
    internal class ExcersizeOne : Excersize
    {
        public override void ExcersizeCode()
        {
            Console.Write("Enter a seven digit number: ");
            int sevenDigit = int.Parse(Console.ReadLine());
        }
    }
}
