
namespace Marathon
{
    partial class certificateForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(certificateForm));
            this.logoutButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.upPanel = new System.Windows.Forms.Panel();
            this.downPanel = new System.Windows.Forms.Panel();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.marathonLabel = new System.Windows.Forms.Label();
            this.inLabel = new System.Windows.Forms.Label();
            this.certificateLabel = new System.Windows.Forms.Label();
            this.congratulationsLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.grayPanel = new System.Windows.Forms.Panel();
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.raceLabel = new System.Windows.Forms.Label();
            this.apprivePictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.okPanek = new System.Windows.Forms.Panel();
            this.notOkPanel = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.upPanel.SuspendLayout();
            this.downPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.grayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apprivePictureBox)).BeginInit();
            this.okPanek.SuspendLayout();
            this.notOkPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.logoutButton.Location = new System.Drawing.Point(757, 15);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(81, 39);
            this.logoutButton.TabIndex = 67;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.backButton.Location = new System.Drawing.Point(12, 15);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(81, 39);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.headerLabel.Location = new System.Drawing.Point(117, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(386, 45);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Marathon Skills 2021";
            // 
            // timerLabel
            // 
            this.timerLabel.Font = new System.Drawing.Font("Arial", 20.25F);
            this.timerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.timerLabel.Location = new System.Drawing.Point(12, 14);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(826, 32);
            this.timerLabel.TabIndex = 41;
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upPanel
            // 
            this.upPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.upPanel.Controls.Add(this.logoutButton);
            this.upPanel.Controls.Add(this.backButton);
            this.upPanel.Controls.Add(this.headerLabel);
            this.upPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upPanel.Location = new System.Drawing.Point(0, 0);
            this.upPanel.Name = "upPanel";
            this.upPanel.Size = new System.Drawing.Size(850, 69);
            this.upPanel.TabIndex = 76;
            // 
            // downPanel
            // 
            this.downPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.downPanel.Controls.Add(this.timerLabel);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 565);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(850, 60);
            this.downPanel.TabIndex = 77;
            // 
            // moneyLabel
            // 
            this.moneyLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.moneyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.moneyLabel.Location = new System.Drawing.Point(192, 355);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.moneyLabel.Size = new System.Drawing.Size(483, 44);
            this.moneyLabel.TabIndex = 75;
            this.moneyLabel.Text = "Вы также заработали $1500 \r\nдля вашей благотворительной организации!";
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cityLabel
            // 
            this.cityLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cityLabel.Location = new System.Drawing.Point(229, 301);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(400, 24);
            this.cityLabel.TabIndex = 74;
            this.cityLabel.Text = "Osaka, Japan";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // marathonLabel
            // 
            this.marathonLabel.Font = new System.Drawing.Font("Arial", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marathonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.marathonLabel.Location = new System.Drawing.Point(224, 262);
            this.marathonLabel.Name = "marathonLabel";
            this.marathonLabel.Size = new System.Drawing.Size(419, 30);
            this.marathonLabel.TabIndex = 73;
            this.marathonLabel.Text = "Marathon Skills 2014";
            this.marathonLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inLabel
            // 
            this.inLabel.AutoSize = true;
            this.inLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.inLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.inLabel.Location = new System.Drawing.Point(417, 229);
            this.inLabel.Name = "inLabel";
            this.inLabel.Size = new System.Drawing.Size(20, 22);
            this.inLabel.TabIndex = 72;
            this.inLabel.Text = "в";
            // 
            // certificateLabel
            // 
            this.certificateLabel.AutoSize = true;
            this.certificateLabel.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.certificateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.certificateLabel.Location = new System.Drawing.Point(217, 178);
            this.certificateLabel.Name = "certificateLabel";
            this.certificateLabel.Size = new System.Drawing.Size(412, 41);
            this.certificateLabel.TabIndex = 71;
            this.certificateLabel.Text = "Сертификат участника";
            // 
            // congratulationsLabel
            // 
            this.congratulationsLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.congratulationsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.congratulationsLabel.Location = new System.Drawing.Point(87, 121);
            this.congratulationsLabel.Name = "congratulationsLabel";
            this.congratulationsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.congratulationsLabel.Size = new System.Drawing.Size(648, 57);
            this.congratulationsLabel.TabIndex = 70;
            this.congratulationsLabel.Text = "Поздравляем Имя Фамилия с участием в 42km Полном марафоне. Ваши результаты время " +
    "4:32:15 и занятое место 183rd!";
            this.congratulationsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Location = new System.Drawing.Point(306, 2);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(240, 89);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 69;
            this.logoPictureBox.TabStop = false;
            // 
            // grayPanel
            // 
            this.grayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.grayPanel.Controls.Add(this.raceComboBox);
            this.grayPanel.Controls.Add(this.raceLabel);
            this.grayPanel.Location = new System.Drawing.Point(0, 60);
            this.grayPanel.Name = "grayPanel";
            this.grayPanel.Size = new System.Drawing.Size(850, 70);
            this.grayPanel.TabIndex = 68;
            // 
            // raceComboBox
            // 
            this.raceComboBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.raceComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.raceComboBox.FormattingEnabled = true;
            this.raceComboBox.Location = new System.Drawing.Point(382, 27);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(231, 30);
            this.raceComboBox.TabIndex = 30;
            this.raceComboBox.Text = "42km Полный марафон";
            this.raceComboBox.SelectedIndexChanged += new System.EventHandler(this.raceComboBox_SelectedIndexChanged);
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.raceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.raceLabel.Location = new System.Drawing.Point(258, 30);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(108, 22);
            this.raceLabel.TabIndex = 6;
            this.raceLabel.Text = "RaceEvent:";
            // 
            // apprivePictureBox
            // 
            this.apprivePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("apprivePictureBox.Image")));
            this.apprivePictureBox.Location = new System.Drawing.Point(681, 276);
            this.apprivePictureBox.Name = "apprivePictureBox";
            this.apprivePictureBox.Size = new System.Drawing.Size(142, 123);
            this.apprivePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.apprivePictureBox.TabIndex = 78;
            this.apprivePictureBox.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // okPanek
            // 
            this.okPanek.Controls.Add(this.apprivePictureBox);
            this.okPanek.Controls.Add(this.moneyLabel);
            this.okPanek.Controls.Add(this.congratulationsLabel);
            this.okPanek.Controls.Add(this.cityLabel);
            this.okPanek.Controls.Add(this.logoPictureBox);
            this.okPanek.Controls.Add(this.certificateLabel);
            this.okPanek.Controls.Add(this.inLabel);
            this.okPanek.Controls.Add(this.marathonLabel);
            this.okPanek.Location = new System.Drawing.Point(12, 147);
            this.okPanek.Name = "okPanek";
            this.okPanek.Size = new System.Drawing.Size(826, 402);
            this.okPanek.TabIndex = 79;
            // 
            // notOkPanel
            // 
            this.notOkPanel.Controls.Add(this.errorLabel);
            this.notOkPanel.Location = new System.Drawing.Point(12, 144);
            this.notOkPanel.Name = "notOkPanel";
            this.notOkPanel.Size = new System.Drawing.Size(826, 402);
            this.notOkPanel.TabIndex = 80;
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold);
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.errorLabel.Location = new System.Drawing.Point(0, 149);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(823, 98);
            this.errorLabel.TabIndex = 0;
            this.errorLabel.Text = "Бегун не принимал участия в марафоне такого типа";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // certificateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 625);
            this.Controls.Add(this.notOkPanel);
            this.Controls.Add(this.upPanel);
            this.Controls.Add(this.grayPanel);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.okPanek);
            this.MaximumSize = new System.Drawing.Size(866, 664);
            this.MinimumSize = new System.Drawing.Size(866, 664);
            this.Name = "certificateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - Certificate preview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.certificateForm_FormClosing);
            this.Load += new System.EventHandler(this.certificateForm_Load);
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            this.downPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.grayPanel.ResumeLayout(false);
            this.grayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apprivePictureBox)).EndInit();
            this.okPanek.ResumeLayout(false);
            this.okPanek.PerformLayout();
            this.notOkPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label marathonLabel;
        private System.Windows.Forms.Label inLabel;
        private System.Windows.Forms.Label certificateLabel;
        private System.Windows.Forms.Label congratulationsLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Panel grayPanel;
        private System.Windows.Forms.ComboBox raceComboBox;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.PictureBox apprivePictureBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel okPanek;
        private System.Windows.Forms.Panel notOkPanel;
        private System.Windows.Forms.Label errorLabel;
    }
}