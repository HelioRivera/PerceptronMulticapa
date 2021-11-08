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
        int tamanoEntrada;
        int cantidadCapas;
        

        
        public void CreaCapas(Random azar, int [] neuronasPorCapa, int tamanoentradaRed)
        {
            capas = new List<Capa>();

            capas.Add(new Capa(azar, neuronasPorCapa[0], tamanoentradaRed,0));

            for (int i = 1; i < neuronasPorCapa.Length; i++)
            {
                capas.Add(new Capa(azar, neuronasPorCapa[i], neuronasPorCapa[i - 1],i));
            }

            cantidadCapas = capas.Count;

        }

        public void CalculaSalida(List<double> entradas, int cuantasCapas)
        {
            tamanoEntrada = entradas.Count;
            
            capas[0].CalculaCapa(entradas, cuantasCapas);

            for (int i=1; i<capas.Count;i++ )
            {
                //Las salidas de la capa anterior son las entradas de la siguiente capa
                capas[i].CalculaCapa(capas[i-1].GetSalida(), cuantasCapas);
            }
           
        }
        public int GetCantidadCapas()
        {
            return cantidadCapas;
        }

        public int GetTamanoEntrada()
        {
            return tamanoEntrada;
        }

        public List<Capa> getCapas()
        {
            return capas;
        }
    }
}
