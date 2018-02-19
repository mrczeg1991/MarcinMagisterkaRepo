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
        public List<Ant> GetAntTreeList()
        {
            List<Ant> antList = new List<Ant>();
            int i = 0;
            foreach (WineData wine in WineList)
            {
                Points points = new Points();
                points.StringData.Add(wine.Type);
                points.DigitData.Add(PrepareDigit(wine.Alcohol, 13.001));
                points.DigitData.Add(PrepareDigit(wine.MalicAcid, 2.34));
                points.DigitData.Add(PrepareDigit(wine.Ash, 2.37));
                points.DigitData.Add(PrepareDigit(wine.AshAlcalinity, 19.49));
                points.DigitData.Add(PrepareDigit(wine.Magnesium, 99.8));
                points.DigitData.Add(PrepareDigit(wine.Total_Phenols, 2.3));
                points.DigitData.Add(PrepareDigit(wine.Flavanoids, 2.03));
                points.DigitData.Add(PrepareDigit(wine.Nonflavanoid_Phenols, 0.36));
                points.DigitData.Add(PrepareDigit(wine.Proanthocyanins, 1.59));
                points.DigitData.Add(PrepareDigit(wine.ColorIntensity, 5.06));
                points.DigitData.Add(PrepareDigit(wine.Hue, 0.96));
                points.DigitData.Add(PrepareDigit(wine.OD280_OD315, 2.611));
                points.DigitData.Add(PrepareDigit(wine.Proline, 746.9));
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
    }
}
