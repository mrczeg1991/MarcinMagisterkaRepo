using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntTreeProgram
{
    class Colors
    {
        List<Color> colors = null;
        public Colors()
        {
            colors = new List<Color>()
            {
                Color.Blue,Color.Red,Color.Green,Color.Yellow,Color.Aquamarine,Color.Pink,Color.Purple,Color.GreenYellow
            };
        }
        public Color GetColor(int index)
        {
            if(index<colors.Count())
            {
                return colors[index];
            }
            return Color.Transparent;
        }
    }
}
