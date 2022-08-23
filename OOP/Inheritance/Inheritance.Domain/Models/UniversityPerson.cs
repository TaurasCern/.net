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
            _random = new Random();
        }

        public virtual Profession Profession { get; set; }
        public List<Hobby> Hobbies { get; set; } = new List<Hobby>();
        private Random _random;
        public void AssignHobbiesRandomly()
        {
            var hobbies = Inheritance.Domain.InitialData.HobbyInitialData.DataSeedCsv.ToList();
            List<int> indexesTaken = new List<int>();

            for (int i = 0; i < _random.Next(4); i++)
            {
                var hobby = new Hobby();

                int randomIndex;

                do
                {
                    randomIndex = _random.Next(hobbies.Count);
                }
                while (indexesTaken.Contains(randomIndex));
                {
                    randomIndex = _random.Next(hobbies.Count);
                }

                indexesTaken.Add(randomIndex);

                hobby.EncodeCsv(hobbies[randomIndex]);

                hobbies.RemoveAt(randomIndex);

                Hobbies.Add(hobby);
            }
        }
        public void AssignHobbiesRandomly(Random random)
        {
            _random = random;

            AssignHobbiesRandomly();
        }
        public void PickProfessionRandomly()
        {
            var choice = _random.Next(3);

            if(choice == 0)
            {
                SetProfession(InitialData.ProfessionInitialData
                    .DataSeed[_random.Next(InitialData.ProfessionInitialData.DataSeed.Length)]);
            }     
            else if (choice == 1)
            {
                SetProfession(InitialData.ProfessionInitialData
                    .DataSeedCsvComma[_random.Next(InitialData.ProfessionInitialData.DataSeedCsvComma.Length)].Split(","));
            }
            else if (choice == 2)
            {
                SetProfession(InitialData.ProfessionInitialData
                    .DataSeedCsvSemicolon[_random.Next(InitialData.ProfessionInitialData.DataSeedCsvComma.Length)].Split(";"));
            }
        }
        public void SetProfession(string[] data)
        {
            Profession.Id = Convert.ToInt32(data[0]);
            Profession.Text = data[1];
            Profession.TextLt = data[2];

        }
        public void SetProfession(Profession profession)
        {
            Profession.Id = profession.Id;
            Profession.Text = profession.Text;
            Profession.TextLt = profession.TextLt;

        }
        public virtual string GetCsv()
        {
            StringBuilder sb = new StringBuilder(String.Join(",", GetPersonCsv(), Profession.GetCsv()));

            foreach(var hobby in Hobbies)
            {
                sb.Append(",").Append(hobby.GetCsv());
            }

            return sb.ToString();
        }
    }
}
