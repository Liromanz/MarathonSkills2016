
namespace Marathon
{
    partial class BMRCalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMRCalculatorForm));
            this.maleLabel = new System.Windows.Forms.Label();
            this.malePictureBox = new System.Windows.Forms.PictureBox();
            this.malePanel = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.femaleLabel = new System.Windows.Forms.Label();
            this.bmrLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.smLabel = new System.Windows.Forms.Label();
            this.kgLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.fatLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.downPanel = new System.Windows.Forms.Panel();
            this.heightTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fatTextBox = new System.Windows.Forms.MaskedTextBox();
            this.countButton = new System.Windows.Forms.Button();
            this.heightLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.upPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.femalePictureBox = new System.Windows.Forms.PictureBox();
            this.femalePanel = new System.Windows.Forms.Panel();
            this.yearLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.MaskedTextBox();
            this.calorieLabel = new System.Windows.Forms.Label();
            this.yourBMRLabel = new System.Windows.Forms.Label();
            this.everydayLabel = new System.Windows.Forms.Label();
            this.bmrNumberLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.bigLabel = new System.Windows.Forms.Label();
            this.normalLabel = new System.Windows.Forms.Label();
            this.lowLabel = new System.Windows.Forms.Label();
            this.sitLabel = new System.Windows.Forms.Label();
            this.sitNumberLabel = new System.Windows.Forms.Label();
            this.lowNumberLabel = new System.Windows.Forms.Label();
            this.normalNumberLabel = new System.Windows.Forms.Label();
            this.bigNumberLabel = new System.Windows.Forms.Label();
            this.maxNumberLabel = new System.Windows.Forms.Label();
            this.infoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.malePictureBox)).BeginInit();
            this.malePanel.SuspendLayout();
            this.downPanel.SuspendLayout();
            this.upPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.femalePictureBox)).BeginInit();
            this.femalePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // maleLabel
            // 
            this.maleLabel.BackColor = System.Drawing.Color.LightGray;
            this.maleLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.maleLabel.Location = new System.Drawing.Point(5, 101);
            this.maleLabel.Name = "maleLabel";
            this.maleLabel.Size = new System.Drawing.Size(123, 22);
            this.maleLabel.TabIndex = 54;
            this.maleLabel.Text = "Мужской";
            this.maleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.maleLabel.Click += new System.EventHandler(this.malePanel_Click);
            // 
            // malePictureBox
            // 
            this.malePictureBox.BackColor = System.Drawing.Color.LightGray;
            this.malePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("malePictureBox.Image")));
            this.malePictureBox.Location = new System.Drawing.Point(3, 14);
            this.malePictureBox.Name = "malePictureBox";
            this.malePictureBox.Size = new System.Drawing.Size(125, 84);
            this.malePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.malePictureBox.TabIndex = 50;
            this.malePictureBox.TabStop = false;
            this.malePictureBox.Click += new System.EventHandler(this.malePanel_Click);
            // 
            // malePanel
            // 
            this.malePanel.BackColor = System.Drawing.Color.LightGray;
            this.malePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.malePanel.Controls.Add(this.maleLabel);
            this.malePanel.Controls.Add(this.malePictureBox);
            this.malePanel.Location = new System.Drawing.Point(60, 219);
            this.malePanel.Name = "malePanel";
            this.malePanel.Size = new System.Drawing.Size(131, 125);
            this.malePanel.TabIndex = 78;
            this.malePanel.Click += new System.EventHandler(this.malePanel_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // femaleLabel
            // 
            this.femaleLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.femaleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.femaleLabel.Location = new System.Drawing.Point(3, 100);
            this.femaleLabel.Name = "femaleLabel";
            this.femaleLabel.Size = new System.Drawing.Size(123, 22);
            this.femaleLabel.TabIndex = 53;
            this.femaleLabel.Text = "Женский";
            this.femaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.femaleLabel.Click += new System.EventHandler(this.femalePanel_Click);
            // 
            // bmrLabel
            // 
            this.bmrLabel.AutoSize = true;
            this.bmrLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bmrLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bmrLabel.Location = new System.Drawing.Point(264, 93);
            this.bmrLabel.Name = "bmrLabel";
            this.bmrLabel.Size = new System.Drawing.Size(323, 42);
            this.bmrLabel.TabIndex = 67;
            this.bmrLabel.Text = "BMR калькулятор";
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
            // smLabel
            // 
            this.smLabel.AutoSize = true;
            this.smLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.smLabel.Location = new System.Drawing.Point(267, 371);
            this.smLabel.Name = "smLabel";
            this.smLabel.Size = new System.Drawing.Size(33, 22);
            this.smLabel.TabIndex = 76;
            this.smLabel.Text = "см";
            // 
            // kgLabel
            // 
            this.kgLabel.AutoSize = true;
            this.kgLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kgLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.kgLabel.Location = new System.Drawing.Point(267, 421);
            this.kgLabel.Name = "kgLabel";
            this.kgLabel.Size = new System.Drawing.Size(25, 22);
            this.kgLabel.TabIndex = 75;
            this.kgLabel.Text = "кг";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cancelButton.Location = new System.Drawing.Point(194, 504);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(131, 30);
            this.cancelButton.TabIndex = 74;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.fatLabel.Location = new System.Drawing.Point(135, 421);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(49, 22);
            this.fatLabel.TabIndex = 73;
            this.fatLabel.Text = "Вес:";
            // 
            // timerLabel
            // 
            this.timerLabel.Font = new System.Drawing.Font("Arial", 20.25F);
            this.timerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.timerLabel.Location = new System.Drawing.Point(12, 9);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(826, 32);
            this.timerLabel.TabIndex = 40;
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
            this.downPanel.TabIndex = 66;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.heightTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.heightTextBox.Location = new System.Drawing.Point(197, 368);
            this.heightTextBox.Mask = "000";
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(64, 29);
            this.heightTextBox.TabIndex = 72;
            // 
            // fatTextBox
            // 
            this.fatTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.fatTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.fatTextBox.Location = new System.Drawing.Point(197, 414);
            this.fatTextBox.Mask = "000";
            this.fatTextBox.Name = "fatTextBox";
            this.fatTextBox.Size = new System.Drawing.Size(64, 29);
            this.fatTextBox.TabIndex = 71;
            // 
            // countButton
            // 
            this.countButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.countButton.Location = new System.Drawing.Point(57, 504);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(131, 30);
            this.countButton.TabIndex = 70;
            this.countButton.Text = "Рассчитать";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.heightLabel.Location = new System.Drawing.Point(135, 371);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(56, 22);
            this.heightLabel.TabIndex = 69;
            this.heightLabel.Text = "Рост:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.descriptionLabel.Location = new System.Drawing.Point(39, 158);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(333, 44);
            this.descriptionLabel.TabIndex = 68;
            this.descriptionLabel.Text = "Информация о том, что такое BRM и\r\nкак расчитываются результаты\r\n";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // upPanel
            // 
            this.upPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.upPanel.Controls.Add(this.backButton);
            this.upPanel.Controls.Add(this.headerLabel);
            this.upPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upPanel.Location = new System.Drawing.Point(0, 0);
            this.upPanel.Name = "upPanel";
            this.upPanel.Size = new System.Drawing.Size(850, 69);
            this.upPanel.TabIndex = 65;
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
            // femalePictureBox
            // 
            this.femalePictureBox.BackColor = System.Drawing.Color.LightGray;
            this.femalePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("femalePictureBox.Image")));
            this.femalePictureBox.Location = new System.Drawing.Point(0, 13);
            this.femalePictureBox.Name = "femalePictureBox";
            this.femalePictureBox.Size = new System.Drawing.Size(130, 84);
            this.femalePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.femalePictureBox.TabIndex = 51;
            this.femalePictureBox.TabStop = false;
            this.femalePictureBox.Click += new System.EventHandler(this.femalePanel_Click);
            // 
            // femalePanel
            // 
            this.femalePanel.BackColor = System.Drawing.Color.LightGray;
            this.femalePanel.Controls.Add(this.femaleLabel);
            this.femalePanel.Controls.Add(this.femalePictureBox);
            this.femalePanel.Location = new System.Drawing.Point(197, 219);
            this.femalePanel.Name = "femalePanel";
            this.femalePanel.Size = new System.Drawing.Size(131, 125);
            this.femalePanel.TabIndex = 77;
            this.femalePanel.Click += new System.EventHandler(this.femalePanel_Click);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.yearLabel.Location = new System.Drawing.Point(267, 465);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(38, 22);
            this.yearLabel.TabIndex = 91;
            this.yearLabel.Text = "лет";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ageLabel.Location = new System.Drawing.Point(97, 465);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(87, 22);
            this.ageLabel.TabIndex = 90;
            this.ageLabel.Text = "Возраст:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.ageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ageTextBox.Location = new System.Drawing.Point(197, 458);
            this.ageTextBox.Mask = "000";
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(64, 29);
            this.ageTextBox.TabIndex = 89;
            // 
            // calorieLabel
            // 
            this.calorieLabel.AutoSize = true;
            this.calorieLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calorieLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.calorieLabel.Location = new System.Drawing.Point(496, 158);
            this.calorieLabel.Name = "calorieLabel";
            this.calorieLabel.Size = new System.Drawing.Size(326, 44);
            this.calorieLabel.TabIndex = 92;
            this.calorieLabel.Text = "Информация о показателях калорий\r\nпоказывается здесь";
            this.calorieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yourBMRLabel
            // 
            this.yourBMRLabel.AutoSize = true;
            this.yourBMRLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yourBMRLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.yourBMRLabel.Location = new System.Drawing.Point(613, 219);
            this.yourBMRLabel.Name = "yourBMRLabel";
            this.yourBMRLabel.Size = new System.Drawing.Size(94, 22);
            this.yourBMRLabel.TabIndex = 93;
            this.yourBMRLabel.Text = "Ваш BMR";
            // 
            // everydayLabel
            // 
            this.everydayLabel.AutoSize = true;
            this.everydayLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.everydayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.everydayLabel.Location = new System.Drawing.Point(536, 309);
            this.everydayLabel.Name = "everydayLabel";
            this.everydayLabel.Size = new System.Drawing.Size(191, 44);
            this.everydayLabel.TabIndex = 94;
            this.everydayLabel.Text = "Ежедневно тратится\r\nкалорий";
            this.everydayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bmrNumberLabel
            // 
            this.bmrNumberLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bmrNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bmrNumberLabel.Location = new System.Drawing.Point(500, 256);
            this.bmrNumberLabel.Name = "bmrNumberLabel";
            this.bmrNumberLabel.Size = new System.Drawing.Size(322, 42);
            this.bmrNumberLabel.TabIndex = 95;
            this.bmrNumberLabel.Text = "1,670";
            this.bmrNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxLabel
            // 
            this.maxLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.maxLabel.Location = new System.Drawing.Point(462, 502);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(245, 35);
            this.maxLabel.TabIndex = 96;
            this.maxLabel.Text = "Максимальная активность:";
            this.maxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bigLabel
            // 
            this.bigLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bigLabel.ForeColor = System.Drawing.Color.Red;
            this.bigLabel.Location = new System.Drawing.Point(462, 467);
            this.bigLabel.Name = "bigLabel";
            this.bigLabel.Size = new System.Drawing.Size(245, 35);
            this.bigLabel.TabIndex = 97;
            this.bigLabel.Text = "Сильная активность:";
            this.bigLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // normalLabel
            // 
            this.normalLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.normalLabel.Location = new System.Drawing.Point(462, 432);
            this.normalLabel.Name = "normalLabel";
            this.normalLabel.Size = new System.Drawing.Size(245, 35);
            this.normalLabel.TabIndex = 98;
            this.normalLabel.Text = "Средняя активность:";
            this.normalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lowLabel
            // 
            this.lowLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.lowLabel.Location = new System.Drawing.Point(462, 397);
            this.lowLabel.Name = "lowLabel";
            this.lowLabel.Size = new System.Drawing.Size(245, 35);
            this.lowLabel.TabIndex = 99;
            this.lowLabel.Text = "Маленькая активность:";
            this.lowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sitLabel
            // 
            this.sitLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.sitLabel.Location = new System.Drawing.Point(462, 362);
            this.sitLabel.Name = "sitLabel";
            this.sitLabel.Size = new System.Drawing.Size(245, 35);
            this.sitLabel.TabIndex = 100;
            this.sitLabel.Text = "Сидячий";
            this.sitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sitNumberLabel
            // 
            this.sitNumberLabel.Font = new System.Drawing.Font("Arial", 20.25F);
            this.sitNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.sitNumberLabel.Location = new System.Drawing.Point(713, 362);
            this.sitNumberLabel.Name = "sitNumberLabel";
            this.sitNumberLabel.Size = new System.Drawing.Size(86, 35);
            this.sitNumberLabel.TabIndex = 101;
            this.sitNumberLabel.Text = "2,004";
            this.sitNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lowNumberLabel
            // 
            this.lowNumberLabel.Font = new System.Drawing.Font("Arial", 20.25F);
            this.lowNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.lowNumberLabel.Location = new System.Drawing.Point(713, 397);
            this.lowNumberLabel.Name = "lowNumberLabel";
            this.lowNumberLabel.Size = new System.Drawing.Size(86, 35);
            this.lowNumberLabel.TabIndex = 102;
            this.lowNumberLabel.Text = "2,004";
            this.lowNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // normalNumberLabel
            // 
            this.normalNumberLabel.Font = new System.Drawing.Font("Arial", 20.25F);
            this.normalNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.normalNumberLabel.Location = new System.Drawing.Point(713, 432);
            this.normalNumberLabel.Name = "normalNumberLabel";
            this.normalNumberLabel.Size = new System.Drawing.Size(86, 35);
            this.normalNumberLabel.TabIndex = 103;
            this.normalNumberLabel.Text = "2,004";
            this.normalNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bigNumberLabel
            // 
            this.bigNumberLabel.Font = new System.Drawing.Font("Arial", 20.25F);
            this.bigNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.bigNumberLabel.Location = new System.Drawing.Point(713, 467);
            this.bigNumberLabel.Name = "bigNumberLabel";
            this.bigNumberLabel.Size = new System.Drawing.Size(86, 35);
            this.bigNumberLabel.TabIndex = 104;
            this.bigNumberLabel.Text = "2,004";
            this.bigNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxNumberLabel
            // 
            this.maxNumberLabel.Font = new System.Drawing.Font("Arial", 20.25F);
            this.maxNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.maxNumberLabel.Location = new System.Drawing.Point(713, 499);
            this.maxNumberLabel.Name = "maxNumberLabel";
            this.maxNumberLabel.Size = new System.Drawing.Size(86, 35);
            this.maxNumberLabel.TabIndex = 105;
            this.maxNumberLabel.Text = "2,004";
            this.maxNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // infoPictureBox
            // 
            this.infoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("infoPictureBox.Image")));
            this.infoPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("infoPictureBox.InitialImage")));
            this.infoPictureBox.Location = new System.Drawing.Point(746, 320);
            this.infoPictureBox.Name = "infoPictureBox";
            this.infoPictureBox.Size = new System.Drawing.Size(24, 22);
            this.infoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoPictureBox.TabIndex = 106;
            this.infoPictureBox.TabStop = false;
            this.infoPictureBox.Click += new System.EventHandler(this.infoPictureBox_Click);
            // 
            // BMRCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 625);
            this.Controls.Add(this.infoPictureBox);
            this.Controls.Add(this.maxNumberLabel);
            this.Controls.Add(this.bigNumberLabel);
            this.Controls.Add(this.normalNumberLabel);
            this.Controls.Add(this.lowNumberLabel);
            this.Controls.Add(this.sitNumberLabel);
            this.Controls.Add(this.sitLabel);
            this.Controls.Add(this.lowLabel);
            this.Controls.Add(this.normalLabel);
            this.Controls.Add(this.bigLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.bmrNumberLabel);
            this.Controls.Add(this.everydayLabel);
            this.Controls.Add(this.yourBMRLabel);
            this.Controls.Add(this.calorieLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.malePanel);
            this.Controls.Add(this.bmrLabel);
            this.Controls.Add(this.smLabel);
            this.Controls.Add(this.kgLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.fatTextBox);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.upPanel);
            this.Controls.Add(this.femalePanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.MaximumSize = new System.Drawing.Size(866, 664);
            this.MinimumSize = new System.Drawing.Size(866, 664);
            this.Name = "BMRCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - BMR Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMRCalculatorForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.malePictureBox)).EndInit();
            this.malePanel.ResumeLayout(false);
            this.downPanel.ResumeLayout(false);
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.femalePictureBox)).EndInit();
            this.femalePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label maleLabel;
        private System.Windows.Forms.PictureBox malePictureBox;
        private System.Windows.Forms.Panel malePanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label femaleLabel;
        private System.Windows.Forms.Label bmrLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label smLabel;
        private System.Windows.Forms.Label kgLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.MaskedTextBox heightTextBox;
        private System.Windows.Forms.MaskedTextBox fatTextBox;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.PictureBox femalePictureBox;
        private System.Windows.Forms.Panel femalePanel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.MaskedTextBox ageTextBox;
        private System.Windows.Forms.Label calorieLabel;
        private System.Windows.Forms.Label yourBMRLabel;
        private System.Windows.Forms.Label everydayLabel;
        private System.Windows.Forms.Label bmrNumberLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label bigLabel;
        private System.Windows.Forms.Label normalLabel;
        private System.Windows.Forms.Label lowLabel;
        private System.Windows.Forms.Label sitLabel;
        private System.Windows.Forms.Label sitNumberLabel;
        private System.Windows.Forms.Label lowNumberLabel;
        private System.Windows.Forms.Label normalNumberLabel;
        private System.Windows.Forms.Label bigNumberLabel;
        private System.Windows.Forms.Label maxNumberLabel;
        private System.Windows.Forms.PictureBox infoPictureBox;
    }
}