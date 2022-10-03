using MusicEShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicEShop.Domain.Interfaces;

namespace MusicEShop.Domain.Services
{
    public class InputService : IInputService
    {
        private IMenuStateHandler _menu;
        public InputService(IMenuStateHandler menu)
        {
            _menu = menu;
        }
        public int InputInt() 
        { 
            var isParsed = int.TryParse(Console.ReadLine(), out int number);

            while (!isParsed)
            {
                Console.WriteLine("Not a number. Try again");

                isParsed = int.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }
        public string InputString() => Console.ReadLine();

        public string Search()
        {
            Console.Clear();
            Console.WriteLine($"Paieska: ({_menu.GetMenuState()})");

            if (_menu.GetMenuState().Equals("Search: Id") 
            ||  _menu.GetMenuState().Contains("Search: AlbumId")) 
            { 
                return InputInt().ToString(); 
            }

            else return InputString(); 
        }
        public string Update()
        {
            Console.Clear();
            Console.WriteLine($"Atnaujinama: ({_menu.GetMenuState()})");
            return InputString();
        }
        public Customer InputCustomer()
        {
            Console.Clear();
            Console.WriteLine("Iveskite varda");
            var firstName = InputString();
            Console.WriteLine("Iveskite pavarde");
            var lastName = InputString();
            Console.WriteLine("Iveskite elektronini pasta");
            var email = InputString();

            return new Customer(firstName, lastName, email);
        }
        public int TrackId()
        {
            Console.Clear();
            Console.WriteLine("Iveskite iraso Id:");

            return InputInt();
        }
    }
}
