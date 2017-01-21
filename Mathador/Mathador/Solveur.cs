using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathador;
using Newtonsoft.Json;

namespace Mathador
{
    public class Solveur
    {
        int i, j, k, l, m, preresult;
        int valid, op;
        string equation = "";
        public int[] UnSigne = new int[4];
        int[,] DeuxSignes = new int[2, 16];
        int[,] TroisSignes = new int[3, 64];
        int[,] QuatreSignes = new int[4, 256];




        public void TabSigne()
        {
            int op1 = 0;
            int op2 = 0;
            int op3 = 0;
            int op4 = 0;



            //Remplissage du tableau à un seul signe
            for (i = 0; i < 4; i++)
            {
                UnSigne[i] = op1;
                op1++;
            }
            op1 = 0;


            //Replissage du tableau à deux signes

            for (j = 0; j < 16; j++)
            {
                DeuxSignes[0, j] = op1;
                DeuxSignes[1, j] = op2;
                op1++;
                if (op1 == 4)
                {
                    op1 = 0;
                    op2++;
                }
            }
            op1 = 0;
            op2 = 0;



            //Remplissage du tableau à trois signes
            for (j = 0; j < 64; j++)
            {
                TroisSignes[0, j] = op1;
                TroisSignes[1, j] = op2;
                TroisSignes[2, j] = op3;
                op1++;
                if (op1 == 4)
                {
                    op1 = 0;
                    op2++;
                }
                if (op2 == 4)
                {
                    op2 = 0;
                    op3++;
                }
            }
            op1 = 0;
            op2 = 0;
            op3 = 0;

            //Remplissage du tableau à quatre signes
            for (j = 0; j < 256; j++)
            {
                QuatreSignes[0, j] = op1;
                QuatreSignes[1, j] = op2;
                QuatreSignes[2, j] = op3;
                QuatreSignes[3, j] = op4;
                op1++;
                if (op1 == 4)
                {
                    op1 = 0;
                    op2++;
                }
                if (op2 == 4)
                {
                    op2 = 0;
                    op3++;
                }
                if (op3 == 4)
                {
                    op3 = 0;
                    op4++;
                }
            }
        }


