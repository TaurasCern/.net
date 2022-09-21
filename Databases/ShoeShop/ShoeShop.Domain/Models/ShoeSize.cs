using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Domain
{
    public class ShoeSize
    {
        [Key]
        public int Id { get; set; }
        public int Size { get; set; }
        public int Amount { get; set; }


        public int ShoeId { get; set; }
        public virtual Shoe Shoe { get; set; }
    }
}
