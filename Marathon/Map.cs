using System;
using System.Windows.Forms;

namespace Marathon
{
    public partial class mapForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public mapForm() //Инициализация метода
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу формы
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void exitPictureBox_Click(object sender, EventArgs e)//Скрываем окошко с информацией
        {
            infoPanel.Hide();
        }

        private void showInfo(string name, string description1, string description2, string description3) //Передача данных в окошко с информацией
        {
            infoPanel.Show();
            markNameLabel.Text = name;
            description1Label.Text = description1;
            description2Label.Text = description2;
            description3Label.Text = description3;
        }

        private void startPictureBox_Click(object sender, EventArgs e) //Иконка старта
        {
            showInfo("Старт", "Начать марафон", "Места болельщиков", "Получение призов");
        }

        private void infoPictureBox_Click(object sender, EventArgs e) //Иконка инфо
        {
            showInfo("Стойка информации", "Получить информацию", "Купить предметы", "Зарегистрироваться");

        }

        private void healthPictureBox_Click(object sender, EventArgs e) //Иконка здоровья
        {
            showInfo("Медпункт", "Получить первую помощь", "Завершить досрочно", "Взять воды");
        }

        private void drinkBottomPictureBox_Click(object sender, EventArgs e) //Нижняя иконка питья
        {
            showInfo("Стенд питья", "Взять воды", "Места болельщиков", "Место отдыха");

        }

        private void toiletPictureBox_Click(object sender, EventArgs e) //Иконка туалет
        {
            showInfo("Туалет", "Место отдыха", "Медпункт", "Взять воды");
        }

        private void energyPictureBox_Click(object sender, EventArgs e) //Иконка энергии
        {
            showInfo("Энергетические батончики", "Бесплатные батончики", "Места болельщиков", "Купить предметы");

        }

        private void drinkUpPictureBox_Click(object sender, EventArgs e) //Верхняя иконка питья
        {
            showInfo("Стенд питья", "Взять воды", "Туалет", "Место отдыха");
        }

        private void backButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Назад", переход на информацию о марафоне
        {
            mapForm.ActiveForm.Hide();
            aboutForm form = new aboutForm();
            form.Show();
        }

        private void mapForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие программы при закрытии формы
        {
            Application.Exit();
        }
    }
}
