namespace Dp.AbstractFactory;

public interface IFighterFactory
{
    KarateAbstract GetKarateFighter(Belts belt);
    JiuJitsuAbstract GetJiuJitsuFighter(Belts belt);
}