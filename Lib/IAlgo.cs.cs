namespace Lib;

public interface IAlgo
{
    string Solve(string[] input, bool isBonus = false);
    DayAndBonus GetDayAndBonus();

    public class DayAndBonus
    {
        public int Day { get; set; }
        public bool Bonus { get; set; }
    }
}