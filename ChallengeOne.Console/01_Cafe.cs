using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne.Console
{
    public class Item : MenuItem
    {
        public Item() { }
        public Item(string name, string description, int price) : base(name, description, price) { }
    }
}
