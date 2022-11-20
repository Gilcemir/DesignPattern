namespace Dp.AbstractFactory;

public class FighterFactory : IFighterFactory
{
    public KarateAbstract GetKarateFighter(Belts belt)
    {
        return new KarateFactoryConcrete().GetKarate(belt);
    }

    public JiuJitsuAbstract GetJiuJitsuFighter(Belts belt)
    {
        return new JiuJitsuFactoryConcrete().GetJiuJitsu(belt);
    }
    
}