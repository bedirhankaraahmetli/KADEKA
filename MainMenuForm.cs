using System;
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
            showFilesButton.BackColor = fgcolor;
            showFilesButton.ForeColor = bgcolor;
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

        private void showFilesButton_MouseEnter(object sender, EventArgs e)
        {
            showFilesButton.BackColor = midcolor;
        }

        private void showFilesButton_MouseLeave(object sender, EventArgs e)
        {
            showFilesButton.BackColor = fgcolor;
        }

        private void showFilesButton_Click(object sender, EventArgs e)
        {
            PasswordForm passwordForm = new PasswordForm();
            passwordForm.Show();
        }
    }
}
