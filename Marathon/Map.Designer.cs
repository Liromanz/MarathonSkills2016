
namespace Marathon
{
    partial class mapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mapForm));
            this.timerLabel = new System.Windows.Forms.Label();
            this.downPanel = new System.Windows.Forms.Panel();
            this.upPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.energyPictureBox = new System.Windows.Forms.PictureBox();
            this.toiletPictureBox = new System.Windows.Forms.PictureBox();
            this.startPictureBox = new System.Windows.Forms.PictureBox();
            this.mapPictureBox = new System.Windows.Forms.PictureBox();
            this.infoPictureBox = new System.Windows.Forms.PictureBox();
            this.healthPictureBox = new System.Windows.Forms.PictureBox();
            this.drinkBottomPictureBox = new System.Windows.Forms.PictureBox();
            this.drinkUpPictureBox = new System.Windows.Forms.PictureBox();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.description3Label = new System.Windows.Forms.Label();
            this.description2Label = new System.Windows.Forms.Label();
            this.description1Label = new System.Windows.Forms.Label();
            this.markNameLabel = new System.Windows.Forms.Label();
            this.abilitesLabel = new System.Windows.Forms.Label();
            this.markLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.downPanel.SuspendLayout();
            this.upPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.energyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toiletPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkBottomPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkUpPictureBox)).BeginInit();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.downPanel.TabIndex = 73;
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
            this.upPanel.TabIndex = 72;
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
            // energyPictureBox
            // 
            this.energyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("energyPictureBox.Image")));
            this.energyPictureBox.Location = new System.Drawing.Point(149, 242);
            this.energyPictureBox.Name = "energyPictureBox";
            this.energyPictureBox.Size = new System.Drawing.Size(27, 30);
            this.energyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.energyPictureBox.TabIndex = 45;
            this.energyPictureBox.TabStop = false;
            this.energyPictureBox.Click += new System.EventHandler(this.energyPictureBox_Click);
            // 
            // toiletPictureBox
            // 
            this.toiletPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("toiletPictureBox.Image")));
            this.toiletPictureBox.Location = new System.Drawing.Point(242, 514);
            this.toiletPictureBox.Name = "toiletPictureBox";
            this.toiletPictureBox.Size = new System.Drawing.Size(27, 30);
            this.toiletPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.toiletPictureBox.TabIndex = 44;
            this.toiletPictureBox.TabStop = false;
            this.toiletPictureBox.Click += new System.EventHandler(this.toiletPictureBox_Click);
            // 
            // startPictureBox
            // 
            this.startPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("startPictureBox.Image")));
            this.startPictureBox.Location = new System.Drawing.Point(325, 90);
            this.startPictureBox.Name = "startPictureBox";
            this.startPictureBox.Size = new System.Drawing.Size(27, 30);
            this.startPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.startPictureBox.TabIndex = 43;
            this.startPictureBox.TabStop = false;
            this.startPictureBox.Click += new System.EventHandler(this.startPictureBox_Click);
            // 
            // mapPictureBox
            // 
            this.mapPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("mapPictureBox.Image")));
            this.mapPictureBox.Location = new System.Drawing.Point(12, 75);
            this.mapPictureBox.Name = "mapPictureBox";
            this.mapPictureBox.Size = new System.Drawing.Size(576, 484);
            this.mapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mapPictureBox.TabIndex = 42;
            this.mapPictureBox.TabStop = false;
            // 
            // infoPictureBox
            // 
            this.infoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("infoPictureBox.Image")));
            this.infoPictureBox.Location = new System.Drawing.Point(490, 90);
            this.infoPictureBox.Name = "infoPictureBox";
            this.infoPictureBox.Size = new System.Drawing.Size(27, 30);
            this.infoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.infoPictureBox.TabIndex = 74;
            this.infoPictureBox.TabStop = false;
            this.infoPictureBox.Click += new System.EventHandler(this.infoPictureBox_Click);
            // 
            // healthPictureBox
            // 
            this.healthPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("healthPictureBox.Image")));
            this.healthPictureBox.Location = new System.Drawing.Point(308, 292);
            this.healthPictureBox.Name = "healthPictureBox";
            this.healthPictureBox.Size = new System.Drawing.Size(27, 30);
            this.healthPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.healthPictureBox.TabIndex = 75;
            this.healthPictureBox.TabStop = false;
            this.healthPictureBox.Click += new System.EventHandler(this.healthPictureBox_Click);
            // 
            // drinkBottomPictureBox
            // 
            this.drinkBottomPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("drinkBottomPictureBox.Image")));
            this.drinkBottomPictureBox.Location = new System.Drawing.Point(490, 429);
            this.drinkBottomPictureBox.Name = "drinkBottomPictureBox";
            this.drinkBottomPictureBox.Size = new System.Drawing.Size(27, 30);
            this.drinkBottomPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.drinkBottomPictureBox.TabIndex = 76;
            this.drinkBottomPictureBox.TabStop = false;
            this.drinkBottomPictureBox.Click += new System.EventHandler(this.drinkBottomPictureBox_Click);
            // 
            // drinkUpPictureBox
            // 
            this.drinkUpPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("drinkUpPictureBox.Image")));
            this.drinkUpPictureBox.Location = new System.Drawing.Point(103, 90);
            this.drinkUpPictureBox.Name = "drinkUpPictureBox";
            this.drinkUpPictureBox.Size = new System.Drawing.Size(27, 30);
            this.drinkUpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.drinkUpPictureBox.TabIndex = 77;
            this.drinkUpPictureBox.TabStop = false;
            this.drinkUpPictureBox.Click += new System.EventHandler(this.drinkUpPictureBox_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.LightGray;
            this.infoPanel.Controls.Add(this.exitPictureBox);
            this.infoPanel.Controls.Add(this.description3Label);
            this.infoPanel.Controls.Add(this.description2Label);
            this.infoPanel.Controls.Add(this.description1Label);
            this.infoPanel.Controls.Add(this.markNameLabel);
            this.infoPanel.Controls.Add(this.abilitesLabel);
            this.infoPanel.Controls.Add(this.markLabel);
            this.infoPanel.Location = new System.Drawing.Point(620, 90);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(204, 290);
            this.infoPanel.TabIndex = 78;
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("exitPictureBox.Image")));
            this.exitPictureBox.Location = new System.Drawing.Point(174, 5);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(27, 25);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPictureBox.TabIndex = 79;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // description3Label
            // 
            this.description3Label.Font = new System.Drawing.Font("Arial", 15F);
            this.description3Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.description3Label.Location = new System.Drawing.Point(14, 230);
            this.description3Label.Name = "description3Label";
            this.description3Label.Size = new System.Drawing.Size(187, 48);
            this.description3Label.TabIndex = 84;
            this.description3Label.Text = "Описание 3";
            // 
            // description2Label
            // 
            this.description2Label.Font = new System.Drawing.Font("Arial", 15F);
            this.description2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.description2Label.Location = new System.Drawing.Point(14, 182);
            this.description2Label.Name = "description2Label";
            this.description2Label.Size = new System.Drawing.Size(187, 48);
            this.description2Label.TabIndex = 83;
            this.description2Label.Text = "Описание 2";
            // 
            // description1Label
            // 
            this.description1Label.Font = new System.Drawing.Font("Arial", 15F);
            this.description1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.description1Label.Location = new System.Drawing.Point(14, 134);
            this.description1Label.Name = "description1Label";
            this.description1Label.Size = new System.Drawing.Size(187, 48);
            this.description1Label.TabIndex = 82;
            this.description1Label.Text = "Описание 1";
            // 
            // markNameLabel
            // 
            this.markNameLabel.Font = new System.Drawing.Font("Arial", 15F);
            this.markNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.markNameLabel.Location = new System.Drawing.Point(14, 52);
            this.markNameLabel.Name = "markNameLabel";
            this.markNameLabel.Size = new System.Drawing.Size(187, 48);
            this.markNameLabel.TabIndex = 81;
            this.markNameLabel.Text = "Название метки";
            // 
            // abilitesLabel
            // 
            this.abilitesLabel.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.abilitesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.abilitesLabel.Location = new System.Drawing.Point(13, 100);
            this.abilitesLabel.Name = "abilitesLabel";
            this.abilitesLabel.Size = new System.Drawing.Size(188, 41);
            this.abilitesLabel.TabIndex = 80;
            this.abilitesLabel.Text = "Возможности:";
            // 
            // markLabel
            // 
            this.markLabel.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.markLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.markLabel.Location = new System.Drawing.Point(13, 20);
            this.markLabel.Name = "markLabel";
            this.markLabel.Size = new System.Drawing.Size(177, 41);
            this.markLabel.TabIndex = 79;
            this.markLabel.Text = "Метка:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // mapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 625);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.drinkUpPictureBox);
            this.Controls.Add(this.drinkBottomPictureBox);
            this.Controls.Add(this.healthPictureBox);
            this.Controls.Add(this.infoPictureBox);
            this.Controls.Add(this.energyPictureBox);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.toiletPictureBox);
            this.Controls.Add(this.upPanel);
            this.Controls.Add(this.startPictureBox);
            this.Controls.Add(this.mapPictureBox);
            this.MaximumSize = new System.Drawing.Size(866, 664);
            this.MinimumSize = new System.Drawing.Size(866, 664);
            this.Name = "mapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon 2021 - Interactive map";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mapForm_FormClosing);
            this.downPanel.ResumeLayout(false);
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.energyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toiletPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkBottomPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkUpPictureBox)).EndInit();
            this.infoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.PictureBox energyPictureBox;
        private System.Windows.Forms.PictureBox toiletPictureBox;
        private System.Windows.Forms.PictureBox startPictureBox;
        private System.Windows.Forms.PictureBox mapPictureBox;
        private System.Windows.Forms.PictureBox infoPictureBox;
        private System.Windows.Forms.PictureBox healthPictureBox;
        private System.Windows.Forms.PictureBox drinkBottomPictureBox;
        private System.Windows.Forms.PictureBox drinkUpPictureBox;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label markLabel;
        private System.Windows.Forms.Label abilitesLabel;
        private System.Windows.Forms.Label markNameLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label description3Label;
        private System.Windows.Forms.Label description2Label;
        private System.Windows.Forms.Label description1Label;
        private System.Windows.Forms.PictureBox exitPictureBox;
    }
}