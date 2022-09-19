using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeptemberPracticeThree
{
    internal class Excersize
    {
        public Excersize()
        {
            ExcersizeCode();
        }

        public virtual void ExcersizeCode() {
            Console.WriteLine("User didn't enter code");
        }

        public static void PrintTitle(string title)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}
