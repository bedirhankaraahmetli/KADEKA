using Kadeka.Controller;
using Kadeka.Model;
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
        List<Button> tableButtons = new List<Button>();
        List<Button> productButtons = new List<Button>();
        Dictionary<int, Table> tables = new Dictionary<int, Table>();
        List<Product> products = MenuInteractions.loadProducts("products.txt");
        Dictionary<String, Product> productsDict = new Dictionary<String, Product>();

        public MainMenuForm()
        {
            InitializeComponent();
            this.BackColor = bgcolor;
            logOutButton.BackColor = fgcolor;
            logOutButton.ForeColor = bgcolor;
            showReportsButton.BackColor = fgcolor;
            showReportsButton.ForeColor = bgcolor;
            dateTimeLabel.Text = DateTime.Now.ToLongDateString();
            goBackButton.Visible = false;
            paymentButton.Visible = false;
            reserveButton.Visible = false;
            nameLabel.Text = "Bedo BABA";
            orderLabel.Text = "";
            totalPriceLabel.Text = "";
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
            int x = 300;
            int y = 120;
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
                    tables.Add(table.getId(), table);
                    button.Width = 150;
                    button.Height = 100;
                    Controls.Add(button);
                    tableButtons.Add(button);
                    button.Click += (s, e) =>
                    {
                        paymentButton.Visible = true;
                        reserveButton.Visible = true;
                        goBackButton.Visible = true;
                        foreach (Button b in tableButtons)
                        {
                            b.Visible = false;
                        }
                        button.Visible = false;
                        selected_tableID = table.getId();
                        if (table.getOrder() == null)
                            table.setOrder(new Order(orderID, 0, " "));

                        table.setState(Model.State.occupied);
                        button.BackColor = Color.OrangeRed;
                        showProducts(selected_tableID);
                    };


                    x += 200;
                }
                x = 300;
                y += 156;
            }




        }
        public void showProducts(int selected_tableID)
        {
            PrintOrder(tables[selected_tableID].getOrder());
            int x = 300;
            int y = 120;
            int m = -1;
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
                    if (!productsDict.ContainsKey(button.Text))
                        productsDict.Add(button.Text, products[m]);
                    productButtons.Add(button);
                    Controls.Add(button);

                    button.Click += (s, e) =>
                    {
                        Order order = tables[selected_tableID].getOrder();
                        List<Product> product = order.getProductList();
                        product.Add(productsDict[button.Text]);
                        float price = productsDict[button.Text].getPrice();
                        order.setTotalPrice(order.getTotalPrice() + price);
                        orderLabel.Text += productsDict[button.Text].getName().ToString() + ": " + productsDict[button.Text].getPrice().ToString() + "\n";
                        totalPriceLabel.Text = order.getTotalPrice().ToString();
                    };

                    x += 180;
                }
                x = 300;
                y += 120;
            }
        }
        private void PrintOrder(Order order)
        {
            foreach (Product product in order.getProductList())
                orderLabel.Text += product.getName().ToString() + ": " + product.getPrice().ToString() + "\n";

            totalPriceLabel.Text = order.getTotalPrice().ToString();
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
            foreach (Button b in tableButtons)
            {
                b.Visible = true;
                orderLabel.Text = "";
                totalPriceLabel.Text = "";
            }
            foreach (Button b in productButtons)
            {
                b.Visible = false;
            }
            goBackButton.Visible = false;
            reserveButton.Visible = false;
            paymentButton.Visible = false;
        }

        private void showReportsButton_Click(object sender, EventArgs e)
        {

        }

        private void orderLabel_TextChanged(object sender, EventArgs e)
        {
            orderLabel.Update();
        }
    }
}