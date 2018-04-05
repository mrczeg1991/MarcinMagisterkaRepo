using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram.CheckScoreTools
{
    class ClassificationError
    {
        public double Operation(List<Ant> ants)
        {
            double error = 0;
            double sum = 0;
            foreach(Ant ant in ants.OrderBy(s=>s.Number))
            {
                List<Ant> temp = ants.Where(a => a.Number != ant.Number).ToList();
                sum += temp.Count();
                error+=CountError(temp, ant);
            }
            double score = error / sum;
            return Math.Round(score, 3);
        }
        double CountError(List<Ant> ants, Ant ant)
        {
            double error = (from rekord in ants
                         where
    ((rekord.Points.StringData[0] == ant.Points.StringData[0] && rekord.Index != ant.Index) ||
    (rekord.Points.StringData[0] != ant.Points.StringData[0] && rekord.Index == ant.Index))
                         select rekord).Count();
            return error;

        }
    }
}

