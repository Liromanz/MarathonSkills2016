
namespace Marathon
{
    partial class contactsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contactsForm));
            this.emailBigLabel = new System.Windows.Forms.Label();
            this.numberGysLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.numberLable = new System.Windows.Forms.Label();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // emailBigLabel
            // 
            this.emailBigLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailBigLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.emailBigLabel.Location = new System.Drawing.Point(227, 228);
            this.emailBigLabel.Name = "emailBigLabel";
            this.emailBigLabel.Size = new System.Drawing.Size(365, 29);
            this.emailBigLabel.TabIndex = 35;
            this.emailBigLabel.Text = "coordinators@marathonskills.org";
            // 
            // numberGysLabel
            // 
            this.numberGysLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberGysLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.numberGysLabel.Location = new System.Drawing.Point(306, 188);
            this.numberGysLabel.Name = "numberGysLabel";
            this.numberGysLabel.Size = new System.Drawing.Size(264, 29);
            this.numberGysLabel.TabIndex = 34;
            this.numberGysLabel.Text = "+8 909 976 50 01";
            // 
            // emailLabel
            // 
            this.emailLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.emailLabel.Location = new System.Drawing.Point(153, 228);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(264, 29);
            this.emailLabel.TabIndex = 33;
            this.emailLabel.Text = "E-mail:";
            // 
            // numberLable
            // 
            this.numberLable.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.numberLable.Location = new System.Drawing.Point(188, 188);
            this.numberLable.Name = "numberLable";
            this.numberLable.Size = new System.Drawing.Size(264, 29);
            this.numberLable.TabIndex = 32;
            this.numberLable.Text = "Телефон:";
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("exitPictureBox.Image")));
            this.exitPictureBox.Location = new System.Drawing.Point(621, 17);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(27, 25);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPictureBox.TabIndex = 31;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.descriptionLabel.Location = new System.Drawing.Point(19, 118);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(637, 70);
            this.descriptionLabel.TabIndex = 30;
            this.descriptionLabel.Text = "Для получения дополнительной информации пожалуйста свяжитесь с координаторами";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nameLabel.Location = new System.Drawing.Point(16, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(633, 42);
            this.nameLabel.TabIndex = 29;
            this.nameLabel.Text = "Контакты";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 331);
            this.ControlBox = false;
            this.Controls.Add(this.emailBigLabel);
            this.Controls.Add(this.numberGysLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.numberLable);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.MaximumSize = new System.Drawing.Size(677, 370);
            this.MinimumSize = new System.Drawing.Size(677, 370);
            this.Name = "contactsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label emailBigLabel;
        public System.Windows.Forms.Label numberGysLabel;
        public System.Windows.Forms.Label emailLabel;
        public System.Windows.Forms.Label numberLable;
        private System.Windows.Forms.PictureBox exitPictureBox;
        public System.Windows.Forms.Label descriptionLabel;
        public System.Windows.Forms.Label nameLabel;
    }
}