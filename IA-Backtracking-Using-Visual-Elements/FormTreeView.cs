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
    public partial class FormTreeView : Form
    {
        public FormTreeView()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            TreeView.Nodes.Add("Hola");

            TreeView.Nodes[0].Nodes.Add("Hola 1");
            TreeView.Nodes[0].Nodes.Add("Hola 2");
            TreeView.Nodes[0].Nodes.Add("Hola 3");
        }
    }
}
