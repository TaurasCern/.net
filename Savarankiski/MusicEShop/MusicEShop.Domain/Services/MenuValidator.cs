using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicEShop.Domain.Interfaces;

namespace MusicEShop.Domain.Services
{
    public class MenuValidator : IMenuValidator
    {
        private IMenuStateHandler _menuStateHandler;
        public MenuValidator(IMenuStateHandler menuStateHandler)
        {
            _menuStateHandler = menuStateHandler;
        }

        public bool ValidChoice(ConsoleKey choice) => _menuStateHandler.GetMenuState() switch
        {
            "Not logged in" => CheckLoginMenu(choice),
            "Customer menu" => CheckCustomerMenu(choice),
            "Print tracks" => CheckFilter(choice),
            "Sort" => CheckSearchMenu(choice),
            "Search" => CheckSortMenu(choice),
            "Add to cart" => CheckAddToCart(choice),
            "Check cart" => CheckCartMenu(choice),
            "Checked out" or "Invoice history" => CheckBack(choice),
            "Employee menu" => CheckEmployeeMenu(choice),
            "Print customers" => CheckBack(choice),
            "Update customer" => CheckUpdateCustomer(choice),
            "Change tracks status menu" => CheckChangeTracksStatus(choice),
            "Print all tracks" => CheckBack(choice),
            "Change track menu" => CheckChangeTrack(choice)
        };

        private bool CheckChangeTrack(ConsoleKey choice) => choice switch
        {
            ConsoleKey.Y => true,
            ConsoleKey.Q => true,
            _ => false
        };
        private bool CheckChangeTracksStatus(ConsoleKey choice) => choice switch
        {
            ConsoleKey.D1 or ConsoleKey.NumPad1 => true,
            ConsoleKey.D2 or ConsoleKey.NumPad2 => true,
            ConsoleKey.Q => true,
            _ => false
        };

        private bool CheckUpdateCustomer(ConsoleKey choice) => choice switch
        {
            ConsoleKey.D1 or ConsoleKey.NumPad1 => true,
            ConsoleKey.D2 or ConsoleKey.NumPad2 => true,
            ConsoleKey.D3 or ConsoleKey.NumPad3 => true,
            ConsoleKey.D5 or ConsoleKey.NumPad5 => true,
            ConsoleKey.D4 or ConsoleKey.NumPad4 => true,
            ConsoleKey.Q => true,
            _ => false
        };

        private bool CheckEmployeeMenu(ConsoleKey choice) => choice switch
        {
            ConsoleKey.D1 or ConsoleKey.NumPad1 => true,
            ConsoleKey.D2 or ConsoleKey.NumPad2 => true,
            ConsoleKey.D3 or ConsoleKey.NumPad3 => true,
            ConsoleKey.D4 or ConsoleKey.NumPad4 => true,
            ConsoleKey.Q => true,
            _ => false
        };

        private bool CheckLoginMenu(ConsoleKey choice) => choice switch
        {
            ConsoleKey.D1 or ConsoleKey.NumPad1 => true,
            ConsoleKey.D2 or ConsoleKey.NumPad2 => true,
            ConsoleKey.D3 or ConsoleKey.NumPad3 => true,
            ConsoleKey.Q => true,
            _ => false
        };
        private bool CheckCustomerMenu(ConsoleKey choice) => choice switch
        {
            ConsoleKey.D1 or ConsoleKey.NumPad1 => true,
            ConsoleKey.D2 or ConsoleKey.NumPad2 => true,
            ConsoleKey.D3 or ConsoleKey.NumPad3 => true,
            ConsoleKey.D4 or ConsoleKey.NumPad4 => true,
            ConsoleKey.Q => true,
            _ => false
        };
        private bool CheckFilter(ConsoleKey choice) => choice switch
        {
            ConsoleKey.Q => true,
            ConsoleKey.O => true,
            ConsoleKey.S => true,
            _ => false
        };
        private bool CheckSearchMenu(ConsoleKey choice) => choice switch
        {
            ConsoleKey.D1 or ConsoleKey.NumPad1 => true,
            ConsoleKey.D2 or ConsoleKey.NumPad2 => true,
            ConsoleKey.D3 or ConsoleKey.NumPad3 => true,
            ConsoleKey.D4 or ConsoleKey.NumPad4 => true,
            ConsoleKey.D5 or ConsoleKey.NumPad5 => true,
            ConsoleKey.D6 or ConsoleKey.NumPad6 => true,
            ConsoleKey.D7 or ConsoleKey.NumPad7 => true,
            ConsoleKey.Q => true,
            _ => false
        };
        private bool CheckSortMenu(ConsoleKey choice) => choice switch
        {
            ConsoleKey.D1 or ConsoleKey.NumPad1 => true,
            ConsoleKey.D2 or ConsoleKey.NumPad2 => true,
            ConsoleKey.D3 or ConsoleKey.NumPad3 => true,
            ConsoleKey.D4 or ConsoleKey.NumPad4 => true,
            ConsoleKey.D5 or ConsoleKey.NumPad5 => true,
            ConsoleKey.Q => true,
            _ => false
        };
        private bool CheckAddToCart(ConsoleKey choice) => choice switch
        {
            ConsoleKey.D1 or ConsoleKey.NumPad1 => true,
            ConsoleKey.D2 or ConsoleKey.NumPad2 => true,
            ConsoleKey.D3 or ConsoleKey.NumPad3 => true,
            ConsoleKey.D4 or ConsoleKey.NumPad4 => true,
            ConsoleKey.Y => true,
            ConsoleKey.Q => true,
            _ => false
        };
        private bool CheckCartMenu(ConsoleKey choice) => choice switch
        {
            ConsoleKey.Y => true,
            ConsoleKey.Q => true,
            _ => false
        };
        private bool CheckBack(ConsoleKey choice) => choice switch
        {
            ConsoleKey.Q => true,
            _ => false
        };
    }
}
