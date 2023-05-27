﻿using Kadeka.Controller;
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
            menuPanel.Visible = false;
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
            List<Product> products = MenuIteractions.loadProducts("products.txt");
            Dictionary<String, Table> tables = new Dictionary<String, Table>();
            int x = 20;
            int y = 20;
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    Button button = new Button();
                    button.Text = (1 + i) + "-" + (j + 1);
                    button.Font = new Font("Tahoma", 14, FontStyle.Bold);
                    button.BackColor = Color.LimeGreen;
                    button.ForeColor = Color.White;
                    button.FlatStyle = FlatStyle.Popup;
                    button.Size = new Size(150, 110);
                    button.Location = new Point(x, y);
                    button.Click += (s, e) =>
                    {
                        //MessageBox.Show(products[0].name);
                        menuPanel.Visible = true;

                        menuPanel.BorderStyle = BorderStyle.Fixed3D;
                    };
                    tables.Add(button.Text, new Table());
                    tablePanel.Controls.Add(button);

                    x += 240;
                }
                x = 20;
                y += 156;
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

        private void goBackButton_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = false;
            tablePanel.Visible = true;
        }
    }
}
