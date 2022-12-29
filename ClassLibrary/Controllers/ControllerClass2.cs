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
            Console.WriteLine("MSB made this and input is" + input);
            return input + 2;
        }
    }
}
