using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces.Domain.Interfaces;

namespace Interfaces.Domain.Models
{
    public class Apskritimas : Figura, IGeometrija
    {
        public Apskritimas(double spindulys) : base(typeof(Apskritimas).Name) 
        { 
            Spindulys = spindulys;
        }

        public readonly double Spindulys;
        public readonly double Skersmuo;
        public double Perimetras() => Math.PI * Spindulys * 2;
        public double Plotas() => Math.PI * Math.Pow(Spindulys, 2);
    }
}
