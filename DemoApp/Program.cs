using System;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Read();
            Console.WriteLine(args[0]);
            Console.WriteLine("=====================");
            Console.WriteLine(args[1]);
            Console.WriteLine("=====================");
            Console.WriteLine("\nGive the URL");
            var url = Console.ReadLine();
            
            
               InitDriver.Init(args[0], args[1]);
            
           
        }
    }
}
