using static Lib.IAlgo;

namespace Lib
{
    internal class AlgoDay05 : IAlgo
    {
        public DayAndBonus GetDayAndBonus() => new() { Day = 5 };

        public string Solve(string[] input, bool isBonus = false)
        {
            /*input: 47|53
                    97 | 13
                    97 | 61
                    97 | 47
                    75 | 29
                    61 | 13
                    75 | 53
                    29 | 13
                    97 | 29
                    53 | 29
                    61 | 53
                    97 | 53
                    61 | 29
                    47 | 13
                    75 | 47
                    97 | 75
                    47 | 61
                    75 | 61
                    47 | 29
                    75 | 13
                    53 | 13

                    75,47,61,53,29
                    97,61,53,29,13
                    75,29,13
                    75,97,47,61,53
                    61,13,29
                    97,13,75,29,47 */
            List<List<int>> orderingRules = new();
            List<List<int>> manualPages = new();

            int X = 0;
            int Y = 0;
            bool isOrderingRules = true;
            foreach (string line in input)
            {
                if (string.IsNullOrEmpty(line))
                {
                    isOrderingRules = false;
                }
                if (isOrderingRules)
                {
                    string[] rules = line.Split('|');
                    X = int.Parse(rules[0].Trim());
                    Y = int.Parse(rules[1].Trim());
                    orderingRules.Add(new List<int> { X, Y });     
                }
                else {
                    string[] pages = line.Split(',');
                    manualPages.Add(pages
                        .Select(page => int.Parse(page.Trim()))
                        .ToList());
                }
            }


            return orderingRules.ToString();
        }
    }
}

