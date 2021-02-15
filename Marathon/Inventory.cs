using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Marathon
{
    public partial class inventoryForm : Form
    {
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);
        string connection = @"Data Source=desktop-ua4mnst\bubochka;Initial Catalog=MarathonSkills2016;User ID=sa;Password=1056vQOAKZMtalvgty";

        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        DataTable table;
        public inventoryForm() //Инициализация формы
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание таймера внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void backButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Назад", переход на экран админа
        {
            inventoryForm.ActiveForm.Hide();
            adminForm form = new adminForm();
            form.Show();
        }

        private void reportButton_Click(object sender, EventArgs e) //Создание всплывающего окна для отчета и отображение отчета при нажатии на кнопку "Отчет"
        {
            reportForm form = new reportForm();
            form.idLeftLabel.Text = idLeftLabel.Text;
            form.idNeedLabel.Text = idNeedLabel.Text;
            form.rfidLeftLabel.Text = rfidLeftLabel.Text;
            form.rfidNeedLabel.Text = rfidNeedLabel.Text;
            form.baseballLeftLabel.Text = baseballLeftLabel.Text;
            form.basebalNeedLabel.Text = basebalNeedLabel.Text;
            form.waterLeftLabel.Text = waterLeftLabel.Text;
            form.waterNeedLabel.Text = waterNeedLabel.Text;
            form.tshirtLeftLabel.Text = tshirtLeftLabel.Text;
            form.tshirtNeedLabel.Text = tshirtNeedLabel.Text;
            form.souvenirLeftLabel.Text = souvenirLeftLabel.Text;
            form.souvenirNeedLabel.Text = souvenirNeedLabel.Text;
            form.ShowDialog();
        }

        private void admissionButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Поступление", переход на экран поступления
        {
            inventoryForm.ActiveForm.Hide();
            admissionForm form = new admissionForm();
            form.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Logout", переход на главный экран
        {
            inventoryForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void inventoryForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void inventoryForm_Load(object sender, EventArgs e) //Загрузка методов при загрузке формы
        {
            loadRunners();
            loadItems();
            
        }

        private void loadRunners() //Загрузка всех бегунов и их пакетов
        {
            try
            {
                connectionSql.Open();

                dataAdapter = new SqlDataAdapter("select (select COUNT([RegistrationId])  from Registration) as 'All', (select COUNT([RegistrationId]) from Registration where RaceKitOptionId = 'A') as 'A', (select COUNT([RegistrationId])  from Registration where RaceKitOptionId = 'B') as 'B', (select COUNT([RegistrationId])  from Registration where RaceKitOptionId = 'C') as 'C'", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                table = dataSet.Tables[0];

                totalNumberLabel.Text = table.Rows[0][0].ToString();

                typeANumberLabel.Text =  table.Rows[0][1].ToString();
                idTypeALabel.Text =  table.Rows[0][1].ToString();
                rfidTypeALabel.Text =  table.Rows[0][1].ToString();

                typeBNumberLabel.Text =  table.Rows[0][2].ToString();
                idTypeBLabel.Text =  table.Rows[0][2].ToString();
                rfidTypeBLabel.Text =  table.Rows[0][2].ToString();
                basebalTypeBLabel.Text =  table.Rows[0][2].ToString();
                waterTypeBLabel.Text =  table.Rows[0][2].ToString();

                typeCNumberLabel.Text =  table.Rows[0][3].ToString();
                idTypeCLabel.Text =  table.Rows[0][3].ToString();
                rfidTypeCLabel.Text =  table.Rows[0][3].ToString();
                basebalTypeCLabel.Text =  table.Rows[0][3].ToString();
                waterTypeCLabel.Text =  table.Rows[0][3].ToString();
                tshirtTypeCLabel.Text =  table.Rows[0][3].ToString();
                souvenirTypeCLabel.Text =  table.Rows[0][3].ToString();

                idNeedLabel.Text = ((int)table.Rows[0][0]).ToString();
                rfidNeedLabel.Text = ((int)table.Rows[0][0]).ToString();
                basebalNeedLabel.Text = ((int)table.Rows[0][2] + (int)table.Rows[0][3]).ToString();
                waterNeedLabel.Text = ((int)table.Rows[0][2] + (int)table.Rows[0][3]).ToString();
                tshirtNeedLabel.Text = ((int)table.Rows[0][3]).ToString();
                souvenirNeedLabel.Text = ((int)table.Rows[0][3]).ToString();

                needNumberLabel.Text = ((int)table.Rows[0][0] + (int)table.Rows[0][0] + (int)table.Rows[0][2] + (int)table.Rows[0][3] + (int)table.Rows[0][2] + (int)table.Rows[0][3] + (int)table.Rows[0][3]  +(int)table.Rows[0][3]).ToString();

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

        private void loadItems() //Загрузка всех предметов инвентаря
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("select [Amount] from Inventory", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                table = dataSet.Tables[0];

                idLeftLabel.Text = ((int)table.Rows[0][0] - Convert.ToInt32(idNeedLabel.Text)).ToString();
                rfidLeftLabel.Text = ((int)table.Rows[1][0] - Convert.ToInt32(rfidNeedLabel.Text)).ToString();
                baseballLeftLabel.Text = ((int)table.Rows[2][0] - Convert.ToInt32(basebalNeedLabel.Text)).ToString();
                waterLeftLabel.Text = ((int)table.Rows[3][0] - Convert.ToInt32(waterNeedLabel.Text)).ToString();
                tshirtLeftLabel.Text = ((int)table.Rows[4][0] - Convert.ToInt32(tshirtNeedLabel.Text)).ToString();
                souvenirLeftLabel.Text = ((int)table.Rows[5][0] - Convert.ToInt32(souvenirNeedLabel.Text)).ToString();

                leftNumberLabel.Text = ((int)table.Rows[0][0] + (int)table.Rows[1][0] + (int)table.Rows[2][0] + (int)table.Rows[3][0] + (int)table.Rows[4][0] + (int)table.Rows[5][0] - Convert.ToInt32(needNumberLabel.Text)).ToString();
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
