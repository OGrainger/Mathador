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
        bool valid;
        string equation;

        public void simpleSolveur()
        {
            for (i=1; i<=5; i++)
            {
                for (j = 1; j <= 5; j++)
                {
                    if (i != j)
                    {
                        preresult = MathadorGame.tableau[i] + MathadorGame.tableau[j];
                        if (preresult == MathadorGame.cible)
                        {
                            equation = (MathadorGame.tableau[i].ToString() + " + " + MathadorGame.tableau[j].ToString() + " = " + MathadorGame.cible.ToString() + "\n");

                            string json = JsonConvert.SerializeObject(equation);
                            System.IO.File.AppendAllText("Solutions.db", json);
                        }
                    }
                }
            }
        } 
    }
}
