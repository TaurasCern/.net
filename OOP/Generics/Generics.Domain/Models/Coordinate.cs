using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Coordinate<T> : ICordinate
    {
        public Coordinate()
        {

        }
        public Coordinate(T x, T y)
        {
            X = x;
            Y = y;
        }
        public T X { get; set; }
        public T Y { get; set; }

        public string GetCoordinate() => $"{X};{Y}";

        public void ResetCoordinate()
        {
            X = default(T);
            Y = default(T);
        }
    }
}
