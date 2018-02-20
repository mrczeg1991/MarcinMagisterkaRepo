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
            throw new NotImplementedException();
        }

        public string GetPath()
        {
            string path = @"C:\Users\Marcin\Desktop\Magisterka\Glass.xls";
            return path;
        }

        public void ReadData()
        {
            string sheetName = "Iris";
            var glassFile = new ExcelQueryFactory(GetPath());
            GlassList = (from a in glassFile.Worksheet<GlassData>(sheetName) select a).ToList();
        }
    }
}
