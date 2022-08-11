using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika_uz7
{
    internal class PazymiuKnygele
    {
        public List<Pamoka> Lesson { get; private set; }
        public List<List<int>> Grades { get; private set; }
        public List<string> Averages
        { 
            get 
            {
                int i = 0;
                var averages = new List<string>();
                foreach(var grades in Grades)
                {
                    double sum = 0;
                    foreach(var grade in grades)
                    {
                        sum += grade;
                    }
                    var ans = sum / grades.Count;
                    averages.Add(String.Format("{0}: {1:#.##}", Lesson[i].Name, ans));
                    i++;
                }
                return averages;
            } 
        }
        public PazymiuKnygele()
        {

        }
        public PazymiuKnygele(List<Pamoka> lessons, List<List<int>> grades)
        {
            Lesson = lessons;
            Grades = grades;
        }
    }
}
