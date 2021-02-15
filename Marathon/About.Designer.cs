
namespace Marathon
{
    partial class aboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutForm));
            this.infoLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.downPanel = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.upPanel = new System.Windows.Forms.Panel();
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.mapPictureBox = new System.Windows.Forms.PictureBox();
            this.info1PictureBox = new System.Windows.Forms.PictureBox();
            this.info3PictureBox = new System.Windows.Forms.PictureBox();
            this.info4PictureBox = new System.Windows.Forms.PictureBox();
            this.info2PictureBox = new System.Windows.Forms.PictureBox();
            this.downPanel.SuspendLayout();
            this.upPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info4PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info2PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.infoLabel.Location = new System.Drawing.Point(118, 91);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(628, 42);
            this.infoLabel.TabIndex = 14;
            this.infoLabel.Text = "Информация о Marathon Skills 2021";
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
            this.downPanel.TabIndex = 13;
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
            this.upPanel.Controls.Add(this.backButton);
            this.upPanel.Controls.Add(this.headerLabel);
            this.upPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upPanel.Location = new System.Drawing.Point(0, 0);
            this.upPanel.Name = "upPanel";
            this.upPanel.Size = new System.Drawing.Size(850, 69);
            this.upPanel.TabIndex = 12;
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.aboutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.aboutTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.aboutTextBox.Location = new System.Drawing.Point(386, 152);
            this.aboutTextBox.Multiline = true;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.ReadOnly = true;
            this.aboutTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.aboutTextBox.Size = new System.Drawing.Size(442, 397);
            this.aboutTextBox.TabIndex = 15;
            this.aboutTextBox.Text = resources.GetString("aboutTextBox.Text");
            // 
            // mapPictureBox
            // 
            this.mapPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.mapPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("mapPictureBox.Image")));
            this.mapPictureBox.Location = new System.Drawing.Point(34, 152);
            this.mapPictureBox.Name = "mapPictureBox";
            this.mapPictureBox.Size = new System.Drawing.Size(314, 191);
            this.mapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapPictureBox.TabIndex = 71;
            this.mapPictureBox.TabStop = false;
            this.mapPictureBox.Click += new System.EventHandler(this.mapPictureBox_Click);
            // 
            // info1PictureBox
            // 
            this.info1PictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.info1PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("info1PictureBox.Image")));
            this.info1PictureBox.Location = new System.Drawing.Point(34, 349);
            this.info1PictureBox.Name = "info1PictureBox";
            this.info1PictureBox.Size = new System.Drawing.Size(152, 97);
            this.info1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.info1PictureBox.TabIndex = 72;
            this.info1PictureBox.TabStop = false;
            // 
            // info3PictureBox
            // 
            this.info3PictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.info3PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("info3PictureBox.Image")));
            this.info3PictureBox.Location = new System.Drawing.Point(34, 452);
            this.info3PictureBox.Name = "info3PictureBox";
            this.info3PictureBox.Size = new System.Drawing.Size(152, 97);
            this.info3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.info3PictureBox.TabIndex = 73;
            this.info3PictureBox.TabStop = false;
            // 
            // info4PictureBox
            // 
            this.info4PictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.info4PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("info4PictureBox.Image")));
            this.info4PictureBox.Location = new System.Drawing.Point(196, 452);
            this.info4PictureBox.Name = "info4PictureBox";
            this.info4PictureBox.Size = new System.Drawing.Size(152, 97);
            this.info4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.info4PictureBox.TabIndex = 75;
            this.info4PictureBox.TabStop = false;
            // 
            // info2PictureBox
            // 
            this.info2PictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.info2PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("info2PictureBox.Image")));
            this.info2PictureBox.Location = new System.Drawing.Point(196, 349);
            this.info2PictureBox.Name = "info2PictureBox";
            this.info2PictureBox.Size = new System.Drawing.Size(152, 97);
            this.info2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.info2PictureBox.TabIndex = 74;
            this.info2PictureBox.TabStop = false;
            // 
            // aboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 625);
            this.Controls.Add(this.info4PictureBox);
            this.Controls.Add(this.info2PictureBox);
            this.Controls.Add(this.info3PictureBox);
            this.Controls.Add(this.info1PictureBox);
            this.Controls.Add(this.mapPictureBox);
            this.Controls.Add(this.aboutTextBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.upPanel);
            this.MaximumSize = new System.Drawing.Size(866, 664);
            this.MinimumSize = new System.Drawing.Size(866, 664);
            this.Name = "aboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - About Marathon Skills 2021";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.aboutForm_FormClosing);
            this.downPanel.ResumeLayout(false);
            this.upPanel.ResumeLayout(false);
            this.upPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info4PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info2PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel upPanel;
        private System.Windows.Forms.TextBox aboutTextBox;
        private System.Windows.Forms.PictureBox mapPictureBox;
        private System.Windows.Forms.PictureBox info1PictureBox;
        private System.Windows.Forms.PictureBox info3PictureBox;
        private System.Windows.Forms.PictureBox info4PictureBox;
        private System.Windows.Forms.PictureBox info2PictureBox;
        private System.Windows.Forms.Label timerLabel;
    }
}