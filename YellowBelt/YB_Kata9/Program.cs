namespace YB_Kata9;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Arin", 15, 1);
        Enemy enemy = new Enemy("Goblin", 75, 5);
        NPC npc = new NPC("NPC", "Welcome to our village!");
        Merchant merchant = new Merchant("Merchant", "Sword, Shield, Potion");
        
        player.Attack("Goblin");
        enemy.TakeDamage(35);
        npc.Speak();
        merchant.Trade();
    }
    

    public class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }

        public Player(string name, int health, int level)
        {
            Name = name;
            Health = health;
            Level = level;
        }

        public void Attack(string enemy)
        {
            int damage = 20;
            Console.WriteLine($"{Name} attacks {enemy} and deals damage {damage}");
            
        }
    }

    public class Enemy
    {
           public string Type { get; set; }
           public int Health { get; set; }
           public int Damage { get; set; }

           public Enemy(string type, int health, int damage)
           {
               Type = type;
               Health = health;
               Damage = damage;
           }

           public void TakeDamage(int damage)
           {
               Health -= damage;
               Console.WriteLine($"{Type} takes {damage} damage. Remaining health: {Health}");
               
           }
    }
    public class NPC
    {
        public string Name { get; set; }
        public string Dialogue { get; set; }

        public NPC(string name, string dialogue)
        {
            Name = name;
            Dialogue = dialogue;
        }
        public void Speak()
        {
            Console.WriteLine($"{Name} says: {Dialogue}");
        }
    }

    public class Merchant
    {
        public string Name { get; set; }
        public string Inventory { get; set; }

        public Merchant(string name, String inventory)
        {
            Name = name;
            Inventory = inventory;
        }

        public void Trade()
        {
            Console.WriteLine($"{Name}'s inventory: {Inventory}");
        }
    }
}
