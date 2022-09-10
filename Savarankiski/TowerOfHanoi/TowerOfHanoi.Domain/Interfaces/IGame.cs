using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoi.Domain.Models;

namespace TowerOfHanoi.Domain.Interfaces
{
    public interface IGame
    {
        Dictionary<int, List<Disk>> Board { get; set; }
        int Moves { get; set; }
        Disk PickedUpDisk { get; set; }
        int CurrentCollumn { get; set; }
        int PreviousCollumn { get; set; }
        bool IsPickedUp { get; }
        List<int> GetLocations();
        void PickUp(int collumn);
        void Place(int collumn);
        bool IsWon(int collumn = 2);
        bool IsPlaceable(int choice);
    }
}
