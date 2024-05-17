using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_sheet_7_Question_01
{
    internal class Program
    {
        abstract class Animal
        {
            public string Name;
            public abstract void MakeSound();
        }

        class Lion : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine($"{Name} the Lion roars: Roarrr!");
            }
        }
        class Tiger : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine($"{Name} the Tiger growls: Grrrr!");
            }
        }

        class Elephant : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine($"{Name} the Elephant trumpets: Pwaaa!");
            }
        }
        static void Main(string[] args)
        {
            List<Animal> zoo = new List<Animal>();
            string input;

            while (true)
            {
                Console.WriteLine("Welcome to the Zoo Management System!");
                Console.WriteLine("1. Add Lion");
                Console.WriteLine("2. Add Tiger");
                Console.WriteLine("3. Add Elephant");
                Console.WriteLine("4. List all animals and make sounds");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                input = Console.ReadLine();

                if (input == "5") break;

                try
                {
                    switch (input)
                    {
                        case "1":
                            zoo.Add(CreateAnimal<Lion>("Lion"));
                            break;
                        case "2":
                            zoo.Add(CreateAnimal<Tiger>("Tiger"));
                            break;
                        case "3":
                            zoo.Add(CreateAnimal<Elephant>("Elephant"));
                            break;
                        case "4":
                            MakeAllAnimalsSound(zoo);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine();
            }
        }

        static T CreateAnimal<T>(string type) where T : Animal, new()
        {
            Console.Write($"Enter the name of the {type}: ");
            string name = Console.ReadLine();
            return new T { Name = name };
        }

        static void MakeAllAnimalsSound(List<Animal> zoo)
        {
            if (zoo.Count == 0)
            {
                Console.WriteLine("The zoo is empty.");
                return;
            }

            foreach (var animal in zoo)
            {
                animal.MakeSound();
            }
        }
    }
}
