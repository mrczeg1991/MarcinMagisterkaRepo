using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram
{
    class PrepareData
    {
        public List<Points> RandomPoints(int lenght)
        {
            Random random = new Random();
            List<Points> radnomList = new List<Points>();
            while(lenght>0)
            {
                Points points = new Points() { X = random.Next(-50, 50), Y = random.Next(-50, 50) };
                radnomList.Add(points);
                lenght--;
            }
            return radnomList;
        }
        public  List<Ant> RandomAnts(int lenght,double TSim, double TDissim)
        {
            Random random = new Random();
            List<Ant> antsList = new List<Ant>();
            while (lenght > 0)
            {
                Ant newAnt = new Ant(TSim, TDissim);
               // newAnt.Points = new Points() { X = random.NextDouble(), Y = random.NextDouble() };
                if(lenght==8) newAnt.Points = new Points() { X = 0, Y = 0 };
                if (lenght == 7) newAnt.Points = new Points() { X = 0.15, Y = 0.15 };
                if (lenght == 6) newAnt.Points = new Points() { X = 0, Y = 1 };
                if (lenght == 5) newAnt.Points = new Points() { X = 0.15, Y = 1};
                if (lenght == 4) newAnt.Points = new Points() { X = 1, Y = 0 };
                if (lenght == 3) newAnt.Points = new Points() { X = 0.9, Y = 0 };
                if (lenght == 2) newAnt.Points = new Points() { X = 1, Y = 1 };
                if (lenght == 1) newAnt.Points = new Points() { X = 0.9, Y =0.9 };

                newAnt.Number = lenght;
                antsList.Add(newAnt);
                lenght--;
            }
            return antsList;
        }
        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
