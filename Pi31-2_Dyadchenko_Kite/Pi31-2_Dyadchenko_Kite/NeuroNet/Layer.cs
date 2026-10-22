using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Pi31_2_Dyadchenko_Kite.NeuroNet
{
    abstract class Layer
    {
        // Поле
        protected string name_Layer;
        string pathDirWeights;
        string pathFileWeights; // путь к файлу синаптических весов для нейронов
        protected int numofneurons; // число нейронов текущего слоя
        protected int numofprevneurons; // число нейронов предудущего слоя
        protected const double learningrate = 0.05d; // скорость обучения
        protected const double momentum = 0.050d; // момент итерации
        protected double[,] lastdeltaweights; // веса предыдущей итерации
        protected Neuron[] neurons; // массив нейронов текущего слоя

        // свойства
        public double[] Data // передача входных данных на нейроны слоя и активация нейронов
        {
            set
            {
                for (int i = 0; i < numofneurons; i++)
                {
                    neurons[i].Activator(value);
                }
            }
        }

        // конструктор
        protected Layer(int non, int nopn, NeuronType nt, string nm_Layer)
        {
            numofneurons = non;
            numofprevneurons = nopn;
            neurons = new Neuron[non];
            name_Layer = nm_Layer;
            pathDirWeights = AppDomain.CurrentDomain.BaseDirectory + "memory\\";
            pathFileWeights = pathDirWeights + name_Layer + "_memory.csv";

            lastdeltaweights = new double[non, nopn + 1];
            double[,] Weights;

            if (File.Exists(pathFileWeights))
                Weights = WeightInitialize(MemoryMode.GET, pathFileWeights);
            else
            {
                Directory.CreateDirectory(pathFileWeights);
                Weights = WeightInitialize(MemoryMode.INIT, pathFileWeights);
            }
            for (int i = 0; i < non; i++)
            {
                double[] tmp_weight = new double[nopn + 1];
                for (int j = 0; j < nopn +1; j++)
                {
                    tmp_weight[j]= Weights[i, j];
                }
                neurons[i] = new Neuron(tmp_weight, nt);
            }
        }

        public double[,] WeightInitialize(MemoryMode mm, string path)
        {
            char[] delim = new char[] { ';', ' ', '_' }; // разделитель слов
            string tmpStr; // Временная строка для чтения
            string[] tmpStrWeights; // Временный массив сторок
            double[,] weight = new double[numofneurons, numofprevneurons+1]; //

            switch (mm)
            {
                case MemoryMode.GET:
                    tmpStrWeights = File.ReadAllLines(path); // считывание строк текстового файла
                    string[] memory_elemmt;
                    for (int i = 0; i < numofneurons; i++)
                    {
                        memory_elemmt = tmpStrWeights[i].Split(delim); // разбивание строк на подстроки
                        for (int j = 0; j < numofprevneurons +1; j++)
                        {
                            weight[i, j]= double.Parse(memory_elemmt[j].Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);
                            // преобразование ...
                        }
                    }
                    break;

                case MemoryMode.SET:
                    tmpStrWeights = new string[numofneurons];
                    if (!File.Exists(path)) // если нет файла синаптических весов
                    {
                        MessageBox.Show("!!! ВНИМАНИЕ !!!\nФайл " + name_Layer +
                            "_memory.csv"+"\nНЕ НАЙДЕН !!!\nПосле нажатия кнопки ОК создасться отсутсвующий файл, и все значения будут сохранены", "Внимание",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    for (int i = 0; i < numofneurons; i++)
                    {
                        tmpStr = neurons[i].Weights[0].ToString();
                        for (int j = 0; j< numofprevneurons+1; j++)
                        {
                            tmpStr += delim[0] + neurons[i].Weights[j].ToString();

                        }
                        tmpStrWeights[i]=tmpStr;

                    }
                    File.WriteAllLines(path, tmpStrWeights);
                    break;
                case MemoryMode.INIT:
                    MessageBox.Show("!!! ВНИМАНИЕ !!!\nФайл " + name_Layer + "_memory.csv" +
                        "\nсинаптических весов\nНЕ НАЙДЕН !!!\nПосле нажатия кнопки ОК автоматически проинициализируются веса и создасться отсутсвующий файл, "
                            + "нейросеть вернётся к исходному состоянию <<новорождённости>>, и потребуется обучать ёё ЗАНОВО", "Внимание",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    Random random = new Random(); //Генератор случайных чисел

                    //Инициализация исходных значений синаптических весов нейронного слоя
                    double tmpRatio; //коэффициент
                    double tmpShift; //смещение
                    double[] tmpArr = new double[numofprevneurons +1]; //массив весов одного нейрона
                    tmpStrWeights = new string[numofneurons]; // масси строк синаптических весов

                    // расчёт коэффициента и смещения для генерации равномерного распределения
                    tmpRatio = 1.0d/ Math.Sqrt(Convert.ToDouble(numofprevneurons+1));
                    tmpShift = -tmpRatio;

                    for (int i = 0; i < numofneurons; i++)
                    {
                        for (int j = 0; j< numofprevneurons +1; j++)
                        {
                            tmpArr[j]= (random.NextDouble()*2*tmpRatio) - tmpRatio; // равномерное распределение в диапазоне [-tmpRatio; tmpRatio]
                        }
                        // формирование строки
                        tmpStr = tmpArr[0].ToString(System.Globalization.CultureInfo.InvariantCulture);
                        for (int j = 1; j< numofprevneurons +1; j++)
                        {
                            tmpStr += delim[0] + tmpArr[j].ToString(System.Globalization.CultureInfo.InvariantCulture);
                        }
                        tmpStrWeights[i] = tmpStr;
                    }
                    File.WriteAllLines(path, tmpStrWeights); // запись сформированных весов в файл
                    break;
                default:
                    break;
            }
            return weight;
        }
        abstract public void Recognize(Network net, Layer nextLayer); // для прямых проходов
        abstract public double[] BackwardPass(double[] stuff); // и обратных
        /*class HiddenLayer : Layer
        {
            
        }*/

    }
}
