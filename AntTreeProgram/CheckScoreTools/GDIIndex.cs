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
        AntTree antTree = new AntTree();
        public double CountGDIIndex(List<AntBranch> antBranches)
        {
            List<double> antsSim = new List<double>();
            foreach(AntBranch branch in antBranches)
            {
                foreach(Ant ant in branch.Ants)
                {
                    foreach (Ant antTemp in branch.Ants.Where(a => a.Number != ant.Number))
                    {
                        double tempSim = antTree.CountSim(ant, antTemp);
                        if (tempSim < min)
                        {
                            min = tempSim;
                            number = ant.Number;
                            numbertemp = antTemp.Number;
                            group = branch.Index;
                        }
                    }
                    foreach (AntBranch branchTemp in antBranches.Where(d=>d.Index!=branch.Index))
                    {
                        double sim = 0;
                        foreach (Ant antTemp in branchTemp.Ants)
                        {
                           sim=Math.Abs(sim + antTree.CountSim(antTemp, ant));
                        }
                        sim = sim / (branchTemp.Ants.Count + branch.Ants.Count);
                        antsSim.Add(sim);
                    }
                }
            }
            double score=Math.Round(antsSim.Max() / dunn.TheBiggestDifferenceInTheBranch(antBranches),3);
            return score;
        }
    }
}
