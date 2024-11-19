namespace YB_Kata6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enemies:");
        string[] enemies = ["Goblin", "Orc", "Troll", "Skeleton", "Dragon"];

        foreach (string enemy in enemies)
        {
            Console.WriteLine(enemy);
        }
        Console.WriteLine("\nPlayer Inventory:");
        List<string> inventoryItems = new List<string> { "Sword", "Shield", "Potion" };
        foreach (string item in inventoryItems)
        {
            Console.WriteLine(item);
        }
        inventoryItems.Add("Helmet");
        inventoryItems.Add("Armor");
        inventoryItems.Remove("Potion");
        Console.WriteLine("\nUpdated Player Inventory:");
        foreach (string item in inventoryItems)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\nTotal Items in Inventory: {0}", inventoryItems.Count);
    }
}