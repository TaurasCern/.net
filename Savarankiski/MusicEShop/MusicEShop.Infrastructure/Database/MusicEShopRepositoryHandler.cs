using MusicEShop.Domain.Models;
using MusicEShop.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicEShop.Domain.Interfaces;

namespace MusicEShop.Infrastructure.Database
{
    public class MusicEShopRepositoryHandler<T> : IMusicEShopRepositoryHandler<T>
    {
        private IMenuStateHandler _menuHandler;
        private IMusicEShopRepository _repository;
        private IInputService _input;
        private IMenuService _menuService;
        public MusicEShopRepositoryHandler(IMenuStateHandler menuHandler, IMusicEShopRepository repository, IInputService input, IMenuService menuService)
        {
            _menuHandler = menuHandler;
            _repository = repository;
            _input = input;
            _menuService = menuService;
        }

        public T Handle()
        {
            switch (_menuHandler.GetMenuState())
            {
                case "Not logged in": return default(T);
                case "Customer menu" or "Update customer": return (T)_repository.GetAllCustomers();
                    case "Print tracks": return (T)GetAllActiveTracks();
                        case string s when s.Contains("Sort:"): var sorted = (T)GetSortedTracks(); ResetFilter(); return sorted;
                        case string s when s.Contains("Search:"): _menuHandler.SearchQuery = _input.Search(); var found = (T)GetFoundTracks(); ResetFilter(); return found;
                    case "Checkout": Checkout(_menuService.Cart); break;
                case "Add customer": AddCustomer(); break;
                case "Print customers": return (T)_repository.GetAllCustomers();
                case string s when s.Contains("Update:"): UpdateCustomer(_menuService.Customer); ResetEmplyee(); break;
                case "Print all tracks": return (T)_repository.GetAllTracks();
                case "Get track": int id = _input.TrackId(); return (T)GetTrackById(id);
                    case "Change track": UpdateTrackStatus(); break;
            }
            return default(T);
        }

        private void UpdateTrackStatus()
        {
            _menuService.Track.ChangeStatus();

            _repository.UpdateTrack(_menuService.Track);

            _menuHandler.SetMenuState("Employee menu");
        }

        private IEnumerable<Track> GetTrackById(int id) => _repository.GetAllTracks().Where(t => t.TrackId == id); 
        private IEnumerable<Track> GetAllActiveTracks() => _repository.GetAllTracks().Where(t => t.Status == "Active");

        private void UpdateCustomer(Customer customer) 
        {
            switch (_menuHandler.GetMenuState())
            {
                case "Update: Name": customer.FirstName = _input.Update(); _repository.UpdateCustomer(customer); break;
                case "Update: LastName": customer.LastName = _input.Update(); _repository.UpdateCustomer(customer); break;
                case "Update: Email": customer.Email = _input.Update(); _repository.UpdateCustomer(customer); break;
                case "Update: Billing adrress": customer.Address = _input.Update(); _repository.UpdateCustomer(customer); break;
                case "Update: PhoneNumber": customer.Phone = _input.Update(); _repository.UpdateCustomer(customer); break;
            }
        }
        private void Checkout(Invoice invoice)
        {
            _repository.CreateInvoice(invoice);
            _menuHandler.SetMenuState("Checked out");
            _menuHandler.IsChoice = true;
        }

        private void AddCustomer()
        {
            _repository.CreateCustomer(_input.InputCustomer());
            _menuHandler.SetMenuState("Not logged in");
            _menuHandler.IsChoice = true;
        }
        private void ResetEmplyee()
        {
            _menuHandler.IsChoice = true;
            _menuHandler.SetMenuState("Employee menu");
        }
        private void ResetFilter()
        {
            if (_menuHandler.GetMenuState().Contains("AddSearch:")) 
            {
                _menuHandler.IsChoice = false;
                _menuHandler.SetMenuState("Add to cart");  
            }
            else
            {
                _menuHandler.IsChoice = true;
                _menuHandler.SetMenuState("Print tracks");
            }          
        }
        private IEnumerable<Track> GetSortedTracks() => _menuHandler.GetMenuState() switch
        {
            "Sort: Name Alphabetical A-Z" => GetAllActiveTracks().OrderBy(t => t.Name),
            "Sort: Name Alphabetical Z-A" => GetAllActiveTracks().OrderByDescending(t => t.Name),
            "Sort: Composer Alphabetical A-Z" => GetAllActiveTracks().OrderBy(t => t.Composer),
            "Sort: Genre Alphabetical A-Z" => GetAllActiveTracks().OrderBy(t => t.Genre.Name),
            "Sort: Composer->Album Alphabetical A-Z" => GetAllActiveTracks().OrderBy(t => t.Composer).ThenBy(t => t.Album.Title),
        };

        private IEnumerable<Track> GetFoundTracks() => _menuHandler.GetMenuState() switch
        {
            "Search: Id" or "AddSearch: Id" => GetAllActiveTracks().Where(t => t.TrackId == int.Parse(_menuHandler.SearchQuery)),
            "Search: Name" or "AddSearch: Name" => GetAllActiveTracks().Where(t => t.Name.ToLower().Contains(_menuHandler.SearchQuery)),
            "Search: Composer" => GetAllActiveTracks().Where(t => t.Composer != null).Where(t => t.Composer.ToLower().Contains(_menuHandler.SearchQuery)),
            "Search: Genre" => GetAllActiveTracks().Where(t => t.Genre.Name == _menuHandler.SearchQuery),
            "Search: Composer + Album" => GetAllActiveTracks().Where(t => t.Composer == _input.InputString() && t.Album.Title == _menuHandler.SearchQuery),
            "Search: Minumum Miliseconds" => GetAllActiveTracks().Where(t => t.Milliseconds >= int.Parse(_menuHandler.SearchQuery)),
            "Search: Maximum Miliseconds" => GetAllActiveTracks().Where(t => t.Milliseconds <= int.Parse(_menuHandler.SearchQuery)),

            "AddSearch: AlbumId" => GetAllActiveTracks().Where(t => t.AlbumId == int.Parse(_menuHandler.SearchQuery)),
            "AddSearch: AlbumTitle" => GetAllActiveTracks().Where(t => t.Album.Title == _menuHandler.SearchQuery)
        };
    }
}
