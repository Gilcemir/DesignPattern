namespace Dp.AbstractFactory;

public class BlackBeltJiuJitsu: JiuJitsuAbstract
{
    public BlackBeltJiuJitsu()
    {
        _level = Belts.Brown.ToString();
    }

    public override void Takedowns()
    {
        int dmg = new Random().Next(81, 100);
        Console.WriteLine($"Takedown has {dmg} of effectiveness");
    }

    public override void Submissions()
    {
        int dmg = new Random().Next(81, 100);
        Console.WriteLine($"Submission has {dmg} of effectiveness");
    }
    
}