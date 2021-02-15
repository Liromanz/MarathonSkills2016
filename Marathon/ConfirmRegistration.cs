using System;
using System.Windows.Forms;

namespace Marathon
{
    public partial class confirmRegistrationForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public confirmRegistrationForm() //Инициализация формы
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void backButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Назад", переход на экран бегуна
        {
            confirmRegistrationForm.ActiveForm.Hide();
            runnerForm form = new runnerForm();
            form.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Logout", переход на главное меню
        {
            confirmRegistrationForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void okButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Ок", переход на экран бегуна
        {
            confirmRegistrationForm.ActiveForm.Hide();
            runnerForm form = new runnerForm();
            form.Show();
        }

        private void confirmRegistrationForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии фрагмента
        {
            Application.Exit();
        }
    }
}
