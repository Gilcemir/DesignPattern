namespace Dp.AbstractFactory;

public class PurpleBeltKarate: KarateAbstract
{
    public PurpleBeltKarate()
    {
        _level = Belts.Purple.ToString();
    }
    public override void Punch()
    {
        int dmg = new Random().Next(21, 30);
        Console.WriteLine($"Punch has {dmg} of damage");
    }

    public override void Kick()
    {
        int dmg = new Random().Next(41, 60);
        Console.WriteLine($"Kick has {dmg} of damage");
    }

    public override void Kata()
    {
        Console.WriteLine("Not bad at all!");
    }
    
}