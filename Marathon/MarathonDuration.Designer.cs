
namespace Marathon
{
    partial class marathonDurationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(marathonDurationForm));
            this.resultLabel = new System.Windows.Forms.Label();
            this.upPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.downPanel = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.nameSelectLabel = new System.Windows.Forms.Label();
            this.SelectPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.speedDistanceTabControl = new System.Windows.Forms.TabControl();
            this.speedTabPage = new System.Windows.Forms.TabPage();
            this.speed5Label = new System.Windows.Forms.Label();
            this.speed5PictureBox = new System.Windows.Forms.PictureBox();
            this.speed4Label = new System.Windows.Forms.Label();
            this.speed4PictureBox = new System.Windows.Forms.PictureBox();
            this.speed3Label = new System.Windows.Forms.Label();
            this.speed3PictureBox = new System.Windows.Forms.PictureBox();
            this.speed2Label = new System.Windows.Forms.Label();
            this.speed2PictureBox = new System.Windows.Forms.PictureBox();
            this.speed1Label = new System.Windows.Forms.Label();
            this.speed1PictureBox = new System.Windows.Forms.PictureBox();
            this.distanceTabPage = new System.Windows.Forms.TabPage();
            this.distance5Label = new System.Windows.Forms.Label();
            this.distance5PictureBox = new System.Windows.Forms.PictureBox();
            this.distance4Label = new System.Windows.Forms.Label();
            this.distance4PictureBox = new System.Windows.Forms.PictureBox();
            this.distance3Label = new System.Windows.Forms.Label();
            this.distance3PictureBox = new System.Windows.Forms.PictureBox();
            this.distance2Label = new System.Windows.Forms.Label();
            this.distance2PictureBox = new System.Windows.Forms.PictureBox();
            this.distance1Label = new System.Windows.Forms.Label();
            this.distance1PictureBox = new System.Windows.Forms.PictureBox();
            this.upPanel.SuspendLayout();
            this.downPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPictureBox)).BeginInit();
            this.speedDistanceTabControl.SuspendLayout();
            this.speedTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed5PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed4PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed1PictureBox)).BeginInit();
            this.distanceTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distance5PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance4PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance1PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.resultLabel.Location = new System.Drawing.Point(180, 83);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(517, 42);
            this.resultLabel.TabIndex = 48;
            this.resultLabel.Text = "Насколько долгий марафон?";
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
            this.upPanel.TabIndex = 46;
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
            this.downPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.downPanel.Controls.Add(this.timerLabel);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 565);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(850, 60);
            this.downPanel.TabIndex = 47;
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
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // nameSelectLabel
            // 
            this.nameSelectLabel.AutoSize = true;
            this.nameSelectLabel.Font = new System.Drawing.Font("Arial", 17.75F);
            this.nameSelectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nameSelectLabel.Location = new System.Drawing.Point(120, 171);
            this.nameSelectLabel.Name = "nameSelectLabel";
            this.nameSelectLabel.Size = new System.Drawing.Size(277, 27);
            this.nameSelectLabel.TabIndex = 69;
            this.nameSelectLabel.Text = "Имя выбранного пункта";
            // 
            // SelectPictureBox
            // 
            this.SelectPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SelectPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SelectPictureBox.BackgroundImage")));
            this.SelectPictureBox.Location = new System.Drawing.Point(100, 210);
            this.SelectPictureBox.Name = "SelectPictureBox";
            this.SelectPictureBox.Size = new System.Drawing.Size(320, 191);
            this.SelectPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SelectPictureBox.TabIndex = 70;
            this.SelectPictureBox.TabStop = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.descriptionLabel.Location = new System.Drawing.Point(49, 418);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(410, 115);
            this.descriptionLabel.TabIndex = 71;
            this.descriptionLabel.Text = "Информация о скорости выбранного пункта и\r\nсколько времени это взяло бы, чтобы\r\nз" +
    "акончить марафон\r\n";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedDistanceTabControl
            // 
            this.speedDistanceTabControl.Controls.Add(this.speedTabPage);
            this.speedDistanceTabControl.Controls.Add(this.distanceTabPage);
            this.speedDistanceTabControl.Font = new System.Drawing.Font("Arial", 14.25F);
            this.speedDistanceTabControl.Location = new System.Drawing.Point(551, 158);
            this.speedDistanceTabControl.Name = "speedDistanceTabControl";
            this.speedDistanceTabControl.SelectedIndex = 0;
            this.speedDistanceTabControl.Size = new System.Drawing.Size(277, 390);
            this.speedDistanceTabControl.TabIndex = 72;
            // 
            // speedTabPage
            // 
            this.speedTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.speedTabPage.Controls.Add(this.speed5Label);
            this.speedTabPage.Controls.Add(this.speed5PictureBox);
            this.speedTabPage.Controls.Add(this.speed4Label);
            this.speedTabPage.Controls.Add(this.speed4PictureBox);
            this.speedTabPage.Controls.Add(this.speed3Label);
            this.speedTabPage.Controls.Add(this.speed3PictureBox);
            this.speedTabPage.Controls.Add(this.speed2Label);
            this.speedTabPage.Controls.Add(this.speed2PictureBox);
            this.speedTabPage.Controls.Add(this.speed1Label);
            this.speedTabPage.Controls.Add(this.speed1PictureBox);
            this.speedTabPage.Font = new System.Drawing.Font("Arial", 14.25F);
            this.speedTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.speedTabPage.Location = new System.Drawing.Point(4, 31);
            this.speedTabPage.Name = "speedTabPage";
            this.speedTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.speedTabPage.Size = new System.Drawing.Size(269, 355);
            this.speedTabPage.TabIndex = 0;
            this.speedTabPage.Text = "скорость";
            // 
            // speed5Label
            // 
            this.speed5Label.AutoSize = true;
            this.speed5Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speed5Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.speed5Label.Location = new System.Drawing.Point(110, 304);
            this.speed5Label.Name = "speed5Label";
            this.speed5Label.Size = new System.Drawing.Size(61, 22);
            this.speed5Label.TabIndex = 80;
            this.speed5Label.Text = "Ягуар";
            this.speed5Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speed5PictureBox
            // 
            this.speed5PictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.speed5PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("speed5PictureBox.Image")));
            this.speed5PictureBox.Location = new System.Drawing.Point(19, 286);
            this.speed5PictureBox.Name = "speed5PictureBox";
            this.speed5PictureBox.Size = new System.Drawing.Size(75, 59);
            this.speed5PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.speed5PictureBox.TabIndex = 81;
            this.speed5PictureBox.TabStop = false;
            this.speed5PictureBox.Click += new System.EventHandler(this.speed5PictureBox_Click);
            // 
            // speed4Label
            // 
            this.speed4Label.AutoSize = true;
            this.speed4Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speed4Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.speed4Label.Location = new System.Drawing.Point(110, 240);
            this.speed4Label.Name = "speed4Label";
            this.speed4Label.Size = new System.Drawing.Size(82, 22);
            this.speed4Label.TabIndex = 78;
            this.speed4Label.Text = "Капибар";
            this.speed4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speed4PictureBox
            // 
            this.speed4PictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.speed4PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("speed4PictureBox.Image")));
            this.speed4PictureBox.Location = new System.Drawing.Point(19, 221);
            this.speed4PictureBox.Name = "speed4PictureBox";
            this.speed4PictureBox.Size = new System.Drawing.Size(75, 59);
            this.speed4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.speed4PictureBox.TabIndex = 79;
            this.speed4PictureBox.TabStop = false;
            this.speed4PictureBox.Click += new System.EventHandler(this.speed4PictureBox_Click);
            // 
            // speed3Label
            // 
            this.speed3Label.AutoSize = true;
            this.speed3Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speed3Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.speed3Label.Location = new System.Drawing.Point(110, 174);
            this.speed3Label.Name = "speed3Label";
            this.speed3Label.Size = new System.Drawing.Size(85, 22);
            this.speed3Label.TabIndex = 76;
            this.speed3Label.Text = "Ленивец";
            this.speed3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speed3PictureBox
            // 
            this.speed3PictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.speed3PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("speed3PictureBox.Image")));
            this.speed3PictureBox.Location = new System.Drawing.Point(19, 154);
            this.speed3PictureBox.Name = "speed3PictureBox";
            this.speed3PictureBox.Size = new System.Drawing.Size(75, 59);
            this.speed3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.speed3PictureBox.TabIndex = 77;
            this.speed3PictureBox.TabStop = false;
            this.speed3PictureBox.Click += new System.EventHandler(this.speed3PictureBox_Click);
            // 
            // speed2Label
            // 
            this.speed2Label.AutoSize = true;
            this.speed2Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speed2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.speed2Label.Location = new System.Drawing.Point(110, 104);
            this.speed2Label.Name = "speed2Label";
            this.speed2Label.Size = new System.Drawing.Size(66, 22);
            this.speed2Label.TabIndex = 74;
            this.speed2Label.Text = "Червь";
            this.speed2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speed2PictureBox
            // 
            this.speed2PictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.speed2PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("speed2PictureBox.Image")));
            this.speed2PictureBox.Location = new System.Drawing.Point(19, 86);
            this.speed2PictureBox.Name = "speed2PictureBox";
            this.speed2PictureBox.Size = new System.Drawing.Size(75, 59);
            this.speed2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.speed2PictureBox.TabIndex = 75;
            this.speed2PictureBox.TabStop = false;
            this.speed2PictureBox.Click += new System.EventHandler(this.speed2PictureBox_Click);
            // 
            // speed1Label
            // 
            this.speed1Label.AutoSize = true;
            this.speed1Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speed1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.speed1Label.Location = new System.Drawing.Point(110, 37);
            this.speed1Label.Name = "speed1Label";
            this.speed1Label.Size = new System.Drawing.Size(104, 22);
            this.speed1Label.TabIndex = 73;
            this.speed1Label.Text = "Формула 1";
            this.speed1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speed1PictureBox
            // 
            this.speed1PictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.speed1PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("speed1PictureBox.Image")));
            this.speed1PictureBox.Location = new System.Drawing.Point(19, 19);
            this.speed1PictureBox.Name = "speed1PictureBox";
            this.speed1PictureBox.Size = new System.Drawing.Size(75, 59);
            this.speed1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.speed1PictureBox.TabIndex = 73;
            this.speed1PictureBox.TabStop = false;
            this.speed1PictureBox.Click += new System.EventHandler(this.speed1PictureBox_Click);
            // 
            // distanceTabPage
            // 
            this.distanceTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.distanceTabPage.Controls.Add(this.distance5Label);
            this.distanceTabPage.Controls.Add(this.distance5PictureBox);
            this.distanceTabPage.Controls.Add(this.distance4Label);
            this.distanceTabPage.Controls.Add(this.distance4PictureBox);
            this.distanceTabPage.Controls.Add(this.distance3Label);
            this.distanceTabPage.Controls.Add(this.distance3PictureBox);
            this.distanceTabPage.Controls.Add(this.distance2Label);
            this.distanceTabPage.Controls.Add(this.distance2PictureBox);
            this.distanceTabPage.Controls.Add(this.distance1Label);
            this.distanceTabPage.Controls.Add(this.distance1PictureBox);
            this.distanceTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.distanceTabPage.Location = new System.Drawing.Point(4, 31);
            this.distanceTabPage.Name = "distanceTabPage";
            this.distanceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.distanceTabPage.Size = new System.Drawing.Size(269, 355);
            this.distanceTabPage.TabIndex = 1;
            this.distanceTabPage.Text = "Дистанция";
            // 
            // distance5Label
            // 
            this.distance5Label.AutoSize = true;
            this.distance5Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distance5Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.distance5Label.Location = new System.Drawing.Point(110, 303);
            this.distance5Label.Name = "distance5Label";
            this.distance5Label.Size = new System.Drawing.Size(82, 22);
            this.distance5Label.TabIndex = 90;
            this.distance5Label.Text = "Автобус";
            this.distance5Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // distance5PictureBox
            // 
            this.distance5PictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.distance5PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("distance5PictureBox.Image")));
            this.distance5PictureBox.Location = new System.Drawing.Point(19, 285);
            this.distance5PictureBox.Name = "distance5PictureBox";
            this.distance5PictureBox.Size = new System.Drawing.Size(75, 59);
            this.distance5PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.distance5PictureBox.TabIndex = 91;
            this.distance5PictureBox.TabStop = false;
            this.distance5PictureBox.Click += new System.EventHandler(this.distance5PictureBox_Click);
            // 
            // distance4Label
            // 
            this.distance4Label.AutoSize = true;
            this.distance4Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distance4Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.distance4Label.Location = new System.Drawing.Point(110, 238);
            this.distance4Label.Name = "distance4Label";
            this.distance4Label.Size = new System.Drawing.Size(116, 22);
            this.distance4Label.TabIndex = 88;
            this.distance4Label.Text = "Роналдиньо";
            this.distance4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // distance4PictureBox
            // 
            this.distance4PictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.distance4PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("distance4PictureBox.Image")));
            this.distance4PictureBox.Location = new System.Drawing.Point(19, 220);
            this.distance4PictureBox.Name = "distance4PictureBox";
            this.distance4PictureBox.Size = new System.Drawing.Size(75, 59);
            this.distance4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.distance4PictureBox.TabIndex = 89;
            this.distance4PictureBox.TabStop = false;
            this.distance4PictureBox.Click += new System.EventHandler(this.distance4PictureBox_Click);
            // 
            // distance3Label
            // 
            this.distance3Label.AutoSize = true;
            this.distance3Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distance3Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.distance3Label.Location = new System.Drawing.Point(110, 166);
            this.distance3Label.Name = "distance3Label";
            this.distance3Label.Size = new System.Drawing.Size(116, 44);
            this.distance3Label.TabIndex = 86;
            this.distance3Label.Text = "Футбольное\r\nполе";
            // 
            // distance3PictureBox
            // 
            this.distance3PictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.distance3PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("distance3PictureBox.Image")));
            this.distance3PictureBox.Location = new System.Drawing.Point(19, 153);
            this.distance3PictureBox.Name = "distance3PictureBox";
            this.distance3PictureBox.Size = new System.Drawing.Size(75, 59);
            this.distance3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.distance3PictureBox.TabIndex = 87;
            this.distance3PictureBox.TabStop = false;
            this.distance3PictureBox.Click += new System.EventHandler(this.distance3PictureBox_Click);
            // 
            // distance2Label
            // 
            this.distance2Label.AutoSize = true;
            this.distance2Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distance2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.distance2Label.Location = new System.Drawing.Point(110, 103);
            this.distance2Label.Name = "distance2Label";
            this.distance2Label.Size = new System.Drawing.Size(102, 22);
            this.distance2Label.TabIndex = 84;
            this.distance2Label.Text = "Шлепанцы";
            this.distance2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // distance2PictureBox
            // 
            this.distance2PictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.distance2PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("distance2PictureBox.Image")));
            this.distance2PictureBox.Location = new System.Drawing.Point(19, 85);
            this.distance2PictureBox.Name = "distance2PictureBox";
            this.distance2PictureBox.Size = new System.Drawing.Size(75, 59);
            this.distance2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.distance2PictureBox.TabIndex = 85;
            this.distance2PictureBox.TabStop = false;
            this.distance2PictureBox.Click += new System.EventHandler(this.distance2PictureBox_Click);
            // 
            // distance1Label
            // 
            this.distance1Label.AutoSize = true;
            this.distance1Label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distance1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.distance1Label.Location = new System.Drawing.Point(110, 36);
            this.distance1Label.Name = "distance1Label";
            this.distance1Label.Size = new System.Drawing.Size(114, 22);
            this.distance1Label.TabIndex = 82;
            this.distance1Label.Text = "Airbus A380";
            this.distance1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // distance1PictureBox
            // 
            this.distance1PictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.distance1PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("distance1PictureBox.Image")));
            this.distance1PictureBox.Location = new System.Drawing.Point(19, 18);
            this.distance1PictureBox.Name = "distance1PictureBox";
            this.distance1PictureBox.Size = new System.Drawing.Size(75, 59);
            this.distance1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.distance1PictureBox.TabIndex = 83;
            this.distance1PictureBox.TabStop = false;
            this.distance1PictureBox.Click += new System.EventHandler(this.distance1PictureBox_Click);
            // 
            // marathonDurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 625);
            this.Controls.Add(this.speedDistanceTabControl);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.SelectPictureBox);
            this.Controls.Add(this.nameSelectLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.upPanel);
            this.Controls.Add(this.downPanel);
            this.MinimumSize = new System.Drawing.Size(866, 664);
            this.Name = "marathonDurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - How long is a marathon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.marathonDurationForm_FormClosing);
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            this.downPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectPictureBox)).EndInit();
            this.speedDistanceTabControl.ResumeLayout(false);
            this.speedTabPage.ResumeLayout(false);
            this.speedTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speed5PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed4PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed1PictureBox)).EndInit();
            this.distanceTabPage.ResumeLayout(false);
            this.distanceTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distance5PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance4PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance1PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label nameSelectLabel;
        private System.Windows.Forms.PictureBox SelectPictureBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TabControl speedDistanceTabControl;
        private System.Windows.Forms.TabPage speedTabPage;
        private System.Windows.Forms.TabPage distanceTabPage;
        private System.Windows.Forms.Label distance5Label;
        private System.Windows.Forms.PictureBox distance5PictureBox;
        private System.Windows.Forms.Label distance4Label;
        private System.Windows.Forms.PictureBox distance4PictureBox;
        private System.Windows.Forms.Label distance3Label;
        private System.Windows.Forms.PictureBox distance3PictureBox;
        private System.Windows.Forms.Label distance2Label;
        private System.Windows.Forms.PictureBox distance2PictureBox;
        private System.Windows.Forms.Label distance1Label;
        private System.Windows.Forms.PictureBox distance1PictureBox;
        private System.Windows.Forms.Label speed5Label;
        private System.Windows.Forms.PictureBox speed5PictureBox;
        private System.Windows.Forms.Label speed4Label;
        private System.Windows.Forms.PictureBox speed4PictureBox;
        private System.Windows.Forms.Label speed3Label;
        private System.Windows.Forms.PictureBox speed3PictureBox;
        private System.Windows.Forms.Label speed2Label;
        private System.Windows.Forms.PictureBox speed2PictureBox;
        private System.Windows.Forms.Label speed1Label;
        private System.Windows.Forms.PictureBox speed1PictureBox;
        private System.Windows.Forms.Label timerLabel;
    }
}