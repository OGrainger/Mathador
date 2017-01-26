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
        string pseudo;

        public ScoreFinDePartie(string pseudo, int score, int roundCount, int mathadorCount, int plusCount, int moinsCount, int foisCount, int divCount)
        {
            InitializeComponent();
            this.pseudo = pseudo;
            Dictionary<string, int> gameData = new Dictionary<string, int>();

            labelScore.Text = score.ToString();
            labelRoundCount.Text = roundCount.ToString();
            labelMathadorCount.Text = mathadorCount.ToString();
            labelPlusCount.Text = plusCount.ToString();
            labelMoinsCount.Text = moinsCount.ToString();
            labelFoisCount.Text = foisCount.ToString();
            labelDivCount.Text = divCount.ToString();

            gameData.Add("gameScore", score);
            gameData.Add("gameTime", 180);
            gameData.Add("roundCount", roundCount);
            gameData.Add("mathadorCount", mathadorCount);
            gameData.Add("addCount", plusCount);
            gameData.Add("subCount", moinsCount);
            gameData.Add("multCount", foisCount);
            gameData.Add("divCount", divCount);

            SQLiteDatabase db = new SQLiteDatabase();
            db.LaunchDatabase();
            db.UpdateData(pseudo, gameData);

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuMathador form = new MenuMathador(pseudo);
            form.ShowDialog();
        }
        
    }
}
