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
    public partial class ScoreFinDePartie : Form
    {
        string pseudo;

        public ScoreFinDePartie(string pseudo, int score, int roundCount, int mathadorCount, int plusCount, int moinsCount, int foisCount, int divCount)
        {
            InitializeComponent();
            this.pseudo = pseudo;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuMathador form = new MenuMathador(pseudo);
            form.ShowDialog();
        }
    }
}
