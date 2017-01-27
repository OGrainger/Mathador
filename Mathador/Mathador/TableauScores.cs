using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathador
{
    public partial class TableauScores : Form
    {
        string pseudo;

        public TableauScores(string pseudo)
        {
            InitializeComponent();
            this.pseudo = pseudo;
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuMathador form = new MenuMathador(this.pseudo);
            form.ShowDialog();
        }
    }
}
