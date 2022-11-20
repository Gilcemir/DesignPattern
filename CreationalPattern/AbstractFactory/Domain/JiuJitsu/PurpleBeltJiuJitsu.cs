namespace Dp.AbstractFactory;

public class PurpleBeltJiuJitsu : JiuJitsuAbstract
{
    public PurpleBeltJiuJitsu()
    {
        _level = Belts.Purple.ToString();
    }

    public override void Takedowns()
    {
        int dmg = new Random().Next(41, 60);
        Console.WriteLine($"Takedown has {dmg} of effectiveness");
    }

    public override void Submissions()
    {
        int dmg = new Random().Next(41, 60);
        Console.WriteLine($"Submission has {dmg} of effectiveness");
    }
}