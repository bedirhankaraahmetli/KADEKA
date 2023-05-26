﻿using System;
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
    public partial class LoginForm : Form
    {
        Color fgcolor = Color.FromArgb(117, 81, 57);
        Color bgcolor = Color.FromArgb(242, 237, 215);
        Color midcolor = Color.FromArgb(148, 103, 73);
        public static string username;
        public LoginForm()
        {
            InitializeComponent();
            this.BackColor = bgcolor;
            loginButton.BackColor = fgcolor;
            loginButton.ForeColor = bgcolor;
            exitButton.ForeColor = bgcolor;
        }


        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            loginButton.BackColor = midcolor;
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            loginButton.BackColor = fgcolor;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            MainMenuForm menu = new MainMenuForm();

            String username = userNameTextBox.Text;
            String password = passwordTextBox.Text;
            
            if (username == "admin" && password == "admin" || true)
            {
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password! Try Again!");
            }
        }

        public void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            String username = userNameTextBox.Text;

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            String password = passwordTextBox.Text;
        }
    }
}
