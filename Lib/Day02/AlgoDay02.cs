using Lib;
using static Lib.IAlgo;

namespace Lib
{
    public class AlgoDay02 : IAlgo
    {
        public DayAndBonus GetDayAndBonus() => new() { Day = 2, Bonus = true };

        public string Solve(string[] input, bool isBonus = false)
        {
            int numberOfSafeReport = 0;

            foreach (string line in input)
            {
                List<int> report = line
                    .Split(" ")
                    .Select(int.Parse)
                    .ToList();

                if (CheckReport(report))
                {
                    numberOfSafeReport++;
                }
                else if (isBonus)
                {
                    for (int i = 0; i < report.Count; i++)
                    {
                        List<int> newReport = new(report);
                        newReport.RemoveAt(i);

                        if ( CheckReport(newReport))
                        {
                            numberOfSafeReport++;
                            break;
                        }
                    }
                }
            }
            return numberOfSafeReport.ToString();
        }

        public bool AreDifferencesValid(List<int> report, bool isReversed = false)
        {
            return report.Zip(report.Skip(1), (a, b) => isReversed ? a - b : b - a)
                         .All(diff => diff >= 1 && diff <= 3);
        }

        public bool CheckReport(List<int> report)
        {
            bool isIncreasing = report.Zip(report.Skip(1), (a, b) => b > a).All(x => x);
            bool isDecreasing = report.Zip(report.Skip(1), (a, b) => b < a).All(x => x);

            if (isIncreasing)
            {
                if (AreDifferencesValid(report))
                    return true;
            }
            else if (isDecreasing)
            {
                if (AreDifferencesValid(report, isReversed: true))
                    return true;
            }
            return false;
        }
    }
}
