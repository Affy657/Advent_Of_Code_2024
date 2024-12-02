using static Lib.IAlgo;

namespace Lib
{
    public class AlgoDay01 : IAlgo
    {
        private const string separator = "   ";
        public DayAndBonus GetDayAndBonus() => new() { Day = 1, Bonus = true };

        public string Solve(string[] input, bool isBonus = false)
        {
            List<int> leftList = [];
            List<int> rightList = [];
            int distances = 0;

            foreach (string line in input)
            {
                var parts = line.Split(separator);
                leftList.Add(int.Parse(parts[0]));
                rightList.Add(int.Parse(parts[1]));
            }

            leftList.Sort();
            rightList.Sort();
           
            for (int i = 0; i < leftList.Count; i++)
            {
                var distance = rightList[i] - leftList[i];
                if (distance < 0)
                    {
                    distance = leftList[i] - rightList[i];
                }
                distances += distance;      
            }

            return distances.ToString();
        }
    }
}
