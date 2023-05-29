namespace Kadeka
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
            pictureBox1 = new PictureBox();
            dateTimeLabel = new Label();
            logOutButton = new Button();
            shiftTimeLabel = new Label();
            showReportsButton = new Button();
            nameLabel = new Label();
            goBackButton = new Button();
            orderLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.kadeka_logo_transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 92);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.BackColor = Color.Transparent;
            dateTimeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeLabel.Location = new Point(109, 39);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(57, 30);
            dateTimeLabel.TabIndex = 1;
            dateTimeLabel.Text = "Date";
            // 
            // logOutButton
            // 
            logOutButton.FlatStyle = FlatStyle.Popup;
            logOutButton.Location = new Point(1271, 31);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(77, 55);
            logOutButton.TabIndex = 2;
            logOutButton.Text = "LOG OUT";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            logOutButton.MouseEnter += logOutButton_MouseEnter;
            logOutButton.MouseLeave += logOutButton_MouseLeave;
            // 
            // shiftTimeLabel
            // 
            shiftTimeLabel.AutoSize = true;
            shiftTimeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            shiftTimeLabel.Location = new Point(1138, 39);
            shiftTimeLabel.Name = "shiftTimeLabel";
            shiftTimeLabel.Size = new Size(106, 30);
            shiftTimeLabel.TabIndex = 3;
            shiftTimeLabel.Text = "Shift Time";
            // 
            // showReportsButton
            // 
            showReportsButton.FlatStyle = FlatStyle.Popup;
            showReportsButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            showReportsButton.Location = new Point(971, 27);
            showReportsButton.Name = "showReportsButton";
            showReportsButton.Size = new Size(148, 55);
            showReportsButton.TabIndex = 4;
            showReportsButton.Text = "Show Reports";
            showReportsButton.UseVisualStyleBackColor = true;
            showReportsButton.Click += showReportsButton_MouseLeave;
            showReportsButton.MouseEnter += showReportsButton_MouseEnter;
            showReportsButton.MouseLeave += showReportsButton_MouseLeave;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(488, 39);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(217, 37);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name - Surname";
            // 
            // goBackButton
            // 
            goBackButton.BackColor = SystemColors.ActiveCaption;
            goBackButton.Location = new Point(1252, 92);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(106, 24);
            goBackButton.TabIndex = 0;
            goBackButton.Text = "BACK";
            goBackButton.UseVisualStyleBackColor = false;
            goBackButton.Click += goBackButton_Click;
            // 
            // orderLabel
            // 
            orderLabel.AutoSize = true;
            orderLabel.Location = new Point(32, 156);
            orderLabel.Name = "orderLabel";
            orderLabel.Size = new Size(38, 15);
            orderLabel.TabIndex = 6;
            orderLabel.Text = "label1";
            orderLabel.TextChanged += orderLabel_TextChanged;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1370, 735);
            Controls.Add(orderLabel);
            Controls.Add(dateTimeLabel);
            Controls.Add(goBackButton);
            Controls.Add(logOutButton);
            Controls.Add(shiftTimeLabel);
            Controls.Add(showReportsButton);
            Controls.Add(nameLabel);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenuForm";
            Load += MainMenuForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label dateTimeLabel;
        private Button logOutButton;
        private Label shiftTimeLabel;
        private Button showReportsButton;
        private Label nameLabel;
        private Button goBackButton;
        private Label orderLabel;
    }
}