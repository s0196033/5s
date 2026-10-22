using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pi31_2_Dyadchenko_Kite.NeuroNet
{
    internal class Network
    {
        /* // Слои
         private HiddenLayer hiddenLayer1; // 70 нейронов
         private HiddenLayer hiddenLayer2; // 35 нейронов
         private OutputLayer outputLayer;  // 10 нейронов

         public Network()
         {
             // 15 входов - 70 - 35 - 10 выходов
             hiddenLayer1 = new HiddenLayer(70, 15);
             hiddenLayer2 = new HiddenLayer(35, 70);
             outputLayer = new OutputLayer(10, 35);
         }

         public double[] FeedForward(double[] inputs)
         {
             // 1. Входной слой
             double[] signals = inputLayer.FeedForward(inputs);

             // 2. Первый скрытый слой
             signals = hiddenLayer1.FeedForward(signals);

             // 3. Второй скрытый слой
             signals = hiddenLayer2.FeedForward(signals);

             // 4. Выходной слой
             signals = outputLayer.FeedForward(signals);

             return signals;
         }*/
    }
}
