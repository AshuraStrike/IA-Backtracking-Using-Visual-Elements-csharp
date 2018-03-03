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

            // Cambia la textura en el pictureBox como preview
            // debe hacerlo cuando se cambie el terreno en el comboBox
            // el nombre va sin corchetes
            ///pictureBoxTerrain.Image = Properties.Resources.[Nombres];

            filterGround();
        }

        //method filter the repeted numbers
        void filterGround()
        {
            int j;
            filteredMapList.Add(myMap[0][0].Value);

            for (int i = 0; i < myMap.Count; i++)
            {
                j = 0;

                do
                {
                    if (!filteredMapList.Contains(myMap[i][j].Value))
                    {
                        filteredMapList.Add(myMap[i][j].Value);
                    }

                    j++;
                }
                while (j < filteredMapList.Count);
            }
        }

        private void FormTerrains_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < filteredMapList.Count; i++)
            {
                GroundListBox.Items.Add(filteredMapList[i]);
            }

            //set index in listBox for comfort
            GroundListBox.SetSelected(0, true);
        }
    }
}
