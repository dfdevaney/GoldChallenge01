using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims
{
    public class Claims_Content_Repository
    {
        protected readonly List<ClaimContent> _contentDirectory = new List<ClaimContent>();

        // Create:
        public bool AddClaimToDirectory(ClaimContent content)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content);
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        // Read All:
        public List<ClaimContent> GetContents()
        {
            return _contentDirectory;
        }

        // Read One:
        public ClaimContent GetContentByID(int iD)
        {
            foreach(ClaimContent singleContent in _contentDirectory)
            {
                if(singleContent.ClaimID.ToString() == iD.ToString())
                {
                    return singleContent;
                }
            }
            return null;
        }

        // Update:
        public bool UpdateExistingClaim(int originalID, ClaimContent newContent)
        {
            ClaimContent oldContent = GetContentByID(originalID);
            if(oldContent != null)
            {
                oldContent.ClaimID = newContent.ClaimID;
                oldContent.TypeOfClaim = newContent.TypeOfClaim;
                oldContent.ClaimDescription = newContent.ClaimDescription;
                oldContent.ClaimAmount = newContent.ClaimAmount;
                oldContent.DateOfIncident = newContent.DateOfIncident;
                oldContent.DateOfClaim = newContent.DateOfClaim;
                oldContent.IsValid = newContent.IsValid;

                return true;
            }
            else { return false; }
        }

        // Delete:
        public bool DeleteExistingClaim(ClaimContent existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }
    }
}
