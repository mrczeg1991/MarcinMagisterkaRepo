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
        public List<Ant> GetAntTreeList()
        {
            List<Ant> antList = new List<Ant>();
            int i = 0;
            foreach (GlassData glass in GlassList)
            {
                Points points = new Points();
                points.DigitData.Add(PrepareDigit(glass.RI,1.53));
                points.DigitData.Add(PrepareDigit(glass.Na,17.38));
                points.DigitData.Add(PrepareDigit(glass.Mg,4.49));
                points.DigitData.Add(PrepareDigit(glass.Al,3.5));
                points.DigitData.Add(PrepareDigit(glass.Si, 75.41));
                points.DigitData.Add(PrepareDigit(glass.K, 6.21));
                points.DigitData.Add(PrepareDigit(glass.Ca, 16.19));
                points.DigitData.Add(PrepareDigit(glass.Ba, 3.15));
                points.DigitData.Add(PrepareDigit(glass.Fe, 0.51));
                points.StringData.Add(glass.Type);
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
        }

        public object GetList()
        {
            return GlassList;
        }
    }
}
