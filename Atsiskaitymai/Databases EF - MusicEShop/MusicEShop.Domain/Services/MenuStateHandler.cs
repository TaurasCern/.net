using MusicEShop.Domain.Interfaces;
using MusicEShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicEShop.Domain.Services
{
    public class MenuStateHandler : IMenuStateHandler
    {
        /* menu state documentation */
        /* "Not logged in" -> Login menu
         *      "Customer menu" -> Customer menu
         *          "Print tracks" -> Prints all tracks -> "Filter"
         *              "Filter" -> Filter menu
         *                  "Sort" -> Sort menu
         *                      "Sort: Name Alphabetical A-Z"            -> "Filter"
         *                      "Sort: Name Alphabetical Z-A"            -> "Filter"
         *                      "Sort: Composer Alphabetical A-Z"        -> "Filter"
         *                      "Sort: Genre Alphabetical A-Z"           -> "Filter"
         *                      "Sort: Composer->Album Alphabetical A-Z" -> "Filter"
         *                  "Search" -> Search menu
         *                      "Search: Id"                  -> "Filter"
         *                      "Search: Name"                -> "Filter"
         *                      "Search: Composer"            -> "Filter"
         *                      "Search: Genre"               -> "Filter"
         *                      "Search: Composer + Album"    -> "Filter"
         *                      "Search: Minumum Miliseconds" -> "Filter"
         *                      "Search: Maximum Miliseconds" -> "Filter" */
        /* "Add customer"  -> Add customer menu -> repository -> add customer menu */
        /* "Employee menu" -> Employee menu */
        /* "Exit"          -> Exit the application */

        private string _menuState;
        public bool IsChoice { get; set; }
        private MenuValidator _menuValidator;
        public string SearchQuery { get; set; }

        public MenuStateHandler()
        {
            _menuState = "Not logged in";
            IsChoice = true;
        }
        public string GetMenuState() => _menuState;
        public void SetMenuState(string state) { _menuState = state; }

        public void Menu(ConsoleKey choice)
        {
            switch (_menuState) 
            {
                case "Not logged in": LoginMenu(choice); IsChoice = false; break;
                    
                case "Customer menu": CustomerMenu(choice); break;
                    case "Print tracks": Filter(choice); break;
                        case "Sort": SortMenu(choice); break;
                        case "Search": SearchMenu(choice); break;
                    case "Add to cart": AddToCartMenu(choice); break;
                    case "Check cart": CheckCartMenu(choice); break;
                        case "Checked out": Back(choice); break;
                    case "Invoice history": _menuState = "Customer menu" ; break;
                case "Exit": Exit(); break;

                case "Employee menu": EmployeeMenu(choice); break;
                    case "Print customers":  _menuState = "Employee menu"; break;
                    case "Update customer": UpdateCustomerMenu(choice); break;
                    case "Change tracks status menu": ChangeTrackStatusMenu(choice); break;
                        case "Print all tracks": PrintAllTracks(choice); break;
                        case "Change tracks status": UpdateStatus(choice); break;
                        case "Change track menu": ChangeTrack(choice); break;
                        case "Change track": _menuState = "Employee menu"; break;
            }
        }

        private void ChangeTrack(ConsoleKey choice)
        {
            _menuState = choice switch
            {
                ConsoleKey.Y => "Change track",
                ConsoleKey.Q => "Change tracks status menu",
            };
        }

        private void UpdateStatus(ConsoleKey choice)
        {
            _menuState = choice switch
            {
                ConsoleKey.D1 or ConsoleKey.NumPad1 => "Change tracks status menu",
                ConsoleKey.Q => "Change tracks status menu",
            };
        }

        private void PrintAllTracks(ConsoleKey choice)
        {
            _menuState = choice switch
            {
                ConsoleKey.Q => "Change tracks status menu",
            };
        }

        private void ChangeTrackStatusMenu(ConsoleKey choice)
        {
            _menuState = choice switch
            {
                ConsoleKey.D1 or ConsoleKey.NumPad1 => "Print all tracks",
                ConsoleKey.D2 or ConsoleKey.NumPad2 => "Get track",
                ConsoleKey.Q => "Employee menu",
            };
            if(_menuState == "Get track") IsChoice = false;
        }

        private void UpdateCustomerMenu(ConsoleKey choice)
        {
            _menuState = choice switch
            {
                ConsoleKey.D1 or ConsoleKey.NumPad1 => "Update: Name",
                ConsoleKey.D2 or ConsoleKey.NumPad2 => "Update: LastName",
                ConsoleKey.D3 or ConsoleKey.NumPad3 => "Update: Email",
                ConsoleKey.D4 or ConsoleKey.NumPad4 => "Update: Billing adrress",
                ConsoleKey.D5 or ConsoleKey.NumPad5 => "Update: PhoneNumber",
                ConsoleKey.Q => "Employee menu",
            };
            if(choice == ConsoleKey.Q) IsChoice = true;
            else IsChoice = false;
        }

        private void Back(ConsoleKey choice)
        {
            _menuState = choice switch
            {
                ConsoleKey.Q => "Customer menu",
            };
            IsChoice = true;
        }

        private void CheckCartMenu(ConsoleKey choice)
        {
            _menuState = choice switch
            {
                ConsoleKey.Y => "Checkout",
                ConsoleKey.Q => "Customer menu",
            };
        }

        private void AddToCartMenu(ConsoleKey choice)
        {
            _menuState = choice switch
            {
                ConsoleKey.D1 or ConsoleKey.NumPad1 => "AddSearch: Id",
                ConsoleKey.D2 or ConsoleKey.NumPad2 => "AddSearch: Name",
                ConsoleKey.D3 or ConsoleKey.NumPad3 => "AddSearch: AlbumId",
                ConsoleKey.D4 or ConsoleKey.NumPad4 => "AddSearch: AlbumTitle",
                ConsoleKey.Y => "Added to cart",
                ConsoleKey.Q => "Customer menu",
            };
        }

        private void SortMenu(ConsoleKey choice) 
        {
            _menuState = choice switch
            {
                ConsoleKey.D1 or ConsoleKey.NumPad1 => "Sort: Name Alphabetical A-Z",
                ConsoleKey.D2 or ConsoleKey.NumPad2 => "Sort: Name Alphabetical Z-A",
                ConsoleKey.D3 or ConsoleKey.NumPad3 => "Sort: Composer Alphabetical A-Z",
                ConsoleKey.D4 or ConsoleKey.NumPad4 => "Sort: Genre Alphabetical A-Z",
                ConsoleKey.D5 or ConsoleKey.NumPad5 => "Sort: Composer->Album Alphabetical A-Z",
            };
            IsChoice = false;
        }
        private void SearchMenu(ConsoleKey choice)
        {
            _menuState = choice switch
            {
                ConsoleKey.D1 or ConsoleKey.NumPad1 => "Search: Id",
                ConsoleKey.D2 or ConsoleKey.NumPad2 => "Search: Name",
                ConsoleKey.D3 or ConsoleKey.NumPad3 => "Search: Composer",
                ConsoleKey.D4 or ConsoleKey.NumPad4 => "Search: Genre",
                ConsoleKey.D5 or ConsoleKey.NumPad5 => "Search: Composer + Album",
                ConsoleKey.D6 or ConsoleKey.NumPad6 => "Search: Minumum Miliseconds",
                ConsoleKey.D7 or ConsoleKey.NumPad7 => "Search: Maximum Miliseconds",
            };
            IsChoice = false;
        }
        private void Filter(ConsoleKey choice)
        {
            _menuState = choice switch
            {
                ConsoleKey.Q => "Customer menu",
                ConsoleKey.O => "Sort",
                ConsoleKey.S => "Search",
            };
        }

        private void LoginMenu(ConsoleKey choice)
        {
            _menuState = choice switch
            {
                ConsoleKey.D1 or ConsoleKey.NumPad1 => "Customer menu",
                ConsoleKey.D2 or ConsoleKey.NumPad2 => "Add customer",
                ConsoleKey.D3 or ConsoleKey.NumPad3 => "Employee login",
                ConsoleKey.Q => _menuState = "Exit",
            };
        }

        private void CustomerMenu(ConsoleKey choice)
        {
            _menuState = choice switch
            {
                ConsoleKey.D1 or ConsoleKey.NumPad1 => "Print tracks",
                ConsoleKey.D2 or ConsoleKey.NumPad2 => "Add to cart",
                ConsoleKey.D3 or ConsoleKey.NumPad3 => "Check cart",
                ConsoleKey.D4 or ConsoleKey.NumPad4 => "Invoice history",
                ConsoleKey.Q => "Not logged in",
            };
        }
        private void EmployeeMenu(ConsoleKey choice)
        {
            _menuState = choice switch
            {
                ConsoleKey.D1 or ConsoleKey.NumPad1 => "Print customers",
                ConsoleKey.D2 or ConsoleKey.NumPad2 => "Remove customer: Id",
                ConsoleKey.D3 or ConsoleKey.NumPad3 => "Update customer",
                ConsoleKey.D4 or ConsoleKey.NumPad4 => "Change tracks status menu",
                ConsoleKey.Q => "Not logged in",
            };
            if(_menuState == "Update customer") IsChoice = false;
        }
        private void Exit()
        {
            Environment.Exit(0);
        }
    }
}
