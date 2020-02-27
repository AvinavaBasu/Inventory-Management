using System;

namespace Inventory_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to inventory management system!");
            double tatalExpenseIncurred=0;

            var expenseForLuxuaryTextiles = new InventoryExpenses();
            expenseForLuxuaryTextiles.TextileType = "Luxury";
            expenseForLuxuaryTextiles.TextileAmount = 1000;
            tatalExpenseIncurred+= expenseForLuxuaryTextiles.CalculateInventoryExpenses(expenseForLuxuaryTextiles); //1200

            var expenseForImportedTextiles = new InventoryExpenses();
            expenseForImportedTextiles.TextileType = "Imported";
            expenseForImportedTextiles.TextileAmount = 1500;
            tatalExpenseIncurred += expenseForLuxuaryTextiles.CalculateInventoryExpenses(expenseForImportedTextiles); //1650


            Console.WriteLine("Total expenses incurred textiles {0}", tatalExpenseIncurred); //2850
        }
    }
}
