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
using System.Xml.Serialization;

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
        LoginForm loginForm;
        EmployeeAC user;

        int currentTable = 0;

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
            totalPriceLabel.Text = "";
        }
        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            CreateTableButtons();
        }
        private void CreateTableButtons()
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
                            table.setOrder(new Order(++orderID, 0));

                        currentTable = selected_tableID;
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
            ShowOrder();
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
                        if (tables[selected_tableID].getState() == State.available)
                        {
                            tables[selected_tableID].getOrder().setOrderDate(DateTime.Now);
                        }
                        Order order = tables[selected_tableID].getOrder();
                        List<Product> product = order.getProductList();
                        product.Add(productsDict[button.Text]);
                        float price = productsDict[button.Text].getPrice();
                        order.setTotalPrice(order.getTotalPrice() + price);
                        CreateProductButton(productsDict[button.Text], product, selected_tableID);
                        //orderLabel.Text += productsDict[button.Text].getName().ToString() + ": " + productsDict[button.Text].getPrice().ToString() + "\n";
                        totalPriceLabel.Text = order.getTotalPrice().ToString();
                    };

                    x += 180;
                }
                x = 300;
                y += 120;
            }
        }
        private void ShowOrder()
        {
            foreach (Button btn in tables[currentTable].getButtons())
            {
                btn.Visible = true;
            }
        }
        private void CreateProductButton(Product product, List<Product> products, int selected_tableID)
        {
            int x = 20, y = 100;
            int newY = products.Count * 25 + y;
            Button btn = new Button();
            btn.Text = String.Format("{0,-25}:{1,5}", product.getName().Trim(), product.getPrice());
            btn.Location = new Point(x, newY);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.BackColor = Color.LightPink;
            btn.FlatStyle = FlatStyle.Flat;

            btn.Width = 200;
            btn.Height = 30;
            btn.Click += (s, e) =>
            {
                products.Remove(product);
                Controls.Remove(btn);
                btn.Visible = false;
                tables[selected_tableID].getOrder().setTotalPrice(tables[selected_tableID].getOrder().getTotalPrice() - product.getPrice());
                totalPriceLabel.Text = tables[selected_tableID].getOrder().getTotalPrice().ToString();
                tables[selected_tableID].getButtons().Remove(btn);
                if (tables[selected_tableID].getButtons().Count > 0)
                {
                    int index = 1;
                    foreach (Button button in tables[selected_tableID].getButtons())
                    {
                        int newY = index * 25 + y;
                        button.Location = new Point(x, newY);
                        index++;
                    }
                }
            };
            tables[selected_tableID].getButtons().Add(btn);
            Controls.Add(btn);

        }
        private void PrintOrder(Order order)
        {
            foreach (Product product in order.getProductList())
                //orderLabel.Text += product.getName().ToString() + ": " + product.getPrice().ToString() + "\n";

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
            for (int i = 0; i < tableButtons.Count; i++)
            {
                if (tables[2001 + i].getOrder() != null && tables[2001 + i].getOrder().getProductList().Count > 0)
                {
                    tables[2001 + i].setState(Model.State.occupied);
                    tableButtons[i].BackColor = Color.OrangeRed;
                }
            }
            foreach (Button btn in tables[currentTable].getButtons())
            {
                btn.Visible = false;
            }
            foreach (Button b in tableButtons)
            {
                b.Visible = true;
                //orderLabel.Text = "";
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
            ShowReport();
        }
        private void orderLabel_TextChanged(object sender, EventArgs e)
        {
            //orderLabel.Update();
        }
        private void reserveButton_Click(object sender, EventArgs e)
        {
            if (tables[currentTable].getState() == Model.State.reserved)
            {
                tables[currentTable].setState(Model.State.available);
                tableButtons[currentTable - 2001].BackColor = Color.LimeGreen;
            }
            else
            {
                tables[currentTable].setState(Model.State.reserved);
                tableButtons[currentTable - 2001].BackColor = Color.Orange;
            }
        }
        public void SetNameLabel(string name)
        {
            nameLabel.Text = name;

        }
        public void SetLoginForm(LoginForm form)
        {
            loginForm = form;
        }
        public void SetUser(EmployeeAC User)
        {
            user = User;

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
            WriteReport();
            loginForm.Show();
            loginForm.SetMenuForm(this);
            this.Visible = false;
        }
        private void ShowReport()
        {
            File.AppendAllText("employeeReport.txt", "");
            File.AppendAllText("orderReport.txt", "");
            if (user.GetType() == typeof(Manager))
            {
                string report = File.ReadAllText("employeeReport.txt");
                string report2 = File.ReadAllText("orderReport.txt");
                MessageBox.Show("------WAITER SHIFT INFO------\n" + report + "\n------ORDER INFO------\n" + report2);
            }
            else
            {
                MessageBox.Show("Unauthorized Interaction");
            }
        }
        private void WriteReport()
        {
            if (user.GetType() != typeof(Manager))
            {
                String path = "employeeReport.txt";
                File.AppendAllText(path, " ");
                TimeSpan diff = DateTime.Now.Subtract(user.getShiftStartTime());
                string report = user.getName() + " " + user.getLastName() + " -> Start Date: " + user.getShiftStartTime() + " - " + DateTime.Now + " Time: " + diff.Hours + ":" + diff.Minutes + ":" + diff.Seconds + "\n";
                File.AppendAllText(path, report);
            }
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            
            string report = tables[currentTable].getOrder().getID() + " -> Time: " + tables[currentTable].getOrder().getOrderDate() + " Total Price: " + tables[currentTable].getOrder().getTotalPrice() + "\n";
            File.AppendAllText("orderReport.txt", report);
            foreach (Button btn in tables[currentTable].getButtons())
            {
                Controls.Remove(btn);
            }
            tables[currentTable].Clear();
            totalPriceLabel.Text = tables[currentTable].getOrder().getTotalPrice().ToString();
            tableButtons[currentTable - 2001].BackColor = Color.LimeGreen;
        }


    }

}