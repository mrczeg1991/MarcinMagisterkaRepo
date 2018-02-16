using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram
{
    class AntTreeControler
    {
        IAntTreeView view = null;
        List<Ant> antsList = null;
        List<AntBranch> antBranches = null;
        int groupNumber = 0;
        public AntTreeControler(IAntTreeView view)
        {
            this.view = view;
            PrepareData prepare = new PrepareData();
            antsList = prepare.RandomAnts(8, GetSim(), GetDissim());
        }
        public void SetOnStart()
        {
            SetSim();
            SetDissim();
            SetAlgorythmName();
        }
        void SetAlgorythmName()
        {
            view.AddToAlgorythmCombobox("AntTree");
            view.AddToAlgorythmCombobox("k-means");

        }
        void SetSim()
        {
            List<double> values = new List<double>()
            {
                0.005,0.01,0.05,0.1,0.2,0.3,0.4,0.5,0.6,0.7,0.8,0.9,0.95,0.99
            };
            foreach(double d in values)
            {
                view.AddToSimCombobox(d);
            }
        }
        void SetDissim()
        {
            List<double> values = new List<double>()
            {
                0,0.05,0.1,0.15,0.2,0.25,0.3,0.35,0.4,0.5,0.6,0.7,0.8,0.9
            };
            foreach (double d in values)
            {
                view.AddToDissimCombobox(d);
            }
        }
        public void SetData()
        {
            DunnIndex dunnIndex = new DunnIndex(antBranches);
            view.ClearData();
            groupNumber = antBranches.Count();
            view.SetGroupNumber(groupNumber);
            view.SetDunnIndex(dunnIndex.DunnIndexValue);
            foreach (AntBranch branch in antBranches)
            {
                foreach (Ant ant in branch.Ants)
                {
                    view.AddDataToChart(ant, branch.AntColor);
                }
            }
        }
        double GetSim()
        {
            double value = 0;
            double.TryParse(view.GetSim().ToString(), out value);
            return value;
        }
        double GetDissim()
        {
            double value = 0;
            double.TryParse(view.GetDissim().ToString(), out value);
            return value;
        }
        public void GroupData()
        {
            if (view.GetAlgorythmName() == "AntTree")
            {
                antsList.ForEach(a =>
                {
                    a.TDissim = GetDissim();
                    a.TSim = GetSim();
                });
                AntTree antTreeAlgorythm = new AntTree();
                antBranches = antTreeAlgorythm.AntTreeAlgorythm(antsList);
            }
            else
            {
                antBranches=Kmeans.KMeans(antsList,view.GetNumberGroups());
            }
        }
    }
}
