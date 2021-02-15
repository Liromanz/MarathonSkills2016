using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Marathon
{
    public partial class sponsorForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);

        string connection = @"Data Source=desktop-ua4mnst\bubochka;Initial Catalog=MarathonSkills2016;User ID=sa;Password=1056vQOAKZMtalvgty";
        SqlConnection connectionSql;
        SqlCommand command;
        SqlDataAdapter dataAdapter;

        DataTable table;

        public sponsorForm() //Инициализация формы
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
            runnerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void infoPictureBox_Click(object sender, EventArgs e) //Запуск всплывающего окна с информацие об организации
        {
            if (Convert.ToInt32(runnerComboBox.SelectedIndex) != -1)
            {
                DataRow dataRow = table.Rows[Convert.ToInt32(runnerComboBox.SelectedIndex)];
                sponsorInfoForm form = new sponsorInfoForm();
                form.nameLabel.Text = foundationLabel.Text;
                form.descriptionLabel.Text = dataRow[4].ToString();
                form.foundationPictureBox.Image = Bitmap.FromFile(@"D:\Загрузки\Задание\Ресурсы\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\" + dataRow[3].ToString());
                form.ShowDialog();
            }
        }

        private void backButton_Click(object sender, EventArgs e)// Нажатие на кнопку "Назад", переход на главное меню
        {
            sponsorForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void payButton_Click(object sender, EventArgs e) // Нажатие на кнопку "Заплатить", переход на окно подтверждения и добавление денег в базу данных
        {
            string check = checkToAdd();
            if (check == "ОК")
            {
                try
                {
                    connectionSql.Open();

                    command = new SqlCommand($"insert into [Sponsorship] (SponsorName, RegistrationId, Amount) values ('{nameTextBox.Text.ToUpper()}', {runnerComboBox.SelectedValue}, {moneyTextBox.Text}.00)", connectionSql);
                    command.ExecuteNonQuery();

                    sponsorForm.ActiveForm.Hide();
                    confirmationForm form = new confirmationForm();
                    form.moneyLabel.Text = moneyLabel.Text;
                    DataRowView rowRunner = (DataRowView)runnerComboBox.SelectedItem;
                    form.nameLabel.Text = rowRunner[1].ToString();
                    form.foundationLabel.Text = foundationLabel.Text;
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
                MessageBox.Show(check);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) // Нажатие на кнопку "Отмена", переход на главное меню
        {
            sponsorForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void sponsorForm_Load(object sender, EventArgs e) // Загрузка всех спонсоров
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT dbo.Registration.RegistrationId, dbo.[User].FirstName + ' ' + dbo.[User].LastName + ' - ' + CONVERT(varchar, dbo.Registration.RunnerId) + ' (' + dbo.Country.CountryName + ')' AS Runner, dbo.Charity.CharityName, dbo.Charity.CharityLogo, dbo.Charity.CharityDescription FROM dbo.Charity INNER JOIN dbo.Registration ON dbo.Charity.CharityId = dbo.Registration.CharityId INNER JOIN dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId INNER JOIN dbo.[User] ON dbo.Runner.Email = dbo.[User].Email INNER JOIN dbo.Country ON dbo.Runner.CountryCode = dbo.Country.CountryCode", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                table = dataSet.Tables[0];
                runnerComboBox.DataSource = table;
                runnerComboBox.DisplayMember = "Runner";
                runnerComboBox.ValueMember = "RegistrationId";

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

        private void minusButton_Click(object sender, EventArgs e) //Нажатие на кнопку минус
        {
            if (Convert.ToInt32(moneyTextBox.Text) - 10 > 0)
                moneyTextBox.Text = (Convert.ToInt32(moneyTextBox.Text) - 10).ToString();
            else
                moneyTextBox.Text = "0";
        }

        private void plusButton_Click(object sender, EventArgs e) //Нажатие на кнопку плюс
        {
            if (Convert.ToInt32(moneyTextBox.Text) + 10 <= 999999)
                moneyTextBox.Text = (Convert.ToInt32(moneyTextBox.Text) + 10).ToString();
            else
                moneyTextBox.Text = "999999";
        }

        private void sponsorForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие программы при закрытии формы
        {
            Application.Exit();
        }

        private void moneyTextBox_TextChanged(object sender, EventArgs e) //Защита от ввода пустоты
        {
            if (moneyTextBox.Text == "")
                moneyTextBox.Text = "0";
            moneyLabel.Text = moneyTextBox.Text + '$';
        }

        private void runnerComboBox_SelectedIndexChanged(object sender, EventArgs e) //Изменение организации в зависимости от выбранного человека
        {
            if (runnerComboBox.SelectedIndex != -1)
            {
                DataRow dataRow = table.Rows[Convert.ToInt32(runnerComboBox.SelectedIndex)];
                foundationLabel.Text = dataRow[2].ToString();
            }
        }
        private string checkToAdd() //все проверки на текст, пароль и имейл
        {
            if (nameTextBox.Text == "" || cardTextBox.Text == "" || cardNumberTextBox.Text == "" || monthTextBox.Text == "" || yearTextBox.Text == "" || cvvTextBox.Text == "" )
                return "Не все поля заполнены";

            if (Convert.ToInt32(moneyTextBox.Text) == 0)
                return "Пожертвование не может быть равно 0";

            if (Convert.ToInt32(monthTextBox.Text) == 0 || Convert.ToInt32(monthTextBox.Text) > 12 || Convert.ToInt32(monthTextBox.Text) < DateTime.Today.Month)
                return "Некорректный ввод месяца в сроке действия";

            if (Convert.ToInt32(yearTextBox.Text) < 2021)
                return "Некорректный ввод года в сроке действия";

            return "ОК";
        }
    }
}
