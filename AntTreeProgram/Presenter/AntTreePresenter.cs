﻿using AntTreeProgram.CheckScoreTools;
using AntTreeProgram.Data;
using AntTreeProgram.DataXLS;
using AntTreeProgram.Other;
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
        IDownloadXLS xls = null;
        List<Ant> antsList = null;
        List<AntBranch> antBranches = null;
        int groupNumber = 0;
        string[] tabKind = { "Malejąco", "Rosnąco", "Domyślnie" };
        string[] tabMiar = { "euklidesowa", "miejska" };

        public AntTreeControler(IAntTreeView view)
        {
            this.view = view;

        }
        public void SetOnStart()
        {
            SetSim();
            SetDissim();
            SetAlgorythmName();
            SetComboxSortData();
            SetComboxMiara();
        }
        void SetAlgorythmName()
        {
            view.AddToRepoCombobox(XLSData.Iris);
            view.AddToRepoCombobox(XLSData.Wina);
            view.AddToRepoCombobox(XLSData.Szkła);
            view.AddToRepoCombobox(XLSData.Przeżycia);
            view.AddToRepoCombobox(XLSData.Wiedza);

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
        void SetComboxSortData()
        {
            foreach (string s in tabKind)
            {
                view.AddToSortCombobox(s);
            }
        }
        void SetComboxMiara()
        {
            foreach (Miara miara in Enum.GetValues(typeof(Miara)))
            {
                view.AddToMiaraCombobox(miara);
            }
        }
        public void SetData()
        {
            view.ClearData();
            groupNumber = antBranches.Count();
            view.SetGroupNumber(groupNumber);
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
        void GetNewSim(double dissim, double sim)
        {
            antsList.ForEach(a =>
            {
                a.TDissim = dissim;
                a.TSim = sim;
            });
        }
        void TakeDataFromXLS()
        {
            xls = FabrykaXLS.CreateXLSObject(view.GetRepoName());
            xls.ReadData();
            antsList = xls.GetAntTreeList();
        }
        public void GroupData()
        {
            ClearData();
            TakeDataFromXLS();
            GetNewSim(GetDissim(), GetSim());
            AntTree antTreeAlgorythm = new AntTree(view.GetMiara());
            List<Ant> sortedList = SortData(antsList, view.GetSortKind());
            antBranches = antTreeAlgorythm.AntTreeAlgorythm(sortedList, view.GetBranchOperation());
            view.AddToGrid(xls.GetList(), antBranches);
            view.SetErrorPurity(CountPurity().ToString());
            view.SetClassificationError(CountError().ToString());
            view.SetGDIIndex(CountGDI().ToString());
            view.SetDunnIndex(CountDunnIndex());
            view.ClearBranchesCombobox();
            antBranches.ForEach(a=>view.AddToBranchesCombobox($"Gałąź {a.Index}"));
        }
        double CountGDI()
        {
            GDIIndex gdi = new GDIIndex();
            double gdiClass=gdi.CountGDIIndex(antBranches, view.GetMiara());
            return gdiClass;
        }
        double CountPurity()
        {
            ClusterPurity purity = new ClusterPurity();
            double purityScore = purity.Operation(antBranches, xls.GetNameList(), xls.GetAntTreeList().Count());
            return purityScore;
        }
        double CountError()
        {
            ClassificationError error = new ClassificationError();
            double errorScore = error.Operation(antsList);
            return errorScore;
        }
        double CountDunnIndex()
        {
            DunnIndex dunnIndex = new DunnIndex(antBranches, view.GetMiara());
            return dunnIndex.DunnIndexValue;

        }
        public void GroupAutomatic()
        {
            TakeDataFromXLS();
            List<TheBestScore> theBest = new List<TheBestScore>();
            List<double> values = new List<double>();
            double tmp=0.001;
            values.Add(0.005);
            while(tmp<1)
            {
                values.Add(tmp);
                tmp+=0.05;
            }
            foreach (Miara miara in Enum.GetValues(typeof(Miara)))
            {
                TheBestScore purity = new TheBestScore();
                foreach (string kind in tabKind)
                {
                    foreach (double simTem in values.Where(d => d > 0.7))
                    {
                        foreach (double dissimTemp in values.Where(d => d < simTem))
                        {
                            AntTree antTreeAlgorythm = new AntTree(miara);
                            antsList = xls.GetAntTreeList();
                            List<Ant> sortedList = SortData(antsList, kind);
                            GetNewSim(dissimTemp, simTem);
                            antBranches = antTreeAlgorythm.AntTreeAlgorythm(sortedList, false);
                            //if (antBranches.Count == ReturnGroupNumber())
                            //{
                                double tempPurity = CountPurity();
                                purity.Purity = tempPurity;
                                purity.Sim = simTem;
                                purity.Dissim = dissimTemp;
                                purity.Kind = kind;
                                purity.Miara = miara;
                                if (tempPurity >= purity.Purity && miara==Miara.euklidesowa)
                                {                                  
                                    theBest.Add(ReturnToTheBestList(purity));
                                }
                                if (tempPurity >= purity.Purity && miara == Miara.kosinusowa)
                                {
                                    theBest.Add(ReturnToTheBestList(purity));
                                }
                                if (tempPurity >= purity.Purity && miara == Miara.miejska)
                                {
                                    theBest.Add(ReturnToTheBestList(purity));
                                }
                            //}
                            
                        }
                    }
                }
            }
            AddAutoRecordToGrid(theBest);
        }
        TheBestScore ReturnToTheBestList(TheBestScore toAdd)
        {
            TheBestScore temp = new TheBestScore();
            temp.Purity = toAdd.Purity;
            temp.Sim = toAdd.Sim;
            temp.Dissim = toAdd.Dissim;
            temp.Kind = toAdd.Kind;
            temp.Miara = toAdd.Miara;
            temp.Gdi = CountGDI();
            temp.Dunn = CountDunnIndex();
            temp.Error = CountError();
            return temp;
        }
        void AddAutoRecordToGrid(List<TheBestScore> theBest)
        {
            view.AddToGrid(theBest.OrderBy(d=>d.Purity).ToList());
        }

        int ReturnGroupNumber()
        {
            int number = 1;
            switch(view.GetRepoName())
            {
                case (XLSData.Iris):
                    {
                        number = 3;
                    }break;
                case (XLSData.Wiedza):
                    {
                        number = 4;
                    }
                    break;
                case (XLSData.Przeżycia):
                    {
                        number = 2;
                    }
                    break;
                case (XLSData.Wina):
                    {
                        number = 3;
                    }
                    break;
                case (XLSData.Szkła):
                    {
                        number = 6;
                    }
                    break;
            }
            return number;
        }
        void ClearData()
        {
            view.SetErrorPurity("0");
            view.SetClassificationError("0");
            view.SetGDIIndex("0");
             view.SetDunnIndex(0);
            view.SetGroupNumber(0);

        } 

        List<Ant> SortData(List<Ant> data, string kind)
        {
            Sort sortData = new Sort();
            sortData.PrepareOrderData(data, view.GetMiara());
            switch(kind)
            {
                case ("Malejąco"):
                    {
                        data = data.OrderByDescending(a => a.AvgSim).ToList();
                    }
                    break;
                case ("Rosnąco"):
                    {
                        data = data.OrderBy(a => a.AvgSim).ToList();
                    }
                    break;
            }
            return data;

        }

        public void ShowBranch(int index)
        {
            view.DrawBranch(antBranches.Where(a=>a.Index==index+1).FirstOrDefault(), $"Gałąź {index}");
        }
    }
}
