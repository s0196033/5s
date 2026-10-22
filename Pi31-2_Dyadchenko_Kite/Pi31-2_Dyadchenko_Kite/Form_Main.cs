using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pi31_2_Dyadchenko_Kite
{
    public partial class Form_Main : Form
    {
        private double[] inputPixels; // массив входных данных

        public Form_Main()
        {
            InitializeComponent();
            inputPixels = new double[15]; // инициализация массива
        }

        // изменение цвета кнопок
        private void ChangeColorButton(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.White)
            {
                ((Button)sender).BackColor = Color.Black; // меняем цвет кнопки
                inputPixels[((Button)sender).TabIndex] = 1d; // меняем значение в массиве
            }
            else
            {
                ((Button)sender).BackColor = Color.White;
                inputPixels[((Button)sender).TabIndex] = 0d;
            }
        }

        // сохранить в файл обучающий пример
        private void buttonSaveTrainSample_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "train.txt";
            string tmpStr = numericUpDown_NecessaryOutput.Value.ToString();

            for (int i = 0; i < inputPixels.Length; i++)
            {
                tmpStr += " " + inputPixels[i].ToString();
            }
            tmpStr +=  "\n";

            File.AppendAllText(path, tmpStr);

        }
        // сохранить в файл тестовый пример
        private void buttonSaveTestSample_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "test.txt";
            string tmpStr = numericUpDown_NecessaryOutput.Value.ToString();

            for (int i = 0; i < inputPixels.Length; i++)
            {
                tmpStr += " " + inputPixels[i].ToString();
            }
            tmpStr +=  "\n";

            File.AppendAllText(path, tmpStr); // добавление текста tmpStr в файл по пути path
        }
    }
}
