using Interfaces.Domain.Interfaces;
namespace Interfaces.Domain.Models
{
    public class Skaicius : IMatematika
    {
        public Skaicius(int number)
        {
            Number = number;
        }
        public readonly int Number;

        public int Atimti(int number) => Number - number;
        public int Prideti(int number) => Number + number;
        public int Padauginti(int number) => Number * number;
        public double Padalinti(int number) => Number / number;
        public int PakeltiKvadratu() => Number * Number;
        public int PakeltiKubu() => Number * Number * Number;
    }
}