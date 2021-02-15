using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Marathon
{
    public partial class raceResultForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        string connection = @"Data Source=desktop-ua4mnst\bubochka;Initial Catalog=MarathonSkills2016;User ID=sa;Password=1056vQOAKZMtalvgty";

        int minAge, maxAge = 0;
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        DataTable table;
        public raceResultForm() //Инициализируем форму
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void backButton_Click(object sender, EventArgs e) // Нажатие на кнопку "Назад", переход на экран бегуна
        {
            raceResultForm.ActiveForm.Hide();
            runnerForm form = new runnerForm();
            form.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)// Нажатие на кнопку "Logout", переход на главный экран
        {
            raceResultForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void showButton_Click(object sender, EventArgs e) // Нажатие на кнопку "Показать все результаты", переход на экран со всеми результатами
        {
            raceResultForm.ActiveForm.Hide();
            raceAllForm form = new raceAllForm();
            form.Show();
        }

        private void raceResultForm_Load(object sender, EventArgs e) //Загрузка резульаттов одного бегуна и выгрузка его в dataGrid
        {
            try
            {
                takeAgesAndGender();
                connectionSql.Open();

                string query = "SELECT [RegistrationId], [MarathonName] as 'Марафон', [EventTypeName] as 'Дистанция', CONVERT(nvarchar, CONVERT(datetime, [RaceTime]/100000.0), 8)  AS 'Время', " +
                    "(select[PlaceId] from[Place]([MarathonName], [EventTypeName]) where[RegId] = [RegistrationId]) as 'Общее место'," +
                    $"(select[PlaceId] from[PlaceYear]([MarathonName], [EventTypeName], {minAge}, {maxAge}) where[RegId] = [RegistrationId]) as 'Место по категории'" +
                    "FROM[RegistrationEvent] " +
                    "inner join[Event] on[RegistrationEvent].[EventId] = [Event].[EventId] " +
                    "inner join[Marathon] on Event.[MarathonId] = [Marathon].[MarathonId] " +
                    "inner join[EventType] on Event.EventTypeId = EventType.EventTypeId " +
                    "where[RegistrationId] = (select RegistrationId from Registration where RunnerId = " +
                    $"(select RunnerId from Runner where Email = '{authorizationForm.email}'))";

                dataAdapter = new SqlDataAdapter(query, connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                table = dataSet.Tables[0];

                resultDataGrid.DataSource = table;
                resultDataGrid.Columns[0].Visible = false;
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
        private void takeAgesAndGender()//Выставляем диапазон возраста в зависимости от возраста нашего пользователя
        {
            try
            {
                connectionSql.Open();

                dataAdapter = new SqlDataAdapter($"select YEAR(GETDATE())-YEAR([DateOfBirth]), [Gender] from [Runner] where  Email = '{authorizationForm.email}'", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                int age = (int)dataSet.Tables[0].Rows[0][0];
                sexLoadLabel.Text = (string)dataSet.Tables[0].Rows[0][1];

                if (age<18)
                {
                    minAge = 0;
                    maxAge = 17;
                }
                if (age>=18 && age<=29)
                {
                    minAge = 18;
                    maxAge = 29;
                }
                if (age>=30 && age<=39)
                {
                    minAge = 30;
                    maxAge = 39;
                }
                if (age >= 40 && age <= 55)
                {
                    minAge = 40;
                    maxAge = 55;
                }
                if (age >= 56 && age <= 70)
                {
                    minAge = 56;
                    maxAge = 70;
                }
                if (age > 70)
                {
                    minAge = 71;
                    maxAge = 120;
                }
                ageLoadLabel.Text = $"{minAge}-{maxAge}";
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

        private void raceResultForm_FormClosing(object sender, FormClosingEventArgs e) //Закрываем приложение при закрытии формы
        {
            Application.Exit();
        }
    }
}
