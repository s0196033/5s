using System.Web;

namespace lb1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent(); // создаёт и настраивает все элементы на форме
            cmbCar.SelectedIndex = 0; // =0 первый элемент выпадающего списка
            cmbTrack.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string driver = txtDriver.Text.Trim(); // Trim() удаляет пробелы в начале и в конце строки
            if (driver.Length == 0)
            {
                lblStatus.Text = "Введите имя пилота!";
                txtDriver.Focus();
                return;
            }
            if (cmbCar.SelectedIndex == -1) // =-1 не выбран элемент из выбранного списка
            {
                lblStatus.Text = "Введите автомобиль!";
                cmbCar.Focus();
                return;
            }

            if (cmbTrack.SelectedIndex == -1)
            {
                lblStatus.Text = "Введите трассу!";
                cmbTrack.Focus();
                return;
            }

            string timeString = txtTime.Text.Trim();
            if (!int.TryParse(timeString, out int time)) // int.TryParse() проверят является ли строка числом
            {
                lblStatus.Text = "Введите целое число!";
                txtTime.Focus();
                return;
            }
            if (time < 30 || time > 600)
            {
                lblStatus.Text = "Время должно быть от 30 до 600 секунд!";
                txtTime.Focus();
                return;
            }
            string result = $"{driver} | {cmbCar.Text} | {cmbTrack.Text} | {time} c";
            lstResults.Items.Add(result); //Items.Add() добавляет элемент в конец списка результатов

            lblStatus.Text = $"Добавлено. Всего записей:{lstResults.Items.Count}"; // Items.Count возвращает количество элементов

            ClearInput();
        }
        private void ClearInput()
        {
            txtDriver.Clear();
            txtTime.Clear();
            txtDriver.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstResults.SelectedIndex == -1)
            {
                lblStatus.Text = "Выберите запись для удаления!";
                return;
            }
            lstResults.Items.RemoveAt(lstResults.SelectedIndex);
            lblStatus.Text = $"Запись удалена. Осталось записей: {lstResults.Items.Count}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            lblStatus.Text = "Поля очищены";
        }

        /*
        private void ShowError(string message)
        {
            lblStatus.Text = message;
            lblStatus.ForeColor = Color.Red;
        }
        */
    }
}
