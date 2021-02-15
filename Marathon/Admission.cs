using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Marathon
{
    public partial class admissionForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        string connection = @"Data Source=desktop-ua4mnst\bubochka;Initial Catalog=MarathonSkills2016;User ID=sa;Password=1056vQOAKZMtalvgty";

        SqlConnection connectionSql;
        SqlCommand command;
        public admissionForm() //Инициализация формы
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void backButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Назад", переход на экран инвентаря
        {
            admissionForm.ActiveForm.Hide();
            inventoryForm form = new inventoryForm();
            form.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)//Нажатие на кнопку "Logout", переход на главный экран
        {
            admissionForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void admissionForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void saveButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Сохранить", обновление данных из базы данных
        {
            try
            {
                connectionSql.Open();
                if (int.TryParse(idTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(idTextBox.Text)} where InventoryId = 1", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(rfidTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(rfidTextBox.Text)} where InventoryId = 2", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(baseballTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(baseballTextBox.Text)} where InventoryId = 3", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(waterTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(waterTextBox.Text)} where InventoryId = 4", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(tshirtTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(tshirtTextBox.Text)} where InventoryId = 5", connectionSql);
                    command.ExecuteNonQuery();
                }
                if (int.TryParse(souvenirTextBox.Text, out _))
                {
                    command = new SqlCommand($"update [Inventory] set Amount = Amount + {Convert.ToInt32(souvenirTextBox.Text)} where InventoryId = 6", connectionSql);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Данные успешно обновлены!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connectionSql.Close();
            }
        }
    }
}
