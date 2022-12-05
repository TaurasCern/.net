using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Domain.Models
{
    public class Disk : ICloneable
    {
        public Disk()
        {

        }
        public Disk(int size, int location)
        {
            Size = size;
            Location = location;
        }

        public int Size { get; set; }
        public int Location { get; set; }
        public object Clone()
        {
            return new Disk
            {
                Size = this.Size,   
                Location = this.Location,   
            };
        }
    }
}
