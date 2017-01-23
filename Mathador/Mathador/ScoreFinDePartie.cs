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
        public ScoreFinDePartie(int OperateurDiv, int OperateurFois, int OperateurPlus, int OperateurMoins, int _Score, int _Round)
        {
            InitializeComponent();
            this.OperateurDiv.Text = OperateurDiv.ToString();
            this.OperateurFois.Text = OperateurFois.ToString();
            this.OperateurMoins.Text = OperateurMoins.ToString();
            this.OperateurPlus.Text = OperateurPlus.ToString();
            this.Score.Text = _Score.ToString();
            this.Round.Text = _Round.ToString();
        }

        private void OperateurPlus_Click(object sender, EventArgs e)
        {

        }
    }
}
