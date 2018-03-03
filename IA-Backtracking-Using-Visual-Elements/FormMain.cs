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
    public partial class FormMain : Form
    {
        Map mapa;
        const int CELL_WIDTH = 32;

        SolidBrush brushRed;
        SolidBrush brushWhite;
        Pen pen;
        Font font;

        ToolTip toolTip;

        public FormMain()
        {
            InitializeComponent();
            labelRoute.Text ="";
            panelMap.Width = 0;
            panelMap.Height = 0;

            // Inicializa el mapa donde irán las celdas
            mapa = new Map();

            // Graphic elements
            brushWhite = new SolidBrush(Color.White);
            brushRed = new SolidBrush(Color.Red);
            pen = new Pen(Color.Black);

            font = new Font("Arial", 8.0f, FontStyle.Regular);
        }

        private void buttonExamine_Click(object sender, EventArgs e)
        {
            // Inicializa el dialogo de buscar archivo
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = "//";
            openFile.Filter = "All files (*.*)|*.*|Txt files (*.txt)|*.txt";
            openFile.FilterIndex = 2;
            openFile.RestoreDirectory = true;

            // Verifica que se haya seleccionado un archivo
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // El lector se inicializa con la ruta del archivo
                Reader lector = new Reader(openFile.FileName);
                labelRoute.ForeColor = Color.Black;
                labelRoute.Text = openFile.SafeFileName;

                mapa.Clear();

                panelMap.CreateGraphics().Clear(Color.White);

                // El lector invoca a su método para llenar la estructura mapa
                if (!lector.fillMap(ref mapa))
                {
                    // En caso de fallo, borra todo del mapa y muestra error en el label de ruta
                    mapa.Vaciar();
                    System.Diagnostics.Debug.WriteLine("Algo ha fallado...");
                    labelRoute.ForeColor = Color.Red;
                    labelRoute.Text = "Archivo Inválido!";
                }
                else
                {
                    panelMap.Width = mapa[0].Count * CELL_WIDTH;
                    panelMap.Height = mapa.Count * CELL_WIDTH;

                    char a = 'A';

                    Graphics formGraphics = this.CreateGraphics();

                    // Clear Coordenates
                    for (int y = 0; y < 15; y++)
                    {
                        formGraphics.FillRectangle(new SolidBrush(SystemColors.Control), panelMap.Location.X - CELL_WIDTH - 1, panelMap.Location.Y+(CELL_WIDTH*y), CELL_WIDTH, CELL_WIDTH);
                    }

                    for (int x = 0; x < 15; x++)
                    {
                        formGraphics.FillRectangle(new SolidBrush(SystemColors.Control), panelMap.Location.X+(x*CELL_WIDTH), panelMap.Location.Y - CELL_WIDTH - 1, CELL_WIDTH, CELL_WIDTH);
                    }

                    // Draw Coordenates
                    for (int y = 0; y < mapa.Count; y++)
                    {
                        //formGraphics.DrawRectangle(pen, panelMapa.Location.X - CELL_WIDTH - 1, panelMapa.Location.Y+(CELL_WIDTH*y), CELL_WIDTH, CELL_WIDTH);
                        string text = (y+1).ToString();
                        formGraphics.DrawString(text, font, brushRed, panelMap.Location.X - CELL_WIDTH - 1, panelMap.Location.Y+(y*CELL_WIDTH) + (CELL_WIDTH / 2) - 7f);
                    }

                    for (int x = 0; x < mapa[0].Count; x++)
                    {
                        //formGraphics.DrawRectangle(pen, panelMapa.Location.X+(x*CELL_WIDTH), panelMapa.Location.Y - CELL_WIDTH - 1, CELL_WIDTH, CELL_WIDTH);
                        string text = a.ToString();
                        formGraphics.DrawString(text, font, brushRed, panelMap.Location.X+(x*CELL_WIDTH), panelMap.Location.Y - (CELL_WIDTH/2)-7f);
                        a += (char)1;
                    }

                    //DEBUG!!! Muestra el contenido del mapa
                    for (int i = 0; i < mapa.Count; i++)
                    {
                        for(int j = 0; j < mapa[i].Count; j++)
                        {
                            System.Diagnostics.Debug.Write(mapa[i][j].Value+" ");
                        }
                        System.Diagnostics.Debug.WriteLine(" ");
                    }
                }/*</DEBUG>!!!*/
            }
        }

        private void panelMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Not Final Version
                Graphics graphics = panelMap.CreateGraphics();

                String text = mapa[e.Y / CELL_WIDTH][e.X / CELL_WIDTH].Value.ToString();

                int cell_x = e.X - (e.X % CELL_WIDTH);
                int cell_y = e.Y - (e.Y % CELL_WIDTH);

                graphics.FillRectangle(brushWhite, cell_x, cell_y, CELL_WIDTH, CELL_WIDTH);
                graphics.DrawRectangle(pen, cell_x, cell_y, CELL_WIDTH, CELL_WIDTH);
                graphics.DrawString(text, font, brushRed, cell_x, cell_y);
            }else if(e.Button == MouseButtons.Right)
            {
                if (toolTip != null)
                {
                    toolTip.Dispose();
                }
                toolTip = new ToolTip();

                toolTip.Show(mapa[e.Y / CELL_WIDTH][e.X / CELL_WIDTH].Value.ToString(), panelMap, e.X, e.Y-20, 1000);
            }
        }

        private void GroundButton_Click(object sender, EventArgs e)
        {
            if (mapa.Count < 1)
            {
                MessageBox.Show("Debe cargar un mapa primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormTerrains GroundWindow = new FormTerrains(ref mapa);
                GroundWindow.ShowDialog();
            }
        }
    }
}
