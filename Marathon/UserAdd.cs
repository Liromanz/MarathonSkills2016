using System;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Marathon
{
    public partial class userAddForm : Form
    {
        string connection = @"Data Source=desktop-ua4mnst\bubochka;Initial Catalog=MarathonSkills2016;User ID=sa;Password=1056vQOAKZMtalvgty";
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        SqlCommand command;

        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public userAddForm() //Инициализировать форму
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void backButton_Click(object sender, EventArgs e) //Нажатие на кнопку назад, переход на форму управления пользователями
        {
            userAddForm.ActiveForm.Hide();
            usersManagerForm form = new usersManagerForm();
            form.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e) //Нажатие на кнопку logout, переход на главный экран
        {
            userAddForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void loadRole() //Загрузка полов
        {
            connectionSql = new SqlConnection(connection);
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT * From Role", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                roleComboBox.DataSource = dataSet.Tables[0];
                roleComboBox.DisplayMember = "RoleName";
                roleComboBox.ValueMember = "RoleId";
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

        private void saveButton_Click(object sender, EventArgs e) //Сохранение нового пользователя
        {
            string result = checkToAdd();
            if (result == "ОК")
            {
                try
                {
                    connectionSql.Open();

                    DataRowView rowRunner = (DataRowView)roleComboBox.SelectedItem;
                    string roleId = rowRunner[0].ToString();
                    command = new SqlCommand($"insert into [dbo].[User] (Email, Password, FirstName, LastName, RoleId) values('{emailTextBox.Text}', '{passwordTextBox.Text}','{nameTextBox.Text.ToUpper()}','{nameTextBox.Text.ToUpper()}','{roleId}')", connectionSql);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Успешно зарегистрирован!");
                    userAddForm.ActiveForm.Hide();
                    usersManagerForm form = new usersManagerForm();
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
                MessageBox.Show(result);
            }
        }

        private string checkToAdd() //Все проверки для полей
        {
            if (emailTextBox.Text == "" || passwordTextBox.Text == "" || passwordAgainTextBox.Text == "" || nameTextBox.Text == "" || lastNameTextBox.Text == "")
                return "Не все поля заполнены";

            try { var mail = new MailAddress(emailTextBox.Text); }
            catch { return "Некорректный e-mail адрес"; }

            if (passwordTextBox.Text.Length < 6 || !Regex.IsMatch(passwordTextBox.Text, @"[0-9]") || !Regex.IsMatch(passwordTextBox.Text, @"[A-Z]") || !Regex.IsMatch(passwordTextBox.Text, @"[!@#$%^]"))
                return "Неверно введен пароль. Пароль должен имень минимум 6 символов, 1 прописную букву, 1 цифру и один из этих символов: !@#$%^";

            if (passwordTextBox.Text != passwordAgainTextBox.Text)
                return "Пароли не совпадают";

            if (!nameTextBox.Text.All(c => char.IsLetter(c)))
                return "В имени есть лишние символы";

            if (!lastNameTextBox.Text.All(c => char.IsLetter(c)))
                return "В фамилии есть лишние символы";

            return "ОК";
        }

        private void userAddForm_Load(object sender, EventArgs e) //Загрузка методов при загрузке формы
        {
            loadRole();
        }

        private void userAddForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }
    }
}
