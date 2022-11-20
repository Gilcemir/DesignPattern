namespace Dp.AbstractFactory;

public class BrownBeltJiuJitsu: JiuJitsuAbstract
{
    public BrownBeltJiuJitsu()
    {
        _level = Belts.Brown.ToString();
    }

    public override void Takedowns()
    {
        int dmg = new Random().Next(61, 80);
        Console.WriteLine($"Takedown has {dmg} of effectiveness");
    }

    public override void Submissions()
    {
        int dmg = new Random().Next(61, 80);
        Console.WriteLine($"Submission has {dmg} of effectiveness");
    }
    
}