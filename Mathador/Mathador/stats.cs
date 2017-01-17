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

            db.LaunchDatabase();
            data = db.GetData(this.Pseudo);

            if (data["gameCount"] > 0)
            {
                totalScorePoints = data["totalScorePoints"];
                gameCount = data["gameCount"];
                roundCount = data["roundCount"];
                totalGameTimeInSeconds = data["totalGameTimeInSeconds"];
                
                averageScore = totalScorePoints / gameCount;
                averagePointsPerRound = totalScorePoints / roundCount;
                averageTimePerGame = totalGameTimeInSeconds / gameCount;
                averageTimePerRound = totalGameTimeInSeconds / roundCount;

                useOfAllOp = data["addCount"] + data["subCount"] + data["multCount"] + data["divCount"];
                averageUseOfAdd = data["addCount"] / useOfAllOp;
                averageUseOfSub = data["subCount"] / useOfAllOp;
                averageUseOfMult = data["multCount"] / useOfAllOp;
                averageUseOfDiv = data["divCount"] / useOfAllOp;
            }
            else
            {
                this.Hide();
                MenuMathador form = new MenuMathador(Pseudo);
                form.ShowDialog();
            }
            
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuMathador form = new MenuMathador(Pseudo);
            form.ShowDialog();
        }
    }
}
