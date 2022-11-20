namespace Dp.AbstractFactory;

public class JiuJitsuFactoryConcrete : JiuJitsuFactory
{
    public override JiuJitsuAbstract GetJiuJitsu(Belts belt)
    {
        return belt switch
        {
            Belts.White => new WhiteBeltJiuJitsu(),
            Belts.Blue => new BlueBeltJiuJitsu(),
            Belts.Purple => new PurpleBeltJiuJitsu(),
            Belts.Brown => new BrownBeltJiuJitsu(),
            Belts.Black => new BlackBeltJiuJitsu(),
            _ => throw new ArgumentOutOfRangeException(nameof(belt), belt, null)
        };
    }
}