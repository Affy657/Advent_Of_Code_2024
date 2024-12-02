using Lib;
using static Lib.IAlgo;

namespace Lib
{
    public class AlgoDay02 : IAlgo
    {
        public DayAndBonus GetDayAndBonus() => new() { Day = 2, Bonus = true };

        public string Solve(string[] input, bool isBonus = false)
        {
          /* input :
            7 6 4 2 1
            1 2 7 8 9
            9 7 6 2 1
            1 3 2 4 5
            8 6 4 4 1
            1 3 6 7 9
            */
            int numberOfSafeReport = 0;

            foreach (string line in input)
            {
                List<int> report = line
                    .Split(" ")
                    .Select(int.Parse)
                    .ToList();

                bool isIncreasing = report.Zip(report.Skip(1), (a, b) => b > a).All(x => x);
                bool isDecreasing = report.Zip(report.Skip(1), (a, b) => b < a).All(x => x);

                if (isIncreasing)
                {
                    bool areDifferencesValid = report.Zip(report.Skip(1), (a, b) => b - a)
                                          .All(diff => diff >= 1 && diff <= 3);
                    if (areDifferencesValid)
                    numberOfSafeReport++;
                }
                else if (isDecreasing)
                {
                    bool areDifferencesValid = report.Zip(report.Skip(1), (a, b) => a - b)
                                          .All(diff => diff >= 1 && diff <= 3);
                    if (areDifferencesValid)
                    numberOfSafeReport++;
                }

            }
            return numberOfSafeReport.ToString();
        }
    }
}
