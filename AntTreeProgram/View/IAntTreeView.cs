using AntTreeProgram.Adapters;
using AntTreeProgram.DataXLS;
using AntTreeProgram.Other;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram
{
    interface IAntTreeView
    {
        void AddDataToChart(Ant ant, Color color);
        void AddToDissimCombobox(double value);
        void AddToSimCombobox(double value);
        object GetDissim();
        object GetSim();
        void ClearData();

        void SetGroupNumber(int number);
        void AddToRepoCombobox(XLSData nazwa);
        XLSData GetRepoName();

        void SetDunnIndex(double index);


        void AddToGrid(object iris, List<AntBranch> branches);

        void SetClassificationError(string value);
        void SetErrorPurity(string value);
        void SetGDIIndex(string value);
        void DrawBranch(AntBranch branch, string name);
        void AddToBranchesCombobox(string name);
        void ClearBranchesCombobox();
        string GetSimText();
        string GetDissimText();

        bool GetManula();

        bool GetBranchOperation();
        void AddToSortCombobox(string name);
        string GetSortKind();
        void AddToMiaraCombobox(Miara name);

        string GetMiara();
    }
}
