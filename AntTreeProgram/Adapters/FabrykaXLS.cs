using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram.DataXLS
{
    public enum XLSData
    {
        Iris, Wina, Szkła, Przeżycia, Wiedza
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
                case (XLSData.Szkła):
                    {
                        objectXLS = new DownloadXLSGlass();
                    }
                    break;
                case (XLSData.Przeżycia):
                    {
                        objectXLS = new DownloadXLSSurvival();
                    }
                    break;
                case (XLSData.Wiedza):
                    {
                        objectXLS = new DownloadXLSKnowledge();
                    }
                    break;
            }
            return objectXLS;
        }
    }
}
