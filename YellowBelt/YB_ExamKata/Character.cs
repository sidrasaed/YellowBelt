namespace YB_ExamKata;

public class Character
{
    public interface IHealable
    {
        public void Heal(int amount);
    }

    public interface IDamageable
    {
        public void TakeDamage(int damage);
    }

    public interface ISpeakable
    {
        public void Speak();
    }
    public interface IExperienceGaining
    {
        public void GainExperience(int experience);
    }
    public interface ITradeable
    {
        public void Trade();
    }

    public class Player: IDamageable, IHealable,IExperienceGaining
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }

        public Player(string name, int health, int level, int experience)
        {
            this.Name = name;
            this.Health = health;
            this.Level = level;
            this.Experience = experience;
        }

        public void Attack()
        {
            Random random = new Random();
            int damage = random.Next(5, 10);
        }


       public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} takes damage {damage} damage. Remaining health: {Health}");
        }

        public void Heal(int amount)
        {
            Health += amount;
            Console.WriteLine($"{Name} heals {amount} amount. Current health:  {Health}.");
        }

        public void GainExperience(int experience)
        {
            Experience += experience;
            Console.WriteLine($"{Name} gains {experience} experience. Total experience: {Experience}");
        }
    }
    public class Enemy:IDamageable
    {
        public string Type{ get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public Enemy(string type, int health, int damage)
        {
            this.Type = type;
            this.Health = health;
            this.Damage = damage;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Type} takes damage {damage} damage. Remaining health: {Health}");
        }
    }
    public class NPC
    {
        public string Name { get; set; }
        public string Dialogue { get; set; }

        public NPC(string name, string dialogue)
        {
            this.Name = name;
            this.Dialogue = dialogue;
        }

        public void Speak()
        {
            Console.WriteLine($"{Name} says:  {Dialogue}");
        }
    }
    public class Merchant: ISpeakable,ITradeable
    {
        public string Name { get; set; }
        public string Inventory{ get; set; }

        public Merchant(string name, string inventory)
        {
            this.Name = name;
            this.Inventory = inventory;
        }

        public void Speak()
        {
            Console.WriteLine($"{Name} says: Ready to trade!");
        }

        public void Trade()
        {
            Console.WriteLine($"{Name} says: {Inventory}");
        }
    }
    
}