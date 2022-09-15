using Intro.Domain.Models;
using Intro.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Infrastructure.Database
{
    public class BloggingRepository : IBloggingRepository
    {
        public BloggingRepository()
        {
            using var context = new BloggingContext();
            context.Database.EnsureCreated();
        }

        public void AddAnimal(Animal animal)
        {
            using var context = new BloggingContext();

            context.Animals.Add(animal);
            context.SaveChanges();
        }

        public void AddAnimal(string name, string type, DateTime birthDate)
        {
            using var context = new BloggingContext();

            var animal = new Animal()
            {
                Name = name,
                Type = type,
                BirthDate = birthDate
            };
            context.Animals.Add(animal);
            context.SaveChanges();
        }

        public void AddPerson(Person person)
        {
            using var context = new BloggingContext();

            context.People.Add(person);
            context.SaveChanges();
        }

        public void AddPerson(string firstName, string lastName, DateTime birthDate, double height, string biography)
        {
            using var context = new BloggingContext();

            var person = new Person()
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate,
                Height = height,
                Biography = biography
            };
            context.People.Add(person);
            context.SaveChanges();
        }

        public void PrintPeople()
        {
            using var context = new BloggingContext();

            var people = context.People;

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Id},{person.FirstName}");
            }
        }
        public void PrintAnimals()
        {
            using var context = new BloggingContext();

            var animals = context.Animals;

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Name},{animal.Type},{animal.BirthDate}");
            }
        }
        public void PrintAnimalsSorted(string type)
        {
            using var context = new BloggingContext();

            var animals = context.Animals
                .Where(a => a.Type == type)
                .OrderBy(a => a.Name);

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Id},{animal.Name},{animal.BirthDate}");
            }
        }



        public void PrintPeopleSorted()
        {
            using var context = new BloggingContext();

            var people = context.People.OrderBy(p => p.FirstName);

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Id},{person.FirstName}");
            }
        }
    }
}
