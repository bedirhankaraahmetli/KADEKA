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
            this.tablePanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.goBackButton = new System.Windows.Forms.Button();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.showReportsButton = new System.Windows.Forms.Button();
            this.shiftTimeLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paymentPanel = new System.Windows.Forms.Panel();
            this.tablePanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel
            // 
            this.tablePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tablePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePanel.Controls.Add(this.menuPanel);
            this.tablePanel.Location = new System.Drawing.Point(246, 148);
            this.tablePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(1314, 825);
            this.tablePanel.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuPanel.Controls.Add(this.goBackButton);
            this.menuPanel.Location = new System.Drawing.Point(-2, -3);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1314, 825);
            this.menuPanel.TabIndex = 0;
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.goBackButton.Location = new System.Drawing.Point(1135, 20);
            this.goBackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(154, 68);
            this.goBackButton.TabIndex = 0;
            this.goBackButton.Text = "BACK";
            this.goBackButton.UseVisualStyleBackColor = false;
            // 
            // infoPanel
            // 
            this.infoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoPanel.Controls.Add(this.nameLabel);
            this.infoPanel.Controls.Add(this.showReportsButton);
            this.infoPanel.Controls.Add(this.shiftTimeLabel);
            this.infoPanel.Controls.Add(this.logOutButton);
            this.infoPanel.Controls.Add(this.dateTimeLabel);
            this.infoPanel.Controls.Add(this.pictureBox1);
            this.infoPanel.Location = new System.Drawing.Point(14, 16);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1546, 123);
            this.infoPanel.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(502, 35);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(273, 46);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name - Surname";
            // 
            // showReportsButton
            // 
            this.showReportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showReportsButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showReportsButton.Location = new System.Drawing.Point(1055, 24);
            this.showReportsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showReportsButton.Name = "showReportsButton";
            this.showReportsButton.Size = new System.Drawing.Size(169, 73);
            this.showReportsButton.TabIndex = 4;
            this.showReportsButton.Text = "Show Reports";
            this.showReportsButton.UseVisualStyleBackColor = true;
            this.showReportsButton.Click += new System.EventHandler(this.showReportsButton_Click);
            // 
            // shiftTimeLabel
            // 
            this.shiftTimeLabel.AutoSize = true;
            this.shiftTimeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shiftTimeLabel.Location = new System.Drawing.Point(1263, 43);
            this.shiftTimeLabel.Name = "shiftTimeLabel";
            this.shiftTimeLabel.Size = new System.Drawing.Size(135, 37);
            this.shiftTimeLabel.TabIndex = 3;
            this.shiftTimeLabel.Text = "Shift Time";
            // 
            // logOutButton
            // 
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logOutButton.Location = new System.Drawing.Point(1434, 24);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(88, 73);
            this.logOutButton.TabIndex = 2;
            this.logOutButton.Text = "LOG OUT";
            this.logOutButton.UseVisualStyleBackColor = true;
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateTimeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeLabel.Location = new System.Drawing.Point(144, 43);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(73, 37);
            this.dateTimeLabel.TabIndex = 1;
            this.dateTimeLabel.Text = "Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Kadeka.Properties.Resources.kadeka_logo_transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 123);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // paymentPanel
            // 
            this.paymentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paymentPanel.Location = new System.Drawing.Point(14, 148);
            this.paymentPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.paymentPanel.Name = "paymentPanel";
            this.paymentPanel.Size = new System.Drawing.Size(225, 503);
            this.paymentPanel.TabIndex = 1;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1566, 980);
            this.Controls.Add(this.paymentPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.tablePanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuForm";
            this.tablePanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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