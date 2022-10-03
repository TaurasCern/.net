using MusicEShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicEShop.Domain.Interfaces
{
    public interface IMusicEShopRepository
    {
        public IEnumerable<Customer> GetAllCustomers();
        public IEnumerable<Track> GetAllTracks();
        public void CreateCustomer(Customer customer);
        public void UpdateCustomer(Customer customer);
        public long CreateInvoice(Invoice invoice);
        public void UpdateTrack(Track track);
    }
}
