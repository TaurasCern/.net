using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Domain.Interfaces;

namespace Interfaces.Domain.Models
{
    public class StatusisTrikampis : Figura, IGeometrija
    {
        public StatusisTrikampis(double ilgis, double plotis) : base(typeof(StatusisTrikampis).Name)
        {
            Ilgis = ilgis;
            Plotis = plotis;
        }

        public readonly double Ilgis;
        public readonly double Plotis;
        public double Perimetras() => Ilgis + Plotis + Math.Sqrt(Math.Pow(Ilgis,2) + Math.Pow(Plotis, 2));

        public double Plotas() => Ilgis * Plotis / 2; 
    }
}
