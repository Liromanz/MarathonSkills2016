using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon
{
    public partial class foundationManagerForm : Form
    {
        string connection = @"Data Source=desktop-ua4mnst\bubochka;Initial Catalog=MarathonSkills2016;User ID=sa;Password=1056vQOAKZMtalvgty";
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;

        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        public foundationManagerForm() //Инициализация формы
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void manageFoundationForm_Load(object sender, EventArgs e) //Загрузка организаций при загрузке форм
        {
            charity();
        }
        public void charity() //Вызгурзка организаций из базы данных и настройка карточки
        {
            try
            {
                connectionSql.Open();

                dataAdapter = new SqlDataAdapter("SELECT * from Charity", connectionSql);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                sponsorOrganizationUserControl[] Control = new sponsorOrganizationUserControl[dataSet.Tables[0].Rows.Count];
                DataTable table = new DataTable();
                int i = 0; while (i < dataSet.Tables[0].Rows.Count)
                {

                    Control[i] = new sponsorOrganizationUserControl();
                    Control[i].Title = dataSet.Tables[0].Rows[i][1].ToString();
                    Control[i].Message = dataSet.Tables[0].Rows[i][2].ToString();
                    Control[i].Check = true;
                    Control[i].ImageLocation = @"D:\Загрузки\Задание\Ресурсы\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\" + dataSet.Tables[0].Rows[i][3].ToString();
                    Control[i].Icon = Bitmap.FromFile(@"D:\Загрузки\Задание\Ресурсы\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\" + dataSet.Tables[0].Rows[i][3].ToString());
                    if (organizationLayoutPanel.Controls.Count < 0)
                    {
                        organizationLayoutPanel.Controls.Clear();
                    }
                    else
                    {
                        organizationLayoutPanel.Controls.Add(Control[i]);
                    }
                    i++;
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

        private void newButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Добавить нового", переход на экрандобавления организаций
        {
            foundationManagerForm.ActiveForm.Hide();
            foundationEditForm form = new foundationEditForm();
            form.Show();
        }

        private void backButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Назад", переход на форму администратора
        {
            foundationManagerForm.ActiveForm.Hide();
            adminForm form = new adminForm();
            form.Show();
        }

        private void Manage_Foundation_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

    }
}
