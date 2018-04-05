using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram.Data
{
    class Sort
    {
        public void PrepareOrderData(List<Ant> listPoints)
        {
            AntTree antTree = new AntTree();
            double min = 1;
            foreach (Ant ant in listPoints)
            {
                double sim = 0;
                foreach (Ant antTemp in listPoints.Where(a => a.Number != ant.Number))
                {
                    double temp= antTree.CountSim(ant, antTemp);
                    if(temp<min)
                    {
                        min = temp;
                    }
                    sim += temp;
                }
                ant.AvgSim = sim / (listPoints.Count - 1);
            }
            string dupa = "sss";
        }
    }
}
