using System;

public abstract class Character
{
    public string Name;
    public int Health;
    public int Strength;
    public int Defense;
    public int Damage;
    // Your code here
    public abstract void Attack(Character opponent);
    public string DisplayStats()
    {
        return $"Character's Properties {Name}, {Health}, {Strength}, {Defense}";
    }
    public bool IsAlive()
    {
        if (Health > 0)
        {
            return true;
        }
        return false;
    }
    public string GetName()
    {
        return Name;
    }
    public Character(string Name, int Health, int Strength, int Defence, int Damage)
    {
        this.Name = Name;
        this.Health = Health;
        this.Strength = Strength;
        this.Defense = Defence;
        this.Damage = Damage;
    }
}
