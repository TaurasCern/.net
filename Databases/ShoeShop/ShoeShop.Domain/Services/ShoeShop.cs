using ShoeShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Domain.Services
{
    public class ShoeShop 
    {
        private readonly IShopRepository _repository;
        public ShoeShop(IShopRepository repository)
        {
            _repository = repository;
        }

        public void Begin()
        {
            Console.WriteLine("Pasirinkite veiksma:");
            Console.WriteLine("1.");
            Console.WriteLine("2. Pirkimas");

            var choice = Console.ReadKey().Key;

            if (choice == ConsoleKey.NumPad2) Buy();
        }
        private void Buy()
        {
            while(true)
            {
                Console.Clear();
                var shoesInStock = _repository.GetShoes();
                foreach (var shoe in shoesInStock)
                {
                    Console.WriteLine("shoe");
                }
                Console.WriteLine("Pasirinkti batu nr");
                var choice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Pasirinkite dydi");
                var chosenShoe = shoesInStock.First(x => x.Id == choice);
                foreach (var size in chosenShoe.Sizes)
                {
                    Console.WriteLine("sizes");
                }
                int inputSize = int.Parse(Console.ReadLine());
                var chosenSize = chosenShoe.Sizes.First(x => x.Size == inputSize);
                Console.WriteLine("Nurodykite kieki");
                var amount = int.Parse(Console.ReadLine());

                _repository.InsertSaleAndDecreaseAmount(chosenSize.Size, amount);
                Console.WriteLine();
                Console.WriteLine("Testi?()Y/N");
                var continueChoice = Console.ReadKey().Key;
                if(continueChoice == ConsoleKey.N) { break; }
            }
        }
    }
}
