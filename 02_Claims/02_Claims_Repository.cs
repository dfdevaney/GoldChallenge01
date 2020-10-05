using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims
{
    public class Claims_Repository : Claims_Content_Repository
    {
        public List<ClaimsMain> GetClaimByID(int claimID)
        {
            List<ClaimsMain> idList = new List<ClaimsMain>();
            var listOfAllClaims = GetAllClaims();
            foreach(var eachID in listOfAllClaims)
            {
                
            }
        }
    }
}
