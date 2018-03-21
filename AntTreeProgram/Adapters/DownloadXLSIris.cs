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
        public List<IrisData> IrisList { get; set; } = new List<IrisData>();
        List<string> nameList { get; set; } = new List<string>();
        PrepareData prepareData = new PrepareData();
        public void ReadData()
        {
            string sheetName = "Iris";
            var irisFile = new ExcelQueryFactory(GetPath());
            IrisList = (from a in irisFile.Worksheet<IrisData>(sheetName) select a).ToList();
            IrisData data = new IrisData();
            prepareData.AddToDicionary(data, IrisList);
        }
        public string GetPath()
        {
            string path = @"C:\Users\Marcin\Desktop\Magisterka\Iris.xls";
            return path;
        }

        public List<Ant> GetAntTreeList()
        {
            List<Ant> antList = new List<Ant>();
            int i = 1;
            foreach(IrisData iris in IrisList)
            {
                Points points = new Points();
                points.DigitData.Add(prepareData.RescaleData(iris.PetalLength, "PetalLength"));
                points.DigitData.Add(prepareData.RescaleData(iris.PetalWidth, "PetalWidth"));
                points.DigitData.Add(prepareData.RescaleData(iris.SepalLength, "SepalLength"));
                points.DigitData.Add(prepareData.RescaleData(iris.SepalWidth, "SepalWidth"));
                if (!nameList.Exists(a => a == iris.Iris)) nameList.Add(iris.Iris);
                Ant ant = new Ant(0, 0)
                {
                    Number = i,
                    Points = points
                };
                antList.Add(ant);
                i++;
            }
            return antList;
        }
        double PrepareDigit(double digit, double max)
        {
            return digit / max;
        }
        public object GetList()
        {
            return IrisList;
        }

        public List<string> GetNameList()
        {
            return nameList;
        }
    }
}
