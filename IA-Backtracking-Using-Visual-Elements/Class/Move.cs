using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_Backtracking_Using_Visual_Elements.Class
{
    public class Move
    {
        public int coordX;
        public int coordY;
        public int childNumber;
        public int currentStep;

        public Move(int coordX, int coordY, int childNumber, int currentStep)
        {
            this.coordX = coordX;
            this.coordY = coordY;
            this.childNumber = childNumber;
            this.currentStep = currentStep;
        }
    }
}
