using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktika_homework
{
    internal class Room
    {
        public Floor Floor { get; set; }
        public Wall[] Walls { get; set; }
        public Ceiling Ceiling { get; set; }
        public Chimney Chimney { get; set; }
        public Wardrobe Wardrobe { get; set; }
        public Shelve[] Shelves { get; set; }
        public Table Table { get; set; }
        public Drawer Drawer { get; set; }
        public Chair Chair { get; set; }
        public Bed Bed { get; set; }

        public Room(Floor floor, Wall[] walls, Ceiling ceiling, Chimney chimney, Wardrobe wardrobe, Shelve[] shelves, Table table, Drawer drawer, Chair chair, Bed bed)
        {
            this.Floor = floor;
            this.Walls = walls;
            this.Ceiling = ceiling;
            this.Chimney = chimney;
            this.Wardrobe = wardrobe;
            this.Shelves = shelves;
            this.Table = table;
            this.Drawer = drawer;
            this.Chair = chair;
            this.Bed = bed;
        }
        public Room()
        {

        }
    }
}
