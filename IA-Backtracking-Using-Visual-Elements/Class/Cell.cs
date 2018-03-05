using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IA_Backtracking_Using_Visual_Elements
{
    public class Cell
    {
        public int TerrainId;
        public string TerrainName;
        public Image texture;
        public List<int> listSteps;

        public Cell(int TerrainId)
        {
            this.TerrainId = TerrainId;
        }

        public Cell(int TerrainId, string TerrainName, Image img)
        {
            this.TerrainId = TerrainId;
            this.TerrainName = TerrainName;
            texture = img;
            listSteps = new List<int>();
        }

        public string listStepsString()
        {
            string text = "";
            if (this.listSteps.Count>0) {
                text += listSteps[0];
                for (int i = 1; i < listSteps.Count; i++)
                {
                    text += ',';
                    if ((i) % 2 == 0) text += '\n';
                    text += this.listSteps[i];
                }
            }
            return text;
        }
    }
}
