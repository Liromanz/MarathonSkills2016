using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Marathon
{
    public partial class certificateForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        string connection = @"Data Source=desktop-ua4mnst\bubochka;Initial Catalog=MarathonSkills2016;User ID=sa;Password=1056vQOAKZMtalvgty";

        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;

        public string emailInfo, nameInfo, lastNameInfo;
        public certificateForm() //Инициализация формы
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void certificateForm_Load(object sender, EventArgs e) //Загрузка всей информации для отображения сертификата
        {
            loadRace();
        }
        private void loadRace() //Загрузка всех дистанций в список
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("select * from EventType", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                connectionSql.Close();


                raceComboBox.DataSource = dataSet.Tables[0];
                raceComboBox.DisplayMember = "EventTypeName";
                raceComboBox.ValueMember = "EventTypeId";
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void createCertificate() //Запрос для создания сертификата и выгрузка текста
        {
            try
            {
                notOkPanel.Visible = true;
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT [MarathonName] as 'Марафон', [CityName] +', '+ [CountryCode] as 'Place', [EventTypeName]," +
                    " CONVERT(nvarchar, CONVERT(datetime, [RaceTime]/100000.0), 8)  AS 'Время', " +
                    "(select[PlaceId] from[Place]([MarathonName], [EventTypeName]) where[RegId] = [RegistrationEvent].[RegistrationId]) as 'Общее место', [CharityLogo] ," +
                    " (select SUM(Amount) from Sponsorship where RegistrationId = [Registration].[RegistrationId]) as 'Amount' FROM[RegistrationEvent]" +
                    " inner join[Event] on[RegistrationEvent].[EventId] = [Event].[EventId] " +
                    "inner join[Marathon] on Event.[MarathonId] = [Marathon].[MarathonId] " +
                    "inner join[EventType] on Event.EventTypeId = EventType.EventTypeId " +
                    "inner join[Registration] on RegistrationEvent.RegistrationId = Registration.RegistrationId" +
                    " inner join Charity on Registration.CharityId = Charity.CharityId " +
                    " where[RegistrationEvent].[RegistrationId] = (select RegistrationId from Registration where RunnerId = " +
                    $"(select RunnerId from Runner where Email = '{emailInfo}')) and[EventTypeName] = '{raceComboBox.Text}'", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    DataRow dataRow = dataSet.Tables[0].Rows[0];
                    if (dataRow[3].ToString() != "" && dataRow[3].ToString() != "00:00:00")
                    {
                        notOkPanel.Visible = false;
                        congratulationsLabel.Text = $"Поздравляем {nameInfo} {lastNameInfo} с участием в {dataRow[2]}. Ваши результаты время {dataRow[3]} и занятое место - {dataRow[4]}-ое!";
                        marathonLabel.Text = dataRow[0].ToString();
                        cityLabel.Text = dataRow[1].ToString();
                        moneyLabel.Text = $"Вы также заработали ${dataRow[6]} для вашей благотворительной организации!";
                        logoPictureBox.Image = Bitmap.FromFile(@"D:\Загрузки\Задание\Ресурсы\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\" + dataRow[5].ToString());
                    }
                    else
                    {
                        errorLabel.Text = "Бегун не финишировал вовремя";
                    }
                }
                else
                {
                    errorLabel.Text = "Бегун не принимал участия в марафоне такого типа";
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

        private void backButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Отмена", переход на управление бегуном
        {
            certificateForm.ActiveForm.Hide();
            runnerManagerForm form = new runnerManagerForm();
            form.Show();
        }

        private void raceComboBox_SelectedIndexChanged(object sender, EventArgs e) //Создание сертификата при изменении пункта в списке дистанций
        {
            createCertificate();
        }

        private void logoutButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Logout", выход на главное меню
        {
            certificateForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void certificateForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }
    }
}
