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
    public partial class sponsorshipViewForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        string connection = @"Data Source=desktop-ua4mnst\bubochka;Initial Catalog=MarathonSkills2016;User ID=sa;Password=1056vQOAKZMtalvgty";

        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        public sponsorshipViewForm() //Инициализация фонмы
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }
        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }
        private void sponsorshipViewForm_Load(object sender, EventArgs e) //Загрузка списка спонсоров при загрузке формы
        {
            try
            {
                int fullCost = 0;
                connectionSql.Open();

                dataAdapter = new SqlDataAdapter("select [CharityLogo], [CharityName], (select [Amount] from [OneThing]([CharityName])) AS 'Amount' from [Charity]", connectionSql);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                SponsorSort[] control = new SponsorSort[dataSet.Tables[0].Rows.Count];
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    control[i] = new SponsorSort();
                    control[i].Image = Bitmap.FromFile(@"D:\Загрузки\Задание\Ресурсы\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\" + dataSet.Tables[0].Rows[i][0].ToString());
                    control[i].Organization = dataSet.Tables[0].Rows[i][1].ToString();
                    control[i].Amount = dataSet.Tables[0].Rows[i][2].ToString();
                    flowLayoutPanel.Controls.Add(control[i]);
                    fullCost += Convert.ToInt32(dataSet.Tables[0].Rows[i][2]);
                }
                organizationNummberLabel.Text = control.Count().ToString();
                moneyNumberLabel.Text = "$" + fullCost;
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

        private void refreshButton_Click(object sender, EventArgs e) //Кнопка обновления дата грида
        {
            string orderBy = "";
            if (statusComboBox.SelectedIndex == 0) orderBy = "CharityName";
            else orderBy = "Amount";

            try
            {
                connectionSql.Open();

                dataAdapter = new SqlDataAdapter($"select [CharityLogo], [CharityName], (select [Amount] from [OneThing]([CharityName])) AS 'Amount' from [Charity] order by {orderBy} desc", connectionSql);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                SponsorSort[] control = new SponsorSort[dataSet.Tables[0].Rows.Count];
                flowLayoutPanel.Controls.Clear();
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    control[i] = new SponsorSort();
                    control[i].Image = Bitmap.FromFile(@"D:\Загрузки\Задание\Ресурсы\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\" + dataSet.Tables[0].Rows[i][0].ToString());
                    control[i].Organization = dataSet.Tables[0].Rows[i][1].ToString();
                    control[i].Amount = dataSet.Tables[0].Rows[i][2].ToString();
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

        private void sponsorshipViewForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            sponsorshipViewForm.ActiveForm.Hide();
            coordinatorForm form = new coordinatorForm();
            form.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            sponsorshipViewForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }
    }
}
