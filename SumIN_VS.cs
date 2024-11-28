using System;

namespace ConsoleFor_Git
{
    class Human
    {
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine(Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 54;
            int b = 42;
            int sum = a + b;
            Console.WriteLine(sum);

            Human Miki = new Human(Miki);
            Miki.Print();

        }
    }
}
