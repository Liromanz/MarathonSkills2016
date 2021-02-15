using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Marathon
{
    public partial class runnerProfileForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);

        string connection = @"Data Source=desktop-ua4mnst\bubochka;Initial Catalog=MarathonSkills2016;User ID=sa;Password=1056vQOAKZMtalvgty";

        SqlConnection connectionSql;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataRow row;
        string imageLocation = "";
        public runnerProfileForm() //Инициализация формы
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
            sexComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void photoButton_Click(object sender, EventArgs e) //Открытие диалогового окна для выбора картинки
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Файлы JPG (*.jpg)|*.jpg|Файлы PNG (*.png)|*.png";
                dialog.Title = "Выбрать фотографию";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName.ToString();
                    photoPictureBox.ImageLocation = imageLocation;
                    photoTextBox.Text = dialog.FileName;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void registerButton_Click(object sender, EventArgs e) //изменение всех файлов для внесения их в бд и обновление всех данных в зависимости от email
        {
            string result = checkToAdd();
            if (result == "ОК")
            {
                try
                {
                    connectionSql.Open();

                    string name = nameTextBox.Text;
                    string lastName = lastNameTextBox.Text;
                    string gender = sexComboBox.Text;
                    string data = birthDateTimePicker.Value.ToString();
                    string country = countryComboBox.SelectedValue.ToString();

                    byte[] image = (byte[])row[6];
                    if (imageLocation != "")
                    {
                        FileStream fileStream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader binaryReader = new BinaryReader(fileStream);
                        image = binaryReader.ReadBytes((int)fileStream.Length);
                    }

                    string password = (string)row[7];
                    if (passwordTextBox.Text != "" || passwordAgainTextBox.Text != "")
                    {
                        string resultPassword = changePassword();
                        if (resultPassword == "ОК")
                        {
                            password = passwordTextBox.Text;
                        }
                        else
                        {
                            MessageBox.Show(resultPassword);
                        }
                    }

                    command = new SqlCommand($"update[dbo].[User] set Password = '{password}', FirstName = '{name}', LastName = '{lastName}' where Email = '{emailUserLabel.Text}'", connectionSql);
                    command.ExecuteNonQuery();
                    connectionSql.Close();

                    connectionSql.Open();
                    command = new SqlCommand($"update[dbo].[Runner] set Gender = '{gender}', CountryCode = '{country}', DateOfBirth = CONVERT(datetime, '{data}', 4), Image = @img where Email = '{emailUserLabel.Text}'", connectionSql);
                    command.Parameters.Add(new SqlParameter("@img", image));
                    command.ExecuteNonQuery();


                    runnerProfileForm.ActiveForm.Hide();
                    eventRegistrationForm form = new eventRegistrationForm();
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

        private void cancelButton_Click(object sender, EventArgs e) // Нажатие на кнопку "Отмена", переход на экран бегуна
        {
            runnerProfileForm.ActiveForm.Hide();
            runnerForm form = new runnerForm();
            form.Show();
        }

        private void backButton_Click(object sender, EventArgs e) // Нажатие на кнопку "Назад", переход на главный экран
        {
            runnerProfileForm.ActiveForm.Hide();
            runnerForm form = new runnerForm();
            form.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e) // Нажатие на кнопку "Logout", переход на главный экран
        {
            runnerProfileForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void runnerProfileForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void runnerProfileForm_Load(object sender, EventArgs e) // Загрузка всех методов при открытии формы
        {
            loadGender();
            loadCountries();
            loadData();
        }

        private void loadGender() // Загрузка полов и выгрузка в список
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT * from Gender", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                sexComboBox.DataSource = dataSet.Tables[0];
                sexComboBox.DisplayMember = "Gender";
                sexComboBox.ValueMember = "Gender";

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

        private void loadCountries() // Загрузка стран и выгразка в список 
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT [CountryCode], [CountryName] from Country", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                countryComboBox.DataSource = dataSet.Tables[0];
                countryComboBox.DisplayMember = "CountryName";
                countryComboBox.ValueMember = "CountryCode";

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

        private string checkToAdd() //Все проверки для текста
        {
            DateTime today = DateTime.Today;
            if (today.Subtract(birthDateTimePicker.Value).Days / 365 < 10)
                return "Вам еще не исполнилось 10 лет";

            if (!nameTextBox.Text.All(c => char.IsLetter(c)))
                return "В имени есть лишние символы";

            if (!lastNameTextBox.Text.All(c => char.IsLetter(c)))
                return "В фамилии есть лишние символы";

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

        private void loadData() //Загрузка информации о бегуне
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter($"SELECT dbo.Runner.Email, dbo.[User].FirstName, dbo.[User].LastName, dbo.Runner.Gender, dbo.Runner.DateOfBirth, dbo.Country.CountryName, dbo.Runner.Image, dbo.[User].Password FROM dbo.Runner INNER JOIN dbo.[User] ON dbo.Runner.Email = dbo.[User].Email INNER JOIN dbo.Country ON dbo.Runner.CountryCode = dbo.Country.CountryCode WHERE (dbo.Runner.Email = '{authorizationForm.email}')", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                row = dataSet.Tables[0].Rows[0];
                emailUserLabel.Text = row[0].ToString();
                nameTextBox.Text = row[1].ToString();
                lastNameTextBox.Text = row[2].ToString();
                sexComboBox.Text = row[3].ToString();
                birthDateTimePicker.Value = Convert.ToDateTime(row[4].ToString());
                countryComboBox.Text = row[5].ToString();
                if (!((byte[])row[6]).All(c => c == 0))
                {
                    MemoryStream memoryStream = new MemoryStream((byte[])row[6]);
                    photoPictureBox.Image = Image.FromStream(memoryStream);
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

    }
}
