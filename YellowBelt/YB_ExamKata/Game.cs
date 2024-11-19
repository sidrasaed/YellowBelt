namespace YB_ExamKata;

public class Game
{
    private Character.Player player;
    private Random random;

    public Game()
    {
        random = new Random();
    }

    public void Run()
    {
        Console.WriteLine("Enter your name: ");
        string playerName = Console.ReadLine();
        
        player= new Character.Player(playerName,75,1,35);
        Console.WriteLine($"Welcome {playerName}!, Your adventure begins.");

        while (player.Health>0)
        {
            Encounter();
        }
        Console.WriteLine("Game Over! Your health has reached zero.");
    }

    private void Encounter()
    {
        int encounterType = random.Next(1,4);

        if (encounterType == 1)
        {
            EncounterEnemy();
        }
        else if (encounterType == 2)
        {
            EncounterNPC();
        }
        else
        {
            EncounterMerchant();
        }
    }

    private void EncounterEnemy()
    {
        Character.Enemy enemy = new Character.Enemy("Goblin", 30, 5);
        Console.WriteLine($"A wild {enemy.Type} appears with {enemy.Health} health and {enemy.Damage} damage.");

        PlayerTurn(enemy);
    }

    private void EncounterNPC()
    {
        Character.NPC npc= new Character.NPC("Villager","Welcome to our Village");
        Console.WriteLine($"You encounter a {npc.Name}.");
        npc.Speak();
    }

    private void EncounterMerchant()
    {
        Character.Merchant merchant = new Character.Merchant("Merchant","Available items: Sword, Shield, Potion");
        merchant.Speak();
        merchant.Trade();
    }

    public void PlayerTurn(Character.Enemy enemy)
    {
        while (player.Health>0 && enemy.Health>0)
        {
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");
            string action = Console.ReadLine();

            if (action == "1")
            {
                player.Attack();
                enemy.TakeDamage(20);
                if (enemy.Health <= 0)
                {
                    Console.WriteLine($"{enemy.Type} is defeated!");
                    break;
                }
                Console.WriteLine($"The {enemy.Type} attacks {player.Name} for {enemy.Damage} damage.");
                player.TakeDamage(35);
                
            }
            else if (action == "2")
            {
                player.Heal(25);
            }
            else
            {
                Console.WriteLine("Invalid action.");
            }
            if (player.Health <= 0)
            {
                Console.WriteLine($"{player.Name} has been defeated!");
                break;
            }
        }
    }
}