namespace Dp.AbstractFactory;

public abstract class KarateAbstract : IFighter, IKarate
{
    protected string _level;
    public void Level()
    {
        Console.WriteLine(_level);
    }

    public abstract void Punch();


    public abstract void Kick();


    public abstract void Kata();
}