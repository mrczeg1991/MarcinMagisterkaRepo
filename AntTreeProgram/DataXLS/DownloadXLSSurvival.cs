using AntTreeProgram.Adapters;
using LinqToExcel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram.DataXLS
{
    class DownloadXLSSurvival : IDownloadXLS
    {
        public List<SurvivalData> SurvivalList { get; set; } = new List<SurvivalData>();
        List<string> nameList { get; set; } = new List<string>();

        public List<Ant> GetAntTreeList()
        {
            List<Ant> antList = new List<Ant>();
            int i = 0;
            foreach (SurvivalData wine in SurvivalList)
            {
                Points points = new Points();
                points.StringData.Add(wine.Survival);
                if (!nameList.Exists(a => a == wine.Survival)) nameList.Add(wine.Survival);
                points.DigitData.Add(PrepareDigit(wine.Age, 83));
                points.DigitData.Add(PrepareDigit(wine.Year, 69));
                points.DigitData.Add(PrepareDigit(wine.Number, 52));
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
            return SurvivalList;
        }

        public string GetPath()
        {
            string path = @"C:\Users\Marcin\Desktop\Magisterka\Survival.xls";
            return path;
        }

        public void ReadData()
        {
            string sheetName = "Survival";
            var survivalFile = new ExcelQueryFactory(GetPath());
            SurvivalList = (from survivalXLS in survivalFile.Worksheet<SurvivalData>(sheetName) select survivalXLS).ToList();
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
