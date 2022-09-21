using ShoeShop.Infrastructure.Database;

namespace ShoeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ShoeShopContext())
            {
                context.Database.EnsureCreated();
                var repository = new ShoeRepository(context);
            }
            /*
                         * Sukurkite nauja programa ShoeShop. Si programa turetu tureti duombaze su 3 lentelemis:
                       Shoes Id
            Name[iki 100 simboliu, privalomas]
            Type[iki10 simboliu, privalomas] // Moteriski, vyriski, vaikiski etc
            Price
                      ShoeSizeId
            Size
            Quantity
                      SaleId
            Shoe (Kurie buvo nupirkti)
            Pairs (Kiek poru batu buvo nupirkta)
            Sale taip pat turi tureti property PurchaseTotal,
                        kuri neturetu atsirasti duombazeje (Tam naudokite [NotMapped]) ir turetu 
                        buti apskaiciuojama naudojant bato kaina * parduotas kiekis. Atsiminkite, 
                        kad siame kontekste vienas batu pora gali turetu daug dydziu (One to Many), 
                        batu dydis turetu tureti 1 pora batu (many to one), 
                        o pardavimas turetu tureti 1 batu dydi (Pagal kuri galesime atsekti programos pagalba reikalinga batu pora).
            [Key]
            [NotMapped]
            [Required, MaxLength(100)]
            Sukurkite klase ShoeShopRepository su jai priklausanciu interface, kurie leistu apsipirkti batus.
            ShoeShopRepository metodai:
                            public List<Shoe> GetAllShoes()
                            public void MakePurchaseAndReduceQuantity(int shoeSizeId, int quantity)
            public List<Sale> GetAllPurchases()
            Tam, kad visus siuos reikalavimus igyvendintumete jums reikes uzsipildyti pradinius duomenis duomenu bazeje (batu kiekiai, dydziai ir t.t)
            Sukurkite klase ShoeShop, kuri veiktu kaip jusu programine interface dalis (UI/ConsoleWriteline) ir turetu metoda Purchase(), 
                        kuris i ekrana isvestu reikiamas zinutes ir valdytu visa pirkimo logika (Atemimas is quantity, pridejimas i Purchases)
                         */
        }
    }
}