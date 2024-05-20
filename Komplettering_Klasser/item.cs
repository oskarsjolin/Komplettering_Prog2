public class Item
{
    // Variabler
    public string Name { get; set; }
    public string Description { get; set; }
    public int Value { get; set; }

    
    public Item(string name, string description, int value)
    {
        Name = name;
        Description = description;
        Value = value;
    }

    // Metod
    public string GetDetails()
    {
        return $"{Name}: {Description} (Value: {Value})";
    }
}
