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
        public Dictionary<string, int> data;
        private SQLiteDatabase db = new SQLiteDatabase();
        public string Pseudo;
        public MenuMathador(string Pseudo, int gameCount)
        {
            InitializeComponent();
            BienvenuePseudo.Text = "Bienvenue " + Pseudo + " !";
            this.Pseudo = Pseudo;
            buttonStats.Enabled = gameCount > 0;
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

        private void buttonStats_Click(object sender, EventArgs e)
        {
            this.Hide();
            stats form = new stats(this.Pseudo);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageConnection form = new PageConnection();
            form.ShowDialog();
        }

    }
}
