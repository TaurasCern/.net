using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TowerOfHanoi.Domain.Interfaces;

namespace TowerOfHanoi.Domain.Models
{
    public class Game : IGame
    {
        public Game(DateTime gameStartDate)
        {
            Board = new Dictionary<int, List<Disk>>()
            {
                { 0, new List<Disk>() },
                { 1, new List<Disk>() },
                { 2, new List<Disk>() },
            };
            
            Board[0].Add(new Disk(4, 0));
            Board[0].Add(new Disk(3, 0));
            Board[0].Add(new Disk(2, 0));
            Board[0].Add(new Disk(1, 0));

            PickedUpDisk = null;

            GameStartDate = gameStartDate;
        }
        public DateTime GameStartDate { get; }
        public Dictionary<int, List<Disk>> Board { get; set; }
        public Disk PickedUpDisk { get; set; }
        public int Moves { get; set; }
        public bool IsPickedUp { get => PickedUpDisk != null; }
        public int PreviousCollumn { get; set; }
        public int CurrentCollumn { get; set; }
        /// <summary>
        /// Method to "Pick up" a disk from specified collumn
        /// </summary>
        /// <param name="collumn">index of collumns</param>
        public void PickUp(int collumn)
        {
            PickedUpDisk = (Disk)Board[collumn][Board[collumn].Count - 1].Clone();
            Board[collumn].RemoveAt(Board[collumn].Count - 1);
            PreviousCollumn = collumn;
        }
        /// <summary>
        /// Method to "Place" a disk to a specified collumn
        /// </summary>
        /// <param name="collumn">index of collumns</param>
        public void Place(int collumn)
        {
            PickedUpDisk.Location = collumn;
            Board[collumn].Add((Disk)PickedUpDisk.Clone());
            PickedUpDisk = null;
            CurrentCollumn = collumn;
            Moves++;        
        }
        /// <summary>
        /// Method to get all locations from smallest to largest
        /// </summary>
        /// <returns> locations smallest to largest </returns>
        public List<int> GetLocations()
        {
            List<int> locations = new List<int>();
            List<Disk> disks = new List<Disk>();

            foreach(var collumn in Board.Values)
            {
                disks.AddRange(collumn);
            }
            disks.Sort((x, y) => x.Size.CompareTo(y.Size));

            foreach(var disk in disks)
            {
                locations.Add(disk.Location);
            }
            return locations;
        }
        /// <summary>
        /// Method to check if game if won
        /// </summary>
        /// <param name="collumn">3rd collumn</param>
        /// <returns>Is the game won</returns>
        public bool IsWon(int collumn = 2) => Board[collumn].Count == 4;
        /// <summary>
        /// Method to check if picked up Disk is placeable at the specified collumn
        /// </summary>
        /// <param name="collumn"></param>
        /// <returns></returns>
        public bool IsPlaceable(int collumn) => Board[collumn].Count == 0 ? true : Board[collumn][Board[collumn].Count - 1].Size > PickedUpDisk.Size;

    }
}
