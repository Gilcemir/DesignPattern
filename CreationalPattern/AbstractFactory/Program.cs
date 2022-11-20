using Dp.AbstractFactory;

class Program
{
    static void Main(string[] args)
    {
        int total = 10;
        var factory = new FighterFactory();
        var jiuJitsu_fighters = new List<JiuJitsuAbstract>();
        var karate_fighters = new List<KarateAbstract>();

        for (int i = 0; i < total; i++)
        {
            var belt = (Belts)new Random().Next(0, 5);
            //add bjj fighter
            jiuJitsu_fighters.Add(factory.GetJiuJitsuFighter(belt));
            //add karate fighter
            karate_fighters.Add(factory.GetKarateFighter(belt));
        }

        Console.WriteLine("Jiu Jitsu fighters: \n ----------");
        foreach (var item in jiuJitsu_fighters)
        {
            item.Level();
            item.Submissions();
            item.Takedowns();
        }
        
        Console.WriteLine("Karate fighters: \n ----------");
        foreach (var item in karate_fighters)
        {
            item.Level();
            item.Kick();
            item.Punch();
            item.Kata();
        }

        Console.ReadKey();
    }
}