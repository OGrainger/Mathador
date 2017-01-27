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
    public partial class Solutions : Form
    {
        private int i;
        private string tempListElement;
        public Solutions()
        {
            InitializeComponent();
        }

        private void Solutions_Load(object sender, EventArgs e)
        {
            listBoxSolutions.Items.Clear();                                     //On efface la listbox solutions
            Solveur.Solutions.Clear();                                          //On efface la list des solutions
            Solveur Solv = new Solveur();                                       //On appel les methodes du solveur
            List<Solution> solutions = Solv.SolvComplet();
            for (i = 0; i < solutions.Count(); i++)
            {
                tempListElement = solutions[i].score.ToString();
                tempListElement += " : ";
                tempListElement += solutions[i].equations;
                listBoxSolutions.Items.Add(tempListElement);
            }
        }

        private void buttonTerminer_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathadorGame frm = Application.OpenForms.OfType<MathadorGame>().FirstOrDefault();
            if (frm != null)
                frm.FinDeRound();
        }
    }
}
