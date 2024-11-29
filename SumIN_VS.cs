using System;

namespace ConsoleFor_Git
{
    internal class Program

    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3 };
           
            int sum = numbers.Sum();
            Console.WriteLine(sum);

        }
    }
}
