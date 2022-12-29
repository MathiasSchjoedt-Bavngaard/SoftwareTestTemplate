using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Boundry
{
    public class NonCoveredClass
    {
        public int Method3(int input)
        {
            Console.WriteLine("MSB made this and input is: " + input);
            Console.WriteLine("Output Should be: " + (input + 3));
            return input + 3;
        }
    }
}
