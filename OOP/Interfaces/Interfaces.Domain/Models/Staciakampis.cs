using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Domain.Interfaces;
namespace Interfaces.Domain.Models
{
    public class Staciakampis : Figura, IGeometrija
    {
        public Staciakampis(double ilgis, double plotis) : base(typeof(Staciakampis).Name)
        {
            Ilgis = ilgis;
            Plotis = plotis;
        }

        public readonly double Ilgis;
        public readonly double Plotis;

        public double Perimetras() => (Ilgis * 2) + (Plotis * 2);

        public double Plotas() => Ilgis * Plotis;
    }
}
