namespace Dp.AbstractFactory;

public class BlackBeltKarate: KarateAbstract
{
    public BlackBeltKarate()
    {
        _level = Belts.Black.ToString();
    }
    public override void Punch()
    {
        int dmg = new Random().Next(41, 50);
        Console.WriteLine($"Punch has {dmg} of damage");
    }

    public override void Kick()
    {
        int dmg = new Random().Next(81, 100);
        Console.WriteLine($"Kick has {dmg} of damage");
    }

    public override void Kata()
    {
        Console.WriteLine("This is a masterpiece!");
    }
    
}