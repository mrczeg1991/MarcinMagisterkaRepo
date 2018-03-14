using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram.CheckScoreTools
{
    class ClusterPurity
    {    
        public double Operation(List<AntBranch> antBranches, List<string> nameList, int numberAnts)
        {
            double temp = 0;
            foreach(string name in nameList)
            {
                var test = antBranches.Select(a => a.Ants.Select(b => b.Points.StringData[0]).Where(d => d == name).Count()).ToList().Max();
                temp =temp+antBranches.Select(a => a.Ants.Select(b => b.Points.StringData[0]).Where(d => d ==name).Count()).ToList().Max();
            }
            double score = temp / numberAnts;
            return Math.Round(score,3);
        }
    }
}
