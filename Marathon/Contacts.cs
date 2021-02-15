using System;
using System.Windows.Forms;

namespace Marathon
{
    public partial class contactsForm : Form
    {
        public contactsForm()
        {
            InitializeComponent();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            contactsForm.ActiveForm.Close();
        }
    }
}
