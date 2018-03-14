using LinqToExcel.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram.Adapters
{
    class GlassData
    {
        [ExcelColumn("RI")]
        public double RI { get; set; }
        [ExcelColumn("Na")]
        public double Na { get; set; }
        [ExcelColumn("Mg")]
        public double Mg { get; set; }
        [ExcelColumn("Al.")]
        public double Al { get; set; }
        [ExcelColumn("Si")]
        public double Si { get; set; }
        [ExcelColumn("K")]
        public double K { get; set; }
        [ExcelColumn("Ca")]
        public double Ca { get; set; }
        [ExcelColumn("Ba")]
        public double Ba { get; set; }
        [ExcelColumn("Fe")]
        public double Fe { get; set; }
        [ExcelColumn("Type")]
        public string Type { get; set; }
    }
}
