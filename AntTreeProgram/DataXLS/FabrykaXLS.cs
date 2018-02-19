using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram.DataXLS
{
    public enum XLSData
    {
        Iris, Wine
    }
    class FabrykaXLS
    {
        public static IDownloadXLS CreateXLSObject(XLSData name)
        {
            IDownloadXLS objectXLS = new DownloadXLSIris();
            switch(name)
            {
                case (XLSData.Iris):
                    {
                        objectXLS = new DownloadXLSIris();
                    }
                    break;
                case (XLSData.Wine):
                    {
                        objectXLS = new DownloadXLSWine();
                    }break;
            }
            return objectXLS;
        }
    }
}
