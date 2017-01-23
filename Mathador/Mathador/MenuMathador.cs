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
    public partial class MenuMathador : Form
    {
        public string Pseudo;
        public MenuMathador(string Pseudo)
        {
            InitializeComponent();
            BienvenuePseudo.Text = "Bienvenue " + Pseudo + " !";
            this.Pseudo = Pseudo;
        }


        private void BouttonNouvellePartie_Click(object sender, EventArgs e)
        {
            String Pseudo = this.Pseudo;
            this.Hide();
            MathadorGame form = new MathadorGame(Pseudo);
            form.ShowDialog();
            
        }

        private void BouttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BouttonScore_Click(object sender, EventArgs e)
        {
            MathadorGame form = new MathadorGame(this.Pseudo);
            form.ShowDialog();
            this.Close();
        }

      
    }
}
