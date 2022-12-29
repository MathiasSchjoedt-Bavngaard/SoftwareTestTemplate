using ClassLibrary.Interfaces;

namespace ClassLibrary.Boundry
{
    public class Class1 : IClass1
    {
        public int Method1(int input)
        {
            Console.WriteLine("MSB made this and input is" + input);
            return input + 1;
        }
    }
}