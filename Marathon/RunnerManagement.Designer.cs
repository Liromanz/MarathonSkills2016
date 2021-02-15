
namespace Marathon
{
    partial class runnerManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(runnerManagementForm));
            this.editProfileButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.startLabel = new System.Windows.Forms.Label();
            this.packLabel = new System.Windows.Forms.Label();
            this.payLabel = new System.Windows.Forms.Label();
            this.regLabel = new System.Windows.Forms.Label();
            this.startPictureBox = new System.Windows.Forms.PictureBox();
            this.packagePictureBox = new System.Windows.Forms.PictureBox();
            this.payPictureBox = new System.Windows.Forms.PictureBox();
            this.regPictureBox = new System.Windows.Forms.PictureBox();
            this.linePanel = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.certificateButton = new System.Windows.Forms.Button();
            this.emailUserLabel = new System.Windows.Forms.Label();
            this.nameUserLabel = new System.Windows.Forms.Label();
            this.lastNameUserLabel = new System.Windows.Forms.Label();
            this.genderUserLabel = new System.Windows.Forms.Label();
            this.dateUserLabel = new System.Windows.Forms.Label();
            this.countryUserLabel = new System.Windows.Forms.Label();
            this.orgUserLabel = new System.Windows.Forms.Label();
            this.moneyUserLabel = new System.Windows.Forms.Label();
            this.packageUserLabel = new System.Windows.Forms.Label();
            this.packageLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.orgLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.upPanel = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.downPanel = new System.Windows.Forms.Panel();
            this.runnerLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.startPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.upPanel.SuspendLayout();
            this.downPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // editProfileButton
            // 
            this.editProfileButton.Font = new System.Drawing.Font("Arial", 14.25F);
            this.editProfileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.editProfileButton.Location = new System.Drawing.Point(651, 491);
            this.editProfileButton.Name = "editProfileButton";
            this.editProfileButton.Size = new System.Drawing.Size(161, 53);
            this.editProfileButton.TabIndex = 73;
            this.editProfileButton.Text = "Редактирование профиля";
            this.editProfileButton.UseVisualStyleBackColor = true;
            this.editProfileButton.Click += new System.EventHandler(this.editProfileButton_Click);
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Arial", 14.25F);
            this.printButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.printButton.Location = new System.Drawing.Point(340, 491);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(216, 53);
            this.printButton.TabIndex = 72;
            this.printButton.Text = "Печать бейджа";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.startLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.startLabel.Location = new System.Drawing.Point(600, 390);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(148, 22);
            this.startLabel.TabIndex = 71;
            this.startLabel.Text = "Вышел на старт";
            this.startLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // packLabel
            // 
            this.packLabel.AutoSize = true;
            this.packLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.packLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.packLabel.Location = new System.Drawing.Point(619, 328);
            this.packLabel.Name = "packLabel";
            this.packLabel.Size = new System.Drawing.Size(118, 22);
            this.packLabel.TabIndex = 70;
            this.packLabel.Text = "Выдан пакет";
            this.packLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // payLabel
            // 
            this.payLabel.AutoSize = true;
            this.payLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.payLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.payLabel.Location = new System.Drawing.Point(600, 238);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(137, 44);
            this.payLabel.TabIndex = 69;
            this.payLabel.Text = "Оплата\r\nподтверждена";
            this.payLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.regLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.regLabel.Location = new System.Drawing.Point(589, 176);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(162, 22);
            this.regLabel.TabIndex = 68;
            this.regLabel.Text = "Зарегестрирован";
            this.regLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startPictureBox
            // 
            this.startPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("startPictureBox.Image")));
            this.startPictureBox.Location = new System.Drawing.Point(757, 376);
            this.startPictureBox.Name = "startPictureBox";
            this.startPictureBox.Size = new System.Drawing.Size(55, 53);
            this.startPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.startPictureBox.TabIndex = 67;
            this.startPictureBox.TabStop = false;
            // 
            // packagePictureBox
            // 
            this.packagePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("packagePictureBox.Image")));
            this.packagePictureBox.Location = new System.Drawing.Point(757, 307);
            this.packagePictureBox.Name = "packagePictureBox";
            this.packagePictureBox.Size = new System.Drawing.Size(55, 53);
            this.packagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.packagePictureBox.TabIndex = 66;
            this.packagePictureBox.TabStop = false;
            // 
            // payPictureBox
            // 
            this.payPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("payPictureBox.Image")));
            this.payPictureBox.Location = new System.Drawing.Point(757, 238);
            this.payPictureBox.Name = "payPictureBox";
            this.payPictureBox.Size = new System.Drawing.Size(55, 53);
            this.payPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.payPictureBox.TabIndex = 65;
            this.payPictureBox.TabStop = false;
            // 
            // regPictureBox
            // 
            this.regPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("regPictureBox.Image")));
            this.regPictureBox.Location = new System.Drawing.Point(757, 163);
            this.regPictureBox.Name = "regPictureBox";
            this.regPictureBox.Size = new System.Drawing.Size(55, 53);
            this.regPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.regPictureBox.TabIndex = 64;
            this.regPictureBox.TabStop = false;
            // 
            // linePanel
            // 
            this.linePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.linePanel.Location = new System.Drawing.Point(780, 147);
            this.linePanel.Name = "linePanel";
            this.linePanel.Size = new System.Drawing.Size(10, 298);
            this.linePanel.TabIndex = 63;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.statusLabel.Location = new System.Drawing.Point(647, 116);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(165, 44);
            this.statusLabel.TabIndex = 62;
            this.statusLabel.Text = "Регистрационный\r\nстатус";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userPictureBox
            // 
            this.userPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.userPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPictureBox.Location = new System.Drawing.Point(370, 169);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(161, 222);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 61;
            this.userPictureBox.TabStop = false;
            // 
            // certificateButton
            // 
            this.certificateButton.Font = new System.Drawing.Font("Arial", 14.25F);
            this.certificateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.certificateButton.Location = new System.Drawing.Point(43, 491);
            this.certificateButton.Name = "certificateButton";
            this.certificateButton.Size = new System.Drawing.Size(148, 53);
            this.certificateButton.TabIndex = 39;
            this.certificateButton.Text = "Показ\r\nСертификата";
            this.certificateButton.UseVisualStyleBackColor = true;
            this.certificateButton.Click += new System.EventHandler(this.certificateButton_Click);
            // 
            // emailUserLabel
            // 
            this.emailUserLabel.AutoSize = true;
            this.emailUserLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.emailUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.emailUserLabel.Location = new System.Drawing.Point(196, 147);
            this.emailUserLabel.Name = "emailUserLabel";
            this.emailUserLabel.Size = new System.Drawing.Size(55, 22);
            this.emailUserLabel.TabIndex = 59;
            this.emailUserLabel.Text = "email";
            // 
            // nameUserLabel
            // 
            this.nameUserLabel.AutoSize = true;
            this.nameUserLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.nameUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.nameUserLabel.Location = new System.Drawing.Point(194, 178);
            this.nameUserLabel.Name = "nameUserLabel";
            this.nameUserLabel.Size = new System.Drawing.Size(47, 22);
            this.nameUserLabel.TabIndex = 58;
            this.nameUserLabel.Text = "Имя";
            // 
            // lastNameUserLabel
            // 
            this.lastNameUserLabel.AutoSize = true;
            this.lastNameUserLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lastNameUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lastNameUserLabel.Location = new System.Drawing.Point(192, 207);
            this.lastNameUserLabel.Name = "lastNameUserLabel";
            this.lastNameUserLabel.Size = new System.Drawing.Size(87, 22);
            this.lastNameUserLabel.TabIndex = 57;
            this.lastNameUserLabel.Text = "Фамилия";
            // 
            // genderUserLabel
            // 
            this.genderUserLabel.AutoSize = true;
            this.genderUserLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.genderUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.genderUserLabel.Location = new System.Drawing.Point(194, 238);
            this.genderUserLabel.Name = "genderUserLabel";
            this.genderUserLabel.Size = new System.Drawing.Size(85, 22);
            this.genderUserLabel.TabIndex = 56;
            this.genderUserLabel.Text = "мужской";
            // 
            // dateUserLabel
            // 
            this.dateUserLabel.AutoSize = true;
            this.dateUserLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.dateUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dateUserLabel.Location = new System.Drawing.Point(194, 269);
            this.dateUserLabel.Name = "dateUserLabel";
            this.dateUserLabel.Size = new System.Drawing.Size(142, 22);
            this.dateUserLabel.TabIndex = 55;
            this.dateUserLabel.Text = "дата рождения";
            // 
            // countryUserLabel
            // 
            this.countryUserLabel.AutoSize = true;
            this.countryUserLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.countryUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.countryUserLabel.Location = new System.Drawing.Point(192, 301);
            this.countryUserLabel.Name = "countryUserLabel";
            this.countryUserLabel.Size = new System.Drawing.Size(87, 22);
            this.countryUserLabel.TabIndex = 54;
            this.countryUserLabel.Text = "Germany";
            // 
            // orgUserLabel
            // 
            this.orgUserLabel.AutoSize = true;
            this.orgUserLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.orgUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.orgUserLabel.Location = new System.Drawing.Point(192, 330);
            this.orgUserLabel.Name = "orgUserLabel";
            this.orgUserLabel.Size = new System.Drawing.Size(136, 22);
            this.orgUserLabel.TabIndex = 53;
            this.orgUserLabel.Text = "наименование";
            // 
            // moneyUserLabel
            // 
            this.moneyUserLabel.AutoSize = true;
            this.moneyUserLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.moneyUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.moneyUserLabel.Location = new System.Drawing.Point(192, 359);
            this.moneyUserLabel.Name = "moneyUserLabel";
            this.moneyUserLabel.Size = new System.Drawing.Size(54, 22);
            this.moneyUserLabel.TabIndex = 52;
            this.moneyUserLabel.Text = "$500";
            // 
            // packageUserLabel
            // 
            this.packageUserLabel.AutoSize = true;
            this.packageUserLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.packageUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.packageUserLabel.Location = new System.Drawing.Point(189, 390);
            this.packageUserLabel.Name = "packageUserLabel";
            this.packageUserLabel.Size = new System.Drawing.Size(100, 22);
            this.packageUserLabel.TabIndex = 51;
            this.packageUserLabel.Text = "Вариант B";
            // 
            // packageLabel
            // 
            this.packageLabel.AutoSize = true;
            this.packageLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.packageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.packageLabel.Location = new System.Drawing.Point(21, 390);
            this.packageLabel.Name = "packageLabel";
            this.packageLabel.Size = new System.Drawing.Size(168, 22);
            this.packageLabel.TabIndex = 50;
            this.packageLabel.Text = "Выбранный пакет:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nameLabel.Location = new System.Drawing.Point(137, 178);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 22);
            this.nameLabel.TabIndex = 49;
            this.nameLabel.Text = "Имя:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lastNameLabel.Location = new System.Drawing.Point(97, 207);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(92, 22);
            this.lastNameLabel.TabIndex = 48;
            this.lastNameLabel.Text = "Фамилия:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.genderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.genderLabel.Location = new System.Drawing.Point(139, 238);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(49, 22);
            this.genderLabel.TabIndex = 47;
            this.genderLabel.Text = "Пол:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dateLabel.Location = new System.Drawing.Point(39, 269);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(149, 22);
            this.dateLabel.TabIndex = 46;
            this.dateLabel.Text = "Дата рождения:";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.countryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.countryLabel.Location = new System.Drawing.Point(111, 301);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(78, 22);
            this.countryLabel.TabIndex = 45;
            this.countryLabel.Text = "Страна:";
            // 
            // orgLabel
            // 
            this.orgLabel.AutoSize = true;
            this.orgLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.orgLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.orgLabel.Location = new System.Drawing.Point(63, 330);
            this.orgLabel.Name = "orgLabel";
            this.orgLabel.Size = new System.Drawing.Size(126, 22);
            this.orgLabel.TabIndex = 44;
            this.orgLabel.Text = "Благотворит.:";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.moneyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.moneyLabel.Location = new System.Drawing.Point(44, 359);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(145, 22);
            this.moneyLabel.TabIndex = 43;
            this.moneyLabel.Text = "Пожертвовано:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.emailLabel.Location = new System.Drawing.Point(129, 147);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(62, 22);
            this.emailLabel.TabIndex = 41;
            this.emailLabel.Text = "Email:";
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
            this.upPanel.TabIndex = 74;
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
            // downPanel
            // 
            this.downPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.downPanel.Controls.Add(this.timerLabel);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 565);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(850, 60);
            this.downPanel.TabIndex = 75;
            // 
            // runnerLabel
            // 
            this.runnerLabel.AutoSize = true;
            this.runnerLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runnerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.runnerLabel.Location = new System.Drawing.Point(300, 86);
            this.runnerLabel.Name = "runnerLabel";
            this.runnerLabel.Size = new System.Drawing.Size(292, 33);
            this.runnerLabel.TabIndex = 68;
            this.runnerLabel.Text = "Управление бегуном";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // runnerManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 625);
            this.Controls.Add(this.regPictureBox);
            this.Controls.Add(this.runnerLabel);
            this.Controls.Add(this.upPanel);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.editProfileButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.packLabel);
            this.Controls.Add(this.payLabel);
            this.Controls.Add(this.regLabel);
            this.Controls.Add(this.startPictureBox);
            this.Controls.Add(this.packagePictureBox);
            this.Controls.Add(this.payPictureBox);
            this.Controls.Add(this.linePanel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.userPictureBox);
            this.Controls.Add(this.certificateButton);
            this.Controls.Add(this.emailUserLabel);
            this.Controls.Add(this.nameUserLabel);
            this.Controls.Add(this.lastNameUserLabel);
            this.Controls.Add(this.genderUserLabel);
            this.Controls.Add(this.dateUserLabel);
            this.Controls.Add(this.countryUserLabel);
            this.Controls.Add(this.orgUserLabel);
            this.Controls.Add(this.moneyUserLabel);
            this.Controls.Add(this.packageUserLabel);
            this.Controls.Add(this.packageLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.orgLabel);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.emailLabel);
            this.MaximumSize = new System.Drawing.Size(866, 664);
            this.MinimumSize = new System.Drawing.Size(866, 664);
            this.Name = "runnerManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - Manage a runner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.runnerManagementForm_FormClosing);
            this.Load += new System.EventHandler(this.runnerManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            this.downPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editProfileButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label packLabel;
        private System.Windows.Forms.Label payLabel;
        private System.Windows.Forms.Label regLabel;
        private System.Windows.Forms.PictureBox startPictureBox;
        private System.Windows.Forms.PictureBox packagePictureBox;
        private System.Windows.Forms.PictureBox payPictureBox;
        private System.Windows.Forms.PictureBox regPictureBox;
        private System.Windows.Forms.Panel linePanel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Button certificateButton;
        private System.Windows.Forms.Label nameUserLabel;
        private System.Windows.Forms.Label lastNameUserLabel;
        private System.Windows.Forms.Label genderUserLabel;
        private System.Windows.Forms.Label dateUserLabel;
        private System.Windows.Forms.Label countryUserLabel;
        private System.Windows.Forms.Label orgUserLabel;
        private System.Windows.Forms.Label moneyUserLabel;
        private System.Windows.Forms.Label packageUserLabel;
        private System.Windows.Forms.Label packageLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label orgLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Label runnerLabel;
        public System.Windows.Forms.Label emailUserLabel;
        private System.Windows.Forms.Timer timer;
    }
}