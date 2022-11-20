namespace Dp.AbstractFactory;

public class WhiteBeltJiuJitsu : JiuJitsuAbstract
{
    public WhiteBeltJiuJitsu()
    {
        _level = Belts.White.ToString();
    }

    public override void Takedowns()
    {
        int dmg = new Random().Next(0, 20);
        Console.WriteLine($"Takedown has {dmg} of effectiveness");
    }

    public override void Submissions()
    {
        int dmg = new Random().Next(0, 20);
        Console.WriteLine($"Submission has {dmg} of effectiveness");
    }
}