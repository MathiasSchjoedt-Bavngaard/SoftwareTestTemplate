using ClassLibrary.Boundry;
using ClassLibrary.Controllers;
using ClassLibrary.Interfaces;

namespace Test.Unit
{
    public class UnitTestExample
    {
        IControllerClass2 _controllerClass2;
        Class1 _class1;


        [SetUp]
        public void Setup()
        {
            _class1 = new Class1();
            _controllerClass2 = new ControllerClass2();
        }

        [Test]
        public void ControllerInClass()
        {
            Assert.That(_class1.Method1(1), Is.EqualTo(2));
        }

        [Test]
        public void ControllerInController()
        {
            Assert.That(_controllerClass2.Method2(1), Is.EqualTo(3));
        }
    }
}