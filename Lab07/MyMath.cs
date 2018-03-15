using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class MyMath
    {
        public double result { get; set; }
        public double operand1 { get; set; }
        public double operand2 { get; set; }
        public void Multiply(double operand1, double operand2)
        {
            result = operand1 * operand2;
        }
        public void Divide(double operand1, double operand2)
        {
            result = operand1 / operand2;
        }
        public void Subtract(double operand1, double operand2)
        {
            result = operand1 - operand2;
        }
        public void Add(double operand1, double operand2)
        {
            result = operand1 + operand2;
        }
        public double GetResult { get; set; }
    }
}
