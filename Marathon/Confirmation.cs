using System;
using System.Windows.Forms;

namespace Marathon
{
    public partial class confirmationForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public confirmationForm() //Инициализация формы
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)//Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void confirmationForm_FormClosing(object sender, FormClosingEventArgs e) //Закрыть приложение при закрытии формы
        {
            Application.Exit();
        }

        private void backScreenButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Назад", переход на главное меню
        {
            confirmationForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void backButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Назад", переход на главное меню
        {
            confirmationForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }
    }
}
