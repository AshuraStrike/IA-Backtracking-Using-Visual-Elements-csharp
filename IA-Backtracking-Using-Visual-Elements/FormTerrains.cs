using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA_Backtracking_Using_Visual_Elements
{
    public partial class FormTerrains : Form
    {
        Map myMap;

        List<int> filteredMapList = new List<int>();

        public FormTerrains(ref Map myMap)
        {
            InitializeComponent();

            this.myMap = myMap;
        }
    }
}
