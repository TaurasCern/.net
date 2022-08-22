using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Domain.Models
{
    public class UniversityPerson : Person
    {
        public UniversityPerson()
        {

        }

        public Profession Profession { get; set; }
        public List<Hobby> Hobbies { get; set; } = new List<Hobby>();
        public void AssignHobbiesRandomly()
        {
            var hobbies = Inheritance.Domain.InitialData.HobbyInitialData.DataSeedCsv.ToList();
            Random random = new Random();

            for (int i = 0; i < random.Next(4); i++)
            {
                var hobby = new Hobby();
                var randomIndex = random.Next(hobbies.Count);

                hobby.EncodeCsv(hobbies[randomIndex]);
                hobbies.RemoveAt(randomIndex);
                Hobbies.Add(hobby);
            }
        }
        public void AssignHobbiesRandomly(Random random)
        {
            var hobbies = Inheritance.Domain.InitialData.HobbyInitialData.DataSeedCsv.ToList();

            for (int i = 0; i < random.Next(4); i++)
            {
                var hobby = new Hobby();
                var randomIndex = random.Next(hobbies.Count);

                hobby.EncodeCsv(hobbies[randomIndex]);
                hobbies.RemoveAt(randomIndex);
                Hobbies.Add(hobby);
            }
        }
        public void PickProfessionRandomly()
        {
            var random = new Random();
            var choice = random.Next(3);

            if(choice == 1)
            {
                var randomProfession = InitialData.ProfessionInitialData.DataSeed[random.Next(InitialData.ProfessionInitialData.DataSeed.Length)];

                Profession = randomProfession;
            }
        
            else if (choice == 2)
            {
                var randomProfession = InitialData.ProfessionInitialData.DataSeedCsvComma[InitialData.ProfessionInitialData.DataSeedCsvComma.Length];

                Profession = new Profession(randomProfession.Split(","));
            }
            else if (choice == 3)
            {
                var randomProfession = InitialData.ProfessionInitialData.DataSeedCsvComma[InitialData.ProfessionInitialData.DataSeedCsvComma.Length];

                Profession = new Profession(randomProfession.Split(";"));
            }
        }
        public void PickProfessionRandomly(Random random)
        {
            var choice = random.Next(3);

            if (choice == 1)
            {
                var randomProfession = InitialData.ProfessionInitialData.DataSeed[random.Next(InitialData.ProfessionInitialData.DataSeed.Length)];

                Profession = randomProfession;
            }

            else if (choice == 2)
            {
                var randomProfession = InitialData.ProfessionInitialData.DataSeedCsvComma[InitialData.ProfessionInitialData.DataSeedCsvComma.Length];

                Profession = new Profession(randomProfession.Split(","));
            }
            else if (choice == 3)
            {
                var randomProfession = InitialData.ProfessionInitialData.DataSeedCsvComma[InitialData.ProfessionInitialData.DataSeedCsvComma.Length];

                Profession = new Profession(randomProfession.Split(";"));
            }
        }
        public string GetCSV()
        {
            var text = new StringBuilder(Profession.GetCsv());

            foreach(var hobby in Hobbies)
            {
                text.Append($",{hobby.GetCsv()}");
            }

            return text.ToString();
        }
    }
}
