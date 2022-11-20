namespace Dp.AbstractFactory;

public class BrownBeltKarate: KarateAbstract
{
    public BrownBeltKarate()
    {
        _level = Belts.Brown.ToString();
    }
    public override void Punch()
    {
        int dmg = new Random().Next(31, 40);
        Console.WriteLine($"Punch has {dmg} of damage");
    }

    public override void Kick()
    {
        int dmg = new Random().Next(61, 80);
        Console.WriteLine($"Kick has {dmg} of damage");
    }

    public override void Kata()
    {
        Console.WriteLine("Good Work!");
    }
    
}