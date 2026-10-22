using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Pi31_2_Dyadchenko_Kite.NeuroNet
{
    class Neuron
    {
        //поля
        private NeuronType type; //тип нейрона
        private double[] weights; //его веса
        private double[] input; //его входы
        private double output; //его выходы
        private double derivative; //производная

        //константы
        private double a = 0.01d;

        //свойства
        public double[] Weights { get => weights; set => weights = value; }
        public double[] Inputs { get => input; set => input = value; }
        public double Output { get => output; }
        public double Derivative { get => derivative; }

        //конструктор
        public Neuron(double[] memoryWeights, NeuronType typeNeuron)
        {
            type = typeNeuron;
            weights = memoryWeights;
        }

        //
        public void Activator(double[] i)
        {
            input = i;
            double sum = weights[0];
            for (int j = 0; j<input.Length; j++)
            {
                sum+= weights[j]*weights[j+1];
            }

            switch (type)
            {
                case NeuronType.Hidden:
                    output = HyperTan(sum);
                    derivative = HyperTan_Derivative(sum);
                    break;
                case NeuronType.Output:
                    output = Exp(sum);
                    break;
            }
        }
        // функция активации
        private double HyperTan(double sum)
        {
            double ep = Exp(sum);
            double en = Exp(-sum);
            return (ep-en)/(ep+en);
        }
        // производная
        private double HyperTan_Derivative(double sum)
        {
            double ep = Exp(sum);
            double en = Exp(-sum);
            return 4/((ep-en)*(ep-en));
        }
    }
}
