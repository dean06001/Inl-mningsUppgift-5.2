using System;
namespace InlämningsUppgift_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tal = new string[3];
            tal[0] = "5";
            tal[1] = "13";
            Console.WriteLine($"Skriv in ett tal förutom {tal[0]} och {tal[1]}");
            tal[2] = Console.ReadLine();

            Console.WriteLine("Här är de tre talen");
            Console.WriteLine($"{tal[0]}, {tal[1]} och {tal[2]}");
            Console.ReadKey();
        }
    }
}