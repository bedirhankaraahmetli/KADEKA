namespace Kadeka
{
    partial class LoginForm
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
            loginButton = new Button();
            userNameTextBox = new TextBox();
            userNameLabel = new Label();
            passWordLabel = new Label();
            passwordTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            exitButton = new Button();
            usernamePanel = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            usernamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginButton.BackColor = Color.Wheat;
            loginButton.BackgroundImageLayout = ImageLayout.None;
            loginButton.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Popup;
            loginButton.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.Location = new Point(547, 324);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(228, 54);
            loginButton.TabIndex = 3;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            loginButton.MouseEnter += loginButton_MouseEnter;
            loginButton.MouseLeave += loginButton_MouseLeave;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userNameTextBox.BackColor = SystemColors.Window;
            userNameTextBox.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            userNameTextBox.ForeColor = SystemColors.WindowText;
            userNameTextBox.Location = new Point(547, 164);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.PlaceholderText = "Enter Username";
            userNameTextBox.Size = new Size(311, 38);
            userNameTextBox.TabIndex = 1;
            userNameTextBox.TextChanged += userNameTextBox_TextChanged;
            // 
            // userNameLabel
            // 
            userNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            userNameLabel.Location = new Point(3, 16);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(154, 31);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "Username :";
            // 
            // passWordLabel
            // 
            passWordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passWordLabel.AutoSize = true;
            passWordLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            passWordLabel.Location = new Point(374, 241);
            passWordLabel.Name = "passWordLabel";
            passWordLabel.Size = new Size(149, 31);
            passWordLabel.TabIndex = 3;
            passWordLabel.Text = "Password :";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.BackColor = SystemColors.Window;
            passwordTextBox.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(547, 241);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Enter Password";
            passwordTextBox.ShortcutsEnabled = false;
            passwordTextBox.Size = new Size(311, 38);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.kadeka_logo_transparent;
            pictureBox1.InitialImage = Properties.Resources.kadeka_logo;
            pictureBox1.Location = new Point(-229, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(876, 542);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.LightCoral;
            exitButton.FlatStyle = FlatStyle.Popup;
            exitButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.Location = new Point(793, 489);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(83, 38);
            exitButton.TabIndex = 6;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // usernamePanel
            // 
            usernamePanel.BackColor = Color.Transparent;
            usernamePanel.BorderStyle = BorderStyle.Fixed3D;
            usernamePanel.Controls.Add(userNameLabel);
            usernamePanel.Location = new Point(364, 149);
            usernamePanel.Name = "usernamePanel";
            usernamePanel.Size = new Size(512, 67);
            usernamePanel.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(364, 222);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 67);
            panel1.TabIndex = 8;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(888, 539);
            Controls.Add(passWordLabel);
            Controls.Add(exitButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(loginButton);
            Controls.Add(usernamePanel);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kadeka";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            usernamePanel.ResumeLayout(false);
            usernamePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private TextBox userNameTextBox;
        private Label userNameLabel;
        private Label passWordLabel;
        private TextBox passwordTextBox;
        private PictureBox pictureBox1;
        private Button exitButton;
        private Panel usernamePanel;
        private Panel panel1;
    }
}