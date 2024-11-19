namespace YB_Kata7;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Arin", 25, 1, 22, 12);
        Enemy enemy = new Enemy("Orc", 50);
        
        player.Attack(35);
        enemy.TakeDamage(22);
        player.GainExperience(50);
    }
    public class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Damage { get; set; }

        public Player(string name, int health, int level, int experience, int damage)
        {
            this.Name = name;
            this.Health = health;
            this.Level = level;
            this.Experience = experience;
            this.Damage = damage;
        }
        public void Attack(int damage)
        {
            Damage += damage;
            Console.WriteLine($"{Name} attacks and deals {damage} damage");
        }

        public void GainExperience(int experience)
        {
            Experience += experience;
            Console.WriteLine($"{Name} gained {experience} experience.");
        }
    }

    public class Enemy
    {
        public string Type { get; set; }
        public int Health { get; set; }

        public Enemy(string type, int health)
        {
            this.Type = type;
            this.Health = health;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Type} takes {damage} damage. Remaining health: {Health}");
        }
    }
}