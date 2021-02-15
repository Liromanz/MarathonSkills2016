using System;
using System.Windows.Forms;

namespace Marathon
{
    public partial class activityLevelForm : Form
    {
        public activityLevelForm() //Инициализация формы
        {
            InitializeComponent();
        }

        private void exitPictureBox_Click(object sender, EventArgs e) //Закрытие формы
        {
            activityLevelForm.ActiveForm.Close();
        }
    }
}
