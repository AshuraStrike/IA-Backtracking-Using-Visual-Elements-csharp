using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_Backtracking_Using_Visual_Elements
{
    public class Map : List<List<Cell>>
    {
        public Map()
        {

        }

        // Deletes all content
        public void Vaciar()
        {
            if (this.Count > 0) {
            for(int i = 0; i < this.Count; i++)
            {
                this[i].Clear();
            }
            this.Clear();
            }
        }
    }
}
