using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram.DataXLS
{
    public enum XLSData
    {
        Iris, Wina, Glass, Survival, Knowledge
    }
    class FabrykaXLS
    {
        public static IDownloadXLS CreateXLSObject(XLSData name)
        {
            IDownloadXLS objectXLS=null;
            switch(name)
            {
            
                case (XLSData.Wina):
                    {
                        objectXLS = new DownloadXLSWine();
                    }break;
                case (XLSData.Iris):
                    {
                        objectXLS = new DownloadXLSIris();
                    }
                    break;
                case (XLSData.Glass):
                    {
                        objectXLS = new DownloadXLSGlass();
                    }
                    break;
                case (XLSData.Survival):
                    {
                        objectXLS = new DownloadXLSSurvival();
                    }
                    break;
                case (XLSData.Knowledge):
                    {
                        objectXLS = new DownloadXLSKnowledge();
                    }
                    break;
            }
            return objectXLS;
        }
    }
}
