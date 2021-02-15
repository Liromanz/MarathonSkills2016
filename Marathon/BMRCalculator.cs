using System;
using System.Windows.Forms;

namespace Marathon
{
    public partial class BMRCalculatorForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        bool maleFemale = true;
        public BMRCalculatorForm() //Инициализация формы
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        { 
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void backButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Назад", возвращение на экран с информацией
        {
            BMRCalculatorForm.ActiveForm.Hide();
            informationForm form = new informationForm();
            form.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Отмена", возвращение на экран с информацией
        {
            BMRCalculatorForm.ActiveForm.Hide();
            informationForm form = new informationForm();
            form.Show();
        }

        private void BMRCalculatorForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void countButton_Click(object sender, EventArgs e) //Подсчеты BMI и их отображение
        {
            try
            {
                double fat, result, age, height;

                height = Convert.ToInt32(heightTextBox.Text);
                fat = Convert.ToInt32(fatTextBox.Text);
                age = Convert.ToInt32(ageTextBox.Text);
                if (maleFemale)
                {
                    result = 66.0 + (13.7 * height) + (5.0 * fat) + (6.8 * age);
                }
                else
                {
                    result = 655 + (9.6 * height) + (1.8 * fat) + (4.7 * age);
                }

                bmrNumberLabel.Text = result.ToString();
                sitNumberLabel.Text = (result * 1.2).ToString();
                lowNumberLabel.Text = (result * 1.375).ToString();
                normalNumberLabel.Text = (result * 1.55).ToString();
                bigNumberLabel.Text = (result * 1.725).ToString();
                maxNumberLabel.Text = (result * 1.9).ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка в вводе");
            }
        }

        private void malePanel_Click(object sender, EventArgs e) //Выбор мужчины
        {
            malePanel.BorderStyle = BorderStyle.FixedSingle;
            femalePanel.BorderStyle = BorderStyle.None;
            maleFemale = true;
        }

        private void femalePanel_Click(object sender, EventArgs e) //Выбор женщины
        {
            femalePanel.BorderStyle = BorderStyle.FixedSingle;
            malePanel.BorderStyle = BorderStyle.None;
            maleFemale = false;
        }

        private void infoPictureBox_Click(object sender, EventArgs e) //Открытие окошка с информацией 
        {
            activityLevelForm form = new activityLevelForm();
            form.ShowDialog();
        }
    }
}
