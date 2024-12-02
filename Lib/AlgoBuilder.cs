

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
            new AlgoDay02()
        };
        return algos.FirstOrDefault(algo =>
        algo.GetDayAndBonus().Day == this.Day
        );

    }
}