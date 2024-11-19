namespace YB_MiniKata5;

class Program
{
    static void Main(string[] args)
    {
        Attack(10);
        Heal(healAmount:36);
    }
    static void Attack(int damage)
    {
        Console.WriteLine("Player dealt {0} damage!", damage);
    }

    static void Heal(int healAmount)
    {
        Console.WriteLine("Player healed {0} health points!", healAmount);
    }
}