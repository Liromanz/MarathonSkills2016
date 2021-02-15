using System;
using System.Windows.Forms;

namespace Marathon
{
    public partial class runnerForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public runnerForm() //Инициализируем форму
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void backButton_Click(object sender, EventArgs e) // Нажатие на кнопку "Назад", переход на гоавный экран
        {
            runnerForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e) // Нажатие на кнопку "Logout", переход на главный экран
        {
            runnerForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void runnerForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void profileButton_Click(object sender, EventArgs e) // Нажатие на кнопку "Редактирование профиля", переход на форму редактирования
        {
            runnerForm.ActiveForm.Hide();
            runnerProfileForm form = new runnerProfileForm();
            form.Show();
        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            runnerForm.ActiveForm.Hide();
            raceResultForm form = new raceResultForm();
            form.Show();
        }

        private void sponsorForm_Click(object sender, EventArgs e)
        {
            runnerForm.ActiveForm.Hide();
            sponsorshipForm form = new sponsorshipForm();
            form.Show();
        }

        private void contactsButton_Click(object sender, EventArgs e)
        {
            contactsForm form = new contactsForm();
            form.ShowDialog();
        }

        private void regMarathonButton_Click(object sender, EventArgs e)
        {
            runnerForm.ActiveForm.Hide();
            eventRegistrationForm form = new eventRegistrationForm();
            form.Show();
        }
    }
}
