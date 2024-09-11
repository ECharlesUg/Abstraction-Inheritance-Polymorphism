using static System.Net.Mime.MediaTypeNames;

public class Enemy : Character
{
    public Enemy(string name) : base(name, new Random().Next(20, 51), new Random().Next(3, 16), new Random().Next(0, 11), 0) { }
    public override void Attack(Character opponent)
    {
        Damage = Defense - opponent.Strength;
        opponent.Health = opponent.Health - Damage;
        if (opponent.Health < 0)
        {
            opponent.Health = 0;
        }
        Console.WriteLine("Damage is done");
    }
}