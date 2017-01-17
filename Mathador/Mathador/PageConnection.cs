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
        public string MDP;
        public string Pseudo;
        public PageConnection()
        {
            InitializeComponent();
        }

        private void buttonValiderConnection_Click(object sender, EventArgs e)
        {
            this.Pseudo = textBoxPseudo.Text;
                this.MDP = textBoxMDP.Text;
            SQLiteDatabase db = new SQLiteDatabase();
            db.LaunchDatabase();

            if (db.CheckIfPasswordMatch(this.Pseudo, this.MDP)){
                this.Hide();
                MenuMathador form = new MenuMathador(Pseudo);
                
                form.ShowDialog();
                
            }else{
                ErreurPseudo.Text = "ERREUR";
            }
                
        }
    }
}
