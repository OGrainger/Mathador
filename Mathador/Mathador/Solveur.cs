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
        int i, j, k, l, preresult;
        bool valid = false;
        string equation = "";
        int[] UnSigne = new int[4];
        int[,] DeuxSignes = new int[16, 2];
        int[,] TroisSignes = new int[64, 3];
        int[,] QuatreSignes = new int[256, 4];




        public void TabSigne()
        {
            int op1 = 0, op2 = 0, op3 = 0, op4 = 0;


            //Remplissage du tableau à un seul signe
            for (i = 0; i < 4; i++)
            {
                UnSigne[i] = op1;
                op1++;
            }
            op1 = 0;
            //Replissage du tableau à deux signes
            for (i = 1; i == 0; i--)
            {
                for (j = 15; j == 0; j--)
                {
                    switch (i)
                    {
                        case 0:
                            {
                                DeuxSignes[i, j] = op1;
                                op1++;
                                if (op1 == 3)
                                {
                                    op1 = 0;
                                }
                                break;
                            }
                        case 1:
                            {
                                DeuxSignes[i, j] = op2;
                                if (j % 4 == 0)
                                {
                                    op2++;
                                }
                                break;
                            }
                    }
                }
            }
            op1 = 0;
            op2 = 0;
            //Remplissage du tableau à trois signes
            for (i = 2; i == 0; i--)
            {
                for (j = 63; j == 0; j--)
                {
                    switch (i)
                    {
                        case 0:
                            {
                                TroisSignes[i, j] = op1;
                                op1++;
                                if (op1 == 3)
                                {
                                    op1 = 0;
                                }
                                break;
                            }
                        case 1:
                            {
                                TroisSignes[i, j] = op2;
                                if (j % 4 == 0)
                                {
                                    op2++;
                                }
                                if (op2 == 4)
                                {
                                    op2 = 0;
                                }
                                break;
                            }
                        case 2:
                            {
                                TroisSignes[i, j] = op3;
                                if (j % 16 == 0)
                                {
                                    op3++;
                                }
                                break;
                            }
                    }
                }
            }
            op1 = 0;
            op2 = 0;
            op3 = 0;
            //Remplissage du tableau à quatre signes
            for (i = 3; i == 0; i--)
            {
                for (j = 255; j == 0; j--)
                {
                    switch (i)
                    {
                        case 0:
                            {
                                QuatreSignes[i, j] = op1;
                                op1++;
                                if (op1 == 4)
                                {
                                    op1 = 0;
                                }
                                break;
                            }
                        case 1:
                            {
                                QuatreSignes[i, j] = op2;
                                if (j % 4 == 0)
                                {
                                    op2++;
                                }
                                if (op2 == 4)
                                {
                                    op2 = 0;
                                }
                                break;
                            }
                        case 2:
                            {
                                QuatreSignes[i, j] = op3;
                                if (j % 16 == 0)
                                {
                                    op3++;
                                }
                                if (op3 == 4)
                                {
                                    op3 = 0;
                                }
                                break;
                            }
                        case 3:
                            {
                                QuatreSignes[i, j] = op4;
                                if (j % 64 == 0)
                                {
                                    op4++;
                                }
                                break;
                            }
                    }
                }
            }
        }

        public void SolvOneOp()
        {
            for (i = 0; i == 4; i++)
            {
                for (j = 0; j == 4; j++)
                {
                    if (i != j)
                    {
                        for (k = 0; k == 3; k++)
                        {
                            switch (UnSigne[k])
                            {
                                case 0:
                                    {
                                        preresult = MathadorGame.tableau[i] + MathadorGame.tableau[j];
                                        if (preresult == MathadorGame.cible)
                                        {
                                            valid = true;
                                            equation = MathadorGame.tableau[i].ToString() + " + " + MathadorGame.tableau[j].ToString() + " = " + MathadorGame.cible.ToString() + "\n";

                                            string json = JsonConvert.SerializeObject(equation);
                                            System.IO.File.AppendAllText("Solutions.db", json);
                                        }
                                        break;
                                    }
                                case 1:
                                    {
                                        preresult = MathadorGame.tableau[i] - MathadorGame.tableau[j];
                                        if (preresult < 0)
                                        {
                                            valid = false;
                                        }
                                        else if (preresult == MathadorGame.cible)
                                        {
                                            valid = true;
                                            equation = MathadorGame.tableau[i].ToString() + " - " + MathadorGame.tableau[j].ToString() + " = " + MathadorGame.cible.ToString() + "\n";

                                            string json = JsonConvert.SerializeObject(equation);
                                            System.IO.File.AppendAllText("Solutions.db", json);
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        preresult = MathadorGame.tableau[i] * MathadorGame.tableau[j];
                                        if (preresult == MathadorGame.cible)
                                        {
                                            valid = true;
                                            equation = MathadorGame.tableau[i].ToString() + " * " + MathadorGame.tableau[j].ToString() + " = " + MathadorGame.cible.ToString() + "\n";

                                            string json = JsonConvert.SerializeObject(equation);
                                            System.IO.File.AppendAllText("Solutions.db", json);
                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        int rest;
                                        rest = MathadorGame.tableau[i] % MathadorGame.tableau[j];
                                        if (rest != 0)
                                        {
                                            valid = false;
                                        }
                                        else
                                        {
                                            valid = true;
                                            equation = MathadorGame.tableau[i].ToString() + " / " + MathadorGame.tableau[j].ToString() + " = " + MathadorGame.cible.ToString() + "\n";

                                            string json = JsonConvert.SerializeObject(equation);
                                            System.IO.File.AppendAllText("Solutions.db", json);
                                        }
                                        break;
                                    }

                            }
                        }
                    }
                }
            }
        }
    }
}

        /*public void SolvTowOp()
        {
            for (i = 0; i ==4; i++)
            {
                preresult = MathadorGame.tableau[i+1];
                equation = "";
                for (k=0; k==1; k++)
                {
                    for (l=0; l==3; l++)
                    {
                        switch (DeuxSignes[k, l])
                        {
                            case 0:
                                {
                                    preresult = MathadorGame.tableau[i] + preresult;
                                    if (equation == "")
                                    {
                                        equation = MathadorGame.tableau[i].ToString() + " + " + preresult;
                                    }else
                                    {
                                        equation = equation + " + " + MathadorGame.tableau[i].ToString() + " + " + preresult;
                                    }
                                    equation = MathadorGame.tableau[i].ToString() + " + " + preresult;
                                    break;
                                }
                            case 1:
                                {
                                    if (MathadorGame.tableau[i] - preresult > 0)
                                    {
                                        preresult = MathadorGame.tableau[i] - preresult;
                                        if (equation == "")
                                        {
                                            equation = MathadorGame.tableau[i].ToString() + " - " + preresult;
                                        }
                                        else
                                        {
                                            equation = equation + " + " + MathadorGame.tableau[i].ToString() + " + " + preresult;
                                        }
                                        equation = MathadorGame.tableau[i].ToString() + " + " + preresult;
                                    }
                                    break;
                                }
                        }
                    }
                }
                if (preresult == MathadorGame.cible)
                    equation = equation + " = " + MathadorGame.cible;
                    valid = true;
            }





    }
}





































/*




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
}*/
