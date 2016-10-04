using System;

namespace HelloWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Tuscias stringas");
                return;
            }


            Console.WriteLine(string.Format("Hello {0}", args[0]));

            Console.ReadLine();
        }
    }
}
