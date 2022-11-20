namespace Dp.AbstractFactory;

public abstract class JiuJitsuAbstract : IFighter, IJiuJitsu
{
    protected string _level;
    protected string _martialArts = MartialArts.JiuJitsu.ToString();
    
    public void Level()
    {
        Console.WriteLine($"{_martialArts} : {_level} belt");
    }

    public abstract void Takedowns();


    public abstract void Submissions();

}