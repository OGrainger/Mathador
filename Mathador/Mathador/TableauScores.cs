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
    public partial class TableauScores : Form
    {
        string pseudo;
        int i;

        public TableauScores(string pseudo)
        {
            InitializeComponent();
            this.pseudo = pseudo;
        }

        private void TableauScores_Load_1(object sender, EventArgs e)
        {
            SQLiteDatabase db = new SQLiteDatabase();
            List<ScorePair> top10scores = db.ReadScoreTable();
            switch (top10scores.Count)
            {
                case 10:
                    ScorePair pairTemp = top10scores[9];
                    labelName10.Text = pairTemp.labelForRest()[1];
                    labelScore10.Text = pairTemp.labelForRest()[0];
                    goto case 9;
                case 9:
                    pairTemp = top10scores[8];
                    labelName9.Text = pairTemp.labelForRest()[1];
                    labelScore9.Text = pairTemp.labelForRest()[0];
                    goto case 8;
                case 8:
                    pairTemp = top10scores[7];
                    labelName8.Text = pairTemp.labelForRest()[1];
                    labelScore8.Text = pairTemp.labelForRest()[0];
                    goto case 7;
                case 7:
                    pairTemp = top10scores[6];
                    labelName7.Text = pairTemp.labelForRest()[1];
                    labelScore7.Text = pairTemp.labelForRest()[0];
                    goto case 6;
                case 6:
                    pairTemp = top10scores[5];
                    labelName6.Text = pairTemp.labelForRest()[1];
                    labelScore6.Text = pairTemp.labelForRest()[0];
                    goto case 5;
                case 5:
                    pairTemp = top10scores[4];
                    labelName5.Text = pairTemp.labelForRest()[1];
                    labelScore5.Text = pairTemp.labelForRest()[0];
                    goto case 4;
                case 4:
                    pairTemp = top10scores[3];
                    labelName4.Text = pairTemp.labelForRest()[1];
                    labelScore4.Text = pairTemp.labelForRest()[0];
                    goto case 3;
                case 3:
                    pairTemp = top10scores[2];
                    labelTroisieme.Text = pairTemp.labelForTop3();
                    goto case 2;
                case 2:
                    pairTemp = top10scores[1];
                    labelDeuxieme.Text = pairTemp.labelForTop3();
                    goto case 1;
                case 1:
                    pairTemp = top10scores[0];
                    labelPremier.Text = pairTemp.labelForTop3();
                    break;
            }
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuMathador form = new MenuMathador(this.pseudo);
            form.ShowDialog();
        }

        
    }
}
