using LinqToExcel.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram.Adapters
{
    class WineData
    {
        [ExcelColumn("Type")]
        public string Type { get; set; }
        [ExcelColumn("Alcohol")]
        public double Alcohol { get; set; }
        [ExcelColumn("Malic_Acid")]
        public  double MalicAcid { get; set; }
        [ExcelColumn("Ash")]
        public double Ash { get; set; }
        [ExcelColumn("Ash_Alcalinity")]
        public double AshAlcalinity { get; set; }
        [ExcelColumn("Magnesium")]
        public double Magnesium { get; set; }
        [ExcelColumn("Total_Phenols")]
        public double Total_Phenols { get; set; }
        [ExcelColumn("Flavanoids")]
        public double Flavanoids{ get; set; }
        [ExcelColumn("Nonflavanoid_Phenols")]
        public double Nonflavanoid_Phenols{ get; set; }
        [ExcelColumn("Proanthocyanins")]
        public double Proanthocyanins{ get; set; }
        [ExcelColumn("Color_Intensity")]
        public double ColorIntensity { get; set; }
        [ExcelColumn("Hue")]
        public double Hue { get; set; }
        [ExcelColumn("OD280_OD315")]
        public double OD280_OD315 { get; set; }
        [ExcelColumn("Proline")]
        public double Proline{ get; set; }
    }
}
