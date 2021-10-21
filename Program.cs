using PerceptronMulticapa.MLP;
using System;
using System.Collections.Generic;

namespace PerceptronMulticapa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Random azar = new Random();
            Perceptron perceptron = new Perceptron();

            List<double> valoresEntrada= new List<double>();

            List<int> nNeuronasPorCapa = new List<int>
            {
                3,
                7,
                6,
                9
            };

            for (int i =0; i < nNeuronasPorCapa[0]; ++i)
            {
                valoresEntrada.Add(azar.NextDouble());
            }
            perceptron.CreaCapas(azar, nNeuronasPorCapa);
            perceptron.CalculaSalida(valoresEntrada);

        }
    }
}
