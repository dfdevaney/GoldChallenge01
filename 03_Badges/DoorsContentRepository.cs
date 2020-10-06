using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badges
{
    public class DoorsContentRepository
    {
        protected readonly List<DoorsContent> _doorDirectory = new List<DoorsContent>();

        // Create:

        public bool AddDoorToDirectory(DoorsContent doors)
        {
            int startingCount = _doorDirectory.Count;
            _doorDirectory.Add(doors);
            bool wasAdded = _doorDirectory.Count > startingCount ? true : false;
            return wasAdded;
        }

        // Read All:

        public List<DoorsContent> GetAllDoors()
        {
            return _doorDirectory;
        }

        // Read One:

        public DoorsContent GetDoorByAddress(string doorAddress)
        {
            foreach (DoorsContent doors in _doorDirectory)
            {
                if (doors.Doors == doorAddress)
                {
                    return doors;
                }
            }
            return null;
        }

        // Update:

        public bool UpdateExistingDoor(string originalDoor, DoorsContent newDoor)
        {
            DoorsContent oldDoor = GetDoorByAddress(originalDoor);
            if (oldDoor != null)
            {
                oldDoor.Doors = newDoor.Doors;
                return true;
            }
            else { return false; }
        }

        // Delete:

        public bool DeleteExistingDoor(DoorsContent existingDoor)
        {
            bool deleteResult = _doorDirectory.Remove(existingDoor);
            return deleteResult;
        }
    }
}
