
namespace Marathon
{
    partial class activityLevelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(activityLevelForm));
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.sitLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.normalLabel = new System.Windows.Forms.Label();
            this.hardLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.sitDescriptionLabel = new System.Windows.Forms.Label();
            this.littleDescriptionLabel = new System.Windows.Forms.Label();
            this.normalDescriptionLabel = new System.Windows.Forms.Label();
            this.hardDescriptionLabel = new System.Windows.Forms.Label();
            this.maxDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("exitPictureBox.Image")));
            this.exitPictureBox.Location = new System.Drawing.Point(621, 11);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(27, 25);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPictureBox.TabIndex = 17;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.descriptionLabel.Location = new System.Drawing.Point(20, 88);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(629, 29);
            this.descriptionLabel.TabIndex = 16;
            this.descriptionLabel.Text = "Это описание всех уровней активности";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nameLabel.Location = new System.Drawing.Point(16, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(633, 42);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Уровни активности";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sitLabel
            // 
            this.sitLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sitLabel.Location = new System.Drawing.Point(30, 147);
            this.sitLabel.Name = "sitLabel";
            this.sitLabel.Size = new System.Drawing.Size(264, 29);
            this.sitLabel.TabIndex = 18;
            this.sitLabel.Text = "• Сидячий:";
            // 
            // minLabel
            // 
            this.minLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.minLabel.Location = new System.Drawing.Point(30, 176);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(264, 29);
            this.minLabel.TabIndex = 19;
            this.minLabel.Text = "• Маленькая активность:";
            // 
            // normalLabel
            // 
            this.normalLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.normalLabel.Location = new System.Drawing.Point(30, 205);
            this.normalLabel.Name = "normalLabel";
            this.normalLabel.Size = new System.Drawing.Size(264, 29);
            this.normalLabel.TabIndex = 20;
            this.normalLabel.Text = "• Средняя активность:";
            // 
            // hardLabel
            // 
            this.hardLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hardLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.hardLabel.Location = new System.Drawing.Point(30, 234);
            this.hardLabel.Name = "hardLabel";
            this.hardLabel.Size = new System.Drawing.Size(264, 29);
            this.hardLabel.TabIndex = 21;
            this.hardLabel.Text = "• Сильная активность:";
            // 
            // maxLabel
            // 
            this.maxLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.maxLabel.Location = new System.Drawing.Point(30, 263);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(300, 29);
            this.maxLabel.TabIndex = 22;
            this.maxLabel.Text = "• Максимальная активность:";
            // 
            // sitDescriptionLabel
            // 
            this.sitDescriptionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sitDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sitDescriptionLabel.Location = new System.Drawing.Point(148, 147);
            this.sitDescriptionLabel.Name = "sitDescriptionLabel";
            this.sitDescriptionLabel.Size = new System.Drawing.Size(500, 29);
            this.sitDescriptionLabel.TabIndex = 23;
            this.sitDescriptionLabel.Text = "Нет физической активности или работа за столом";
            // 
            // littleDescriptionLabel
            // 
            this.littleDescriptionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.littleDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.littleDescriptionLabel.Location = new System.Drawing.Point(281, 176);
            this.littleDescriptionLabel.Name = "littleDescriptionLabel";
            this.littleDescriptionLabel.Size = new System.Drawing.Size(367, 29);
            this.littleDescriptionLabel.TabIndex = 24;
            this.littleDescriptionLabel.Text = "Занятие спортом 1-3 раза в неделю";
            // 
            // normalDescriptionLabel
            // 
            this.normalDescriptionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normalDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.normalDescriptionLabel.Location = new System.Drawing.Point(254, 205);
            this.normalDescriptionLabel.Name = "normalDescriptionLabel";
            this.normalDescriptionLabel.Size = new System.Drawing.Size(394, 29);
            this.normalDescriptionLabel.TabIndex = 25;
            this.normalDescriptionLabel.Text = "Занятие спортом 3-5 раз в неделю";
            // 
            // hardDescriptionLabel
            // 
            this.hardDescriptionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hardDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.hardDescriptionLabel.Location = new System.Drawing.Point(254, 234);
            this.hardDescriptionLabel.Name = "hardDescriptionLabel";
            this.hardDescriptionLabel.Size = new System.Drawing.Size(382, 29);
            this.hardDescriptionLabel.TabIndex = 26;
            this.hardDescriptionLabel.Text = "Занятие спортом 6-7 раз в неделю";
            // 
            // maxDescriptionLabel
            // 
            this.maxDescriptionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.maxDescriptionLabel.Location = new System.Drawing.Point(315, 263);
            this.maxDescriptionLabel.Name = "maxDescriptionLabel";
            this.maxDescriptionLabel.Size = new System.Drawing.Size(321, 29);
            this.maxDescriptionLabel.TabIndex = 27;
            this.maxDescriptionLabel.Text = "Спорт и постоянная физ. нагрузка";
            // 
            // activityLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 331);
            this.ControlBox = false;
            this.Controls.Add(this.maxDescriptionLabel);
            this.Controls.Add(this.hardDescriptionLabel);
            this.Controls.Add(this.normalDescriptionLabel);
            this.Controls.Add(this.littleDescriptionLabel);
            this.Controls.Add(this.sitDescriptionLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.hardLabel);
            this.Controls.Add(this.normalLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.sitLabel);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.MaximumSize = new System.Drawing.Size(677, 370);
            this.MinimumSize = new System.Drawing.Size(677, 370);
            this.Name = "activityLevelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox exitPictureBox;
        public System.Windows.Forms.Label descriptionLabel;
        public System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.Label sitLabel;
        public System.Windows.Forms.Label minLabel;
        public System.Windows.Forms.Label normalLabel;
        public System.Windows.Forms.Label hardLabel;
        public System.Windows.Forms.Label maxLabel;
        public System.Windows.Forms.Label sitDescriptionLabel;
        public System.Windows.Forms.Label littleDescriptionLabel;
        public System.Windows.Forms.Label normalDescriptionLabel;
        public System.Windows.Forms.Label hardDescriptionLabel;
        public System.Windows.Forms.Label maxDescriptionLabel;
    }
}