using System;
using System.Collections.Generic;

public class Player : arv
{
    // Variabler
    public string Name { get; set; }
    public List<Item> Inventory { get; set; }

    
    public Player(string name, int health, int maxHealth) : base(health, maxHealth)
    {
        Name = name;
        Inventory = new List<Item>();
    }

    // Metoder
    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    public void RemoveItem(Item item)
    {
        Inventory.Remove(item);
    }

    public void ListInventory()
    {
        Console.WriteLine($"{Name}'s Inventory:");
        foreach (var item in Inventory)
        {
            Console.WriteLine(item.GetDetails());
        }
    }
}
