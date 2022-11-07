using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.Title = "Practice";

        Console.WriteLine("Hello What's your name?");
        var Name = Console.ReadLine();

        Console.WriteLine($"Hello {Name}");
        
        Console.ReadKey();  
    }
  }
}