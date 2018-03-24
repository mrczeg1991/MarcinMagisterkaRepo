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
        PrepareData prepareDate = new PrepareData();

        public List<Ant> GetAntTreeList()
        {
            List<Ant> antList = new List<Ant>();
            int i = 1;
            foreach (SurvivalData survival in SurvivalList)
            {
                Points points = new Points();
                points.StringData.Add(survival.Survival);
                if (!nameList.Exists(a => a == survival.Survival)) nameList.Add(survival.Survival);
                points.DigitData.Add(prepareDate.RescaleData(survival.Age, "Age"));
                points.DigitData.Add(prepareDate.RescaleData(survival.Year,"Year"));
                points.DigitData.Add(prepareDate.RescaleData(survival.Number, "Number"));
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
            SurvivalData survival = new SurvivalData();
            prepareDate.AddToDicionary(survival, SurvivalList);
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
