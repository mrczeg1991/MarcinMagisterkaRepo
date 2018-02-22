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
        public void ReadData()
        {
            string sheetName = "Iris";
            var irisFile = new ExcelQueryFactory(GetPath());
            IrisList = (from a in irisFile.Worksheet<IrisData>(sheetName) select a).ToList();
        }
        public string GetPath()
        {
            string path = @"C:\Users\Marcin\Desktop\Magisterka\Iris.xls";
            return path;
        }

        public List<Ant> GetAntTreeList()
        {
            List<Ant> antList = new List<Ant>();
            int i = 0;
            foreach(IrisData iris in IrisList)
            {
                Points points = new Points();
                points.DigitData.Add(PrepareDigit(iris.PetalLength,6.9));
                points.DigitData.Add(PrepareDigit(iris.PetalWidth,2.5));
                points.DigitData.Add(PrepareDigit(iris.SepalLength,7.9));
                points.DigitData.Add(PrepareDigit(iris.SepalWidth,4.4));
                points.StringData.Add(iris.Iris);
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
    }
}
