
namespace Marathon
{
    partial class raceAllForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timeNumberLabel = new System.Windows.Forms.Label();
            this.finishNumberLabel = new System.Windows.Forms.Label();
            this.runnerNumberLabel = new System.Windows.Forms.Label();
            this.raceDataGrid = new System.Windows.Forms.DataGridView();
            this.timeLabel = new System.Windows.Forms.Label();
            this.finishLabel = new System.Windows.Forms.Label();
            this.runnersLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.ageComboBox = new System.Windows.Forms.ComboBox();
            this.distanceComboBox = new System.Windows.Forms.ComboBox();
            this.marathonComboBox = new System.Windows.Forms.ComboBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.marathonLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.upPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.downPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.raceDataGrid)).BeginInit();
            this.upPanel.SuspendLayout();
            this.downPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeNumberLabel
            // 
            this.timeNumberLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.timeNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.timeNumberLabel.Location = new System.Drawing.Point(756, 303);
            this.timeNumberLabel.Name = "timeNumberLabel";
            this.timeNumberLabel.Size = new System.Drawing.Size(82, 22);
            this.timeNumberLabel.TabIndex = 56;
            this.timeNumberLabel.Text = "...";
            // 
            // finishNumberLabel
            // 
            this.finishNumberLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.finishNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.finishNumberLabel.Location = new System.Drawing.Point(504, 303);
            this.finishNumberLabel.Name = "finishNumberLabel";
            this.finishNumberLabel.Size = new System.Drawing.Size(96, 22);
            this.finishNumberLabel.TabIndex = 55;
            this.finishNumberLabel.Text = "...";
            // 
            // runnerNumberLabel
            // 
            this.runnerNumberLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.runnerNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.runnerNumberLabel.Location = new System.Drawing.Point(155, 303);
            this.runnerNumberLabel.Name = "runnerNumberLabel";
            this.runnerNumberLabel.Size = new System.Drawing.Size(72, 22);
            this.runnerNumberLabel.TabIndex = 54;
            this.runnerNumberLabel.Text = "...";
            // 
            // raceDataGrid
            // 
            this.raceDataGrid.AllowUserToAddRows = false;
            this.raceDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.raceDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.raceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.raceDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.raceDataGrid.EnableHeadersVisualStyles = false;
            this.raceDataGrid.Location = new System.Drawing.Point(15, 341);
            this.raceDataGrid.Name = "raceDataGrid";
            this.raceDataGrid.RowHeadersVisible = false;
            this.raceDataGrid.Size = new System.Drawing.Size(826, 218);
            this.raceDataGrid.TabIndex = 53;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.timeLabel.Location = new System.Drawing.Point(606, 303);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(154, 22);
            this.timeLabel.TabIndex = 52;
            this.timeLabel.Text = "Среднее время:";
            // 
            // finishLabel
            // 
            this.finishLabel.AutoSize = true;
            this.finishLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.finishLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.finishLabel.Location = new System.Drawing.Point(233, 303);
            this.finishLabel.Name = "finishLabel";
            this.finishLabel.Size = new System.Drawing.Size(279, 22);
            this.finishLabel.TabIndex = 51;
            this.finishLabel.Text = "Всего бегунов финишировало:";
            // 
            // runnersLabel
            // 
            this.runnersLabel.AutoSize = true;
            this.runnersLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.runnersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.runnersLabel.Location = new System.Drawing.Point(22, 303);
            this.runnersLabel.Name = "runnersLabel";
            this.runnersLabel.Size = new System.Drawing.Size(146, 22);
            this.runnersLabel.TabIndex = 50;
            this.runnersLabel.Text = "Всего бегунов: ";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Arial", 14.25F);
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.searchButton.Location = new System.Drawing.Point(708, 209);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(73, 29);
            this.searchButton.TabIndex = 40;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButt_Click);
            // 
            // sexComboBox
            // 
            this.sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexComboBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.sexComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Location = new System.Drawing.Point(518, 172);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(184, 30);
            this.sexComboBox.TabIndex = 49;
            // 
            // ageComboBox
            // 
            this.ageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ageComboBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.ageComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ageComboBox.FormattingEnabled = true;
            this.ageComboBox.Location = new System.Drawing.Point(518, 206);
            this.ageComboBox.Name = "ageComboBox";
            this.ageComboBox.Size = new System.Drawing.Size(184, 30);
            this.ageComboBox.TabIndex = 48;
            // 
            // distanceComboBox
            // 
            this.distanceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.distanceComboBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.distanceComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.distanceComboBox.FormattingEnabled = true;
            this.distanceComboBox.Location = new System.Drawing.Point(191, 206);
            this.distanceComboBox.Name = "distanceComboBox";
            this.distanceComboBox.Size = new System.Drawing.Size(198, 30);
            this.distanceComboBox.TabIndex = 47;
            // 
            // marathonComboBox
            // 
            this.marathonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marathonComboBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.marathonComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.marathonComboBox.FormattingEnabled = true;
            this.marathonComboBox.Location = new System.Drawing.Point(191, 175);
            this.marathonComboBox.Name = "marathonComboBox";
            this.marathonComboBox.Size = new System.Drawing.Size(198, 30);
            this.marathonComboBox.TabIndex = 46;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.ageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ageLabel.Location = new System.Drawing.Point(415, 209);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(104, 22);
            this.ageLabel.TabIndex = 45;
            this.ageLabel.Text = "Категория:";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.sexLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sexLabel.Location = new System.Drawing.Point(465, 175);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(49, 22);
            this.sexLabel.TabIndex = 44;
            this.sexLabel.Text = "Пол:";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.distanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.distanceLabel.Location = new System.Drawing.Point(84, 209);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(107, 22);
            this.distanceLabel.TabIndex = 43;
            this.distanceLabel.Text = "Дистанция:";
            // 
            // marathonLabel
            // 
            this.marathonLabel.AutoSize = true;
            this.marathonLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.marathonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.marathonLabel.Location = new System.Drawing.Point(95, 175);
            this.marathonLabel.Name = "marathonLabel";
            this.marathonLabel.Size = new System.Drawing.Size(98, 22);
            this.marathonLabel.TabIndex = 42;
            this.marathonLabel.Text = "Марафон:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Arial", 21.75F);
            this.resultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.resultLabel.Location = new System.Drawing.Point(231, 91);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(420, 33);
            this.resultLabel.TabIndex = 41;
            this.resultLabel.Text = "Результаты предыдущих гонок";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
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
            this.upPanel.TabIndex = 71;
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
            // downPanel
            // 
            this.downPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.downPanel.Controls.Add(this.timerLabel);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 565);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(850, 60);
            this.downPanel.TabIndex = 72;
            // 
            // raceAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 625);
            this.Controls.Add(this.upPanel);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.timeNumberLabel);
            this.Controls.Add(this.finishNumberLabel);
            this.Controls.Add(this.runnerNumberLabel);
            this.Controls.Add(this.raceDataGrid);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.finishLabel);
            this.Controls.Add(this.runnersLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.ageComboBox);
            this.Controls.Add(this.distanceComboBox);
            this.Controls.Add(this.marathonComboBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.marathonLabel);
            this.Controls.Add(this.resultLabel);
            this.MaximumSize = new System.Drawing.Size(866, 664);
            this.MinimumSize = new System.Drawing.Size(866, 664);
            this.Name = "raceAllForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - Previous race results";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.raceAllForm_FormClosing);
            this.Load += new System.EventHandler(this.raceAllForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.raceDataGrid)).EndInit();
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            this.downPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeNumberLabel;
        private System.Windows.Forms.Label finishNumberLabel;
        private System.Windows.Forms.Label runnerNumberLabel;
        private System.Windows.Forms.DataGridView raceDataGrid;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label finishLabel;
        private System.Windows.Forms.Label runnersLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.ComboBox ageComboBox;
        private System.Windows.Forms.ComboBox distanceComboBox;
        private System.Windows.Forms.ComboBox marathonComboBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label marathonLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Panel downPanel;
    }
}