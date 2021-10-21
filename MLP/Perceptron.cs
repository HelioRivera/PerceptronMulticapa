using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronMulticapa.MLP
{
    class Perceptron
    {
        List<Capa> capas;
        //Crea las diversas capas
        //para la variable de tipo lista "neuronaPorCapa" se considera a la entrada  como una capa mas 
        // aunque esta tecnicamente hablando no lo sea.
        //hay que tener en cuenta que la salida de una capa i-1 corresponde a la entrada de una capa i

        public void CreaCapas(Random azar, List<int> neuronasPorCapa)
        {
            capas = new List<Capa>();
            for (int i = 1; i < neuronasPorCapa.Count; i++)
            {
                capas.Add(new Capa(azar, neuronasPorCapa[i], neuronasPorCapa[i - 1]));
            }
        }

        public void CalculaSalida(List<double> entradas)
        {
            Console.WriteLine("los valores de entrada de la red son:");
            capas[0].CalculaCapa(entradas);
            for (int i=1; i<capas.Count;++i )
            {
                Console.WriteLine("la salida para la capa "+i+ " es :");
                //Las salidas de la capa anterior son las entradas de la siguiente capa
                capas[i].CalculaCapa(capas[i-1].GetSalida());
            }
           
        }
    }
}
