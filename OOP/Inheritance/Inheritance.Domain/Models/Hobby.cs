using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Domain.Models
{
    public class Hobby
    {
        public Hobby()
        {

        }

        public Hobby(int id, string text, string textLt)
        {
            Id = id;
            Text = text;
            TextLt = textLt;
        }

        public int Id { get; set; }
        public string Text { get; set; }
        public string TextLt { get; set; }

        public void EncodeCsv(string line)
        {
            int validCount = 3;

            var parts = line.Split(",");

            if(parts.Length != validCount) { return; }
            if (!int.TryParse(parts[0], out int id)) { return; }

            Id = id;
            Text = parts[1];
            TextLt = parts[2];
        }
        public override bool Equals(object? obj)
        {
            if(obj == null || obj is not Hobby) { return false; }

            var hobby = obj as Hobby;

            return Id == hobby.Id
                || Text.Equals(hobby.Text) 
                || TextLt.Equals(hobby.TextLt); 
        }
        public string GetCsv() => String.Join(",", Id, Text, TextLt);
    }
}
