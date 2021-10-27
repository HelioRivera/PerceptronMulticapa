using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronMulticapa.MLP
{
    class Neurona
    {
        private List<double> pesos; //Los pesos para cada entrada
        double umbral; //El peso del umbral
                       //Inicializa los pesos y umbral con un valor al azar

        public Neurona(Random azar, int totalEntradas)
        {
            pesos = new List<double>();
            for (int cont = 0; cont < totalEntradas; cont++)
            {
                pesos.Add(azar.NextDouble());
               
            }
            umbral = azar.NextDouble();
        }

        //Calcula la salida de la neurona dependiendo de las entradas
        public double CalculaSalida(List<double> entradas)
        {
            double valor = 0;
            for (int cont = 0; cont < pesos.Count; cont++)
            {
                valor += entradas[cont] * pesos[cont];
            }
            valor += umbral;
            return 1 / (1 + Math.Exp(-valor)); //revisar esta funcion de activacion en la capa de salida
        }

        public List<double> GetPesos()
        {
            return pesos;
        }

        public double GetUmbral()
        {
            return umbral;
        }
    }
}
