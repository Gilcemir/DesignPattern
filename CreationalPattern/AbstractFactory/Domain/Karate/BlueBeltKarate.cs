namespace Dp.AbstractFactory;

public class BlueBeltKarate: KarateAbstract
{
    public BlueBeltKarate()
    {
        _level = Belts.Blue.ToString();
    }
    public override void Punch()
    {
        int dmg = new Random().Next(11, 20);
        Console.WriteLine($"Punch has {dmg} of damage");
    }

    public override void Kick()
    {
        int dmg = new Random().Next(21, 40);
        Console.WriteLine($"Kick has {dmg} of damage");
    }

    public override void Kata()
    {
        Console.WriteLine("Improving! Keep it up!");
    }
    
}