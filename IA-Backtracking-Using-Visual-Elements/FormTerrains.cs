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

        List<Cell> noRepeatNumber = new List<Cell>();

        public FormTerrains(ref Map myMap)
        {
            InitializeComponent();

            this.myMap = myMap;

            noRepeat();

            GroundListBox.Enabled = false;
            GroundTypeComboBox.SelectedIndex = 0;
        }

        //Filtra los terrenos para que no se repitan
        void noRepeat()
        {
            bool repeated;

            for(int i = 0; i < myMap.Count; i++)
            {
                for(int j = 0; j < myMap[0].Count; j++)
                {
                    repeated = false;

                    for(int z = 0; z < noRepeatNumber.Count; z++)
                    {
                        if(noRepeatNumber[z].TerrainId == myMap[i][j].TerrainId)
                        {
                            repeated = true;
                        }
                    }

                    if(!repeated)
                    {
                        noRepeatNumber.Add(new Cell(myMap[i][j].TerrainId));
                    }
                }
            }
        }

        private void FormTerrains_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < noRepeatNumber.Count; i++)
            {
                GroundListBox.Items.Add(noRepeatNumber[i].TerrainId);
            }

            //set index in listBox for comfort
            GroundListBox.SetSelected(0, true);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            string TerrainName;
            Image texture;

            texture = pictureBoxTerrain.Image;
            TerrainName = GroundTypeComboBox.Items[GroundTypeComboBox.SelectedIndex].ToString();

            noRepeatNumber[GroundListBox.SelectedIndex].texture = texture;
            noRepeatNumber[GroundListBox.SelectedIndex].TerrainName = TerrainName;
            
            //DEBUG imprimir todo el contenido de la lista noRepeatNumber
            for (int i = 0; i < noRepeatNumber.Count; i++)
            {
                Console.WriteLine("Lista: " + noRepeatNumber[i].TerrainId + " " + noRepeatNumber[i].TerrainName + " " + noRepeatNumber[i].texture);
            }

            //Cierra la ventana cuando hemos terminado
            int last = GroundListBox.Items.Count - 1;
            if (GroundListBox.SelectedIndex == last)
            {
                //reemplaza las viejas celdas por las nuevas con los nuevos atributos
                for(int i = 0; i < myMap.Count; i++)
                {
                    for(int j = 0; j < myMap[0].Count; j++)
                    {
                        for(int z = 0; z < myMap.Count; z++)
                        {
                            myMap[i][j] = noRepeatNumber[z];
                            Console.WriteLine("noRepeat: " + myMap[i][j].TerrainId + " " + myMap[i][j].TerrainName + " " + myMap[i][j].texture);
                            break;
                        }
                    }
                }
                this.Close();
            }
            else
            {
                GroundListBox.SelectedIndex++;
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {

        }

        //tipos de terreno en combobox
        private void GroundTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(GroundTypeComboBox.SelectedIndex)
            {
                    //Tierra
                case 0:
                    pictureBoxTerrain.Image = Properties.Resources.dirt;
                    break;
                
                    //Agua
                case 1:
                    pictureBoxTerrain.Image = Properties.Resources.water;
                    break;
                
                    // Pradera
                case 2:
                    pictureBoxTerrain.Image = Properties.Resources.grass_path_top;
                    break;
                
                    // Bosque
                case 3:
                    pictureBoxTerrain.Image = Properties.Resources.forest;
                    break;

                    //Montaña
                case 4:
                    pictureBoxTerrain.Image = Properties.Resources.cobblestone;
                    break;

                    //Arena
                case 5:
                    pictureBoxTerrain.Image = Properties.Resources.sand;
                    break;

                    //Desierto
                case 6:
                    pictureBoxTerrain.Image = Properties.Resources.sand;
                    break;

                    //Pantano
                case 7:
                    pictureBoxTerrain.Image = Properties.Resources.farmland_dry;
                    break;

                    //Rio
                case 8:
                    pictureBoxTerrain.Image = Properties.Resources.water;
                    break;

                    //Jungla
                case 9:
                    pictureBoxTerrain.Image = Properties.Resources.door_spruce_lower;
                    break;

                    // Lava
                case 10:
                    pictureBoxTerrain.Image = Properties.Resources.magma;
                    break;
            }
        }
    }
}
