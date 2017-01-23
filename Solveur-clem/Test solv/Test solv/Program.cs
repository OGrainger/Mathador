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
            Solvtest.SolvOneOp();
            Solvtest.SolvTowOp();
            Solvtest.SolvTrheeOp();
            Solvtest.SolvfourOp();
            Console.ReadLine();
        }
    }
    public class Solveur
    {
        int i, j, k, l, m, preresult;
        int op, valid;
        string equation = "";
        public int[] UnSigne = new int[4];
        int[,] DeuxSignes = new int[2, 16];
        int[,] TroisSignes = new int[3, 64];
        int[,] QuatreSignes = new int[4, 256];
        int[] tableau = new int[5] { 2, 1, 3, 4, 5 };
        int cible;




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
                //Console.WriteLine("DeuxSignes[" + DeuxSignes[0, j] + "," + DeuxSignes[1, j] + "]");
            }
            //Console.ReadLine();
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
                //Console.WriteLine("TroisSignes[" + TroisSignes[0, j] + "," + TroisSignes[1, j] + "," + TroisSignes[2, j] + "]");
            }
            //Console.ReadLine();
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
                //Console.WriteLine("QuatreSignes[" + QuatreSignes[0, j] + "," + QuatreSignes[1, j] + "," + QuatreSignes[2, j] + "," + QuatreSignes[3, j] + "]");
            }
            //Console.ReadLine();
        }


        public void SolvOneOp()
        {
            cible = 8;
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
                                //Console.WriteLine("i:" + i + " j:" + j + " k:" + k);
                                preresult = tableau[i] + tableau[j];
                                if (preresult == cible)
                                {
                                    equation = tableau[i].ToString() + "+" + tableau[j].ToString() + "=" + cible.ToString() + "\n";
                                    Console.WriteLine(equation);
                                    //string json = JsonConvert.SerializeObject(equation);
                                    //System.IO.File.AppendAllText("Solutions.db", json);
                                }
                            }
                            else if (UnSigne[k] == 1)
                            {
                                preresult = tableau[i] - tableau[j];
                                if ((preresult > 0) && (preresult == cible))
                                {
                                    equation = tableau[i].ToString() + "-" + tableau[j].ToString() + "=" + cible.ToString() + "\n";
                                    Console.WriteLine(equation);
                                    //string json = JsonConvert.SerializeObject(equation);
                                    //System.IO.File.AppendAllText("Solutions.db", json);
                                }
                            }
                            else if (UnSigne[k] == 2)
                            {
                                preresult = tableau[i] * tableau[j];
                                if (preresult == cible)
                                {
                                    equation = tableau[i].ToString() + "*" + tableau[j].ToString() + "=" + cible.ToString() + "\n";
                                    Console.WriteLine(equation);
                                    //string json = JsonConvert.SerializeObject(equation);
                                    //System.IO.File.AppendAllText("Solutions.db", json);
                                }
                            }
                            else if (UnSigne[k] == 3)
                            {
                                if (tableau[i] % tableau[j] == 0)
                                {
                                    preresult = tableau[i] / tableau[j];


                                    if (preresult == cible)
                                    {
                                        equation = tableau[i].ToString() + "/" + tableau[j].ToString() + "=" + cible.ToString() + "\n";
                                        Console.WriteLine(equation);
                                        //string json = JsonConvert.SerializeObject(equation);
                                        //System.IO.File.AppendAllText("Solutions.db", json);
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
            cible = 16;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    for (k = 0; k < 5; k++)
                    {
                        //Console.WriteLine("i:" + i + " j:" + j + " k:" + k);
                        preresult = 0;
                        if (i != j && i != k && j != k)
                        {
                            for (l = 0; l < 16; l++)
                            {
                                equation = "";
                                switch (DeuxSignes[0, l])
                                {
                                    case 0:
                                        {
                                            preresult = tableau[i] + tableau[j];
                                            equation = tableau[i].ToString() + "+" + tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                            //Console.WriteLine("preresult" + preresult);
                                            //Console.WriteLine(equation);
                                            break;
                                        }
                                    case 1:
                                        {
                                            if (tableau[i] - tableau[j] >= 0)
                                            {
                                                preresult = tableau[i] - tableau[j];
                                                equation = tableau[i].ToString() + "-" + tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                                //Console.WriteLine("preresult" + preresult);
                                                //Console.WriteLine(equation);
                                            }
                                            break;
                                        }
                                    case 2:
                                        {
                                            preresult = tableau[i] * tableau[j];
                                            equation = tableau[i].ToString() + "x" + tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                            //Console.WriteLine(equation);
                                            break;
                                        }
                                    case 3:
                                        {
                                            if (tableau[i] % tableau[j] == 0)
                                            {
                                                preresult = tableau[i] / tableau[j];
                                                equation = tableau[i].ToString() + "/" + tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                                //Console.WriteLine("preresult" + preresult);
                                                //Console.WriteLine(equation);;
                                            }
                                            break;
                                        }
                                }
                                //Console.ReadLine();
                                
                                switch (DeuxSignes[1, l])
                                {
                                    case 0:
                                        {
                                            if (preresult+tableau[k] == cible)
                                            {
                                                equation = equation + "+" + tableau[k].ToString() + "=" + cible.ToString() + "\n";
                                                //Console.WriteLine("preresult" + preresult);
                                                Console.WriteLine(equation);
                                                //string json = JsonConvert.SerializeObject(equation);
                                                //System.IO.File.AppendAllText("Solutions.db", json);
                                            }
                                            break;
                                        }
                                    case 1:
                                        {
                                            if (preresult - tableau[k] >= 0 && preresult - tableau[k] == cible)
                                            {
                                                equation = equation + "-" + tableau[k].ToString() + "=" + cible.ToString() + "\n";
                                                //Console.WriteLine("preresult" + preresult);
                                                Console.WriteLine(equation);
                                                //string json = JsonConvert.SerializeObject(equation);
                                                //System.IO.File.AppendAllText("Solutions.db", json);
                                            }
                                            break;
                                        }
                                    case 2:
                                        {
                                            if (preresult * tableau[k] > 0 && preresult * tableau[k] ==cible)
                                            {
                                                equation = equation + "x" + tableau[k].ToString() + "=" + cible.ToString() + "\n";
                                                //Console.WriteLine("preresult" + preresult);
                                                Console.WriteLine(equation);
                                                //string json = JsonConvert.SerializeObject(equation);
                                                //System.IO.File.AppendAllText("Solutions.db", json);
                                            }
                                            break;
                                        }
                                    case 3:
                                        {
                                            if (preresult % tableau[k] == 0 && preresult / tableau[k] == cible)
                                            {
                                                equation = equation + "/" + tableau[k].ToString() + "=" + cible.ToString() + "\n";
                                                //Console.WriteLine("preresult" + preresult);
                                                Console.WriteLine(equation);
                                                //string json = JsonConvert.SerializeObject(equation);
                                                //System.IO.File.AppendAllText("Solutions.db", json);                                         
                                            }
                                            break;
                                        }
                                }
                                preresult = 0;
                                //Console.ReadLine();
                            }
                        }
                    }
                }
            }
            //Console.ReadLine();
        }

        public void SolvTrheeOp()
        {
            cible = 16;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    for (k = 0; k < 5; k++)
                    {
                        for (l = 0; l < 5; l++)
                        {
                            //Console.WriteLine("i:" + i + " j:" + j + " k:" + k + "l:" + l);
                            if (i != j && i != k && j != k && l!=i && l!=j && l!=k)
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
                                                preresult = tableau[i] + tableau[j];
                                                equation = tableau[i].ToString() + "+" + tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                                valid++;
                                                //Console.WriteLine("preresult" + preresult);
                                                //Console.WriteLine("equation:" + equation);
                                                break;
                                            }
                                        case 1:
                                            {
                                                if (tableau[i] - tableau[j] >= 0)
                                                {
                                                    preresult = tableau[i] - tableau[j];
                                                    equation = tableau[i].ToString() + "-" + tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                                    valid++;
                                                    //Console.WriteLine("preresult" + preresult);
                                                    //Console.WriteLine("equation:" + equation);
                                                }
                                                break;
                                            }
                                        case 2:
                                            {
                                                preresult = tableau[i] * tableau[j];
                                                equation = tableau[i].ToString() + "x" + tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                                valid++;
                                                //Console.WriteLine("preresult" + preresult);
                                                //Console.WriteLine("equation:" + equation);
                                                break;
                                            }
                                        case 3:
                                            {
                                                if (tableau[i] % tableau[j] == 0)
                                                {
                                                    preresult = tableau[i] / tableau[j];
                                                    equation = tableau[i].ToString() + "/" + tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                                    valid++;
                                                    //Console.WriteLine("preresult" + preresult);
                                                    //Console.WriteLine("equation:" + equation);
                                                }
                                                break;
                                            }    
                                    }
                                    //Console.ReadLine();
                                   
                                    switch(TroisSignes[1, op])
                                    {
                                        case 0:
                                            {
                                                preresult = preresult + tableau[k];
                                                equation = equation + "+" + tableau[k] +  "=" + preresult + " => " + preresult;
                                                valid++;
                                                //Console.WriteLine("preresult" + preresult);
                                                //Console.WriteLine("equation:" + equation);
                                                break;
                                            }
                                        case 1:
                                            {
                                                if (preresult - tableau[k] > 0)
                                                {
                                                    preresult = preresult - tableau[k];
                                                    equation = equation + "-" + tableau[k] + "=" + preresult + " => " + preresult;
                                                    valid++;
                                                    //Console.WriteLine("preresult" + preresult);
                                                    //Console.WriteLine("equation:" + equation);
                                                }
                                                break;
                                            }
                                        case 2:
                                            {
                                                if (preresult * tableau[k] >= 0)
                                                {
                                                    preresult = preresult * tableau[k];
                                                    equation = equation + "x" + tableau[k] + "=" + preresult + " => " + preresult;
                                                    valid++;
                                                    //Console.WriteLine("preresult" + preresult);
                                                    //Console.WriteLine("equation:" + equation);
                                                }
                                                break; 
                                            }
                                        case 3:
                                            {
                                                if (preresult % tableau[k] == 0)
                                                {
                                                    preresult = preresult / tableau[k];
                                                    equation = equation + "/" + tableau[k] + "=" + preresult + " => " + preresult;
                                                    valid++;
                                                    //Console.WriteLine("preresult" + preresult);
                                                    //Console.WriteLine("equation:" + equation);
                                                }
                                                break;
                                            }   
                                    }
                                   
                                    switch (TroisSignes[2, op])
                                    {
                                        case 0:
                                            {
                                                if (preresult + tableau[l] == cible && valid==2)
                                                {
                                                    equation = equation + "+" + tableau[l].ToString() + "=" + cible.ToString() + "\n";
                                                    //Console.WriteLine("preresult" + preresult);
                                                    Console.WriteLine(equation);
                                                    //string json = JsonConvert.SerializeObject(equation);
                                                    //System.IO.File.AppendAllText("Solutions.db", json);
                                                }
                                                break;
                                            }
                                        case 1:
                                            {
                                                if (preresult - tableau[l] >= 0 && preresult - tableau[l] == cible && valid == 2)
                                                {
                                                    equation = equation + "-" + tableau[l].ToString() + "=" + cible.ToString() + "\n";
                                                    //Console.WriteLine("preresult" + preresult);
                                                    Console.WriteLine(equation);
                                                    //string json = JsonConvert.SerializeObject(equation);
                                                    //System.IO.File.AppendAllText("Solutions.db", json);
                                                }
                                                break;
                                            }
                                        case 2:
                                            {
                                                if (preresult * tableau[l] > 0 && preresult * tableau[l] == cible && valid == 2)
                                                {
                                                    equation = equation + "x" + tableau[l].ToString() + "=" + cible.ToString() + "\n";
                                                    //Console.WriteLine("preresult" + preresult);
                                                    Console.WriteLine(equation);
                                                    //string json = JsonConvert.SerializeObject(equation);
                                                    //System.IO.File.AppendAllText("Solutions.db", json);
                                                }
                                                break;
                                            }
                                        case 3:
                                            {
                                                if (preresult % tableau[l] == 0 && preresult / tableau[l] == cible && valid == 2)
                                                {
                                                    equation = equation + "/" + tableau[l].ToString() + "=" + cible.ToString() + "\n";
                                                    //Console.WriteLine("preresult" + preresult);
                                                    Console.WriteLine(equation);
                                                    //string json = JsonConvert.SerializeObject(equation);
                                                    //System.IO.File.AppendAllText("Solutions.db", json);                                         
                                                }
                                                break;
                                            }
                                    }
                                    preresult = 0;
                                    
                                    //Console.ReadLine();
                                }
                            }
                        }
                    }
                }
            }
            
            //Console.ReadLine();
        }

        public void SolvfourOp()
        {
            cible = 16;
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
                                //Console.WriteLine("i:" + i + " j:" + j + " k:" + k + "l:" + l);
                                if (i != j && i != k && j != k && l != i && l != j && l != k && m!=i && m!=j && m!=k && m!=l)
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
                                                    preresult = tableau[i] + tableau[j];
                                                    equation = tableau[i].ToString() + "+" + tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                                    valid++;
                                                    //Console.WriteLine("preresult" + preresult);
                                                    //Console.WriteLine("equation:" + equation);
                                                    break;
                                                }
                                            case 1:
                                                {
                                                    if (tableau[i] - tableau[j] >= 0)
                                                    {
                                                        preresult = tableau[i] - tableau[j];
                                                        equation = tableau[i].ToString() + "-" + tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                                        valid++;
                                                        //Console.WriteLine("preresult" + preresult);
                                                        //Console.WriteLine("equation:" + equation);
                                                    }
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    preresult = tableau[i] * tableau[j];
                                                    equation = tableau[i].ToString() + "x" + tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                                    valid++;
                                                    //Console.WriteLine("preresult" + preresult);
                                                    //Console.WriteLine("equation:" + equation);
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    if (tableau[i] % tableau[j] == 0)
                                                    {
                                                        preresult = tableau[i] / tableau[j];
                                                        equation = tableau[i].ToString() + "/" + tableau[j].ToString() + "=" + preresult + " => " + preresult;
                                                        valid++;
                                                        //Console.WriteLine("preresult" + preresult);
                                                        //Console.WriteLine("equation:" + equation);
                                                    }
                                                    break;
                                                }
                                        }
                                        //Console.ReadLine();

                                        switch (QuatreSignes[1, op])
                                        {
                                            case 0:
                                                {
                                                    preresult = preresult + tableau[k];
                                                    equation = equation + "+" + tableau[k] + "=" + preresult + " => " + preresult;
                                                    valid++;
                                                    //Console.WriteLine("preresult" + preresult);
                                                    //Console.WriteLine("equation:" + equation);
                                                    break;
                                                }
                                            case 1:
                                                {
                                                    if (preresult - tableau[k] > 0)
                                                    {
                                                        preresult = preresult - tableau[k];
                                                        equation = equation + "-" + tableau[k] + "=" + preresult + " => " + preresult;
                                                        valid++;
                                                        //Console.WriteLine("preresult" + preresult);
                                                        //Console.WriteLine("equation:" + equation);
                                                    }
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    if (preresult * tableau[k] >= 0)
                                                    {
                                                        preresult = preresult * tableau[k];
                                                        equation = equation + "x" + tableau[k] + "=" + preresult + " => " + preresult;
                                                        valid++;
                                                        //Console.WriteLine("preresult" + preresult);
                                                        //Console.WriteLine("equation:" + equation);
                                                    }
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    if (preresult % tableau[k] == 0)
                                                    {
                                                        preresult = preresult / tableau[k];
                                                        equation = equation + "/" + tableau[k] + "=" + preresult + " => " + preresult;
                                                        valid++;
                                                        //Console.WriteLine("preresult" + preresult);
                                                        //Console.WriteLine("equation:" + equation);
                                                    }
                                                    break;
                                                }
                                        }

                                        switch (QuatreSignes[2, op])
                                        {
                                            case 0:
                                                {
                                                    preresult = preresult + tableau[k];
                                                    equation = equation + "+" + tableau[k] + "=" + preresult + " => " + preresult;
                                                    valid++;
                                                    //Console.WriteLine("preresult" + preresult);
                                                    //Console.WriteLine("equation:" + equation);
                                                    break;
                                                }
                                            case 1:
                                                {
                                                    if (preresult - tableau[k] > 0)
                                                    {
                                                        preresult = preresult - tableau[k];
                                                        equation = equation + "-" + tableau[k] + "=" + preresult + " => " + preresult;
                                                        valid++;
                                                        //Console.WriteLine("preresult" + preresult);
                                                        //Console.WriteLine("equation:" + equation);
                                                    }
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    if (preresult * tableau[k] >= 0)
                                                    {
                                                        preresult = preresult * tableau[k];
                                                        equation = equation + "x" + tableau[k] + "=" + preresult + " => " + preresult;
                                                        valid++;
                                                        //Console.WriteLine("preresult" + preresult);
                                                        //Console.WriteLine("equation:" + equation);
                                                    }
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    if (preresult % tableau[k] == 0)
                                                    {
                                                        preresult = preresult / tableau[k];
                                                        equation = equation + "/" + tableau[k] + "=" + preresult + " => " + preresult;
                                                        valid++;
                                                        //Console.WriteLine("preresult" + preresult);
                                                        //Console.WriteLine("equation:" + equation);
                                                    }
                                                    break;
                                                }
                                        }

                                        switch (QuatreSignes[3, op])
                                        {
                                            case 0:
                                                {
                                                    if (preresult + tableau[l] == cible && valid == 3)
                                                    {
                                                        equation = equation + "+" + tableau[l].ToString() + "=" + cible.ToString() + "\n";
                                                        //Console.WriteLine("preresult" + preresult);
                                                        Console.WriteLine(equation);                                                     
                                                        //string json = JsonConvert.SerializeObject(equation);
                                                        //System.IO.File.AppendAllText("Solutions.db", json);
                                                    }
                                                    break;
                                                }
                                            case 1:
                                                {
                                                    if (preresult - tableau[l] >= 0 && preresult - tableau[l] == cible && valid == 3)
                                                    {
                                                        equation = equation + "-" + tableau[l].ToString() + "=" + cible.ToString() + "\n";
                                                        //Console.WriteLine("preresult" + preresult);
                                                        Console.WriteLine(equation);                                                       
                                                        //string json = JsonConvert.SerializeObject(equation);
                                                        //System.IO.File.AppendAllText("Solutions.db", json);
                                                    }
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    if (preresult * tableau[l] > 0 && preresult * tableau[l] == cible && valid == 3)
                                                    {
                                                        equation = equation + "x" + tableau[l].ToString() + "=" + cible.ToString() + "\n";
                                                        //Console.WriteLine("preresult" + preresult);
                                                        Console.WriteLine(equation);                                                       
                                                        //string json = JsonConvert.SerializeObject(equation);
                                                        //System.IO.File.AppendAllText("Solutions.db", json);
                                                    }
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    if (preresult % tableau[l] == 0 && preresult / tableau[l] == cible && valid == 3)
                                                    {
                                                        equation = equation + "/" + tableau[l].ToString() + "=" + cible.ToString() + "\n";
                                                        //Console.WriteLine("preresult" + preresult);
                                                        Console.WriteLine(equation);
                                                        //string json = JsonConvert.SerializeObject(equation);
                                                        //System.IO.File.AppendAllText("Solutions.db", json);                                         
                                                    }
                                                    break;
                                                }
                                        }
                                        preresult = 0;

                                        //Console.ReadLine();
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //Console.ReadLine();
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





