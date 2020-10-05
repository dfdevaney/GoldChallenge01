using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne.Console
{
    public class MenuItemRepository
    {
        protected readonly List<MenuItem> _itemMenu = new List<MenuItem>();

        // CRUD: Create Read Update Delete

        // Create:

        public bool AddItemMenu(MenuItem item)
        {
            int startingCount = _itemMenu.Count;
            _itemMenu.Add(item);
            bool wasAdded = (_itemMenu.Count > startingCount) ? true : false;
            return wasAdded;
        }

        // Read All:

        public List<MenuItem> GetMenuItems()
        {
            return _itemMenu;
        }

        // Read One:

        public MenuItem GetItemByName(string name)
        {
            foreach (MenuItem singleItem in _itemMenu)
            {
                if (singleItem.Name.ToLower() == name.ToLower())
                {
                    return singleItem;
                }
            }
            return null;
        }

        // Update:

        public bool UpdateExistingItem(string originalName, MenuItem newItem)
        {
            MenuItem oldItem = GetItemByName(originalName);

            if (oldItem != null)
            {
                oldItem.Name = newItem.Name;
                return true;
            }
            else
            {
                return false;
            }
        }

        // Delete:

        public bool DeleteExistingItem(MenuItem existingItem)
        {
            bool deleteResult = _itemMenu.Remove(existingItem);
            return deleteResult;
        }
    }
}
