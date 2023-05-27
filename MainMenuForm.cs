using Kadeka.Model.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kadeka
{
    public partial class MainMenuForm : Form
    {
        Color bgcolor = Color.FromArgb(242, 237, 215);
        Color fgcolor = Color.FromArgb(117, 81, 57);
        Color midcolor = Color.FromArgb(148, 103, 73);
        public MainMenuForm()
        {
            InitializeComponent();
            this.BackColor = bgcolor;
            logOutButton.BackColor = fgcolor;
            logOutButton.ForeColor = bgcolor;
            showReportsButton.BackColor = fgcolor;
            showReportsButton.ForeColor = bgcolor;
            tableButton1.BackColor = midcolor;
            dateTimeLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void logOutButton_MouseEnter(object sender, EventArgs e)
        {
            logOutButton.BackColor = midcolor;
        }

        private void logOutButton_MouseLeave(object sender, EventArgs e)
        {
            logOutButton.BackColor = fgcolor;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Point point = tableButton1.Location;

            for (int i = 0; i < 5; i++)
            {
                if (i % 6 == 0)
                {
                    i = 0;

                }
                Button button = new Button();
                button.Text = "T-" + i.ToString();
                button.Font = tableButton1.Font;

                button.BackgroundImage = tableButton1.BackgroundImage;
                button.BackgroundImageLayout = ImageLayout.Zoom;
                button.Size = new Size(154, 110);
                button.BackColor = midcolor;
                button.ForeColor = Color.Black;
                button.Location = new System.Drawing.Point(point.X + 100, point.Y + 100);
                tablePanel.Controls.Add(button);

            }
        }

        private void showReportsButton_MouseLeave(object sender, EventArgs e)
        {
            showReportsButton.BackColor = fgcolor;
        }

        private void showReportsButton_MouseEnter(object sender, EventArgs e)
        {
            showReportsButton.BackColor = midcolor;
        }
    }
}
