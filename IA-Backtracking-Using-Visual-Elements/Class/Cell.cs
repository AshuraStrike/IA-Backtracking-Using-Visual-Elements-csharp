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

        public Cell(int TerrainId)
        {
            this.TerrainId = TerrainId;
        }
    }
}
