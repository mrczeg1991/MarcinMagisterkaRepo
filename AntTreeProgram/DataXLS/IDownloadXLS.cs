using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram.DataXLS
{
    enum DataName
    {
        Iris = 0,
    }
    interface IDownloadXLS
    {
        void ReadData();
        string GetPath();
        List<Ant> GetAntTreeList();
    }
}
