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
        List<string> nameList { get; set; } = new List<string>();
        PrepareData prepareData = new PrepareData();

        public List<Ant> GetAntTreeList()
        {
            List<Ant> antList = new List<Ant>();
            int i = 1;
            foreach (KnowledgeData knowledge in KnowledgeList)
            {
                Points points = new Points();
                points.StringData.Add(knowledge.UNS);
                if (!nameList.Exists(a => a == knowledge.UNS)) nameList.Add(knowledge.UNS);
                points.DigitData.Add(prepareData.RescaleData(knowledge.LPR,"LPR"));
                points.DigitData.Add(prepareData.RescaleData(knowledge.PEG,"PEG"));
                points.DigitData.Add(prepareData.RescaleData(knowledge.SCG, "SCG"));
                points.DigitData.Add(prepareData.RescaleData(knowledge.STG, "STG"));
                points.DigitData.Add(prepareData.RescaleData(knowledge.STR, "STR"));

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
            return KnowledgeList;
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
            KnowledgeData knowledge = new KnowledgeData();
            prepareData.AddToDicionary(knowledge, KnowledgeList);
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
