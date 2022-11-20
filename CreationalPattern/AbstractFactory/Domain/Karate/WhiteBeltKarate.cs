namespace Dp.AbstractFactory;

public class WhiteBeltKarate : KarateAbstract
{
    public WhiteBeltKarate()
    {
        _level = Belts.White.ToString();
    }
    public override void Punch()
    {
        int dmg = new Random().Next(0, 10);
        Console.WriteLine($"Punch has {dmg} of damage");
    }

    public override void Kick()
    {
        int dmg = new Random().Next(0, 20);
        Console.WriteLine($"Kick has {dmg} of damage");
    }

    public override void Kata()
    {
        Console.WriteLine("You need to practice!");
    }
}