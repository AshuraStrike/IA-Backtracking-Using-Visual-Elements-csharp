using IA_Backtracking_Using_Visual_Elements.Class;
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
        Tree tree;


        public FormTreeView(ref List<Move> moveList)
        {
            InitializeComponent();

            tree = new Tree(moveList);
            tree.generateTree();
        }

        private void FormTreeView_Load(object sender, EventArgs e)
        {   //Extract info root
            char a = 'A';
            a += (char) tree.root.posX;
            treeView.Nodes.Add(a + "," + (tree.root.posY + 1) + " " +
                    " Numero de hijos: " + tree.root.numberOfChilds + " " +
                    " Visitas: " + tree.root.visits());
            tree.print(ref treeView);
        }
    }
}
