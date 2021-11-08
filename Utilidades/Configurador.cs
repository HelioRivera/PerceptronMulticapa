using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronMulticapa.Utilidades
{
    static class Configurador
    {
       
        public static List<double> InputDePrueba(int tamanoInput, Random random)
        {
           
            List<double> valoresEntrada = new List<double>();

            for (int i = 0; i < tamanoInput; i++)
            {
                valoresEntrada.Add(random.NextDouble());
            }
            return valoresEntrada;
        }

       
    }
}
