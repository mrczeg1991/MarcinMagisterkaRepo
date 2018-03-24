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
            double sum = 0;
            foreach(List<Ant> ants in antBranches.Select(b=>b.Ants))
            {
                double max = 0;
                foreach (string name in nameList)
                {
                    double temp = ants.Where(b=>b.Points.StringData[0] == name).Select(a => a).Count();
                    if(temp>max)
                    {
                        max = temp;
                    }
                }
                sum = max + sum;
            }
            return Math.Round(sum/numberAnts,3);
        }
    }
}
