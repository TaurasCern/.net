using MusicEShop.Domain.DTOs;
using MusicEShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicEShop.Domain.Interfaces;

namespace MusicEShop.Domain.Services
{
    public class ShopUI : IShopUI
    {
        private IMenuStateHandler _menuService;
        public ShopUI(IMenuStateHandler menuService)
        {
            _menuService = menuService;
        }

        public void PrintMenu<T>(T variable, Customer customer, Invoice cart)
        {
            switch (_menuService.GetMenuState()) 
            {
                case "Not logged in": Console.Clear(); Console.WriteLine(MenuTextData.LoginMenuText); break;
                case "Customer menu": PrintCustomerMenu(variable as IEnumerable<Customer>); break;
                    case string s when s.Equals("Print tracks") || s.Contains("Sort:") || s.Contains("Search:"): 
                        PrintTracks(variable as IEnumerable<Track>);
                        Console.WriteLine("o - rikiuoti, s - ieskoti, q - atgal"); break;

                    case "Add to cart": PrintSearchResult(variable as IEnumerable<Track>); break;
                    case "Check cart": PrintCart(cart); break;
                        case "Checked out": PrintInvoice(customer, cart); break;
                    
                        case "Sort": Console.Clear(); Console.WriteLine(MenuTextData.SortChoiceText); break;
                        case "Search": Console.Clear(); Console.WriteLine(MenuTextData.SearchChoiceText); break;
                    case "Invoice history": PrintInvoiceHistory(customer); break;

                case "Employee login": Console.Clear(); Console.WriteLine("Iveskite pin koda:"); ; break;
                     case "Employee menu": Console.Clear(); Console.WriteLine(MenuTextData.EmployeeChoiceText); break;
                case "Add customer": Console.Clear(); break;

                case "Print customers": PrintCustomers(variable as IEnumerable<Customer>); break;
                case string s when s.Equals("Update customer") && _menuService.IsChoice == false: Console.Clear(); PrintCustomers(variable as IEnumerable<Customer>); break;
                case string s when s.Equals("Update customer") && _menuService.IsChoice == true: Console.Clear(); Console.WriteLine(MenuTextData.UpdateCustomerChoice); break;
                case "Change tracks status menu": Console.Clear(); Console.WriteLine("1. Gauti dainu sarasa\n2. Keisti dainos statusa"); break;
                     case "Print all tracks": Console.Clear(); PrintTracks(variable as IEnumerable<Track>);
                            Console.WriteLine("q - atgal"); break;
                case "Get track": Console.Clear(); PrintTrackStatus(variable as IEnumerable<Track>); break;

            }
        }
        private string IfNull(string text) => text == null ? "" : text;
        private void PrintInvoice(Customer customer, Invoice invoice)
        {
            Console.Clear();
            Console.WriteLine($"Vardas: {customer.FirstName} {customer.LastName}\nAdresas: {IfNull(customer.City)}, {IfNull(customer.Address)}, {IfNull(customer.PostalCode)}\nTelefono numeris: {IfNull(customer.Phone)}\nElektroninis pastas: {customer.Email}");
            foreach (var item in invoice.InvoiceItems)
            {
                Console.WriteLine(item.Track.ToString());
            }
            Console.WriteLine($"Suma be pvm: {invoice.Total * 0.79}");
            Console.WriteLine($"PVM: 21%");
            Console.WriteLine($"Sumas su pvm: {invoice.Total}");
            Console.WriteLine("q - atgal");
        }
        private void PrintTrackStatus(IEnumerable<Track> tracks)
        {
            if(tracks is null) { return; }

            foreach (var track in tracks)
            {
                Console.WriteLine($"{track.TrackId}. Status: {track.Status}");
            }
            Console.WriteLine("y - keisti bukle, q - atgal");
        }

        private void PrintCart(Invoice invoice)
        {
            Console.Clear();
            if (invoice.InvoiceItems == null && invoice.InvoiceItems.Count() == 0) 
            {
                Console.WriteLine("Krepselis tuscias.");
                Console.WriteLine("q - atgal");
                return;
            }

            foreach (var item in invoice.InvoiceItems)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine($"Is viso: {invoice.InvoiceItems.Sum(i => i.UnitPrice)}");
            Console.WriteLine("y - pirkti, q - atgal");
        }

        private void PrintSearchResult(IEnumerable<Track> tracks)
        {
            Console.Clear();
            if (_menuService.IsChoice == true)
            {
                Console.WriteLine(MenuTextData.CartSearchChoiceText);
            }
            else 
            {
                if (tracks == null) return;
                foreach (var track in tracks) Console.WriteLine(track.ToString());
                Console.WriteLine("y - ideti i krepseli, q - atgal");
                _menuService.IsChoice = true;
            }
        }

        private void PrintInvoiceHistory(Customer customer)
        {
            Console.Clear();
            Console.WriteLine($"Vardas: {customer.FirstName} {customer.LastName}\nAdresas: {IfNull(customer.City)}, {IfNull(customer.Address)}, {IfNull(customer.PostalCode)}\nTelefono numeris: {IfNull(customer.Phone)}\nElektroninis pastas: {customer.Email}");
            foreach (var invoice in customer.Invoices) Console.WriteLine(invoice.ToString());
            Console.WriteLine("q - atgal");
        }

        private void PrintCustomerMenu(IEnumerable<Customer> customers)
        {
            Console.Clear();
            if (_menuService.IsChoice) Console.WriteLine(MenuTextData.CustomerMenuText);
            else PrintCustomers(customers);  
        }
        private void PrintTracks(IEnumerable<Track> tracks)
        {
            Console.Clear();
            if(tracks == null) return;

            foreach (var track in tracks) Console.WriteLine(track.ToString());
        }
        private void PrintCustomers(IEnumerable<Customer> customers)
        {
            foreach (var customer in customers) Console.WriteLine(customer.ToString());
        }
    }
}
