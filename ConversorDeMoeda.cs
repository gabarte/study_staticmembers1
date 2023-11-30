using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo_membrosestaticos1
{
     public class ConversorDeMoeda
    {
        public static double Iof = 6;
        public static double DolarParaReal(double cotacao, double quantia)
        {
            double total = quantia * cotacao;
            return total + (total * Iof / 100);
        }
    }
}
