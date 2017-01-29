using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathador
{
   
    public partial class MathadorGame : Form
    {
        public Solveur Solv= new Solveur();
        public int saveOperateurPlusCount = 0;
        public int saveOperateurMoinsCount = 0;
        public int saveOperateurFoisCount = 0;
        public int saveOperateurDivCount = 0;
        public int calculsCount = 0;

        public int resultat;
        public int PointsRound = 0;
        public static int cible;
        public int tentatives = 1;
        public bool finDePartie = false;
        public bool pause = true;

        Button buttonPremierChiffre;
        Button buttonDeuxiemeChiffre;
        Button buttonOp;

        public string pseudo;

        public static Random random = new Random();
        public static int[] tableau = new int[5];

        public int round = 0;
        public int score = 0;
        public int plusCount = 0;
        public int moinsCount = 0;
        public int foisCount = 0;
        public int divCount = 0;
        public int mathadorCount = 0;

        public MathadorGame(String Pseudo)
        {
            InitializeComponent();
            this.pseudo = Pseudo;

            AcceptButton = ButtonSuivant;

            buttonMathador.Hide();
        }

        private void MathadorGame_Load(object sender, EventArgs e)
        {
            //Initialisation du timer
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();

            //Message box au lancement
            MessageBox.Show( pseudo + ", êtes-vous prêt ?",
            "Message",
            MessageBoxButtons.OK,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);
            pause = false;

            Generateur();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Chaque seconde...
            if (!pause) // Si ce n'est pas en pause (message box du début, ou affichage des solutions)
            {
            if (progressBar.Value == progressBar.Maximum && !finDePartie) // Fin de partie si la barre atteint le max
                {
                    finDePartie = true;
                    FinDePartie();
                }
                else if (progressBar.Value < progressBar.Maximum) // Sinon incrémenter la barre
                {
                    progressBar.Value++;
                }
            }
        }
            

        public void Generateur()
        {
            int nb1, nb2, nb3, nb4, nb5;
            float cibleFloat;

            nb1 = random.Next(1, 20);
            nb2 = random.Next(1, 20);
            nb3 = random.Next(1, 12);
            nb4 = random.Next(1, 12);
            nb5 = random.Next(1, 12);

            //Cible calculé à partir des nombres
            cibleFloat = (((Convert.ToSingle(nb1) + Convert.ToSingle(nb2)) - Convert.ToSingle(nb3)) * Convert.ToSingle(nb4)) / Convert.ToSingle(nb5);

            if (cibleFloat > 0 && cibleFloat < 100 && cibleFloat % 1 == 0) //Si la cible correspond aux critères, notamment qu'il est entier
            {
                data datatest = new data();

                datatest.Cible = Convert.ToInt32(cibleFloat);
                datatest.Nombre1 = nb1;
                datatest.Nombre2 = nb2;
                datatest.Nombre3 = nb3;
                datatest.Nombre4 = nb4;
                datatest.Nombre5 = nb5;
                string json = JsonConvert.SerializeObject(datatest);
                string jsonFormat = JValue.Parse(json).ToString(Formatting.Indented);
                System.IO.File.WriteAllText("generation.txt", jsonFormat);
                Console.WriteLine("{0} tentative(s) de génération", tentatives);
                RecupGeneration();
            }
            else //Sinon on relance la génération
            {
                tentatives++;
                Generateur();
            }
        }

        public void RecupGeneration()
        {
            string text = System.IO.File.ReadAllText("generation.txt");
            data json = JsonConvert.DeserializeObject<data>(text);

            cible = json.Cible;
            labelCible.Text = cible.ToString();

            int[] tableauTemp = new int[5];

            tableauTemp[0] = json.Nombre1;
            tableauTemp[1] = json.Nombre2;
            tableauTemp[2] = json.Nombre3;
            tableauTemp[3] = json.Nombre4;
            tableauTemp[4] = json.Nombre5;

            tableau = tableauTemp.OrderBy(x => random.Next()).ToArray();

            ButtonNombre1.Text = tableau[0].ToString();
            ButtonNombre2.Text = tableau[1].ToString();
            ButtonNombre3.Text = tableau[2].ToString();
            ButtonNombre4.Text = tableau[3].ToString();
            ButtonNombre5.Text = tableau[4].ToString();
        }

        public void Reset()
        {
            //Reset de l'affichage et des selections
            this.saveOperateurDivCount = 0;
            this.saveOperateurFoisCount = 0;
            this.saveOperateurMoinsCount = 0;
            this.saveOperateurPlusCount = 0;
            buttonPremierChiffre = null;
            buttonDeuxiemeChiffre = null;
            ButtonNombre1.Enabled = true;
            ButtonNombre2.Enabled = true;
            ButtonNombre3.Enabled = true;
            ButtonNombre4.Enabled = true;
            ButtonNombre5.Enabled = true;
            ButtonNombre1.BackColor = Color.White;
            ButtonNombre2.BackColor = Color.White;
            ButtonNombre3.BackColor = Color.White;
            ButtonNombre4.BackColor = Color.White;
            ButtonNombre5.BackColor = Color.White;
            ButtonPlus.BackColor = Color.White;
            ButtonMoins.BackColor = Color.White;
            ButtonFois.BackColor = Color.White;
            ButtonDiv.BackColor = Color.White;
            buttonOp = null;
    }

        public void Calcul()
        {
            int premierChiffre = Int32.Parse(buttonPremierChiffre.Text);
            int deuxiemeChiffre = Int32.Parse(buttonDeuxiemeChiffre.Text);
            bool calculFait = true;

            if (buttonOp == ButtonPlus)
            {
                resultat = premierChiffre + deuxiemeChiffre;
                saveOperateurPlusCount++;
                PointsRound += 1;

            }
            else if (buttonOp == ButtonMoins)
            {
                if (premierChiffre - deuxiemeChiffre >= 0) // Si le résultat n'est pas négatif
                {
                    resultat = premierChiffre - deuxiemeChiffre;
                    saveOperateurMoinsCount++;
                    PointsRound += 2;
                }
                else //Sinon mettre en rouge l'opérateur
                {
                    buttonOp.BackColor = Color.Red;
                    calculFait = false;
                }
            }
            else if (buttonOp == ButtonFois)
            {
                resultat = premierChiffre * deuxiemeChiffre;
                saveOperateurFoisCount++;
                PointsRound += 1;
            }
            else if (buttonOp == ButtonDiv)
            {
                if (premierChiffre % deuxiemeChiffre == 0 || deuxiemeChiffre == 0) //Si le résultat est entier et qu'on ne divise pas par zéro
                {
                    resultat = premierChiffre / deuxiemeChiffre;
                    saveOperateurDivCount++;
                    PointsRound += 3;
                }
                else
                {
                    buttonOp.BackColor = Color.Red;
                    calculFait = false;
                }
            }
            if (calculFait)
            {
                buttonPremierChiffre.Enabled = false;
                buttonPremierChiffre.BackColor = Color.White;
                buttonPremierChiffre.Text = "";
                buttonDeuxiemeChiffre.Text = resultat.ToString();
                buttonPremierChiffre = buttonDeuxiemeChiffre;
                buttonPremierChiffre.BackColor = Color.LightBlue;
                buttonDeuxiemeChiffre = null;
                buttonOp.BackColor = Color.White;
                buttonOp = null;
                calculsCount++;
                labelScore.Text = score.ToString() + " + " + PointsRound.ToString();
                Console.WriteLine("{0}e calcul", calculsCount);
                if (calculsCount == 4)
                {
                    FinDeRound();
                }
            }
        }

        public void FinDeRound()
        {
            //Si la cible est trouvée
            if (ButtonNombre1.Text == cible.ToString() || ButtonNombre2.Text == cible.ToString() || ButtonNombre3.Text == cible.ToString() || ButtonNombre4.Text == cible.ToString() || ButtonNombre5.Text == cible.ToString())
            {
                //S'il y a mathador
                if (saveOperateurDivCount > 0 && saveOperateurFoisCount > 0 && saveOperateurMoinsCount > 0 && saveOperateurPlusCount > 0)
                {
                    mathadorCount++;
                    score += 13;
                    buttonMathador.Show();
                    if (mathadorCount > 1) { buttonMathador.Text = "MATHADOR x " + mathadorCount; }
                } 
                else
                {
                    score += PointsRound;
                }
            }
            pause = false;
            round++;
            plusCount += saveOperateurPlusCount;
            moinsCount += saveOperateurMoinsCount;
            foisCount += saveOperateurFoisCount;
            divCount += saveOperateurDivCount;

            labelScore.Text = score.ToString();
            PointsRound = 0;
            calculsCount = 0;
            tentatives = 1;
            Reset();
            Generateur();
        }

        public void FinDePartie()
        {
            finDePartie = true;
            this.Hide();
            ScoreFinDePartie form = new ScoreFinDePartie(this.pseudo, score, round, mathadorCount, plusCount, moinsCount, foisCount, divCount);
            form.ShowDialog();
        }

        //=========== ================= Clicks ==============================================================
        
        private void ButtonNombre1_Click(object sender, EventArgs e)
        {
            if (buttonPremierChiffre == null && buttonDeuxiemeChiffre != ButtonNombre1)
            {
                buttonPremierChiffre = ButtonNombre1;
                ButtonNombre1.BackColor = Color.LightBlue;
            }
            else if (buttonDeuxiemeChiffre == null && buttonPremierChiffre != ButtonNombre1)
            {
                buttonDeuxiemeChiffre = ButtonNombre1;
                ButtonNombre1.BackColor = Color.LightSkyBlue;
                if (buttonOp != null) { Calcul(); }
            }
            else if (buttonPremierChiffre == ButtonNombre1)
            {
                buttonPremierChiffre = null;
                ButtonNombre1.BackColor = Color.White;
            }
            else if (buttonDeuxiemeChiffre == ButtonNombre1)
            {
                buttonDeuxiemeChiffre = null;
                ButtonNombre1.BackColor = Color.White;
            }
        }

        private void ButtonNombre2_Click(object sender, EventArgs e)
        {
            if (buttonPremierChiffre == null && buttonDeuxiemeChiffre != ButtonNombre2)
            {
                buttonPremierChiffre = ButtonNombre2;
                ButtonNombre2.BackColor = Color.LightBlue;
            }
            else if (buttonDeuxiemeChiffre == null && buttonPremierChiffre != ButtonNombre2)
            {
                buttonDeuxiemeChiffre = ButtonNombre2;
                ButtonNombre2.BackColor = Color.LightSkyBlue;
                if (buttonOp != null) { Calcul(); }
            }
            else if (buttonPremierChiffre == ButtonNombre2)
            {
                buttonPremierChiffre = null;
                ButtonNombre2.BackColor = Color.White;
            }
            else if (buttonDeuxiemeChiffre == ButtonNombre2)
            {
                buttonDeuxiemeChiffre = null;
                ButtonNombre2.BackColor = Color.White;
            }
        }

        private void ButtonNombre3_Click(object sender, EventArgs e)
        {
            if (buttonPremierChiffre == null && buttonDeuxiemeChiffre != ButtonNombre3)
            {
                buttonPremierChiffre = ButtonNombre3;
                ButtonNombre3.BackColor = Color.LightBlue;
            }
            else if (buttonDeuxiemeChiffre == null && buttonPremierChiffre != ButtonNombre3)
            {
                buttonDeuxiemeChiffre = ButtonNombre3;
                ButtonNombre3.BackColor = Color.LightSkyBlue;
                if (buttonOp != null) { Calcul(); }
            }
            else if (buttonPremierChiffre == ButtonNombre3)
            {
                buttonPremierChiffre = null;
                ButtonNombre3.BackColor = Color.White;
            }
            else if (buttonDeuxiemeChiffre == ButtonNombre3)
            {
                buttonDeuxiemeChiffre = null;
                ButtonNombre3.BackColor = Color.White;
            }
        }

        private void ButtonNombre4_Click(object sender, EventArgs e)
        {
            if (buttonPremierChiffre == null && buttonDeuxiemeChiffre != ButtonNombre4)
            {
                buttonPremierChiffre = ButtonNombre4;
                ButtonNombre4.BackColor = Color.LightBlue;
            }
            else if (buttonDeuxiemeChiffre == null && buttonPremierChiffre != ButtonNombre4)
            {
                buttonDeuxiemeChiffre = ButtonNombre4;
                ButtonNombre4.BackColor = Color.LightSkyBlue;
                if (buttonOp != null) { Calcul(); }
            }
            else if (buttonPremierChiffre == ButtonNombre4)
            {
                buttonPremierChiffre = null;
                ButtonNombre4.BackColor = Color.White;
            }
            else if (buttonDeuxiemeChiffre == ButtonNombre4)
            {
                buttonDeuxiemeChiffre = null;
                ButtonNombre4.BackColor = Color.White;
            }
        }

        private void ButtonNombre5_Click(object sender, EventArgs e)
        {
            if (buttonPremierChiffre == null && buttonDeuxiemeChiffre != ButtonNombre5)
            {
                buttonPremierChiffre = ButtonNombre5;
                ButtonNombre5.BackColor = Color.LightBlue;
            }
            else if (buttonDeuxiemeChiffre == null && buttonPremierChiffre != ButtonNombre5)
            {
                buttonDeuxiemeChiffre = ButtonNombre5;
                ButtonNombre5.BackColor = Color.LightSkyBlue;
                if (buttonOp != null) { Calcul(); }
            }
            else if (buttonPremierChiffre == ButtonNombre5)
            {
                buttonPremierChiffre = null;
                ButtonNombre5.BackColor = Color.White;
            }
            else if (buttonDeuxiemeChiffre == ButtonNombre5)
            {
                buttonDeuxiemeChiffre = null;
                ButtonNombre5.BackColor = Color.White;
            }
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            if (buttonOp == null)
            {
                buttonOp = ButtonPlus;
                ButtonPlus.BackColor = Color.LightCyan;
                if (buttonPremierChiffre != null && buttonDeuxiemeChiffre != null) { Calcul(); }
            }
            else if (buttonOp == ButtonPlus)
            {
                buttonOp = null;
                ButtonPlus.BackColor = Color.White;
            }
            else
            {
                buttonOp.BackColor = Color.White; 
                buttonOp = ButtonPlus;
                ButtonPlus.BackColor = Color.LightCyan;
                if (buttonPremierChiffre != null && buttonDeuxiemeChiffre != null) { Calcul(); }
            }
        }

        private void ButtonMoins_Click(object sender, EventArgs e)
        {
            if (buttonOp == null)
            {
                buttonOp = ButtonMoins;
                ButtonMoins.BackColor = Color.LightCyan;
                if (buttonPremierChiffre != null && buttonDeuxiemeChiffre != null) { Calcul(); }
            }
            else if (buttonOp == ButtonMoins)
            {
                buttonOp = null;
                ButtonMoins.BackColor = Color.White;
            }
            else
            {
                buttonOp.BackColor = Color.White;
                buttonOp = ButtonMoins;
                ButtonMoins.BackColor = Color.LightCyan;
                if (buttonPremierChiffre != null && buttonDeuxiemeChiffre != null) { Calcul(); }
            }
        }

        private void ButtonFois_Click(object sender, EventArgs e)
        {
            if (buttonOp == null)
            {
                buttonOp = ButtonFois;
                ButtonFois.BackColor = Color.LightCyan;
                if (buttonPremierChiffre != null && buttonDeuxiemeChiffre != null) { Calcul(); }
            }
            else if (buttonOp == ButtonFois)
            {
                buttonOp = null;
                ButtonFois.BackColor = Color.White;
            }
            else
            {
                buttonOp.BackColor = Color.White;
                buttonOp = ButtonFois;
                ButtonFois.BackColor = Color.LightCyan;
                if (buttonPremierChiffre != null && buttonDeuxiemeChiffre != null) { Calcul(); }
            }
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            if (buttonOp == null)
            {
                buttonOp = ButtonDiv;
                ButtonDiv.BackColor = Color.LightCyan;
                if (buttonPremierChiffre != null && buttonDeuxiemeChiffre != null) { Calcul(); }
            }
            else if (buttonOp == ButtonDiv)
            {
                buttonOp = null;
                ButtonDiv.BackColor = Color.White;
            }
            else
            {
                buttonOp.BackColor = Color.White;
                buttonOp = ButtonDiv;
                ButtonDiv.BackColor = Color.LightCyan;
                if (buttonPremierChiffre != null && buttonDeuxiemeChiffre != null) { Calcul(); }
            }
        }

        private void ButtonSuivant_Click(object sender, EventArgs e)
        {
            FinDeRound();
        }

        private void ButtonRetour_Click(object sender, EventArgs e)
        {
            labelScore.Text = score.ToString();
            PointsRound = 0;
            calculsCount = 0;
            tentatives = 1;
            Reset();
            RecupGeneration();
        }
        

        private void buttonSoluces_Click_1(object sender, EventArgs e)
        {
            pause = true;
            Solutions solutionsForm = new Solutions();                                                      //On appel le form qui contient les listbox des solutions
            solutionsForm.ShowDialog();
        }

        private void buttonAbandon_Click(object sender, EventArgs e)
        {
            finDePartie = true;
            this.Hide();
            MenuMathador form = new MenuMathador(pseudo);
            form.ShowDialog();
        }
    }

}
