using AntTreeProgram.CheckScoreTools;
using AntTreeProgram.DataXLS;
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

        }
        public void SetOnStart()
        {
            SetSim();
            SetDissim();
            SetAlgorythmName();
        }
        void SetAlgorythmName()
        {
            view.AddToRepoCombobox(XLSData.Iris);
            view.AddToRepoCombobox(XLSData.Wina);
            view.AddToRepoCombobox(XLSData.Glass);
            view.AddToRepoCombobox(XLSData.Survival);
            view.AddToRepoCombobox(XLSData.Knowledge);

        }
        void SetSim()
        {
            List<double> values = new List<double>()
            {
                0.005,0.01,0.05,0.1,0.15,0.2,0.25,0.3,0.35,0.4,0.45,0.5,0.55,0.6,0.65,0.7,0.75,0.8,0.85,0.9,0.95,0.98,0.99
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
                0.005,0.01,0.05,0.1,0.15,0.2,0.25,0.3,0.35,0.4,0.45,0.5,0.55,0.6,0.65,0.7,0.75,0.8,0.85,0.9,0.95,0.98,0.99
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
            if (view.GetManula()==false)
            {
                double.TryParse(view.GetSim().ToString(), out value);
            }
            else
            {
                double.TryParse(view.GetSimText(), out value);
            }
            return value;
        }
        double GetDissim()
        {
            double value = 0;
            if (view.GetManula() == false)
            {
                double.TryParse(view.GetDissim().ToString(), out value);
            }
            else
            {
                double.TryParse(view.GetDissimText(), out value);
            }
            return value;
        }
        public void GroupData()
        {
            view.SetDunnIndex(0);
            view.SetGroupNumber(0);
            IDownloadXLS xls = FabrykaXLS.CreateXLSObject(view.GetRepoName());
            xls.ReadData();
            antsList = xls.GetAntTreeList();
            antsList.ForEach(a =>
            {
                a.TDissim = GetDissim();
                a.TSim = GetSim();
            });
            AntTree antTreeAlgorythm = new AntTree();
            antBranches = antTreeAlgorythm.AntTreeAlgorythm(antsList, view.GetBranchOperation());
            view.AddToGrid(xls.GetList(), antBranches);
            ClusterPurity purity = new ClusterPurity();
            ClassificationError error = new ClassificationError();
            double purityScore = purity.Operation(antBranches, xls.GetNameList(), xls.GetAntTreeList().Count());
            double errorScore = error.Operation(antsList);
            view.SetErrorPurity(purityScore.ToString());
            view.SetClassificationError(errorScore.ToString());
            GDIIndex gdi = new GDIIndex();
            view.SetGDIIndex(gdi.CountGDIIndex(antBranches).ToString());
            view.ClearBranchesCombobox();
            antBranches.ForEach(a=>view.AddToBranchesCombobox($"Gałąź {a.Index}"));
        }
        public void ShowBranch(int index)
        {
            view.DrawBranch(antBranches.Where(a=>a.Index==index).FirstOrDefault(), $"Gałąź {index}");
        }
    }
}
