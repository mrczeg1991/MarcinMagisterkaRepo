using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram
{
    class DunnIndex
    {
        AntTree antTree = null;
        public double DunnIndexValue { get; set; }
        public DunnIndex(List<AntBranch> antBranches)
        {
            antTree = new AntTree();
            if (antBranches.Count > 1)
            {
                DunnIndexValue = Math.Round(TheBiggestSimilarInTheDifferenceBranchs(antBranches) / TheBiggestDifferenceInTheBranch(antBranches), 3);
            }
        }
        public DunnIndex()
        {
            antTree = new AntTree();
        }
        public double TheBiggestDifferenceInTheBranch(List<AntBranch> antBranches)
        {
            double min = 1;
            int number, numbertemp,group = 0;           
            foreach (AntBranch branch in antBranches)
            {
                foreach (Ant ant in branch.Ants)
                {
                    foreach (Ant antTemp in branch.Ants.Where(a => a.Number != ant.Number))
                    {
                        double tempSim = antTree.CountSim(ant, antTemp);
                        if(tempSim < min)
                        {
                            min = tempSim;
                            number = ant.Number;
                            numbertemp = antTemp.Number;
                            group = branch.Index;
                        }
                    }
                }
            }
            double score = Math.Abs((min != 0 ? min : 0.0001) - 1);
            return score;
        }
        double TheBiggestSimilarInTheDifferenceBranchs(List<AntBranch> antBranches)
        {
            double max = 0;
            int number, numbertemp, group = 0;
            foreach (AntBranch branch in antBranches)
            {
                foreach (Ant ant in branch.Ants)
                {
                   antBranches.Where(a => a.Index != ant.Index).Select(a => a.Ants).ToList().ForEach(b=>
                        {
                            b.ForEach(c =>
                           {
                                
                                double tempMin = antTree.CountSim(ant, c);
                                if (tempMin > max)
                                {
                                   number = ant.Number;
                                   numbertemp = c.Number;
                                   max = tempMin;
                                }

                            }
                            );
                        }
                    );
                }
            }
            double score = Math.Abs((max != 0 ? max : 0.0001) - 1);
            return score;
        }
    }
}
