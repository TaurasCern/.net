using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicEShop.Domain.Models
{
    public partial class InvoiceItem
    {
        public InvoiceItem()
        {

        }
        public InvoiceItem(Track track)
        {
            TrackId = track.TrackId;
            UnitPrice = track.UnitPrice;
            Quantity = 1;
        }
        [Key]
        public long InvoiceLineId { get; set; }
        public long InvoiceId { get; set; }
        public long TrackId { get; set; }
        public double UnitPrice { get; set; }
        public long Quantity { get; set; }

        public virtual Invoice Invoice { get; set; } = null!;
        public virtual Track Track { get; set; } = null!;

        public override string ToString() => $"{TrackId}. Kaina: {UnitPrice * Quantity}";
    }
}
