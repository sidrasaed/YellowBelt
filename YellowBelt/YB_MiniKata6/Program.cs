namespace YB_MiniKata6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enemies:");
        string[] enemies = ["Goblin", "Orc", "Troll"];
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
        Console.WriteLine("\nUpdated Inventory:");
        inventoryItems.Add("Helmet");
        foreach (string item in inventoryItems)
        {
            Console.WriteLine(item);
        }
    }
}