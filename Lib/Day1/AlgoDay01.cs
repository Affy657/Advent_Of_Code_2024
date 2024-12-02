using Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lib.IAlgo;

namespace Lib
{
    public class AlgoDay01 : IAlgo
    {
        public DayAndBonus GetDayAndBonus() => new() { Day = 1, Bonus = true };

        public string Solve(string[] input, bool isBonus = false)
        {
            return "Day 1";
        }
    }
}
