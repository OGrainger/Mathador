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
        }
    }

    class Solver
    {
        private List<T> ResultsOfOp = new List<T>();

        public void Resolve(int num1, int num2, string operation)
        {
            int result;
            int points;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    points = 1;
                    break;
                case "-":
                    result = (num1 - num2 < 0 ? num1 - num2 : -1);
                    points = 2;
                    break;
                case "*":
                    result = num1 * num2;
                    points = 1;
                    break;
                case "/":
                    result = (num1 % num2 == 0 ? num1 / num2 : -1);
                    points = 4;
                    break;
            }
        }
    }
}
