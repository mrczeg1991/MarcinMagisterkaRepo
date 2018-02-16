using AntTreeProgram.Adapters;
using LinqToExcel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram.DataXLS
{
    class DownloadXLSIris : IDownloadXLS
    {
        public List<IrisData> Iris { get; set; } = new List<IrisData>();
        public void ReadData()
        {
            string sheetName = "Iris";
            var irisFile = new ExcelQueryFactory(GetPath());
            var irisData = from a in irisFile.Worksheet<IrisData>(sheetName) select a;
            foreach (var iris in irisData)
            {
                IrisData irisTemp = new IrisData()
                {
                    Iris = iris.Iris,
                    PetalLength= iris.PetalLength,
                    PetalWidth=iris.PetalWidth,
                    SepalLength=iris.SepalLength,
                    SepalWidth=iris.SepalWidth
                };
                Iris.Add(irisTemp);
            }
        }
        public string GetPath()
        {
            string path = @"C:\Users\Marcin\Desktop\Magisterka\Iris.xls";
            return path;
        }

        public List<Ant> GetAntTreeList()
        {
            List<Ant> antList = new List<Ant>();
            return antList;
        }
    }
}
