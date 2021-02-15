using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Marathon
{
    public partial class volunterManagerForm : Form
    {
        string connection = @"Data Source=desktop-ua4mnst\bubochka;Initial Catalog=MarathonSkills2016;User ID=sa;Password=1056vQOAKZMtalvgty";
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public volunterManagerForm() //Инициализация формы
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }
        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }
        public void loadVolunters() //Выгрузка из бд всех волонтеров
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.Volunteer.VolunteerId, dbo.Country.CountryCode, dbo.Volunteer.LastName AS Фамилия, dbo.Volunteer.FirstName AS Имя, dbo.Country.CountryName AS Страна, dbo.Gender.Gender AS Пол FROM    dbo.Country INNER JOIN dbo.Volunteer ON dbo.Country.CountryCode = dbo.Volunteer.CountryCode INNER JOIN dbo.Gender ON dbo.Volunteer.Gender = dbo.Gender.Gender", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                volunterDataGrid.DataSource = dataSet.Tables[0];
                volunterDataGrid.Columns[0].Visible = false;
                volunterDataGrid.Columns[1].Visible = false;
                volunterNumberLabel.Text = dataSet.Tables[0].Rows.Count.ToString();

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

        private void volunterManagerForm_Load(object sender, EventArgs e) //Загрузка всех методов при загрузке формы
        {
            loadVolunters();
        }

        private void backButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Назад", переход на экран андмина
        {
            volunterManagerForm.ActiveForm.Hide();
            adminForm form = new adminForm();
            form.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)//Нажатие на кнопку "Logout", переход на главный экран
        {
            volunterManagerForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void loadButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Загрузка волонтеров", переход на экран загрузки волонтеров
        {
            volunterManagerForm.ActiveForm.Hide();
            volunterDownloadForm form = new volunterDownloadForm();
            form.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Обновить"
        {

        }

        private void volunterManagerForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }
    }
}
