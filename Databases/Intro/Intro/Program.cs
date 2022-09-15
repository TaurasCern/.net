using Intro.Infrastructure.Interfaces;
using Intro.Infrastructure.Database;

namespace Intro
{
    internal class Program
    {
        private static IBloggingRepository _bloggingRepository = new BloggingRepository();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"\n1.Add new user" +
                                  $"\n2.Display all users" +
                                  $"\n3.Display all users sorted by name" +
                                  $"\n4.Add new animal" +
                                  $"\n5.Print animal by type (sorted by name)" +
                                  $"\nq.Quit");

                char selection = Console.ReadKey().KeyChar;

                switch (selection)
                {
                    case '1':
                        Console.WriteLine($"\nNew user is being added. Please fill in data:");
                        Console.WriteLine($"\nName:");
                        string firstName = Console.ReadLine();
                        Console.WriteLine($"\nLast name:");
                        string lastName = Console.ReadLine();
                        Console.WriteLine($"\nAge: (Example: 2000/01/01)");
                        DateTime birthDate = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine($"\nHeight:)");
                        double height = double.Parse(Console.ReadLine());
                        Console.WriteLine($"\nBiography:)");
                        string biography = Console.ReadLine();
                        _bloggingRepository.AddPerson(firstName, lastName, birthDate, height, biography);

                        break;
                    case '2':
                        _bloggingRepository.PrintPeople();
                        break;
                    case '3':
                        _bloggingRepository.PrintPeopleSorted();
                        break;
                    case '4':
                        Console.WriteLine($"\nNew animal is being added. Please fill in data:");
                        Console.WriteLine($"\nName:");
                        string name = Console.ReadLine();
                        Console.WriteLine($"\nType:");
                        string type = Console.ReadLine();
                        Console.WriteLine($"\nAge: (Example: 2000/01/01)");
                        DateTime animalBirthDate = DateTime.Parse(Console.ReadLine());
                        _bloggingRepository.AddAnimal(name, type, animalBirthDate);
                        break;                      
                    case '5':
                        Console.WriteLine($"\nPrint type:");
                        string typeToFind = Console.ReadLine();
                        _bloggingRepository.PrintAnimalsSorted(typeToFind);
                        break;
                    case 'q':
                        return;
                    default:
                        Console.WriteLine("Input incorrect. Please try again.");
                        break;
                }
            }

            //_bloggingRepository.AddAnimal("Hermis", "German shepard", new DateTime(2015, 07, 05));
        }
    }
}