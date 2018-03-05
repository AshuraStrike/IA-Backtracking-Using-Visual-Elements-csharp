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
        public int coordinateX;
        public int coordinateY;

        public List<IdCost> idCostList;

        public Character(Image img, int x, int y)
        {
            characterImg = img;
            coordinateX = x;
            coordinateY = y;
        }

        public Character()
        {

        }
    }
}
