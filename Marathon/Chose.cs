using System;
using System.Windows.Forms;

namespace Marathon
{
    public partial class choseForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public choseForm() //Инициализируем форму
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void backButton_Click(object sender, EventArgs e) // Нажатие на кнопку "Назад", возвращение на главный экран
        {
            choseForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void beforeButton_Click(object sender, EventArgs e) // Нажатие на кнопку "Я учавствовал ранее", переход на эран авторизации
        {
            choseForm.ActiveForm.Hide();
            authorizationForm form = new authorizationForm();
            form.Show();

        }

        private void newButton_Click(object sender, EventArgs e)// Нажатие на кнопку "Я новый участник", переход на экран регистрации бегуна
        {
            choseForm.ActiveForm.Hide();
            runnerRegistrationForm form = new runnerRegistrationForm();
            form.Show();
        }

        private void choseForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }
    }
}
