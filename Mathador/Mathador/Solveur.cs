using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathador;
using Newtonsoft.Json;

namespace Solveur
{
    class Solveur
    {
        int i, j, preresult;
        bool valid = false;
        string equation;

        public void SolveurPlus()
        {
            for (i = 0; i <= 4; i++)
            {
                for (j = 0; j <= 4; j++)
                {
                    if (i != j)
                    {
                        preresult = MathadorGame.tableau[i] + MathadorGame.tableau[j];
                        if (preresult == MathadorGame.cible)
                        {
                            valid = true;
                            equation = (MathadorGame.tableau[i].ToString() + " + " + MathadorGame.tableau[j].ToString() + " = " + MathadorGame.cible.ToString() + "\n");

                            string json = JsonConvert.SerializeObject(equation);
                            System.IO.File.AppendAllText("Solutions.db", json);
                        }
                    }
                }
            }
        }

        public void SolveurMoins()
        {
            for (i = 0; i <= 4; i++)
            {
                for (j = 0; j <= 4; j++)
                {
                    if (i != j)
                    {
                        preresult = MathadorGame.tableau[i] - MathadorGame.tableau[j];
                        if (preresult < 0)
                        {
                            valid = false;
                        }
                        else if (preresult == MathadorGame.cible)
                        {
                            valid = true;
                            equation = (MathadorGame.tableau[i].ToString() + " - " + MathadorGame.tableau[j].ToString() + " = " + MathadorGame.cible.ToString() + "\n");

                            string json = JsonConvert.SerializeObject(equation);
                            System.IO.File.AppendAllText("Solutions.db", json);
                        }
                    }
                }
            }
        }

        public void SolveurMult()
        {
            for (i=0; i<=4; i++)
            {
                for (j=0; j<=4; j++)
                {
                    if (i != j)
                    {
                        preresult = MathadorGame.tableau[i] * MathadorGame.tableau[j];
                        if (preresult == MathadorGame.cible)
                        {
                            valid = true;
                            equation = (MathadorGame.tableau[i].ToString() + " x " + MathadorGame.tableau[j].ToString() + " = " + MathadorGame.cible.ToString() + "\n");

                            string json = JsonConvert.SerializeObject(equation);
                            System.IO.File.AppendAllText("Solutions.db", json);
                        }
                    }
                }
            }
        }

        public void SolveurDiv()
        {
            int rest;
            for (i=0; i<=4; i++)
            {
                for (j=0; j<=4; j++)
                {
                    if (i != j)
                    {
                        rest = MathadorGame.tableau[i] % MathadorGame.tableau[j];
                        if (rest != 0)
                        {
                            valid = false;
                        }
                        else
                        {
                            valid = true;
                            equation = (MathadorGame.tableau[i].ToString() + " / " + MathadorGame.tableau[j].ToString() + " = " + MathadorGame.cible.ToString() + "\n");

                            string json = JsonConvert.SerializeObject(equation);
                            System.IO.File.AppendAllText("Solutions.db", json);
                        }                       
                    }
                }
            }
        }
    }
}
