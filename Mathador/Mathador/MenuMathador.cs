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
        private List<string> citations = new List<string>();
        private List<string> auteurs = new List<string>();
        Random rd = new Random();
        int rank;
        int tempRank = 0;

        public MenuMathador(string Pseudo)
        {
            InitializeComponent();
            this.Pseudo = Pseudo;
            AcceptButton = BouttonNouvellePartie;
            CancelButton = BouttonQuitter;
            data = db.GetData(this.Pseudo);
            buttonStats.Enabled = data["gameCount"] > 0;        //N'active le bouton "stats" que si le user a déjà fait au moins une partie
            AcceptButton = BouttonNouvellePartie;
            CancelButton = BouttonQuitter;
            this.Text = "Menu | " + this.Pseudo;
            citations.Add("I have a dream that one day, I will have a matador.");
            auteurs.Add("Martin Luther King");
            citations.Add("La vie est un mystère qu'il faut vivre, et non un mathador à résoudre.");
            auteurs.Add("Mahatma Gandhi");
            citations.Add("Pour critiquer les gens il faut les connaître, et pour les connaître, il faut les battre au Mathador.");
            auteurs.Add("Coluche");
            citations.Add("Placez votre main sur un poêle une minute et ça vous semble durer une heure. Jouez une heure au Mathador et ça vous semble durer une minute. C'est ça la relativité.");
            auteurs.Add("Albert Einstein");
            citations.Add("La nature fait les hommes semblables, le Mathador les rend différents.");
            auteurs.Add("Confucius");
            citations.Add("Un sourire coûte moins cher qu'un Mathador, mais donne autant de bonheur.");
            auteurs.Add("Abbé Pierre");
            citations.Add("Le bonheur est parfois caché dans un mathador.");
            auteurs.Add("Victor Hugo");
            citations.Add("Le mathador est la seule chose qu'on ne regrette jamais.");
            auteurs.Add("Oscar Wilde");
            citations.Add("J'ai appris que le courage n'est pas l'absence de peur, mais la capacité de battre son ennemi au Mathador.");
            auteurs.Add("Nelson Mandela");
            
        }

        private void MenuMathador_Load(object sender, EventArgs e)
        {
            LoadCitation();                                                                 //Chargement des citations
        }

        private void BouttonNouvellePartie_Click(object sender, EventArgs e)
        {
            String Pseudo = this.Pseudo;                                                    //lancement du form MathadorGame et fermeture du form MenuMathador
            this.Hide();
            MathadorGame form = new MathadorGame(Pseudo);
            form.ShowDialog();
        }

        private void BouttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();                                                             //Quitte l'application
        }

        private void buttonStats_Click(object sender, EventArgs e)
        {
            this.Hide();                                                                    //Lance les statistiques
            stats form = new stats(this.Pseudo);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();                                                                    //Retourne sur la page connexion
            PageConnexion form = new PageConnexion();
            form.ShowDialog();
        }

        private void buttonTableauScores_Click(object sender, EventArgs e)
        {
            this.Hide();                                                                    //Affiche les scores
            TableauScores form = new TableauScores(this.Pseudo);
            form.ShowDialog();
        }

        public void LoadCitation()
        {
            rank = rd.Next(citations.Count);                                                //Charge aléatoirement les citations
            tempRank = rank;
            labelCitation.Text = "“" + citations[rank] + "”";
            labelAuteur.Text = auteurs[rank];
        }
    }
}
