using _03_Badges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badges_Program.UI
{
    public class ProgramUI
    {
        private readonly IConsole _console;
        private readonly BadgesRepository _badgeRepo = new BadgesRepository();
        private readonly DoorsRepository _doorRepo = new DoorsRepository();
        IDictionary<BadgesContent, DoorsContent> dictonary = new Dictionary<BadgesContent, DoorsContent>();
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
            while(continueToRun)
            {
                _console.Clear();
                _console.WriteLine("Menu \n \tHello Security Admin. What would you like to do? \n \t1) Add a Badge. \n \t2) Edit a Badge. \n \t3) List All Badges.");
                string userInput = _console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        AddBadge();
                        break;
                    case "2":
                        EditBadge();
                        break;
                    case "3":
                        ListAllBadges();
                        break;
                    default:
                        _console.WriteLine("Please enter a valid number between 1 & 3. \nPress any key to continue...");
                        _console.ReadKey();
                        break;
                }
            }
        }
        private void AddBadge()
        {
            _console.Clear();
            BadgesContent badges = new BadgesContent();
            _console.WriteLine("Please Enter the New Badge Number.");
            int badgeID = Convert.ToInt32(_console.ReadLine());
            badges.BadgeID = badgeID;
            _badgeRepo.AddBadgeToDirectory(badges);
        }
        private void EditBadge()
        {
            _console.Clear();

        }
        private void ListAllBadges()
        {
            _console.Clear();
            List<BadgesContent> listOfBadges = _badgeRepo.GetAllBadges();
            foreach(BadgesContent badges in listOfBadges)
            {
                DisplayBadges(badges);
            }
            _console.WriteLine("Press any key to continue...");
            _console.ReadKey();
        }
        private void DisplayBadges(BadgesContent badges)
        {
            _console.WriteLine($"Key \nBadge # \tDoor Access \n{badges.BadgeID} \t{//DoorID}");
        }
        private void SeedContent()
        {

        }
    }
}
