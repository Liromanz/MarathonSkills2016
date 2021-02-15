using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Marathon
{
    public partial class usersManagerForm : Form
    {
        public string emailInfo, nameInfo, lastNameInfo, roleInfo;
        DateTime dateOfStart = new DateTime(2021, 11, 24, 6, 0, 0);

        string connection = @"Data Source=desktop-ua4mnst\bubochka;Initial Catalog=MarathonSkills2016;User ID=sa;Password=1056vQOAKZMtalvgty";
        SqlConnection connectionSql;
        SqlDataAdapter dataAdapter;
        public usersManagerForm() //Инициализация формы
        {
            InitializeComponent();
            connectionSql = new SqlConnection(connection);
        }

        private void timer_Tick(object sender, EventArgs e) //Тикание часов внизу экрана
        {
            TimeSpan different = dateOfStart.Subtract(DateTime.Now);
            timerLabel.Text = $"{different.Days} дней {different.Hours} часов и {different.Minutes} минут до старта марафона!";
        }

        private void loadRole() //Загрузка ролей и выгрузка их в список
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

        public void loadUsers() //Загрузка пользователей и выгрузка их в список
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter("SELECT FirstName AS 'Имя', LastName AS 'Фамилия', Email AS 'Email', RoleName AS 'Роль' FROM [Role] inner join [User] ON [User].RoleId = [Role].RoleId", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                usersDataGrid.DataSource = dataSet.Tables[0];
                allNumberLabel.Text = dataSet.Tables[0].Rows.Count.ToString();
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

        private void updateButton_Click(object sender, EventArgs e) //Обновление дата грида в зависимости от выбранных значений в списках
        {
            try
            {
                connectionSql.Open();
                dataAdapter = new SqlDataAdapter($"SELECT FirstName AS 'Имя', LastName AS 'Фамилия', Email AS 'Email', RoleName AS 'Роль' FROM [Role] inner join [User] ON [User].RoleId = [Role].RoleId WHERE (FirstName like '%{findTextBox.Text}%' or LastName like '%{findTextBox.Text}%' or Email like '%{findTextBox.Text}%') and RoleName like '%{roleComboBox.Text}%'", connectionSql);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                usersDataGrid.DataSource = dataSet.Tables[0];
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

        private void addButton_Click(object sender, EventArgs e) //Переход на экран с добавлением пользователей
        {
            usersManagerForm.ActiveForm.Hide();
            userAddForm form = new userAddForm();
            form.Show();
        }

        private void editButton_Click(object sender, EventArgs e) //Переносим данные для изменения на другую форму
        {
            if (emailInfo != "" && nameInfo != "" && lastNameInfo != "")
            {
                usersManagerForm.ActiveForm.Hide();
                userEditForm form = new userEditForm();
                form.emailUserLabel.Text = emailInfo;
                form.nameTextBox.Text = lastNameInfo;
                form.lastNameTextBox.Text = nameInfo;
                form.roleComboBox.Text = roleInfo;
                form.Show();
            }
        }

        private void backButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Назад", выход на меню администратора
        {
            usersManagerForm.ActiveForm.Hide();
            adminForm form = new adminForm();
            form.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e) //Нажатие на кнопку "Logout", выход на главное меню
        {
            usersManagerForm.ActiveForm.Hide();
            mainMenuForm form = new mainMenuForm();
            form.Show();
        }

        private void userManagerForm_FormClosing(object sender, FormClosingEventArgs e) //Закрытие приложения при закрытии формы
        {
            Application.Exit();
        }

        private void userManagerForm_Load(object sender, EventArgs e) //Загрузка методов при загрузке формы 
        {
            loadRole();
            loadUsers();
        }

        private void usersDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (usersDataGrid.SelectedRows[0].Index != -1)
            {
                emailInfo = usersDataGrid.SelectedRows[0].Cells[2].Value.ToString();
                nameInfo = usersDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                lastNameInfo = usersDataGrid.SelectedRows[0].Cells[0].Value.ToString();
                roleInfo = usersDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
    }
}
