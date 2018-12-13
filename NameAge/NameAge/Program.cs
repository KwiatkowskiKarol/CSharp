using System;

namespace name_age
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Greetings();
                Age();
                Console.ReadKey();
            }
        }
        private static void Age()
        {
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);
            if (age >= 18)
            {
                Console.Write("You are " + age + " years old, ");
                Console.Write("you can drink beer");
            }
            else if (result == false)
            {
                Console.WriteLine("You entered an incorrect age");
            }
            else
            {
                Console.Write("You are " + age + " years old, ");
                Console.Write("you can drink water or milk");
            }
        }
        private static void Greetings()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "! :)");
            Console.WriteLine("Enter your age: ");
        }


    }
}
