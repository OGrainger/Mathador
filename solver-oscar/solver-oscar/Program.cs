using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solver_oscar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> resultats = new List<int>();
            Solver solveur = new Solver();
            resultats = solveur.Operand(1, 2);
            resultats.ForEach(i => Console.Write("{0}\t", i));
            Console.ReadKey();
        }
    }
    public class Solver
    {
        public List<int> results = new List<int>();

        public List<int> Operand(int num1, int num2)
        {
            results.Add(Adder(num1, num2));
            results.Add(Multiplier(num1, num2));
            results.Add(Divider(num1, num2));
            results.Add(Divider(num2, num1));
            results.Add(Substracter(num1, num2));
            results.Add(Substracter(num2, num1));
            return results;
        }

        public int Adder(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Multiplier(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Divider(int num1, int num2)
        {
            return (num1 % num2 > 0 ? -1 : num1 / num2);
        }
        public int Substracter(int num1, int num2)
        {
            return (num1 - num2 < 0 ? -1 : num1 - num2);
        }
    }
}
