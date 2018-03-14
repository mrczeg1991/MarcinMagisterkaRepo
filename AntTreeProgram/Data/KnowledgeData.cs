using LinqToExcel.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram.Adapters
{
    class KnowledgeData
    {
        [ExcelColumn("STG")]
        public double STG { get; set; }
        [ExcelColumn("SCG")]
        public double SCG { get; set; }
        [ExcelColumn("STR")]
        public double STR { get; set; }

        [ExcelColumn("LPR")]
        public double LPR { get; set; }
        [ExcelColumn("PEG")]
        public double PEG { get; set; }
        [ExcelColumn("UNS")]
        public string UNS { get; set; }

    }
}
