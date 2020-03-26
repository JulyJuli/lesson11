namespace ConsoleApp3
{
    public class Cat
    {
        private ITestInterface _test;

        public Cat(ITestInterface test)
        {
            _test = test;
        }

        public void Can()
        {
            _test.Print();
        }
    }
}