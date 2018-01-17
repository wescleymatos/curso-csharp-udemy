using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = "hello World!";

            Console.WriteLine(output.FirstToUpper());
            Console.ReadKey();
        }
    }
}
