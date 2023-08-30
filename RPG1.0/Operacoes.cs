using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG1._0
{
    internal class Operacoes
    {
        int total;

        public int somar(int x, int y) //x-> val1 e y->val2
        {
            total = x + y;
            return total;
        }
        public int subtrair(int x, int y)
        {
            total = x - y;
            return total;
        }
        public int dividir(int x, int y)
        {
            total = x / y;
            return total;
        }
        public int multiplicar(int x, int y)
        {
            total = x * y;
            return total;
        }
    }


}
