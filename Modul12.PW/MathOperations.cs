using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12.PW
{
    public class MathOperations
    {
        public delegate double MathOperation(double x, double y);

        public static double Add(double x, double y) => x + y;
        public static double Subtract(double x, double y) => x - y;
        public static double Multiply(double x, double y) => x * y;
        public static double Divide(double x, double y) => y != 0 ? x / y : double.NaN;

        public static double PerformOperation(double x, double y, MathOperation operation)
        {
            return operation(x, y);
        }
    }

}
