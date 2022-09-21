using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Domain
{
    public class Shoe
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<ShoeSize> Sizes { get; set; } = new HashSet<ShoeSize>();
    }
}
