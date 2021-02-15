using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Marathon
{
    public partial class userEditForm : Form
    {
        string connection = @"Data Source=desktop-ua4mnst\bubochka;Initial Catalog=MarathonSkills2016;User ID=sa;Password=1056vQOAKZMtalvgty";
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        SqlCommand command;

        DateTime DateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public userEditForm() //Инициализация форму
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = DateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void backButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Назад", возвращение на экран управления пользователями
        {
            userEditForm.ActiveForm.Hide();
            usersManagerForm form = new usersManagerForm();
            form.Show();
        }

        private void loadRoles() //Загрузка ролей
        {
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

        private void saveButton_Click(object sender, EventArgs e) //Изменение полей существующего пользователя
        {
            string result = checkToAdd();
            if (result == "ОК")
            {
                try
                {
                    string password = "";
                    if (passwordTextBox.Text != "" || passwordAgainTextBox.Text != "")
                    {
                        string resultPassword = changePassword();
                        if (resultPassword == "ОК")
                        {
                            password = $", Password = '{passwordTextBox.Text}'";
                        }
                        else
                        {
                            MessageBox.Show(resultPassword);
                        }
                    }
                    connectionSql.Open();
                    DataRowView rowRunner = (DataRowView)roleComboBox.SelectedItem;
                    string roleId = rowRunner[0].ToString();
                    command = new SqlCommand($"UPDATE dbo.[User] SET FirstName='{nameTextBox.Text}', LastName='{lastNameTextBox.Text}', RoleID = '{roleId}'  {password} WHERE Email='{emailUserLabel.Text}'", connectionSql);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Успешно обновлено!");
                    userEditForm.ActiveForm.Hide();
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

        private string checkToAdd() //Все проверки для текста
        {
            if ((nameTextBox.Text == "" || lastNameTextBox.Text == "" ) && passwordTextBox.Text == "")
                return "Не все поля заполнены";

            return "ОК";
        }

        private string changePassword() //Все проверки для паролей
        {
            if (passwordTextBox.Text.Length < 6 || !Regex.IsMatch(passwordTextBox.Text, @"[0-9]") || !Regex.IsMatch(passwordTextBox.Text, @"[A-Z]") || !Regex.IsMatch(passwordTextBox.Text, @"[!@#$%^]"))
                return "Неверно введен пароль. Пароль должен имень минимум 6 символов, 1 прописную букву, 1 цифру и один из этих символов: !@#$%^. Изменение пароля будет пропущено";

            if (passwordTextBox.Text != passwordAgainTextBox.Text)
                return "Пароли не совпадают. Изменение пароля будет пропущено";

            return "ОК";
        }

        private void userEditForm_Load(object sender, EventArgs e) //Загрузка методов при загрузке формы
        {
            loadRoles();
        }

        private void logoutButton_Click(object sender, EventArgs e) //Нажатие на кнопку Logout, переход на главное меню
        {
            userEditForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void userEditForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void cancelButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Отмена", переход на экран управления пользователями
        {
            userEditForm.ActiveForm.Hide();
            usersManagerForm form = new usersManagerForm();
            form.Show();
        }
    }
}
