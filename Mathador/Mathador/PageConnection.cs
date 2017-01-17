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
    public partial class PageConnection : Form
    {
        private SQLiteDatabase db = new SQLiteDatabase();
        public string MDP;
        public string Pseudo;
        public PageConnection()
        {
            InitializeComponent();
            db.LaunchDatabase();
            ErreurPseudo.Text = "";
        }

        private void buttonValiderConnection_Click(object sender, EventArgs e)
        {
            this.Pseudo = textBoxPseudo.Text;
            this.MDP = textBoxMDP.Text;
            if (this.Pseudo == "" || this.MDP == "")
            {
                ErreurPseudo.Text = "Au moins un champ vide";
            }
            else if (db.CheckIfPasswordMatch(this.Pseudo, this.MDP))
            {
                this.Hide();
                MenuMathador form = new MenuMathador(Pseudo);
                form.ShowDialog();
            }
            else
            {
                ErreurPseudo.Text = "Connexion impossible";
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageCreationUser form = new PageCreationUser();
            form.ShowDialog();
        }
    }
}
