namespace Dp.AbstractFactory;

public class KarateFactoryConcrete : KarateFactory
{
    public override KarateAbstract GetKarate(Belts belt)
    {
        return belt switch
        {
            Belts.White => new WhiteBeltKarate(),
            Belts.Blue => new BlueBeltKarate(),
            Belts.Purple => new PurpleBeltKarate(),
            Belts.Brown => new BrownBeltKarate(),
            Belts.Black => new BlackBeltKarate(),
            _ => throw new ArgumentOutOfRangeException(nameof(belt), belt, null)
        };
    }
}