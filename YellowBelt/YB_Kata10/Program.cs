namespace YB_Kata10;

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
        merchant.Speak();
        merchant.Trade();
    }
    public interface IDamageable
    {
        void TakeDamage(int damage);
    }
    public interface ISpeak
    {
        void Speak();
    }


    public class Player : IDamageable
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

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} takes {damage} damage. Remaining health: {Health}");
        }
    }

    public class Enemy: IDamageable
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
    public class NPC:ISpeak
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

    public class Merchant:ISpeak
    {
        public string Name { get; set; }
        public string Inventory { get; set; }

        public Merchant(string name, String inventory)
        {
            Name = name;
            Inventory = inventory;
        }

        public void Speak()
        {
            Console.WriteLine($"{Name} says: Ready to trade!");
        }

        public void Trade()
        {
            Console.WriteLine($"{Name}'s inventory: {Inventory}");
        }
    }
}
