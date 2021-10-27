using PerceptronMulticapa.MLP;
using System;
using System.Collections.Generic;
using PerceptronMulticapa.Utilidades;

namespace PerceptronMulticapa
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Random azar = new Random();

            Perceptron perceptron = new Perceptron();

            List<double> input = Configurador.InputDePrueba(10, azar);

            int[] nNeuronasPorCapa = {3,4,5,6,7};
            
            perceptron.CreaCapas(azar, nNeuronasPorCapa, input.Count);

            perceptron.CalculaSalida(input);

            ParametersVisualizer.ShowAllParameters(nNeuronasPorCapa, perceptron);

        }
    }
}
