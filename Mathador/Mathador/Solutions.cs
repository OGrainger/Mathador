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
        public Solutions()
        {
            InitializeComponent();
        }

        private void Solutions_Load(object sender, EventArgs e)
        {
            listBoxSolutions.Items.Clear();                                     //On efface la list solutions
            Solveur.equations.Clear();                                          //On efface la listbox des solutions
            Solveur Solv = new Solveur();
            Solv.SolvComplet();
            //On appel les methodes du solveur
            /*Solv.TabSigne();
            Solv.SolvOneOp();
            Solv.SolvTowOp();
            Solv.SolvTrheeOp();
            Solv.SolvfourOp();*/

            foreach (string Item in Solveur.equations)                          //On ecrit les solutions de la list du solveur dans la listbox des solutions
            {
                listBoxSolutions.Items.Add(Item);
            }
        }

        private void buttonTerminer_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathadorGame frm = Application.OpenForms.OfType<MathadorGame>().FirstOrDefault();
            if (frm != null)
                frm.methsuivant();
        }
    }
}
