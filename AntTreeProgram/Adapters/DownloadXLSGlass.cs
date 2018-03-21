using AntTreeProgram.Adapters;
using LinqToExcel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram.DataXLS
{
    class DownloadXLSGlass : IDownloadXLS
    {
        public List<GlassData> GlassList { get; set; } = new List<GlassData>();
        List<string> nameList { get; set; } = new List<string>();
        PrepareData prepareData = new PrepareData();
        public List<Ant> GetAntTreeList()
        {
            List<Ant> antList = new List<Ant>();
            int i = 1;
            foreach (GlassData glass in GlassList)
            {
                Points points = new Points();
                points.DigitData.Add(prepareData.RescaleData(glass.RI, "RI"));
                points.DigitData.Add(prepareData.RescaleData(glass.Na, "Na"));
                points.DigitData.Add(prepareData.RescaleData(glass.Mg, "Mg"));
                points.DigitData.Add(prepareData.RescaleData(glass.Al, "Al"));
                points.DigitData.Add(prepareData.RescaleData(glass.Si, "Si"));
                points.DigitData.Add(prepareData.RescaleData(glass.K, "K"));
                points.DigitData.Add(prepareData.RescaleData(glass.Ca, "Ca"));
                points.DigitData.Add(prepareData.RescaleData(glass.Ba, "Ba"));
                points.DigitData.Add(prepareData.RescaleData(glass.Fe, "Fe"));
               // points.StringData.Add(glass.Type);
                if (!nameList.Exists(a => a == glass.Type)) nameList.Add(glass.Type);
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

        public string GetPath()
        {
            string path = @"C:\Users\Marcin\Desktop\Magisterka\Glass.xls";
            return path;
        }

        public void ReadData()
        {
            string sheetName = "Glass";
            var glassFile = new ExcelQueryFactory(GetPath());
            GlassList = (from a in glassFile.Worksheet<GlassData>(sheetName) select a).ToList();
            GlassData glass = new GlassData();
            prepareData.AddToDicionary(glass, GlassList);
        }

        public object GetList()
        {
            return GlassList;
        }

        public List<string> GetNameList()
        {
            return nameList;
        }
    }
}
