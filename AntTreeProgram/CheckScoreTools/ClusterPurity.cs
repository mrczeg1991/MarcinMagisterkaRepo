using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram.CheckScoreTools
{
    class ClusterPurity
    {
        List<AntBranch> antBranches;
        public int Score { get; set; }
        public ClusterPurity(List<AntBranch> antBranches, List<string> nameList, int numberAnts)
        {
            Operation(antBranches, nameList, numberAnts);
        }
        void Operation(List<AntBranch> antBranches, List<string> nameList, int numberAnts)
        {
            int temp = 0;
            foreach(string name in nameList)
            {
                var dd = antBranches.Select(a => a.Ants.Select(b => b.Points.StringData[0]).Where(d => d == name).Count()).ToList();
                temp =temp+antBranches.Select(a => a.Ants.Select(b => b.Points.StringData[0]).Where(d => d ==name).Count()).ToList().Max();
            }
            var ds = antBranches.Select(a => a.Ants.Select(b=>b)).ToList();
            Score = temp / numberAnts;
        }
    }
}
