using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Marathon
{
    public partial class listOfCharitiesForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        string connection = @"Data Source=desktop-ua4mnst\bubochka;Initial Catalog=MarathonSkills2016;User ID=sa;Password=1056vQOAKZMtalvgty";

        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        public listOfCharitiesForm() //Инициализировать форму
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void listOfCharitiesForm_Load(object sender, EventArgs e) //Выгрузка всех организаций из БД и заполнение кастомного элемента для отображения организаций при загрузке формы
        {
            try
            {
                connectionSql.Open();

                dataAdapter = new SqlDataAdapter("SELECT * from Charity", connectionSql);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                sponsorOrganizationUserControl[] control = new sponsorOrganizationUserControl[dataSet.Tables[0].Rows.Count];
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    control[i] = new sponsorOrganizationUserControl();
                    control[i].Title = dataSet.Tables[0].Rows[i][1].ToString();
                    control[i].Message = dataSet.Tables[0].Rows[i][2].ToString();
                    control[i].Check = false;
                    control[i].Icon = Bitmap.FromFile(@"D:\Загрузки\Задание\Ресурсы\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\" + dataSet.Tables[0].Rows[i][3].ToString());
                    flowLayoutPanel.Controls.Add(control[i]);
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

        private void backButton_Click(object sender, EventArgs e) // Нажатие на кнопку "Назад", переход на экран с информацией
        {
            listOfCharitiesForm.ActiveForm.Hide();
            informationForm form = new informationForm();
            form.Show();
        }

        private void listOfCharitiesForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }
    }
}
