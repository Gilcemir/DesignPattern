namespace Dp.AbstractFactory;

public class BlueBeltJiuJitsu : JiuJitsuAbstract
{
    public BlueBeltJiuJitsu()
    {
        _level = Belts.Blue.ToString();
    }

    public override void Takedowns()
    {
        int dmg = new Random().Next(21, 40);
        Console.WriteLine($"Takedown has {dmg} of effectiveness");
    }

    public override void Submissions()
    {
        int dmg = new Random().Next(21, 40);
        Console.WriteLine($"Submission has {dmg} of effectiveness");
    }
}
