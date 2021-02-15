using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Marathon
{
    public partial class eventRegistrationForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        int amount = 0;
        int amountKit = 0;
        char raceKit = 'A';

        string connection = @"Data Source=desktop-ua4mnst\bubochka;Initial Catalog=MarathonSkills2016;User ID=sa;Password=1056vQOAKZMtalvgty";

        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        SqlCommand command;
        DataTable table;
        public eventRegistrationForm() //Инициализация формы
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
            foundationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void backButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Назад", переход на экран бегуна
        {
            eventRegistrationForm.ActiveForm.Hide();
            runnerForm form = new runnerForm();
            form.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Logout", переход на главный экран
        {
            eventRegistrationForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void registerButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Регистрация", добавление информации о пользователе в базу данных в зависимости от поставленных флагов
        {
            if ((fullCheckBox.Checked || halfCheckBox.Checked || littleCheckBox.Checked) && Convert.ToInt32(moneyTextBox.Text) >= amount)
            {
                try
                {
                    connectionSql.Open();

                    command = new SqlCommand($"insert into [Registration] (RunnerId, RegistrationDateTime, RaceKitOptionId, RegistrationStatusId, Cost, CharityId, SponsorshipTarget) values ((select [RunnerId] from [Runner] where [Email] = '{authorizationForm.email}'), GETDATE(), '{raceKit}', 1, {amountKit}, {foundationComboBox.SelectedValue}, {moneyTextBox.Text})", connectionSql);
                    command.ExecuteNonQuery();
                    Random random = new Random();
                    if (fullCheckBox.Checked)
                    {
                        command = new SqlCommand($"insert into RegistrationEvent (RegistrationId, EventId, BibNumber) values ((select RegistrationId from Registration where [RunnerId] = (select [RunnerId] from [Runner] where [Email] = '{authorizationForm.email}')),'{eventSelect("FM")}',{random.Next(1727)})", connectionSql);
                        command.ExecuteNonQuery();
                    }
                    if (halfCheckBox.Checked)
                    {
                        command = new SqlCommand($"insert into RegistrationEvent (RegistrationId, EventId, BibNumber) values ((select RegistrationId from Registration where [RunnerId] = (select [RunnerId] from [Runner] where [Email] = '{authorizationForm.email}')),'{eventSelect("HM")}',{random.Next(1727)})", connectionSql);
                        command.ExecuteNonQuery();

                    }
                    if (littleCheckBox.Checked)
                    {
                        command = new SqlCommand($"insert into RegistrationEvent (RegistrationId, EventId, BibNumber) values ((select RegistrationId from Registration where [RunnerId] = (select [RunnerId] from [Runner] where [Email] = '{authorizationForm.email}')),'{eventSelect("FR")}',{random.Next(1727)})", connectionSql);
                        command.ExecuteNonQuery();
                    }

                    eventRegistrationForm.ActiveForm.Hide();
                    confirmRegistrationForm form = new confirmRegistrationForm();
                    form.Show();
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
            else
            {
                MessageBox.Show("Выберите вид марафона или проверьте сумму взноса");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Отмена", переход на экран бегуна
        {
            eventRegistrationForm.ActiveForm.Hide();
            runnerForm form = new runnerForm();
            form.Show();
        }

        private void infoPictureBox_Click(object sender, EventArgs e) //Нажатие на кнопку с иконкой I, открытие формы с информацией о спонсоре
        {
            sponsorInfoForm form = new sponsorInfoForm();
            try
            {
                form.nameLabel.Text = (string)table.Rows[(int)foundationComboBox.SelectedValue-1][1];
                form.descriptionLabel.Text = (string)table.Rows[(int)foundationComboBox.SelectedValue-1][2];
                form.foundationPictureBox.Image = Image.FromFile(@"D:\Загрузки\Задание\Ресурсы\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\" + table.Rows[(int)foundationComboBox.SelectedValue-1][3].ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            form.ShowDialog();
        }

        private void eventRegistrationForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void eventRegistrationForm_Load(object sender, EventArgs e) //Загрузка данных в списки при загрузке формы
        {
            try
            {
                connectionSql.Open();

                dataAdapter = new SqlDataAdapter("SELECT * from Charity", connectionSql);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                table = dataSet.Tables[0];

                foundationComboBox.DataSource = dataSet.Tables[0];
                foundationComboBox.DisplayMember = "CharityName";
                foundationComboBox.ValueMember = "CharityId";

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

        private string eventSelect(string marathonType) //Выбор марафона, к которому привяжется пользователь
        {
            try
            {
                dataAdapter = new SqlDataAdapter($"SELECT [EventId] FROM [MarathonSkills2016].[dbo].[Event] where EventTypeId = '{marathonType}'", connectionSql);
                DataSet dataSource = new DataSet();

                dataAdapter.Fill(dataSource);
                List<string> allEvents = new List<string>();
                for (int i = 0; i < dataSource.Tables[0].Rows.Count; i++)
                {
                    allEvents.Add((string)dataSource.Tables[0].Rows[i][0]);
                }
                Random random = new Random();
                return allEvents[random.Next(allEvents.Count - 1)];

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return "";
            }
        }

        private void fullCheckBox_CheckedChanged(object sender, EventArgs e) //Обработка нажатия на флаг с полным марафоном
        {
            if (fullCheckBox.Checked)
                amount += 145;
            else
                amount -= 145;
            moneyLabel.Text = (amount + amountKit).ToString() + '$';
        }

        private void halfCheckBox_CheckedChanged(object sender, EventArgs e) //Обработка нажатия на флаг с частичным марафоном
        {
            if (halfCheckBox.Checked)
                amount += 75;
            else
                amount -= 75;
            moneyLabel.Text = (amount + amountKit).ToString() + '$';
        }

        private void littleCheckBox_CheckedChanged(object sender, EventArgs e) //Обработка нажатия на флаг с 5 километровым марафоном
        {
            if (littleCheckBox.Checked)
                amount += 20;
            else
                amount -= 20;
            moneyLabel.Text = (amount + amountKit).ToString() + '$';
        }

        private void varARadioButton_CheckedChanged(object sender, EventArgs e) //Обработка нажатия на флаг с пакетом А
        {
            if (varARadioButton.Checked)
            {
                raceKit = 'A';
                amountKit = 0;
                moneyLabel.Text = (amount + amountKit).ToString() + '$';
            }
        }

        private void varBRadioButton_CheckedChanged(object sender, EventArgs e) //Обработка нажатия на флаг с пакетом В
        {
            if (varBRadioButton.Checked)
            {
                amountKit = 20;
                raceKit = 'B';
                moneyLabel.Text = (amount + amountKit).ToString() + '$';
            }
        }

        private void varCRadioButton_CheckedChanged(object sender, EventArgs e) //Обработка нажатия на флаг с пакетом С
        {
            if (varCRadioButton.Checked)
            {
                amountKit = 45;
                raceKit = 'C';
                moneyLabel.Text = (amount + amountKit).ToString() + '$';
            }
        }

        private void moneyTextBox_TextChanged(object sender, EventArgs e) //Защита от введение пустоты в текстовое поле с деньгами
        {
            if (moneyTextBox.Text == "")
                moneyTextBox.Text = "0";
        }
    }
}
