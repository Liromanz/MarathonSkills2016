using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Marathon
{
    public partial class volunterDownloadForm : Form
    {
        string connection = @"Data Source=desktop-ua4mnst\bubochka;Initial Catalog=MarathonSkills2016;User ID=sa;Password=1056vQOAKZMtalvgty";
        SqlConnection connectionSql;
        SqlCommand command;
        SqlDataAdapter DataAdapter;
        string fileLocation = "";
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public volunterDownloadForm() //Инициализация формы
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }
        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }
        private void fileButton_Click(object sender, EventArgs e) //Открытие диалогового окна для выбора файла
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Файлы CSV (*.csv)|*.csv";
                dialog.Title = "Выбрать файла";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    fileLocation = dialog.FileName;
                    fileTextBox.Text = fileLocation;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void loadButton_Click(object sender, EventArgs e) //Импортирование фойла при нажатии кнопки "Загрузка"
        {
            try
            {
                string[] line = File.ReadAllLines(fileLocation);
                connectionSql.Open();
                DataSet dataset = new DataSet();
                dataset.Tables.Add();
                dataset.Tables[0].Columns.Add("Номер поля", typeof(int)); 
                dataset.Tables[0].Columns.Add("Изменение", typeof(string)); 
                for (int i = 1; i < line.Length; i++)
                {
                    string[] stringSplit = line[i].Split(','); 
                    DataAdapter = new SqlDataAdapter($"SELECT {line[0]} from Volunteer where VolunteerId = '{stringSplit[0]}' ", connectionSql);
                    DataSet dataSetFor = new DataSet();
                    DataAdapter.Fill(dataSetFor);
                    csvDataGrid.DataSource = dataSetFor.Tables[0];
                    if (dataSetFor.Tables[0].Rows.Count > 0)
                    {
                        command = new SqlCommand($"update dbo.[Volunteer] set FirstName = '{stringSplit[1]}', LastName = '{stringSplit[2]}',CountryCode = '{stringSplit[3]}',Gender = '{stringSplit[4]}' where VolunteerId = '{stringSplit[0]}' ", connectionSql);
                        dataset.Tables[0].Rows.Add(stringSplit[0], "Update");
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        command = new SqlCommand($"insert into Volunteer(FirstName,  LastName, CountryCode,Gender) values ('{stringSplit[1]}','{stringSplit[2]}','{stringSplit[3]}','{stringSplit[4]}')", connectionSql);
                        dataset.Tables[0].Rows.Add(stringSplit[0], "Insert");
                        command.ExecuteNonQuery();
                    }
                }

                csvDataGrid.DataSource = dataset.Tables[0];
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

        private void backButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Назад", перезод на экран администратора
        {
            volunterDownloadForm.ActiveForm.Hide();
            adminForm Form = new adminForm();
            Form.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Logout", перезод на главный экран
        {
            volunterDownloadForm.ActiveForm.Hide();
            mainMenuForm Form = new mainMenuForm();
            Form.Show();
        }

        private void volunterDownloadForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void cancelButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Назад", перезод на экран администратора
        {
            volunterDownloadForm.ActiveForm.Hide();
            adminForm Form = new adminForm();
            Form.Show();
        }
    }
}
