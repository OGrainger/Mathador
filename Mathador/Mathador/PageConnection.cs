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
    public partial class PageConnexion : Form
    {
        public Dictionary<string, int> data;
        private SQLiteDatabase db = new SQLiteDatabase();
        public string MDP;
        public string Pseudo;
        int gameCount;

        public PageConnexion()
        {
            InitializeComponent();
            db.LaunchDatabase();
            ErreurPseudo.Text = "";
            AcceptButton = buttonValiderConnexion;
            CancelButton = quit;
            
        }

        private void buttonValiderConnexion_Click(object sender, EventArgs e)
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
                data = db.GetData(this.Pseudo);
                gameCount = data["gameCount"];
                MenuMathador form = new MenuMathador(Pseudo, gameCount);
                form.ShowDialog();
            }
            else
            {
                ErreurPseudo.Text = "Connexion impossible";
            }
                
        }

        private void newUser_click(object sender, EventArgs e)
        {
            this.Hide();
            PageCreationUser form = new PageCreationUser();
            form.ShowDialog();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
