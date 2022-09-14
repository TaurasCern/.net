using Intro.Infrastructure.Interfaces;
using Intro.Infrastructure.Database;

namespace Intro
{
    internal class Program
    {
        private static IBloggingRepository _bloggingRepository = new BloggingRepository();
        static void Main(string[] args)
        {
            // 1. install-package Microsoft.EntityFrameworkCore.Sqlite;
            // 2. install-package Microsoft.EntityFrameworkCore.Proxies;
            // 3. install-package Microsoft.EntityFrameworkCore.Tools;


            //_bloggingRepository.AddPerson("Petras", "Petrauskas", new DateTime(2000,1,1), 190);
            //_bloggingRepository.PrintPeople();
            //_bloggingRepository.PrintPeopleSorted();

            _bloggingRepository.AddAnimal("Hermis", "German shepard", new DateTime(2015, 07, 05));
        }
    }
}