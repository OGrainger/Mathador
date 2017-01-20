using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_solv
{
    class Program
    {
        static void Main(string[] args)
        {
            Solveur Solvtest = new Solveur();
            Solvtest.TabSigne();
            Console.ReadLine();
        }
    }
    public class Solveur
    {
        int i, j, k, l, preresult;
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
                Console.WriteLine("UnSigne[" + UnSigne[i] + "]");
            } Console.ReadLine();
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
                Console.WriteLine("DeuxSignes[" + DeuxSignes[0, j] + "," + DeuxSignes[1, j] + "]");
            }
            Console.ReadLine();
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
                Console.WriteLine("TroisSignes[" + TroisSignes[0, j] + "," + TroisSignes[1, j] + "," + TroisSignes[2, j] + "]");
            }
            Console.ReadLine();
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
                Console.WriteLine("QuatreSignes[" + QuatreSignes[0, j] + "," + QuatreSignes[1, j] + "," + QuatreSignes[2, j] + "," + QuatreSignes[3, j] + "]");
            }
            Console.ReadLine();
        }

        
        /*public void SolvOneOp()
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
                                            equation = MathadorGame.tableau[i].ToString() + " + " + MathadorGame.tableau[j].ToString() + " = " + MathadorGame.cible.ToString() + "\n";

                                            string json = JsonConvert.SerializeObject(equation);
                                            System.IO.File.AppendAllText("Solutions.db", json);
                                        }
                                        break;
                                    }
                                case 1:
                                    {
                                        preresult = MathadorGame.tableau[i] - MathadorGame.tableau[j];
                                        if ((preresult > 0) && (preresult == MathadorGame.cible))
                                        {
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
                                            equation = MathadorGame.tableau[i].ToString() + " * " + MathadorGame.tableau[j].ToString() + " = " + MathadorGame.cible.ToString() + "\n";

                                            string json = JsonConvert.SerializeObject(equation);
                                            System.IO.File.AppendAllText("Solutions.db", json);
                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        if (MathadorGame.tableau[i] % MathadorGame.tableau[j] == 0)
                                        {
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

        public void SolvTowOp()
        {
            for (i = 0; i == 3; i++)
            {
                preresult = MathadorGame.tableau[i + 1];
                equation = "";
                for (k = 0; k == 15; k++)
                {
                    for (l = 0; l == 1; l++)
                    {
                        switch (DeuxSignes[k, l])
                        {
                            case 0:
                                {
                                    preresult = MathadorGame.tableau[i] + preresult;
                                    if (equation == "")
                                    {
                                        equation = MathadorGame.tableau[i].ToString() + " + " + preresult;
                                    }
                                    else
                                    {
                                        equation = MathadorGame.tableau[i].ToString() + " + " + equation;
                                    }
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
                                            equation = MathadorGame.tableau[i].ToString() + " - " + equation;
                                        }
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    preresult = MathadorGame.tableau[i] * preresult;
                                    if (equation == "")
                                    {
                                        equation = " ( " + MathadorGame.tableau[i].ToString() + " * " + preresult + " ) ";
                                    }
                                    else
                                    {
                                        equation = " ( " + equation + " * " + MathadorGame.tableau[i].ToString() + " ) ";
                                    }
                                    break;

                                }
                            case 3:
                                {
                                    if (MathadorGame.tableau[i] % preresult == 0)
                                    {
                                        preresult = MathadorGame.tableau[i] / preresult;
                                        if (equation == "")
                                        {
                                            equation = " ( " + MathadorGame.tableau[i].ToString() + " / " + preresult + " ) ";
                                        }
                                        else
                                        {
                                            equation = " ( " + equation + " / " + MathadorGame.tableau[i].ToString() + " ) ";
                                        }
                                    }
                                    break;

                                }
                        }
                        if (preresult == MathadorGame.cible)
                        {
                            equation = equation + " = " + MathadorGame.cible + "\n";
                            string json = JsonConvert.SerializeObject(equation);
                            System.IO.File.AppendAllText("Solutions.db", json);
                        }
                    }
                }
            }
        }

        public void SolvTrheeOp()
        {
            for (i = 0; i == 3; i++)
            {
                preresult = MathadorGame.tableau[i + 1];
                equation = "";
                for (k = 0; k == 63; k++)
                {
                    for (l = 0; l == 2; l++)
                    {
                        switch (TroisSignes[k, l])
                        {
                            case 0:
                                {
                                    preresult = MathadorGame.tableau[i] + preresult;
                                    if (equation == "")
                                    {
                                        equation = MathadorGame.tableau[i].ToString() + " + " + preresult;
                                    }
                                    else
                                    {
                                        equation = equation + " + " + MathadorGame.tableau[i].ToString();
                                    }
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
                                            equation = equation + " - " + MathadorGame.tableau[i].ToString();
                                        }
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    preresult = MathadorGame.tableau[i] * preresult;
                                    if (equation == "")
                                    {
                                        equation = " ( " + MathadorGame.tableau[i].ToString() + " * " + preresult + " ) ";
                                    }
                                    else
                                    {
                                        equation = " ( " + equation + " * " + MathadorGame.tableau[i].ToString() + " ) ";
                                    }
                                    break;

                                }
                            case 3:
                                {
                                    if (MathadorGame.tableau[i] % preresult == 0)
                                    {
                                        preresult = MathadorGame.tableau[i] / preresult;
                                        if (equation == "")
                                        {
                                            equation = "(" + MathadorGame.tableau[i].ToString() + " / " + preresult + ")";
                                        }
                                        else
                                        {
                                            equation = "(" + equation + " / " + MathadorGame.tableau[i].ToString() + ")";
                                        }
                                    }
                                    break;

                                }
                        }
                        if (preresult == MathadorGame.cible)
                        {
                            equation = equation + " = " + MathadorGame.cible + "\n";
                            string json = JsonConvert.SerializeObject(equation);
                            System.IO.File.AppendAllText("Solutions.db", json);
                        }
                    }
                }
            }
        }

        public void SolvfourOp()
        {
            for (i = 0; i == 3; i++)
            {
                preresult = MathadorGame.tableau[i + 1];
                equation = "";
                for (k = 0; k == 255; k++)
                {
                    for (l = 0; l == 3; l++)
                    {
                        switch (TroisSignes[k, l])
                        {
                            case 0:
                                {
                                    preresult = MathadorGame.tableau[i] + preresult;
                                    if (equation == "")
                                    {
                                        equation = MathadorGame.tableau[i].ToString() + " + " + preresult;
                                    }
                                    else
                                    {
                                        equation = equation + " + " + MathadorGame.tableau[i].ToString();
                                    }
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
                                            equation = equation + " - " + MathadorGame.tableau[i].ToString();
                                        }
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    preresult = MathadorGame.tableau[i] * preresult;
                                    if (equation == "")
                                    {
                                        equation = " ( " + MathadorGame.tableau[i].ToString() + " * " + preresult + " ) ";
                                    }
                                    else
                                    {
                                        equation = " ( " + equation + " * " + MathadorGame.tableau[i].ToString() + " ) ";
                                    }
                                    break;

                                }
                            case 3:
                                {
                                    if (MathadorGame.tableau[i] % preresult == 0)
                                    {
                                        preresult = MathadorGame.tableau[i] / preresult;
                                        if (equation == "")
                                        {
                                            equation = "(" + MathadorGame.tableau[i].ToString() + " / " + preresult + ")";
                                        }
                                        else
                                        {
                                            equation = "(" + equation + " / " + MathadorGame.tableau[i].ToString() + ")";
                                        }
                                    }
                                    break;

                                }
                        }
                        if (preresult == MathadorGame.cible)
                        {
                            equation = equation + " = " + MathadorGame.cible + "\n";
                            string json = JsonConvert.SerializeObject(equation);
                            System.IO.File.AppendAllText("Solutions.db", json);
                        }

                    }
                }
            }
        }*/

        public void SolvComplet()
        {
            TabSigne();
            /*SolvOneOp();
            SolvTowOp();
            SolvTrheeOp();
            SolvfourOp();*/

        }
    }
}





