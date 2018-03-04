using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA_Backtracking_Using_Visual_Elements
{
    public partial class FormMain : Form
    {
        Map mapa;
        const int CELL_WIDTH = 32;

        SolidBrush brushRed;
        Pen pen;
        Font font;
        Graphics graphics;

        ToolTip toolTip;

        Graphics formGraphics;

        Character character;
        Character creature1;
        Character creature2;
        Character creature3;

        Point currentXY = new Point(0,0);

        public FormMain()
        {
            InitializeComponent();
            KeyPreview = true;
            labelRoute.Text = "";
            panelMap.Width = 0;
            panelMap.Height = 0;

            // Inicializa el mapa donde irán las celdas
            mapa = new Map();

            // Graphic elements
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

                // El lector invoca a su método para llenar la estructura mapa
                if (!lector.fillMap(ref mapa))
                {
                    // En caso de fallo, borra todo del mapa y muestra error en el label de ruta
                    mapa.Vaciar();
                    System.Diagnostics.Debug.WriteLine("Algo ha fallado...");
                    labelRoute.ForeColor = Color.Red;
                    labelRoute.Text = "Archivo Inválido!";
                }
            }
            this.Focus();
        }

        private void panelMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentXY.X = e.X / CELL_WIDTH;
                currentXY.Y = e.Y / CELL_WIDTH;
                char a = 'A';
                a += (char) currentXY.X;
                labelSelectedX.Text = a.ToString();
                labelSelectedY.Text = (currentXY.Y+1).ToString();
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (toolTip != null)
                {
                    toolTip.Dispose();
                }
                char letter = 'A';
                letter += (char)((e.X / CELL_WIDTH));
                String text = letter + ((e.Y / CELL_WIDTH) + 1).ToString();
                if (mapa[0][0].TerrainName != null)
                {
                    toolTip = new ToolTip();
                    text += '\n' + mapa[e.Y / CELL_WIDTH][e.X / CELL_WIDTH].TerrainName;
                }

                toolTip = new ToolTip();

                toolTip.Show(text, panelMap, e.X, e.Y - 20, 1000);
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
                panelMap.Refresh();
            }
        }

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            if (mapa.Count > 0)
            {
                panelMap.Width = mapa[0].Count * CELL_WIDTH;
                panelMap.Height = mapa.Count * CELL_WIDTH;

                char a = 'A';

                formGraphics = this.CreateGraphics();

                // Clear Coordenates
                for (int y = 0; y < 15; y++)
                {
                    formGraphics.FillRectangle(new SolidBrush(SystemColors.Control), panelMap.Location.X - CELL_WIDTH - 1, panelMap.Location.Y + (CELL_WIDTH * y), CELL_WIDTH, CELL_WIDTH);
                }

                for (int x = 0; x < 15; x++)
                {
                    formGraphics.FillRectangle(new SolidBrush(SystemColors.Control), panelMap.Location.X + (x * CELL_WIDTH), panelMap.Location.Y - CELL_WIDTH - 1, CELL_WIDTH, CELL_WIDTH);
                }

                // Draw Coordenates
                for (int y = 0; y < mapa.Count; y++)
                {
                    //formGraphics.DrawRectangle(pen, panelMapa.Location.X - CELL_WIDTH - 1, panelMapa.Location.Y+(CELL_WIDTH*y), CELL_WIDTH, CELL_WIDTH);
                    string text = (y + 1).ToString();
                    formGraphics.DrawString(text, font, brushRed, panelMap.Location.X - CELL_WIDTH - 1, panelMap.Location.Y + (y * CELL_WIDTH) + (CELL_WIDTH / 2) - 7f);
                }

                for (int x = 0; x < mapa[0].Count; x++)
                {
                    //formGraphics.DrawRectangle(pen, panelMapa.Location.X+(x*CELL_WIDTH), panelMapa.Location.Y - CELL_WIDTH - 1, CELL_WIDTH, CELL_WIDTH);
                    string text = a.ToString();
                    formGraphics.DrawString(text, font, brushRed, panelMap.Location.X + (x * CELL_WIDTH), panelMap.Location.Y - (CELL_WIDTH / 2) - 7f);
                    a += (char)1;
                }
            }
        }

        private void panelMap_Paint(object sender, PaintEventArgs e)
        {
            graphics = panelMap.CreateGraphics();
            if (mapa.Count<1)
            {
                for (int i = 0; i < mapa.Count; i++)
                {
                    for (int j = 0; j < mapa[0].Count; j++)
                    {
                        graphics.DrawImage(mapa[i][j].texture, j * CELL_WIDTH, i * CELL_WIDTH);
                    }
                }
            }
            if(character != null)
            graphics.DrawImage(character.characterImg, character.coordinateX * CELL_WIDTH, character.coordinateY * CELL_WIDTH);
        }

        

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            buttonExamine.Enabled = false;
            buttonPlay.Enabled = false;
            GroundButton.Enabled = false;
        }

        private void FormMain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.Up:
                case Keys.Left:
                case Keys.Right:
                    e.IsInputKey = true;
                    break;
            }
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (character != null)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        if (character.coordinateX > 0)
                            character.coordinateX -= 1;
                        break;
                    case Keys.Right:
                        if (character.coordinateX < mapa[0].Count - 1)
                            character.coordinateX += 1;
                        break;
                    case Keys.Up:
                        if (character.coordinateY > 0)
                            character.coordinateY -= 1;
                        break;
                    case Keys.Down:
                        if (character.coordinateY < mapa.Count - 1)
                            character.coordinateY += 1;
                        break;
                }
                panelMap.Refresh();
            }
        }

        private void buttonCharacter_Click(object sender, EventArgs e)
        {
            character = new Character("Tu gfa", Properties.Resources.magma, currentXY.X, currentXY.Y);
            panelMap.Refresh();
        }
    }
}
