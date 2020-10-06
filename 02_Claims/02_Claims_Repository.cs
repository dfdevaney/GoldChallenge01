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
        public List<ClaimContent> GetAllClaims()
        {
            List<ClaimContent> allClaims = new List<ClaimContent>();
            foreach(ClaimContent content in _contentDirectory)
            {
                allClaims.Add(content);
                return allClaims;
            }
        }
    }
}
