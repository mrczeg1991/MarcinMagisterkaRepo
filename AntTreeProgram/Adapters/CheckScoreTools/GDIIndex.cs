using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram.CheckScoreTools
{
    class GDIIndex
    {
        public double GDIIndexValue { get; set; }
        public DunnIndex Dunn { get; set; } = new DunnIndex();
        AntTree antTree = new AntTree();
        public double CountGDIIndex(List<AntBranch> antBranches)
        {
            double score = 0;
            if (antBranches.Count() > 1)
            {
                List<double> antsSim = new List<double>();
                List<double> antsSimInBranch = new List<double>();
                foreach (AntBranch branch in antBranches)
                {
                    double simInBranch = 0;
                    Dictionary<int, double> tempSim = new Dictionary<int, double>();
                    foreach (AntBranch branchTemp in antBranches.Where(d => d.Index != branch.Index))
                    {
                        tempSim.Add(branchTemp.Index, 0);
                    }
                    foreach (Ant ant in branch.Ants)
                    {
                        foreach (AntBranch branchTemp in antBranches.Where(d => d.Index == branch.Index))
                        {
                            foreach (Ant antTemp in branchTemp.Ants)
                            {
                                simInBranch = Math.Abs(simInBranch + antTree.CountSim(antTemp, ant));
                            }
                            simInBranch = simInBranch / (branchTemp.Ants.Count + branch.Ants.Count);
                        }
                        foreach (AntBranch branchTemp in antBranches.Where(d => d.Index != branch.Index))
                        {
                            double sim = 0;
                            foreach (Ant antTemp in branchTemp.Ants)
                            {
                                sim = Math.Abs(sim + antTree.CountSim(antTemp, ant));
                            }
                            tempSim[branchTemp.Index] = sim / (branchTemp.Ants.Count + branch.Ants.Count);
                        }
                    }
                    antsSim.AddRange(tempSim.Select(a => a.Value));
                    antsSimInBranch.Add(simInBranch);
                }
                score = Math.Round(antsSim.Min() / antsSimInBranch.Max(), 3);
            }
            return score;
        }
    }
}
