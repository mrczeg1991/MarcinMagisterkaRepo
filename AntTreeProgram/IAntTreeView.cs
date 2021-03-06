﻿using System;
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
        void AddToAlgorythmCombobox(string nazwa);
        string GetAlgorythmName();

        void SetDunnIndex(double index);

        int GetNumberGroups();
    }
}
