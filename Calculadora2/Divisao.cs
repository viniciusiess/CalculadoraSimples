using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora2
{
    public class Divisao
    {
        public float PerformDivisao(float num1, float num2)
        {
            if(num2 != 0)
            {
                return num1 / num2;
            } else
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
        }
    }
}
