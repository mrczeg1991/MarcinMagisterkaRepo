﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram
{
    class AntBranch
    {
        public List<Ant> Ants { get; set; }
        public Color AntColor { get; set; }
        public int Index { get; set; }
        public AntBranch()
        {
            Ants = new List<Ant>();
        }
    }
}
