using MusicEShop.Domain.DTOs;
using MusicEShop.Infrastructure.Database;
using MusicEShop.Domain.Services;
using MusicEShop.Domain.Models;
using MusicEShop.Domain.Interfaces;

namespace MusicEShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMenuStateHandler menuHandler = new MenuStateHandler();
            IShopUI ui = new ShopUI(menuHandler);
            IInputService inputService = new InputService(menuHandler);
            IMenuService menuService = new MenuService(menuHandler);
            IMusicEShopRepositoryHandler<IEnumerable<object>> repositoryHandler = 
                new MusicEShopRepositoryHandler<IEnumerable<object>>(
                    menuHandler, new MusicEShopRepository(
                        new chinookContext()), inputService, menuService);

            IEnumerable<object> result = null;

            while (menuHandler.GetMenuState() != "Exit")
            {            
                ui.PrintMenu(result, menuService.Customer, menuService.Cart);

                menuService.Process(result);

                result = repositoryHandler.Handle();
            }           
        }
    }
}