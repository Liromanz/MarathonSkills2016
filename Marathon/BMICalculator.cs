using System;
using System.Drawing;
using System.Windows.Forms;

namespace Marathon
{
    public partial class BMICalculatorForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public BMICalculatorForm() //Инициализация формы
        {
            InitializeComponent();
        }


        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void backButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Назад", возвращение на окно с информацией
        {
            BMICalculatorForm.ActiveForm.Hide();
            informationForm form = new informationForm();
            form.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Отмена", возвращение на окно с информацией
        {
            BMICalculatorForm.ActiveForm.Hide();
            informationForm form = new informationForm();
            form.Show();
        }

        private void countButton_Click(object sender, EventArgs e) //Подсчеты индекса массы тела и выгрузка в интерфейс
        {
            try
            {
                double result;
                double height = Convert.ToInt32(heightTextBox.Text);
                double weight = Convert.ToInt32(fatTextBox.Text);
                result = weight / ((height / 100) * (height / 100));
                bmiNumberLabel.Text = result.ToString();
                if (result < 18)
                {
                    healthPictureBox.ImageLocation = $@"D:\Загрузки\Задание\Ресурсы\WSR2016_TP09_ресурсы_сессия_4\marathon-skills-2016-bmi-icons\bmi-underweight-icon.png";
                    cursorPanel.Location = new Point(464, 421);
                    healthLabel.Text = "Недостаточный";
                }
                else if (18 <= result && result < 25)
                {
                    healthPictureBox.ImageLocation = $@"D:\Загрузки\Задание\Ресурсы\WSR2016_TP09_ресурсы_сессия_4\marathon-skills-2016-bmi-icons\bmi-healthy-icon.png";
                    cursorPanel.Location = new Point(560, 421);
                    healthLabel.Text = "Здоровый";
                }
                else if (25 <= result && result < 30)
                {
                    healthPictureBox.ImageLocation = $@"D:\Загрузки\Задание\Ресурсы\WSR2016_TP09_ресурсы_сессия_4\marathon-skills-2016-bmi-icons\bmi-overweight-icon.png";
                    cursorPanel.Location = new Point(654, 421);
                    healthLabel.Text = "Избыточный";
                }
                else if (result >= 30)
                {
                    healthPictureBox.ImageLocation = $@"D:\Загрузки\Задание\Ресурсы\WSR2016_TP09_ресурсы_сессия_4\marathon-skills-2016-bmi-icons\bmi-obese-icon.png";
                    cursorPanel.Location = new Point(750, 421);
                    healthLabel.Text = "Ожирение";
                }
                else
                {
                    MessageBox.Show("Ошибка в подсчетах");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }
    }
}
