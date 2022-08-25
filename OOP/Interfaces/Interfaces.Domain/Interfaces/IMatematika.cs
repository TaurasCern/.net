using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Domain.Interfaces
{
    public interface IMatematika
    {
        int Prideti(int number);
        int Atimti(int number);
        int Padauginti(int number);
        double Padalinti(int number);
        int PakeltiKvadratu();
        int PakeltiKubu();
    }
}
