using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram
{
    public class Ant
    {
        public Ant(double TSim, double TDissim)
        {
            this.TSim = TSim;
            this.TDissim = TDissim;
        }
        public Points Points { get; set; }
        /// <summary>
        /// Numer gałęzi w której znajduje się mrówka
        /// </summary>
        public int Index { get; set; }
        public int ParentIndex { get; set; }
        public double TSim  { get; set; }
        public double TDissim { get; set; }
        public int Number { get; set; }

        public int ParenTemp { get; set; }

    }
}
