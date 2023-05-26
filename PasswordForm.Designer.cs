namespace Kadeka
{
    partial class PasswordForm
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
            enterPasswordLabel = new Label();
            passwordTextBox = new TextBox();
            passwordButton = new Button();
            SuspendLayout();
            // 
            // enterPasswordLabel
            // 
            enterPasswordLabel.AutoSize = true;
            enterPasswordLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            enterPasswordLabel.Location = new Point(66, 40);
            enterPasswordLabel.Name = "enterPasswordLabel";
            enterPasswordLabel.Size = new Size(332, 25);
            enterPasswordLabel.TabIndex = 0;
            enterPasswordLabel.Text = "Enter a password to do this  operation";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(99, 77);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Enter a password";
            passwordTextBox.Size = new Size(273, 35);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordButton
            // 
            passwordButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            passwordButton.Location = new Point(133, 130);
            passwordButton.Name = "passwordButton";
            passwordButton.Size = new Size(196, 46);
            passwordButton.TabIndex = 2;
            passwordButton.Text = "Enter";
            passwordButton.UseVisualStyleBackColor = true;
            passwordButton.MouseEnter += passwordButton_MouseEnter;
            passwordButton.MouseLeave += passwordButton_MouseLeave;
            // 
            // PasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 206);
            Controls.Add(passwordButton);
            Controls.Add(passwordTextBox);
            Controls.Add(enterPasswordLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label enterPasswordLabel;
        private TextBox textBox1;
        private Button passwordButton;
        private TextBox passwordTextBox;
    }
}