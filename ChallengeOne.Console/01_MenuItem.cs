using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne.Console
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public MenuItem() { }
        public MenuItem(string name, string description, int price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
