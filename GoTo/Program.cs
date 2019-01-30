using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTo
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
        label:
            counter++;
            Console.WriteLine("counter = {0}", counter);
            if (counter < 3)
            {
                goto label;
            }
            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
