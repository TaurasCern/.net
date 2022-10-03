using MusicEShop.Domain.Interfaces;
using MusicEShop.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicEShop.Domain.Interfaces;

namespace MusicEShop.Infrastructure.Database
{
    public class MusicEShopRepository : IMusicEShopRepository
    {
        private chinookContext _context;
        public MusicEShopRepository(chinookContext context)
        {
            _context = context;
        }
        public IEnumerable<Customer> GetAllCustomers() => _context.Customers;
        public IEnumerable<Track> GetAllTracks() => _context.Tracks;
        public void CreateCustomer(Customer customer)
        {
            _context.Customers.Add(customer);

            _context.SaveChanges();
        }
        public void UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);

            _context.SaveChanges();
        }
        public long CreateInvoice(Invoice invoice)
        {
            invoice.InvoiceDate = DateTime.Now;

            var addedInvoice = _context.Invoices.Add(invoice);

            _context.SaveChanges();

            return addedInvoice.Entity.InvoiceId;
        }

        public void UpdateTrack(Track track)
        {
            _context.Update(track);

            _context.SaveChanges();
        }
    }
}
