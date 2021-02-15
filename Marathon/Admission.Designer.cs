
namespace Marathon
{
    partial class admissionForm
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
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.downPanel = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.upPanel = new System.Windows.Forms.Panel();
            this.idLabel = new System.Windows.Forms.Label();
            this.rfidLabel = new System.Windows.Forms.Label();
            this.baseballCapLabel = new System.Windows.Forms.Label();
            this.waterLabel = new System.Windows.Forms.Label();
            this.tshirtLabel = new System.Windows.Forms.Label();
            this.souvenirLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.admissionLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rfidTextBox = new System.Windows.Forms.MaskedTextBox();
            this.baseballTextBox = new System.Windows.Forms.MaskedTextBox();
            this.waterTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tshirtTextBox = new System.Windows.Forms.MaskedTextBox();
            this.souvenirTextBox = new System.Windows.Forms.MaskedTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.downPanel.SuspendLayout();
            this.upPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.inventoryLabel.Location = new System.Drawing.Point(224, 93);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(431, 42);
            this.inventoryLabel.TabIndex = 54;
            this.inventoryLabel.Text = "Поступление инвентаря";
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
            // downPanel
            // 
            this.downPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.downPanel.Controls.Add(this.timerLabel);
            this.downPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downPanel.Location = new System.Drawing.Point(0, 565);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(850, 60);
            this.downPanel.TabIndex = 53;
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
            this.upPanel.TabIndex = 52;
            // 
            // idLabel
            // 
            this.idLabel.BackColor = System.Drawing.Color.LightGray;
            this.idLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.idLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.idLabel.Location = new System.Drawing.Point(63, 218);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(183, 30);
            this.idLabel.TabIndex = 55;
            this.idLabel.Text = "Номер бегуна";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rfidLabel
            // 
            this.rfidLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.rfidLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rfidLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.rfidLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.rfidLabel.Location = new System.Drawing.Point(63, 248);
            this.rfidLabel.Name = "rfidLabel";
            this.rfidLabel.Size = new System.Drawing.Size(183, 30);
            this.rfidLabel.TabIndex = 56;
            this.rfidLabel.Text = "RFID браслет";
            this.rfidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // baseballCapLabel
            // 
            this.baseballCapLabel.BackColor = System.Drawing.Color.LightGray;
            this.baseballCapLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseballCapLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.baseballCapLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.baseballCapLabel.Location = new System.Drawing.Point(63, 278);
            this.baseballCapLabel.Name = "baseballCapLabel";
            this.baseballCapLabel.Size = new System.Drawing.Size(183, 30);
            this.baseballCapLabel.TabIndex = 57;
            this.baseballCapLabel.Text = "Бейсболка";
            this.baseballCapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // waterLabel
            // 
            this.waterLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.waterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.waterLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.waterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.waterLabel.Location = new System.Drawing.Point(63, 308);
            this.waterLabel.Name = "waterLabel";
            this.waterLabel.Size = new System.Drawing.Size(183, 30);
            this.waterLabel.TabIndex = 58;
            this.waterLabel.Text = "Бутылка воды";
            this.waterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tshirtLabel
            // 
            this.tshirtLabel.BackColor = System.Drawing.Color.LightGray;
            this.tshirtLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tshirtLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.tshirtLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tshirtLabel.Location = new System.Drawing.Point(63, 338);
            this.tshirtLabel.Name = "tshirtLabel";
            this.tshirtLabel.Size = new System.Drawing.Size(183, 30);
            this.tshirtLabel.TabIndex = 59;
            this.tshirtLabel.Text = "Футболка";
            this.tshirtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // souvenirLabel
            // 
            this.souvenirLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.souvenirLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.souvenirLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.souvenirLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.souvenirLabel.Location = new System.Drawing.Point(63, 368);
            this.souvenirLabel.Name = "souvenirLabel";
            this.souvenirLabel.Size = new System.Drawing.Size(183, 30);
            this.souvenirLabel.TabIndex = 60;
            this.souvenirLabel.Text = "Сувенирный буклет";
            this.souvenirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.DarkGray;
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nameLabel.Location = new System.Drawing.Point(63, 188);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(183, 30);
            this.nameLabel.TabIndex = 61;
            this.nameLabel.Text = "Наименование";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // admissionLabel
            // 
            this.admissionLabel.BackColor = System.Drawing.Color.DarkGray;
            this.admissionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.admissionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.admissionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.admissionLabel.Location = new System.Drawing.Point(246, 188);
            this.admissionLabel.Name = "admissionLabel";
            this.admissionLabel.Size = new System.Drawing.Size(183, 30);
            this.admissionLabel.TabIndex = 62;
            this.admissionLabel.Text = "Поступление";
            this.admissionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Arial", 14.5F);
            this.idTextBox.Location = new System.Drawing.Point(246, 218);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(183, 30);
            this.idTextBox.TabIndex = 63;
            // 
            // rfidTextBox
            // 
            this.rfidTextBox.Font = new System.Drawing.Font("Arial", 14.5F);
            this.rfidTextBox.Location = new System.Drawing.Point(246, 248);
            this.rfidTextBox.Name = "rfidTextBox";
            this.rfidTextBox.Size = new System.Drawing.Size(183, 30);
            this.rfidTextBox.TabIndex = 64;
            // 
            // baseballTextBox
            // 
            this.baseballTextBox.Font = new System.Drawing.Font("Arial", 14.5F);
            this.baseballTextBox.Location = new System.Drawing.Point(246, 278);
            this.baseballTextBox.Name = "baseballTextBox";
            this.baseballTextBox.Size = new System.Drawing.Size(183, 30);
            this.baseballTextBox.TabIndex = 65;
            // 
            // waterTextBox
            // 
            this.waterTextBox.Font = new System.Drawing.Font("Arial", 14.5F);
            this.waterTextBox.Location = new System.Drawing.Point(246, 308);
            this.waterTextBox.Name = "waterTextBox";
            this.waterTextBox.Size = new System.Drawing.Size(183, 30);
            this.waterTextBox.TabIndex = 66;
            // 
            // tshirtTextBox
            // 
            this.tshirtTextBox.Font = new System.Drawing.Font("Arial", 14.5F);
            this.tshirtTextBox.Location = new System.Drawing.Point(246, 338);
            this.tshirtTextBox.Name = "tshirtTextBox";
            this.tshirtTextBox.Size = new System.Drawing.Size(183, 30);
            this.tshirtTextBox.TabIndex = 67;
            // 
            // souvenirTextBox
            // 
            this.souvenirTextBox.Font = new System.Drawing.Font("Arial", 14.5F);
            this.souvenirTextBox.Location = new System.Drawing.Point(246, 368);
            this.souvenirTextBox.Name = "souvenirTextBox";
            this.souvenirTextBox.Size = new System.Drawing.Size(183, 30);
            this.souvenirTextBox.TabIndex = 68;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.saveButton.Location = new System.Drawing.Point(175, 460);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(138, 30);
            this.saveButton.TabIndex = 75;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // admissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 625);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.souvenirTextBox);
            this.Controls.Add(this.tshirtTextBox);
            this.Controls.Add(this.waterTextBox);
            this.Controls.Add(this.baseballTextBox);
            this.Controls.Add(this.rfidTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.admissionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.souvenirLabel);
            this.Controls.Add(this.tshirtLabel);
            this.Controls.Add(this.waterLabel);
            this.Controls.Add(this.baseballCapLabel);
            this.Controls.Add(this.rfidLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.upPanel);
            this.MaximumSize = new System.Drawing.Size(866, 664);
            this.MinimumSize = new System.Drawing.Size(866, 664);
            this.Name = "admissionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.admissionForm_FormClosing);
            this.downPanel.ResumeLayout(false);
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label rfidLabel;
        private System.Windows.Forms.Label baseballCapLabel;
        private System.Windows.Forms.Label waterLabel;
        private System.Windows.Forms.Label tshirtLabel;
        private System.Windows.Forms.Label souvenirLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label admissionLabel;
        private System.Windows.Forms.MaskedTextBox idTextBox;
        private System.Windows.Forms.MaskedTextBox rfidTextBox;
        private System.Windows.Forms.MaskedTextBox baseballTextBox;
        private System.Windows.Forms.MaskedTextBox waterTextBox;
        private System.Windows.Forms.MaskedTextBox tshirtTextBox;
        private System.Windows.Forms.MaskedTextBox souvenirTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label timerLabel;
    }
}