using Kadeka.Controller;
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
            goBackButton.Width = 50;
            goBackButton.Height = 50;
            goBackButton.Location = new Point(1080, 20);
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
            this.Visible = false;
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            Dictionary<String, Table> tables = new Dictionary<String, Table>();
            int x = 20;
            int y = 20;
            int tableID = 2000, selected_tableID, orderID = 4000;
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
                    Table table = new Table(++tableID);
                    tables.Add(button.Text, table);
                    tablePanel.Controls.Add(button);
                    button.Click += (s, e) =>
                    {
                        menuPanel.Visible = true;
                        menuPanel.BorderStyle = BorderStyle.Fixed3D;
                        selected_tableID = table.getId();
                        Order order = new Order(orderID, 0, " ");
                        table.setOrder(order);
                        table.setState(Model.State.occupied);
                        button.BackColor = Color.OrangeRed;
                    };


                    x += 240;
                }
                x = 20;
                y += 156;
            }

            List<Product> products = MenuInteractions.loadProducts("products.txt");
            Dictionary<String, Product> productsDict = new Dictionary<String, Product>();
            x = y = 20;
            int m = -1, total = 0;
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    m++;
                    if (m == products.Count)
                        break;
                    Button button = new Button();
                    button.Text = products[m].getName() + "\n" + products[m].getPrice() + "$\n" + products[m].getMainType() + " / " + products[m].getSubType();
                    button.Font = new Font("Tahoma", 8, FontStyle.Bold);
                    button.BackColor = midcolor;
                    button.ForeColor = bgcolor;
                    button.FlatStyle = FlatStyle.Popup;
                    button.Size = new Size(150, 110);
                    button.Location = new Point(x, y);
                    productsDict.Add(products[m].getID().ToString(), products[m]);
                    menuPanel.Controls.Add(button);
                    button.Click += (s, e) =>
                    {

                    };
                    x += 180;
                }
                x = 20;
                y += 120;
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

        private void showReportsButton_Click(object sender, EventArgs e)
        {

        }
    }
}