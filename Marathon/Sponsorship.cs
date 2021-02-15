using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Marathon
{
    public partial class sponsorshipForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        string connection = @"Data Source=desktop-ua4mnst\bubochka;Initial Catalog=MarathonSkills2016;User ID=sa;Password=1056vQOAKZMtalvgty";

        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        public sponsorshipForm() //Инициализация формы
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }
        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void backButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Назад", переход на экран бегуна
        {
            sponsorshipForm.ActiveForm.Hide();
            runnerForm form = new runnerForm();
            form.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Logout", переход на главный экран
        {
            sponsorshipForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void sponsorshipForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void sponsorshipForm_Load(object sender, EventArgs e) //загружаем методы при загрузке формы
        {
            loadCharity();
            loadSponsors();
        }

        private void loadCharity() //загрузка организации
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("select [CharityName], [CharityDescription], [CharityLogo] from Registration " +
                    "inner join Charity on[Registration].[CharityId] = [Charity].[CharityId] " +
                    $"where RunnerId = (select RunnerId from Runner where Email = '{authorizationForm.email}')", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                infoLabel.Text = (string)dataSet.Tables[0].Rows[0][0];
                descriptionTextBox.Text = (string)dataSet.Tables[0].Rows[0][1];
                organizationPictureBox.Image = Bitmap.FromFile(@"D:\Загрузки\Задание\Ресурсы\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\" + (string)dataSet.Tables[0].Rows[0][2]);

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

        private void loadSponsors() //загрузка всех людей, которые проспонсировали бегуна
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter($"SELECT [SponsorName], [Amount] from [Sponsorship] where RegistrationId = (select RegistrationId from Registration where RunnerId = (select RunnerId from Runner where Email = '{authorizationForm.email}'))", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                int total = 0;
                sponsorMoneyUserControl[] Control = new sponsorMoneyUserControl[dataSet.Tables[0].Rows.Count];
                DataTable Table = new DataTable();
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    Control[i] = new sponsorMoneyUserControl();
                    Control[i].NameLabel = dataSet.Tables[0].Rows[i][0].ToString();
                    Control[i].Amount = '$' + dataSet.Tables[0].Rows[i][1].ToString();
                    total += Convert.ToInt32(dataSet.Tables[0].Rows[i][1]);
                    if (flowLayoutPanel.Controls.Count < 0)
                    {
                        flowLayoutPanel.Controls.Clear();
                    }
                    else
                    {
                        flowLayoutPanel.Controls.Add(Control[i]);
                    }
                }
                totalLabel.Text = "Всего $" + total.ToString();

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
