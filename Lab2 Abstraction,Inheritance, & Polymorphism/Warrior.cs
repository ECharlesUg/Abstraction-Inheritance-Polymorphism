using static System.Net.Mime.MediaTypeNames;

public class Warrior : Character
{
    public Warrior(string name) : base(name, 100, 10, 5, 0) { }
    public override void Attack(Character opponent)
    {
        Damage = (Strength - opponent.Defense) + 2;
        opponent.Health = opponent.Health - Damage;
        if (opponent.Health < 0)
        {
            opponent.Health = 0;
        }
       Console.WriteLine("Damage is done");
    }
    public void Heal()
    {
        Health = Health + 10;
        Console.WriteLine("Warrior's Health +10");
    }
}