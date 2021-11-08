using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronMulticapa.MLP
{
    class Capa
    {
        List<Neurona> neuronas; //Las neuronas que tendrá la capa
        List<double> salidas; //Almacena las salidas de cada neurona
        int idCapa;

        /*totalNeuronas : corresponde a la cantidad de neuronas en la capa actual.
         totalEntradas : corresponde a la cantidad de entradas en la capa actual*/
        public Capa(Random azar, int totalNeuronas, int totalEntradas, int id)
        {
            neuronas = new List<Neurona>();
            salidas = new List<double>();
            idCapa = id;
            //Genera las neuronas e inicializa sus salidas
            for (int cont = 0; cont < totalNeuronas; cont++)
            {
                neuronas.Add(new Neurona(azar, totalEntradas));
                salidas.Add(0);
            }
        }

        public void CalculaCapa(List<double> entradas, int cuantasCapas)
        {
            if(idCapa == cuantasCapas-1)
            {
                Console.WriteLine("Softmax");
                //SoftMax(entradas);
            }
            else
            {
                Console.WriteLine("tanh");
                for (int cont = 0; cont < neuronas.Count; cont++)
                {
                    salidas[cont] = ActivacionTanh(neuronas[cont].CalculaPreActivacion(entradas));
                }

            }  
        }

        //softmax con un detalle minimo no revisado aun a fecha 8/11/2021
        private void SoftMax(List<double> entradas)
        {
            double suma = 0;
            for (int j =0; j < entradas.Count;j++) 
            {
                suma +=Math.Exp(entradas[j]);
            }
          
          
            for(int i=0; i < entradas.Count; i++)
            {
                salidas[i]=Math.Exp(entradas[i]) / suma;
            }
           
        }

        private double ActivacionTanh(double valor)
        {
            return Math.Tanh(valor);
        }

        public List <double> GetSalida()
        {
            return salidas;
        }

        public List<Neurona> GetNeuronas()
        {
            return neuronas;
        }
    }
}
