namespace YB_MiniKata7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Player Info:");
        
        Player player = new Player
        {
            Name = "Arin",
            Health = 100,
            Level = 1
        };
        Console.WriteLine("Name: {0}",player.Name);
        Console.WriteLine("Health: {0}",player.Health);
        Console.WriteLine("Level: {0}",player.Level);
        
        Console.WriteLine("\nEnemy Info:");
        Enemy enemy = new Enemy
        {
            Type = "Goblin",
            Health = 50,
            Damage = 10
        };
        
        Console.WriteLine("Type: {0}", enemy.Type);
        Console.WriteLine("Health: {0}",enemy.Health);
        Console.WriteLine("Damage: {0}", enemy.Damage);

    }
    public class Player
    {
        public string Name{get;set;}
        public int Health{get;set;}
        public int Level{get;set;}
    }

    public class Enemy
    {
        public string Type{get;set;}
        public int Health{get;set;}
        public int Damage{get;set;}
    }
}