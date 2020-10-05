using System;
using ChallengeOne.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.@for.Challenge.One
{
    [TestClass]
    public class MenuItemRepositoryTests
    {
        private MenuItemRepository _repo;
        private MenuItem _item;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new MenuItemRepository();
            _item = new MenuItem();
            _repo.AddItemMenu(_item);
        }

        [TestMethod]
        public void AddToMenu_ShouldGetCorrectBoolean()
        {
            // Arrange

            MenuItem item = new MenuItem();
            MenuItemRepository repository = new MenuItemRepository();

            // Act

            bool addResult = repository.AddItemMenu(item);

            // Assert

            Assert.IsTrue(addResult);
        }
        [TestMethod]
        public void UpdateExistingMenu_ShouldReturnTrue()
        {
            // Arrange

            MenuItem updateItem = new MenuItem("Cheeseburger", "A Tasty Burger, now with Cheese", 8);

            // Act

            bool updateResult = _repo.UpdateExistingItem("Hamburger", updateItem);

            // Assert

            Assert.IsTrue(updateResult);
        }
        [TestMethod]
        public void DeleteExistingItem_ShouldBeTrue()
        {
            // Arrange

            MenuItem foundItem = _repo.GetItemByName("Hamburger");

            // Act

            bool removeResult = _repo.DeleteExistingItem(foundItem);

            // Assert

            Assert.IsTrue(removeResult);
        }
    }
}
