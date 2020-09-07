using System;

namespace Lucktext
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string age;
            string color;

            Console.WriteLine("Hej, vad heter du?");

            name = Console.ReadLine();

            Console.WriteLine(name + " Hur gammal är du?");

            age = Console.ReadLine();

            Console.WriteLine(name + " vad är din favorit färg?");

            color = Console.ReadLine();

            Console.WriteLine("Du heter " + name + " och är " + age + " och din favoritfärg är " + color);

            Console.ReadLine();









        }
    }
}
