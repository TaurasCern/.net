using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika_uz7
{
    internal class Mokykla
    {
        public string Name { get; private set; }
        public List<Mokytojas> Teachers { get; set; } = new List<Mokytojas>();
        public Mokykla()
        {

        }
        public Mokykla(string name, List<Mokytojas> teachers)
        {
            Name = name;
            Teachers = teachers;
        }
        public string GetClasses()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var teacher in Teachers)
            {
                sb.Append("Mokytojas: ").Append(teacher.Name).Append(Environment.NewLine);
                foreach(var student in teacher.Students)
                {
                    sb.Append(student.Name).Append(Environment.NewLine);
                }
            }
            return sb.ToString();
        }
        public string GetGrades()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var teacher in Teachers)
            {
                foreach(var student in teacher.Students)
                {
                    sb.Append(student.Name).Append(":").Append(Environment.NewLine);
                    for (int i = 0; i < student.GradesBook.Lesson.Count; i++)
                    {
                        sb.Append(student.GradesBook.Lesson[i].Name).Append(": ").Append(String.Join(", ", student.GradesBook.Grades[i]));
                        sb.Append(Environment.NewLine);
                    }
                    sb.Append(Environment.NewLine);
                }
            }

            return sb.ToString();
        }
        public string GetAverages()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var teacher in Teachers)
            {
                foreach (var student in teacher.Students)
                {
                    sb.Append(student.Name).Append(":").Append(Environment.NewLine);
                    sb.Append(String.Join(Environment.NewLine, student.GradesBook.Averages));
                    sb.Append(Environment.NewLine).Append(Environment.NewLine);
                }
            }
            return sb.ToString();
        }
    }
}
