using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IA_Backtracking_Using_Visual_Elements
{
    public class Character
    {
        public Image characterImg;
        public String name;
        public int coordinateX;
        public int coordinateY;

        public Character(String name, Image img, int x, int y)
        {
            this.name = name;
            characterImg = img;
            coordinateX = x;
            coordinateY = y;
        }
    }
}
