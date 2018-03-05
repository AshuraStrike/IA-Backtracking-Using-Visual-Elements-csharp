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
    public partial class FormNewCharacter : Form
    {
        Character character;
        public FormNewCharacter(ref Character character)
        {
            InitializeComponent();
            this.character = character;
        }
    }
}
