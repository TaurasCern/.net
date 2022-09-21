using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Domain
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        public int Amount { get; set; }

        public int ShoeSizeId { get; set; }
        public virtual ShoeSize ShoeSize { get; set; }

        [NotMapped]
        public virtual decimal SpentAmount => ShoeSize.Shoe.Price * Amount;
    }
}
