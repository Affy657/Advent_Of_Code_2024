using Lib;
using System.Text.RegularExpressions;
using static Lib.IAlgo;

namespace Lib
{
    public class AlgoDay03 : IAlgo
    {
        public const string PATTERN_MUL = @"mul\((\d{1,3}),(\d{1,3})\)";
        public const string PATTERN_DO = @"\bdo\(\)";
        public const string PATTERN_DONT = @"\bdon't\(\)";
        public const string PATTERN_ALL_INSTRUCTIONS = @"mul\((\d{1,3}),(\d{1,3})\)|do\(\)|don't\(\)";
        public DayAndBonus GetDayAndBonus() => new() { Day = 3 };

        public string Solve(string[] input, bool isBonus = false)
        {
            // input : xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))
            // output : 48
            int sumOfMul = 0;
            bool doMul = true;

            foreach (string line in input)
            {
                MatchCollection matches = Regex.Matches(line,isBonus ? PATTERN_ALL_INSTRUCTIONS : PATTERN_MUL);

                foreach (Match match in matches)
                {
                    if (Regex.IsMatch(match.Value, PATTERN_DO) && isBonus)
                    {
                        doMul = true;
                    }
                    else if (Regex.IsMatch(match.Value, PATTERN_DONT) && isBonus)
                    {
                        doMul = false;
                    }
                    else if (Regex.IsMatch(match.Value, PATTERN_MUL) && doMul)
                    {
                        sumOfMul += Multiply(match);    
                    }
                }
            }
            return sumOfMul.ToString();
        }

        public int Multiply(Match match)
        {
            int x = int.Parse(match.Groups[1].Value);
            int y = int.Parse(match.Groups[2].Value);
            return x * y;
        }
    }
}
