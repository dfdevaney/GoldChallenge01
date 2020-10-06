using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badges
{
    public class BadgesContentRepository
    {
        protected readonly List<BadgesContent> _badgesDirectory = new List<BadgesContent>();
        
        // Create:

        public bool AddBadgeToDirectory (BadgesContent badges)
        {
            int startingCount = _badgesDirectory.Count;
            _badgesDirectory.Add(badges);
            bool wasAdded = (_badgesDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        // Read All:

        public List<BadgesContent> GetAllBadges()
        {
            return _badgesDirectory;
        }

        // Read One:

        public BadgesContent GetBadgeByID(int badgeID)
        {
            foreach (BadgesContent badges in _badgesDirectory)
            {
                if (badges.BadgeID.ToString() == badgeID.ToString())
                {
                    return (BadgesContent)badges;
                }
            }
            return null;
        }

        // Update:

        public bool UpdateExistingBadge(int originalBadge, BadgesContent newBadge)
        {
            BadgesContent oldBadge = GetBadgeByID(originalBadge);
            if (oldBadge != null)
            {
                oldBadge.BadgeID = newBadge.BadgeID;
                return true;
            }
            else { return false; }
        }

        // Delete:

        public bool DeleteExistingBadge(BadgesContent existingBadge)
        {
            bool deleteResult = _badgesDirectory.Remove(existingBadge);
            return deleteResult;
        }
    }
}
