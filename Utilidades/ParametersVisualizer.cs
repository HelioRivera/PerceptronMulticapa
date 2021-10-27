using PerceptronMulticapa.MLP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronMulticapa.Utilidades
{
    static class ParametersVisualizer
    {
        public static void ShowAllParameters(int[] neuronasPorCapa,Perceptron perceptron)
        {
            Console.WriteLine("____________PARAMETROS PERCEPTRON MULTICAPA_________________ \n");

            Console.WriteLine("tamaño del imput :" + perceptron.GetTamanoEntrada());

            Console.WriteLine("_____________________________________________________________");

            Console.WriteLine("cantidad de capas :" + perceptron.GetCantidadCapas());

            Console.WriteLine("_____________________________________________________________");

            Console.WriteLine("cantidad de neuronas por cada capa:");

            int contador = 0;

            foreach (int x in neuronasPorCapa)
            {
                Console.WriteLine("capa "+ contador+": " + x + " neuronas.");
                ++contador;
            }

            Console.WriteLine("_____________________________________________________________");

            MostrarSalidasPorCapa(perceptron);

            Console.WriteLine("_____________________________________________________________");

            MostrarPesosPorCapa(perceptron);

            Console.WriteLine("_____________________________________________________________");

            //Console.WriteLine("funcion de activacion por cada capa : ");

        }

        public static void MostrarSalidasPorCapa(Perceptron perceptron)
        {
            int cantidadCapas = perceptron.GetCantidadCapas();

            List<Capa> capas = perceptron.getCapas();

            for (int i =0; i < cantidadCapas; ++i)
            {
                Console.WriteLine("Salida capa " + i + " :");

                List<double> list = capas[i].GetSalida();

                int contador = 0;
                foreach (double valorsalida in list)
                {
                    Console.Write("neurona " + contador + ": ");
                    Console.WriteLine("{0:F4};", valorsalida);
                    ++contador;
                }
            }
        }

        public static void MostrarPesosPorCapa(Perceptron perceptron)
        {
            int cantidadCapas = perceptron.GetCantidadCapas();

            List<Capa> capas = perceptron.getCapas();

            for (int i = 0; i < cantidadCapas; ++i)
            {
                Console.WriteLine("Pesos en la capa " + i + " :");

                List<Neurona> neuronas = capas[i].GetNeuronas();

                int contador = 0;

                foreach (Neurona neurona in neuronas)
                {
                    
                    List<double> pesos = neurona.GetPesos();

                    Console.Write("neurona "+ contador + ": ");
                    foreach (double peso in pesos)
                    {
                        
                        Console.Write("{0:F4}; ", peso);
                        
                    }
                    Console.Write( "umbral : {0:F4};", neurona.GetUmbral());
                    Console.WriteLine("");
                    ++contador;
                }
            }

        }

       
    }
}
