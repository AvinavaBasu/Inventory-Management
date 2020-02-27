namespace Inventory_Management
{
    public class InventoryExpenses
    {
        public string TextileType { get; set; }
        public int TextileAmount { get; set; }

        InventorySystem _inventorySystem;
        public InventoryExpenses()
        {
            _inventorySystem = new InventorySystem();
        }
        public double CalculateInventoryExpenses(InventoryExpenses inventoryExpenses)
        {
            double totlaCost;
            if (inventoryExpenses.TextileType == "Imported")
                totlaCost=_inventorySystem.CalculateForImportedTextiles(inventoryExpenses.TextileAmount);
           else if (inventoryExpenses.TextileType == "Local")
                totlaCost=_inventorySystem.CalculateForLocalMerchandiseTextiles(inventoryExpenses.TextileAmount); 
            else
                totlaCost=_inventorySystem.CalculateForLuxuaryBrands(inventoryExpenses.TextileAmount);
            return totlaCost;
        } 

    }
}
