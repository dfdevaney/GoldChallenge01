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
        public enum Validity
        {
            True = 1, False
        }
        public class ClaimContent
        {
            public int ClaimID { get; set; }
            public ClaimType TypeOfClaim { get; set; }

            public string ClaimDescription { get; set; }
            public decimal ClaimAmount { get; set; }
            public string DateOfIncident { get; set; }
            public string DateOfClaim { get; set; }
            public Validity IsValid { get; set; }
            public bool IsIsNotValid
            {
                get
                {
                    switch (IsValid)
                    {
                    case Validity.True:
                        return true;
                    case Validity.False:
                        return false;
                    default:
                        return false;
                    }
                }
            }
        public ClaimContent(int claimID, ClaimType claimType, string claimDescription, decimal claimAmount, string dateOfIncident, string dateOfClaim, Validity isValid)
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
