using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Marathon
{
    public partial class runnerManagementForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        string connection = @"Data Source=desktop-ua4mnst\bubochka;Initial Catalog=MarathonSkills2016;User ID=sa;Password=1056vQOAKZMtalvgty";

        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;

        DataRow row;
        public runnerManagementForm() //Инициализация формы
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void runnerManagementForm_Load(object sender, EventArgs e) //Загрузка пользователя по его e-mail
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.[User].FirstName, dbo.[User].LastName, dbo.Runner.Gender,FORMAT([DateOfBirth], '%d.%M.%y') as 'DateOfBirth', " +
                    "dbo.Country.CountryName, dbo.Charity.CharityName, (select SUM(Amount) " +
                    "from Sponsorship where RegistrationId = [Registration].[RegistrationId]) as 'Amount',dbo.Registration.RaceKitOptionId, [RegistrationStatusId], [Image] " +
                    "FROM dbo.Registration INNER JOIN dbo.Charity ON dbo.Registration.CharityId = dbo.Charity.CharityId " +
                    "INNER JOIN dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId " +
                    "INNER JOIN dbo.[User] ON dbo.Runner.Email = dbo.[User].Email " +
                    $"INNER JOIN dbo.Country ON dbo.Runner.CountryCode = dbo.Country.CountryCode where [Runner].Email = '{emailUserLabel.Text}'", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                row = dataSet.Tables[0].Rows[0];

                nameUserLabel.Text = row[0].ToString();
                lastNameUserLabel.Text = row[1].ToString();
                genderUserLabel.Text = row[2].ToString();
                dateUserLabel.Text = row[3].ToString();
                countryUserLabel.Text = row[4].ToString();
                orgUserLabel.Text = row[5].ToString();
                moneyUserLabel.Text = "$" + row[6].ToString();
                packageUserLabel.Text = row[7].ToString();
                setPictures(Convert.ToInt32(row[8]));

                if (!((byte[])row[9]).All(c => c == 0))
                {
                    MemoryStream memoryStream = new MemoryStream((byte[])row[9]);
                    userPictureBox.Image = Image.FromStream(memoryStream);
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

        private void setPictures(int index) //Устанавливаем картинку галочки на пунктах регистрации
        {
            PictureBox[] pictureBoxes = new PictureBox[] { regPictureBox, payPictureBox, packagePictureBox, startPictureBox };
            for (int i = 0; i < index; i++)
            {
                pictureBoxes[i].Image = Bitmap.FromFile(@"D:\Загрузки\Задание\Ресурсы\WSR2016_TP09_ресурсы_сессия_5\marathon-skills-2016-status-icons\tick-icon.png"); //иконка галочки из 5 сессии
            }
        }

        private void backButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Назад", возвращение на управление бегунами
        {
            runnerManagementForm.ActiveForm.Hide();
            runnerManagerForm form = new runnerManagerForm();
            form.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e) //Возвращение на главное меню через "Logout"
        {
            runnerManagementForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void certificateButton_Click(object sender, EventArgs e) //Переход на форму создания сертификата
        {
            runnerManagementForm.ActiveForm.Hide();
            certificateForm form = new certificateForm();
            form.emailInfo = emailUserLabel.Text;
            form.nameInfo = nameUserLabel.Text;
            form.lastNameInfo = lastNameUserLabel.Text;
            form.Show();
        }

        private void printButton_Click(object sender, EventArgs e) //Переход на форму создания сертификата
        {
            runnerManagementForm.ActiveForm.Hide();
            certificateForm form = new certificateForm();
            form.emailInfo = emailUserLabel.Text;
            form.nameInfo = nameUserLabel.Text;
            form.lastNameInfo = lastNameUserLabel.Text;
            form.Show();
        }

        private void editProfileButton_Click(object sender, EventArgs e) //Переход на форму изменения данных пользователя
        {
            runnerManagementForm.ActiveForm.Hide();
            runnerEditForm form = new runnerEditForm();
            form.emailUserLabel.Text = emailUserLabel.Text;
            form.Show();
        }

        private void runnerManagementForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие программы при закрытии формы
        {
            Application.Exit();
        }
    }
}
