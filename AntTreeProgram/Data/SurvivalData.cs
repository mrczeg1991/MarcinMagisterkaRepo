using LinqToExcel.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram.Adapters
{
    class SurvivalData
    {
        [ExcelColumn("Age")]
        public double Age { get; set; }
        [ExcelColumn("Year")]
        public double Year { get; set; }
        [ExcelColumn("Number")]
        public double Number { get; set; }
        [ExcelColumn("Survival")]
        public string Survival { get; set; }
    }
}
