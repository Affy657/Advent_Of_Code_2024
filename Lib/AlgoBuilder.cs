namespace Lib;

public class AlgoBuilder
{
    public int Day { get; set; }
    public bool Bonus { get; set; }
    public AlgoBuilder( int day, bool bonus)
    {
        this.Day = day;
        Bonus = bonus;
    }

    public IAlgo Build()
    {
        List<IAlgo> algos = new()
        {
            new AlgoDay01(),
            new AlgoDay02(),
            new AlgoDay03(),
            new AlgoDay04(),
            new AlgoDay05(),
            new AlgoDay06()/*,
            new AlgoDay07(),
            new AlgoDay08(),
            new AlgoDay09(),
            new AlgoDay10(),
            new AlgoDay11(),
            new AlgoDay12(),
            new AlgoDay13(),
            new AlgoDay14(),
            new AlgoDay15(),
            new AlgoDay16(),
            new AlgoDay17(),
            new AlgoDay18(),
            new AlgoDay19(),
            new AlgoDay20(),
            new AlgoDay21(),
            new AlgoDay22(),
            new AlgoDay23(),
            new AlgoDay24(),
            new AlgoDay25()*/
        };
        return algos.FirstOrDefault(algo =>
               algo.GetDayAndBonus().Day == this.Day
        );

    }
}