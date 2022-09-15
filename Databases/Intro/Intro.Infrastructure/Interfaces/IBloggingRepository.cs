using Intro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Infrastructure.Interfaces
{
    public interface IBloggingRepository
    {
        public void AddPerson(Person person);
        public void AddPerson(string firstName, string lastName, DateTime birthDate, double height, string biography);
        public void AddAnimal(Animal animal);
        public void AddAnimal(string name, string type, DateTime birthDate);
        public void PrintPeople();
        public void PrintPeopleSorted();
        public void PrintAnimals();
        public void PrintAnimalsSorted();
        public List<Animal> FetchAnimalsByType(string type);
    }
}
