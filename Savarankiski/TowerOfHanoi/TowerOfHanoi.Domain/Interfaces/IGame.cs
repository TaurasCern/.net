using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Domain.Interfaces
{
    public interface IGame
    {
        void PickUp(int collumn);
        void Place(int collumn);
        bool IsWon(int collumn = 2);
    }
}
