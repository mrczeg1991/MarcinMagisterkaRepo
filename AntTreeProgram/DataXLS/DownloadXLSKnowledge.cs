using AntTreeProgram.Adapters;
using LinqToExcel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram.DataXLS
{
    class DownloadXLSKnowledge : IDownloadXLS
    {
        List<KnowledgeData> KnowledgeList = new List<KnowledgeData>();
        public List<Ant> GetAntTreeList()
        {
            List<Ant> antList = new List<Ant>();
            int i = 0;
            foreach (KnowledgeData knowledge in KnowledgeList)
            {
                Points points = new Points();
                points.StringData.Add(knowledge.UNS);
                points.DigitData.Add(PrepareDigit(knowledge.LPR, 0.99));
                points.DigitData.Add(PrepareDigit(knowledge.PEG, 0.99));
                points.DigitData.Add(PrepareDigit(knowledge.SCG, 0.99));
                points.DigitData.Add(PrepareDigit(knowledge.STG, 0.99));
                points.DigitData.Add(PrepareDigit(knowledge.STR, 0.91));

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
            string path = @"C:\Users\Marcin\Desktop\Magisterka\Data_User_Modeling_Dataset_Hamdi Tolga KAHRAMAN.xls";
            return path;
        }

        public void ReadData()
        {
            string sheetName = "TEST_DATA";
            var survivalFile = new ExcelQueryFactory(GetPath());
            KnowledgeList = (from knowledgeXLS in survivalFile.Worksheet<KnowledgeData>(sheetName) select knowledgeXLS).ToList();
        }
        double PrepareDigit(double digit, double max)
        {
            return digit / max;
        }
    }
}
