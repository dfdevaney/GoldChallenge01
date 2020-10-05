using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims
{
        public enum ClaimType
        {
            Car = 1, Home, Theft
        }
        public class ClaimContent
        {
            public int ClaimID { get; set; }
            public ClaimType TypeOfClaim { get; set; }

            public string ClaimDescription { get; set; }
            public float ClaimAmount { get; set; }
            public string DateOfIncident { get; set; }
            public string DateOfClaim { get; set; }
            public bool IsValid { get; set; }
        public ClaimContent(int claimID, ClaimType claimType, string claimDescription, float claimAmount, string dateOfIncident, string dateOfClaim, bool isValid)
        {
            ClaimID = claimID;
            TypeOfClaim = claimType;
            ClaimDescription = claimDescription;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }
    }
}
