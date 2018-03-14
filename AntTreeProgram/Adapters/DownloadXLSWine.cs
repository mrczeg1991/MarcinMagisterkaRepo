using AntTreeProgram.Adapters;
using LinqToExcel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram.DataXLS
{
    class DownloadXLSWine : IDownloadXLS
    {
        public List<WineData> WineList { get; set; } = new List<WineData>();
        List<string> nameList { get; set; } = new List<string>();

        public List<Ant> GetAntTreeList()
        {
            List<Ant> antList = new List<Ant>();
            int i = 0;
            foreach (WineData wine in WineList)
            {
                Points points = new Points();
                points.StringData.Add(wine.Type);
                if (!nameList.Exists(a => a == wine.Type)) nameList.Add(wine.Type);
                points.DigitData.Add(PrepareDigit(wine.Alcohol, 14.83));
                points.DigitData.Add(PrepareDigit(wine.MalicAcid, 5.8));
                points.DigitData.Add(PrepareDigit(wine.Ash, 3.23));
                points.DigitData.Add(PrepareDigit(wine.AshAlcalinity, 30));
                points.DigitData.Add(PrepareDigit(wine.Magnesium, 162));
                points.DigitData.Add(PrepareDigit(wine.Total_Phenols, 3.88));
                points.DigitData.Add(PrepareDigit(wine.Flavanoids, 5.08));
                points.DigitData.Add(PrepareDigit(wine.Nonflavanoid_Phenols, 0.66));
                points.DigitData.Add(PrepareDigit(wine.Proanthocyanins, 3.58));
                points.DigitData.Add(PrepareDigit(wine.ColorIntensity, 13));
                points.DigitData.Add(PrepareDigit(wine.Hue, 1.71));
                points.DigitData.Add(PrepareDigit(wine.OD280_OD315, 4));
                points.DigitData.Add(PrepareDigit(wine.Proline, 1680));
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

        public object GetList()
        {
            return WineList;
        }

        public string GetPath()
        {
            string path = @"C:\Users\Marcin\Desktop\Magisterka\Wine.xls";
            return path;
        }

        public void ReadData()
        {
            string sheetName = "Data";
            var wineFile = new ExcelQueryFactory(GetPath());
            WineList = (from wineXLS in wineFile.Worksheet<WineData>(sheetName) select wineXLS).ToList();
        }
        double PrepareDigit(double digit, double max)
        {
            return digit / max;
        }
        public List<string> GetNameList()
        {
            return nameList;
        }
    }
}
