using Inventory_Management;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectInvnetoryManagement
{
    [TestClass]
    public class IndividualExpenseTests
    {
        InventoryExpenses _inventoryExpenses;
        [TestInitialize]
        public void Setup()
        {
            _inventoryExpenses = new InventoryExpenses();
        }


        [TestMethod]
        public void WhenWeBuyImportedItem()
        {
            _inventoryExpenses.TextileType = "Imported";
            _inventoryExpenses.TextileAmount = 1500;
            var importTextileCostExpenses = _inventoryExpenses.CalculateInventoryExpenses(_inventoryExpenses);
            Assert.AreEqual(importTextileCostExpenses, 1650);
        }


        [TestMethod]
        public void WhenWeBuyLuxuryItem()
        {
            _inventoryExpenses.TextileType = "Luxury";
            _inventoryExpenses.TextileAmount = 1000;
            var importTextileCostExpenses = _inventoryExpenses.CalculateInventoryExpenses(_inventoryExpenses);
            Assert.AreEqual(importTextileCostExpenses, 1200);
        }
    }
}
