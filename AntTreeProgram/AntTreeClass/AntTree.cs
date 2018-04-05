using AntTreeProgram.Other;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AntTreeProgram
{
    class AntTree
    {
        Colors color = null;
        Miara miara = Miara.euklidesowa;
        public AntTree()
        {
            color = new Colors();
        }
        public List<AntBranch> AntTreeAlgorythm(List<Ant> antsList, bool branchOperation)
        {
            List<AntBranch> antBranches = new List<AntBranch>();
            AddToBranches(antsList, antBranches);
            if(branchOperation) BranchesOperation(antBranches, antsList);
            return antBranches;
        }

        private void BranchesOperation(List<AntBranch> antBranches, List<Ant> ants)
        {
            int i = 0;
            while (!CheckWeatherAllAntsHaveParents(ants, antBranches.Count()))
            {
                foreach (AntBranch branch in antBranches)
                {
                    foreach (Ant ant in branch.Ants.Where(a=>a.ParentIndex==0 && a.ParentIndex != 999999))
                    {
                        
                        Ant apos = branch.Ants.Where(a=>a.Number==ant.ParenTemp).FirstOrDefault();
                        if (CountSim(ant, apos) >= ant.TSim)
                        {
                            Ant aplus = FindTheMostSimilarAnt(ant, branch.Ants.Where(a => a.ParentIndex == apos.Number).ToList())??apos;
                            if (CountSim(ant, aplus) < ant.TDissim)
                            {
                                ant.ParentIndex = apos.Number;
                                ant.ParenTemp = 0;
                            }
                            else
                            {
                                ChangeSim(ant);
                                ant.ParenTemp = PickRandomAnt(branch.Ants.Where(a => a.ParentIndex == apos.Number).ToList(),apos.Number);
                            }

                        }
                        else
                        {
                            ant.ParenTemp = PickRandomAnt(branch.Ants.Where(a => a.ParentIndex == apos.Number).ToList(), apos.Number);

                        }
                        
                        i++;
                    }
                }
            }
        }
        int PickRandomAnt(List<Ant> list, int indexApos)
        {
            Random rng = new Random();
            if (list.Count == 0) return indexApos;
            return list[rng.Next(list.Count)].Number;
        }
        bool CheckWeatherAllAntsAreInBranches(int ants, List<AntBranch> antBranches)
        {
            int antInBranches= (from l in antBranches select l.Ants.Count()).Sum();
            return antInBranches != ants;
        }
        bool CheckWeatherAllAntsHaveParents(List<Ant> ants, int numberBranches)
        {
            int antsWithParents = ants.Where(a => a.ParentIndex != 0).Count();
            return antsWithParents >= ants.Count-numberBranches;

        }
        bool CheckWeatherAntNotExistInBranches(Ant ant, List<AntBranch> antBranches)
        {
            bool exist = (from rekord in antBranches
                            select rekord.Ants.Exists(x=>x.Number==ant.Number)).Contains(true);
            return !exist;
        }
        void AddToBranches(List<Ant> antsList, List<AntBranch> antBranches)
        {
            while (CheckWeatherAllAntsAreInBranches(antsList.Count, antBranches))
            {
                foreach (Ant ant in antsList.Where(a=>a.Index==0))
                {
                    if (antBranches.Count == 0)
                    {
                        antBranches.Add(CreateNewBranch(ant, 1));
                    }
                    else
                    {
                        Support(ant, antBranches);
                    }
                }
            }
        }
  
        AntBranch CreateNewBranch(Ant firstAnt, int index)
        {
            AntBranch branch = new AntBranch();
            branch.Index = index;
            branch.AntColor = color.GetColor(index);
            firstAnt.Index = index;
            firstAnt.ParentIndex = 999999;
            branch.Ants.Add(firstAnt);
            return branch;
        }
        void Support(Ant ant, List<AntBranch> antBranches)
        {
            Ant theMostSimilar=FindTheMostSimilarAntInBranches(ant, antBranches);
            double tempSim = CountSim(ant, theMostSimilar);
            if (tempSim>=ant.TSim)
            {
                ant.Index = theMostSimilar.Index;
                ant.ParenTemp = theMostSimilar.Number;
                antBranches.FirstOrDefault(a => a.Index == theMostSimilar.Index).Ants.Add(ant);
            }
            else
            {
                if (tempSim< ant.TDissim)
                {
                    antBranches.Add(CreateNewBranch(ant, antBranches.Count()+1));
                }
                else
                {
                    ChangeSim(ant);
                }
            }
        }
        void ChangeSim(Ant ant)
        {
            ant.TSim = ant.TSim * 0.9;
            ant.TDissim = ant.TDissim + 0.01;
        }
        public double CountSim(Ant ant, Ant antSupport)
        {
            double score = 0;
            if (ant!=null && antSupport!=null)
            {
                double temp = CountDigitData(ant.Points.DigitData, antSupport.Points.DigitData);
                double tempToSqrt = temp / ant.Points.DigitData.Count;
                double sqrt = Math.Sqrt(tempToSqrt);
                score = 1-sqrt;
            }
            return score;
        }
        double CountStringData(List<string> antData, List<string> antSupportData)
        {
            double score = 0;
            int i = 0;
            foreach(string temp in antData)
            {
                if (temp != antSupportData[i]) score++;
                    i++;
            }
            return score;
        }
        double CountDigitData(List<double> ant, List<double> antSupport)
        {
            double score = 0;
            int i = 0;
            foreach (double digit in ant)
            {
                double temp = Math.Pow(digit - antSupport[i],2);
                score =+ temp;
                i++;
            }
            return score;
        }
        Ant FindTheMostSimilarAnt(Ant ant, List<Ant> antBranches)
        {
            // Sim 1 to takie same
            Ant minAnt = null;
            double min = double.MinValue;
            foreach(Ant antTemp in antBranches)
            {
                double scoreTemp = CountSim(ant, antTemp);
                if (scoreTemp > min) minAnt = antTemp;
            }
            return minAnt;
        }
        Ant FindTheMostSimilarAntInBranches(Ant ant, List<AntBranch> antBranches)
        {
            Ant minAnt = null;
            double min = double.MinValue;
            foreach (AntBranch branch in antBranches)
            {
                Ant antTemp=branch.Ants[0];
                double scoreTemp = CountSim(ant, antTemp);
                if (scoreTemp > min) minAnt = antTemp;
            }
            return minAnt;
        }
    }
}

