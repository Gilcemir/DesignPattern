namespace Dp.AbstractFactory;

public abstract class JiuJitsuAbstract : IFighter, IJiuJitsu
{
    protected string _level;
    
    public void Level()
    {
        Console.WriteLine(_level);
    }

    public abstract void Takedowns();


    public abstract void Submissions();

}