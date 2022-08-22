using Inheritance.Domain.Models;
namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hobbies1 = new List<Hobby>()
            {
                new Hobby(0, "Hobby1", "Hobis1"),
                new Hobby(1, "Hobby2", "Hobis2"),
                new Hobby(2, "Hobby3", "Hobis3")
            };

            var hobbies2 = new List<Hobby>()
            {
                new Hobby() { Id = 3, Text = "Hobby4", TextLt = "Hobis4"},
                new Hobby() { Id = 4, Text = "Hobby5", TextLt = "Hobis5"},
                new Hobby() { Id = 5, Text = "Hobby6", TextLt = "Hobis6"}
            };

            var hobbies3 = new List<Hobby>(3);
            hobbies3[0].Id = 6;
            hobbies3[0].Text = "Hobby1";
            hobbies3[0].TextLt = "Hobis1";   
            
            hobbies3[1].Id = 7;
            hobbies3[1].Text = "Hobby2";
            hobbies3[1].TextLt = "Hobis2";
            
            hobbies3[2].Id = 8;
            hobbies3[2].Text = "Hobby3";
            hobbies3[2].TextLt = "Hobis3";

        }

    }
}