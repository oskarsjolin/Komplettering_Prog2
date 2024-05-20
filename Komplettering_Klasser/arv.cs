public abstract class arv
{
    // Variabler
    public int Health { get; set; }
    public int MaxHealth { get; set; }

    
    public arv(int health, int maxHealth)
    {
        Health = health;
        MaxHealth = maxHealth;
    }

    // Metod för att ta skada
    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;
    }

    // Metod för att heala
    public void Heal(int amount)
    {
        Health += amount;
        if (Health > MaxHealth) Health = MaxHealth;
    }

    // Metod för att kolla om den lever
    public bool IsAlive()
    {
        return Health > 0;
    }
}
