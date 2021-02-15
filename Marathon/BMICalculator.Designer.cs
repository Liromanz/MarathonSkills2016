
namespace Marathon
{
    partial class BMICalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMICalculatorForm));
            this.bmiLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.downPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fatTextBox = new System.Windows.Forms.MaskedTextBox();
            this.countButton = new System.Windows.Forms.Button();
            this.heightLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.upPanel = new System.Windows.Forms.Panel();
            this.fatLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.kgLabel = new System.Windows.Forms.Label();
            this.smLabel = new System.Windows.Forms.Label();
            this.femalePictureBox = new System.Windows.Forms.PictureBox();
            this.femalePanel = new System.Windows.Forms.Panel();
            this.femaleLabel = new System.Windows.Forms.Label();
            this.malePictureBox = new System.Windows.Forms.PictureBox();
            this.malePanel = new System.Windows.Forms.Panel();
            this.maleLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.healthPictureBox = new System.Windows.Forms.PictureBox();
            this.healthPanel = new System.Windows.Forms.Panel();
            this.notEnoughPanel = new System.Windows.Forms.Panel();
            this.healthyPanel = new System.Windows.Forms.Panel();
            this.biggerPanel = new System.Windows.Forms.Panel();
            this.tooMuchPanel = new System.Windows.Forms.Panel();
            this.cursorPictureBox = new System.Windows.Forms.PictureBox();
            this.cursorPanel = new System.Windows.Forms.Panel();
            this.bmiNumberLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notEnoughLabel = new System.Windows.Forms.Label();
            this.healthyLabel = new System.Windows.Forms.Label();
            this.biggerLabel = new System.Windows.Forms.Label();
            this.tooMuchLabel = new System.Windows.Forms.Label();
            this.downPanel.SuspendLayout();
            this.upPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.femalePictureBox)).BeginInit();
            this.femalePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.malePictureBox)).BeginInit();
            this.malePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthPictureBox)).BeginInit();
            this.healthPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursorPictureBox)).BeginInit();
            this.cursorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bmiLabel
            // 
            this.bmiLabel.AutoSize = true;
            this.bmiLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bmiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bmiLabel.Location = new System.Drawing.Point(286, 92);
            this.bmiLabel.Name = "bmiLabel";
            this.bmiLabel.Size = new System.Drawing.Size(305, 42);
            this.bmiLabel.TabIndex = 40;
            this.bmiLabel.Text = "BMI калькулятор";
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
            this.downPanel.TabIndex = 39;
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
            // heightTextBox
            // 
            this.heightTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.heightTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.heightTextBox.Location = new System.Drawing.Point(197, 368);
            this.heightTextBox.Mask = "000";
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(64, 29);
            this.heightTextBox.TabIndex = 45;
            // 
            // fatTextBox
            // 
            this.fatTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.fatTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.fatTextBox.Location = new System.Drawing.Point(197, 414);
            this.fatTextBox.Mask = "000";
            this.fatTextBox.Name = "fatTextBox";
            this.fatTextBox.Size = new System.Drawing.Size(64, 29);
            this.fatTextBox.TabIndex = 44;
            // 
            // countButton
            // 
            this.countButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.countButton.Location = new System.Drawing.Point(60, 473);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(131, 30);
            this.countButton.TabIndex = 43;
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
            this.heightLabel.TabIndex = 42;
            this.heightLabel.Text = "Рост:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.descriptionLabel.Location = new System.Drawing.Point(39, 158);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(325, 44);
            this.descriptionLabel.TabIndex = 41;
            this.descriptionLabel.Text = "Информация о том, что такое BMI и\r\nкак калькулятор работает\r\n";
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
            this.upPanel.TabIndex = 38;
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.fatLabel.Location = new System.Drawing.Point(135, 421);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(49, 22);
            this.fatLabel.TabIndex = 46;
            this.fatLabel.Text = "Вес:";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cancelButton.Location = new System.Drawing.Point(197, 473);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(131, 30);
            this.cancelButton.TabIndex = 47;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // kgLabel
            // 
            this.kgLabel.AutoSize = true;
            this.kgLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kgLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.kgLabel.Location = new System.Drawing.Point(267, 421);
            this.kgLabel.Name = "kgLabel";
            this.kgLabel.Size = new System.Drawing.Size(25, 22);
            this.kgLabel.TabIndex = 48;
            this.kgLabel.Text = "кг";
            // 
            // smLabel
            // 
            this.smLabel.AutoSize = true;
            this.smLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.smLabel.Location = new System.Drawing.Point(267, 371);
            this.smLabel.Name = "smLabel";
            this.smLabel.Size = new System.Drawing.Size(33, 22);
            this.smLabel.TabIndex = 49;
            this.smLabel.Text = "см";
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
            // 
            // femalePanel
            // 
            this.femalePanel.BackColor = System.Drawing.Color.LightGray;
            this.femalePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.femalePanel.Controls.Add(this.femaleLabel);
            this.femalePanel.Controls.Add(this.femalePictureBox);
            this.femalePanel.Location = new System.Drawing.Point(197, 219);
            this.femalePanel.Name = "femalePanel";
            this.femalePanel.Size = new System.Drawing.Size(131, 125);
            this.femalePanel.TabIndex = 52;
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
            // 
            // malePanel
            // 
            this.malePanel.BackColor = System.Drawing.Color.LightGray;
            this.malePanel.Controls.Add(this.maleLabel);
            this.malePanel.Controls.Add(this.malePictureBox);
            this.malePanel.Location = new System.Drawing.Point(60, 219);
            this.malePanel.Name = "malePanel";
            this.malePanel.Size = new System.Drawing.Size(131, 125);
            this.malePanel.TabIndex = 53;
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
            // 
            // healthLabel
            // 
            this.healthLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.healthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.healthLabel.Location = new System.Drawing.Point(3, 209);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(175, 22);
            this.healthLabel.TabIndex = 53;
            this.healthLabel.Text = "Здоровый";
            this.healthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // healthPictureBox
            // 
            this.healthPictureBox.BackColor = System.Drawing.Color.LightGray;
            this.healthPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("healthPictureBox.Image")));
            this.healthPictureBox.Location = new System.Drawing.Point(3, 30);
            this.healthPictureBox.Name = "healthPictureBox";
            this.healthPictureBox.Size = new System.Drawing.Size(175, 155);
            this.healthPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.healthPictureBox.TabIndex = 51;
            this.healthPictureBox.TabStop = false;
            // 
            // healthPanel
            // 
            this.healthPanel.BackColor = System.Drawing.Color.LightGray;
            this.healthPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.healthPanel.Controls.Add(this.healthLabel);
            this.healthPanel.Controls.Add(this.healthPictureBox);
            this.healthPanel.Location = new System.Drawing.Point(548, 158);
            this.healthPanel.Name = "healthPanel";
            this.healthPanel.Size = new System.Drawing.Size(183, 239);
            this.healthPanel.TabIndex = 54;
            // 
            // notEnoughPanel
            // 
            this.notEnoughPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.notEnoughPanel.Location = new System.Drawing.Point(441, 491);
            this.notEnoughPanel.Name = "notEnoughPanel";
            this.notEnoughPanel.Size = new System.Drawing.Size(97, 10);
            this.notEnoughPanel.TabIndex = 55;
            // 
            // healthyPanel
            // 
            this.healthyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(223)))), ((int)(((byte)(0)))));
            this.healthyPanel.Location = new System.Drawing.Point(538, 491);
            this.healthyPanel.Name = "healthyPanel";
            this.healthyPanel.Size = new System.Drawing.Size(97, 10);
            this.healthyPanel.TabIndex = 56;
            // 
            // biggerPanel
            // 
            this.biggerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.biggerPanel.Location = new System.Drawing.Point(635, 491);
            this.biggerPanel.Name = "biggerPanel";
            this.biggerPanel.Size = new System.Drawing.Size(97, 10);
            this.biggerPanel.TabIndex = 57;
            // 
            // tooMuchPanel
            // 
            this.tooMuchPanel.BackColor = System.Drawing.Color.Red;
            this.tooMuchPanel.Location = new System.Drawing.Point(729, 491);
            this.tooMuchPanel.Name = "tooMuchPanel";
            this.tooMuchPanel.Size = new System.Drawing.Size(97, 10);
            this.tooMuchPanel.TabIndex = 58;
            // 
            // cursorPictureBox
            // 
            this.cursorPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cursorPictureBox.Image")));
            this.cursorPictureBox.Location = new System.Drawing.Point(7, 30);
            this.cursorPictureBox.Name = "cursorPictureBox";
            this.cursorPictureBox.Size = new System.Drawing.Size(41, 19);
            this.cursorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cursorPictureBox.TabIndex = 59;
            this.cursorPictureBox.TabStop = false;
            // 
            // cursorPanel
            // 
            this.cursorPanel.Controls.Add(this.bmiNumberLabel);
            this.cursorPanel.Controls.Add(this.cursorPictureBox);
            this.cursorPanel.Location = new System.Drawing.Point(556, 435);
            this.cursorPanel.Name = "cursorPanel";
            this.cursorPanel.Size = new System.Drawing.Size(59, 51);
            this.cursorPanel.TabIndex = 60;
            // 
            // bmiNumberLabel
            // 
            this.bmiNumberLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bmiNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bmiNumberLabel.Location = new System.Drawing.Point(3, 5);
            this.bmiNumberLabel.Name = "bmiNumberLabel";
            this.bmiNumberLabel.Size = new System.Drawing.Size(53, 22);
            this.bmiNumberLabel.TabIndex = 61;
            this.bmiNumberLabel.Text = "24.2";
            this.bmiNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // notEnoughLabel
            // 
            this.notEnoughLabel.AutoSize = true;
            this.notEnoughLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.notEnoughLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.notEnoughLabel.Location = new System.Drawing.Point(438, 504);
            this.notEnoughLabel.Name = "notEnoughLabel";
            this.notEnoughLabel.Size = new System.Drawing.Size(111, 16);
            this.notEnoughLabel.TabIndex = 61;
            this.notEnoughLabel.Text = "Недостаточный";
            // 
            // healthyLabel
            // 
            this.healthyLabel.AutoSize = true;
            this.healthyLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.healthyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.healthyLabel.Location = new System.Drawing.Point(553, 504);
            this.healthyLabel.Name = "healthyLabel";
            this.healthyLabel.Size = new System.Drawing.Size(73, 16);
            this.healthyLabel.TabIndex = 62;
            this.healthyLabel.Text = "Здоровый";
            // 
            // biggerLabel
            // 
            this.biggerLabel.AutoSize = true;
            this.biggerLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.biggerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.biggerLabel.Location = new System.Drawing.Point(637, 504);
            this.biggerLabel.Name = "biggerLabel";
            this.biggerLabel.Size = new System.Drawing.Size(90, 16);
            this.biggerLabel.TabIndex = 63;
            this.biggerLabel.Text = "Избыточный";
            // 
            // tooMuchLabel
            // 
            this.tooMuchLabel.AutoSize = true;
            this.tooMuchLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.tooMuchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tooMuchLabel.Location = new System.Drawing.Point(733, 504);
            this.tooMuchLabel.Name = "tooMuchLabel";
            this.tooMuchLabel.Size = new System.Drawing.Size(76, 16);
            this.tooMuchLabel.TabIndex = 64;
            this.tooMuchLabel.Text = "Ожирение";
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 625);
            this.Controls.Add(this.tooMuchLabel);
            this.Controls.Add(this.biggerLabel);
            this.Controls.Add(this.healthyLabel);
            this.Controls.Add(this.notEnoughLabel);
            this.Controls.Add(this.cursorPanel);
            this.Controls.Add(this.tooMuchPanel);
            this.Controls.Add(this.notEnoughPanel);
            this.Controls.Add(this.biggerPanel);
            this.Controls.Add(this.healthyPanel);
            this.Controls.Add(this.healthPanel);
            this.Controls.Add(this.malePanel);
            this.Controls.Add(this.smLabel);
            this.Controls.Add(this.kgLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.bmiLabel);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.fatTextBox);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.upPanel);
            this.Controls.Add(this.femalePanel);
            this.MaximumSize = new System.Drawing.Size(866, 664);
            this.MinimumSize = new System.Drawing.Size(866, 664);
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - BMI Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculator_FormClosing);
            this.downPanel.ResumeLayout(false);
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.femalePictureBox)).EndInit();
            this.femalePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.malePictureBox)).EndInit();
            this.malePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.healthPictureBox)).EndInit();
            this.healthPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cursorPictureBox)).EndInit();
            this.cursorPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bmiLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.MaskedTextBox heightTextBox;
        private System.Windows.Forms.MaskedTextBox fatTextBox;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label kgLabel;
        private System.Windows.Forms.Label smLabel;
        private System.Windows.Forms.PictureBox femalePictureBox;
        private System.Windows.Forms.Panel femalePanel;
        private System.Windows.Forms.Label femaleLabel;
        private System.Windows.Forms.PictureBox malePictureBox;
        private System.Windows.Forms.Panel malePanel;
        private System.Windows.Forms.Label maleLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.PictureBox healthPictureBox;
        private System.Windows.Forms.Panel healthPanel;
        private System.Windows.Forms.Panel notEnoughPanel;
        private System.Windows.Forms.Panel healthyPanel;
        private System.Windows.Forms.Panel biggerPanel;
        private System.Windows.Forms.Panel tooMuchPanel;
        private System.Windows.Forms.PictureBox cursorPictureBox;
        private System.Windows.Forms.Panel cursorPanel;
        private System.Windows.Forms.Label bmiNumberLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label notEnoughLabel;
        private System.Windows.Forms.Label healthyLabel;
        private System.Windows.Forms.Label biggerLabel;
        private System.Windows.Forms.Label tooMuchLabel;
    }
}