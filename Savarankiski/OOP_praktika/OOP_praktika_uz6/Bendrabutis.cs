using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika_uz6
{
    /*
 * Uzduotis 6: 
 * (Savarankiskai)
 * Sukurkite klasę “Bendrabutis”. 
 * Klasės kontraktas/interfeisas turėtų turėti šiuos atributus:       
 * BendrabucioId
    KambariuSkaicius
    Kaina
Sujunkite/sukomponuokite klases “Zmogus” ir “Bendrabutis” taip,
kad kiekviename bendrabutyje galėtų gyventi daug žmonių, 
tačiau vienas žmogus galėtų gyventi tik viename bendrabutyje.
  */
    internal class Bendrabutis
    {
        public int ID { get; private set; }
        public double Price { get; private set; }
        public List<Person> Tenants { get; private set; } = new List<Person>();
        public Bendrabutis()
        {

        }
        public Bendrabutis(int iD, double price, List<Person> tenants)
        {
            ID = iD;
            Price = price;
            Tenants = tenants;
        }

    }
}
