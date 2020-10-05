using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne.Console
{
    public class MenuRepository : MenuItemRepository
    {
        public Item GetMenuItemByName(string name)
        {
            foreach (MenuItem item in _itemMenu)
            {
                if (item.Name.ToLower() == name.ToLower() && item.Name.ToLower() == nameof(Item))
                {
                    return (Item)item;
                }
            }
            return null;
        }
    }
}
