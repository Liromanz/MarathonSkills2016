using System;
using System.Windows.Forms;

namespace Marathon
{
    public partial class sponsorInfoForm : Form
    {
        public sponsorInfoForm() //Инициализация формы
        {
            InitializeComponent();
        }

        private void exitPictureBox_Click(object sender, EventArgs e) //Закрытие формы
        {
            sponsorInfoForm.ActiveForm.Close();
        }
    }
}
