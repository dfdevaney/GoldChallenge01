using ChallengeOne.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.UI_01
{
    public class ProgramUI
    {
        private readonly IConsole _console;
        private readonly MenuRepository _menuRepo = new MenuRepository();
        public ProgramUI(IConsole console)
        {
            _console = console;
        }
        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                _console.Clear();
                _console.WriteLine("Enter the number of the option you'd like to select: \n" +
                    "1) Add New Menu Item \n" +
                    "2) Remove Menu Item \n" +
                    "3) Show All Items on Menu \n" +
                    "4) Exit");
                string userInput = _console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //Add New Menu Item
                        CreateNewMenuItem();
                        break;
                    case "2":
                        //Remove Menu Item
                        RemoveMenuItem();
                        break;
                    case "3":
                        //Show All Menu Items
                        ShowAllMenuItems();
                        break;
                    case "4":
                        //Exit
                        continueToRun = false;
                        break;
                    default:
                        //default
                        _console.WriteLine("Please enter a valid number between 1 and 3. \n" +
                            "Press any key to continue......");
                        _console.ReadKey();
                        break;
                }
            }

        }
        private void CreateNewMenuItem()
        {
            MenuItem item = new MenuItem();
            _console.WriteLine("Please enter the Name of the new Menu Item");
            string itemName = _console.ReadLine();
            item.Name = itemName;
            _console.WriteLine($"Please enter the description for {item.Name}");
            item.Description = _console.ReadLine();
            _console.WriteLine($"Enter a new price for {item.Name}");
            item.Price = int.Parse(_console.ReadLine());
            _menuRepo.AddItemMenu(item);
        }
        private void ShowAllMenuItems()
        {
            _console.Clear();
            List<MenuItem> listOfContent = _menuRepo.GetMenuItems();
            foreach (MenuItem content in listOfContent)
            {
                DisplaySimple(content);
            }
            _console.WriteLine("Press any key to continue....");
            _console.ReadKey();
        }
        private void RemoveMenuItem()
        {
            MenuItem item = new MenuItem();
            _console.WriteLine("Which item would you like to remove?");
            List<MenuItem> itemList = _menuRepo.GetMenuItems();
            int count = 0;
            foreach (var content in itemList)
            {
                count++;
                _console.WriteLine($"{count}) {item.Name}");
            }
            int targetContentID = int.Parse(_console.ReadLine());
            int correctIndex = targetContentID - 1;
            if (correctIndex >= 0 && correctIndex < itemList.Count)
            {
                MenuItem desiredContent = itemList[correctIndex];
                if (_menuRepo.DeleteExistingItem(desiredContent))
                {
                    _console.WriteLine($"{desiredContent.Name} successfully removed!");
                }
                else
                {
                    _console.WriteLine("I'm sorry, that cannot currently be completed.");
                }
            }
            else
            {
                _console.WriteLine("INVALID OPTION");
            }
            _console.WriteLine("Press any key to continue....");
            _console.ReadKey();
        }
        private void DisplaySimple(MenuItem content)
        {
            _console.WriteLine($"{content.Name} \n" +
                    $"{content.Description} \n" +
                    $"-----------------------");
        }
    }
}
