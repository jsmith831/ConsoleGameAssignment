using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleGameAssignment.ProgramUI;

namespace ConsoleGameAssignment
{
    public class Room
    {
        public string Splash { get; }
        public List<String> Items { get; }
        public List<string> Exits { get; }
        //public void RemoveItem(Item item)
        //{
        //    if (item.Contains(item))
        //    {
        //        Items.Remove(item);
        //    }
        //}

        public Room(string splash, List<string> exits)
        {
            Splash = splash;
            Exits = exits;
        }
        public Room(string splash, List<string> exits, List<String> items)
        {
            Splash = splash;
            Exits = exits;
            Items = items;
        }
    }
}
