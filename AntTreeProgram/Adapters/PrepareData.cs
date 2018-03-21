using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram.Adapters
{
    class PrepareData
    {
        Dictionary<string, double> maxData = new Dictionary<string, double>();
        Dictionary<string, double> minData = new Dictionary<string, double>();
        public void AddToDicionary(object example, object listData)
        {

            foreach (PropertyInfo property in example.GetType().GetProperties())
            {
                var result = ((IEnumerable)listData).Cast<object>().ToList();
                if (property.PropertyType == typeof(double))
                {
                    string name = property.Name;
                    double max = (double)(from rekord in result select rekord.GetType().GetProperty(name).GetValue(rekord)).ToList().Max();
                    double min = (double)(from rekord in result select rekord.GetType().GetProperty(name).GetValue(rekord)).ToList().Min();
                    minData.Add(name, min);
                    maxData.Add(name, max);
                }
            }
        }
        public double RescaleData(double digit, string name)
        {
            double max = maxData[name];
            double min = minData[name];
            double score = (digit - min) / (max - min);
            return score;

        }
    }
}
