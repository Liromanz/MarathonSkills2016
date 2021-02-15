using System;
using System.Windows.Forms;

namespace Marathon
{
    public partial class reportForm : Form
    {
        public reportForm() //Инициализация формы
        {
            InitializeComponent();
        }

        private void crossPictureBox_Click(object sender, EventArgs e) // Нажатие на кнопку с крестиком, закрытие формы
        {
            reportForm.ActiveForm.Close();
        }

        private void reportForm_Load(object sender, EventArgs e) // Расчет необзодимого количества для закупки при загрузке формы
        {
            if (Convert.ToInt32(idLeftLabel.Text) - Convert.ToInt32(idNeedLabel.Text) < 0)
                idOrderLabel.Text = (Convert.ToInt32(idLeftLabel.Text) - Convert.ToInt32(idNeedLabel.Text)).ToString();

            if (Convert.ToInt32(rfidLeftLabel.Text) - Convert.ToInt32(rfidNeedLabel.Text) < 0)
                rfidOrderLabel.Text = (Convert.ToInt32(rfidLeftLabel.Text) - Convert.ToInt32(rfidNeedLabel.Text)).ToString();

            if (Convert.ToInt32(baseballLeftLabel.Text) - Convert.ToInt32(basebalNeedLabel.Text) < 0)
                baseballOrderLabel.Text = (Convert.ToInt32(baseballLeftLabel.Text) - Convert.ToInt32(basebalNeedLabel.Text)).ToString();

            if (Convert.ToInt32(waterLeftLabel.Text) - Convert.ToInt32(waterNeedLabel.Text) < 0)
                waterOrderLabel.Text = (Convert.ToInt32(waterLeftLabel.Text) - Convert.ToInt32(waterNeedLabel.Text)).ToString();

            if (Convert.ToInt32(tshirtLeftLabel.Text) - Convert.ToInt32(tshirtNeedLabel.Text) < 0)
                tshirtOrderLabel.Text = (Convert.ToInt32(tshirtLeftLabel.Text) - Convert.ToInt32(tshirtNeedLabel.Text)).ToString();

            if (Convert.ToInt32(souvenirLeftLabel.Text) - Convert.ToInt32(souvenirNeedLabel.Text) < 0)
                souvenirOrderLabel.Text = (Convert.ToInt32(souvenirLeftLabel.Text) - Convert.ToInt32(souvenirNeedLabel.Text)).ToString();
        }
    }
}
