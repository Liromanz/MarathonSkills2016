
namespace Marathon
{
    partial class eventRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eventRegistrationForm));
            this.upPanel = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.downPanel = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.variationLabel = new System.Windows.Forms.Label();
            this.fullCheckBox = new System.Windows.Forms.CheckBox();
            this.halfCheckBox = new System.Windows.Forms.CheckBox();
            this.littleCheckBox = new System.Windows.Forms.CheckBox();
            this.varARadioButton = new System.Windows.Forms.RadioButton();
            this.registerFeeLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.varALabel = new System.Windows.Forms.Label();
            this.varBRadioButton = new System.Windows.Forms.RadioButton();
            this.varBLabel = new System.Windows.Forms.Label();
            this.varCRadioButton = new System.Windows.Forms.RadioButton();
            this.varCLabel = new System.Windows.Forms.Label();
            this.detailLabel = new System.Windows.Forms.Label();
            this.foundationComboBox = new System.Windows.Forms.ComboBox();
            this.moneyTextBox = new System.Windows.Forms.MaskedTextBox();
            this.feeLabel = new System.Windows.Forms.Label();
            this.feeAmountLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.infoPictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.upPanel.SuspendLayout();
            this.downPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.upPanel.TabIndex = 29;
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.logoutButton.Location = new System.Drawing.Point(757, 15);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(81, 39);
            this.logoutButton.TabIndex = 2;
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
            // downPanel
            // 
            this.downPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.downPanel.Controls.Add(this.timerLabel);
            this.downPanel.Location = new System.Drawing.Point(0, 565);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(850, 60);
            this.downPanel.TabIndex = 30;
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
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.descriptionLabel.Location = new System.Drawing.Point(87, 148);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(689, 66);
            this.descriptionLabel.TabIndex = 30;
            this.descriptionLabel.Text = "Пожалуйста заполните всю информацию, чтобы зарегистрироваться на Skills\r\nMarathon" +
    " 2021 проводимом в Москве. Russia. С вам свяжутся после\r\nрегистрации для уточнен" +
    "ия оплаты и другой информации.\r\n";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.registerLabel.Location = new System.Drawing.Point(212, 96);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(452, 42);
            this.registerLabel.TabIndex = 29;
            this.registerLabel.Text = "Регистрация на марафон";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.typeLabel.Location = new System.Drawing.Point(107, 231);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(216, 33);
            this.typeLabel.TabIndex = 31;
            this.typeLabel.Text = "Вид марафона";
            // 
            // variationLabel
            // 
            this.variationLabel.AutoSize = true;
            this.variationLabel.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.variationLabel.Location = new System.Drawing.Point(481, 231);
            this.variationLabel.Name = "variationLabel";
            this.variationLabel.Size = new System.Drawing.Size(316, 33);
            this.variationLabel.TabIndex = 32;
            this.variationLabel.Text = "Варианты комплектов";
            // 
            // fullCheckBox
            // 
            this.fullCheckBox.AutoSize = true;
            this.fullCheckBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.fullCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.fullCheckBox.Location = new System.Drawing.Point(67, 278);
            this.fullCheckBox.Name = "fullCheckBox";
            this.fullCheckBox.Size = new System.Drawing.Size(296, 26);
            this.fullCheckBox.TabIndex = 33;
            this.fullCheckBox.Text = "42km Полный марафон ($145)";
            this.fullCheckBox.UseVisualStyleBackColor = true;
            this.fullCheckBox.CheckedChanged += new System.EventHandler(this.fullCheckBox_CheckedChanged);
            // 
            // halfCheckBox
            // 
            this.halfCheckBox.AutoSize = true;
            this.halfCheckBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.halfCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.halfCheckBox.Location = new System.Drawing.Point(67, 310);
            this.halfCheckBox.Name = "halfCheckBox";
            this.halfCheckBox.Size = new System.Drawing.Size(255, 26);
            this.halfCheckBox.TabIndex = 34;
            this.halfCheckBox.Text = "21km Полумарафон ($75)";
            this.halfCheckBox.UseVisualStyleBackColor = true;
            this.halfCheckBox.CheckedChanged += new System.EventHandler(this.halfCheckBox_CheckedChanged);
            // 
            // littleCheckBox
            // 
            this.littleCheckBox.AutoSize = true;
            this.littleCheckBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.littleCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.littleCheckBox.Location = new System.Drawing.Point(67, 342);
            this.littleCheckBox.Name = "littleCheckBox";
            this.littleCheckBox.Size = new System.Drawing.Size(270, 26);
            this.littleCheckBox.TabIndex = 35;
            this.littleCheckBox.Text = "5km Малая дистанция ($20)";
            this.littleCheckBox.UseVisualStyleBackColor = true;
            this.littleCheckBox.CheckedChanged += new System.EventHandler(this.littleCheckBox_CheckedChanged);
            // 
            // varARadioButton
            // 
            this.varARadioButton.AutoSize = true;
            this.varARadioButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.varARadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.varARadioButton.Location = new System.Drawing.Point(487, 271);
            this.varARadioButton.Name = "varARadioButton";
            this.varARadioButton.Size = new System.Drawing.Size(172, 26);
            this.varARadioButton.TabIndex = 36;
            this.varARadioButton.TabStop = true;
            this.varARadioButton.Text = "Вариант А($0): ";
            this.varARadioButton.UseVisualStyleBackColor = true;
            this.varARadioButton.CheckedChanged += new System.EventHandler(this.varARadioButton_CheckedChanged);
            // 
            // registerFeeLabel
            // 
            this.registerFeeLabel.AutoSize = true;
            this.registerFeeLabel.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.registerFeeLabel.Location = new System.Drawing.Point(464, 437);
            this.registerFeeLabel.Name = "registerFeeLabel";
            this.registerFeeLabel.Size = new System.Drawing.Size(348, 33);
            this.registerFeeLabel.TabIndex = 39;
            this.registerFeeLabel.Text = "Регистрационный взнос";
            // 
            // moneyLabel
            // 
            this.moneyLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.moneyLabel.Location = new System.Drawing.Point(470, 470);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(329, 56);
            this.moneyLabel.TabIndex = 40;
            this.moneyLabel.Text = "0$";
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // varALabel
            // 
            this.varALabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.varALabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.varALabel.Location = new System.Drawing.Point(505, 273);
            this.varALabel.Name = "varALabel";
            this.varALabel.Size = new System.Drawing.Size(307, 48);
            this.varALabel.TabIndex = 41;
            this.varALabel.Text = "                              Номер бегуна + RFID браслет.";
            // 
            // varBRadioButton
            // 
            this.varBRadioButton.AutoSize = true;
            this.varBRadioButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.varBRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.varBRadioButton.Location = new System.Drawing.Point(487, 319);
            this.varBRadioButton.Name = "varBRadioButton";
            this.varBRadioButton.Size = new System.Drawing.Size(184, 26);
            this.varBRadioButton.TabIndex = 42;
            this.varBRadioButton.TabStop = true;
            this.varBRadioButton.Text = "Вариант В($20): ";
            this.varBRadioButton.UseVisualStyleBackColor = true;
            this.varBRadioButton.CheckedChanged += new System.EventHandler(this.varBRadioButton_CheckedChanged);
            // 
            // varBLabel
            // 
            this.varBLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.varBLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.varBLabel.Location = new System.Drawing.Point(505, 321);
            this.varBLabel.Name = "varBLabel";
            this.varBLabel.Size = new System.Drawing.Size(307, 48);
            this.varBLabel.TabIndex = 43;
            this.varBLabel.Text = "                                 вариант А + бейсболка + бутылка воды.\r\n";
            // 
            // varCRadioButton
            // 
            this.varCRadioButton.AutoSize = true;
            this.varCRadioButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.varCRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.varCRadioButton.Location = new System.Drawing.Point(487, 367);
            this.varCRadioButton.Name = "varCRadioButton";
            this.varCRadioButton.Size = new System.Drawing.Size(184, 26);
            this.varCRadioButton.TabIndex = 44;
            this.varCRadioButton.TabStop = true;
            this.varCRadioButton.Text = "Вариант С($45): ";
            this.varCRadioButton.UseVisualStyleBackColor = true;
            this.varCRadioButton.CheckedChanged += new System.EventHandler(this.varCRadioButton_CheckedChanged);
            // 
            // varCLabel
            // 
            this.varCLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.varCLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.varCLabel.Location = new System.Drawing.Point(505, 369);
            this.varCLabel.Name = "varCLabel";
            this.varCLabel.Size = new System.Drawing.Size(307, 48);
            this.varCLabel.TabIndex = 45;
            this.varCLabel.Text = "                                 Вариант В +футболка + сувенирный буклет\r\n.";
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.detailLabel.Location = new System.Drawing.Point(70, 393);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(293, 33);
            this.detailLabel.TabIndex = 46;
            this.detailLabel.Text = "Детали спонсорства";
            // 
            // foundationComboBox
            // 
            this.foundationComboBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.foundationComboBox.FormattingEnabled = true;
            this.foundationComboBox.Location = new System.Drawing.Point(157, 442);
            this.foundationComboBox.Name = "foundationComboBox";
            this.foundationComboBox.Size = new System.Drawing.Size(224, 30);
            this.foundationComboBox.TabIndex = 47;
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.moneyTextBox.Location = new System.Drawing.Point(157, 478);
            this.moneyTextBox.Mask = "0000";
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(224, 29);
            this.moneyTextBox.TabIndex = 48;
            this.moneyTextBox.Text = "500";
            this.moneyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.moneyTextBox.TextChanged += new System.EventHandler(this.moneyTextBox_TextChanged);
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.feeLabel.Location = new System.Drawing.Point(83, 445);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(68, 22);
            this.feeLabel.TabIndex = 49;
            this.feeLabel.Text = "Взнос:";
            // 
            // feeAmountLabel
            // 
            this.feeAmountLabel.AutoSize = true;
            this.feeAmountLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feeAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.feeAmountLabel.Location = new System.Drawing.Point(12, 481);
            this.feeAmountLabel.Name = "feeAmountLabel";
            this.feeAmountLabel.Size = new System.Drawing.Size(139, 22);
            this.feeAmountLabel.TabIndex = 50;
            this.feeAmountLabel.Text = "Сумма взноса:";
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.registerButton.Location = new System.Drawing.Point(67, 513);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(139, 30);
            this.registerButton.TabIndex = 52;
            this.registerButton.Text = "Регистрация";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cancelButton.Location = new System.Drawing.Point(212, 513);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 30);
            this.cancelButton.TabIndex = 53;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // infoPictureBox
            // 
            this.infoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("infoPictureBox.Image")));
            this.infoPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("infoPictureBox.InitialImage")));
            this.infoPictureBox.Location = new System.Drawing.Point(396, 445);
            this.infoPictureBox.Name = "infoPictureBox";
            this.infoPictureBox.Size = new System.Drawing.Size(24, 22);
            this.infoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoPictureBox.TabIndex = 51;
            this.infoPictureBox.TabStop = false;
            this.infoPictureBox.Click += new System.EventHandler(this.infoPictureBox_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // eventRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 625);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.infoPictureBox);
            this.Controls.Add(this.feeAmountLabel);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.moneyTextBox);
            this.Controls.Add(this.foundationComboBox);
            this.Controls.Add(this.detailLabel);
            this.Controls.Add(this.varCRadioButton);
            this.Controls.Add(this.varCLabel);
            this.Controls.Add(this.varBRadioButton);
            this.Controls.Add(this.varBLabel);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.registerFeeLabel);
            this.Controls.Add(this.varARadioButton);
            this.Controls.Add(this.littleCheckBox);
            this.Controls.Add(this.halfCheckBox);
            this.Controls.Add(this.fullCheckBox);
            this.Controls.Add(this.variationLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.upPanel);
            this.Controls.Add(this.varALabel);
            this.Name = "eventRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - Register for an event";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.eventRegistrationForm_FormClosing);
            this.Load += new System.EventHandler(this.eventRegistrationForm_Load);
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            this.downPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label variationLabel;
        private System.Windows.Forms.CheckBox fullCheckBox;
        private System.Windows.Forms.CheckBox halfCheckBox;
        private System.Windows.Forms.CheckBox littleCheckBox;
        private System.Windows.Forms.RadioButton varARadioButton;
        private System.Windows.Forms.Label registerFeeLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label varALabel;
        private System.Windows.Forms.RadioButton varBRadioButton;
        private System.Windows.Forms.Label varBLabel;
        private System.Windows.Forms.RadioButton varCRadioButton;
        private System.Windows.Forms.Label varCLabel;
        private System.Windows.Forms.Label detailLabel;
        private System.Windows.Forms.ComboBox foundationComboBox;
        private System.Windows.Forms.MaskedTextBox moneyTextBox;
        private System.Windows.Forms.Label feeLabel;
        private System.Windows.Forms.Label feeAmountLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox infoPictureBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timerLabel;
    }
}