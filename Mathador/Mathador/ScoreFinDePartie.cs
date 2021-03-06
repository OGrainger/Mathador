﻿using System;
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

            AcceptButton = buttonRestart;
            CancelButton = buttonMenu;

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

            SQLiteDatabase db = new SQLiteDatabase();                                                       //Ajoute les scores data base
            db.UpdateData(pseudo, gameData);
            db.AddScore(pseudo, score);
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();                                                                                    //Retourne au menu du jeu
            MenuMathador form = new MenuMathador(pseudo);
            form.ShowDialog();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            this.Hide();                                                                                    //Retourne au form du jeu MathadorGame
            MathadorGame form = new MathadorGame(pseudo);
            form.ShowDialog();
        }
    }
}
