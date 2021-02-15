using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Marathon
{
    public partial class sponsorOrganizationUserControl : UserControl
    {
        public sponsorOrganizationUserControl() //Инициализация формы
        {
            InitializeComponent();
        }

        private string _message;
        private string _title;
        private Image _icon;
        private bool _check;
        private string _imageLocation;

        [Category("Custom Props")]
        public string ImageLocation
        {
            get { return _imageLocation; }
            set { _imageLocation = value; }
        }

        [Category("Custom Props")]
        public bool Check
        {
            get { return _check; }
            set { _check = value; }
        }

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; nameLabel.Text = value; }
        }

        [Category("Custom Props")]
        public string Message
        {
            get { return _message; }
            set { _message = value; descriptionTextBox.Text = value; }
        }
        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; orgPictureBox.Image = value; }
        }

        private void sponsorOrganizationUserControl_Click(object sender, EventArgs e)
        {
            if (Check)
            {
                foundationManagerForm.ActiveForm.Hide();
                foundationEditForm Form = new foundationEditForm();
                Form.nameTextBox.Text = Title;
                Form.descriptionTextBox.Text = Message;
                Form.logoPictureBox.Image = Icon;
                Form.photoTextBox.Text = ImageLocation;
                Form.Show();
            }
        }
    }
}
