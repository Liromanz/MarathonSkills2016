using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon
{
    public partial class informationForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public informationForm() //Инициализация формы
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void backButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Назад", переход на главный экран
        {
            informationForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void listButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Список благотворительных организаций", переход на форму с организациями
        {
            informationForm.ActiveForm.Hide();
            listOfCharitiesForm form = new listOfCharitiesForm();
            form.Show();
        }

        private void informationForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void marathonButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Marathon Skills 2021", переход на экран про марафон
        {
            informationForm.ActiveForm.Hide();
            aboutForm form = new aboutForm();
            form.Show();
        }

        private void durationButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Насколько долгий марафон", переход на главный экран
        {
            informationForm.ActiveForm.Hide();
            marathonDurationForm form = new marathonDurationForm();
            form.Show();
        }

        private void bmiButton_Click(object sender, EventArgs e) //Переход на bmi калькулятор
        {
            informationForm.ActiveForm.Hide();
            BMICalculatorForm form = new BMICalculatorForm();
            form.Show();
        }

        private void bmrButton_Click(object sender, EventArgs e) //Переход на bmr калькулятор
        {
            informationForm.ActiveForm.Hide();
            BMRCalculatorForm form = new BMRCalculatorForm();
            form.Show();
        }

        private void resultsButton_Click(object sender, EventArgs e) //Переход на предыдущие результаты марафонов
        {
            informationForm.ActiveForm.Hide();
            raceAllForm form = new raceAllForm();
            form.Show();
        }
    }
}
