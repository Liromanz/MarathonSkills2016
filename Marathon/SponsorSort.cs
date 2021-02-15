using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon
{
    public partial class SponsorSort : UserControl
    {
        public SponsorSort()
        {
            InitializeComponent();
        }

        private string _organization;

        public string Organization
        {
            get { return _organization; }
            set { _organization = value; orgLabel.Text = value; }
        }

        private string _amount;

        public string Amount
        {
            get { return _amount; }
            set { _amount = value; moneyLabel.Text = value; }
        }

        private Image _image;

        public Image Image
        {
            get { return _image; }
            set { _image = value; logoPictureBox.Image = value; }
        }


    }
}
