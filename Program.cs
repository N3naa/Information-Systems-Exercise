// See https://aka.ms/new-console-template for more information

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void Function() 
        {
            Console.WriteLine("This is the first exercise!");        
        }

        public int Addition(int x, int y)
        {
            return x + y;
        }

        public void Goodbye() 
        {
            Console.WriteLine("Can't wait to got home!");
        }
    }
}
