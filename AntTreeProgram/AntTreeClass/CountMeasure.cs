using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram
{
    class CountMeasure
    {
        List<double> firstDoule = null;
        List<double> secondDouble = null;
        List<string> firstString = null;
        List<string> secondString = null;
        public bool CountString { get; set; } = true;
        public CountMeasure(Points first, Points second)
        {
            this.firstDoule = first.DigitData;
            this.secondDouble = second.DigitData;
            this.firstString = first.StringData;
            this.secondString = second.StringData;
        }
        public double MiejscaCount()
        {
            double score = 0;
            if (firstDoule.Count != secondDouble.Count) return 0;
            int i = 0;
            foreach(double digit in firstDoule)
            {
                score += Math.Abs(digit - secondDouble[i]);
                i++;
            }
            if (CountString) score += CountStringData();
            score = 1 - (score / (firstDoule.Count() + (CountString ? 2 : 0)));
            return score;
        }
        public double EuklidesowaCount()
        {
            double score = 0;
            int i = 0;
            if (firstDoule.Count != secondDouble.Count) return 0;
            foreach (double digit in firstDoule)
            {
                score += Math.Pow(digit - secondDouble[i], 2);
                i++;
            }
            if(CountString)score += CountStringData();
            score = 1 - Math.Sqrt(score / (firstDoule.Count() + (CountString ? 2 : 0)));
            return score;
        }
        public double CosinusowaCount()
        {
            double score = 0;
            double scoreFirst = 0;
            double scoreSecond = 0;
            int i = 0;
            if (firstDoule.Count != secondDouble.Count) return 0;
            foreach (double digit in firstDoule)
            {
                score += digit * secondDouble[i];
                scoreFirst += Math.Pow(digit, 2);
                scoreSecond += Math.Pow(secondDouble[i], 2);
                i++;
            }
            if (CountString) score += CountStringData();
            score = score/(Math.Sqrt(scoreFirst)+Math.Sqrt(scoreSecond)+ (CountString ? 2 : 0));
            return score;
        }
        double CountStringData()
        {
            double score = 0;
            int i = 0;
            foreach (string temp in firstString)
            {
                if (temp != secondString[i]) score=score + 2;
                i++;
            }
            return score;
        }
    }
}
