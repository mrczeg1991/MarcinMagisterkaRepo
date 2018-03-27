using AntTreeProgram.Adapters;
using LinqToExcel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram.DataXLS
{
    class DownloadXLSWine : IDownloadXLS
    {
        public List<WineData> WineList { get; set; } = new List<WineData>();
        List<string> nameList { get; set; } = new List<string>();

        PrepareData prepareData = new PrepareData();
        public List<Ant> GetAntTreeList()
        {
            List<Ant> antList = new List<Ant>();
            int i = 1;
            foreach (WineData wine in WineList.Where(a=>a.Alcohol>0))
            {
                Points points = new Points();
                points.StringData.Add(wine.Type);
                if (!nameList.Exists(a => a == wine.Type)) nameList.Add(wine.Type);
                points.DigitData.Add(prepareData.RescaleData(wine.Alcohol, "Alcohol"));
                points.DigitData.Add(prepareData.RescaleData(wine.MalicAcid, "MalicAcid"));
                points.DigitData.Add(prepareData.RescaleData(wine.Ash, "Ash"));
                points.DigitData.Add(prepareData.RescaleData(wine.AshAlcalinity, "AshAlcalinity"));
                points.DigitData.Add(prepareData.RescaleData(wine.Magnesium, "Magnesium"));
                points.DigitData.Add(prepareData.RescaleData(wine.Total_Phenols, "Total_Phenols"));
                points.DigitData.Add(prepareData.RescaleData(wine.Flavanoids, "Flavanoids"));
                points.DigitData.Add(prepareData.RescaleData(wine.Nonflavanoid_Phenols, "Nonflavanoid_Phenols"));
                points.DigitData.Add(prepareData.RescaleData(wine.Proanthocyanins, "Proanthocyanins"));
                points.DigitData.Add(prepareData.RescaleData(wine.ColorIntensity, "ColorIntensity"));
                points.DigitData.Add(prepareData.RescaleData(wine.Hue, "Hue"));
                points.DigitData.Add(prepareData.RescaleData(wine.OD280_OD315, "OD280_OD315"));
                points.DigitData.Add(prepareData.RescaleData(wine.Proline, "Proline"));
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
            return WineList.Where(a=>a.Alcohol>0);
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
            WineData data = new WineData();
            prepareData.AddToDicionary(data, WineList.Where(a=>a.Alcohol>0));
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
