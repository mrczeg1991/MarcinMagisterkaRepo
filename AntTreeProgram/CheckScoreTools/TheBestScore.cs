using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram.CheckScoreTools
{
    class TheBestScore
    {
        public double Sim { get; set; }
        public double Dissim { get; set; }

        public string Kind { get; set; }

        public double Gdi { get; set; }

        public double Dunn { get; set; }

        public double Purity { get; set; }
        public double Error { get; set; } = 1;



    }
}
