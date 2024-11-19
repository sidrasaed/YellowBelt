namespace YB_Kata8;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Arin", 25, 1, 22, 12);
        Enemy enemy = new Enemy("Orc", 50);
        
        player.GainExperience(50);
        player.GainExperience(76);
        player.GainExperience(16);
    }
    public class Player
    {
        public string Name { get; set; }
        private int health;
        private int level;
        private int experience; 
        public int Damage { get; set; }

        public int Health
        {
            get { return health;}
            set{health = value;}
        }

        public int Experience
        {
            get { return experience;}
            set
            {
                if (value < 0)
                {
                    experience = 0;
                    Console.WriteLine("Experience cannot be negative. Setting experience to 0.");
                }
                else
                {
                    experience = value; 
                }
                
            }
        }

        public int Level
        {
            get {return level; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Level cannot be negative. Setting level to 0.");
                }
                else
                {
                    level = value;
                }
                
            }
        }

        public Player(string name, int health, int level, int experience, int damage)
        {
            this.Name = name;
            this.Health = health;
            this.Level = level;
            this.Experience = experience;
            this.Damage = damage;
        }

        private void LevelUp()
        {
            this.Level++;
            experience = 0;
            Console.WriteLine($"Congratulations! You leveled up to Level {Level}.");
        }
        public void Attack(int damage)
        {
            Damage += damage;
            Console.WriteLine($"{Name} attacks and deals {damage} damage");
        }

        public void GainExperience(int experience)
        {
            Experience += experience;
            Console.WriteLine($"{Name} gained {experience} experience. Total Experience: {Experience}");
            if (Experience >= 100)
            {
                LevelUp();
            }
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