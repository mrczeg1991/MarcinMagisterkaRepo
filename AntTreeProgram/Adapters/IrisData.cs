using LinqToExcel.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram.Adapters
{
    class IrisData
    {
        [ExcelColumn("sepal length")]
        public double SepalLength { get; set; }
        [ExcelColumn("sepal width")]
        public double SepalWidth { get; set; }
        [ExcelColumn("petal length")]
        public double PetalLength { get; set; }
        [ExcelColumn("petal width")]
        public double PetalWidth { get; set; }
        [ExcelColumn("iris")]
        public string Iris { get; set; }
    }
}
