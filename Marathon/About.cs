using System;
using System.Windows.Forms;

namespace Marathon
{
    public partial class aboutForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public aboutForm() //Инициализация формы
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера, который отображается внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void backButton_Click(object sender, EventArgs e) //Возвращение формы на экран информации
        {
            aboutForm.ActiveForm.Hide();
            informationForm form = new informationForm();
            form.Show();
        }

        private void aboutForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void mapPictureBox_Click(object sender, EventArgs e) //Нажатие на карту и переход к ее информации
        {
            aboutForm.ActiveForm.Hide();
            mapForm form = new mapForm();
            form.Show();
        }
    }
}
