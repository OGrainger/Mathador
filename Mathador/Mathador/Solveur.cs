using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Mathador
{
    public class Solveur
    {
        int i, j, k, l, m, preresult;
        int valid, op, score;
        string equation = "";
        public int[] UnSigne = new int[4];
        int[,] DeuxSignes = new int[2, 16];
        int[,] TroisSignes = new int[3, 64];
        int[,] QuatreSignes = new int[4, 256];
        public static JArray equationsTemp = new JArray();
        public static List<Solution> Solutions = new List<Solution>();

        public void TabSigne()
        {
            int op1 = 0;
            int op2 = 0;
            int op3 = 0;
            int op4 = 0;

            //Remplissage du tableau à un seul signe (le 0 correspond à un "+", le 1 à un "-", le 2 à un "x" et le 3 à un "/")
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
            for (i = 0; i < 5; i++)                                                                             //Boucle pour le premier nombre
            {
                for (j = 0; j < 5; j++)                                                                         //Boucle pour le second nombre
                {
                    if (i != j)                                                                                 //Verif si les 2 nombres sont différents
                    {
                        for (k = 0; k < 4; k++)                                                                 //Boucle pour les 4 signes
                        {
                            score = 0;
                            if (UnSigne[k] == 0)                                                                //Si (UnSigne[k] == 0), alors : addition
                            {
                                if (MathadorGame.tableau[i] + MathadorGame.tableau[j] == MathadorGame.cible)    //Si l'addition = cible, alors écriture de l'équation dans le fichier JSON "Solutions"
                                {
                                    equation = MathadorGame.tableau[i].ToString() + "+" + MathadorGame.tableau[j].ToString() + "=" + MathadorGame.cible.ToString(); //Miseen forme de l'équation
                                    score++;                                                                    //Mise à jour du score : plus 1 pour une addition
                                    Solution Sol = new Solution();                                              //Création d'un nouvel objet "Solution"
                                    Sol.score = score;                                                          //Mise de score et de l'équation dans l'objet"Solution"
                                    Sol.equations=equation;
                                    Solutions.Add(Sol);                                                         //Mise de l'objet dans la liste de toutes les solutions
                                }
                            }
                            else if (UnSigne[k] == 1)                                                           //Si (UnSigne[k] == 1), alors : soustraction
                            {
                                if ((MathadorGame.tableau[i] - MathadorGame.tableau[j] > 0) && (MathadorGame.tableau[i] - MathadorGame.tableau[j] == MathadorGame.cible))   //Si la soustraction = cible et que le résultat de la soustraction
                                {                                                                                                                                           //est suppérieur à 0, alors écriture de l'équation dans le fichier JSON "Solutions"
                                    equation = MathadorGame.tableau[i].ToString() + "-" + MathadorGame.tableau[j].ToString() + "=" + MathadorGame.cible.ToString();
                                    score = score + 2;                                                          //Mise à jour du score : plus 2 pour une soustraction
                                    Solution Sol = new Solution();
                                    Sol.score = score;
                                    Sol.equations=equation;
                                    Solutions.Add(Sol);
                                }
                            }
                            else if (UnSigne[k] == 2)                                                           //Si (UnSigne[k] == 2), alors : multiplication
                            {
                                if (MathadorGame.tableau[i] * MathadorGame.tableau[j] == MathadorGame.cible)    //Si la multiplication = cible, alors écriture de l'équation dans le fichier JSON "Solutions"
                                {
                                    equation = MathadorGame.tableau[i].ToString() + "*" + MathadorGame.tableau[j].ToString() + "=" + MathadorGame.cible.ToString();
                                    score++;                                                                    //Mise à jour du score : plus 1 pour une multiplication
                                    Solution Sol = new Solution();
                                    Sol.score = score;
                                    Sol.equations=equation;
                                    Solutions.Add(Sol);
                                }
                            }
                            else if (UnSigne[k] == 3)                                                           //Si (UnSigne[k] == 3), alors : division
                            {
                                if (MathadorGame.tableau[i] % MathadorGame.tableau[j] == 0)                     //Si le reste de la division est égal à 0 et que le résultat
                                {                                                                               //est égal à la cible, alors écriture de l'équation dans le fichier JSON "Solutions"
                                    {
                                        if (MathadorGame.tableau[i] / MathadorGame.tableau[j] == MathadorGame.cible)
                                        {

                                            equation = MathadorGame.tableau[i].ToString() + "/" + MathadorGame.tableau[j].ToString() + "=" + MathadorGame.cible.ToString();
                                            score = score + 3;                                                  //Mise à jour du score : plus 3 pour une division
                                            Solution Sol = new Solution();
                                            Sol.score = score;
                                            Sol.equations=equation;
                                            Solutions.Add(Sol);
                                        }
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
            for (i = 0; i < 5; i++)                                                                             //Boucles pour les 3 nombres
            {
                for (j = 0; j < 5; j++)
                {
                    for (k = 0; k < 5; k++)
                    {
                        if (i != j && i != k && j != k)                                                         //Verif si les 3 nombres sont différents
                        {
                            for (l = 0; l < 16; l++)                                                            //Boucle pour les 16 possibilités d'équations différentes
                            {
                                score = 0;
                                valid = 0;
                                switch (DeuxSignes[0, l])                                                       //Vérif du signe de la première opération de l'équation
                                {
                                    case 0:                                                                     //addition
                                        {
                                            preresult = MathadorGame.tableau[i] + MathadorGame.tableau[j];      //première opération dans préresult et dans équation
                                            equation = MathadorGame.tableau[i].ToString() + "+" + MathadorGame.tableau[j].ToString() + "=" + preresult;
                                            score++;
                                            valid++;
                                            equationsTemp.Add(equation);                                        //Première partie de l'équation dans la liste temporaire d'équations
                                            break;
                                        }
                                    case 1:                                                                     //soustraction
                                        {
                                            if (MathadorGame.tableau[i] - MathadorGame.tableau[j] >= 0)
                                            {
                                                preresult = MathadorGame.tableau[i] - MathadorGame.tableau[j];
                                                equation = MathadorGame.tableau[i].ToString() + "-" + MathadorGame.tableau[j].ToString() + "=" + preresult;
                                                score = score + 2;
                                                valid++;
                                                equationsTemp.Add(equation);
                                            }
                                            break;
                                        }
                                    case 2:                                                                     //multiplication
                                        {
                                            preresult = MathadorGame.tableau[i] * MathadorGame.tableau[j];
                                            equation = MathadorGame.tableau[i].ToString() + "x" + MathadorGame.tableau[j].ToString() + "=" + preresult;
                                            score++;
                                            valid++;
                                            equationsTemp.Add(equation);
                                            break;
                                        }
                                    case 3:                                                                     //division
                                        {
                                            if (MathadorGame.tableau[i] % MathadorGame.tableau[j] == 0)
                                            {
                                                preresult = MathadorGame.tableau[i] / MathadorGame.tableau[j];
                                                equation = MathadorGame.tableau[i].ToString() + "/" + MathadorGame.tableau[j].ToString() + "=" + preresult;
                                                score = score + 3;
                                                valid++;
                                                equationsTemp.Add(equation);
                                            }
                                            break;
                                        }
                                }

                                switch (DeuxSignes[1, l])                                                       //Vérif du signe de la seconde opération de l'équation
                                {     
                                                                                                                //Si le résultat de la première opération et de la seconde est égal à la cible,
                                    case 0:                                                                     //alors écriture de l'équation dans le fichier JSON "Solutions"
                                        {
                                            if ((preresult + MathadorGame.tableau[k] == MathadorGame.cible) && (valid == 1))
                                            {
                                                equation = preresult + "+" + MathadorGame.tableau[k].ToString() + "=" + MathadorGame.cible.ToString();
                                                equationsTemp.Add(equation);                                    //Seconde partie de l'équation dans la liste temporaire d'équations
                                                score++;
                                                MaJSol();                                         
                                            }
                                            equationsTemp.Clear();                                              //Effacement de la liste temporaire d'équations                              
                                            break;
                                        }
                                    case 1:
                                        {
                                            if ((preresult - MathadorGame.tableau[k] >= 0 && preresult - MathadorGame.tableau[k] == MathadorGame.cible) && (valid == 1))
                                            {
                                                equation = preresult + "-" + MathadorGame.tableau[k].ToString() + "=" + MathadorGame.cible.ToString();
                                                score = score + 2;
                                                equationsTemp.Add(equation);
                                                MaJSol();

                                            }
                                            equationsTemp.Clear();
                                            break;
                                        }
                                    case 2:
                                        {
                                            if ((preresult * MathadorGame.tableau[k] > 0 && preresult * MathadorGame.tableau[k] == MathadorGame.cible) && (valid == 1))
                                            {
                                                equation = preresult + "x" + MathadorGame.tableau[k].ToString() + "=" + MathadorGame.cible.ToString();
                                                score++;
                                                equationsTemp.Add(equation);
                                                MaJSol();

                                            }
                                            equationsTemp.Clear();
                                            break;
                                        }
                                    case 3:
                                        {
                                            if ((preresult % MathadorGame.tableau[k] == 0 && preresult / MathadorGame.tableau[k] == MathadorGame.cible) && (valid == 1))
                                            {
                                                equation = preresult + "/" + MathadorGame.tableau[k].ToString() + "=" + MathadorGame.cible.ToString();
                                                score = score + 3;
                                                equationsTemp.Add(equation);
                                                MaJSol();

                                            }
                                            equationsTemp.Clear();
                                            break;
                                        }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void SolvTrheeOp()
        {
            for (i = 0; i < 5; i++)                                                                             //Boucles pour les 4 nombres
            {
                for (j = 0; j < 5; j++)
                {
                    for (k = 0; k < 5; k++)
                    {
                        for (l = 0; l < 5; l++)
                        {
                            if (i != j && i != k && j != k && l != i && l != j && l != k)                       //Vérif pour que les 4 nombres soient différents
                            {
                                for (op = 0; op < 64; op++)                                                     //Vérif pour les 64 possibilité d'équations différentes
                                {
                                    valid = 0;                                                                  //Variable pour vérifier que l'équation utilise 3 opérateurs
                                    score = 0;
                                    switch (TroisSignes[0, op])                                                 //Test du signe de la première partie de l'équation
                                    {                                                                           //Première opération dans "preresult"                                                                          
                                        case 0:                                                                 //Première partie de l'équation dans "equation"
                                            {
                                                preresult = MathadorGame.tableau[i] + MathadorGame.tableau[j];
                                                equation = MathadorGame.tableau[i].ToString() + "+" + MathadorGame.tableau[j].ToString() + "=" + preresult;
                                                equationsTemp.Add(equation);
                                                valid++;
                                                score++;
                                                break;
                                            }
                                        case 1:
                                            {
                                                if (MathadorGame.tableau[i] - MathadorGame.tableau[j] >= 0)
                                                {
                                                    preresult = MathadorGame.tableau[i] - MathadorGame.tableau[j];
                                                    equation = MathadorGame.tableau[i].ToString() + "-" + MathadorGame.tableau[j].ToString() + "=" + preresult;
                                                    equationsTemp.Add(equation);
                                                    valid++;
                                                    score = score + 2;
                                                }
                                                break;
                                            }
                                        case 2:
                                            {
                                                preresult = MathadorGame.tableau[i] * MathadorGame.tableau[j];
                                                equation = MathadorGame.tableau[i].ToString() + "x" + MathadorGame.tableau[j].ToString() + "=" + preresult;
                                                equationsTemp.Add(equation);
                                                valid++;
                                                score++;
                                                break;
                                            }
                                        case 3:
                                            {
                                                if (MathadorGame.tableau[i] % MathadorGame.tableau[j] == 0)
                                                {
                                                    preresult = MathadorGame.tableau[i] / MathadorGame.tableau[j];
                                                    equation = MathadorGame.tableau[i].ToString() + "/" + MathadorGame.tableau[j].ToString() + "=" + preresult;
                                                    equationsTemp.Add(equation);
                                                    valid++;
                                                    score = score + 3;
                                                }
                                                break;
                                            }
                                    }
                                    switch (TroisSignes[1, op])                                                 //Seconde opération de l'équation
                                    {
                                        case 0:
                                            {
                                                equation = preresult.ToString();
                                                preresult = preresult + MathadorGame.tableau[k];
                                                equation = equation + "+" + MathadorGame.tableau[k] + "=" + preresult;
                                                equationsTemp.Add(equation);
                                                valid++;
                                                score++;
                                                break;
                                            }
                                        case 1:
                                            {
                                                if (preresult - MathadorGame.tableau[k] > 0)
                                                {
                                                    equation = preresult.ToString();
                                                    preresult = preresult - MathadorGame.tableau[k];
                                                    equation = equation + "-" + MathadorGame.tableau[k] + "=" + preresult;
                                                    equationsTemp.Add(equation);
                                                    valid++;
                                                    score = score + 2;
                                                }
                                                break;
                                            }
                                        case 2:
                                            {
                                                if (preresult * MathadorGame.tableau[k] >= 0)
                                                {
                                                    equation = preresult.ToString();
                                                    preresult = preresult * MathadorGame.tableau[k];
                                                    equation = equation + "x" + MathadorGame.tableau[k] + "=" + preresult;
                                                    equationsTemp.Add(equation);
                                                    valid++;
                                                    score++;
                                                }
                                                break;
                                            }
                                        case 3:
                                            {
                                                if (preresult % MathadorGame.tableau[k] == 0)
                                                {
                                                    equation = preresult.ToString();
                                                    preresult = preresult / MathadorGame.tableau[k];
                                                    equation = equation + "/" + MathadorGame.tableau[k] + "=" + preresult;
                                                    equationsTemp.Add(equation);
                                                    valid++;
                                                    score = score + 3;
                                                }
                                                break;
                                            }
                                    }

                                    switch (TroisSignes[2, op])                                                 //Troisième partie de l'équation et écriture dans le fichier "Solutions"
                                    {
                                        case 0:
                                            {
                                                if ((preresult + MathadorGame.tableau[l] == MathadorGame.cible) && (valid == 2))
                                                {
                                                    equation = preresult + "+" + MathadorGame.tableau[l].ToString() + "=" + MathadorGame.cible.ToString();
                                                    equationsTemp.Add(equation);
                                                    score++;
                                                    MaJSol();
                                                }
                                                equationsTemp.Clear();
                                                break;
                                            }
                                        case 1:
                                            {
                                                if ((preresult - MathadorGame.tableau[l] >= 0 && preresult - MathadorGame.tableau[l] == MathadorGame.cible) && (valid == 2))
                                                {
                                                    equation = preresult + "-" + MathadorGame.tableau[l].ToString() + "=" + MathadorGame.cible.ToString();
                                                    equationsTemp.Add(equation);
                                                    score = score + 2;
                                                    MaJSol();

                                                }
                                                equationsTemp.Clear();
                                                break;
                                            }
                                        case 2:
                                            {
                                                if ((preresult * MathadorGame.tableau[l] > 0 && preresult * MathadorGame.tableau[l] == MathadorGame.cible) && (valid == 2))
                                                {
                                                    equation = preresult + "x" + MathadorGame.tableau[l].ToString() + "=" + MathadorGame.cible.ToString();
                                                    equationsTemp.Add(equation);
                                                    score++;
                                                    MaJSol();
                                                }
                                                equationsTemp.Clear();
                                                break;
                                            }
                                        case 3:
                                            {
                                                if ((preresult % MathadorGame.tableau[l] == 0 && preresult / MathadorGame.tableau[l] == MathadorGame.cible) && (valid == 2))
                                                {
                                                    equation = preresult.ToString();
                                                    equation = equation + "/" + MathadorGame.tableau[l].ToString() + "=" + MathadorGame.cible.ToString();
                                                    equationsTemp.Add(equation);
                                                    score = score + 3;
                                                    MaJSol();
                                                }
                                                equationsTemp.Clear();
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

        public void SolvfourOp()
        {
            for (i = 0; i < 5; i++)                                                                             //Boucles pour les 5 nombres        
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
                                    for (op = 0; op < 256; op++)                                                //Boucle pour les 256 équations possibles
                                    {
                                        valid = 0;
                                        score = 0;
                                        switch (QuatreSignes[0, op])
                                        {

                                            case 0:
                                                {
                                                    preresult = MathadorGame.tableau[i] + MathadorGame.tableau[j];
                                                    equation = MathadorGame.tableau[i].ToString() + "+" + MathadorGame.tableau[j].ToString() + "=" + preresult;
                                                    equationsTemp.Add(equation);
                                                    valid++;
                                                    score++;
                                                    break;
                                                }
                                            case 1:
                                                {
                                                    if (MathadorGame.tableau[i] - MathadorGame.tableau[j] >= 0)
                                                    {
                                                        preresult = MathadorGame.tableau[i] - MathadorGame.tableau[j];
                                                        equation = MathadorGame.tableau[i].ToString() + "-" + MathadorGame.tableau[j].ToString() + "=" + preresult;
                                                        equationsTemp.Add(equation);
                                                        valid++;
                                                        score = score + 2;
                                                    }
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    preresult = MathadorGame.tableau[i] * MathadorGame.tableau[j];
                                                    equation = MathadorGame.tableau[i].ToString() + "x" + MathadorGame.tableau[j].ToString() + "=" + preresult;
                                                    equationsTemp.Add(equation);
                                                    valid++;
                                                    score++;
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    if (MathadorGame.tableau[i] % MathadorGame.tableau[j] == 0)
                                                    {
                                                        preresult = MathadorGame.tableau[i] / MathadorGame.tableau[j];
                                                        equation = MathadorGame.tableau[i].ToString() + "/" + MathadorGame.tableau[j].ToString() + "=" + preresult;
                                                        equationsTemp.Add(equation);
                                                        valid++;
                                                        score = score + 3;
                                                    }
                                                    break;
                                                }
                                        }

                                        switch (QuatreSignes[1, op])
                                        {
                                            case 0:
                                                {
                                                    equation = preresult.ToString();
                                                    preresult = preresult + MathadorGame.tableau[k];
                                                    equation = equation + "+" + MathadorGame.tableau[k] + "=" + preresult;
                                                    equationsTemp.Add(equation);
                                                    valid++;
                                                    score++;
                                                    break;
                                                }
                                            case 1:
                                                {
                                                    if (preresult - MathadorGame.tableau[k] > 0)
                                                    {
                                                        equation = preresult.ToString();
                                                        preresult = preresult - MathadorGame.tableau[k];
                                                        equation = equation + "-" + MathadorGame.tableau[k] + "=" + preresult;
                                                        equationsTemp.Add(equation);
                                                        valid++;
                                                        score = score + 2;
                                                    }
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    if (preresult * MathadorGame.tableau[k] >= 0)
                                                    {
                                                        equation = preresult.ToString();
                                                        preresult = preresult * MathadorGame.tableau[k];
                                                        equation = equation + "x" + MathadorGame.tableau[k] + "=" + preresult;
                                                        equationsTemp.Add(equation);
                                                        valid++;
                                                        score++;
                                                    }
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    if (preresult % MathadorGame.tableau[k] == 0)
                                                    {
                                                        equation = preresult.ToString();
                                                        preresult = preresult / MathadorGame.tableau[k];
                                                        equation = equation + "/" + MathadorGame.tableau[k] + "=" + preresult;
                                                        equationsTemp.Add(equation);
                                                        valid++;
                                                        score = score + 3;
                                                    }
                                                    break;
                                                }
                                        }

                                        switch (QuatreSignes[2, op])
                                        {
                                            case 0:
                                                {
                                                    equation = preresult.ToString();
                                                    preresult = preresult + MathadorGame.tableau[k];
                                                    equation = equation + "+" + MathadorGame.tableau[k] + "=" + preresult;
                                                    equationsTemp.Add(equation);
                                                    valid++;
                                                    score++;
                                                    break;
                                                }
                                            case 1:
                                                {
                                                    if (preresult - MathadorGame.tableau[k] > 0)
                                                    {
                                                        equation = preresult.ToString();
                                                        preresult = preresult - MathadorGame.tableau[k];
                                                        equation = equation + "-" + MathadorGame.tableau[k] + "=" + preresult;
                                                        equationsTemp.Add(equation);
                                                        valid++;
                                                        score = score + 2;
                                                    }
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    if (preresult * MathadorGame.tableau[k] >= 0)
                                                    {
                                                        equation = preresult.ToString();
                                                        preresult = preresult * MathadorGame.tableau[k];
                                                        equation = equation + "x" + MathadorGame.tableau[k] + "=" + preresult;
                                                        equationsTemp.Add(equation);
                                                        valid++;
                                                        score++;
                                                    }
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    if (preresult % MathadorGame.tableau[k] == 0)
                                                    {
                                                        equation = preresult.ToString();
                                                        preresult = preresult / MathadorGame.tableau[k];
                                                        equation = equation + "/" + MathadorGame.tableau[k] + "=" + preresult;
                                                        equationsTemp.Add(equation);
                                                        valid++;
                                                        score = score + 3;
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
                                                        equation = preresult + "+" + MathadorGame.tableau[l].ToString() + "=" + MathadorGame.cible.ToString();
                                                        equationsTemp.Add(equation);
                                                        score++;
                                                        MaJSol();
                                                    }
                                                    equationsTemp.Clear();
                                                    break;
                                                }
                                            case 1:
                                                {
                                                    if (preresult - MathadorGame.tableau[l] >= 0 && preresult - MathadorGame.tableau[l] == MathadorGame.cible && valid == 3)
                                                    {
                                                        equation = preresult + "-" + MathadorGame.tableau[l].ToString() + "=" + MathadorGame.cible.ToString();
                                                        equationsTemp.Add(equation);
                                                        score = score + 2;
                                                        MaJSol();

                                                    }
                                                    equationsTemp.Clear();
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    if (preresult * MathadorGame.tableau[l] > 0 && preresult * MathadorGame.tableau[l] == MathadorGame.cible && valid == 3)
                                                    {
                                                        equation = preresult.ToString();
                                                        equation = equation + "x" + MathadorGame.tableau[l].ToString() + "=" + MathadorGame.cible.ToString();
                                                        equationsTemp.Add(equation);
                                                        score++;
                                                        MaJSol();
                                                    }
                                                    equationsTemp.Clear();
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    if (preresult % MathadorGame.tableau[l] == 0 && preresult / MathadorGame.tableau[l] == MathadorGame.cible && valid == 3)
                                                    {
                                                        equation = preresult.ToString();
                                                        equation = equation + "/" + MathadorGame.tableau[l].ToString() + "=" + MathadorGame.cible.ToString();
                                                        equationsTemp.Add(equation);
                                                        score = score + 3;
                                                        MaJSol();
                                                    }
                                                    equationsTemp.Clear();
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
        }

        public void MaJSol()
        {
            Solution Sol = new Solution();                                                                      //Création d'un nouvel objet "Solution"
            Sol.score = score;                                                                                  //Mise de score et de l'équation dans l'objet"Solution"
            Sol.equations = String.Join(" → ", equationsTemp.ToList());                                           //Conversion de la liste des equation de la solution en String
            Solutions.Add(Sol);                                                                                 //Ajout de l'objet Solution à la liste des "Solutions"
        }

        public List<Solution> SolvComplet()
        {
            TabSigne();
            SolvOneOp();
            SolvTowOp();
            SolvTrheeOp();
            SolvfourOp();
            string json = JsonConvert.SerializeObject(Solutions);                                               //Conversion de l'objet Solution en Json
            string jsonFormat = JValue.Parse(json).ToString(Formatting.Indented);                               //Formatage de l'objet json
            System.IO.File.WriteAllText("SolveurOutput.txt", jsonFormat);                                       //Écriture des Solutions dans un fichier .txt
            Console.WriteLine(jsonFormat);
            return Solutions;
        }
    }
    public class Solution
    {
        public int score;
        public string equations;
    }
}