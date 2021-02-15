using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Marathon
{
    public partial class runnerManagerForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        string connection = @"Data Source=desktop-ua4mnst\bubochka;Initial Catalog=MarathonSkills2016;User ID=sa;Password=1056vQOAKZMtalvgty";

        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;

        string email = "";

        public runnerManagerForm() //Инициализация формы
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }
        private void timer_Tick(object sender, EventArgs e) //Тикание часов внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }
        public void loadRunners() //Выгрузка всех нужных данных в dataGrid
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.[User].FirstName, dbo.[User].LastName, dbo.Runner.Email,  " +
                    "dbo.RegistrationStatus.RegistrationStatus FROM            " +
                    "dbo.Registration INNER JOIN dbo.RegistrationStatus ON dbo.Registration.RegistrationStatusId " +
                    "= dbo.RegistrationStatus.RegistrationStatusId " +
                    "INNER JOIN dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId " +
                    "INNER JOIN dbo.[User] ON dbo.Runner.Email = dbo.[User].Email", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                runnersDataGrid.DataSource = dataSet.Tables[0];
                totalNumberLabel.Text = dataSet.Tables[0].Rows.Count.ToString();

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

        public void loadStatus() //Загрузка статуса регистрации в список
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT * from RegistrationStatus", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                statusComboBox.DataSource = dataSet.Tables[0];
                statusComboBox.DisplayMember = "RegistrationStatus";
                statusComboBox.ValueMember = "RegistrationStatusId";

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
        public void loadDistances() //Загрузка всех дистанций в список
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT * from EventType", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                distanceComboBox.DataSource = dataSet.Tables[0];
                distanceComboBox.DisplayMember = "EventTypeName";
                distanceComboBox.ValueMember = "EventTypeId";
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

        private void runnerManagerForm_Load(object sender, EventArgs e) //Загрузка методов при загрузке формы
        {
            loadDistances();
            loadStatus();
            loadRunners();
        }

        private void refreshButton_Click(object sender, EventArgs e) //Обновление информации в отображении данных
        {
            try
            {
                DataRowView rowView = (DataRowView)statusComboBox.SelectedItem;
                string statusName = rowView[1].ToString();
                rowView = (DataRowView)distanceComboBox.SelectedItem;
                string eventName = rowView[1].ToString();
                connectionSql.Open();

                dataAdapter = new SqlDataAdapter($"SELECT dbo.[User].FirstName, dbo.[User].LastName, dbo.Runner.Email, dbo.RegistrationStatus.RegistrationStatus FROM dbo.Event INNER JOIN dbo.EventType ON dbo.Event.EventTypeId = dbo.EventType.EventTypeId " +
                    $" INNER JOIN dbo.RegistrationEvent ON dbo.Event.EventId = dbo.RegistrationEvent.EventId" +
                    $" INNER JOIN dbo.Registration ON dbo.RegistrationEvent.RegistrationId = dbo.Registration.RegistrationId " +
                    $"INNER JOIN dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN dbo.[User] " +
                    $"ON dbo.Runner.Email = dbo.[User].Email " +
                    $"INNER JOIN dbo.RegistrationStatus ON dbo.Registration.RegistrationStatusId = dbo.RegistrationStatus.RegistrationStatusId " +
                    $"WHERE (dbo.EventType.EventTypeName = '{eventName}') AND (dbo.RegistrationStatus.RegistrationStatus = '{statusName}')", connectionSql);

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                //работает через раз (в прямом смысле слова), исправить, как время будет
                runnersDataGrid.DataSource = dataSet.Tables[0];
                totalNumberLabel.Text = dataSet.Tables[0].Rows.Count.ToString();

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

        private void backButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Назад", возвращение на окно координатора
        {
            runnerManagerForm.ActiveForm.Hide();
            coordinatorForm form = new coordinatorForm();
            form.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Logout", выход в главное меню
        {
            runnerManagerForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void runnerManagerForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (email != "")
            {
                runnerManagerForm.ActiveForm.Hide();
                runnerManagementForm form = new runnerManagementForm();
                form.emailUserLabel.Text = email;
                form.Show();
            }
            else
            {
                MessageBox.Show("Не выбрано ни одного бегуна");
            }
        }

        private void csvButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = null;

                using (var dialog = new FolderBrowserDialog())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                        path = dialog.SelectedPath + @"\runner.csv";
                }

                connectionSql.Open();

                using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
                {

                    string columns = "FirstName,LastName,Email,Gender,CountryName,DateOfBirth,RegistrationStatus,RaceKitOption,EventTypeName";
                    byte[] arrayCollums = Encoding.Default.GetBytes(columns + "\n");
                    fileStream.Write(arrayCollums, 0, arrayCollums.Length);
                    for (int j = 0; j < runnersDataGrid.Rows.Count; j++)
                    {
                        dataAdapter = new SqlDataAdapter($"SELECT * FROM View_1 where FirstName = '{runnersDataGrid.Rows[j].Cells[0].Value}' and LastName = '{runnersDataGrid.Rows[j].Cells[1].Value}' and Email = '{runnersDataGrid.Rows[j].Cells[2].Value}' and RegistrationStatus = '{runnersDataGrid.Rows[j].Cells[3].Value}'", connection);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);
                        for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                        {
                            string Name = dataSet.Tables[0].Rows[i][0].ToString();
                            string LastName = dataSet.Tables[0].Rows[i][1].ToString();
                            string Email = dataSet.Tables[0].Rows[i][2].ToString();
                            string Gender = dataSet.Tables[0].Rows[i][3].ToString();
                            string CountryName = dataSet.Tables[0].Rows[i][4].ToString();
                            DateTime DateOfBirth = DateTime.Parse(dataSet.Tables[0].Rows[i][5].ToString());
                            TimeSpan span = DateTime.Now - DateOfBirth;
                            string Birth = DateOfBirth.ToString();
                            string Age = (span.Days / 365).ToString();
                            string RegistrationStatus = dataSet.Tables[0].Rows[i][6].ToString();
                            string Option = dataSet.Tables[0].Rows[i][7].ToString();
                            string Event = dataSet.Tables[0].Rows[i][8].ToString();
                            string All = Name + "," + LastName + "," + Email + "," + Gender + "," + CountryName + "," + Birth + "," + Age + "," + RegistrationStatus + "," + Option + "," + Event + "\n";
                            byte[] array = Encoding.Default.GetBytes(All);
                            fileStream.Write(array, 0, array.Length);
                        }
                    }
                    MessageBox.Show("Текст записан в файл");
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

        private void emailButton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = null;
                using (var dialog = new FolderBrowserDialog())
                    if (dialog.ShowDialog() == DialogResult.OK)
                        path = dialog.SelectedPath + @"\runner.txt";

                connectionSql.Open();

                using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
                {
                    for (int j = 0; j < runnersDataGrid.Rows.Count; j++)
                    {
                        dataAdapter = new SqlDataAdapter($"SELECT dbo.[User].FirstName, dbo.[User].LastName, dbo.[User].Email FROM  dbo.Runner INNER JOIN dbo.[User] ON dbo.Runner.Email = dbo.[User].Email AND dbo.Runner.Email = dbo.[User].Email INNER JOIN dbo.Registration ON dbo.Runner.RunnerId = dbo.Registration.RunnerId INNER JOIN dbo.RegistrationStatus ON dbo.RegistrationStatus.RegistrationStatusId = dbo.Registration.RegistrationStatusId where FirstName = '{runnersDataGrid.Rows[j].Cells[0].Value}' and LastName = '{runnersDataGrid.Rows[j].Cells[1].Value}' and [Runner].Email = '{runnersDataGrid.Rows[j].Cells[2].Value}' and RegistrationStatus = '{runnersDataGrid.Rows[j].Cells[3].Value}'", connection);
                        DataSet dataSet = new DataSet();
                        dataAdapter.Fill(dataSet);
                        for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                        {
                            string Name = dataSet.Tables[0].Rows[i][0].ToString();
                            string LastName = dataSet.Tables[0].Rows[i][1].ToString();
                            string Email = dataSet.Tables[0].Rows[i][2].ToString();
                            string All = '"' + LastName + " " + Name + '"' + "<" + Email + ">" + ";" + "\n";
                            byte[] array = Encoding.Default.GetBytes(All);
                            fileStream.Write(array, 0, array.Length);
                        }
                    }
                    MessageBox.Show("Текст записан в файл");
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

        private void runnersDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (runnersDataGrid.SelectedRows[0].Index != -1)
            {
                email = runnersDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            }
        }
    }
}
