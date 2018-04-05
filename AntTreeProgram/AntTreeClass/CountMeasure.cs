using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram
{
    class CountMeasure
    {
        public double MiejscaCount(List<double> first, List<double> second)
        {
            double score = 0;
            if (first.Count != second.Count) return 0;
            int i = 0;
            foreach(double digit in first)
            {
                double temp = Math.Abs(digit - second[i]);
                score += temp;
                i++;
            }
            score = 1 - (score / first.Count());
            return score;
        }
        public double EuklidesowaCount(List<double> first, List<double> second)
        {
            double score = 0;
            int i = 0;
            if (first.Count != second.Count) return 0;
            foreach (double digit in first)
            {
                double temp = Math.Pow(digit - second[i], 2);
                score += temp;
                i++;
            }
            score = 1 - Math.Sqrt(score / first.Count());
            return score;
        }
    }
}
