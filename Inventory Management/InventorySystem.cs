namespace Inventory_Management
{
    public class InventorySystem
    {
        public double CalculateForImportedTextiles(int amount)
        {
            return 0.10 * amount + amount;
        }

        public double CalculateForLocalMerchandiseTextiles(int amount)
        {
            return 0.05 * amount + amount;
        }

        public double CalculateForLuxuaryBrands(int amount)
        {
            return 0.20 * amount + amount;
        }

    }
}
