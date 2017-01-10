using Newtonsoft.Json;
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
        public int OperateurPlusCount = 0;
        public int OperateurMoinsCount = 0;
        public int OperateurFoisCount = 0;
        public int OperateurDivCount = 0;
        public int ScoreManche;
        public DateTime TempsManche1;
        public bool tempsEcoule = false;

        public int resultat;
        public bool plus = false;
        public bool div = false;
        public bool fois = false;
        public bool moins = false;
        public int round = 0;
        public int ScoreRound;
        int cible;
        Button button2;
        Button LastButton;
        public bool PremierNombreSelectione = false;
        public int i;

         // Because we have not specified a namespace, this
        // will be a System.Windows.Forms.Timer instance
        private Timer _timer;

        // The last time the timer was started
        private DateTime _startTime = DateTime.MinValue;

        // Time between now and when the timer was started last
        private TimeSpan _currentElapsedTime = TimeSpan.Zero;

        // Time between now and the first time timer was started after a reset
        private TimeSpan _totalElapsedTime = TimeSpan.Zero;

        // Whether or not the timer is currently running
        private bool _timerRunning = false;

       
          
        

        public MathadorGame()
        {
            InitializeComponent();

            // Set up a timer and fire the Tick event once per second (1000 ms)
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += new EventHandler(_timer1_Tick);
        }
        
        private void MathadorGame_Load(object sender, EventArgs e)
        {

            TextCible.Text = "";
            ButtonNombre5.Text = "";
            BouttonNombre1.Text = "";
            BouttonNombre2.Text = "";
            BouttonNombre3.Text = "";
            BouttonNombre4.Text = "";
        }


        private void ButtonTestGenerer_Click(object sender, EventArgs e)
        {
            this.tempsEcoule = true;
            if (!_timerRunning)
            {
                // Set the start time to Now
                _startTime = DateTime.Now;

                // Store the total elapsed time so far
                _totalElapsedTime = _currentElapsedTime;

                _timer.Start();
                _timerRunning = true;
            }
            else // If the timer is already running
            {
                
                _timer.Stop();
                _timerRunning = false;

                // Reset the elapsed time TimeSpan objects
                _totalElapsedTime = TimeSpan.Zero;
                _currentElapsedTime = TimeSpan.Zero;
                _startTime = DateTime.Now;

                // Store the total elapsed time so far
                _totalElapsedTime = _currentElapsedTime;

                _timer.Start();
                _timerRunning = true;
            }

            Generator();

            string text = System.IO.File.ReadAllText(@"C:\Users\Roro\Documents\Visual Studio 2013\Projects\Mathador\ressources\path.db");
            
            data json = JsonConvert.DeserializeObject<data>(text);
           //Console.WriteLine("Cible: {0}, Nombre1: {1}", datatest.Cible, datatest.Nombre1);


            cible = json.Cible;
            NombreCible.Text = cible.ToString();
            int[] tableau = new int[5];

            tableau[0] = json.Nombre1;
            tableau[1] = json.Nombre2;
            tableau[2] = json.Nombre3;
            tableau[3] = json.Nombre4;
            tableau[4] = json.Nombre5;

            BouttonNombre1.Text = tableau[0].ToString();
            BouttonNombre2.Text = tableau[1].ToString();
            BouttonNombre3.Text = tableau[2].ToString();
            BouttonNombre4.Text = tableau[3].ToString();
            ButtonNombre5.Text = tableau[4].ToString();

        }

        private void BouttonNombre1_Click(object sender, EventArgs e)
        {
            Calcule(BouttonNombre1);
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            plus = true;
            if (LastButton != null && PremierNombreSelectione == false)
            {
                Calcule(LastButton);
            }
        }

        private void BouttonNombre2_Click(object sender, EventArgs e)
        {

            Calcule(BouttonNombre2);
        }

        public void reset()
        {
            this.OperateurDivCount = 0;
            this.OperateurFoisCount = 0;
            this.OperateurMoinsCount = 0;
            this.OperateurPlusCount = 0;

            _timer.Stop();
            _timerRunning = false;

            // Reset the elapsed time TimeSpan objects
            _totalElapsedTime = TimeSpan.Zero;
            _currentElapsedTime = TimeSpan.Zero;
          resultat = 0;
        plus = false;
        div = false;
        fois = false;
        moins = false;
        round = 0;
        ScoreRound = 0;
        cible = 0;
        button2 = null;
        LastButton = null;
        PremierNombreSelectione = false;

        BouttonNombre1.Text = "";
        BouttonNombre2.Text = "";
        BouttonNombre3.Text = "";
        BouttonNombre4.Text = "";
        ButtonNombre5.Text = "";
        NombreCible.Text = "0";
        TextScore.Text = "Score";
        BouttonNombre1.BackColor = Color.White;
        BouttonNombre2.BackColor = Color.White;
        BouttonNombre3.BackColor = Color.White;
        BouttonNombre4.BackColor = Color.White;
        ButtonNombre5.BackColor = Color.White;

        this.tempsEcoule = false;
        }

        public void Calcule(Button button1)
        {
            BouttonNombre1.BackColor = Color.White;
            BouttonNombre2.BackColor = Color.White;
            BouttonNombre3.BackColor = Color.White;
            BouttonNombre4.BackColor = Color.White;
            ButtonNombre5.BackColor = Color.White;
           
            if (PremierNombreSelectione == true)
            {
                if (plus == true)
                {
                    resultat = resultat + Int32.Parse(button1.Text);
                    button1.Text = resultat.ToString();
                    button2.Text = "";
                    ScoreRound += 1;
                    LastButton = button1;
                    this.OperateurPlusCount += 1;
                    plus = false;
                }
                if (moins == true)
                {
                    resultat = resultat - Int32.Parse(button1.Text);
                    button1.Text = resultat.ToString();
                    button2.Text = "";
                    ScoreRound += 2;
                    LastButton = button1;
                    this.OperateurMoinsCount++;
                    moins = false;
                }
                if (div == true )
                {
                    if (Int32.Parse(button1.Text) != 0 && resultat % Int32.Parse(button1.Text) == 0)
                    {
                        resultat = resultat / Int32.Parse(button1.Text);
                        button1.Text = resultat.ToString();
                        button2.Text = "";
                        ScoreRound += 3;
                        LastButton = button1;
                        this.OperateurDivCount++;
                        div = false;
                    }
                    else
                    {
                        button1.BackColor = Color.Red;
                        div = false;
                        round --;
                    }
                }
                if (fois == true)
                {
                    resultat = resultat * Int32.Parse(button1.Text);
                    button1.Text = resultat.ToString();
                    button2.Text = "";
                    ScoreRound += 1;
                    LastButton = button1;
                    this.OperateurFoisCount++;
                    fois = false;
                }
                PremierNombreSelectione = false;
                round++;
            }
            else
            {
                resultat = Int32.Parse(button1.Text);
                button2 = button1;
                PremierNombreSelectione = true;
            }
            if (round == 4)
            {
                TextScore.Text = "Terminer";
                if (button1.Text == cible.ToString())
                {
                    TextScore.Text = "Mathador";
                    TextAffichageScore.Text = ScoreRound.ToString();
                }
            }
        }

        public static void Generator()
        {
            int nb1, nb2, nb3, nb4, nb5, cible;

            Random random = new Random();

            nb1 = random.Next(1,20);
            nb2 = random.Next(1,20);
            nb3 = random.Next(1,12);
            nb4 = random.Next(1,12);
            nb5 = random.Next(1,12);

            cible = nb1 + nb2 - nb3 * nb4 / nb5;

            if (cible > 0)
            {
                data datatest = new data();
                datatest.Cible = cible;
                datatest.Nombre1 = nb1;
                datatest.Nombre2 = nb2;
                datatest.Nombre3 = nb3;
                datatest.Nombre4 = nb4;
                datatest.Nombre5 = nb5;





                string json = JsonConvert.SerializeObject(datatest);

                System.IO.File.WriteAllText(@"C:\Users\Roro\Documents\Visual Studio 2013\Projects\Mathador\ressources\path.db", json);
            }
            else
            {
                Generator();
            }
        }




        private void BouttonNombre3_Click(object sender, EventArgs e)
        {
            Calcule(BouttonNombre3);
        }

        private void BouttonNombre4_Click(object sender, EventArgs e)
        {
            Calcule(BouttonNombre4);
        }

        private void ButtonNombre5_Click(object sender, EventArgs e)
        {
            Calcule(ButtonNombre5);
        }

        private void ButtonMoins_Click(object sender, EventArgs e)
        {
            moins = true;
            if (LastButton != null && PremierNombreSelectione == false)
            {
                Calcule(LastButton);
            }
        }

        private void ButtonFois_Click(object sender, EventArgs e)
        {
            fois = true;
            if (LastButton != null && PremierNombreSelectione == false)
            {
                Calcule(LastButton);
            }
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            div = true;
            if (LastButton != null && PremierNombreSelectione == false)
            {
                Calcule(LastButton);
            }
        }

        private void ButtonSuivant_Click(object sender, EventArgs e)
        {
            if (LastButton.Text == NombreCible.Text)
            {
                MessageBox.Show("Bien Joué \n Vous avez utilisé : \n" + this.OperateurPlusCount + " fois le + \n" + this.OperateurMoinsCount + " fois le - \n" + this.OperateurFoisCount + " fois le * \n" + this.OperateurDivCount + " fois le / \n" + TextTimer.Text + "/n Votre Score est de : " + TextAffichageScore.Text);
                TextAffichageScore.Text = ScoreRound.ToString();

            }
            else
            {
                MessageBox.Show("Perdu" + this.OperateurPlusCount + " " + this.OperateurMoinsCount + " " + this.OperateurFoisCount + " " + this.OperateurDivCount + " " + TextTimer.Text);
            }
        }

        private void ButtonRetour_Click(object sender, EventArgs e)
        {
            reset();
            
        }

        private void _timer1_Tick(object sender, EventArgs e)
        {

            var timeSinceStartTime = DateTime.Now - _startTime;
            timeSinceStartTime = new TimeSpan(timeSinceStartTime.Hours,
                                              timeSinceStartTime.Minutes,
                                              timeSinceStartTime.Seconds);

            _currentElapsedTime = timeSinceStartTime + _totalElapsedTime;

            // These are just two Label controls which display the current 
            // elapsed time and total elapsed time
            //TextTemps.Text = _currentElapsedTime.ToString();
            TextTimer.Text = timeSinceStartTime.ToString();
            if (timeSinceStartTime.Minutes == 01)
            {
                Message();
            }
                //timeSinceStartTime = DateTime.Now - _startTime;
        }

        private void TextTemps_Click(object sender, EventArgs e)
        {

        }
        public void Message()
        {
            if (tempsEcoule == true)
            {
                MessageBox.Show("Temps écoulé");
                reset();
                tempsEcoule = false;
            }
        }

      }
}
