using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Domain.Models
{
    public class Student : UniversityPerson
    {
        public Student()
        {
            _random = new Random();
        }
        private Random _random;
        public override Profession Profession
        {
            get => base.Profession;
            set
            {
                if (value.Text.Equals("Lecturer") || value.Text.Equals("Teacher") || value.Text.Equals("Scientist"))
                {
                    base.Profession.Id = 0;
                    base.Profession.Text = "N/A";
                    base.Profession.TextLt = "N/A";
                }
                else
                {
                    base.Profession = value;
                }
            }
        }
        public List<Profession> Courses { get; set; }
        private List<int> _takenCoursesIndexes;

        public void AssignProfessionsRandomly()
        {
            var professions = InitialData.ProfessionInitialData.DataSeed.ToList();


            _takenCoursesIndexes = new List<int>();

            for (int i = 0; i < _random.Next(4); i++)
            {
                var profession = new Profession();

                int randomIndex;

                do
                {
                    randomIndex = _random.Next(professions.Count);
                }
                while (_takenCoursesIndexes.Contains(randomIndex) 
                    || professions[randomIndex].Id == 10
                    || professions[randomIndex].Id == 13
                    || professions[randomIndex].Id == 16);
                {
                    randomIndex = _random.Next(professions.Count);
                }

                _takenCoursesIndexes.Add(randomIndex);
                profession.EncodeCsv(professions[randomIndex].GetCsv());
                professions.RemoveAt(randomIndex);
                Courses.Add(profession);
            }
        }
        public void AssignProfessionsRandomly(Random random)
        {
            _random = random;

            AssignHobbiesRandomly();
        }
        public override string GetCsv()
        {
            return $"{base.GetCsv()},{Profession.Id},{Profession.Text},{Profession.TextLt}" ;
        }
        public List<int> GetCoursesDataSeedIndexes() => _takenCoursesIndexes;
        public string GetBiography()
        {
            var text = Gender == Enums.EGenderType.MALE ? "Studentas" : "Studente";
            text += $" {FullName} kurio profesija yra {Profession.TextLt}";

            if(Hobbies.Count > 0)
            {
                text += $" turi hobius";
                foreach(var hobby in Hobbies)
                {
                    text += $" {hobby.TextLt},";
                }
                text.TrimEnd(',');
            }
            if (Courses.Count > 0)
            {
                text += $" turi hobius";
                foreach (var course in Courses)
                {
                    text += $" {course.TextLt},";
                }
                text.TrimEnd(',');
            }
            return text;
        }
    }
}
//  -parašykite metodą GetBiography() kuris parašys asmens biografiją naturalia kalba
//  "studentas/studentė (parinkti pagal lytį) Vardenis Pavardenis kurio profesija yra ... turi hobius ..., .... ir .... bei lanko .... ir .... kursus"
//  jei studentas neturi hobių, šios sakinio dalies rašyti nereikia.