using Lib;
using System.Text.RegularExpressions;
using static Lib.IAlgo;

namespace Lib
{
    public class AlgoDay03 : IAlgo
    {
        public const string PATTERN = @"mul\((\d{1,3}),(\d{1,3})\)";
        public DayAndBonus GetDayAndBonus() => new() { Day = 3 };

        public string Solve(string[] input, bool isBonus = false)
        {
            // input : xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))
            // output : 161
            int sumOfMul = 0;

            foreach (string line in input)
            {
                MatchCollection matches = Regex.Matches(line, PATTERN);

                foreach (Match match in matches)
                {
                    int x = int.Parse(match.Groups[1].Value);
                    int y = int.Parse(match.Groups[2].Value);
                    sumOfMul += x * y;
                }
            }
            return sumOfMul.ToString();
        }
    }
}
