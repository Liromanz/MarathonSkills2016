using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon
{
    public partial class foundationEditForm : Form
    {
        string connection = @"Data Source=desktop-ua4mnst\bubochka;Initial Catalog=MarathonSkills2016;User ID=sa;Password=1056vQOAKZMtalvgty";

        SqlConnection connectionSql;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        string imageLocation = "";
        string imageName = "";
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public foundationEditForm() //Инициализация формы
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }
        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void backButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Назад", возвращене на экран управление организациями
        {
            foundationEditForm.ActiveForm.Hide();
            foundationManagerForm form = new foundationManagerForm();
            form.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Logout", переход на главный экран
        {
            foundationEditForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Отмена", переход на экран управления организациями
        {
            foundationEditForm.ActiveForm.Hide();
            foundationManagerForm form = new foundationManagerForm();
            form.Show();
        }


        private void saveButton_Click(object sender, EventArgs e) //Сохранение или редактирование всех введенных данны
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter($"SELECT * from Charity where CharityName = '{nameTextBox.Text}' ", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    command = new SqlCommand($"insert into Charity(CharityName,  CharityDescription, CharityLogo) values ('{nameTextBox.Text}','{descriptionTextBox.Text}','{imageName}')", connectionSql);
                    command.ExecuteNonQuery();
                }
                else
                {
                    if (imageName == "")
                    {
                        FileInfo fileInfo = new FileInfo(photoTextBox.Text);
                        imageName = fileInfo.Name; 
                    }
                    command = new SqlCommand($"update Charity set CharityName = '{nameTextBox.Text}', CharityDescription = '{descriptionTextBox.Text}', CharityLogo = '{imageName}' where CharityId = {Convert.ToInt32(dataSet.Tables[0].Rows[0][0])} ", connectionSql);
                    command.ExecuteNonQuery();
                }
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
        public void loadChairity() //Загрузка организаций
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT * from Charity", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

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

        private void photoButton_Click(object sender, EventArgs e) //Открытие диалогового окна для выбора картинки
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Файлы JPG (*.jpg)|*.jpg|Файлы PNG (*.png)|*.png|Все файлы (*.*)|*.*";
                dialog.Title = "Выбрать фотографию";
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    imageLocation = dialog.FileName.ToString();
                    logoPictureBox.ImageLocation = imageLocation;
                    photoTextBox.Text = dialog.FileName;
                    FileInfo fileInfo = new FileInfo(imageLocation);
                    imageName = fileInfo.Name;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void foundationEditForm_Load(object sender, EventArgs e) //Загрузка всех методов при загрузке формы
        {
            loadChairity();
        }

        private void foundationEditForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }
    }
}



