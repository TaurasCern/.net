using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicEShop.Domain.Models
{
    public partial class Invoice
    {
        public Invoice()
        {
            InvoiceItems = new HashSet<InvoiceItem>();
        }
        public Invoice(List<InvoiceItem> invoiceItems, Customer customer)
        {
            //InvoiceItems = invoiceItems;
            //Customer = customer;
            InvoiceItems = new HashSet<InvoiceItem>();
            Total = invoiceItems.Sum(i => i.UnitPrice);
            CustomerId = customer.CustomerId;
        }
        [Key]
        public long InvoiceId { get; set; }
        public long CustomerId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string? BillingAddress { get; set; }
        public string? BillingCity { get; set; }
        public string? BillingState { get; set; }
        public string? BillingCountry { get; set; }
        public string? BillingPostalCode { get; set; }
        public double Total { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }

        public void InvoiceItemAddRange(List<InvoiceItem> items)
        {
            foreach (var item in items)
            {
                InvoiceItems.Add(item);
                Total += item.UnitPrice;
            }
        }
        public override string ToString() => $"{InvoiceId}. Suma: {Total}, Pirkimo data: {InvoiceDate.ToShortDateString()}";
    }
}
