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

        public Neurona(Random azar, int totalEntradas)
        {
            pesos = new List<double>();
            for (int cont = 0; cont < totalEntradas; cont++)
            {
                pesos.Add(azar.NextDouble());
               
            }
            umbral = azar.NextDouble();
        }

      
        public double CalculaPreActivacion(List<double> entradas)
        {
            double valor = 0;
            for (int cont = 0; cont < pesos.Count; cont++)
            {
                valor += entradas[cont] * pesos[cont];
            }
            valor += umbral;

            return valor;
           
        }

        public List<double> GetPesos()
        {
            return pesos;
        }

        public double GetUmbral()
        {
            return umbral;
        }

       /*private double Tanh(double valor)
        {
            return Math.Tanh(valor);
        }

        private double Sigmoide(double valor)
        {
            return 1 / (1 + Math.Exp(-valor));
        }*/

    }
}
