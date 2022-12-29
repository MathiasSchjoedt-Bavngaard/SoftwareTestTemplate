using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;


namespace ClassLibrary.Controllers
{
    public class ControllerClass2 : IControllerClass2
    {
        public int Method2(int input)
        {
            Console.WriteLine("MSB made this and input is: " + input);
            Console.WriteLine("Output Should be: " + (input + 2));
            return input + 2;
        }
    }
}
