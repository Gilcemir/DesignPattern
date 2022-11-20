namespace Dp.AbstractFactory;

public abstract class KarateAbstract : IFighter, IKarate
{
    protected string _level;
    protected string _martialArts = MartialArts.Karate.ToString();
    public void Level()
    {
        Console.WriteLine($"{_martialArts} : {_level} belt");
    }

    public abstract void Punch();


    public abstract void Kick();


    public abstract void Kata();
}