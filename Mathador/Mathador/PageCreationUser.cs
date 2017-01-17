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
    public partial class PageCreationUser : Form
    {
        private SQLiteDatabase db = new SQLiteDatabase();
        public string pseudo;
        public string mdp;
        public string mdpVerif;
        public PageCreationUser()
        {
            InitializeComponent();
            db.LaunchDatabase();
            labelErreur.Text = "";
        }

        private void valider_Click(object sender, EventArgs e) {

            this.pseudo = TextBoxPseudo.Text;
            this.mdp = TextBoxMdp.Text;
            this.mdpVerif = TextBoxVerifMdp.Text;

            if (this.pseudo == "" || this.mdp == "" || this.mdpVerif == "")
            {
                labelErreur.Text = "Au moins un champ vide";
            }
            else if (this.mdp != this.mdpVerif)
            {
                labelErreur.Text = "Les mots de passe ne correspondent pas";
            }
            else if (db.CheckIfUserAlreadyExists(this.pseudo))
            {
                labelErreur.Text = "Ce nom est déjà pris !";
            }
            else
            {
                db.CreateANewUser(this.pseudo, this.mdp);
                labelErreur.Text = "Utilisateur créé avec succès !";
                this.Hide();
                MenuMathador form = new MenuMathador();
                form.ShowDialog();
            }
        }
        private void retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageConnection form = new PageConnection();
            form.ShowDialog();
        }
    }
}
