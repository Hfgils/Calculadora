using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operaciones_Matematicas
    {

        public Double suma(Double n1, Double n2) {
            Double Resultado = n1 + n2;
            return Resultado;
        }

        public Double resta(Double n1, Double n2)
        {
            Double Resultado = n1 - n2;
            return Resultado;
        }

        public Double Multiplicacion(Double n1, Double n2)
        {
            Double Resultado = n1 * n2;
            return Resultado;
        }

        public Double divicion(Double n1, Double n2)
        {
            Double Resultado = n1 / n2;
            return Resultado;
        }

        public Double factorial(Double n1)
        {
            if (n1 == 0 || n1 == 1)
            {
                return 1;
            }
            else {
                return n1 * factorial(n1-1);
            }
        }


    }
}