        public void SolvOneOp()
        {
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (i != j)
                    {
                        for (k = 0; k < 4; k++)
                        {
                            if (UnSigne[k] == 0)
                            {
                                preresult = MathadorGame.tableau[i] + MathadorGame.tableau[j];
                                if (preresult == MathadorGame.cible)
                                {
                                    equation = MathadorGame.tableau[i].ToString() + "+" + MathadorGame.tableau[j].ToString() + "=" + MathadorGame.cible.ToString() + "\n";
                                    string json = JsonConvert.SerializeObject(equation);
                                    System.IO.File.AppendAllText("Solutions.db", json);
                                }
                            }
                            else if (UnSigne[k] == 1)
                            {
                                preresult = MathadorGame.tableau[i] - MathadorGame.tableau[j];
                                if ((preresult > 0) && (preresult == MathadorGame.cible))
                                {
                                    equation = MathadorGame.tableau[i].ToString() + "-" + MathadorGame.tableau[j].ToString() + "=" + MathadorGame.cible.ToString() + "\n";
                                    string json = JsonConvert.SerializeObject(equation);
                                    System.IO.File.AppendAllText("Solutions.db", json);
                                }
                            }
                            else if (UnSigne[k] == 2)
                            {
                                preresult = MathadorGame.tableau[i] * MathadorGame.tableau[j];
                                if (preresult == MathadorGame.cible)
                                {
                                    equation = MathadorGame.tableau[i].ToString() + "*" + MathadorGame.tableau[j].ToString() + "=" + MathadorGame.cible.ToString() + "\n";
                                    string json = JsonConvert.SerializeObject(equation);
                                    System.IO.File.AppendAllText("Solutions.db", json);
                                }
                            }
                            else if (UnSigne[k] == 3)
                            {
                                if (MathadorGame.tableau[i] % MathadorGame.tableau[j] == 0)
                                {
                                    preresult = MathadorGame.tableau[i] / MathadorGame.tableau[j];


                                    if (preresult == MathadorGame.cible)
                                    {
                                        equation = MathadorGame.tableau[i].ToString() + "/" + MathadorGame.tableau[j].ToString() + "=" + MathadorGame.cible.ToString() + "\n";
                                        string json = JsonConvert.SerializeObject(equation);
                                        System.IO.File.AppendAllText("Solutions.db", json);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void SolvTowOp()
        {
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    for (k = 0; k < 5; k++)
                    {
                        preresult = 0;
                        if (i != j && i != k && j != k)
                        {
                            for (l = 0; l < 1; l++)
                            {
                                equation = "";
                                switch (DeuxSignes[0, l])
                                {
                                    case 0:
                                        {
                                            preresult = MathadorGame.tableau[i] + MathadorGame.tableau[j];
                                            equation = MathadorGame.tableau[i].ToString() + "+" + MathadorGame.tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                            break;
                                        }
                                    case 1:
                                        {
                                            if (MathadorGame.tableau[i] - MathadorGame.tableau[j] >= 0)
                                            {
                                                preresult = MathadorGame.tableau[i] - MathadorGame.tableau[j];
                                                equation = MathadorGame.tableau[i].ToString() + "-" + MathadorGame.tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                            }
                                            break;
                                        }
                                    case 2:
                                        {
                                            preresult = MathadorGame.tableau[i] * MathadorGame.tableau[j];
                                            equation = MathadorGame.tableau[i].ToString() + "x" + MathadorGame.tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                            break;
                                        }
                                    case 3:
                                        {
                                            if (MathadorGame.tableau[i] % MathadorGame.tableau[j] == 0)
                                            {
                                                preresult = MathadorGame.tableau[i] / MathadorGame.tableau[j];
                                                equation = MathadorGame.tableau[i].ToString() + "/" + MathadorGame.tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                            }
                                            break;
                                        }
                                }

                                switch (DeuxSignes[1, l])
                                {
                                    case 0:
                                        {
                                            if (preresult + MathadorGame.tableau[k] == MathadorGame.cible)
                                            {
                                                equation = equation + "+" + MathadorGame.tableau[k].ToString() + "=" + MathadorGame.cible.ToString() + "\n";
                                                string json = JsonConvert.SerializeObject(equation);
                                                System.IO.File.AppendAllText("Solutions.db", json);
                                            }
                                            break;
                                        }
                                    case 1:
                                        {
                                            if (preresult - MathadorGame.tableau[k] >= 0 && preresult - MathadorGame.tableau[k] == MathadorGame.cible)
                                            {
                                                equation = equation + "-" + MathadorGame.tableau[k].ToString() + "=" + MathadorGame.cible.ToString() + "\n";
                                                string json = JsonConvert.SerializeObject(equation);
                                                System.IO.File.AppendAllText("Solutions.db", json);
                                            }
                                            break;
                                        }
                                    case 2:
                                        {
                                            if (preresult * MathadorGame.tableau[k] > 0 && preresult * MathadorGame.tableau[k] == MathadorGame.cible)
                                            {
                                                equation = equation + "x" + MathadorGame.tableau[k].ToString() + "=" + MathadorGame.cible.ToString() + "\n";
                                                string json = JsonConvert.SerializeObject(equation);
                                                System.IO.File.AppendAllText("Solutions.db", json);
                                            }
                                            break;
                                        }
                                    case 3:
                                        {
                                            if (preresult % MathadorGame.tableau[k] == 0 && preresult / MathadorGame.tableau[k] == MathadorGame.cible)
                                            {
                                                equation = equation + "/" + MathadorGame.tableau[k].ToString() + "=" + MathadorGame.cible.ToString() + "\n";
                                                string json = JsonConvert.SerializeObject(equation);
                                                System.IO.File.AppendAllText("Solutions.db", json);                                         
                                            }
                                            break;
                                        }
                                }
                                preresult = 0;
                            }
                        }
                    }
                }
            }
        }

        public void SolvTrheeOp()
        {
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    for (k = 0; k < 5; k++)
                    {
                        for (l = 0; l < 5; l++)
                        {
                            if (i != j && i != k && j != k && l != i && l != j && l != k)
                            {
                                for (op = 0; op < 64; op++)
                                {
                                    valid = 0;
                                    equation = "";
                                    preresult = 0;
                                    switch (TroisSignes[0, op])
                                    {

                                        case 0:
                                            {
                                                preresult = MathadorGame.tableau[i] + MathadorGame.tableau[j];
                                                equation = MathadorGame.tableau[i].ToString() + "+" + MathadorGame.tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                                valid++;
                                                break;
                                            }
                                        case 1:
                                            {
                                                if (MathadorGame.tableau[i] - MathadorGame.tableau[j] >= 0)
                                                {
                                                    preresult = MathadorGame.tableau[i] - MathadorGame.tableau[j];
                                                    equation = MathadorGame.tableau[i].ToString() + "-" + MathadorGame.tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                                    valid++;
                                                }
                                                break;
                                            }
                                        case 2:
                                            {
                                                preresult = MathadorGame.tableau[i] * MathadorGame.tableau[j];
                                                equation = MathadorGame.tableau[i].ToString() + "x" + MathadorGame.tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                                valid++;
                                                break;
                                            }
                                        case 3:
                                            {
                                                if (MathadorGame.tableau[i] % MathadorGame.tableau[j] == 0)
                                                {
                                                    preresult = MathadorGame.tableau[i] / MathadorGame.tableau[j];
                                                    equation = MathadorGame.tableau[i].ToString() + "/" + MathadorGame.tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                                    valid++;
                                                }
                                                break;
                                            }
                                    }

                                    switch (TroisSignes[1, op])
                                    {
                                        case 0:
                                            {
                                                preresult = preresult + MathadorGame.tableau[k];
                                                equation = equation + "+" + MathadorGame.tableau[k] + "=" + preresult + " => " + preresult;
                                                valid++;
                                                break;
                                            }
                                        case 1:
                                            {
                                                if (preresult - MathadorGame.tableau[k] > 0)
                                                {
                                                    preresult = preresult - MathadorGame.tableau[k];
                                                    equation = equation + "-" + MathadorGame.tableau[k] + "=" + preresult + " => " + preresult;
                                                    valid++;
                                                }
                                                break;
                                            }
                                        case 2:
                                            {
                                                if (preresult * MathadorGame.tableau[k] >= 0)
                                                {
                                                    preresult = preresult * MathadorGame.tableau[k];
                                                    equation = equation + "x" + MathadorGame.tableau[k] + "=" + preresult + " => " + preresult;
                                                    valid++;
                                                }
                                                break;
                                            }
                                        case 3:
                                            {
                                                if (preresult % MathadorGame.tableau[k] == 0)
                                                {
                                                    preresult = preresult / MathadorGame.tableau[k];
                                                    equation = equation + "/" + MathadorGame.tableau[k] + "=" + preresult + " => " + preresult;
                                                    valid++;
                                                }
                                                break;
                                            }
                                    }

                                    switch (TroisSignes[2, op])
                                    {
                                        case 0:
                                            {
                                                if (preresult + MathadorGame.tableau[l] == MathadorGame.cible && valid == 2)
                                                {
                                                    equation = equation + "+" + MathadorGame.tableau[l].ToString() + "=" + MathadorGame.cible.ToString() + "\n";
                                                    string json = JsonConvert.SerializeObject(equation);
                                                    System.IO.File.AppendAllText("Solutions.db", json);
                                                }
                                                break;
                                            }
                                        case 1:
                                            {
                                                if (preresult - MathadorGame.tableau[l] >= 0 && preresult - MathadorGame.tableau[l] == MathadorGame.cible && valid == 2)
                                                {
                                                    equation = equation + "-" + MathadorGame.tableau[l].ToString() + "=" + MathadorGame.cible.ToString() + "\n";
                                                    string json = JsonConvert.SerializeObject(equation);
                                                    System.IO.File.AppendAllText("Solutions.db", json);
                                                }
                                                break;
                                            }
                                        case 2:
                                            {
                                                if (preresult * MathadorGame.tableau[l] > 0 && preresult * MathadorGame.tableau[l] == MathadorGame.cible && valid == 2)
                                                {
                                                    equation = equation + "x" + MathadorGame.tableau[l].ToString() + "=" + MathadorGame.cible.ToString() + "\n";
                                                    string json = JsonConvert.SerializeObject(equation);
                                                    System.IO.File.AppendAllText("Solutions.db", json);
                                                }
                                                break;
                                            }
                                        case 3:
                                            {
                                                if (preresult % MathadorGame.tableau[l] == 0 && preresult / MathadorGame.tableau[l] == MathadorGame.cible && valid == 2)
                                                {
                                                    equation = equation + "/" + MathadorGame.tableau[l].ToString() + "=" + MathadorGame.cible.ToString() + "\n";
                                                    string json = JsonConvert.SerializeObject(equation);
                                                    System.IO.File.AppendAllText("Solutions.db", json);                                         
                                                }
                                                break;
                                            }
                                    }
                                    preresult = 0;
                                }
                            }
                        }
                    }
                }
            }
        }

        public void SolvfourOp()
        {
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    for (k = 0; k < 5; k++)
                    {
                        for (l = 0; l < 5; l++)
                        {
                            for (m = 0; m < 5; m++)
                            {
                                if (i != j && i != k && j != k && l != i && l != j && l != k && m != i && m != j && m != k && m != l)
                                {
                                    for (op = 0; op < 256; op++)
                                    {
                                        valid = 0;
                                        equation = "";
                                        preresult = 0;
                                        switch (QuatreSignes[0, op])
                                        {

                                            case 0:
                                                {
                                                    preresult = MathadorGame.tableau[i] + MathadorGame.tableau[j];
                                                    equation = MathadorGame.tableau[i].ToString() + "+" + MathadorGame.tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                                    valid++;
                                                    break;
                                                }
                                            case 1:
                                                {
                                                    if (MathadorGame.tableau[i] - MathadorGame.tableau[j] >= 0)
                                                    {
                                                        preresult = MathadorGame.tableau[i] - MathadorGame.tableau[j];
                                                        equation = MathadorGame.tableau[i].ToString() + "-" + MathadorGame.tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                                        valid++;
                                                    }
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    preresult = MathadorGame.tableau[i] * MathadorGame.tableau[j];
                                                    equation = MathadorGame.tableau[i].ToString() + "x" + MathadorGame.tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                                    valid++;
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    if (MathadorGame.tableau[i] % MathadorGame.tableau[j] == 0)
                                                    {
                                                        preresult = MathadorGame.tableau[i] / MathadorGame.tableau[j];
                                                        equation = MathadorGame.tableau[i].ToString() + "/" + MathadorGame.tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                                        valid++;
                                                    }
                                                    break;
                                                }
                                        }

                                        switch (QuatreSignes[1, op])
                                        {
                                            case 0:
                                                {
                                                    preresult = preresult + MathadorGame.tableau[k];
                                                    equation = equation + "+" + MathadorGame.tableau[k] + "=" + preresult + " => " + preresult;
                                                    valid++;
                                                    break;
                                                }
                                            case 1:
                                                {
                                                    if (preresult - MathadorGame.tableau[k] > 0)
                                                    {
                                                        preresult = preresult - MathadorGame.tableau[k];
                                                        equation = equation + "-" + MathadorGame.tableau[k] + "=" + preresult + " => " + preresult;
                                                        valid++;
                                                    }
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    if (preresult * MathadorGame.tableau[k] >= 0)
                                                    {
                                                        preresult = preresult * MathadorGame.tableau[k];
                                                        equation = equation + "x" + MathadorGame.tableau[k] + "=" + preresult + " => " + preresult;
                                                        valid++;
                                                    }
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    if (preresult % MathadorGame.tableau[k] == 0)
                                                    {
                                                        preresult = preresult / MathadorGame.tableau[k];
                                                        equation = equation + "/" + MathadorGame.tableau[k] + "=" + preresult + " => " + preresult;
                                                        valid++;
                                                    }
                                                    break;
                                                }
                                        }

                                        switch (QuatreSignes[2, op])
                                        {
                                            case 0:
                                                {
                                                    preresult = preresult + MathadorGame.tableau[k];
                                                    equation = equation + "+" + MathadorGame.tableau[k] + "=" + preresult + " => " + preresult;
                                                    valid++;
                                                    break;
                                                }
                                            case 1:
                                                {
                                                    if (preresult - MathadorGame.tableau[k] > 0)
                                                    {
                                                        preresult = preresult - MathadorGame.tableau[k];
                                                        equation = equation + "-" + MathadorGame.tableau[k] + "=" + preresult + " => " + preresult;
                                                        valid++;
                                                    }
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    if (preresult * MathadorGame.tableau[k] >= 0)
                                                    {
                                                        preresult = preresult * MathadorGame.tableau[k];
                                                        equation = equation + "x" + MathadorGame.tableau[k] + "=" + preresult + " => " + preresult;
                                                        valid++;
                                                    }
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    if (preresult % MathadorGame.tableau[k] == 0)
                                                    {
                                                        preresult = preresult / MathadorGame.tableau[k];
                                                        equation = equation + "/" + MathadorGame.tableau[k] + "=" + preresult + " => " + preresult;
                                                        valid++;
                                                    }
                                                    break;
                                                }
                                        }

                                        switch (QuatreSignes[3, op])
                                        {
                                            case 0:
                                                {
                                                    if (preresult + MathadorGame.tableau[l] == MathadorGame.cible && valid == 3)
                                                    {
                                                        equation = equation + "+" + MathadorGame.tableau[l].ToString() + "=" + MathadorGame.cible.ToString() + "\n";
                                                        string json = JsonConvert.SerializeObject(equation);
                                                        System.IO.File.AppendAllText("Solutions.db", json);
                                                    }
                                                    break;
                                                }
                                            case 1:
                                                {
                                                    if (preresult - MathadorGame.tableau[l] >= 0 && preresult - MathadorGame.tableau[l] == MathadorGame.cible && valid == 3)
                                                    {
                                                        equation = equation + "-" + MathadorGame.tableau[l].ToString() + "=" + MathadorGame.cible.ToString() + "\n";
                                                        string json = JsonConvert.SerializeObject(equation);
                                                        System.IO.File.AppendAllText("Solutions.db", json);
                                                    }
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    if (preresult * MathadorGame.tableau[l] > 0 && preresult * MathadorGame.tableau[l] == MathadorGame.cible && valid == 3)
                                                    {
                                                        equation = equation + "x" + MathadorGame.tableau[l].ToString() + "=" + MathadorGame.cible.ToString() + "\n";
                                                        string json = JsonConvert.SerializeObject(equation);
                                                        System.IO.File.AppendAllText("Solutions.db", json);
                                                    }
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    if (preresult % MathadorGame.tableau[l] == 0 && preresult / MathadorGame.tableau[l] == MathadorGame.cible && valid == 3)
                                                    {
                                                        equation = equation + "/" + MathadorGame.tableau[l].ToString() + "=" + MathadorGame.cible.ToString() + "\n";
                                                        string json = JsonConvert.SerializeObject(equation);
                                                        System.IO.File.AppendAllText("Solutions.db", json);                                         
                                                    }
                                                    break;
                                                }
                                        }
                                        preresult = 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void SolvComplet()
        {
            TabSigne();
            SolvOneOp();
            SolvTowOp();
            SolvTrheeOp();
            SolvfourOp();
            
        }
    }
}
