
namespace Marathon
{
    partial class sponsorOrganizationUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sponsorOrganizationUserControl));
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.orgPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.orgPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.descriptionTextBox.Location = new System.Drawing.Point(127, 38);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(593, 162);
            this.descriptionTextBox.TabIndex = 5;
            this.descriptionTextBox.Text = resources.GetString("descriptionTextBox.Text");
            this.descriptionTextBox.Click += new System.EventHandler(this.sponsorOrganizationUserControl_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 20.25F);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nameLabel.Location = new System.Drawing.Point(127, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(65, 32);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Title";
            this.nameLabel.Click += new System.EventHandler(this.sponsorOrganizationUserControl_Click);
            // 
            // orgPictureBox
            // 
            this.orgPictureBox.Location = new System.Drawing.Point(3, 3);
            this.orgPictureBox.Name = "orgPictureBox";
            this.orgPictureBox.Size = new System.Drawing.Size(118, 113);
            this.orgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.orgPictureBox.TabIndex = 3;
            this.orgPictureBox.TabStop = false;
            this.orgPictureBox.Click += new System.EventHandler(this.sponsorOrganizationUserControl_Click);
            // 
            // sponsorOrganizationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.orgPictureBox);
            this.Name = "sponsorOrganizationUserControl";
            this.Size = new System.Drawing.Size(723, 203);
            this.Click += new System.EventHandler(this.sponsorOrganizationUserControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.orgPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox orgPictureBox;
    }
}
