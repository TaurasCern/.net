using MusicEShop.Domain.DTOs;
using MusicEShop.Domain.Models;
using MusicEShop.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicEShop.Domain.Interfaces;

namespace MusicEShop.Domain.Services
{
    public class MenuService : IMenuService
    {
        public Customer Customer { get; private set; }
        public Invoice Cart { get; private set; }
        public Track Track { get; private set; }
        private IMenuStateHandler _menuStateHandler;
        private IMenuValidator _menuValidator;
        private IInputService _inputService;
        public MenuService(IMenuStateHandler menuStateHandler)
        {
            _menuValidator = new MenuValidator(menuStateHandler);
            _menuStateHandler = menuStateHandler;
            _inputService = new InputService(menuStateHandler);
            Cart = new Invoice();
        }
        private bool IsCustomerLogin() => _menuStateHandler.GetMenuState() == "Customer menu" && !_menuStateHandler.IsChoice;
        private bool IsEmployeeLogin() => _menuStateHandler.GetMenuState() == "Employee login" && !_menuStateHandler.IsChoice;
        private bool IsAddToCart() => _menuStateHandler.GetMenuState().Equals("Added to cart");
        private bool IsCustomerSearch() => _menuStateHandler.GetMenuState() == "Update customer" && !_menuStateHandler.IsChoice;
        private bool IsTrackStatus() => _menuStateHandler.GetMenuState() == "Get track" && !_menuStateHandler.IsChoice;
        public void Process<T>(T data)
        {
            if (IsCustomerLogin()) Login(data as IEnumerable<Customer>);
            else if (IsEmployeeLogin()) EmployeeLogin();
            else if (IsCustomerSearch()) Login(data as IEnumerable<Customer>);
            else if (IsTrackStatus())
            {
                Track = (data as IEnumerable<Track>).FirstOrDefault();
                _menuStateHandler.SetMenuState("Change track menu"); 
                _menuStateHandler.IsChoice = true;
            }
            else if (_menuStateHandler.IsChoice)
                Choice();


            if (IsAddToCart())
            {
                AddToCart(data as IEnumerable<Track>);

                _menuStateHandler.SetMenuState("Customer menu");
            }
        }
        private void Choice()
        {
            var choice = Console.ReadKey().Key;
            if (!_menuValidator.ValidChoice(choice)) return;
            if (_menuStateHandler.GetMenuState().Equals("Checked out")) { Cart = new Invoice(); }
            if (_menuStateHandler.GetMenuState().Equals("Add Customer")) { }
            _menuStateHandler.Menu(choice);
        }
        private void AddToCart(IEnumerable<Track> tracks)
        {
            var items = new List<InvoiceItem>();

            foreach (var track in tracks)
            {
                items.Add(new InvoiceItem(track));
            }

            Cart.InvoiceItemAddRange(items);
        }
        private void Login(IEnumerable<Customer> customers)
        {
            int input = _inputService.InputInt();
            var customer = customers.FirstOrDefault(r => r.CustomerId == input);

            if (customer is null) { return; }

            Customer = customer;
            Cart.CustomerId = Customer.CustomerId;
            _menuStateHandler.IsChoice = true;
        }
        private void EmployeeLogin() 
        {
            string password = Console.ReadLine();

            if(password != PINDTO.PIN) _menuStateHandler.SetMenuState("Not logged in"); 
            else _menuStateHandler.SetMenuState("Employee menu");
   
            _menuStateHandler.IsChoice = true;
        }
        public void SetCustomer(Customer customer) { Customer = customer; }
        public void SetTrack(Track track) { Track = track; }
        public void SetInvoice(Invoice invoice) { Cart = invoice; }
    }
}
