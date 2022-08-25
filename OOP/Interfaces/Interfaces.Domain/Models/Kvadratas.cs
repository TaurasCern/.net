using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Domain.Interfaces;


namespace Interfaces.Domain.Models
{
    public class Kvadratas : Figura, IGeometrija
    {
        public Kvadratas(double krastine) : base(typeof(Kvadratas).Name) 
        { 
            Krastine = krastine; 
        }

        public readonly double Krastine;

        public double Perimetras() => Krastine * 4;

        public double Plotas() => Math.Pow(Krastine, 2);
    }
}
