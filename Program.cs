using System;
public interface IEnemy
{

    void Attack();
    void Defend();

}
public class Dragon : IEnemy
{
    public void Attack()
    {
        Console.WriteLine("dragon attack");
    }

    public void Defend()
    {
        Console.WriteLine("dragon Defend");
    }
}
public class Vampire : IEnemy
{
    public void Attack()
    {
        Console.WriteLine("Vampire  attack");
    }

    public void Defend()
    {
        Console.WriteLine("Vampire  Defend");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        IEnemy e1 = new Dragon();
        e1.Attack();
        e1.Defend();

        IEnemy e2 = new Vampire();
        e2.Attack();
        e2.Defend();
    }
}