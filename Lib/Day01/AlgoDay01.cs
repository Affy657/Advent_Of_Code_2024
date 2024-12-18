﻿using static Lib.IAlgo;

namespace Lib
{
    public class AlgoDay01 : IAlgo
    {
        private const string separator = "   ";
        public DayAndBonus GetDayAndBonus() => new() { Day = 1 };

        public string Solve(string[] input, bool isBonus = false)
        {
            List<int> leftList = [];
            List<int> rightList = [];

            foreach (string line in input)
            {
                var parts = line.Split(separator);
                leftList.Add(int.Parse(parts[0]));
                rightList.Add(int.Parse(parts[1]));
            }

            leftList.Sort();
            rightList.Sort();

            if (isBonus)
            {
                return findSimilarity(leftList, rightList);
            }
            else
            {
                return findDistances(leftList, rightList);
            }
        }
        public string findDistances(List<int> leftList, List<int> rightList)
        {
            int distances = 0;
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
        public string findSimilarity(List<int> leftList, List<int> rightList)
        {
            int similarity = 0;
            for (int i = 0; i < leftList.Count; i++)
            {
                int target = leftList[i];
                similarity += target * rightList.Count(n => n == target);
            }
            return similarity.ToString();
        }
    }
}
