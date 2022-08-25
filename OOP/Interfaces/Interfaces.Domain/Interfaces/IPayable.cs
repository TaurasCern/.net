using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Domain.Interfaces
{
    public interface IPayable
    {
        int GetSalary();
        void IncreaseSalary(int amount);
        string GetAdress();
    }
}
