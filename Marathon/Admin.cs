using System;
using System.Windows.Forms;

namespace Marathon
{
    public partial class adminForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public adminForm() //Инициализация формы
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
            adminForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Logout", переход на главный экран
        {
            adminForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void adminForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void inventoryButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Инвентарь", переход на экран инвентаря
        {
            adminForm.ActiveForm.Hide();
            inventoryForm form = new inventoryForm();
            form.Show();
        }

        private void volunterButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Волонтеры", переход на экран управления волонтерами
        {
            adminForm.ActiveForm.Hide();
            volunterManagerForm form = new volunterManagerForm();
            form.Show();

        }

        private void charityButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Благотворительные организации", переход на экран с организациями
        {
            adminForm.ActiveForm.Hide();
            foundationManagerForm form = new foundationManagerForm();
            form.Show();
        }

        private void usersButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Пользователи", переход на экран управления пользователями
        {
            adminForm.ActiveForm.Hide();
            usersManagerForm form = new usersManagerForm();
            form.Show();
        }
    }
}
