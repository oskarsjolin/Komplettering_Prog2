using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Skapa en spelare med namn, hälsa och maxhälsa
        Player player = new Player("Oskar", 100, 150);

        // Skapa föremål. vapen och sljöld
        Item sword = new Item("Svärd", "Ett vasst svärd", 100);
        Item shield = new Item("Skjöld", "En stark skjöld", 150);

        // Lägg till föremålen till spelarens inventory
        player.AddItem(sword);
        player.AddItem(shield);

        // Lista spelarens inventoryy
        player.ListInventory();

        // Ta skada och visa spelarens liv
        player.TakeDamage(20);
        Console.WriteLine($"{player.Name} har {player.Health}/{player.MaxHealth} liv.");

        // Heala spelaren och visa spelarens liv
        player.Heal(10);
        Console.WriteLine($"{player.Name} har {player.Health}/{player.MaxHealth} liv.");

        // Ta bort svärdet
        player.RemoveItem(sword);

        // Lista spelarens inventory igen efter det är borttaget
        player.ListInventory();
    }
}
