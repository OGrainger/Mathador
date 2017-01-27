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
    public partial class stats : Form
    {
        public string Pseudo;

        public int totalScorePoints;
        public int gameCount;
        public int roundCount;
        public int totalGameTimeInSeconds;

        public float averageScore;
        public float averagePointsPerRound;
        public float averageTimePerGame;
        public float averageTimePerRound;
        public float averageMathadorPerGame;
        public float averageMathadorPerRound;
        public float averageUseOfAdd;
        public float averageUseOfSub;
        public float averageUseOfMult;
        public float averageUseOfDiv;

        public int useOfAllOp;

        private SQLiteDatabase db = new SQLiteDatabase();
        public Dictionary<string, int> data;

        public stats(string Pseudo)
        {
            InitializeComponent();
            this.Pseudo = Pseudo;

            data = db.GetData(this.Pseudo);
            totalScorePoints = data["totalScorePoints"];
            gameCount = data["gameCount"];
            roundCount = data["roundCount"];
            totalGameTimeInSeconds = data["totalGameTimeInSeconds"];
                
            averageScore = Convert.ToSingle(totalScorePoints) / gameCount;
            averagePointsPerRound = Convert.ToSingle(totalScorePoints) / roundCount;
            averageTimePerGame = Convert.ToSingle(totalGameTimeInSeconds) / gameCount;
            averageTimePerRound = Convert.ToSingle(totalGameTimeInSeconds) / roundCount;
            averageMathadorPerGame = Convert.ToSingle(data["mathadorCount"]) / gameCount;
            averageMathadorPerRound = Convert.ToSingle(data["mathadorCount"]) / roundCount;

            useOfAllOp = data["addCount"] + data["subCount"] + data["multCount"] + data["divCount"];
            averageUseOfAdd = Convert.ToSingle(data["addCount"]) / useOfAllOp;
            averageUseOfSub = Convert.ToSingle(data["subCount"]) / useOfAllOp;
            averageUseOfMult = Convert.ToSingle(data["multCount"]) / useOfAllOp;
            averageUseOfDiv = Convert.ToSingle(data["divCount"]) / useOfAllOp;

            labelAveragePointsPerRound.Text = averagePointsPerRound.ToString();
            labelAverageScore.Text = averageScore.ToString();
            labelAverageTimePerRound.Text = averageTimePerRound.ToString() + "s";
            labelGameCount.Text = gameCount.ToString();
            labelRoundCount.Text = roundCount.ToString();
            labelScoreMin.Text = Convert.ToString(data["minScore"]);
            labelScoreMaxi.Text = Convert.ToString(data["maxScore"]);
            labelTotalScore.Text = totalScorePoints.ToString();
            labelTotalTime.Text = totalGameTimeInSeconds.ToString() + "s";
            labelMathadorCount.Text = data["mathadorCount"].ToString();
            labelAverageMathadorPerGame.Text = averageMathadorPerGame.ToString();

            pieChartOp.Series["Series1"].Points.AddXY("+ ("+ Math.Round(averageUseOfAdd, 3, MidpointRounding.AwayFromZero) * 100 +"%)", averageUseOfAdd);
            pieChartOp.Series["Series1"].Points.AddXY("- (" + Math.Round(averageUseOfSub, 3, MidpointRounding.AwayFromZero) * 100 + "%)", averageUseOfSub);
            pieChartOp.Series["Series1"].Points.AddXY(" x ("+ Math.Round(averageUseOfMult, 3, MidpointRounding.AwayFromZero) * 100 +" %)", averageUseOfMult);
            pieChartOp.Series["Series1"].Points.AddXY("÷ (" + Math.Round(averageUseOfDiv, 3, MidpointRounding.AwayFromZero) * 100 + " %)", averageUseOfDiv);

            pieChartMathador.Series["Series1"].Points.AddXY("Mathador (" + Math.Round(averageMathadorPerRound, 3, MidpointRounding.AwayFromZero) * 100 + " %)", averageMathadorPerRound);
            pieChartMathador.Series["Series1"].Points.AddXY("Autres (" + Math.Round(1 - averageMathadorPerRound, 3, MidpointRounding.AwayFromZero) * 100 + " %)", 1 - averageMathadorPerRound);
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuMathador form = new MenuMathador(Pseudo);
            form.ShowDialog();
        }
       
    }
}
