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

            List<double> input = Configurador.InputDePrueba(400, azar);

            int[] nNeuronasPorCapa = {120,84,10};

            Perceptron perceptron = new Perceptron();

            perceptron.CreaCapas(azar, nNeuronasPorCapa, input.Count);

            perceptron.CalculaSalida(input, nNeuronasPorCapa.Length);

            //note to helio developer : this method should only have one parameter ; the perceptron
            ParametersVisualizer.TamanoImput(perceptron);
            ParametersVisualizer.CantidadCapas(perceptron);
            ParametersVisualizer.NeuronasPorCapa(nNeuronasPorCapa);


        }
    }
}
