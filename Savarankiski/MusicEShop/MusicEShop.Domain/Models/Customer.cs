using System;
using System.Collections.Generic;

namespace MusicEShop.Domain.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Invoices = new HashSet<Invoice>();
        }
        public Customer(string firstName, string lastName, string email)
        {
            Invoices = new HashSet<Invoice>();

            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public long CustomerId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Company { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? PostalCode { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string Email { get; set; } = null!;
        public long? SupportRepId { get; set; }

        public virtual Employee? SupportRep { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }

        public override string ToString() => $"{CustomerId}. {FirstName} {LastName}";
    }
}
