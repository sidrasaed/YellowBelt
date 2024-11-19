namespace YB_Kata5;

class Program
{
    static void Main(string[] args)
    {
        AttackEnemy(enemyName:"Goblin",damage:20);
        HealPlayer(playerName:"Arin",healAmount:15);
    }

    public static void AttackEnemy(string enemyName, int damage)
    {
        Console.WriteLine("Attacked {0} and dealt {1} damage!", enemyName , damage);
    }

    static void HealPlayer(string playerName, int healAmount)
    {
        Console.WriteLine("Player {0} healed {1} health points!", playerName, healAmount);
    }
}