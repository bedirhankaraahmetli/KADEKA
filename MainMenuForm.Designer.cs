﻿namespace Kadeka
{
    partial class MainMenuForm
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
            tablePanel = new Panel();
            menuPanel = new Panel();
            goBackButton = new Button();
            infoPanel = new Panel();
            nameLabel = new Label();
            showReportsButton = new Button();
            shiftTimeLabel = new Label();
            logOutButton = new Button();
            dateTimeLabel = new Label();
            pictureBox1 = new PictureBox();
            paymentPanel = new Panel();
            tablePanel.SuspendLayout();
            menuPanel.SuspendLayout();
            infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tablePanel
            // 
            tablePanel.BackgroundImageLayout = ImageLayout.None;
            tablePanel.BorderStyle = BorderStyle.Fixed3D;
            tablePanel.Controls.Add(menuPanel);
            tablePanel.Location = new Point(215, 111);
            tablePanel.Name = "tablePanel";
            tablePanel.Size = new Size(1150, 620);
            tablePanel.TabIndex = 0;
            // 
            // menuPanel
            // 
            menuPanel.BorderStyle = BorderStyle.Fixed3D;
            menuPanel.Controls.Add(goBackButton);
            menuPanel.Location = new Point(-2, -2);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(1150, 620);
            menuPanel.TabIndex = 0;
            // 
            // goBackButton
            // 
            goBackButton.BackColor = SystemColors.ActiveCaption;
            goBackButton.Location = new Point(993, 15);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(135, 51);
            goBackButton.TabIndex = 0;
            goBackButton.Text = "BACK";
            goBackButton.UseVisualStyleBackColor = false;
            goBackButton.Click += goBackButton_Click;
            // 
            // infoPanel
            // 
            infoPanel.BorderStyle = BorderStyle.Fixed3D;
            infoPanel.Controls.Add(nameLabel);
            infoPanel.Controls.Add(showReportsButton);
            infoPanel.Controls.Add(shiftTimeLabel);
            infoPanel.Controls.Add(logOutButton);
            infoPanel.Controls.Add(dateTimeLabel);
            infoPanel.Controls.Add(pictureBox1);
            infoPanel.Location = new Point(12, 12);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(1353, 93);
            infoPanel.TabIndex = 0;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(439, 26);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(217, 37);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name - Surname";
            // 
            // showReportsButton
            // 
            showReportsButton.FlatStyle = FlatStyle.Popup;
            showReportsButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            showReportsButton.Location = new Point(923, 18);
            showReportsButton.Name = "showReportsButton";
            showReportsButton.Size = new Size(148, 55);
            showReportsButton.TabIndex = 4;
            showReportsButton.Text = "Show Reports";
            showReportsButton.UseVisualStyleBackColor = true;
            showReportsButton.Click += showReportsButton_MouseLeave;
            showReportsButton.MouseEnter += showReportsButton_MouseEnter;
            showReportsButton.MouseLeave += showReportsButton_MouseLeave;
            // 
            // shiftTimeLabel
            // 
            shiftTimeLabel.AutoSize = true;
            shiftTimeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            shiftTimeLabel.Location = new Point(1105, 32);
            shiftTimeLabel.Name = "shiftTimeLabel";
            shiftTimeLabel.Size = new Size(106, 30);
            shiftTimeLabel.TabIndex = 3;
            shiftTimeLabel.Text = "Shift Time";
            // 
            // logOutButton
            // 
            logOutButton.FlatStyle = FlatStyle.Popup;
            logOutButton.Location = new Point(1255, 18);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(77, 55);
            logOutButton.TabIndex = 2;
            logOutButton.Text = "LOG OUT";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            logOutButton.MouseEnter += logOutButton_MouseEnter;
            logOutButton.MouseLeave += logOutButton_MouseLeave;
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.BackColor = Color.Transparent;
            dateTimeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeLabel.Location = new Point(126, 32);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(57, 30);
            dateTimeLabel.TabIndex = 1;
            dateTimeLabel.Text = "Date";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.kadeka_logo_transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 92);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // paymentPanel
            // 
            paymentPanel.BorderStyle = BorderStyle.Fixed3D;
            paymentPanel.Location = new Point(12, 111);
            paymentPanel.Name = "paymentPanel";
            paymentPanel.Size = new Size(197, 378);
            paymentPanel.TabIndex = 1;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1370, 735);
            Controls.Add(paymentPanel);
            Controls.Add(infoPanel);
            Controls.Add(tablePanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenuForm";
            Load += MainMenuForm_Load;
            tablePanel.ResumeLayout(false);
            menuPanel.ResumeLayout(false);
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel tablePanel;
        private Panel infoPanel;
        private Panel paymentPanel;
        private PictureBox pictureBox1;
        private Label dateTimeLabel;
        private Button logOutButton;
        private Label shiftTimeLabel;
        private Button showReportsButton;
        private Label nameLabel;
        private Panel menuPanel;
        private Button goBackButton;
    }
}