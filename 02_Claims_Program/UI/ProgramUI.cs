using _02_Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims_Program.UI
{
    public class ProgramUI
    {
        private readonly IConsole _console;
        private readonly Claims_Repository _claimsRepo = new Claims_Repository();
        public ProgramUI(IConsole console)
        {
            _console = console;
        }
        public void Run()
        {
            SeedContent();
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                _console.Clear();
                _console.WriteLine("Choose a Menu Item: \n" +
                    "1) See All Claims. \n" +
                    "2) Take Care of Next Claim. \n" +
                    "3) Enter a New Claim. \n" +
                    "4) Exit.");
                string userInput = _console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        GetAllClaims();
                        break;
                    case "2":
                        MoveToNextClaim();
                        break;
                    case "3":
                        CreateNewClaim();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        _console.WriteLine("Please enter a valid number between 1 & 4. \n" +
                                           "Press any key to continue......");
                        _console.ReadKey();
                        break;
                }
            }
        }
        private void DisplaySimple(ClaimContent content)
        {
            _console.WriteLine("Claim ID \tType \tDescription \tAmount \tDate of Accident \t Date of Claim \tIs Valid \n" +
                $"{content.ClaimID} \t{content.TypeOfClaim} \t{content.ClaimDescription} \t{content.ClaimAmount} \t{content.DateOfIncident} \t{content.DateOfClaim} \t{content.IsValid}");
        }
        private void GetAllClaims()
        {
            _console.Clear();
            List<ClaimContent> listOfClaims = _claimsRepo.GetAllClaims();
            foreach (ClaimContent content in listOfClaims)
            {
                DisplaySimple(content);
            }
            _console.WriteLine("Press any key to continue....");
            _console.ReadKey();
        }
        private void MoveToNextClaim()
        {
            _console.Clear();
            Queue<ClaimContent> queue = _claimsRepo.ClaimQueue();

        }
        private void CreateNewClaim()
        {
            _console.Clear();
            ClaimContent claim = new ClaimContent();
            // Get Claim ID:
            _console.WriteLine("Please enter the Claim Number: ");
            int claimID = Convert.ToInt32(_console.ReadLine());
            claim.ClaimID = claimID;
            // Get Type of Claim:
            _console.WriteLine($"Please enter the Claim Type for Claim {claimID}: 1) Car \n2) Home \n3)Theft");
            string claimType = _console.ReadLine();
            switch (claimType)
            {
                case "1":
                    claim.TypeOfClaim = ClaimType.Car;
                    break;
                case "2":
                    claim.TypeOfClaim = ClaimType.Home;
                    break;
                case "3":
                    claim.TypeOfClaim = ClaimType.Theft;
                    break;
            }
            // Get Description:
            _console.WriteLine($"Enter Description for Claim {claimID}: ");
            string description = _console.ReadLine();
            claim.ClaimDescription = description;
            // Get Claim Amount:
            _console.WriteLine($"Enter Claim Amount for Claim {claimID}: ");
            decimal claimAmount = Convert.ToDecimal(_console.ReadLine());
            claim.ClaimAmount = claimAmount;
            // Get Date of Incident:
            _console.WriteLine($"Enter Date of Incident for Claim {claimID}: (mm/dd/yyyy)");
            string claimIncidentDate = _console.ReadLine();
            claim.DateOfIncident = claimIncidentDate;
            // Get Date of Claim:
            _console.WriteLine($"Enter the Claim Date for Claim {claimID}: ");
            string claimDate = _console.ReadLine();
            claim.DateOfClaim = claimDate;
            // Get Claim Validity:
            _console.WriteLine($"Enter if the Claim is Valid for Calim {claimID}: 1) True \n2) False");
            string claimValidity = _console.ReadLine();
            switch (claimValidity)
            {
                case "1":
                    claim.IsValid = Validity.True;
                    break;
                case "2":
                    claim.IsValid = Validity.False;
                    break;
            }
            // Add Claim to Repository:
            _claimsRepo.AddClaimToDirectory(claim);
        }
        private void SeedContent()
        {

        }
    }
}
